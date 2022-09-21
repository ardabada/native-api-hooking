using System;

namespace NativeApiHooking.Common.Disasm
{
    internal static partial class DisASMx86
    {
        private static int modeConfig_addrSize = 32;
        private static int modeConfig_operSize = 32;
        private static string config_notation = "INT";

        public static Prefix[] ParsePrefixes(byte[] buf, int offset)
        {
            byte source = buf[offset];

            Prefixes.TryGetValue(source, out Prefix value);
            if (value is null) return new Prefix[0];
            return new Prefix[1] { value };
        }

        public static Opcode ParseOperation(byte[] buf, int offset, Prefix[] prefixes)
        {
            Opcode operation = null;

            for (int i = 0; i < X86Opcodes.Opcodes.Length; ++i)
            {
                var op = X86Opcodes.Opcodes[i];
                if (operation != null && op.Seq.Length < operation.Seq.Length) continue;

                int j = 0;
                for (; j < op.Seq.Length; ++j)
                {
                    if (op.Seq[j] != buf[offset + j]) break;
                }

                if (j != op.Seq.Length)
                {
                    if (op.operands == null || op.operands.Length == 0) continue;

                    var operand = op.operands[0];
                    if (string.IsNullOrEmpty(operand.A) || operand.A.IndexOf('Z') == -1) continue;

                    if (op.Seq[j] != (buf[offset + j] & 0xF8)) continue; // Check operands for register indicator
                }

                if ((op.OpExt != null || op.OpExt == 0) && op.OpExt != getReg(buf[offset + (op.Seq[0] == 0x0F ? 2 : 1)])) continue;

                operation = op;
            }

            if (operation == null) throw new InvalidOperationException(string.Format("Unknown assembly opcode ({0:x}).", buf[offset]));

            return operation;
        }

        public static ParsedInstruction ParseInstruction(byte[] buf, int offset)
        {
            if (offset < 0) offset = 0;
            var preOffset = offset;

            var prefixes = ParsePrefixes(buf, offset);
            offset += prefixes.Length;

            var operation = ParseOperation(buf, offset, prefixes);
            offset += operation.Seq.Length;

            var operands = operation.operands != null ? new string[operation.operands.Length] : Array.Empty<string>();

            var ownOffset = offset;
            var sharedLen = 0;
            ParseTypeDto info;
            for (int i = 0; i < operands.Length; i++)
            {
                if (operation.operands[i].A != null)
                {
                    info = parseType(operation.operands[i].A, buf, offset, ownOffset + sharedLen, operation, operation.operands[i].T);
                    operands[i] = info.Str;
                    sharedLen = sharedLen > info.SharedLen ? sharedLen : info.SharedLen;
                    ownOffset += info.OwnLen;
                }
                else if (operation.operands[i].R != null)
                {
                    switch (operation.operands[i].T)
                    {
                        case "b":
                            operands[i] = operation.operands[i].R[getRegisterMode(8, operation.InstrExt)];
                            break;
                        case "vqp":
                            operands[i] = operation.operands[i].R[getRegisterMode(modeConfig_operSize, operation.InstrExt)];
                            break;
                        case "w":
                            operands[i] = operation.operands[i].R[getRegisterMode(16, operation.InstrExt)];
                            break;
                        default:
                            throw new InvalidOperationException("Unknown register type " + operation.operands[i].T);
                    }
                }
                else
                {
                    throw new InvalidOperationException("Unknown operand");
                }
            }
            offset = sharedLen + ownOffset;

            return new ParsedInstruction
            {
                Prefixes = prefixes,
                Operation = operation,
                Operands = operands,
                Length = offset - preOffset
            };
        }

        private static int getReg(int b) => (b >> 3) & 7;

        private static int getMod(int b) => b >> 6;

        private static int getRm(int b) => b & 7;

        private static Sib parseSib(int b) => new Sib
        {
            Scale = b >> 6,
            Index = (b >> 3) & 7,
            Base = b & 7
        };

        private static string getRegisterMode(int size, string instrExt)
        {
            if (instrExt == null)
            {
                if (size == 80) return "s80";
                else return "r" + size;
            }
            else if (instrExt == "mmx" && size == 64) return "mm";
            else if (instrExt == "sse" && size == 128) return "xmm";

            throw new InvalidOperationException("Unknown register mode");
        }

        private static string formatHexNumber(int num)
        {
            if (config_notation == "INT")
                return string.Format("{0}0x{1:X}h", num < 0 ? "-" : "", Math.Abs(num));
            else if (config_notation == "AT&T")
                return string.Format("{0}0x{1}", num < 0 ? "-" : "", Math.Abs(num));
            throw new InvalidOperationException("Invalid notation");
        }

