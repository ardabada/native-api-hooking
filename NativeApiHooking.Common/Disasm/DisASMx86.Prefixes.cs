using System.Collections.Generic;

namespace NativeApiHooking.Common.Disasm
{
    internal static partial class DisASMx86
    {
        public static readonly Dictionary<byte, Prefix> Prefixes = new Dictionary<byte, Prefix>
        {
            { 0x26, new Prefix { Mnem = "ES" } },
            { 0x36, new Prefix { Mnem = "SS" } },
            { 0x3E, new Prefix { Mnem = "DS" } },
            { 0x64, new Prefix { Mnem = "FS" } },
            { 0x65, new Prefix { Mnem = "GS" } },
            { 0x66, new Prefix { OperSize = 2 } },
            { 0x67, new Prefix { AddrSize = 2 } },
            { 0x9B, new Prefix { } },
            { 0xF0, new Prefix { Mnem = "LOCK" } },
            { 0xF2, new Prefix { Mnem = "REPNZ" } },
            { 0xF3, new Prefix { Mnem = "REPZ" } }
        };
    }
}
