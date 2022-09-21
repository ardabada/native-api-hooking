namespace NativeApiHooking.Common.Disasm
{
    internal static partial class DisASMx86
    {
        internal static class X86Opcodes
        {
            public static readonly Opcode[] Opcodes = new Opcode[]
            {
            new Opcode {
                Seq = new byte[] {0x00},
                Mnem = "ADD",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x01},
                Mnem = "ADD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x02},
                Mnem = "ADD",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x03},
                Mnem = "ADD",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x04},
                Mnem = "ADD",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x05},
                Mnem = "ADD",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x06},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[11], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x07},
                Mnem = "POP",
                operands = new[] { new Operand {R = DisASMx86.Registers[11], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x08},
                Mnem = "OR",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x09},
                Mnem = "OR",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0A},
                Mnem = "OR",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0B},
                Mnem = "OR",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0C},
                Mnem = "OR",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0D},
                Mnem = "OR",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0E},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[8], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x10},
                Mnem = "ADC",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x11},
                Mnem = "ADC",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x12},
                Mnem = "ADC",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x13},
                Mnem = "ADC",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x14},
                Mnem = "ADC",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x15},
                Mnem = "ADC",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x16},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[10], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x17},
                Mnem = "POP",
                operands = new[] { new Operand {R = DisASMx86.Registers[10], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x18},
                Mnem = "SBB",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x19},
                Mnem = "SBB",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x1A},
                Mnem = "SBB",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x1B},
                Mnem = "SBB",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x1C},
                Mnem = "SBB",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x1D},
                Mnem = "SBB",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x1E},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[9], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x1F},
                Mnem = "POP",
                operands = new[] { new Operand {R = DisASMx86.Registers[9], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x20},
                Mnem = "AND",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x21},
                Mnem = "AND",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x22},
                Mnem = "AND",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x23},
                Mnem = "AND",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x24},
                Mnem = "AND",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x25},
                Mnem = "AND",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x26},
                Mnem = "ES"
            },
            new Opcode {
                Seq = new byte[] {0x27},
                Mnem = "DAA"
            },
            new Opcode {
                Seq = new byte[] {0x28},
                Mnem = "SUB",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x29},
                Mnem = "SUB",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x2A},
                Mnem = "SUB",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x2B},
                Mnem = "SUB",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x2C},
                Mnem = "SUB",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x2D},
                Mnem = "SUB",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x2E},
                Mnem = "CS"
            },
            new Opcode {
                Seq = new byte[] {0x2E},
                Mnem = "NTAKEN"
            },
            new Opcode {
                Seq = new byte[] {0x2F},
                Mnem = "DAS"
            },
            new Opcode {
                Seq = new byte[] {0x30},
                Mnem = "XOR",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x31},
                Mnem = "XOR",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x32},
                Mnem = "XOR",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x33},
                Mnem = "XOR",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x34},
                Mnem = "XOR",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x35},
                Mnem = "XOR",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x36},
                Mnem = "SS"
            },
            new Opcode {
                Seq = new byte[] {0x37},
                Mnem = "AAA"
            },
            new Opcode {
                Seq = new byte[] {0x38},
                Mnem = "CMP",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x39},
                Mnem = "CMP",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x3A},
                Mnem = "CMP",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x3B},
                Mnem = "CMP",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x3C},
                Mnem = "CMP",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x3D},
                Mnem = "CMP",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x3E},
                Mnem = "DS"
            },
            new Opcode {
                Seq = new byte[] {0x3E},
                Mnem = "TAKEN"
            },
            new Opcode {
                Seq = new byte[] {0x3F},
                Mnem = "AAS"
            },
            new Opcode {
                Seq = new byte[] {0x40},
                Mnem = "INC",
                operands = new[] { new Operand {A = "Z", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x48},
                Mnem = "DEC",
                operands = new[] { new Operand {A = "Z", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x50},
                Mnem = "PUSH",
                operands = new[] { new Operand {A = "Z", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x58},
                Mnem = "POP",
                operands = new[] { new Operand {A = "Z", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x60},
                Mnem = "PUSHA"
            },
            new Opcode {
                Seq = new byte[] {0x60},
                Mnem = "PUSHAD"
            },
            new Opcode {
                Seq = new byte[] {0x61},
                Mnem = "POPA"
            },
            new Opcode {
                Seq = new byte[] {0x61},
                Mnem = "POPAD"
            },
            new Opcode {
                Seq = new byte[] {0x62},
                Mnem = "BOUND",
                operands = new[] { new Operand {A = "G", T = "v"}, new Operand {A = "M", T = "a"} }
            },
            new Opcode {
                Seq = new byte[] {0x63},
                Mnem = "ARPL",
                operands = new[] { new Operand {A = "E", T = "w"}, new Operand {A = "G", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x64},
                Mnem = "FS"
            },
            new Opcode {
                Seq = new byte[] {0x64},
                Mnem = "ALTER"
            },
            new Opcode {
                Seq = new byte[] {0x65},
                Mnem = "GS"
            },
            new Opcode {
                Seq = new byte[] {0x68},
                Mnem = "PUSH",
                operands = new[] { new Operand {A = "I", T = "vs"} }
            },
            new Opcode {
                Seq = new byte[] {0x69},
                Mnem = "IMUL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x6A},
                Mnem = "PUSH",
                operands = new[] { new Operand {A = "I", T = "bss"} }
            },
            new Opcode {
                Seq = new byte[] {0x6B},
                Mnem = "IMUL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x6C},
                Mnem = "INS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x6D},
                Mnem = "INS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x6D},
                Mnem = "INS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x6E},
                Mnem = "OUTS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x6F},
                Mnem = "OUTS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x6F},
                Mnem = "OUTS",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x70},
                Mnem = "JO",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x71},
                Mnem = "JNO",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x72},
                Mnem = "JB",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x73},
                Mnem = "JNB",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x74},
                Mnem = "JZ",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x75},
                Mnem = "JNZ",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x76},
                Mnem = "JBE",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x77},
                Mnem = "JNBE",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x78},
                Mnem = "JS",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x79},
                Mnem = "JNS",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7A},
                Mnem = "JP",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7B},
                Mnem = "JNP",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7C},
                Mnem = "JL",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7D},
                Mnem = "JNL",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7E},
                Mnem = "JLE",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x7F},
                Mnem = "JNLE",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "ADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "OR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "ADC",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "SBB",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "AND",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "SUB",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "XOR",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x80},
                Mnem = "CMP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "ADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "OR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "ADC",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "SBB",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "AND",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "SUB",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "XOR",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x81},
                Mnem = "CMP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "ADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "OR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "ADC",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "SBB",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "AND",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "SUB",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "XOR",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x82},
                Mnem = "CMP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "ADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "OR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "ADC",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "SBB",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "AND",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "SUB",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "XOR",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x83},
                Mnem = "CMP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0x84},
                Mnem = "TEST",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x85},
                Mnem = "TEST",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x86},
                Mnem = "XCHG",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x87},
                Mnem = "XCHG",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x88},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x89},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x8A},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "G", T = "b"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x8B},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x8C},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "M", T = "w"}, new Operand {A = "S", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x8D},
                Mnem = "LEA",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0x8E},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "S", T = "w"}, new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x8F},
                Mnem = "POP",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x90},
                Mnem = "XCHG",
                operands = new[] { new Operand {A = "Z", T = "vqp"}, new Operand {R = DisASMx86.Registers[0], T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x90},
                Mnem = "NOP"
            },
            new Opcode {
                Seq = new byte[] {0x90},
                Mnem = "NOP"
            },
            new Opcode {
                Seq = new byte[] {0x90},
                Mnem = "PAUSE",
                InstrExt = "sse2"
            },
            new Opcode {
                Seq = new byte[] {0x98},
                Mnem = "CBW"
            },
            new Opcode {
                Seq = new byte[] {0x98},
                Mnem = "CWDE"
            },
            new Opcode {
                Seq = new byte[] {0x99},
                Mnem = "CWD"
            },
            new Opcode {
                Seq = new byte[] {0x99},
                Mnem = "CDQ"
            },
            new Opcode {
                Seq = new byte[] {0x9A},
                Mnem = "CALLF",
                operands = new[] { new Operand {A = "A", T = "p"} }
            },
            new Opcode {
                Seq = new byte[] {0x9B},
                Mnem = "FWAIT"
            },
            new Opcode {
                Seq = new byte[] {0x9C},
                Mnem = "PUSHF"
            },
            new Opcode {
                Seq = new byte[] {0x9C},
                Mnem = "PUSHFD"
            },
            new Opcode {
                Seq = new byte[] {0x9D},
                Mnem = "POPF"
            },
            new Opcode {
                Seq = new byte[] {0x9D},
                Mnem = "POPFD"
            },
            new Opcode {
                Seq = new byte[] {0x9E},
                Mnem = "SAHF"
            },
            new Opcode {
                Seq = new byte[] {0x9F},
                Mnem = "LAHF"
            },
            new Opcode {
                Seq = new byte[] {0xA0},
                Mnem = "MOV",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "O", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xA1},
                Mnem = "MOV",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "O", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xA2},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "O", T = "b"}, new Operand {R = DisASMx86.Registers[0], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xA3},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "O", T = "vqp"}, new Operand {R = DisASMx86.Registers[0], T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xA4},
                Mnem = "MOVS"
            },
            new Opcode {
                Seq = new byte[] {0xA5},
                Mnem = "MOVS"
            },
            new Opcode {
                Seq = new byte[] {0xA5},
                Mnem = "MOVS"
            },
            new Opcode {
                Seq = new byte[] {0xA6},
                Mnem = "CMPS"
            },
            new Opcode {
                Seq = new byte[] {0xA7},
                Mnem = "CMPS"
            },
            new Opcode {
                Seq = new byte[] {0xA7},
                Mnem = "CMPS"
            },
            new Opcode {
                Seq = new byte[] {0xA8},
                Mnem = "TEST",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xA9},
                Mnem = "TEST",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0xAA},
                Mnem = "STOS"
            },
            new Opcode {
                Seq = new byte[] {0xAB},
                Mnem = "STOS"
            },
            new Opcode {
                Seq = new byte[] {0xAB},
                Mnem = "STOS"
            },
            new Opcode {
                Seq = new byte[] {0xAC},
                Mnem = "LODS"
            },
            new Opcode {
                Seq = new byte[] {0xAD},
                Mnem = "LODS"
            },
            new Opcode {
                Seq = new byte[] {0xAD},
                Mnem = "LODS"
            },
            new Opcode {
                Seq = new byte[] {0xAE},
                Mnem = "SCAS"
            },
            new Opcode {
                Seq = new byte[] {0xAF},
                Mnem = "SCAS"
            },
            new Opcode {
                Seq = new byte[] {0xAF},
                Mnem = "SCAS"
            },
            new Opcode {
                Seq = new byte[] {0xB0},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "Z", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xB8},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "Z", T = "vqp"}, new Operand {A = "I", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC0},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC1},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC2},
                Mnem = "RETN",
                operands = new[] { new Operand {A = "I", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xC3},
                Mnem = "RETN"
            },
            new Opcode {
                Seq = new byte[] {0xC4},
                Mnem = "LES",
                operands = new[] { new Operand {A = "G", T = "v"}, new Operand {A = "M", T = "p"} }
            },
            new Opcode {
                Seq = new byte[] {0xC5},
                Mnem = "LDS",
                operands = new[] { new Operand {A = "G", T = "v"}, new Operand {A = "M", T = "p"} }
            },
            new Opcode {
                Seq = new byte[] {0xC6},
                Mnem = "MOV",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC7},
                Mnem = "MOV",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0xC8},
                Mnem = "ENTER",
                operands = new[] { new Operand {A = "I", T = "w"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xC9},
                Mnem = "LEAVE"
            },
            new Opcode {
                Seq = new byte[] {0xCA},
                Mnem = "RETF",
                operands = new[] { new Operand {A = "I", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xCB},
                Mnem = "RETF"
            },
            new Opcode {
                Seq = new byte[] {0xCC},
                Mnem = "INT"
            },
            new Opcode {
                Seq = new byte[] {0xCD},
                Mnem = "INT",
                operands = new[] { new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xCE},
                Mnem = "INTO"
            },
            new Opcode {
                Seq = new byte[] {0xCF},
                Mnem = "IRET"
            },
            new Opcode {
                Seq = new byte[] {0xCF},
                Mnem = "IRETD"
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD0},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD1},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD2},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "ROL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "ROR",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "RCL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "RCR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "SHL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "SHR",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "SAL",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD3},
                Mnem = "SAR",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD4, 0x0A},
                Mnem = "AAM"
            },
            new Opcode {
                Seq = new byte[] {0xD4},
                Mnem = "AMX",
                operands = new[] { new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD5, 0x0A},
                Mnem = "AAD"
            },
            new Opcode {
                Seq = new byte[] {0xD5},
                Mnem = "ADX",
                operands = new[] { new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xD6},
                Mnem = "SALC"
            },
            new Opcode {
                Seq = new byte[] {0xD7},
                Mnem = "XLAT"
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FMUL",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FCOM",
                OpExt = 2,
                operands = new[] { new Operand {A = "ES", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8, 0xD1},
                Mnem = "FCOM",
                OpExt = 2
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FCOMP",
                OpExt = 3,
                operands = new[] { new Operand {A = "ES", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8, 0xD9},
                Mnem = "FCOMP",
                OpExt = 3
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FSUB",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FSUBR",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FDIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD8},
                Mnem = "FDIVR",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FLD",
                OpExt = 0,
                operands = new[] { new Operand {A = "ES", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FXCH",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xC9},
                Mnem = "FXCH",
                OpExt = 1
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FST",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xD0},
                Mnem = "FNOP",
                OpExt = 2
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FSTP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "sr"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FSTP1",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FSTP1",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FLDENV",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "e"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE0},
                Mnem = "FCHS",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE1},
                Mnem = "FABS",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE4},
                Mnem = "FTST",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE5},
                Mnem = "FXAM",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FLDCW",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE8},
                Mnem = "FLD1",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xE9},
                Mnem = "FLDL2T",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xEA},
                Mnem = "FLDL2E",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xEB},
                Mnem = "FLDPI",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xEC},
                Mnem = "FLDLG2",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xED},
                Mnem = "FLDLN2",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xEE},
                Mnem = "FLDZ",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FNSTENV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "e"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FSTENV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "e"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF0},
                Mnem = "F2XM1",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF1},
                Mnem = "FYL2X",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF2},
                Mnem = "FPTAN",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF3},
                Mnem = "FPATAN",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF4},
                Mnem = "FXTRACT",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF5},
                Mnem = "FPREM1",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF6},
                Mnem = "FDECSTP",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF7},
                Mnem = "FINCSTP",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FNSTCW",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9},
                Mnem = "FSTCW",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF8},
                Mnem = "FPREM",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xF9},
                Mnem = "FYL2XP1",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFA},
                Mnem = "FSQRT",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFB},
                Mnem = "FSINCOS",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFC},
                Mnem = "FRNDINT",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFD},
                Mnem = "FSCALE",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFE},
                Mnem = "FSIN",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xD9, 0xFF},
                Mnem = "FCOS",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FIADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FCMOVB",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FIMUL",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FCMOVE",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FICOM",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FCMOVBE",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FICOMP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FCMOVU",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FISUB",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FISUBR",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA, 0xE9},
                Mnem = "FUCOMPP",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FIDIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDA},
                Mnem = "FIDIVR",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FILD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FCMOVNB",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FISTTP",
                OpExt = 1,
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FCMOVNE",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FIST",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FCMOVNBE",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FISTP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "di"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FCMOVNU",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE0},
                Mnem = "FNENI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE0},
                Mnem = "FENI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE0},
                Mnem = "FNENI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE1},
                Mnem = "FNDISI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE1},
                Mnem = "FDISI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE1},
                Mnem = "FNDISI",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE2},
                Mnem = "FNCLEX",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE2},
                Mnem = "FCLEX",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE3},
                Mnem = "FNINIT",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE3},
                Mnem = "FINIT",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE4},
                Mnem = "FNSETPM",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE4},
                Mnem = "FSETPM",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB, 0xE4},
                Mnem = "FNSETPM",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FLD",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "er"} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FUCOMI",
                OpExt = 5,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FCOMI",
                OpExt = 6,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDB},
                Mnem = "FSTP",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "er"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FMUL",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FMUL",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOM",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOM2",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOM2",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOMP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOMP3",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FCOMP3",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FSUB",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FSUBR",
                OpExt = 4,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FSUBR",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FSUB",
                OpExt = 5,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FDIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FDIVR",
                OpExt = 6,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FDIVR",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDC},
                Mnem = "FDIV",
                OpExt = 7,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FLD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FFREE",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FISTTP",
                OpExt = 1,
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "M", T = "qi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FXCH4",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FXCH4",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FST",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FST",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FSTP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "dr"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FSTP",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FRSTOR",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "st"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FUCOM",
                OpExt = 4,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD, 0xE1},
                Mnem = "FUCOM",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FUCOMP",
                OpExt = 5,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDD, 0xE9},
                Mnem = "FUCOMP",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FNSAVE",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "st"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FSAVE",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "st"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FNSTSW",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xDD},
                Mnem = "FSTSW",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FIADD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FADDP",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xC1},
                Mnem = "FADDP",
                OpExt = 0
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FIMUL",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FMULP",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xC9},
                Mnem = "FMULP",
                OpExt = 1
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FICOM",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FCOMP5",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FCOMP5",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FICOMP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xD9},
                Mnem = "FCOMPP",
                OpExt = 3
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FISUB",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FSUBRP",
                OpExt = 4,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xE1},
                Mnem = "FSUBRP",
                OpExt = 4
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FISUBR",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FSUBP",
                OpExt = 5,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xE9},
                Mnem = "FSUBP",
                OpExt = 5
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FIDIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FDIVRP",
                OpExt = 6,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xF1},
                Mnem = "FDIVRP",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FIDIVR",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDE},
                Mnem = "FDIVP",
                OpExt = 7,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDE, 0xF9},
                Mnem = "FDIVP",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FILD",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FFREEP",
                OpExt = 0,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FISTTP",
                OpExt = 1,
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FXCH7",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FXCH7",
                OpExt = 1,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FIST",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FSTP8",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FSTP8",
                OpExt = 2,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FISTP",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "wi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FSTP9",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FSTP9",
                OpExt = 3,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FBLD",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "bcd"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF, 0xE0},
                Mnem = "FNSTSW",
                OpExt = 4,
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF, 0xE0},
                Mnem = "FSTSW",
                OpExt = 4,
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FILD",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "qi"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FUCOMIP",
                OpExt = 5,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FBSTP",
                OpExt = 6,
                operands = new[] { new Operand {A = "M", T = "bcd"} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FCOMIP",
                OpExt = 6,
                operands = new[] { new Operand {A = "EST", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0xDF},
                Mnem = "FISTP",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = "qi"} }
            },
            new Opcode {
                Seq = new byte[] {0xE0},
                Mnem = "LOOPNZ",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0xE1},
                Mnem = "LOOPZ",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0xE2},
                Mnem = "LOOP",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0xE3},
                Mnem = "JCXZ",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0xE4},
                Mnem = "IN",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xE5},
                Mnem = "IN",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "v"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xE6},
                Mnem = "OUT",
                operands = new[] { new Operand {A = "I", T = "b"}, new Operand {R = DisASMx86.Registers[0], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xE7},
                Mnem = "OUT",
                operands = new[] { new Operand {A = "I", T = "b"}, new Operand {R = DisASMx86.Registers[0], T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0xE8},
                Mnem = "CALL",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0xE9},
                Mnem = "JMP",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0xEA},
                Mnem = "JMPF",
                operands = new[] { new Operand {A = "A", T = "p"} }
            },
            new Opcode {
                Seq = new byte[] {0xEB},
                Mnem = "JMP",
                operands = new[] { new Operand {A = "J", T = "bs"} }
            },
            new Opcode {
                Seq = new byte[] {0xEC},
                Mnem = "IN",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "b"}, new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xED},
                Mnem = "IN",
                operands = new[] { new Operand {R = DisASMx86.Registers[0], T = "v"}, new Operand {R = DisASMx86.Registers[2], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0xEE},
                Mnem = "OUT",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"}, new Operand {R = DisASMx86.Registers[0], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xEF},
                Mnem = "OUT",
                operands = new[] { new Operand {R = DisASMx86.Registers[2], T = "w"}, new Operand {R = DisASMx86.Registers[0], T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0xF0},
                Mnem = "LOCK"
            },
            new Opcode {
                Seq = new byte[] {0xF1},
                Mnem = "INT1"
            },
            new Opcode {
                Seq = new byte[] {0xF2},
                Mnem = "REPNZ"
            },
            new Opcode {
                Seq = new byte[] {0xF2},
                Mnem = "REP"
            },
            new Opcode {
                Seq = new byte[] {0xF3},
                Mnem = "REPZ"
            },
            new Opcode {
                Seq = new byte[] {0xF3},
                Mnem = "REP"
            },
            new Opcode {
                Seq = new byte[] {0xF4},
                Mnem = "HLT"
            },
            new Opcode {
                Seq = new byte[] {0xF5},
                Mnem = "CMC"
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "TEST",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "TEST",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "NOT",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "NEG",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "MUL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "IMUL",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "DIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF6},
                Mnem = "IDIV",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "TEST",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "TEST",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "NOT",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "NEG",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "MUL",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "IMUL",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "DIV",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF7},
                Mnem = "IDIV",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xF8},
                Mnem = "CLC"
            },
            new Opcode {
                Seq = new byte[] {0xF9},
                Mnem = "STC"
            },
            new Opcode {
                Seq = new byte[] {0xFA},
                Mnem = "CLI"
            },
            new Opcode {
                Seq = new byte[] {0xFB},
                Mnem = "STI"
            },
            new Opcode {
                Seq = new byte[] {0xFC},
                Mnem = "CLD"
            },
            new Opcode {
                Seq = new byte[] {0xFD},
                Mnem = "STD"
            },
            new Opcode {
                Seq = new byte[] {0xFE},
                Mnem = "INC",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xFE},
                Mnem = "DEC",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "INC",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "DEC",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "CALL",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "CALLF",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "ptp"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "JMP",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "JMPF",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = "ptp"} }
            },
            new Opcode {
                Seq = new byte[] {0xFF},
                Mnem = "PUSH",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "SLDT",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "STR",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "LLDT",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "LTR",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "VERR",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "VERW",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x00},
                Mnem = "JMPE",
                OpExt = 6
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "SGDT",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "s"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC1},
                Mnem = "VMCALL",
                OpExt = 0,
                InstrExt = "vmx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC2},
                Mnem = "VMLAUNCH",
                OpExt = 0,
                InstrExt = "vmx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC3},
                Mnem = "VMRESUME",
                OpExt = 0,
                InstrExt = "vmx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC4},
                Mnem = "VMXOFF",
                OpExt = 0,
                InstrExt = "vmx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "SIDT",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "s"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC8},
                Mnem = "MONITOR",
                OpExt = 1,
                InstrExt = "sse3"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xC9},
                Mnem = "MWAIT",
                OpExt = 1,
                InstrExt = "sse3"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "LGDT",
                OpExt = 2,
                operands = new[] { new Operand {A = "M", T = "s"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xD0},
                Mnem = "XGETBV",
                OpExt = 2
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xD1},
                Mnem = "XSETBV",
                OpExt = 2
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "LIDT",
                OpExt = 3,
                operands = new[] { new Operand {A = "M", T = "s"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "SMSW",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "LMSW",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01},
                Mnem = "INVLPG",
                OpExt = 7,
                operands = new[] { new Operand {A = "M", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x01, 0xF9},
                Mnem = "RDTSCP",
                OpExt = 7
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x02},
                Mnem = "LAR",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x03},
                Mnem = "LSL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x05},
                Mnem = "LOADALL"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x06},
                Mnem = "CLTS"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x07},
                Mnem = "LOADALL"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x08},
                Mnem = "INVD"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x09},
                Mnem = "WBINVD"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x0B},
                Mnem = "UD2"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x0D},
                Mnem = "NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x10},
                Mnem = "MOVUPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x10},
                Mnem = "MOVSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x10},
                Mnem = "MOVUPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x10},
                Mnem = "MOVSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x11},
                Mnem = "MOVUPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "W", T = "ps"}, new Operand {A = "V", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x11},
                Mnem = "MOVSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "W", T = "ss"}, new Operand {A = "V", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x11},
                Mnem = "MOVUPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "pd"}, new Operand {A = "V", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x11},
                Mnem = "MOVSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "sd"}, new Operand {A = "V", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x12},
                Mnem = "MOVHLPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "U", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x12},
                Mnem = "MOVLPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x12},
                Mnem = "MOVLPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x12},
                Mnem = "MOVDDUP",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x12},
                Mnem = "MOVSLDUP",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x13},
                Mnem = "MOVLPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "q"}, new Operand {A = "V", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x13},
                Mnem = "MOVLPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "q"}, new Operand {A = "V", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x14},
                Mnem = "UNPCKLPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x14},
                Mnem = "UNPCKLPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x15},
                Mnem = "UNPCKHPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x15},
                Mnem = "UNPCKHPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x16},
                Mnem = "MOVLHPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "U", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x16},
                Mnem = "MOVHPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x16},
                Mnem = "MOVHPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x16},
                Mnem = "MOVSHDUP",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x17},
                Mnem = "MOVHPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "q"}, new Operand {A = "V", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x17},
                Mnem = "MOVHPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "q"}, new Operand {A = "V", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "PREFETCHNTA",
                OpExt = 0,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "PREFETCHT0",
                OpExt = 1,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "PREFETCHT1",
                OpExt = 2,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "PREFETCHT2",
                OpExt = 3,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "HINT_NOP",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "HINT_NOP",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "HINT_NOP",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x18},
                Mnem = "HINT_NOP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x19},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1A},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1B},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1C},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1D},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1E},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "NOP",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 1,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 2,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 3,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x1F},
                Mnem = "HINT_NOP",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "v"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x20},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "R", T = "d"}, new Operand {A = "C", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x20},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "H", T = "d"}, new Operand {A = "C", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x21},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "R", T = "d"}, new Operand {A = "D", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x21},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "H", T = "d"}, new Operand {A = "D", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x22},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "C", T = "d"}, new Operand {A = "R", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x22},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "C", T = "d"}, new Operand {A = "H", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x23},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "D", T = "d"}, new Operand {A = "R", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x23},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "D", T = "q"}, new Operand {A = "H", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x24},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "R", T = "d"}, new Operand {A = "T", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x24},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "H", T = "d"}, new Operand {A = "T", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x26},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "T", T = "d"}, new Operand {A = "R", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x26},
                Mnem = "MOV",
                operands = new[] { new Operand {A = "T", T = "d"}, new Operand {A = "H", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x28},
                Mnem = "MOVAPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x28},
                Mnem = "MOVAPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x29},
                Mnem = "MOVAPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "W", T = "ps"}, new Operand {A = "V", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x29},
                Mnem = "MOVAPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "pd"}, new Operand {A = "V", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2A},
                Mnem = "CVTPI2PS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "Q", T = "pi"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2A},
                Mnem = "CVTSI2SS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "E", T = "dqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2A},
                Mnem = "CVTPI2PD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "Q", T = "pi"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2A},
                Mnem = "CVTSI2SD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "E", T = "dqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2B},
                Mnem = "MOVNTPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "ps"}, new Operand {A = "V", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2B},
                Mnem = "MOVNTPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "pd"}, new Operand {A = "V", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2C},
                Mnem = "CVTTPS2PI",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "pi"}, new Operand {A = "W", T = "psq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2C},
                Mnem = "CVTTSS2SI",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2C},
                Mnem = "CVTTPD2PI",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "pi"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2C},
                Mnem = "CVTTSD2SI",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2D},
                Mnem = "CVTPS2PI",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "pi"}, new Operand {A = "W", T = "psq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2D},
                Mnem = "CVTSS2SI",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2D},
                Mnem = "CVTPD2PI",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "pi"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2D},
                Mnem = "CVTSD2SI",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2E},
                Mnem = "UCOMISS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2E},
                Mnem = "UCOMISD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2F},
                Mnem = "COMISS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x2F},
                Mnem = "COMISD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x30},
                Mnem = "WRMSR"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x31},
                Mnem = "RDTSC"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x32},
                Mnem = "RDMSR"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x33},
                Mnem = "RDPMC"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x34},
                Mnem = "SYSENTER"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x35},
                Mnem = "SYSEXIT"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x37},
                Mnem = "GETSEC",
                InstrExt = "smx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x00},
                Mnem = "PSHUFB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x00},
                Mnem = "PSHUFB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x01},
                Mnem = "PHADDW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x01},
                Mnem = "PHADDW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x02},
                Mnem = "PHADDD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x02},
                Mnem = "PHADDD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x03},
                Mnem = "PHADDSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x03},
                Mnem = "PHADDSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x04},
                Mnem = "PMADDUBSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x04},
                Mnem = "PMADDUBSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x05},
                Mnem = "PHSUBW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x05},
                Mnem = "PHSUBW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x06},
                Mnem = "PHSUBD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x06},
                Mnem = "PHSUBD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x07},
                Mnem = "PHSUBSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x07},
                Mnem = "PHSUBSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x08},
                Mnem = "PSIGNB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x08},
                Mnem = "PSIGNB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x09},
                Mnem = "PSIGNW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x09},
                Mnem = "PSIGNW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x0A},
                Mnem = "PSIGND",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x0A},
                Mnem = "PSIGND",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x0B},
                Mnem = "PMULHRSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x0B},
                Mnem = "PMULHRSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x10},
                Mnem = "PBLENDVB",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x14},
                Mnem = "BLENDVPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x15},
                Mnem = "BLENDVPD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x17},
                Mnem = "PTEST",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1C},
                Mnem = "PABSB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1C},
                Mnem = "PABSB",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1D},
                Mnem = "PABSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1D},
                Mnem = "PABSW",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1E},
                Mnem = "PABSD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x1E},
                Mnem = "PABSD",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x20},
                Mnem = "PMOVSXBW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x21},
                Mnem = "PMOVSXBD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x22},
                Mnem = "PMOVSXBQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x23},
                Mnem = "PMOVSXWD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x24},
                Mnem = "PMOVSXWQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x25},
                Mnem = "PMOVSXDQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x28},
                Mnem = "PMULDQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x29},
                Mnem = "PCMPEQQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x2A},
                Mnem = "MOVNTDQA",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x2B},
                Mnem = "PACKUSDW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x30},
                Mnem = "PMOVZXBW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x31},
                Mnem = "PMOVZXBD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x32},
                Mnem = "PMOVZXBQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x33},
                Mnem = "PMOVZXWD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x34},
                Mnem = "PMOVZXWQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x35},
                Mnem = "PMOVZXDQ",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x37},
                Mnem = "PCMPGTQ",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x38},
                Mnem = "PMINSB",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x39},
                Mnem = "PMINSD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3A},
                Mnem = "PMINUW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3B},
                Mnem = "PMINUD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3C},
                Mnem = "PMAXSB",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3D},
                Mnem = "PMAXSD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3E},
                Mnem = "PMAXUW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x3F},
                Mnem = "PMAXUD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x40},
                Mnem = "PMULLD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x41},
                Mnem = "PHMINPOSUW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x80},
                Mnem = "INVEPT",
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "G", T = "d"}, new Operand {A = "M", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0x81},
                Mnem = "INVVPID",
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "G", T = "d"}, new Operand {A = "M", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0xF0},
                Mnem = "MOVBE",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0xF0},
                Mnem = "CRC32",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0xF1},
                Mnem = "MOVBE",
                operands = new[] { new Operand {A = "M", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x38, 0xF1},
                Mnem = "CRC32",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x08},
                Mnem = "ROUNDPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x09},
                Mnem = "ROUNDPD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "pd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0A},
                Mnem = "ROUNDSS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0B},
                Mnem = "ROUNDSD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0C},
                Mnem = "BLENDPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0D},
                Mnem = "BLENDPD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0E},
                Mnem = "PBLENDW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0F},
                Mnem = "PALIGNR",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x0F},
                Mnem = "PALIGNR",
                InstrExt = "ssse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x14},
                Mnem = "PEXTRB",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "M", T = "b"}, new Operand {A = "V", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x15},
                Mnem = "PEXTRW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "M", T = "w"}, new Operand {A = "V", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x16},
                Mnem = "PEXTRD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "E", T = "d"}, new Operand {A = "V", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x17},
                Mnem = "EXTRACTPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "E", T = "d"}, new Operand {A = "V", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x20},
                Mnem = "PINSRB",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "b"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x21},
                Mnem = "INSERTPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "U", T = "ps"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x22},
                Mnem = "PINSRD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "E", T = "d"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x40},
                Mnem = "DPPS",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x41},
                Mnem = "DPPD",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x42},
                Mnem = "MPSADBW",
                InstrExt = "sse41",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x60},
                Mnem = "PCMPESTRM",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x61},
                Mnem = "PCMPESTRI",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x62},
                Mnem = "PCMPISTRM",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x3A, 0x63},
                Mnem = "PCMPISTRI",
                InstrExt = "sse42",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x40},
                Mnem = "CMOVO",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x41},
                Mnem = "CMOVNO",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x42},
                Mnem = "CMOVB",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x43},
                Mnem = "CMOVNB",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x44},
                Mnem = "CMOVZ",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x45},
                Mnem = "CMOVNZ",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x46},
                Mnem = "CMOVBE",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x47},
                Mnem = "CMOVNBE",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x48},
                Mnem = "CMOVS",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x49},
                Mnem = "CMOVNS",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4A},
                Mnem = "CMOVP",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4B},
                Mnem = "CMOVNP",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4C},
                Mnem = "CMOVL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4D},
                Mnem = "CMOVNL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4E},
                Mnem = "CMOVLE",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x4F},
                Mnem = "CMOVNLE",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x50},
                Mnem = "MOVMSKPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "U", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x50},
                Mnem = "MOVMSKPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "U", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x51},
                Mnem = "SQRTPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x51},
                Mnem = "SQRTSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x51},
                Mnem = "SQRTPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x51},
                Mnem = "SQRTSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x52},
                Mnem = "RSQRTPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x52},
                Mnem = "RSQRTSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x53},
                Mnem = "RCPPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x53},
                Mnem = "RCPSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x54},
                Mnem = "ANDPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x54},
                Mnem = "ANDPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x55},
                Mnem = "ANDNPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x55},
                Mnem = "ANDNPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x56},
                Mnem = "ORPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x56},
                Mnem = "ORPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x57},
                Mnem = "XORPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x57},
                Mnem = "XORPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x58},
                Mnem = "ADDPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x58},
                Mnem = "ADDSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x58},
                Mnem = "ADDPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x58},
                Mnem = "ADDSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x59},
                Mnem = "MULPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x59},
                Mnem = "MULSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x59},
                Mnem = "MULPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x59},
                Mnem = "MULSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5A},
                Mnem = "CVTPS2PD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5A},
                Mnem = "CVTPD2PS",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5A},
                Mnem = "CVTSS2SD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5A},
                Mnem = "CVTSD2SS",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5B},
                Mnem = "CVTDQ2PS",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5B},
                Mnem = "CVTPS2DQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5B},
                Mnem = "CVTTPS2DQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5C},
                Mnem = "SUBPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5C},
                Mnem = "SUBSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5C},
                Mnem = "SUBPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5C},
                Mnem = "SUBSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5D},
                Mnem = "MINPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5D},
                Mnem = "MINSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5D},
                Mnem = "MINPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5D},
                Mnem = "MINSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5E},
                Mnem = "DIVPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5E},
                Mnem = "DIVSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5E},
                Mnem = "DIVPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5E},
                Mnem = "DIVSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5F},
                Mnem = "MAXPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5F},
                Mnem = "MAXSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5F},
                Mnem = "MAXPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x5F},
                Mnem = "MAXSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x60},
                Mnem = "PUNPCKLBW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x60},
                Mnem = "PUNPCKLBW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x61},
                Mnem = "PUNPCKLWD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x61},
                Mnem = "PUNPCKLWD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x62},
                Mnem = "PUNPCKLDQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x62},
                Mnem = "PUNPCKLDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x63},
                Mnem = "PACKSSWB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x63},
                Mnem = "PACKSSWB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x64},
                Mnem = "PCMPGTB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x64},
                Mnem = "PCMPGTB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x65},
                Mnem = "PCMPGTW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x65},
                Mnem = "PCMPGTW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x66},
                Mnem = "PCMPGTD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x66},
                Mnem = "PCMPGTD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x67},
                Mnem = "PACKUSWB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x67},
                Mnem = "PACKUSWB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x68},
                Mnem = "PUNPCKHBW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x68},
                Mnem = "PUNPCKHBW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x69},
                Mnem = "PUNPCKHWD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x69},
                Mnem = "PUNPCKHWD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6A},
                Mnem = "PUNPCKHDQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6A},
                Mnem = "PUNPCKHDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6B},
                Mnem = "PACKSSDW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6B},
                Mnem = "PACKSSDW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6C},
                Mnem = "PUNPCKLQDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6D},
                Mnem = "PUNPCKHQDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6E},
                Mnem = "MOVD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "E", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6E},
                Mnem = "MOVD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "E", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6F},
                Mnem = "MOVQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6F},
                Mnem = "MOVDQA",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x6F},
                Mnem = "MOVDQU",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x70},
                Mnem = "PSHUFW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x70},
                Mnem = "PSHUFLW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x70},
                Mnem = "PSHUFHW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x70},
                Mnem = "PSHUFD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSRLW",
                OpExt = 2,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSRLW",
                OpExt = 2,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSRAW",
                OpExt = 4,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSRAW",
                OpExt = 4,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSLLW",
                OpExt = 6,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x71},
                Mnem = "PSLLW",
                OpExt = 6,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSRLD",
                OpExt = 2,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSRLD",
                OpExt = 2,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSRAD",
                OpExt = 4,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSRAD",
                OpExt = 4,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSLLD",
                OpExt = 6,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x72},
                Mnem = "PSLLD",
                OpExt = 6,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSRLQ",
                OpExt = 2,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSRLQ",
                OpExt = 2,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSRLDQ",
                OpExt = 3,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSLLQ",
                OpExt = 6,
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSLLQ",
                OpExt = 6,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x73},
                Mnem = "PSLLDQ",
                OpExt = 7,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x74},
                Mnem = "PCMPEQB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x74},
                Mnem = "PCMPEQB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x75},
                Mnem = "PCMPEQW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x75},
                Mnem = "PCMPEQW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x76},
                Mnem = "PCMPEQD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x76},
                Mnem = "PCMPEQD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x77},
                Mnem = "EMMS",
                InstrExt = "mmx"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x78},
                Mnem = "VMREAD",
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "E", T = "d"}, new Operand {A = "G", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x79},
                Mnem = "VMWRITE",
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "G", T = "d"}, new Operand {A = "E", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7C},
                Mnem = "HADDPD",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7C},
                Mnem = "HADDPS",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7D},
                Mnem = "HSUBPD",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7D},
                Mnem = "HSUBPS",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7E},
                Mnem = "MOVD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "E", T = "d"}, new Operand {A = "P", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7E},
                Mnem = "MOVD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "E", T = "d"}, new Operand {A = "V", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7E},
                Mnem = "MOVQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "q"}, new Operand {A = "W", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7F},
                Mnem = "MOVQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "Q", T = "q"}, new Operand {A = "P", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7F},
                Mnem = "MOVDQA",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "dq"}, new Operand {A = "V", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x7F},
                Mnem = "MOVDQU",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "dq"}, new Operand {A = "V", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x80},
                Mnem = "JO",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x81},
                Mnem = "JNO",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x82},
                Mnem = "JB",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x83},
                Mnem = "JNB",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x84},
                Mnem = "JZ",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x85},
                Mnem = "JNZ",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x86},
                Mnem = "JBE",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x87},
                Mnem = "JNBE",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x88},
                Mnem = "JS",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x89},
                Mnem = "JNS",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8A},
                Mnem = "JP",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8B},
                Mnem = "JNP",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8C},
                Mnem = "JL",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8D},
                Mnem = "JNL",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8E},
                Mnem = "JLE",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x8F},
                Mnem = "JNLE",
                operands = new[] { new Operand {A = "J", T = "vds"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x90},
                Mnem = "SETO",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x91},
                Mnem = "SETNO",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x92},
                Mnem = "SETB",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x93},
                Mnem = "SETNB",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x94},
                Mnem = "SETZ",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x95},
                Mnem = "SETNZ",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x96},
                Mnem = "SETBE",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x97},
                Mnem = "SETNBE",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x98},
                Mnem = "SETS",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x99},
                Mnem = "SETNS",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9A},
                Mnem = "SETP",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9B},
                Mnem = "SETNP",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9C},
                Mnem = "SETL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9D},
                Mnem = "SETNL",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9E},
                Mnem = "SETLE",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0x9F},
                Mnem = "SETNLE",
                OpExt = 0,
                operands = new[] { new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA0},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[12], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA1},
                Mnem = "POP",
                operands = new[] { new Operand {R = DisASMx86.Registers[12], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA2},
                Mnem = "CPUID"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA3},
                Mnem = "BT",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA4},
                Mnem = "SHLD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA5},
                Mnem = "SHLD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA8},
                Mnem = "PUSH",
                operands = new[] { new Operand {R = DisASMx86.Registers[13], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xA9},
                Mnem = "POP",
                operands = new[] { new Operand {R = DisASMx86.Registers[13], T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAA},
                Mnem = "RSM"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAB},
                Mnem = "BTS",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAC},
                Mnem = "SHRD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAD},
                Mnem = "SHRD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"}, new Operand {R = DisASMx86.Registers[1], T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "FXSAVE",
                OpExt = 0,
                operands = new[] { new Operand {A = "M", T = "stx"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "FXRSTOR",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "stx"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "LDMXCSR",
                OpExt = 2,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "STMXCSR",
                OpExt = 3,
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "XSAVE",
                OpExt = 4,
                operands = new[] { new Operand {A = "M", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "LFENCE",
                OpExt = 5,
                InstrExt = "sse2"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "XRSTOR",
                OpExt = 5,
                operands = new[] { new Operand {A = "M", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "MFENCE",
                OpExt = 6,
                InstrExt = "sse2"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "SFENCE",
                OpExt = 7,
                InstrExt = "sse1"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAE},
                Mnem = "CLFLUSH",
                OpExt = 7,
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xAF},
                Mnem = "IMUL",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB0},
                Mnem = "CMPXCHG",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB1},
                Mnem = "CMPXCHG",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB2},
                Mnem = "LSS",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "ptp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB3},
                Mnem = "BTR",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB4},
                Mnem = "LFS",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "ptp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB5},
                Mnem = "LGS",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "M", T = "ptp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB6},
                Mnem = "MOVZX",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB7},
                Mnem = "MOVZX",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB8},
                Mnem = "JMPE"
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB8},
                Mnem = "POPCNT",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xB9},
                Mnem = "UD",
                operands = new[] { new Operand {A = "G", T = null}, new Operand {A = "E", T = null} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBA},
                Mnem = "BT",
                OpExt = 4,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBA},
                Mnem = "BTS",
                OpExt = 5,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBA},
                Mnem = "BTR",
                OpExt = 6,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBA},
                Mnem = "BTC",
                OpExt = 7,
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBB},
                Mnem = "BTC",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBC},
                Mnem = "BSF",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBD},
                Mnem = "BSR",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBE},
                Mnem = "MOVSX",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xBF},
                Mnem = "MOVSX",
                operands = new[] { new Operand {A = "G", T = "vqp"}, new Operand {A = "E", T = "w"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC0},
                Mnem = "XADD",
                operands = new[] { new Operand {A = "E", T = "b"}, new Operand {A = "G", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC1},
                Mnem = "XADD",
                operands = new[] { new Operand {A = "E", T = "vqp"}, new Operand {A = "G", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC2},
                Mnem = "CMPPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC2},
                Mnem = "CMPSS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ss"}, new Operand {A = "W", T = "ss"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC2},
                Mnem = "CMPPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC2},
                Mnem = "CMPSD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "sd"}, new Operand {A = "W", T = "sd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC3},
                Mnem = "MOVNTI",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "dqp"}, new Operand {A = "G", T = "dqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC4},
                Mnem = "PINSRW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "R", T = "dqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC4},
                Mnem = "PINSRW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "R", T = "dqp"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC5},
                Mnem = "PEXTRW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "N", T = "q"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC5},
                Mnem = "PEXTRW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "U", T = "dq"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC6},
                Mnem = "SHUFPS",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC6},
                Mnem = "SHUFPD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"}, new Operand {A = "I", T = "b"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC7},
                Mnem = "CMPXCHG8B",
                OpExt = 1,
                operands = new[] { new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC7},
                Mnem = "VMPTRLD",
                OpExt = 6,
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC7},
                Mnem = "VMCLEAR",
                OpExt = 6,
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC7},
                Mnem = "VMXON",
                OpExt = 6,
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC7},
                Mnem = "VMPTRST",
                OpExt = 7,
                InstrExt = "vmx",
                operands = new[] { new Operand {A = "M", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xC8},
                Mnem = "BSWAP",
                operands = new[] { new Operand {A = "Z", T = "vqp"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD0},
                Mnem = "ADDSUBPD",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD0},
                Mnem = "ADDSUBPS",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "ps"}, new Operand {A = "W", T = "ps"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD1},
                Mnem = "PSRLW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD1},
                Mnem = "PSRLW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD2},
                Mnem = "PSRLD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD2},
                Mnem = "PSRLD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD3},
                Mnem = "PSRLQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD3},
                Mnem = "PSRLQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD4},
                Mnem = "PADDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD4},
                Mnem = "PADDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD5},
                Mnem = "PMULLW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD5},
                Mnem = "PMULLW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD6},
                Mnem = "MOVQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "W", T = "q"}, new Operand {A = "V", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD6},
                Mnem = "MOVQ2DQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "N", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD6},
                Mnem = "MOVDQ2Q",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "U", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD7},
                Mnem = "PMOVMSKB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "N", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD7},
                Mnem = "PMOVMSKB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "G", T = "dqp"}, new Operand {A = "U", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD8},
                Mnem = "PSUBUSB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD8},
                Mnem = "PSUBUSB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD9},
                Mnem = "PSUBUSW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xD9},
                Mnem = "PSUBUSW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDA},
                Mnem = "PMINUB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDA},
                Mnem = "PMINUB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDB},
                Mnem = "PAND",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDB},
                Mnem = "PAND",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDC},
                Mnem = "PADDUSB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDC},
                Mnem = "PADDUSB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDD},
                Mnem = "PADDUSW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDD},
                Mnem = "PADDUSW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDE},
                Mnem = "PMAXUB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDE},
                Mnem = "PMAXUB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDF},
                Mnem = "PANDN",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xDF},
                Mnem = "PANDN",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE0},
                Mnem = "PAVGB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE0},
                Mnem = "PAVGB",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE1},
                Mnem = "PSRAW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE1},
                Mnem = "PSRAW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE2},
                Mnem = "PSRAD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE2},
                Mnem = "PSRAD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE3},
                Mnem = "PAVGW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE3},
                Mnem = "PAVGW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE4},
                Mnem = "PMULHUW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE4},
                Mnem = "PMULHUW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE5},
                Mnem = "PMULHW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE5},
                Mnem = "PMULHW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE6},
                Mnem = "CVTPD2DQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE6},
                Mnem = "CVTTPD2DQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "pd"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE6},
                Mnem = "CVTDQ2PD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "pd"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE7},
                Mnem = "MOVNTQ",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "M", T = "q"}, new Operand {A = "P", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE7},
                Mnem = "MOVNTDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "M", T = "dq"}, new Operand {A = "V", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE8},
                Mnem = "PSUBSB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE8},
                Mnem = "PSUBSB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE9},
                Mnem = "PSUBSW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xE9},
                Mnem = "PSUBSW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEA},
                Mnem = "PMINSW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEA},
                Mnem = "PMINSW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEB},
                Mnem = "POR",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEB},
                Mnem = "POR",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEC},
                Mnem = "PADDSB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEC},
                Mnem = "PADDSB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xED},
                Mnem = "PADDSW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xED},
                Mnem = "PADDSW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEE},
                Mnem = "PMAXSW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEE},
                Mnem = "PMAXSW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEF},
                Mnem = "PXOR",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xEF},
                Mnem = "PXOR",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF0},
                Mnem = "LDDQU",
                InstrExt = "sse3",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "M", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF1},
                Mnem = "PSLLW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF1},
                Mnem = "PSLLW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF2},
                Mnem = "PSLLD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF2},
                Mnem = "PSLLD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF3},
                Mnem = "PSLLQ",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF3},
                Mnem = "PSLLQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF4},
                Mnem = "PMULUDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF4},
                Mnem = "PMULUDQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF5},
                Mnem = "PMADDWD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "d"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF5},
                Mnem = "PMADDWD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF6},
                Mnem = "PSADBW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF6},
                Mnem = "PSADBW",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF7},
                Mnem = "MASKMOVQ",
                InstrExt = "sse1",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "N", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF7},
                Mnem = "MASKMOVDQU",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "U", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF8},
                Mnem = "PSUBB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF8},
                Mnem = "PSUBB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF9},
                Mnem = "PSUBW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xF9},
                Mnem = "PSUBW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFA},
                Mnem = "PSUBD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFA},
                Mnem = "PSUBD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFB},
                Mnem = "PSUBQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFB},
                Mnem = "PSUBQ",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFC},
                Mnem = "PADDB",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFC},
                Mnem = "PADDB",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFD},
                Mnem = "PADDW",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFD},
                Mnem = "PADDW",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFE},
                Mnem = "PADDD",
                InstrExt = "mmx",
                operands = new[] { new Operand {A = "P", T = "q"}, new Operand {A = "Q", T = "q"} }
            },
            new Opcode {
                Seq = new byte[] {0x0F, 0xFE},
                Mnem = "PADDD",
                InstrExt = "sse2",
                operands = new[] { new Operand {A = "V", T = "dq"}, new Operand {A = "W", T = "dq"} }
            }
            };
        }
    }
}
