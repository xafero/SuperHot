using System;
using SuperHot.Args;
using O = SuperHot.Auto.Opcode;
using I = SuperHot.Instruction;
using A = SuperHot.Args.Arg;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace SuperHot
{
    internal static class InstructV
    {
        internal static A p(Register r) => new RegPlusArg(r);

        internal static A m(Register r) => new RegMinusArg(r);

        internal static A h(A a1)
        {
            if (a1 is IntArg ia)
                a1 = new DecArg(ia.Val);
            return new HashArg(a1);
        }

        internal static A at(A a1) => new At1Arg(a1);
        
        internal static A atb(A a1, A a2)
        {
            if (a1 is IntArg ia)
                a1 = new DecArg(ia.Val);
            return new At2bArg(a1, a2);
        }

        internal static A at(A a1, A a2)
        {
            if (a1 is IntArg ia)
                a1 = new DecArg(ia.Val);
            return new At2Arg(a1, a2);
        }
    }
}