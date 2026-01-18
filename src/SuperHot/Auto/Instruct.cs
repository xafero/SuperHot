using O = SuperHot.Auto.Opcode;
using I = SuperHot.Instruction;
using A = SuperHot.Arg;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace SuperHot.Auto
{
	internal static class Instruct
	{
		internal static I Add(A a1, A a2)
		{
			return new I(O.Add);
		}

		internal static I Addc(A a1, A a2)
		{
			return new I(O.Addc);
		}

		internal static I Addv(A a1, A a2)
		{
			return new I(O.Addv);
		}

		internal static I And(A a1, A a2)
		{
			return new I(O.And);
		}

		internal static I And_b(A a1, A a2)
		{
			return new I(O.And_b);
		}

		internal static I Bclr(A a1, A a2)
		{
			return new I(O.Bclr);
		}

		internal static I Bf(A a1)
		{
			return new I(O.Bf);
		}

		internal static I Bf_s(A a1)
		{
			return new I(O.Bf_s);
		}

		internal static I Bld(A a1, A a2)
		{
			return new I(O.Bld);
		}

		internal static I Bra(A a1)
		{
			return new I(O.Bra);
		}

		internal static I Braf(A a1)
		{
			return new I(O.Braf);
		}

		internal static I Bset(A a1, A a2)
		{
			return new I(O.Bset);
		}

		internal static I Bsr(A a1)
		{
			return new I(O.Bsr);
		}

		internal static I Bsrf(A a1)
		{
			return new I(O.Bsrf);
		}

		internal static I Bst(A a1, A a2)
		{
			return new I(O.Bst);
		}

		internal static I Bt(A a1)
		{
			return new I(O.Bt);
		}

		internal static I Bt_s(A a1)
		{
			return new I(O.Bt_s);
		}

		internal static I Clips_b(A a1)
		{
			return new I(O.Clips_b);
		}

		internal static I Clips_w(A a1)
		{
			return new I(O.Clips_w);
		}

		internal static I Clipu_b(A a1)
		{
			return new I(O.Clipu_b);
		}

		internal static I Clipu_w(A a1)
		{
			return new I(O.Clipu_w);
		}

		internal static I Clrmac()
		{
			return new I(O.Clrmac);
		}

		internal static I Clrs()
		{
			return new I(O.Clrs);
		}

		internal static I Clrt()
		{
			return new I(O.Clrt);
		}

		internal static I CmpEq(A a1, A a2)
		{
			return new I(O.CmpEq);
		}

		internal static I CmpGe(A a1, A a2)
		{
			return new I(O.CmpGe);
		}

		internal static I CmpGt(A a1, A a2)
		{
			return new I(O.CmpGt);
		}

		internal static I CmpHi(A a1, A a2)
		{
			return new I(O.CmpHi);
		}

		internal static I CmpHs(A a1, A a2)
		{
			return new I(O.CmpHs);
		}

		internal static I CmpPl(A a1)
		{
			return new I(O.CmpPl);
		}

		internal static I CmpPz(A a1)
		{
			return new I(O.CmpPz);
		}

		internal static I CmpStr(A a1, A a2)
		{
			return new I(O.CmpStr);
		}

		internal static I Div0s(A a1, A a2)
		{
			return new I(O.Div0s);
		}

		internal static I Div0u()
		{
			return new I(O.Div0u);
		}

		internal static I Div1(A a1, A a2)
		{
			return new I(O.Div1);
		}

		internal static I Divs(A a1, A a2)
		{
			return new I(O.Divs);
		}

		internal static I Divu(A a1, A a2)
		{
			return new I(O.Divu);
		}

		internal static I Dmuls_l(A a1, A a2)
		{
			return new I(O.Dmuls_l);
		}

		internal static I Dmulu_l(A a1, A a2)
		{
			return new I(O.Dmulu_l);
		}

		internal static I Dt(A a1)
		{
			return new I(O.Dt);
		}

		internal static I Exts_b(A a1, A a2)
		{
			return new I(O.Exts_b);
		}

		internal static I Exts_w(A a1, A a2)
		{
			return new I(O.Exts_w);
		}

		internal static I Extu_b(A a1, A a2)
		{
			return new I(O.Extu_b);
		}

		internal static I Extu_w(A a1, A a2)
		{
			return new I(O.Extu_w);
		}

		internal static I Fabs(A a1)
		{
			return new I(O.Fabs);
		}

		internal static I Fadd(A a1, A a2)
		{
			return new I(O.Fadd);
		}

		internal static I FcmpEq(A a1, A a2)
		{
			return new I(O.FcmpEq);
		}

		internal static I FcmpGt(A a1, A a2)
		{
			return new I(O.FcmpGt);
		}

		internal static I Fcnvds(A a1, A a2)
		{
			return new I(O.Fcnvds);
		}

		internal static I Fcnvsd(A a1, A a2)
		{
			return new I(O.Fcnvsd);
		}

		internal static I Fdiv(A a1, A a2)
		{
			return new I(O.Fdiv);
		}

		internal static I Fipr(A a1, A a2)
		{
			return new I(O.Fipr);
		}

		internal static I Fldi0(A a1)
		{
			return new I(O.Fldi0);
		}

		internal static I Fldi1(A a1)
		{
			return new I(O.Fldi1);
		}

		internal static I Flds(A a1, A a2)
		{
			return new I(O.Flds);
		}

		internal static I Float(A a1, A a2)
		{
			return new I(O.Float);
		}

		internal static I Fmac(A a1, A a2, A a3)
		{
			return new I(O.Fmac);
		}

		internal static I Fmov(A a1, A a2)
		{
			return new I(O.Fmov);
		}

		internal static I Fmul(A a1, A a2)
		{
			return new I(O.Fmul);
		}

		internal static I Fneg(A a1)
		{
			return new I(O.Fneg);
		}

		internal static I Fpchg()
		{
			return new I(O.Fpchg);
		}

		internal static I Frchg()
		{
			return new I(O.Frchg);
		}

		internal static I Fsca(A a1, A a2)
		{
			return new I(O.Fsca);
		}

		internal static I Fschg()
		{
			return new I(O.Fschg);
		}

		internal static I Fsqrt(A a1)
		{
			return new I(O.Fsqrt);
		}

		internal static I Fsrra(A a1)
		{
			return new I(O.Fsrra);
		}

		internal static I Fsts(A a1, A a2)
		{
			return new I(O.Fsts);
		}

		internal static I Fsub(A a1, A a2)
		{
			return new I(O.Fsub);
		}

		internal static I Ftrc(A a1, A a2)
		{
			return new I(O.Ftrc);
		}

		internal static I Ftrv(A a1, A a2)
		{
			return new I(O.Ftrv);
		}

		internal static I Icbi(A a1)
		{
			return new I(O.Icbi);
		}

		internal static I Jmp(A a1)
		{
			return new I(O.Jmp);
		}

		internal static I Jsr(A a1)
		{
			return new I(O.Jsr);
		}

		internal static I JsrN(A a1)
		{
			return new I(O.JsrN);
		}

		internal static I Ldbank(A a1, A a2)
		{
			return new I(O.Ldbank);
		}

		internal static I Ldc(A a1, A a2)
		{
			return new I(O.Ldc);
		}

		internal static I Ldc_l(A a1, A a2)
		{
			return new I(O.Ldc_l);
		}

		internal static I Lds(A a1, A a2)
		{
			return new I(O.Lds);
		}

		internal static I Lds_l(A a1, A a2)
		{
			return new I(O.Lds_l);
		}

		internal static I Ldtlb()
		{
			return new I(O.Ldtlb);
		}

		internal static I Mac_l(A a1, A a2)
		{
			return new I(O.Mac_l);
		}

		internal static I Mac_w(A a1, A a2)
		{
			return new I(O.Mac_w);
		}

		internal static I Mov(A a1, A a2)
		{
			return new I(O.Mov);
		}

		internal static I Mov_b(A a1, A a2)
		{
			return new I(O.Mov_b);
		}

		internal static I Mov_l(A a1, A a2)
		{
			return new I(O.Mov_l);
		}

		internal static I Mov_w(A a1, A a2)
		{
			return new I(O.Mov_w);
		}

		internal static I Mova(A a1, A a2)
		{
			return new I(O.Mova);
		}

		internal static I Movca_l(A a1, A a2)
		{
			return new I(O.Movca_l);
		}

		internal static I Movco_l(A a1, A a2)
		{
			return new I(O.Movco_l);
		}

		internal static I Movli_l(A a1, A a2)
		{
			return new I(O.Movli_l);
		}

		internal static I Movml_l(A a1, A a2)
		{
			return new I(O.Movml_l);
		}

		internal static I Movmu_l(A a1, A a2)
		{
			return new I(O.Movmu_l);
		}

		internal static I Movrt(A a1)
		{
			return new I(O.Movrt);
		}

		internal static I Movt(A a1)
		{
			return new I(O.Movt);
		}

		internal static I Movua_l(A a1, A a2)
		{
			return new I(O.Movua_l);
		}

		internal static I Mul_l(A a1, A a2)
		{
			return new I(O.Mul_l);
		}

		internal static I Mulr(A a1, A a2)
		{
			return new I(O.Mulr);
		}

		internal static I Muls_w(A a1, A a2)
		{
			return new I(O.Muls_w);
		}

		internal static I Mulu_w(A a1, A a2)
		{
			return new I(O.Mulu_w);
		}

		internal static I Neg(A a1, A a2)
		{
			return new I(O.Neg);
		}

		internal static I Negc(A a1, A a2)
		{
			return new I(O.Negc);
		}

		internal static I Nop()
		{
			return new I(O.Nop);
		}

		internal static I Not(A a1, A a2)
		{
			return new I(O.Not);
		}

		internal static I Nott()
		{
			return new I(O.Nott);
		}

		internal static I Ocbi(A a1)
		{
			return new I(O.Ocbi);
		}

		internal static I Ocbp(A a1)
		{
			return new I(O.Ocbp);
		}

		internal static I Ocbwb(A a1)
		{
			return new I(O.Ocbwb);
		}

		internal static I Or(A a1, A a2)
		{
			return new I(O.Or);
		}

		internal static I Or_b(A a1, A a2)
		{
			return new I(O.Or_b);
		}

		internal static I Pref(A a1)
		{
			return new I(O.Pref);
		}

		internal static I Prefi(A a1)
		{
			return new I(O.Prefi);
		}

		internal static I Resbank()
		{
			return new I(O.Resbank);
		}

		internal static I Rotcl(A a1)
		{
			return new I(O.Rotcl);
		}

		internal static I Rotcr(A a1)
		{
			return new I(O.Rotcr);
		}

		internal static I Rotl(A a1)
		{
			return new I(O.Rotl);
		}

		internal static I Rotr(A a1)
		{
			return new I(O.Rotr);
		}

		internal static I Rte()
		{
			return new I(O.Rte);
		}

		internal static I Rts()
		{
			return new I(O.Rts);
		}

		internal static I RtsN()
		{
			return new I(O.RtsN);
		}

		internal static I RtvN(A a1)
		{
			return new I(O.RtvN);
		}

		internal static I Sets()
		{
			return new I(O.Sets);
		}

		internal static I Sett()
		{
			return new I(O.Sett);
		}

		internal static I Shad(A a1, A a2)
		{
			return new I(O.Shad);
		}

		internal static I Shal(A a1)
		{
			return new I(O.Shal);
		}

		internal static I Shar(A a1)
		{
			return new I(O.Shar);
		}

		internal static I Shld(A a1, A a2)
		{
			return new I(O.Shld);
		}

		internal static I Shll(A a1)
		{
			return new I(O.Shll);
		}

		internal static I Shll16(A a1)
		{
			return new I(O.Shll16);
		}

		internal static I Shll2(A a1)
		{
			return new I(O.Shll2);
		}

		internal static I Shll8(A a1)
		{
			return new I(O.Shll8);
		}

		internal static I Shlr(A a1)
		{
			return new I(O.Shlr);
		}

		internal static I Shlr16(A a1)
		{
			return new I(O.Shlr16);
		}

		internal static I Shlr2(A a1)
		{
			return new I(O.Shlr2);
		}

		internal static I Shlr8(A a1)
		{
			return new I(O.Shlr8);
		}

		internal static I Sleep()
		{
			return new I(O.Sleep);
		}

		internal static I Stbank(A a1, A a2)
		{
			return new I(O.Stbank);
		}

		internal static I Stc(A a1, A a2)
		{
			return new I(O.Stc);
		}

		internal static I Stc_l(A a1, A a2)
		{
			return new I(O.Stc_l);
		}

		internal static I Sts(A a1, A a2)
		{
			return new I(O.Sts);
		}

		internal static I Sts_l(A a1, A a2)
		{
			return new I(O.Sts_l);
		}

		internal static I Sub(A a1, A a2)
		{
			return new I(O.Sub);
		}

		internal static I Subc(A a1, A a2)
		{
			return new I(O.Subc);
		}

		internal static I Subv(A a1, A a2)
		{
			return new I(O.Subv);
		}

		internal static I Swap_b(A a1, A a2)
		{
			return new I(O.Swap_b);
		}

		internal static I Swap_w(A a1, A a2)
		{
			return new I(O.Swap_w);
		}

		internal static I Synco()
		{
			return new I(O.Synco);
		}

		internal static I Tas_b(A a1)
		{
			return new I(O.Tas_b);
		}

		internal static I Trapa(A a1)
		{
			return new I(O.Trapa);
		}

		internal static I Tst(A a1, A a2)
		{
			return new I(O.Tst);
		}

		internal static I Tst_b(A a1, A a2)
		{
			return new I(O.Tst_b);
		}

		internal static I Word(A a1)
		{
			return new I(O.Word);
		}

		internal static I Xor(A a1, A a2)
		{
			return new I(O.Xor);
		}

		internal static I Xor_b(A a1, A a2)
		{
			return new I(O.Xor_b);
		}

		internal static I Xtrct(A a1, A a2)
		{
			return new I(O.Xtrct);
		}
	}
}
