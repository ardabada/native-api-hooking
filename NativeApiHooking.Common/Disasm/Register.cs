using System;

namespace NativeApiHooking.Common.Disasm
{
    internal class Register
    {
        public string R8 { get; set; }
        public string R16 { get; set; }
        public string R32 { get; set; }
        public string MM { get; set; }
        public string XMM { get; set; }
        public string S80 { get; set; }

        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "r8": return R8;
                    case "r16": return R16;
                    case "r32": return R32;
                    case "mm": return MM;
                    case "xmm": return XMM;
                    case "s80": return S80;
                    default:
                        throw new InvalidOperationException("Unknown registry " + index);
                }
            }
        }
    }
}
