namespace NativeApiHooking.Common.Disasm
{
    internal static partial class DisASMx86
    {
        public static readonly Register[] Registers = new Register[22]
        {
            new Register {
                R8= "AL",
                R16= "AX",
                R32= "EAX",
                MM= "MM0",
                XMM= "XMM0"
            },
            new Register {
                R8= "CL",
                R16= "CX",
                R32= "ECX",
                MM= "MM1",
                XMM= "XMM1"
            },
            new Register {
                R8= "DL",
                R16= "DX",
                R32= "EDX",
                MM= "MM2",
                XMM= "XMM2"
            },
            new Register {
                R8= "BL",
                R16= "BX",
                R32= "EBX",
                MM= "MM3",
                XMM= "XMM3"
            },
            new Register {
                R8= "AH",
                R16= "SP",
                R32= "ESP",
                MM= "MM4",
                XMM= "XMM4"
            },
            new Register {
                R8= "CH",
                R16= "BP",
                R32= "EBP",
                MM= "MM5",
                XMM= "XMM5"
            },
            new Register {
                R8= "DH",
                R16= "SI",
                R32= "ESI",
                MM= "MM6",
                XMM= "XMM6"
            },
            new Register {
                R8= "BH",
                R16= "DI",
                R32= "EDI",
                MM= "MM7",
                XMM= "XMM7"
            },
            new Register {
                R16= "ES"
            },
            new Register {
                R16= "CS"
            },
            new Register {
                R16= "SS"
            },
            new Register {
                R16= "DS"
            },
            new Register {
                R16= "FS"
            },
            new Register {
                R16= "GS"
            },
            new Register {
                S80= "ST0"
            },
            new Register {
                S80= "ST1"
            },
            new Register {
                S80= "ST2"
            },
            new Register {
                S80= "ST3"
            },
            new Register {
                S80= "ST4"
            },
            new Register {
                S80= "ST5"
            },
            new Register {
                S80= "ST6"
            },
            new Register {
                S80= "ST7"
            }
        };

        public static readonly string[] RegisterCombinations = new string[8]
        {
             "BX + SI",
             "BX + DI",
             "BP + SI",
             "BP + DI",
             "SI",
             "DI",
             "BP",
             "BX"
        };
    }
}
