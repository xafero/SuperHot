using System;
using System.Collections.Generic;

namespace SuperHot
{
    public sealed class OpMeta : Attribute
    {
        public OpMeta(Dialect[] cpu, byte args = 0, string? min = null, string? max = null)
        {
            Dialects = cpu;
            ArgCount = args;
            Min = min;
            Max = max;
        }

        public Dialect[] Dialects { get; }
        public byte ArgCount { get; }
        public string? Min { get; }
        public string? Max { get; }
    }
}