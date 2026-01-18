namespace SuperHot
{
    public sealed class IntArg : Arg
    {
        public int Val { get; }

        public IntArg(int val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"0x{Val:x}";
        }
    }
}