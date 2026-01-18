namespace SuperHot
{
    public sealed class At2bArg : Arg
    {
        public Arg Val1 { get; }
        public Arg Val2 { get; }

        public At2bArg(Arg a1, Arg a2)
        {
            Val1 = a1;
            Val2 = a2;
        }

        public override string ToString()
        {
            return $"@@({Val1},{Val2})";
        }
    }
}