namespace NativeApiHooking.Common.Disasm
{
    internal class Opcode
    {
        public byte[] Seq { get; set; }

        public string Mnem { get; set; }

        public int? OpExt { get; set; }

        public Operand[] operands { get; set; }

        public string InstrExt { get; set; }
    }
}
