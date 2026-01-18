namespace SuperHot
{
    public sealed class RegPlusArg : Arg
    {
        public Register Val { get; }

        public RegPlusArg(Register val)
        {
            Val = val;
        }

        public override string ToString()
        {
            return $"{Val}+";
        }
    }
}