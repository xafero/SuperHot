namespace SuperHot.Args
{
    public sealed class DecArg : Arg
    {
        public int Val { get; }

        public DecArg(int val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"{Val}";
        }
    }
}