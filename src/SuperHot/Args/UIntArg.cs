namespace SuperHot.Args
{
    public sealed class UIntArg : Arg
    {
        public uint Val { get; }

        public UIntArg(uint val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"0x{Val:x4}";
        }
    }
}