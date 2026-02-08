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
	internal static class d44A000000000
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b0000:
					switch (n1)
					{
						default: j001:
							switch (n2)
							{
								case 0b0011:
									switch (n3)
									{
										case 0b1010:
											return I.Stc(sgr, n: R(n1));
									}
									break;
								case 0b1001:
									switch (n3)
									{
										case 0b0011:
											return I.Ocbi(n: at(R(n1)));
									}
									break;
								case 0b1010:
									switch (n3)
									{
										case 0b0011:
											return I.Ocbp(n: at(R(n1)));
									}
									break;
								case 0b1011:
									switch (n3)
									{
										case 0b0011:
											return I.Ocbwb(n: at(R(n1)));
									}
									break;
								case 0b1100:
									switch (n3)
									{
										case 0b0011:
											return I.Movca_l(r0, n: at(R(n1)));
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b1010:
											return I.Stc(dbr, n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0100:
					switch (n1)
					{
						default: j002:
							switch (n2)
							{
								case 0b0011:
									switch (n3)
									{
										case 0b0010:
											return I.Stc_l(sgr, n: at(m(R(n1))));
										case 0b0110:
											return I.Ldc_l(m: at(p(R(n1))), sgr);
										case 0b1010:
											return I.Ldc(m: R(n1), sgr);
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b0010:
											return I.Stc_l(dbr, n: at(m(R(n1))));
										case 0b0110:
											return I.Ldc_l(m: at(p(R(n1))), dbr);
										case 0b1010:
											return I.Ldc(m: R(n1), dbr);
									}
									break;
							}
							break;
					}
					break;
				case 0b1111:
					switch (n1)
					{
						case 0b1011:
							switch (n2)
							{
								case 0b1111:
									switch (n3)
									{
										case 0b1101:
											return I.Frchg();
									}
									break;
							}
							goto j003;
						default: j003:
							switch (n2)
							{
								case 0b0111:
									switch (n3)
									{
										case 0b1101:
											return I.Fsrra(n: fR(n1));
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b1101:
											return I.Fipr(m: fV(n1 & 0b0011), n: fV(n1 >> 2));
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b1101:
											return I.Fsca_or_Ftrv(n0, n1, n2, n3, 
											/* 1111nnn011111101 */ () => I.Fsca(fpul, n: dR(n1 >> 1)),
												/* 1111nn0111111101 */ () => I.Ftrv(xmtrx, n: fV(n1 >> 2)));
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
