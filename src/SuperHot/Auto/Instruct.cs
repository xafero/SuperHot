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
			return new I(O.Add, a1, a2);
		}

		internal static I Addc(A a1, A a2)
		{
			return new I(O.Addc, a1, a2);
		}

		internal static I Addv(A a1, A a2)
		{
			return new I(O.Addv, a1, a2);
		}

		internal static I And(A a1, A a2)
		{
			return new I(O.And, a1, a2);
		}

		internal static I And_b(A a1, A a2)
		{
			return new I(O.And_b, a1, a2);
		}

		internal static I Bclr(A a1, A a2)
		{
			return new I(O.Bclr, a1, a2);
		}

		internal static I Bf(A a1)
		{
			return new I(O.Bf, a1);
		}

		internal static I Bf_s(A a1)
		{
			return new I(O.Bf_s, a1);
		}

		internal static I Bld(A a1, A a2)
		{
			return new I(O.Bld, a1, a2);
		}

		internal static I Bra(A a1)
		{
			return new I(O.Bra, a1);
		}

		internal static I Braf(A a1)
		{
			return new I(O.Braf, a1);
		}

		internal static I Bset(A a1, A a2)
		{
			return new I(O.Bset, a1, a2);
		}

		internal static I Bsr(A a1)
		{
			return new I(O.Bsr, a1);
		}

		internal static I Bsrf(A a1)
		{
			return new I(O.Bsrf, a1);
		}

		internal static I Bst(A a1, A a2)
		{
			return new I(O.Bst, a1, a2);
		}

		internal static I Bt(A a1)
		{
			return new I(O.Bt, a1);
		}

		internal static I Bt_s(A a1)
		{
			return new I(O.Bt_s, a1);
		}

		internal static I Clips_b(A a1)
		{
			return new I(O.Clips_b, a1);
		}

		internal static I Clips_w(A a1)
		{
			return new I(O.Clips_w, a1);
		}

		internal static I Clipu_b(A a1)
		{
			return new I(O.Clipu_b, a1);
		}

		internal static I Clipu_w(A a1)
		{
			return new I(O.Clipu_w, a1);
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
			return new I(O.CmpEq, a1, a2);
		}

		internal static I CmpGe(A a1, A a2)
		{
			return new I(O.CmpGe, a1, a2);
		}

		internal static I CmpGt(A a1, A a2)
		{
			return new I(O.CmpGt, a1, a2);
		}

		internal static I CmpHi(A a1, A a2)
		{
			return new I(O.CmpHi, a1, a2);
		}

		internal static I CmpHs(A a1, A a2)
		{
			return new I(O.CmpHs, a1, a2);
		}

		internal static I CmpPl(A a1)
		{
			return new I(O.CmpPl, a1);
		}

		internal static I CmpPz(A a1)
		{
			return new I(O.CmpPz, a1);
		}

		internal static I CmpStr(A a1, A a2)
		{
			return new I(O.CmpStr, a1, a2);
		}

		internal static I Div0s(A a1, A a2)
		{
			return new I(O.Div0s, a1, a2);
		}

		internal static I Div0u()
		{
			return new I(O.Div0u);
		}

		internal static I Div1(A a1, A a2)
		{
			return new I(O.Div1, a1, a2);
		}

		internal static I Divs(A a1, A a2)
		{
			return new I(O.Divs, a1, a2);
		}

		internal static I Divu(A a1, A a2)
		{
			return new I(O.Divu, a1, a2);
		}

		internal static I Dmuls_l(A a1, A a2)
		{
			return new I(O.Dmuls_l, a1, a2);
		}

		internal static I Dmulu_l(A a1, A a2)
		{
			return new I(O.Dmulu_l, a1, a2);
		}

		internal static I Dt(A a1)
		{
			return new I(O.Dt, a1);
		}

		internal static I Exts_b(A a1, A a2)
		{
			return new I(O.Exts_b, a1, a2);
		}

		internal static I Exts_w(A a1, A a2)
		{
			return new I(O.Exts_w, a1, a2);
		}

		internal static I Extu_b(A a1, A a2)
		{
			return new I(O.Extu_b, a1, a2);
		}

		internal static I Extu_w(A a1, A a2)
		{
			return new I(O.Extu_w, a1, a2);
		}

		internal static I Fabs(A a1)
		{
			return new I(O.Fabs, a1);
		}

		internal static I Fadd(A a1, A a2)
		{
			return new I(O.Fadd, a1, a2);
		}

		internal static I FcmpEq(A a1, A a2)
		{
			return new I(O.FcmpEq, a1, a2);
		}

		internal static I FcmpGt(A a1, A a2)
		{
			return new I(O.FcmpGt, a1, a2);
		}

		internal static I Fcnvds(A a1, A a2)
		{
			return new I(O.Fcnvds, a1, a2);
		}

		internal static I Fcnvsd(A a1, A a2)
		{
			return new I(O.Fcnvsd, a1, a2);
		}

		internal static I Fdiv(A a1, A a2)
		{
			return new I(O.Fdiv, a1, a2);
		}

		internal static I Fipr(A a1, A a2)
		{
			return new I(O.Fipr, a1, a2);
		}

		internal static I Fldi0(A a1)
		{
			return new I(O.Fldi0, a1);
		}

		internal static I Fldi1(A a1)
		{
			return new I(O.Fldi1, a1);
		}

		internal static I Flds(A a1, A a2)
		{
			return new I(O.Flds, a1, a2);
		}

		internal static I Float(A a1, A a2)
		{
			return new I(O.Float, a1, a2);
		}

		internal static I Fmac(A a1, A a2, A a3)
		{
			return new I(O.Fmac, a1, a2, a3);
		}

		internal static I Fmov(A a1, A a2)
		{
			return new I(O.Fmov, a1, a2);
		}

		internal static I Fmul(A a1, A a2)
		{
			return new I(O.Fmul, a1, a2);
		}

		internal static I Fneg(A a1)
		{
			return new I(O.Fneg, a1);
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
			return new I(O.Fsca, a1, a2);
		}

		internal static I Fschg()
		{
			return new I(O.Fschg);
		}

		internal static I Fsqrt(A a1)
		{
			return new I(O.Fsqrt, a1);
		}

		internal static I Fsrra(A a1)
		{
			return new I(O.Fsrra, a1);
		}

		internal static I Fsts(A a1, A a2)
		{
			return new I(O.Fsts, a1, a2);
		}

		internal static I Fsub(A a1, A a2)
		{
			return new I(O.Fsub, a1, a2);
		}

		internal static I Ftrc(A a1, A a2)
		{
			return new I(O.Ftrc, a1, a2);
		}

		internal static I Ftrv(A a1, A a2)
		{
			return new I(O.Ftrv, a1, a2);
		}

		internal static I Icbi(A a1)
		{
			return new I(O.Icbi, a1);
		}

		internal static I Jmp(A a1)
		{
			return new I(O.Jmp, a1);
		}

		internal static I Jsr(A a1)
		{
			return new I(O.Jsr, a1);
		}

		internal static I JsrN(A a1)
		{
			return new I(O.JsrN, a1);
		}

		internal static I Ldbank(A a1, A a2)
		{
			return new I(O.Ldbank, a1, a2);
		}

		internal static I Ldc(A a1, A a2)
		{
			return new I(O.Ldc, a1, a2);
		}

		internal static I Ldc_l(A a1, A a2)
		{
			return new I(O.Ldc_l, a1, a2);
		}

		internal static I Lds(A a1, A a2)
		{
			return new I(O.Lds, a1, a2);
		}

		internal static I Lds_l(A a1, A a2)
		{
			return new I(O.Lds_l, a1, a2);
		}

		internal static I Ldtlb()
		{
			return new I(O.Ldtlb);
		}

		internal static I Mac_l(A a1, A a2)
		{
			return new I(O.Mac_l, a1, a2);
		}

		internal static I Mac_w(A a1, A a2)
		{
			return new I(O.Mac_w, a1, a2);
		}

		internal static I Mov(A a1, A a2)
		{
			return new I(O.Mov, a1, a2);
		}

		internal static I Mov_b(A a1, A a2)
		{
			return new I(O.Mov_b, a1, a2);
		}

		internal static I Mov_l(A a1, A a2)
		{
			return new I(O.Mov_l, a1, a2);
		}

		internal static I Mov_w(A a1, A a2)
		{
			return new I(O.Mov_w, a1, a2);
		}

		internal static I Mova(A a1, A a2)
		{
			return new I(O.Mova, a1, a2);
		}

		internal static I Movca_l(A a1, A a2)
		{
			return new I(O.Movca_l, a1, a2);
		}

		internal static I Movco_l(A a1, A a2)
		{
			return new I(O.Movco_l, a1, a2);
		}

		internal static I Movli_l(A a1, A a2)
		{
			return new I(O.Movli_l, a1, a2);
		}

		internal static I Movml_l(A a1, A a2)
		{
			return new I(O.Movml_l, a1, a2);
		}

		internal static I Movmu_l(A a1, A a2)
		{
			return new I(O.Movmu_l, a1, a2);
		}

		internal static I Movrt(A a1)
		{
			return new I(O.Movrt, a1);
		}

		internal static I Movt(A a1)
		{
			return new I(O.Movt, a1);
		}

		internal static I Movua_l(A a1, A a2)
		{
			return new I(O.Movua_l, a1, a2);
		}

		internal static I Mul_l(A a1, A a2)
		{
			return new I(O.Mul_l, a1, a2);
		}

		internal static I Mulr(A a1, A a2)
		{
			return new I(O.Mulr, a1, a2);
		}

		internal static I Muls_w(A a1, A a2)
		{
			return new I(O.Muls_w, a1, a2);
		}

		internal static I Mulu_w(A a1, A a2)
		{
			return new I(O.Mulu_w, a1, a2);
		}

		internal static I Neg(A a1, A a2)
		{
			return new I(O.Neg, a1, a2);
		}

		internal static I Negc(A a1, A a2)
		{
			return new I(O.Negc, a1, a2);
		}

		internal static I Nop()
		{
			return new I(O.Nop);
		}

		internal static I Not(A a1, A a2)
		{
			return new I(O.Not, a1, a2);
		}

		internal static I Nott()
		{
			return new I(O.Nott);
		}

		internal static I Ocbi(A a1)
		{
			return new I(O.Ocbi, a1);
		}

		internal static I Ocbp(A a1)
		{
			return new I(O.Ocbp, a1);
		}

		internal static I Ocbwb(A a1)
		{
			return new I(O.Ocbwb, a1);
		}

		internal static I Or(A a1, A a2)
		{
			return new I(O.Or, a1, a2);
		}

		internal static I Or_b(A a1, A a2)
		{
			return new I(O.Or_b, a1, a2);
		}

		internal static I Pref(A a1)
		{
			return new I(O.Pref, a1);
		}

		internal static I Prefi(A a1)
		{
			return new I(O.Prefi, a1);
		}

		internal static I Resbank()
		{
			return new I(O.Resbank);
		}

		internal static I Rotcl(A a1)
		{
			return new I(O.Rotcl, a1);
		}

		internal static I Rotcr(A a1)
		{
			return new I(O.Rotcr, a1);
		}

		internal static I Rotl(A a1)
		{
			return new I(O.Rotl, a1);
		}

		internal static I Rotr(A a1)
		{
			return new I(O.Rotr, a1);
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
			return new I(O.RtvN, a1);
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
			return new I(O.Shad, a1, a2);
		}

		internal static I Shal(A a1)
		{
			return new I(O.Shal, a1);
		}

		internal static I Shar(A a1)
		{
			return new I(O.Shar, a1);
		}

		internal static I Shld(A a1, A a2)
		{
			return new I(O.Shld, a1, a2);
		}

		internal static I Shll(A a1)
		{
			return new I(O.Shll, a1);
		}

		internal static I Shll16(A a1)
		{
			return new I(O.Shll16, a1);
		}

		internal static I Shll2(A a1)
		{
			return new I(O.Shll2, a1);
		}

		internal static I Shll8(A a1)
		{
			return new I(O.Shll8, a1);
		}

		internal static I Shlr(A a1)
		{
			return new I(O.Shlr, a1);
		}

		internal static I Shlr16(A a1)
		{
			return new I(O.Shlr16, a1);
		}

		internal static I Shlr2(A a1)
		{
			return new I(O.Shlr2, a1);
		}

		internal static I Shlr8(A a1)
		{
			return new I(O.Shlr8, a1);
		}

		internal static I Sleep()
		{
			return new I(O.Sleep);
		}

		internal static I Stbank(A a1, A a2)
		{
			return new I(O.Stbank, a1, a2);
		}

		internal static I Stc(A a1, A a2)
		{
			return new I(O.Stc, a1, a2);
		}

		internal static I Stc_l(A a1, A a2)
		{
			return new I(O.Stc_l, a1, a2);
		}

		internal static I Sts(A a1, A a2)
		{
			return new I(O.Sts, a1, a2);
		}

		internal static I Sts_l(A a1, A a2)
		{
			return new I(O.Sts_l, a1, a2);
		}

		internal static I Sub(A a1, A a2)
		{
			return new I(O.Sub, a1, a2);
		}

		internal static I Subc(A a1, A a2)
		{
			return new I(O.Subc, a1, a2);
		}

		internal static I Subv(A a1, A a2)
		{
			return new I(O.Subv, a1, a2);
		}

		internal static I Swap_b(A a1, A a2)
		{
			return new I(O.Swap_b, a1, a2);
		}

		internal static I Swap_w(A a1, A a2)
		{
			return new I(O.Swap_w, a1, a2);
		}

		internal static I Synco()
		{
			return new I(O.Synco);
		}

		internal static I Tas_b(A a1)
		{
			return new I(O.Tas_b, a1);
		}

		internal static I Trapa(A a1)
		{
			return new I(O.Trapa, a1);
		}

		internal static I Tst(A a1, A a2)
		{
			return new I(O.Tst, a1, a2);
		}

		internal static I Tst_b(A a1, A a2)
		{
			return new I(O.Tst_b, a1, a2);
		}

		internal static I Word(A a1)
		{
			if (a1 is IntArg ia)
				a1 = new HexArg(ia.Val);
			return new I(O.Word, a1);
		}

		internal static I Xor(A a1, A a2)
		{
			return new I(O.Xor, a1, a2);
		}

		internal static I Xor_b(A a1, A a2)
		{
			return new I(O.Xor_b, a1, a2);
		}

		internal static I Xtrct(A a1, A a2)
		{
			return new I(O.Xtrct, a1, a2);
		}
	}
}
