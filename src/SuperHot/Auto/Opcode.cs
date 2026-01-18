using System;
using D = SuperHot.Dialect;
using O = SuperHot.OpMeta;

namespace SuperHot.Auto
{
	public enum Opcode
	{
		None = 0,

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r10")]
		Add, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Addc, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Addv, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		And, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		And_b, 

		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bclr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bf, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bf_s, 

		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bld, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xfffff004")]
		Bra, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Braf, 

		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bset, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xfffff004")]
		Bsr, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Bsrf, 

		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bst, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bt, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bt_s, 

		[O([D.Sh2a], 1, "r0", "r10")]
		Clips_b, 

		[O([D.Sh2a], 1, "r0", "r10")]
		Clips_w, 

		[O([D.Sh2a], 1, "r0", "r10")]
		Clipu_b, 

		[O([D.Sh2a], 1, "r0", "r10")]
		Clipu_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrmac, 

		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrs, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrt, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r0")]
		CmpEq, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpGe, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpGt, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpHi, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpHs, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		CmpPl, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		CmpPz, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpStr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Div0s, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Div0u, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Div1, 

		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Divs, 

		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Divu, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Dmuls_l, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Dmulu_l, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Dt, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Exts_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Exts_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Extu_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Extu_w, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fabs, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fadd, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		FcmpEq, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		FcmpGt, 

		[O([D.Sh2a,D.Sh4,D.Sh4a], 2, "dr0,fpul", "dr10,fpul")]
		Fcnvds, 

		[O([D.Sh2a,D.Sh4,D.Sh4a], 2, "fpul,dr0", "fpul,dr10")]
		Fcnvsd, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fdiv, 

		[O([D.Sh4,D.Sh4a], 2, "fv0,fv0", "fv12,fv12")]
		Fipr, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fldi0, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fldi1, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fpul", "fr10,fpul")]
		Flds, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fpul,fr0", "fpul,fr10")]
		Float, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 3, "fr0,fr0,fr0", "fr0,fr10,fr10")]
		Fmac, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,fr0", "@(r0,r10),fr10")]
		Fmov, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fmul, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fneg, 

		[O([D.Sh4a])]
		Fpchg, 

		[O([D.Sh4,D.Sh4a])]
		Frchg, 

		[O([D.Sh4,D.Sh4a], 2, "fpul,dr0", "fpul,dr10")]
		Fsca, 

		[O([D.Sh2a,D.Sh4,D.Sh4a])]
		Fschg, 

		[O([D.Sh2a,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fsqrt, 

		[O([D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fsrra, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fpul,fr0", "fpul,fr10")]
		Fsts, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fsub, 

		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fpul", "fr10,fpul")]
		Ftrc, 

		[O([D.Sh4,D.Sh4a], 2, "xmtrx,fv0", "xmtrx,fv12")]
		Ftrv, 

		[O([D.Sh4a], 1, "@r0", "@r10")]
		Icbi, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Jmp, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Jsr, 

		[O([D.Sh2a], 1, "@r0", "@@(1000,tbr)")]
		JsrN, 

		[O([D.Sh2a], 2, "@r0,r0", "@r10,r0")]
		Ldbank, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,sr", "r10,r0_bank")]
		Ldc, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,sr", "@r10+,r0_bank")]
		Ldc_l, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,pr", "r10,fpscr")]
		Lds, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,pr", "@r10+,fpscr")]
		Lds_l, 

		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Ldtlb, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,@r0+", "@r10+,@r10+")]
		Mac_l, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,@r0+", "@r10+,@r10+")]
		Mac_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r10")]
		Mov, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(100,gbr),r0")]
		Mov_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(1000,gbr),r0")]
		Mov_l, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(100,gbr),r0")]
		Mov_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "0x4,r0", "0x100,r0")]
		Mova, 

		[O([D.Sh4,D.Sh4a], 2, "r0,@r0", "r0,@r10")]
		Movca_l, 

		[O([D.Sh4a], 2, "r0,@r0", "r0,@r10")]
		Movco_l, 

		[O([D.Sh4a], 2, "@r0,r0", "@r10,r0")]
		Movli_l, 

		[O([D.Sh2a], 2, "@r15+,r0", "@r15+,r10")]
		Movml_l, 

		[O([D.Sh2a], 2, "@r15+,r0", "@r15+,r10")]
		Movmu_l, 

		[O([D.Sh2a], 1, "r0", "r10")]
		Movrt, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Movt, 

		[O([D.Sh4a], 2, "@r0,r0", "@r10+,r0")]
		Movua_l, 

		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Mul_l, 

		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Mulr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Muls_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Mulu_w, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Neg, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Negc, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Nop, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Not, 

		[O([D.Sh2a])]
		Nott, 

		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbi, 

		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbp, 

		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbwb, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Or, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Or_b, 

		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Pref, 

		[O([D.Sh4a], 1, "@r0", "@r10")]
		Prefi, 

		[O([D.Sh2a])]
		Resbank, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotcl, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotcr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotl, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Rte, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Rts, 

		[O([D.Sh2a])]
		RtsN, 

		[O([D.Sh2a], 1, "r0", "r10")]
		RtvN, 

		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sets, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sett, 

		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Shad, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shal, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shar, 

		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Shld, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll16, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll2, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll8, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr16, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr2, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr8, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sleep, 

		[O([D.Sh2a], 2, "r0,@r0", "r0,@r10")]
		Stbank, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "sr,r0", "r0_bank,r10")]
		Stc, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "sr,@-r0", "r0_bank,@-r10")]
		Stc_l, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "pr,r0", "fpscr,r10")]
		Sts, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "pr,@-r0", "fpscr,@-r10")]
		Sts_l, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Sub, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Subc, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Subv, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Swap_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Swap_w, 

		[O([D.Sh4a])]
		Synco, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Tas_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "#0", "#100")]
		Trapa, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Tst, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Tst_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0000", "0x0000")]
		Word, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Xor, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Xor_b, 

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Xtrct
	}
}
