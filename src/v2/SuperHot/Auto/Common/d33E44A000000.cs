using System;
using SuperHot;
using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot2.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot2.Auto.Common
{
	internal static class d33E44A000000
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
								case 0b0011:
									switch (n3)
									{
										case 0b1000:
											return I.Ldtlb();
									}
									break;
								case 0b0100:
									switch (n3)
									{
										case 0b1000:
											return I.Clrs();
									}
									break;
								case 0b0101:
									switch (n3)
									{
										case 0b1000:
											return I.Sets();
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
										case 0b0010:
											return I.Stc(ssr, n: R(n1));
									}
									break;
								case 0b0100:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(spc, n: R(n1));
									}
									break;
								case 0b0101:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r5_bank, n: R(n1));
									}
									break;
								case 0b0110:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r6_bank, n: R(n1));
									}
									break;
								case 0b0111:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r7_bank, n: R(n1));
									}
									break;
								case 0b1000:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r0_bank, n: R(n1));
									}
									break;
								case 0b1001:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r1_bank, n: R(n1));
									}
									break;
								case 0b1010:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r2_bank, n: R(n1));
									}
									break;
								case 0b1011:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r3_bank, n: R(n1));
									}
									break;
								case 0b1100:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r4_bank, n: R(n1));
									}
									break;
								case 0b1101:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r5_bank, n: R(n1));
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r6_bank, n: R(n1));
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(r7_bank, n: R(n1));
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
										case 0b0011:
											return I.Stc_l(ssr, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), ssr);
										case 0b1110:
											return I.Ldc(m: R(n1), ssr);
									}
									break;
								case 0b0100:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(spc, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), spc);
										case 0b1110:
											return I.Ldc(m: R(n1), spc);
									}
									break;
								case 0b0101:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r5_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r5_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r5_bank);
									}
									break;
								case 0b0110:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r6_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r6_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r6_bank);
									}
									break;
								case 0b0111:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r7_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r7_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r7_bank);
									}
									break;
								case 0b1000:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r0_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r0_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r0_bank);
									}
									break;
								case 0b1001:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r1_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r1_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r1_bank);
									}
									break;
								case 0b1010:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r2_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r2_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r2_bank);
									}
									break;
								case 0b1011:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r3_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r3_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r3_bank);
									}
									break;
								case 0b1100:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r4_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r4_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r4_bank);
									}
									break;
								case 0b1101:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r5_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r5_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r5_bank);
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r6_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r6_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r6_bank);
									}
									break;
								case 0b1111:
									switch (n3)
									{
										case 0b0011:
											return I.Stc_l(r7_bank, n: at(m(R(n1))));
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), r7_bank);
										case 0b1110:
											return I.Ldc(m: R(n1), r7_bank);
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
