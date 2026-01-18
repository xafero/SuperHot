namespace SuperHot
{
    public sealed class HashArg : Arg
    {
        public Arg Val1 { get; }

        public HashArg(Arg a1) { Val1 = a1; }

        public override string ToString() => $"#{Val1}";
    }
}