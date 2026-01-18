using System.Collections.Generic;

namespace Generator
{
    internal record OpMetaTmp
    {
        public SortedSet<string> Dialects { get; } = new();
        public SortedSet<int> Counts { get; } = new();
        public SortedSet<string> Args { get; } = new();
        public SortedSet<string> Names { get; } = new();
    }
}