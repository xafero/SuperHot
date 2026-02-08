using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d122A2E33E44A
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
								case 0b0000:
									switch (n3)
									{
										case 0b1000:
											return I.Clrt();
										case 0b1001:
											return I.Nop();
										case 0b1011:
											return I.Rts();
									}
									break;
								case 0b0001:
									switch (n3)
									{
										case 0b1000:
											return I.Sett();
										case 0b1001:
											return I.Div0u();
										case 0b1011:
											return I.Sleep();
									}
									break;
								case 0b0010:
									switch (n3)
									{
										case 0b1000:
											return I.Clrmac();
										case 0b1011:
											return I.Rte();
									}
									break;
							}
							goto j001;
						default: j001:
							switch (n2)
							{
								case 0b0000:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(sr, n: R(n1));
										case 0b1010:
											return I.Sts(mach, n: R(n1));
									}
									goto j002;
								case 0b0001:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(gbr, n: R(n1));
										case 0b1010:
											return I.Sts(macl, n: R(n1));
									}
									goto j002;
								case 0b0010:
									switch (n3)
									{
										case 0b0010:
											return I.Stc(vbr, n: R(n1));
										case 0b1001:
											return I.Movt(n: R(n1));
										case 0b1010:
											return I.Sts(pr, n: R(n1));
									}
									goto j002;
								default: j002:
									switch (n3)
									{
										case 0b0100:
											return I.Mov_b_rs(m: R(n2), r0, n: R(n1));
										case 0b0101:
											return I.Mov_w_rs(m: R(n2), r0, n: R(n1));
										case 0b0110:
											return I.Mov_l_rs(m: R(n2), r0, n: R(n1));
										case 0b1100:
											return I.Mov_b_ls(r0, m: R(n2), n: R(n1));
										case 0b1101:
											return I.Mov_w_ls(r0, m: R(n2), n: R(n1));
										case 0b1110:
											return I.Mov_l_ls(r0, m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0001:
					switch (n1)
					{
						default: j003:
							switch (n2)
							{
								default: j004:
									switch (n3)
									{
										default: j005:
											return I.Mov_l_rs(m: R(n2), d: n3, n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0010:
					switch (n1)
					{
						default: j006:
							switch (n2)
							{
								default: j007:
									switch (n3)
									{
										case 0b0000:
											return I.Mov_b(m: R(n2), n: at(R(n1)));
										case 0b0001:
											return I.Mov_w(m: R(n2), n: at(R(n1)));
										case 0b0010:
											return I.Mov_l(m: R(n2), n: at(R(n1)));
										case 0b0100:
											return I.Mov_b(m: R(n2), n: at(m(R(n1))));
										case 0b0101:
											return I.Mov_w(m: R(n2), n: at(m(R(n1))));
										case 0b0110:
											return I.Mov_l(m: R(n2), n: at(m(R(n1))));
										case 0b0111:
											return I.Div0s(m: R(n2), n: R(n1));
										case 0b1000:
											return I.Tst(m: R(n2), n: R(n1));
										case 0b1001:
											return I.And(m: R(n2), n: R(n1));
										case 0b1010:
											return I.Xor(m: R(n2), n: R(n1));
										case 0b1011:
											return I.Or(m: R(n2), n: R(n1));
										case 0b1100:
											return I.Cmpstr(m: R(n2), n: R(n1));
										case 0b1101:
											return I.Xtrct(m: R(n2), n: R(n1));
										case 0b1110:
											return I.Mulu_w(m: R(n2), n: R(n1));
										case 0b1111:
											return I.Muls_w(m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0011:
					switch (n1)
					{
						default: j008:
							switch (n2)
							{
								default: j009:
									switch (n3)
									{
										case 0b0000:
											return I.Cmpeq(m: R(n2), n: R(n1));
										case 0b0010:
											return I.Cmphs(m: R(n2), n: R(n1));
										case 0b0011:
											return I.Cmpge(m: R(n2), n: R(n1));
										case 0b0100:
											return I.Div1(m: R(n2), n: R(n1));
										case 0b0110:
											return I.Cmphi(m: R(n2), n: R(n1));
										case 0b0111:
											return I.Cmpgt(m: R(n2), n: R(n1));
										case 0b1000:
											return I.Sub(m: R(n2), n: R(n1));
										case 0b1010:
											return I.Subc(m: R(n2), n: R(n1));
										case 0b1011:
											return I.Subv(m: R(n2), n: R(n1));
										case 0b1100:
											return I.Add(m: R(n2), n: R(n1));
										case 0b1110:
											return I.Addc(m: R(n2), n: R(n1));
										case 0b1111:
											return I.Addv(m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0100:
					switch (n1)
					{
						default: j010:
							switch (n2)
							{
								case 0b0000:
									switch (n3)
									{
										case 0b0000:
											return I.Shll(n: R(n1));
										case 0b0001:
											return I.Shlr(n: R(n1));
										case 0b0010:
											return I.Sts_l(mach, n: at(m(R(n1))));
										case 0b0011:
											return I.Stc_l(sr, n: at(m(R(n1))));
										case 0b0100:
											return I.Rotl(n: R(n1));
										case 0b0101:
											return I.Rotr(n: R(n1));
										case 0b0110:
											return I.Lds_l(m: at(p(R(n1))), mach);
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), sr);
										case 0b1000:
											return I.Shll2(n: R(n1));
										case 0b1001:
											return I.Shlr2(n: R(n1));
										case 0b1010:
											return I.Lds(m: R(n1), mach);
										case 0b1011:
											return I.Jsr(n: at(R(n1)));
										case 0b1110:
											return I.Ldc(m: R(n1), sr);
									}
									goto j011;
								case 0b0001:
									switch (n3)
									{
										case 0b0001:
											return I.Cmppz(n: R(n1));
										case 0b0010:
											return I.Sts_l(macl, n: at(m(R(n1))));
										case 0b0011:
											return I.Stc_l(gbr, n: at(m(R(n1))));
										case 0b0101:
											return I.Cmppl(n: R(n1));
										case 0b0110:
											return I.Lds_l(m: at(p(R(n1))), macl);
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), gbr);
										case 0b1000:
											return I.Shll8(n: R(n1));
										case 0b1001:
											return I.Shlr8(n: R(n1));
										case 0b1010:
											return I.Lds(m: R(n1), macl);
										case 0b1011:
											return I.Tas_b(n: at(R(n1)));
										case 0b1110:
											return I.Ldc(m: R(n1), gbr);
									}
									goto j011;
								case 0b0010:
									switch (n3)
									{
										case 0b0000:
											return I.Shal(n: R(n1));
										case 0b0001:
											return I.Shar(n: R(n1));
										case 0b0010:
											return I.Sts_l(pr, n: at(m(R(n1))));
										case 0b0011:
											return I.Stc_l(vbr, n: at(m(R(n1))));
										case 0b0100:
											return I.Rotcl(n: R(n1));
										case 0b0101:
											return I.Rotcr(n: R(n1));
										case 0b0110:
											return I.Lds_l(m: at(p(R(n1))), pr);
										case 0b0111:
											return I.Ldc_l(m: at(p(R(n1))), vbr);
										case 0b1000:
											return I.Shll16(n: R(n1));
										case 0b1001:
											return I.Shlr16(n: R(n1));
										case 0b1010:
											return I.Lds(m: R(n1), pr);
										case 0b1011:
											return I.Jmp(n: at(R(n1)));
										case 0b1110:
											return I.Ldc(m: R(n1), vbr);
									}
									goto j011;
								default: j011:
									switch (n3)
									{
										case 0b1111:
											return I.Mac_w(m: at(p(R(n2))), n: at(p(R(n1))));
									}
									break;
							}
							break;
					}
					break;
				case 0b0101:
					switch (n1)
					{
						default: j012:
							switch (n2)
							{
								default: j013:
									switch (n3)
									{
										default: j014:
											return I.Mov_l_ls(d: n3, m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0110:
					switch (n1)
					{
						default: j015:
							switch (n2)
							{
								default: j016:
									switch (n3)
									{
										case 0b0000:
											return I.Mov_b(m: at(R(n2)), n: R(n1));
										case 0b0001:
											return I.Mov_w(m: at(R(n2)), n: R(n1));
										case 0b0010:
											return I.Mov_l(m: at(R(n2)), n: R(n1));
										case 0b0011:
											return I.Mov(m: R(n2), n: R(n1));
										case 0b0100:
											return I.Mov_b(m: at(p(R(n2))), n: R(n1));
										case 0b0101:
											return I.Mov_w(m: at(p(R(n2))), n: R(n1));
										case 0b0110:
											return I.Mov_l(m: at(p(R(n2))), n: R(n1));
										case 0b0111:
											return I.Not(m: R(n2), n: R(n1));
										case 0b1000:
											return I.Swap_b(m: R(n2), n: R(n1));
										case 0b1001:
											return I.Swap_w(m: R(n2), n: R(n1));
										case 0b1010:
											return I.Negc(m: R(n2), n: R(n1));
										case 0b1011:
											return I.Neg(m: R(n2), n: R(n1));
										case 0b1100:
											return I.Extu_b(m: R(n2), n: R(n1));
										case 0b1101:
											return I.Extu_w(m: R(n2), n: R(n1));
										case 0b1110:
											return I.Exts_b(m: R(n2), n: R(n1));
										case 0b1111:
											return I.Exts_w(m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0111:
					switch (n1)
					{
						default: j017:
							switch (n2)
							{
								default: j018:
									switch (n3)
									{
										default: j019:
											return I.Add(i: (n2 << 4) | n3, n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b1000:
					switch (n1)
					{
						case 0b0000:
							switch (n2)
							{
								default: j020:
									switch (n3)
									{
										default: j021:
											return I.Mov_b_rs(r0, d: n3, n: R(n2));
									}
									break;
							}
							break;
						case 0b0001:
							switch (n2)
							{
								default: j022:
									switch (n3)
									{
										default: j023:
											return I.Mov_w_rs(r0, d: n3, n: R(n2));
									}
									break;
							}
							break;
						case 0b0100:
							switch (n2)
							{
								default: j024:
									switch (n3)
									{
										default: j025:
											return I.Mov_b_ls(d: n3, m: R(n2), r0);
									}
									break;
							}
							break;
						case 0b0101:
							switch (n2)
							{
								default: j026:
									switch (n3)
									{
										default: j027:
											return I.Mov_w_ls(d: n3, m: R(n2), r0);
									}
									break;
							}
							break;
						case 0b1000:
							switch (n2)
							{
								default: j028:
									switch (n3)
									{
										default: j029:
											return I.Cmpeq(i: (n2 << 4) | n3, r0);
									}
									break;
							}
							break;
						case 0b1001:
							switch (n2)
							{
								default: j030:
									switch (n3)
									{
										default: j031:
											return I.Bt(d: (n2 << 4) | n3);
									}
									break;
							}
							break;
						case 0b1011:
							switch (n2)
							{
								default: j032:
									switch (n3)
									{
										default: j033:
											return I.Bf(d: (n2 << 4) | n3);
									}
									break;
							}
							break;
					}
					break;
				case 0b1001:
					switch (n1)
					{
						default: j034:
							switch (n2)
							{
								default: j035:
									switch (n3)
									{
										default: j036:
											return I.Mov_w_ls(d: (n2 << 4) | n3, pc, n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b1010:
					switch (n1)
					{
						default: j037:
							switch (n2)
							{
								default: j038:
									switch (n3)
									{
										default: j039:
											return I.Bra(d: (n1 << 8) | ((n2 << 4) | n3));
									}
									break;
							}
							break;
					}
					break;
				case 0b1011:
					switch (n1)
					{
						default: j040:
							switch (n2)
							{
								default: j041:
									switch (n3)
									{
										default: j042:
											return I.Bsr(d: (n1 << 8) | ((n2 << 4) | n3));
									}
									break;
							}
							break;
					}
					break;
				case 0b1100:
					switch (n1)
					{
						case 0b0000:
							switch (n2)
							{
								default: j043:
									switch (n3)
									{
										default: j044:
											return I.Mov_b_rs(r0, d: (n2 << 4) | n3, gbr);
									}
									break;
							}
							break;
						case 0b0001:
							switch (n2)
							{
								default: j045:
									switch (n3)
									{
										default: j046:
											return I.Mov_w_rs(r0, d: (n2 << 4) | n3, gbr);
									}
									break;
							}
							break;
						case 0b0010:
							switch (n2)
							{
								default: j047:
									switch (n3)
									{
										default: j048:
											return I.Mov_l_rs(r0, d: (n2 << 4) | n3, gbr);
									}
									break;
							}
							break;
						case 0b0011:
							switch (n2)
							{
								default: j049:
									switch (n3)
									{
										default: j050:
											return I.Trapa(i: (n2 << 4) | n3);
									}
									break;
							}
							break;
						case 0b0100:
							switch (n2)
							{
								default: j051:
									switch (n3)
									{
										default: j052:
											return I.Mov_b_ls(d: (n2 << 4) | n3, gbr, r0);
									}
									break;
							}
							break;
						case 0b0101:
							switch (n2)
							{
								default: j053:
									switch (n3)
									{
										default: j054:
											return I.Mov_w_ls(d: (n2 << 4) | n3, gbr, r0);
									}
									break;
							}
							break;
						case 0b0110:
							switch (n2)
							{
								default: j055:
									switch (n3)
									{
										default: j056:
											return I.Mov_l_ls(d: (n2 << 4) | n3, gbr, r0);
									}
									break;
							}
							break;
						case 0b0111:
							switch (n2)
							{
								default: j057:
									switch (n3)
									{
										default: j058:
											return I.Mova_ls(d: (n2 << 4) | n3, pc, r0);
									}
									break;
							}
							break;
						case 0b1000:
							switch (n2)
							{
								default: j059:
									switch (n3)
									{
										default: j060:
											return I.Tst(i: (n2 << 4) | n3, r0);
									}
									break;
							}
							break;
						case 0b1001:
							switch (n2)
							{
								default: j061:
									switch (n3)
									{
										default: j062:
											return I.And(i: (n2 << 4) | n3, r0);
									}
									break;
							}
							break;
						case 0b1010:
							switch (n2)
							{
								default: j063:
									switch (n3)
									{
										default: j064:
											return I.Xor(i: (n2 << 4) | n3, r0);
									}
									break;
							}
							break;
						case 0b1011:
							switch (n2)
							{
								default: j065:
									switch (n3)
									{
										default: j066:
											return I.Or(i: (n2 << 4) | n3, r0);
									}
									break;
							}
							break;
						case 0b1100:
							switch (n2)
							{
								default: j067:
									switch (n3)
									{
										default: j068:
											return I.Tst_b_rs(i: (n2 << 4) | n3, r0, gbr);
									}
									break;
							}
							break;
						case 0b1101:
							switch (n2)
							{
								default: j069:
									switch (n3)
									{
										default: j070:
											return I.And_b_rs(i: (n2 << 4) | n3, r0, gbr);
									}
									break;
							}
							break;
						case 0b1110:
							switch (n2)
							{
								default: j071:
									switch (n3)
									{
										default: j072:
											return I.Xor_b_rs(i: (n2 << 4) | n3, r0, gbr);
									}
									break;
							}
							break;
						case 0b1111:
							switch (n2)
							{
								default: j073:
									switch (n3)
									{
										default: j074:
											return I.Or_b_rs(i: (n2 << 4) | n3, r0, gbr);
									}
									break;
							}
							break;
					}
					break;
				case 0b1101:
					switch (n1)
					{
						default: j075:
							switch (n2)
							{
								default: j076:
									switch (n3)
									{
										default: j077:
											return I.Mov_l_ls(d: (n2 << 4) | n3, pc, n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b1110:
					switch (n1)
					{
						default: j078:
							switch (n2)
							{
								default: j079:
									switch (n3)
									{
										default: j080:
											return I.Mov(i: (n2 << 4) | n3, n: R(n1));
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
