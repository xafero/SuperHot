using SuperHot.Auto.Common;
using I = SuperHot.InstructH;

// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto
{
	public sealed class Sh2eDecoder : IDecoder
	{
		public Instruction? Decode(IByteReader reader, bool fail)
		{
			var b0 = reader.ReadOne();
			var b1 = reader.ReadOne();
			var (n0, n1) = ((byte)(b0 >> 4), (byte)(b0 & 0x0F));
			var (n2, n3) = ((byte)(b1 >> 4), (byte)(b1 & 0x0F));
			if (d122A2E33E44A.Decode(n0, n1, n2, n3) is { } x1)
				return x1;
			if (d22A2E33E44A0.Decode(n0, n1, n2, n3) is { } x2)
				return x2;
			if (d2A2E3E44A000.Decode(n0, n1, n2, n3) is { } x3)
				return x3;
			return fail ? throw new DecodeException(b0, b1) : I.Word(n0, n1, n2, n3);
		}
	}
}
