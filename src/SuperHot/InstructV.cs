using System;
using SuperHot.Args;
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

        internal static Register fR(A a1)
        {
            var iV = ((IntArg)a1).Val;
            switch (iV)
            {
                case 0: return Register.fr0;
                case 1: return Register.fr1;
                case 2: return Register.fr2;
                case 3: return Register.fr3;
                case 4: return Register.fr4;
                case 5: return Register.fr5;
                case 6: return Register.fr6;
                case 7: return Register.fr7;
                case 8: return Register.fr8;
                case 9: return Register.fr9;
                case 10: return Register.fr10;
                case 11: return Register.fr11;
                case 12: return Register.fr12;
                case 13: return Register.fr13;
                case 14: return Register.fr14;
                case 15: return Register.fr15;
                default: throw new InvalidOperationException($"{iV} ?!");
            }
        }

        internal static Register R(A a1)
        {
            if (a1 is RegArg ra) 
                return ra.Val;
            var iV = ((IntArg)a1).Val;
            switch (iV)
            {
                case 0: return Register.r0;
                case 1: return Register.r1;
                case 2: return Register.r2;
                case 3: return Register.r3;
                case 4: return Register.r4;
                case 5: return Register.r5;
                case 6: return Register.r6;
                case 7: return Register.r7;
                case 8: return Register.r8;
                case 9: return Register.r9;
                case 10: return Register.r10;
                case 11: return Register.r11;
                case 12: return Register.r12;
                case 13: return Register.r13;
                case 14: return Register.r14;
                case 15: return Register.r15;
                default: throw new InvalidOperationException($"{iV} ?!");
            }
        }

        internal static int se(int number)
        {
            if ((number & 0x800) != 0)
                number = (int)(0xFFFFF000 | number);
            return number;
        }
    }
}