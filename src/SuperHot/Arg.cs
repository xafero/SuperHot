namespace SuperHot
{
    public abstract class Arg
    {
        public static implicit operator Arg(Register v) => new RegArg(v);

        public static implicit operator Arg(int v) => new IntArg(v);
        
        public static implicit operator Arg(uint v) => new UIntArg(v);
    }

    public sealed class IntArg : Arg
    {
        public int Val { get; }

        public IntArg(int val) => Val = val;

        public override string ToString() => $"0x{Val:x4}";
    }
    
    public sealed class UIntArg : Arg
    {
        public uint Val { get; }

        public UIntArg(uint val) => Val = val;

        public override string ToString() => $"0x{Val:x4}";
    }

    public sealed class RegArg : Arg
    {
        public Register Val { get; }

        public RegArg(Register val) => Val = val;

        public override string ToString() => $"{Val}";
    }
}