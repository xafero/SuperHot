using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d2A2E3E44A000
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
								case 0b0101:
									switch (n3)
									{
										case 0b1010:
											return I.Sts(fpul, n: R(n1));
									}
									break;
								case 0b0110:
									switch (n3)
									{
										case 0b1010:
											return I.Sts(fpscr, n: R(n1));
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
								case 0b0101:
									switch (n3)
									{
										case 0b0010:
											return I.Sts_l(fpul, n: at(m(R(n1))));
										case 0b0110:
											return I.Lds_l(m: at(p(R(n1))), fpul);
										case 0b1010:
											return I.Lds(m: R(n1), fpul);
									}
									break;
								case 0b0110:
									switch (n3)
									{
										case 0b0010:
											return I.Sts_l(fpscr, n: at(m(R(n1))));
										case 0b0110:
											return I.Lds_l(m: at(p(R(n1))), fpscr);
										case 0b1010:
											return I.Lds(m: R(n1), fpscr);
									}
									break;
							}
							break;
					}
					break;
				case 0b1111:
					switch (n1)
					{
						default: j003:
							switch (n2)
							{
								case 0b0000:
									switch (n3)
									{
										case 0b1101:
											return I.Fsts(fpul, n: fR(n1));
									}
									goto j004;
								case 0b0001:
									switch (n3)
									{
										case 0b1101:
											return I.Flds(m: fR(n1), fpul);
									}
									goto j004;
								case 0b0010:
									switch (n3)
									{
										case 0b1101:
											return I.Float(fpul, n: fR(n1));
									}
									goto j004;
								case 0b0011:
									switch (n3)
									{
										case 0b1101:
											return I.Ftrc(m: fR(n1), fpul);
									}
									goto j004;
								case 0b0100:
									switch (n3)
									{
										case 0b1101:
											return I.Fneg(n: fR(n1));
									}
									goto j004;
								case 0b0101:
									switch (n3)
									{
										case 0b1101:
											return I.Fabs(n: fR(n1));
									}
									goto j004;
								case 0b1000:
									switch (n3)
									{
										case 0b1101:
											return I.Fldi0(n: fR(n1));
									}
									goto j004;
								case 0b1001:
									switch (n3)
									{
										case 0b1101:
											return I.Fldi1(n: fR(n1));
									}
									goto j004;
								default: j004:
									switch (n3)
									{
										case 0b0000:
											return I.Fadd(m: fR(n2), n: fR(n1));
										case 0b0001:
											return I.Fsub(m: fR(n2), n: fR(n1));
										case 0b0010:
											return I.Fmul(m: fR(n2), n: fR(n1));
										case 0b0011:
											return I.Fdiv(m: fR(n2), n: fR(n1));
										case 0b0100:
											return I.Fcmpeq(m: fR(n2), n: fR(n1));
										case 0b0101:
											return I.Fcmpgt(m: fR(n2), n: fR(n1));
										case 0b0110:
											return I.Fmov_ls(r0, m: R(n2), n: fR(n1));
										case 0b0111:
											return I.Fmov_rs(m: fR(n2), r0, n: R(n1));
										case 0b1000:
											return I.Fmov(m: at(R(n2)), n: fR(n1));
										case 0b1001:
											return I.Fmov(m: at(p(R(n2))), n: fR(n1));
										case 0b1010:
											return I.Fmov(m: fR(n2), n: at(R(n1)));
										case 0b1011:
											return I.Fmov(m: fR(n2), n: at(m(R(n1))));
										case 0b1100:
											return I.Fmov(m: fR(n2), n: fR(n1));
										case 0b1110:
											return I.Fmac(fr0, m: fR(n2), n: fR(n1));
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