        private static int parseNumber(byte[] buf, int offset, int bytes)
        {
            double num = 0;
            for (int i = 0; i < bytes; i++)
            {
                num += Math.Pow(2, 8 * i) * buf[offset + i];
            }

            var max = Math.Pow(2, bytes * 8);
            if (num > max / 2 - 1)
            {
                num -= max;
            }

            return (int)num;
        }

        private static ModRmDto parseModRM(int b, int? regOffset = null)
        {
            var dest = DisASMx86.Registers[getReg(b) + (regOffset ?? 0)];
            int? displ = null;
            var adrOf = true;
            var sib = false;
            Register regData = null;

            var mod = getMod(b);
            switch (mod)
            {
                case 1:
                    displ = 1;
                    break;
                case 2:
                    displ = 2;
                    break;
                case 3:
                    adrOf = false;
                    break;
            }

            var reg = getRm(b);
            switch (reg)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 6:
                case 7:
                    regData = DisASMx86.Registers[reg];
                    break;
                case 4:
                    if (mod != 3)
                    {
                        sib = true;
                    }
                    else
                    {
                        regData = DisASMx86.Registers[reg];
                    }
                    break;
                case 5:
                    if (mod == 0)
                    {
                        displ = 2;
                    }
                    else
                    {
                        regData = DisASMx86.Registers[reg];
                    }
                    break;
            }
            return new ModRmDto
            {
                Src = new ModRmSource
                {
                    Reg = regData,
                    Displ = displ,
                    AdrOf = adrOf,
                    Sib = sib
                },
                Dest = dest
            };
        }

        private static ParseTypeDto parseType(string type, byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            switch (type)
            {
                case "E": return parseTypeE(buf, sharedOffset, ownOffset, operation, opSize);
                case "EST": return parseTypeEST(buf, sharedOffset, ownOffset, operation, opSize);
                case "G": return parseTypeG(buf, sharedOffset, ownOffset, operation, opSize);
                case "I": return parseTypeI(buf, sharedOffset, ownOffset, operation, opSize);
                case "J": return parseTypeJ(buf, sharedOffset, ownOffset, operation, opSize);
                case "M": return parseTypeM(buf, sharedOffset, ownOffset, operation, opSize);
                case "O": return parseTypeO(buf, sharedOffset, ownOffset, operation, opSize);
                case "S": return parseTypeS(buf, sharedOffset, ownOffset, operation, opSize);
                case "Z": return parseTypeZ(buf, sharedOffset, ownOffset, operation, opSize);
                default: throw new InvalidOperationException("Unknown operand type");
            }
        }

        private static ParseTypeDto parseTypeE(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var modRm = parseModRM(buf[sharedOffset]);
            var len = 1;

            var str = "";
            if (modRm.Src.Sib)
            {
                var sib = parseSib(buf[sharedOffset + len]);

                if (sib.Scale != 0)
                {
                    str = " " + DisASMx86.Registers[sib.Index].R32 + " * " + (1 << sib.Scale);
                }
                str += " " + DisASMx86.Registers[sib.Base].R32 + " ";

                len++;
            }
            else if (modRm.Src.Reg != null)
            {
                str = " " + modRm.Src.Reg[getRegisterMode(modeConfig_operSize, operation.InstrExt)] + " ";  //FIXME: Register must be size dependent
            }

            if (modRm.Src.Displ != null && modRm.Src.Displ == 1)
            {
                str += "+ " + formatHexNumber(parseNumber(buf, sharedOffset + len, 1));
                ++len;
            }
            else if (modRm.Src.Displ != null && modRm.Src.Displ == 2)
            {
                str += "+ " + formatHexNumber(parseNumber(buf, sharedOffset + len, modeConfig_operSize / 8));
                len += modeConfig_operSize / 8;
            }

            str = str.Substring(1);
            if (modRm.Src.AdrOf) str = "[" + str + "]";

            return new ParseTypeDto { Str = str, SharedLen = len, OwnLen = 0 };
        }

        private static ParseTypeDto parseTypeEST(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var modRm = parseModRM(buf[sharedOffset], 14);

            return new ParseTypeDto
            {
                Str = modRm.Dest[getRegisterMode(80, operation.InstrExt)],
                SharedLen = 1,
                OwnLen = 0
            };
        }

        private static ParseTypeDto parseTypeG(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var modRm = parseModRM(buf[sharedOffset]);
            int size;
            switch (opSize)
            {
                case "v":
                case "vqp":
                case "vds":
                    size = modeConfig_operSize == 32 ? 32 : 16;
                    break;
                case "b":
                    size = 8;
                    break;
                default:
                    throw new InvalidOperationException("Unknown opsize " + opSize);
            }

            return new ParseTypeDto
            {
                Str = modRm.Dest[getRegisterMode(size, operation.InstrExt)],
                SharedLen = 1,
                OwnLen = 0
            };
        }

