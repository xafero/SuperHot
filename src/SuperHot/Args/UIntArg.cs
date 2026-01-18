namespace SuperHot
{
    public sealed class UIntArg : Arg
    {
        public uint Val { get; }

        public UIntArg(uint val) => Val = val;

        public override string ToString() => $"0x{Val:x4}";
    }
}