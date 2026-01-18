using SuperHot.Auto;
using static SuperHot.SuperTool;

namespace SuperHot
{
    public sealed class Instruction
    {
        public Opcode Code { get; }
        public object? Val { get; }

        public Instruction(Opcode code, object? val = null)
        {
            Code = code;
            Val = val;
        }

        public override string ToString()
        {
            return $"{Code.ToName()}\t{Format(Val)}";
        }
    }
}