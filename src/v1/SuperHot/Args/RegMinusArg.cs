namespace SuperHot.Args
{
    public sealed class RegMinusArg : Arg
    {
        public Register Val { get; }

        public RegMinusArg(Register val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"-{Val}";
        }
    }
}