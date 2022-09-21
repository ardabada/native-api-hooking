namespace NativeApiHooking.Common.Disasm
{
    internal class ParsedInstruction
    {
        public Prefix[] Prefixes { get; set; }

        public Opcode Operation { get; set; }

        public string[] Operands { get; set; }

        public int Length { get; set; }
    }
}
