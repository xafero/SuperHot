using static SuperHot.SuperTool;

namespace SuperHot
{
    public sealed class Instruction
    {
        public Opcode Code { get; }
        public ushort Val { get; }

        public Instruction(Opcode code, ushort val)
        {
            Code = code;
            Val = val;
        }

        public override string ToString()
        {
            return $"{GetName(Code)}\t{Format(Val)}";
        }
    }
}