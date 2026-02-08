using System.Linq;
using SuperHot.Args;
using SuperHot.Auto;

// ReSharper disable ConditionalAccessQualifierIsNonNullableAccordingToAPIContract

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
            var a = string.Join(",", Args.Select(a => a?.ToString()));
            var t = $"{Code.ToName()}\t{a}";
            return t.Trim();
        }
    }
}