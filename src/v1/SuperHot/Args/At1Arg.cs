namespace SuperHot.Args
{
    public sealed class At1Arg : Arg
    {
        public Arg Val1 { get; }

        public At1Arg(Arg a1)
        {
            Val1 = a1;
        }

        public override string ToString()
        {
            return $"@{Val1}";
        }
    }
}