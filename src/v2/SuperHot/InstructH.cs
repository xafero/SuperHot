using System;
using SuperHot.Args;
using I = SuperHot.Instruction;
using O = SuperHot.Auto.Opcode;
using static SuperHot.InstructV;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace SuperHot
{
    internal static class InstructH{
        internal static I Add(int i, Arg n) {return new I(O.Add, h((sbyte)i), n); }
        internal static I Add(Register m, Register n) {return new I(O.Add, m, n); }
        internal static I Addc(Arg n, Arg m) {return new I(O.Addc, m, n); }
        internal static I Addv(Arg n, Arg m) {return new I(O.Addv, m, n); }
        internal static I And_b_rs(int i, Register r, Register n) {return new I(O.And_b, h(i), at(r, n)); }
        internal static I And(int i, Arg r) {return new I(O.And, h(i), r); }
        internal static I And(Register m, Register n) {return new I(O.And, m, n); }
        internal static I Bclr(Arg i, Arg n) {return new I(O.Bclr, h(i), n); }
        internal static I Bclr_or_Bset(byte n0, byte n1, byte n2, byte n3, params Func<I>[] funcs) 
            => n3 switch { 0 or 1 or 2 or 3 or 4 or 5 or 6 or 7 => funcs[0](), _ => funcs[1]() };
        internal static I Bld_or_Bst(byte n0, byte n1, byte n2, byte n3, params Func<I>[] funcs)
            => n3 switch { 0 or 1 or 2 or 3 or 4 or 5 or 6 or 7 => funcs[1](), _ => funcs[0]() };
        internal static I Bf(int d) {return new I(O.Bf, 4 + (sbyte)d * 2); }
        internal static I Bf_s(int d) {return new I(O.Bf_s, 4 + (sbyte)d * 2); }
        internal static I Bld(Arg i, Arg n) {return new I(O.Bld, h(i), n); }
        internal static I Bra(int d) {return new I(O.Bra, 4 + se(d) * 2); }
        internal static I Braf(Arg n) {return new I(O.Braf, n); }
        internal static I Bset(Arg i, Arg n) {return new I(O.Bset, h(i), n); }
        internal static I Bsr(int d) {return new I(O.Bsr, 4 + se(d) * 2); }
        internal static I Bsrf(Arg n) {return new I(O.Bsrf, n); }
        internal static I Bst(Arg i, Arg n) {return new I(O.Bst, h(i), n); }
        internal static I Bt(int d) {return new I(O.Bt, 4 + (sbyte)d * 2); }
        internal static I Bt_s(int d) {return new I(O.Bt_s, 4 + (sbyte)d * 2); }
        internal static I Clips_b(Arg n) {return new I(O.Clips_b, n); }
        internal static I Clips_w(Arg n) {return new I(O.Clips_w, n); }
        internal static I Clipu_b(Arg n) {return new I(O.Clipu_b, n); }
        internal static I Clipu_w(Arg n) {return new I(O.Clipu_w, n); }
        internal static I Clrmac() {return new I(O.Clrmac); }
        internal static I Clrs() {return new I(O.Clrs); }
        internal static I Clrt() {return new I(O.Clrt); }
        internal static I Cmpeq(int i, Arg r) {return new I(O.CmpEq, h((sbyte)i), r); }
        internal static I Cmpeq(Register m, Register n) {return new I(O.CmpEq, m, n); }
        internal static I Cmpge(Arg n, Arg m) {return new I(O.CmpGe, m, n); }
        internal static I Cmpgt(Arg n, Arg m) {return new I(O.CmpGt, m, n); }
        internal static I Cmphi(Arg n, Arg m) {return new I(O.CmpHi, m, n); }
        internal static I Cmphs(Arg n, Arg m) {return new I(O.CmpHs, m, n); }
        internal static I Cmppl(Arg n) {return new I(O.CmpPl, n); }
        internal static I Cmppz(Arg n) {return new I(O.CmpPz, n); }
        internal static I Cmpstr(Arg n, Arg m) {return new I(O.CmpStr, m, n); }
        internal static I Div0s(Arg n, Arg m) {return new I(O.Div0s, m, n); }
        internal static I Div0u() {return new I(O.Div0u); }
        internal static I Div1(Arg n, Arg m) {return new I(O.Div1, m, n); }
        internal static I Divs(Register r, Arg n) {return new I(O.Divs, r, n); }
        internal static I Divu(Register r, Arg n) {return new I(O.Divu, r, n); }
        internal static I Dmuls_l(Arg n, Arg m) {return new I(O.Dmuls_l, m, n); }
        internal static I Dmulu_l(Arg m, Arg n) {return new I(O.Dmulu_l, m, n); }
        internal static I Dt(Arg n) {return new I(O.Dt, n); }
        internal static I Exts_b(Arg n, Arg m) {return new I(O.Exts_b, m, n); }
        internal static I Exts_w(Arg n, Arg m) {return new I(O.Exts_w, m, n); }
        internal static I Extu_b(Arg n, Arg m) {return new I(O.Extu_b, m, n); }
        internal static I Extu_w(Arg n, Arg m) {return new I(O.Extu_w, m, n); }
        internal static I Fabs(Arg n) {return new I(O.Fabs, n); }
        internal static I Fadd(Arg n, Arg m) {return new I(O.Fadd, m, n); }
        internal static I Fcmpeq(Arg n, Arg m) {return new I(O.FcmpEq, m, n); }
        internal static I Fcmpgt(Arg n, Arg m) {return new I(O.FcmpGt, m, n); }
        internal static I Fcnvds(Arg m, Arg r) {return new I(O.Fcnvds, m, r); }
        internal static I Fcnvds_or_Word(byte n0, byte n1, byte n2, byte n3, params Func<I>[] funcs) 
            => n1 switch { 0 or 2 or 4 or 6 or 8 or 10 or 12 or 14 => funcs[0](), _ => funcs[1]() };
        internal static I Fcnvsd(Arg m, Arg n) {return new I(O.Fcnvsd, m, n); }
        internal static I Fcnvsd_or_Word(byte n0, byte n1, byte n2, byte n3, params Func<I>[] funcs) 
            => n1 switch { 0 or 2 or 4 or 6 or 8 or 10 or 12 or 14 => funcs[0](), _ => funcs[1]() };
        internal static I Fdiv(Arg n, Arg m) {return new I(O.Fdiv, m, n); }
        internal static I Fipr(Register m, Register n) {return new I(O.Fipr, m, n); }
        internal static I Fldi0(Arg n) {return new I(O.Fldi0, n); }
        internal static I Fldi1(Arg n) {return new I(O.Fldi1, n); }
        internal static I Flds(Arg m, Register r) {return new I(O.Flds, m, r); }
        internal static I Float(Register r, Arg n) {return new I(O.Float, r, n); }
        internal static I Fmac(Register r, Arg n, Arg m) {return new I(O.Fmac, r, m, n); }
        internal static I Fmov(Arg m, Arg n) {return new I(O.Fmov, m, n); }
        internal static I Fmov_ls(Register r, Register m, Arg n) {return new I(O.Fmov, at(r, m), n); }
        internal static I Fmov_rs(Arg m, Register r, Arg n) {return new I(O.Fmov, m, at(r, n)); }
        internal static I Fmul(Arg n, Arg m) {return new I(O.Fmul, m, n); }
        internal static I Fneg(Arg n) {return new I(O.Fneg, n); }
        internal static I Fpchg() {return new I(O.Fpchg); }
        internal static I Frchg() {return new I(O.Frchg); }
        internal static I Fsca(Register r, Arg n) {return new I(O.Fsca, r, n); }
        internal static I? Fsca_or_Ftrv(byte n0, byte n1, byte n2, byte n3, params Func<I>[] funcs) 
            => n1 switch { 7 or 15 => null, 0 or 2 or 4 or 6 or 8 or 10 or 12 or 14 => funcs[0](), _ => funcs[1]() };
        internal static I Fschg() {return new I(O.Fschg); }
        internal static I Fsqrt(Register n) {return new I(O.Fsqrt, n); }
        internal static I Fsrra(Register n) {return new I(O.Fsrra, n); }
        internal static I Fsts(Register r, Arg n) {return new I(O.Fsts, r, n); }
        internal static I Fsub(Arg n, Arg m) {return new I(O.Fsub, m, n); }
        internal static I Ftrc(Arg m, Register r) {return new I(O.Ftrc, m, r); }
        internal static I Ftrv(Register r, Arg n) {return new I(O.Ftrv, r, n); }
        internal static I Icbi(Arg n) {return new I(O.Icbi, n); }
        internal static I Jmp(Arg n) {return new I(O.Jmp, n); }
        internal static I Jsr(Arg n) {return new I(O.Jsr, n); }
        internal static I Jsrn_ls(int d, Register r) {return new I(O.JsrN, atb(d*4,r)); }
        internal static I Jsrn(Arg m) {return new I(O.JsrN, m); }
        internal static I Ldbank(Arg m, Register r) {return new I(O.Ldbank, m, r); }
        internal static I Ldc(Arg m, Register r) {return new I(O.Ldc, m, r); }
        internal static I Ldc_l(Arg m, Register r) {return new I(O.Ldc_l, m, r); }
        internal static I Lds(Arg m, Register r) {return new I(O.Lds, m, r); }
        internal static I Lds_l(Arg m, Register r) {return new I(O.Lds_l, m, r); }
        internal static I Ldtlb() {return new I(O.Ldtlb); }
        internal static I Mac_l(Arg n, Arg m) {return new I(O.Mac_l, m, n); }
        internal static I Mac_w(Arg n, Arg m) {return new I(O.Mac_w, m, n); }
        internal static I Mova_ls(int d, Register n, Arg r) {return n==Register.pc ? new I(O.Mova, 4+d*4, r)
                            :new I(O.Mova, at(d,n), r); }
        internal static I Mov_b(Arg n, Arg m) {return new I(O.Mov_b, m, n); }
        internal static I Mov_b(Arg n, Register r) {return new I(O.Mov_b, n, r); }
        internal static I Mov_b(Register m, Arg n) {return new I(O.Mov_b, m, n); }
        internal static I Mov_b_rs(Register m, Register r, Register n) {return new I(O.Mov_b, m, at(r,n)); }
        internal static I Mov_b_ls(Register r, Register m, Register n) {return new I(O.Mov_b, at(r,m), n); }
        internal static I Mov_b_rs(Register r, Arg d, Register n) {return new I(O.Mov_b, r, at(d, n)); }
        internal static I Mov_b_ls(Arg d, Register m, Register r) {return new I(O.Mov_b, at(d, m), r); }
        internal static I Mov(Arg n, Arg m) {return new I(O.Mov, m, n); }
        internal static I Mov(int i, Register n) {return new I(O.Mov, h((sbyte)i), n); }
        internal static I Movca_l(Register r, Arg n) {return new I(O.Movca_l, r, n); }
        internal static I Movco_l(Register r, Arg n) {return new I(O.Movco_l, r, n); }
        internal static I Mov_l_rs(Register m, int d, Register n) {return new I(O.Mov_l, m, at(d*4, n)); }
        internal static I Mov_l_rs(Register m, Register d, Register n) {return new I(O.Mov_l, m, at(d, n)); }
        internal static I Mov_l_ls(Register r, Register m, Register n) {return new I(O.Mov_l, at(r, m), n); }
        internal static I Mov_l_ls(int d, Register m, Register n) {return m==Register.pc? 
            new I(O.Mov_l, 4+d*4, n) : new I(O.Mov_l, at(d*4, m), n); }
        internal static I Mov_l(Arg n, Arg m) {return new I(O.Mov_l, m, n); }
        internal static I Mov_l(Arg n, Register r) {return new I(O.Mov_l, n, r); }
        internal static I Mov_l(Register m, Arg n) {return new I(O.Mov_l, m, n); }
        internal static I Movli_l(Arg m, Register r) {return new I(O.Movli_l, m, r); }
        internal static I Movml_l(Register m, Arg r) {return new I(O.Movml_l, m, r); }
        internal static I Movml_l(Arg r, Register n) {return new I(O.Movml_l, r, n); }
        internal static I Movmu_l(Register m, Arg r) {return new I(O.Movmu_l, m, r); }
        internal static I Movmu_l(Arg r, Register n) {return new I(O.Movmu_l, r, n); }
        internal static I Movrt(Arg n) {return new I(O.Movrt, n); }
        internal static I Movt(Arg n) {return new I(O.Movt, n); }
        internal static I Movua_l(Arg m, Register r) {return new I(O.Movua_l, m, r); }
        internal static I Mov_w_ls(byte d, Register m, Arg r) {return new I(O.Mov_w, at(d * 2, m), r); }
        internal static I Mov_w_rs(Register m, Register r, Register n) {return new I(O.Mov_w, m, at(r, n)); }
        internal static I Mov_w_ls(Register r, Register m, Register n) {return new I(O.Mov_w, at(r,m), n); }
        internal static I Mov_w_ls(int d, Register r, Register n) {return r == Register.pc ?  
                    new I(O.Mov_w, 4+d*2, n) : new I(O.Mov_w, at(d*2, r), n); }
        internal static I Mov_w_rs(Register r, byte d, Register n) {return new I(O.Mov_w, r, at(d*2, n)); }
        internal static I Mov_w_rs(Register r, int d, Register n) {return new I(O.Mov_w, r, at(d*2, n)); }
        internal static I Mov_w(Arg m, Arg n) {return new I(O.Mov_w, m, n); }
        internal static I Mov_w(Arg n, Register r) {return new I(O.Mov_w, n, r); }
        internal static I Mov_w(Register m, Arg n) {return new I(O.Mov_w, m, n); }
        internal static I Mul_l(Arg n, Arg m) {return new I(O.Mul_l, m, n); }
        internal static I Mulr(Register r, Arg n) {return new I(O.Mulr, r, n); }
        internal static I Muls_w(Arg n, Arg m) {return new I(O.Muls_w, m, n); }
        internal static I Mulu_w(Arg n, Arg m) {return new I(O.Mulu_w, m, n); }
        internal static I Neg(Arg n, Arg m) {return new I(O.Neg, m, n); }
        internal static I Negc(Arg n, Arg m) {return new I(O.Negc, m, n); }
        internal static I Nop() {return new I(O.Nop); }
        internal static I Not(Arg n, Arg m) {return new I(O.Not, m, n); }
        internal static I Nott() {return new I(O.Nott); }
        internal static I Ocbi(Arg n) {return new I(O.Ocbi, n); }
        internal static I Ocbp(Arg n) {return new I(O.Ocbp, n); }
        internal static I Ocbwb(Arg n) {return new I(O.Ocbwb, n); }
        internal static I Or_b_rs(int i, Register r, Arg m) {return new I(O.Or_b, h(i), at(r, m)); }
        internal static I Or(int i, Arg r) {return new I(O.Or, h(i), r); }
        internal static I Or(Register m, Register n) {return new I(O.Or, m, n); }
        internal static I Pref(Arg n) {return new I(O.Pref, n); }
        internal static I Prefi(Arg n) {return new I(O.Prefi, n); }
        internal static I Resbank() {return new I(O.Resbank); }
        internal static I Rotcl(Arg n) {return new I(O.Rotcl, n); }
        internal static I Rotcr(Arg n) {return new I(O.Rotcr, n); }
        internal static I Rotl(Arg n) {return new I(O.Rotl, n); }
        internal static I Rotr(Arg n) {return new I(O.Rotr, n); }
        internal static I Rte() {return new I(O.Rte); }
        internal static I Rtsn() {return new I(O.RtsN); }
        internal static I Rts() {return new I(O.Rts); }
        internal static I Rtvn(Arg m) {return new I(O.RtvN, m); }
        internal static I Sets() {return new I(O.Sets); }
        internal static I Sett() {return new I(O.Sett); }
        internal static I Shad(Register m, Register n) {return new I(O.Shad, m, n); }
        internal static I Shal(Arg n) {return new I(O.Shal, n); }
        internal static I Shar(Arg n) {return new I(O.Shar, n); }
        internal static I Shld(Register m, Register n) {return new I(O.Shld, m, n); }
        internal static I Shll16(Arg n) {return new I(O.Shll16, n); }
        internal static I Shll2(Arg n) {return new I(O.Shll2, n); }
        internal static I Shll8(Arg n) {return new I(O.Shll8, n); }
        internal static I Shll(Arg n) {return new I(O.Shll, n); }
        internal static I Shlr16(Arg n) {return new I(O.Shlr16, n); }
        internal static I Shlr2(Arg n) {return new I(O.Shlr2, n); }
        internal static I Shlr8(Arg n) {return new I(O.Shlr8, n); }
        internal static I Shlr(Arg n) {return new I(O.Shlr, n); }
        internal static I Sleep() {return new I(O.Sleep); }
        internal static I Stbank(Register r, Arg n) {return new I(O.Stbank, r, n); }
        internal static I Stc(Register r, Arg n) {return new I(O.Stc, r, n); }
        internal static I Stc_l(Register r, Arg n) {return new I(O.Stc_l, r, n); }
        internal static I Sts(Register r, Arg n) {return new I(O.Sts, r, n); }
        internal static I Sts_l(Register r, Arg n) {return new I(O.Sts_l, r, n); }
        internal static I Sub(Arg n, Arg m) {return new I(O.Sub, m, n); }
        internal static I Subc(Arg n, Arg m) {return new I(O.Subc, m, n); }
        internal static I Subv(Arg n, Arg m) {return new I(O.Subv, m, n); }
        internal static I Swap_b(Arg n, Arg m) {return new I(O.Swap_b, m, n); }
        internal static I Swap_w(Arg n, Arg m) {return new I(O.Swap_w, m, n); }
        internal static I Synco() {return new I(O.Synco); }
        internal static I Tas_b(Arg n) {return new I(O.Tas_b, n); }
        internal static I Trapa(int i) {return new I(O.Trapa, h(i)); }
        internal static I Tst_b_rs(int i, Register r, Register n) {return new I(O.Tst_b, h(i), at(r,n)); }
        internal static I Tst(Register m, Register n) {return new I(O.Tst, m, n); }
        internal static I Tst(int i, Arg r) {return new I(O.Tst, h(i), r); }
        internal static I Word(byte n0, byte n1, byte n2, byte n3) {var b0 = (n0 << 4) | n1;            var b1 = (n2 << 4) | n3;            var v = (b0 << 8) | b1;            var h = new HexArg(v);          return new I(O.Word, h); }
        internal static I Xor_b_rs(int i, Register r, Register n) {return new I(O.Xor_b, h(i), at(r,n)); }
        internal static I Xor(int i, Arg r) {return new I(O.Xor, h(i), r); }
        internal static I Xor(Register m, Register n) {return new I(O.Xor, m, n); }
        internal static I Xtrct(Arg n, Arg m) {return new I(O.Xtrct, m, n); }
    }
}