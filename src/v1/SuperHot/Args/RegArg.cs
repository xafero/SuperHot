namespace SuperHot.Args
{
    public sealed class RegArg : Arg
    {
        public Register Val { get; }

        public RegArg(Register val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"{Val}";
        }
    }
}