        private static ParseTypeDto parseTypeI(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            int size;

            switch (opSize)
            {
                case "b":
                case "bs":
                case "bss":
                    size = 8;
                    break;
                case "v":
                case "vs":
                case "vqp":
                case "vds":
                    size = modeConfig_operSize == 32 ? 32 : 16;
                    break;
                case "w":
                    size = 16;
                    break;
                default:
                    throw new InvalidOperationException("Unknown opsize " + opSize);
            }

            return new ParseTypeDto
            {
                Str = "+ " + formatHexNumber(parseNumber(buf, ownOffset, size / 8)),
                OwnLen = size / 8,
                SharedLen = 0
            };
        }

        private static ParseTypeDto parseTypeJ(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            int size;
            switch (opSize)
            {
                case "v":
                case "vqp":
                case "vds":
                    size = modeConfig_operSize == 32 ? 32 : 16;
                    break;
                case "bs":
                    size = 8;
                    break;
                default:
                    throw new InvalidOperationException("Unknown opsize " + opSize);
            }

            var num = parseNumber(buf, ownOffset, size / 8);
            return new ParseTypeDto
            {
                Str = formatHexNumber(num),
                OwnLen = size / 8,
                SharedLen = 0
            };
        }

        private static ParseTypeDto parseTypeM(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var modRm = parseModRM(buf[sharedOffset]);
            var len = 1;

            var str = "";
            if (modRm.Src.Sib)
            {
                var sib = parseSib(buf[sharedOffset + len]);

                if (sib.Scale != 0)
                {
                    str = " " + DisASMx86.Registers[sib.Index].R32 + " * " + (1 << sib.Scale);
                }
                str += " " + DisASMx86.Registers[sib.Base].R32 + " ";

                len++;
            }
            else if (modRm.Src.Reg != null)
            {
                str = " " + modRm.Src.Reg[getRegisterMode(modeConfig_operSize, operation.InstrExt)] + " ";
            }

            if (modRm.Src.Displ != null && modRm.Src.Displ == 1)
            {
                str += "+ " + formatHexNumber(parseNumber(buf, sharedOffset + len, 1));
                ++len;
            }
            else if (modRm.Src.Displ != null && modRm.Src.Displ == 2)
            {
                str += "+ " + formatHexNumber(parseNumber(buf, sharedOffset + len, modeConfig_operSize / 8));
                len += modeConfig_operSize / 8;
            }

            str = str.Substring(1);
            if (modRm.Src.AdrOf) str = "[" + str + "]";

            return new ParseTypeDto { Str = str, OwnLen = 0, SharedLen = len };
        }
        private static ParseTypeDto parseTypeO(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var num = parseNumber(buf, ownOffset, modeConfig_addrSize / 8);
            return new ParseTypeDto
            {
                Str = formatHexNumber(num),
                OwnLen = modeConfig_addrSize / 8,
                SharedLen = 0
            };
        }
        private static ParseTypeDto parseTypeS(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var modRm = parseModRM(buf[sharedOffset], 8);
            int size;

            switch (opSize)
            {
                case "b":
                    size = 8;
                    break;
                case "v":
                case "vqp":
                case "vds":
                    size = modeConfig_operSize == 32 ? 32 : 16;
                    break;
                case "w":
                    size = 16;
                    break;
                default:
                    throw new InvalidOperationException("Unknown opsize " + opSize);
            }

            return new ParseTypeDto
            {
                Str = modRm.Dest[getRegisterMode(size, operation.InstrExt)],
                SharedLen = 1,
                OwnLen = 0
            };
        }
        private static ParseTypeDto parseTypeZ(byte[] buf, int sharedOffset, int ownOffset, Opcode operation, string opSize)
        {
            var reg = buf[sharedOffset - operation.Seq.Length] & 7;

            int size;
            switch (opSize)
            {
                case "v":
                case "vqp":
                    size = modeConfig_operSize == 32 ? 32 : 16;
                    break;
                case "b":
                    size = 8;
                    break;
                default:
                    throw new InvalidOperationException("Unknown opsize " + opSize);
            }

            return new ParseTypeDto
            {
                Str = DisASMx86.Registers[reg][getRegisterMode(size, operation.InstrExt)],
                OwnLen = 0,
                SharedLen = 0
            };
        }

        private class ModRmDto
        {
            public ModRmSource Src { get; set; }
            public Register Dest { get; set; }
        }
        private class ModRmSource
        {
            public Register Reg { get; set; }
            public int? Displ { get; set; }
            public bool AdrOf { get; set; }
            public bool Sib { get; set; }
        }
        private class Sib
        {
            public int Scale { get; set; }
            public int Index { get; set; }
            public int Base { get; set; }
        }
        private class ParseTypeDto
        {
            public string Str { get; set; }
            public int SharedLen { get; set; }
            public int OwnLen { get; set; }
        }
    }
}
