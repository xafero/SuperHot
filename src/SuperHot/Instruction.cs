using System.Linq;
using SuperHot.Auto;
using static SuperHot.SuperTool;

namespace SuperHot
{
    public sealed class Instruction
    {
        public Opcode Code { get; }
        public Arg[] Args { get; }

        public Instruction(Opcode code, params Arg[] args)
        {
            Code = code;
            Args = args;
        }

        public override string ToString()
        {
            var a = string.Join(", ", Args.Select(a => a.ToString()));
            var t = $"{Code.ToName()}\t{a}";
            return t.Trim();
        }
    }
}