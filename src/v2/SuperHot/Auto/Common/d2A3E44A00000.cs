using static SuperHot.InstructV;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d2A3E44A00000
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b1111:
					switch (n1)
					{
						default: j001:
							switch (n2)
							{
								case 0b0110:
									switch (n3)
									{
										case 0b1101:
											return I.Fsqrt(n: fR(n1));
									}
									break;
							}
							break;
					}
					break;
			}
			return null;
		}
	}
}
