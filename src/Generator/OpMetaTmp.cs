using System.Collections.Generic;

namespace Generator
{
    internal record OpMetaTmp
    {
        internal SortedSet<string> Dialects { get; } = new();
        internal SortedSet<int> Counts { get; } = new();
        internal SortedSet<string> Args { get; } = new();
        internal SortedSet<string> Names { get; } = new();
    }
}