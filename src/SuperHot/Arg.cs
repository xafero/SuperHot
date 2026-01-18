using A = SuperHot.Arg;

namespace SuperHot
{
    public abstract class Arg
    {
        public static implicit operator A(Register v) => new RegArg(v);

        public static implicit operator A(int v) => new IntArg(v);

        public static implicit operator A(uint v) => new UIntArg(v);
    }

    public sealed class IntArg : A
    {
        public int Val { get; }

        public IntArg(int val) => Val = val;

        public override string ToString() => $"0x{Val:x4}";
    }

    public sealed class UIntArg : A
    {
        public uint Val { get; }

        public UIntArg(uint val) => Val = val;

        public override string ToString() => $"0x{Val:x4}";
    }

    public sealed class At2Arg : A
    {
        public A Val1 { get; }
        public A Val2 { get; }

        public At2Arg(A a1, A a2) { Val1 = a1; Val2 = a2; }

        public override string ToString() => $"@({Val1} {Val2})";
    }
    
    public sealed class At1Arg : A
    {
        public A Val1 { get; }

        public At1Arg(A a1) { Val1 = a1; }

        public override string ToString() => $"@({Val1})";
    }
    
    public sealed class HashArg : A
    {
        public A Val1 { get; }

        public HashArg(A a1) { Val1 = a1; }

        public override string ToString() => $"#({Val1})";
    }

    public sealed class RegArg : A
    {
        public Register Val { get; }

        public RegArg(Register val) => Val = val;

        public override string ToString() => $"{Val}";
    }
}