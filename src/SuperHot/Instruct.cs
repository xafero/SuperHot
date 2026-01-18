using System;
using SuperHot.Auto;

// ReSharper disable InconsistentNaming

namespace SuperHot
{
	internal static class Instruct
	{
		internal static Instruction Addc(object x, object y)
		{
			return new Instruction(Opcode.Addc);
		}

		internal static Instruction Add(object x, object y)
		{
			return new Instruction(Opcode.Add);
		}

		internal static Instruction Addv(object x, object y)
		{
			return new Instruction(Opcode.Addv);
		}

		internal static Instruction And_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction And(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bf_s(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bf(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Braf(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bra(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bsrf(object x)
		{
			return new Instruction(Opcode.Bsrf);
		}

		internal static Instruction Bsr(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bt_s(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bt(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clrmac()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clrt()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpEq(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpGe(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpGt(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpHi(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpHs(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpPl(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpPz(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction CmpStr(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Div0s(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Div0u()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Div1(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Dmuls_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Dmulu_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Dt(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Exts_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Exts_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Extu_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Extu_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fabs(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fadd(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction FcmpEq(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction FcmpGt(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fdiv(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fldi0(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fldi1(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Flds(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Float(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fmac(object x, object y, object z)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fmov(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fmul(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fneg(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fsts(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fsub(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ftrc(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Jmp(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Jsr(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ldc_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ldc(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Lds_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Lds(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mac_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mac_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mova(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mov_b(object x, object y)
		{
			return new Instruction(Opcode.Mov_b);
		}

		internal static Instruction Mov_l(object x, object y)
		{
			return new Instruction(Opcode.Mov_l);
		}

		internal static Instruction Mov_w(object x, object y)
		{
			return new Instruction(Opcode.Mov_w);
		}

		internal static Instruction Mov(object x, object y)
		{
			return new Instruction(Opcode.Mov);
		}

		internal static Instruction Movt(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mul_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Muls_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mulu_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Negc(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Neg(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Nop()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Not(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Or_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Or(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rotcl(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rotcr(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rotl(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rotr(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rte()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Rts()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sett()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bclr(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bld(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bset(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Bst(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clips_b(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clips_w(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clipu_b(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clipu_w(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Divs(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Divu(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fcnvds(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fcnvsd(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fipr(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fpchg()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Frchg()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fsca(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fschg()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fsqrt(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Fsrra(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ftrv(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Icbi(object x)
		{
			return new Instruction(Opcode.Icbi);
		}

		internal static Instruction JsrN(object x)
		{
			return new Instruction(Opcode.JsrN);
		}

		internal static Instruction Ldbank(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movml_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movmu_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movua_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Mulr(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Nott()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Pref(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Prefi(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction RtsN()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction RtvN(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sets()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shad(object x, object y)
		{
			return new Instruction(Opcode.Shad);
		}

		internal static Instruction Shld(object x, object y)
		{
			return new Instruction(Opcode.Shld);
		}

		internal static Instruction Stbank(object x, object y)
		{
			return new Instruction(Opcode.Stbank);
		}

		internal static Instruction Synco()
		{
			return new Instruction(Opcode.Synco);
		}

		internal static Instruction Shal(object x)
		{
			return new Instruction(Opcode.Shal);
		}

		internal static Instruction Shar(object x)
		{
			return new Instruction(Opcode.Shar);
		}

		internal static Instruction Shll16(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shll2(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shll8(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shll(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shlr16(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shlr2(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shlr8(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Shlr(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sleep()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Stc_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Stc()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Stc(object x, object y)
		{
			return new Instruction(Opcode.Stc);
		}

		internal static Instruction Movli_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ocbp(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ocbwb(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movco_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ocbi(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sts_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sts(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Subc(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Sub(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Subv(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Swap_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Ldtlb()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Swap_w(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Resbank()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Clrs()
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movrt(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Movca_l(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Tas_b(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Trapa(object x)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Tst_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Tst(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Word(int val)
		{
			return new Instruction(Opcode.Word, (ushort) val);
		}

		internal static Instruction Xor_b(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Xor(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static Instruction Xtrct(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static int dbr = 0;

		internal static int dr0 = 0;
		internal static int dr2 = 0;
		internal static int dr4 = 0;
		internal static int dr6 = 0;
		internal static int dr8 = 0;
		internal static int dr10 = 0;
		internal static int dr12 = 0;
		internal static int dr14 = 0;

		internal static int fv0 = 0;
		internal static int fv4 = 0;
		internal static int fv8 = 0;
		internal static int fv12 = 0;

		internal static int sgr = 0;
		internal static int spc = 0;
		internal static int tbr = 0;
		internal static int xmtrx = 0;

		internal static int fpul = 0;
		internal static int fpscr = 0;

		internal static int fr0 = 0;
		internal static int fr1 = 0;
		internal static int fr2 = 0;
		internal static int fr3 = 0;
		internal static int fr4 = 0;
		internal static int fr5 = 0;
		internal static int fr6 = 0;
		internal static int fr7 = 0;
		internal static int fr8 = 0;
		internal static int fr9 = 0;
		internal static int fr10 = 0;
		internal static int fr11 = 0;
		internal static int fr12 = 0;
		internal static int fr13 = 0;
		internal static int fr14 = 0;
		internal static int fr15 = 0;

		internal static int at_r0 = 0;
		internal static int at_r0_a = 0;
		internal static int at_r1_a = 0;
		internal static int at_r2_a = 0;
		internal static int at_r3_a = 0;
		internal static int at_r4_a = 0;
		internal static int at_r5_a = 0;
		internal static int at_r6_a = 0;
		internal static int at_r7_a = 0;
		internal static int at_r8_a = 0;
		internal static int at_r9_a = 0;
		internal static int at_r10_a = 0;
		internal static int at_r11_a = 0;
		internal static int at_r12_a = 0;
		internal static int at_r13_a = 0;
		internal static int at_r14_a = 0;
		internal static int at_r15_a = 0;
		internal static int at_r1 = 0;
		internal static int at_r6 = 0;
		internal static int at_r3 = 0;
		internal static int at_r4 = 0;
		internal static int at_r5 = 0;
		internal static int at_r13 = 0;
		internal static int at_r14 = 0;
		internal static int at_r15 = 0;
		internal static int at_s_r3 = 0;
		internal static int at_r11 = 0;
		internal static int at_r8 = 0;
		internal static int at_s_r8 = 0;
		internal static int at_r7 = 0;
		internal static int at_r2 = 0;
		internal static int at_r9 = 0;
		internal static int at_r10 = 0;
		internal static int at_s_r10 = 0;
		internal static int at_s_r1 = 0;
		internal static int at_s_r0 = 0;
		internal static int at_r12 = 0;
		internal static int at_s_r2 = 0;
		internal static int at_s_r7 = 0;
		internal static int at_s_r6 = 0;
		internal static int at_s_r11 = 0;
		internal static int at_s_r9 = 0;
		internal static int at_s_r12 = 0;
		internal static int at_s_r13 = 0;
		internal static int at_s_r14 = 0;
		internal static int at_s_r15 = 0;
		internal static int at_s_r4 = 0;
		internal static int at_s_r5 = 0;

		internal static int h_0 = 0;
		internal static int h_1 = 0;
		internal static int h_2 = 0;
		internal static int h_3 = 0;
		internal static int h_4 = 0;
		internal static int h_5 = 0;
		internal static int h_6 = 0;
		internal static int h_7 = 0;
		internal static int h_8 = 0;
		internal static int h_9 = 0;
		internal static int h_10 = 0;
		internal static int h_11 = 0;
		internal static int h_12 = 0;
		internal static int h_13 = 0;
		internal static int h_14 = 0;
		internal static int h_15 = 0;
		internal static int h_16 = 0;
		internal static int h_17 = 0;
		internal static int h_18 = 0;
		internal static int h_19 = 0;
		internal static int h_20 = 0;
		internal static int h_21 = 0;
		internal static int h_22 = 0;
		internal static int h_23 = 0;
		internal static int h_24 = 0;

		internal static int r0 = 0;
		internal static int r1 = 0;
		internal static int r2 = 0;
		internal static int r3 = 0;
		internal static int r4 = 0;
		internal static int r5 = 0;
		internal static int r6 = 0;
		internal static int r7 = 0;
		internal static int r8 = 0;
		internal static int r9 = 0;
		internal static int r10 = 0;
		internal static int r11 = 0;
		internal static int r12 = 0;
		internal static int r13 = 0;
		internal static int r14 = 0;
		internal static int r15 = 0;

		internal static int mach = 0;
		internal static int macl = 0;
		internal static int sr = 0;
		internal static int gbr = 0;
		internal static int pr = 0;
		internal static int vbr = 0;
		internal static int ssr = 0;

		internal static int r0_bank = 0;
		internal static int r1_bank = 0;
		internal static int r2_bank = 0;
		internal static int r3_bank = 0;
		internal static int r4_bank = 0;
		internal static int r5_bank = 0;
		internal static int r6_bank = 0;
		internal static int r7_bank = 0;
		internal static int r8_bank = 0;
		internal static int r9_bank = 0;
		internal static int r10_bank = 0;
		internal static int r11_bank = 0;

		internal static object at(object x)
		{
			throw new InvalidOperationException();
		}

		internal static object h(object x)
		{
			throw new InvalidOperationException();
		}

		internal static object m(object x)
		{
			throw new InvalidOperationException();
		}

		internal static object p(object x)
		{
			throw new InvalidOperationException();
		}

		internal static object at(object x, object y)
		{
			throw new InvalidOperationException();
		}

		internal static object hash(int num)
		{
			throw new InvalidOperationException();
		}
	}
}