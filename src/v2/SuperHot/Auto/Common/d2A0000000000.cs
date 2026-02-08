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
	internal static class d2A0000000000
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b0000:
					switch (n1)
					{
						case 0b0000:
							switch (n2)
							{
								case 0b0101:
									switch (n3)
									{
										case 0b1011:
											return I.Resbank();
									}
									break;
								case 0b0110:
									switch (n3)
									{
										case 0b1000:
											return I.Nott();
										case 0b1011:
											return I.Rtsn();
									}
									break;
							}
							goto j001;
						default: j001:
							switch (n2)
							{
								case 0b0011:
									switch (n3)
									{
										case 0b1001:
											return I.Movrt(n: R(n1));
									}
									break;
								case 0b0100:
									switch (n3)
									{
										case 0b1010:
											return I.Stc(tbr, n: R(n1));
									}
									break;
								case 0b0111:
									switch (n3)
									{
										case 0b1011:
											return I.Rtvn(m: R(n1));
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
								case 0b0100:
									switch (n3)
									{
										case 0b1010:
											return I.Ldc(m: R(n1), tbr);
										case 0b1011:
											return I.Jsrn(m: at(R(n1)));
									}
									break;
								case 0b1000:
									switch (n3)
									{
										case 0b0000:
											return I.Mulr(r0, n: R(n1));
										case 0b0001:
											return I.Clipu_b(n: R(n1));
										case 0b0100:
											return I.Divu(r0, n: R(n1));
										case 0b0101:
											return I.Clipu_w(n: R(n1));
										case 0b1011:
											return I.Mov_b(r0, n: at(p(R(n1))));
									}
									break;
								case 0b1001:
									switch (n3)
									{
										case 0b0001:
											return I.Clips_b(n: R(n1));
										case 0b0100:
											return I.Divs(r0, n: R(n1));
										case 0b0101:
											return I.Clips_w(n: R(n1));
										case 0b1011:
											return I.Mov_w(r0, n: at(p(R(n1))));
									}
									break;
								case 0b1010:
									switch (n3)
									{
										case 0b1011:
											return I.Mov_l(r0, n: at(p(R(n1))));
									}
									break;
								case 0b1100:
									switch (n3)
									{
										case 0b1011:
											return I.Mov_b(n: at(m(R(n1))), r0);
									}
									break;
								case 0b1101:
									switch (n3)
									{
										case 0b1011:
											return I.Mov_w(n: at(m(R(n1))), r0);
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b0001:
											return I.Stbank(r0, n: at(R(n1)));
										case 0b0101:
											return I.Ldbank(m: at(R(n1)), r0);
										case 0b1011:
											return I.Mov_l(n: at(m(R(n1))), r0);
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b0000:
											return I.Movmu_l(m: R(n1), at(m(R(r15))));
										case 0b0001:
											return I.Movml_l(m: R(n1), at(m(R(r15))));
										case 0b0100:
											return I.Movmu_l(at(p(R(r15))), n: R(n1));
										case 0b0101:
											return I.Movml_l(at(p(R(r15))), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b1000:
					switch (n1)
					{
						case 0b0011:
							switch (n2)
							{
								default: j003:
									switch (n3)
									{
										default: j004:
											return I.Jsrn_ls(d: (n2 << 4) | n3, tbr);
									}
									break;
							}
							break;
						case 0b0110:
							switch (n2)
							{
								default: j005:
									switch (n3)
									{
										default: j006:
											return I.Bclr_or_Bset(n0, n1, n2, n3, 
											/* 10000110nnnn0iii */ () => I.Bclr(i: n3 & 0b0111, n: R(n2)),
												/* 10000110nnnn1iii */ () => I.Bset(i: n3 & 0b0111, n: R(n2)));
									}
									break;
							}
							break;
						case 0b0111:
							switch (n2)
							{
								default: j007:
									switch (n3)
									{
										default: j008:
											return I.Bld_or_Bst(n0, n1, n2, n3, 
											/* 10000111nnnn1iii */ () => I.Bld(i: n3 & 0b0111, n: R(n2)),
												/* 10000111nnnn0iii */ () => I.Bst(i: n3 & 0b0111, n: R(n2)));
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
