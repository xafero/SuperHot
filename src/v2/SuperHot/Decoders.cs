using System;
using IDecoder = SuperHot.IDecoder;
using Dialect = SuperHot.Dialect;
using SuperHot2.Auto;

namespace SuperHot
{
    public static class Decoders
    {
        public static IDecoder GetDecoder(Dialect mode)
        {
            switch (mode)
            {
                case Dialect.Sh: return new ShDecoder();
                case Dialect.Sh2: return new Sh2Decoder();
                case Dialect.Sh2a: return new Sh2aDecoder();
                case Dialect.Sh2e: return new Sh2eDecoder();
                case Dialect.Sh3: return new Sh3Decoder();
                case Dialect.Sh3e: return new Sh3eDecoder();
                case Dialect.Sh4: return new Sh4Decoder();
                case Dialect.Sh4a: return new Sh4aDecoder();
                default: throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}