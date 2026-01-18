using A = SuperHot.Args.Arg;

namespace SuperHot.Args
{
    public abstract class Arg
    {
        public static implicit operator A(Register v) => new RegArg(v);

        public static implicit operator A(int v) => new IntArg(v);

        public static implicit operator A(uint v) => new UIntArg(v);
    }
}