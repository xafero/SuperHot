using System;

namespace SuperHot
{
	internal static class Instruct
	{
		internal static Instruction Fmov() { throw new InvalidOperationException(); }
		internal static Instruction Fadd() { throw new InvalidOperationException(); }
		internal static Instruction Fsub() { throw new InvalidOperationException(); }
		internal static Instruction Word() { throw new InvalidOperationException(); }
		internal static Instruction Nop() { throw new InvalidOperationException(); }
		internal static Instruction Clrt() { throw new InvalidOperationException(); }
		internal static Instruction Clrmac() { throw new InvalidOperationException(); }
		internal static Instruction Stc() { throw new InvalidOperationException(); }
		internal static Instruction Sts() { throw new InvalidOperationException(); }
		internal static Instruction Bsrf() { throw new InvalidOperationException(); }
		internal static Instruction Mov_b() { throw new InvalidOperationException(); }
		internal static Instruction Mov_l() { throw new InvalidOperationException(); }
		internal static Instruction Mul_l() { throw new InvalidOperationException(); }
	}
}