using System;
using SuperHot;
using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d2A44A0000000
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b1111:
					switch (n1)
					{
						case 0b0011:
							switch (n2)
							{
								case 0b1111:
									switch (n3)
									{
										case 0b1101:
											return I.Fschg();
									}
									break;
							}
							goto j001;
						default: j001:
							switch (n2)
							{
								case 0b1010:
									switch (n3)
									{
										case 0b1101:
											return I.Fcnvsd_or_Word(n0, n1, n2, n3, 
											/* 1111nnn010101101 */ () => I.Fcnvsd(fpul, n: dR(n1 >> 1)),
												/* 1111bbbb10101101 */ () => I.Word(n0, n1, n2, n3));
									}
									break;
								case 0b1011:
									switch (n3)
									{
										case 0b1101:
											return I.Fcnvds_or_Word(n0, n1, n2, n3, 
											/* 1111mmm010111101 */ () => I.Fcnvds(m: dR(n1 >> 1), fpul),
												/* 1111bbbb10111101 */ () => I.Word(n0, n1, n2, n3));
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
