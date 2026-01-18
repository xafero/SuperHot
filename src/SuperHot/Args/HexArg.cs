namespace SuperHot
{
    public sealed class HexArg : Arg
    {
        public int Val { get; }

        public HexArg(int val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"0x{Val:x4}";
        }
    }
}