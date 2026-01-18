namespace SuperHot
{
    public sealed class At2Arg : Arg
    {
        public Arg Val1 { get; }
        public Arg Val2 { get; }

        public At2Arg(Arg a1, Arg a2) { Val1 = a1; Val2 = a2; }

        public override string ToString() => $"@({Val1},{Val2})";
    }
}