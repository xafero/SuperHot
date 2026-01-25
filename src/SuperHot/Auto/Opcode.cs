using System.Collections.Generic;
using D = SuperHot.Dialect;
using O = SuperHot.OpMeta;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace SuperHot.Auto
{
	public enum Opcode
	{
		None = 0,

		/// <summary>
		/// Add binary
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r10")]
		Add,

		/// <summary>
		/// Add with Carry
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Addc,

		/// <summary>
		/// Add with V Flag Overflow Check
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Addv,

		/// <summary>
		/// AND Logical
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		And,

		/// <summary>
		/// AND Logical (Byte)
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		And_b,

		/// <summary>
		/// Bit Clear
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bclr,

		/// <summary>
		/// Branch if False
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bf,

		/// <summary>
		/// Branch if False with Delay Slot
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bf_s,

		/// <summary>
		/// Bit Load
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bld,

		/// <summary>
		/// Branch
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xfffff004")]
		Bra,

		/// <summary>
		/// Branch Far
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Braf,

		/// <summary>
		/// Bit Set
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bset,

		/// <summary>
		/// Branch to Subroutine
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xfffff004")]
		Bsr,

		/// <summary>
		/// Branch to Subroutine Far
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Bsrf,

		/// <summary>
		/// Bit Store
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "#0,r0", "#0,r10")]
		Bst,

		/// <summary>
		/// Branch if True
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bt,

		/// <summary>
		/// Branch if True with Delay Slot
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0", "0xffffff04")]
		Bt_s,

		/// <summary>
		/// Signed Saturation Value Comparison (Byte)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		Clips_b,

		/// <summary>
		/// Signed Saturation Value Comparison (Word)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		Clips_w,

		/// <summary>
		/// Unsigned Saturation Value Comparison (Byte)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		Clipu_b,

		/// <summary>
		/// Unsigned Saturation Value Comparison (Word)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		Clipu_w,

		/// <summary>
		/// Clear MAC Register
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrmac,

		/// <summary>
		/// Clear S Bit
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrs,

		/// <summary>
		/// Clear T Bit
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Clrt,

		/// <summary>
		/// Compare Equal
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r0")]
		CmpEq,

		/// <summary>
		/// Compare Greater or Equal (Signed)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpGe,

		/// <summary>
		/// Compare Greater Than (Signed)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpGt,

		/// <summary>
		/// Compare Higher (Unsigned)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpHi,

		/// <summary>
		/// Compare Higher or Same (Unsigned)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpHs,

		/// <summary>
		/// Compare Plus (Positive)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		CmpPl,

		/// <summary>
		/// Compare Plus or Zero
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		CmpPz,

		/// <summary>
		/// Compare String
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		CmpStr,

		/// <summary>
		/// Divide Step 0 as Signed
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Div0s,

		/// <summary>
		/// Divide Step 0 as Unsigned
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Div0u,

		/// <summary>
		/// Divide Step 1
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Div1,

		/// <summary>
		/// Division Signed
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Divs,

		/// <summary>
		/// Division Unsigned
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Divu,

		/// <summary>
		/// Double-length Multiply as Signed (Long)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Dmuls_l,

		/// <summary>
		/// Double-length Multiply as Unsigned (Long)
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Dmulu_l,

		/// <summary>
		/// Decrement and Test
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Dt,

		/// <summary>
		/// Extend as Signed (Byte)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Exts_b,

		/// <summary>
		/// Extend as Signed (Word)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Exts_w,

		/// <summary>
		/// Extend as Unsigned (Byte)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Extu_b,

		/// <summary>
		/// Extend as Unsigned (Word)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Extu_w,

		/// <summary>
		/// Floating Point Absolute Value
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fabs,

		/// <summary>
		/// Floating Point Add
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fadd,

		/// <summary>
		/// Floating Point Compare Equal
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		FcmpEq,

		/// <summary>
		/// Floating Point Compare Greater Than
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		FcmpGt,

		/// <summary>
		/// Floating Point Convert Double to Single Precision
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh4,D.Sh4a], 2, "dr0,fpul", "dr10,fpul")]
		Fcnvds,

		/// <summary>
		/// Floating Point Convert Single to Double Precision
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh4,D.Sh4a], 2, "fpul,dr0", "fpul,dr10")]
		Fcnvsd,

		/// <summary>
		/// Floating Point Divide
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fdiv,

		/// <summary>
		/// Floating Point Inner Product
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 2, "fv0,fv0", "fv12,fv12")]
		Fipr,

		/// <summary>
		/// Floating Point Load Immediate 0.0
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fldi0,

		/// <summary>
		/// Floating Point Load Immediate 1.0
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fldi1,

		/// <summary>
		/// Floating Point Load to System Register
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fpul", "fr10,fpul")]
		Flds,

		/// <summary>
		/// Floating Point Convert from Integer
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fpul,fr0", "fpul,fr10")]
		Float,

		/// <summary>
		/// Floating Point Multiply and Accumulate
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 3, "fr0,fr0,fr0", "fr0,fr10,fr10")]
		Fmac,

		/// <summary>
		/// Floating Point Move
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,fr0", "@(r0,r10),fr10")]
		Fmov,

		/// <summary>
		/// Floating Point Multiply
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fmul,

		/// <summary>
		/// Floating Point Negate
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fneg,

		/// <summary>
		/// PR-bit Change
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4a])]
		Fpchg,

		/// <summary>
		/// FR-bit Change
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a])]
		Frchg,

		/// <summary>
		/// Floating Point Sine and Cosine Approximate
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 2, "fpul,dr0", "fpul,dr10")]
		Fsca,

		/// <summary>
		/// SZ-bit Change
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh4,D.Sh4a])]
		Fschg,

		/// <summary>
		/// Floating Point Square Root
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh3e,D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fsqrt,

		/// <summary>
		/// Floating Point Square Reciprocal Approximate
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 1, "fr0", "fr10")]
		Fsrra,

		/// <summary>
		/// Floating Point Store System Register
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fpul,fr0", "fpul,fr10")]
		Fsts,

		/// <summary>
		/// Floating Point Subtract
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fr0", "fr10,fr10")]
		Fsub,

		/// <summary>
		/// Floating Point Truncate and Convert to Integer
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh2e,D.Sh3e,D.Sh4,D.Sh4a], 2, "fr0,fpul", "fr10,fpul")]
		Ftrc,

		/// <summary>
		/// Floating Point Transform Vector
		/// <remarks>Floating Point</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 2, "xmtrx,fv0", "xmtrx,fv12")]
		Ftrv,

		/// <summary>
		/// Instruction Cache Block Invalidate
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a], 1, "@r0", "@r10")]
		Icbi,

		/// <summary>
		/// Jump
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Jmp,

		/// <summary>
		/// Jump to Subroutine
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Jsr,

		/// <summary>
		/// Jump to Subroutine (No Delay)
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "@r0", "@@(1000,tbr)")]
		JsrN,

		/// <summary>
		/// Load from Register Bank
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "@r0,r0", "@r10,r0")]
		Ldbank,

		/// <summary>
		/// Load to Control Register
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,sr", "r10,r0_bank")]
		Ldc,

		/// <summary>
		/// Load to Control Register (Long)
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,sr", "@r10+,r0_bank")]
		Ldc_l,

		/// <summary>
		/// Load to System Register
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,pr", "r10,fpscr")]
		Lds,

		/// <summary>
		/// Load to System Register (Long)
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,pr", "@r10+,fpscr")]
		Lds_l,

		/// <summary>
		/// Load PTEH/PTEL to TLB
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Ldtlb,

		/// <summary>
		/// Multiply and Accumulate Long
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,@r0+", "@r10+,@r10+")]
		Mac_l,

		/// <summary>
		/// Multiply and Accumulate Word
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0+,@r0+", "@r10+,@r10+")]
		Mac_w,

		/// <summary>
		/// Move Data
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#-100,r10")]
		Mov,

		/// <summary>
		/// Move Data (Byte)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(100,gbr),r0")]
		Mov_b,

		/// <summary>
		/// Move Data (Long)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(1000,gbr),r0")]
		Mov_l,

		/// <summary>
		/// Move Data (Word)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "@r0,r0", "@(100,gbr),r0")]
		Mov_w,

		/// <summary>
		/// Move Effective Address
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "0x4,r0", "0x100,r0")]
		Mova,

		/// <summary>
		/// Move with Cache Block Allocation
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 2, "r0,@r0", "r0,@r10")]
		Movca_l,

		/// <summary>
		/// Move Conditional
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a], 2, "r0,@r0", "r0,@r10")]
		Movco_l,

		/// <summary>
		/// Move Linked
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a], 2, "@r0,r0", "@r10,r0")]
		Movli_l,

		/// <summary>
		/// Move Multi-register Lower part
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "@r15+,r0", "@r15+,r10")]
		Movml_l,

		/// <summary>
		/// Move Multi-register Upper part
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "@r15+,r0", "@r15+,r10")]
		Movmu_l,

		/// <summary>
		/// T Bit Inversion and Transfer to Rn
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		Movrt,

		/// <summary>
		/// Move T Bit
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Movt,

		/// <summary>
		/// Move Unaligned (Long)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a], 2, "@r0,r0", "@r10+,r0")]
		Movua_l,

		/// <summary>
		/// Multiply Long
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Mul_l,

		/// <summary>
		/// Signed Multiplication with Storage in Rn
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "r0,r0", "r0,r10")]
		Mulr,

		/// <summary>
		/// Multiply as Signed Word
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Muls_w,

		/// <summary>
		/// Multiply as Unsigned Word
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Mulu_w,

		/// <summary>
		/// Negate
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Neg,

		/// <summary>
		/// Negate with Carry
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Negc,

		/// <summary>
		/// No Operation
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Nop,

		/// <summary>
		/// NOT-Logical Complement
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Not,

		/// <summary>
		/// T Bit Inversion
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh2a])]
		Nott,

		/// <summary>
		/// Operand Cache Block Invalidate
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbi,

		/// <summary>
		/// Operand Cache Block Purge
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbp,

		/// <summary>
		/// Operand Cache Block Write Back
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Ocbwb,

		/// <summary>
		/// OR Logical
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Or,

		/// <summary>
		/// OR Logical (Byte)
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Or_b,

		/// <summary>
		/// Prefetch Data to Cache
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Pref,

		/// <summary>
		/// Prefetch Instruction Cache Block
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a], 1, "@r0", "@r10")]
		Prefi,

		/// <summary>
		/// Register Restoration from Bank
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a])]
		Resbank,

		/// <summary>
		/// Rotate with Carry Left
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotcl,

		/// <summary>
		/// Rotate with Carry Right
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotcr,

		/// <summary>
		/// Rotate Left
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotl,

		/// <summary>
		/// Rotate Right
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Rotr,

		/// <summary>
		/// Return from Exception
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Rte,

		/// <summary>
		/// Return from Subroutine
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Rts,

		/// <summary>
		/// Return from Subroutine (No Delay)
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2a])]
		RtsN,

		/// <summary>
		/// Return to Value from Subroutine (No Delay)
		/// <remarks>Branch</remarks>
		/// </summary>
		[O([D.Sh2a], 1, "r0", "r10")]
		RtvN,

		/// <summary>
		/// Set S Bit
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sets,

		/// <summary>
		/// Set T Bit
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sett,

		/// <summary>
		/// Shift Arithmetic Dynamically
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Shad,

		/// <summary>
		/// Shift Arithmetic Left
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shal,

		/// <summary>
		/// Shift Arithmetic Right
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shar,

		/// <summary>
		/// Shift Logical Dynamically
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh2a,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Shld,

		/// <summary>
		/// Shift Logical Left
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll,

		/// <summary>
		/// Shift Logical Left 16 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll16,

		/// <summary>
		/// Shift Logical Left 2 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll2,

		/// <summary>
		/// Shift Logical Left 8 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shll8,

		/// <summary>
		/// Shift Logical Right
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr,

		/// <summary>
		/// Shift Logical Right 16 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr16,

		/// <summary>
		/// Shift Logical Right 2 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr2,

		/// <summary>
		/// Shift Logical Right 8 Bits
		/// <remarks>Shift</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "r0", "r10")]
		Shlr8,

		/// <summary>
		/// Sleep
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a])]
		Sleep,

		/// <summary>
		/// Register Save to Specified Bank
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh2a], 2, "r0,@r0", "r0,@r10")]
		Stbank,

		/// <summary>
		/// Store Control Register
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "sr,r0", "r0_bank,r10")]
		Stc,

		/// <summary>
		/// Store Control Register (Long)
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "sr,@-r0", "r0_bank,@-r10")]
		Stc_l,

		/// <summary>
		/// Store System Register
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "pr,r0", "fpscr,r10")]
		Sts,

		/// <summary>
		/// Store System Register (Long)
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "pr,@-r0", "fpscr,@-r10")]
		Sts_l,

		/// <summary>
		/// Subtract Binary
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Sub,

		/// <summary>
		/// Subtract with Carry
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Subc,

		/// <summary>
		/// Subtract with V Flag Underflow Check
		/// <remarks>Arithmetic</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Subv,

		/// <summary>
		/// Swap (Byte)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Swap_b,

		/// <summary>
		/// Swap (Word)
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Swap_w,

		/// <summary>
		/// Synchronize Data Operation
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh4a])]
		Synco,

		/// <summary>
		/// Test And Set (Byte)
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "@r0", "@r10")]
		Tas_b,

		/// <summary>
		/// Trap Always
		/// <remarks>System Control</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "#0", "#100")]
		Trapa,

		/// <summary>
		/// Test Logical
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Tst,

		/// <summary>
		/// Test Logical (Byte)
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Tst_b,

		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 1, "0x0000", "0x0000")]
		Word,

		/// <summary>
		/// Exclusive OR Logical
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,r0", "#100,r0")]
		Xor,

		/// <summary>
		/// Exclusive OR Logical (Byte)
		/// <remarks>Logic Operation</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "#0,@(r0,gbr)", "#100,@(r0,gbr)")]
		Xor_b,

		/// <summary>
		/// Extract
		/// <remarks>Data Transfer</remarks>
		/// </summary>
		[O([D.Sh,D.Sh2,D.Sh2a,D.Sh2e,D.Sh3,D.Sh3e,D.Sh4,D.Sh4a], 2, "r0,r0", "r10,r10")]
		Xtrct
	}

	public static class OpcodeExt
	{
		public static string ToName(this Opcode code) => _names[code];

		private static readonly Dictionary<Opcode, string> _names = new()
		{
			{ Opcode.Add, "add" },
			{ Opcode.Addc, "addc" },
			{ Opcode.Addv, "addv" },
			{ Opcode.And, "and" },
			{ Opcode.And_b, "and.b" },
			{ Opcode.Bclr, "bclr" },
			{ Opcode.Bf, "bf" },
			{ Opcode.Bf_s, "bf.s" },
			{ Opcode.Bld, "bld" },
			{ Opcode.Bra, "bra" },
			{ Opcode.Braf, "braf" },
			{ Opcode.Bset, "bset" },
			{ Opcode.Bsr, "bsr" },
			{ Opcode.Bsrf, "bsrf" },
			{ Opcode.Bst, "bst" },
			{ Opcode.Bt, "bt" },
			{ Opcode.Bt_s, "bt.s" },
			{ Opcode.Clips_b, "clips.b" },
			{ Opcode.Clips_w, "clips.w" },
			{ Opcode.Clipu_b, "clipu.b" },
			{ Opcode.Clipu_w, "clipu.w" },
			{ Opcode.Clrmac, "clrmac" },
			{ Opcode.Clrs, "clrs" },
			{ Opcode.Clrt, "clrt" },
			{ Opcode.CmpEq, "cmp/eq" },
			{ Opcode.CmpGe, "cmp/ge" },
			{ Opcode.CmpGt, "cmp/gt" },
			{ Opcode.CmpHi, "cmp/hi" },
			{ Opcode.CmpHs, "cmp/hs" },
			{ Opcode.CmpPl, "cmp/pl" },
			{ Opcode.CmpPz, "cmp/pz" },
			{ Opcode.CmpStr, "cmp/str" },
			{ Opcode.Div0s, "div0s" },
			{ Opcode.Div0u, "div0u" },
			{ Opcode.Div1, "div1" },
			{ Opcode.Divs, "divs" },
			{ Opcode.Divu, "divu" },
			{ Opcode.Dmuls_l, "dmuls.l" },
			{ Opcode.Dmulu_l, "dmulu.l" },
			{ Opcode.Dt, "dt" },
			{ Opcode.Exts_b, "exts.b" },
			{ Opcode.Exts_w, "exts.w" },
			{ Opcode.Extu_b, "extu.b" },
			{ Opcode.Extu_w, "extu.w" },
			{ Opcode.Fabs, "fabs" },
			{ Opcode.Fadd, "fadd" },
			{ Opcode.FcmpEq, "fcmp/eq" },
			{ Opcode.FcmpGt, "fcmp/gt" },
			{ Opcode.Fcnvds, "fcnvds" },
			{ Opcode.Fcnvsd, "fcnvsd" },
			{ Opcode.Fdiv, "fdiv" },
			{ Opcode.Fipr, "fipr" },
			{ Opcode.Fldi0, "fldi0" },
			{ Opcode.Fldi1, "fldi1" },
			{ Opcode.Flds, "flds" },
			{ Opcode.Float, "float" },
			{ Opcode.Fmac, "fmac" },
			{ Opcode.Fmov, "fmov" },
			{ Opcode.Fmul, "fmul" },
			{ Opcode.Fneg, "fneg" },
			{ Opcode.Fpchg, "fpchg" },
			{ Opcode.Frchg, "frchg" },
			{ Opcode.Fsca, "fsca" },
			{ Opcode.Fschg, "fschg" },
			{ Opcode.Fsqrt, "fsqrt" },
			{ Opcode.Fsrra, "fsrra" },
			{ Opcode.Fsts, "fsts" },
			{ Opcode.Fsub, "fsub" },
			{ Opcode.Ftrc, "ftrc" },
			{ Opcode.Ftrv, "ftrv" },
			{ Opcode.Icbi, "icbi" },
			{ Opcode.Jmp, "jmp" },
			{ Opcode.Jsr, "jsr" },
			{ Opcode.JsrN, "jsr/n" },
			{ Opcode.Ldbank, "ldbank" },
			{ Opcode.Ldc, "ldc" },
			{ Opcode.Ldc_l, "ldc.l" },
			{ Opcode.Lds, "lds" },
			{ Opcode.Lds_l, "lds.l" },
			{ Opcode.Ldtlb, "ldtlb" },
			{ Opcode.Mac_l, "mac.l" },
			{ Opcode.Mac_w, "mac.w" },
			{ Opcode.Mov, "mov" },
			{ Opcode.Mov_b, "mov.b" },
			{ Opcode.Mov_l, "mov.l" },
			{ Opcode.Mov_w, "mov.w" },
			{ Opcode.Mova, "mova" },
			{ Opcode.Movca_l, "movca.l" },
			{ Opcode.Movco_l, "movco.l" },
			{ Opcode.Movli_l, "movli.l" },
			{ Opcode.Movml_l, "movml.l" },
			{ Opcode.Movmu_l, "movmu.l" },
			{ Opcode.Movrt, "movrt" },
			{ Opcode.Movt, "movt" },
			{ Opcode.Movua_l, "movua.l" },
			{ Opcode.Mul_l, "mul.l" },
			{ Opcode.Mulr, "mulr" },
			{ Opcode.Muls_w, "muls.w" },
			{ Opcode.Mulu_w, "mulu.w" },
			{ Opcode.Neg, "neg" },
			{ Opcode.Negc, "negc" },
			{ Opcode.Nop, "nop" },
			{ Opcode.Not, "not" },
			{ Opcode.Nott, "nott" },
			{ Opcode.Ocbi, "ocbi" },
			{ Opcode.Ocbp, "ocbp" },
			{ Opcode.Ocbwb, "ocbwb" },
			{ Opcode.Or, "or" },
			{ Opcode.Or_b, "or.b" },
			{ Opcode.Pref, "pref" },
			{ Opcode.Prefi, "prefi" },
			{ Opcode.Resbank, "resbank" },
			{ Opcode.Rotcl, "rotcl" },
			{ Opcode.Rotcr, "rotcr" },
			{ Opcode.Rotl, "rotl" },
			{ Opcode.Rotr, "rotr" },
			{ Opcode.Rte, "rte" },
			{ Opcode.Rts, "rts" },
			{ Opcode.RtsN, "rts/n" },
			{ Opcode.RtvN, "rtv/n" },
			{ Opcode.Sets, "sets" },
			{ Opcode.Sett, "sett" },
			{ Opcode.Shad, "shad" },
			{ Opcode.Shal, "shal" },
			{ Opcode.Shar, "shar" },
			{ Opcode.Shld, "shld" },
			{ Opcode.Shll, "shll" },
			{ Opcode.Shll16, "shll16" },
			{ Opcode.Shll2, "shll2" },
			{ Opcode.Shll8, "shll8" },
			{ Opcode.Shlr, "shlr" },
			{ Opcode.Shlr16, "shlr16" },
			{ Opcode.Shlr2, "shlr2" },
			{ Opcode.Shlr8, "shlr8" },
			{ Opcode.Sleep, "sleep" },
			{ Opcode.Stbank, "stbank" },
			{ Opcode.Stc, "stc" },
			{ Opcode.Stc_l, "stc.l" },
			{ Opcode.Sts, "sts" },
			{ Opcode.Sts_l, "sts.l" },
			{ Opcode.Sub, "sub" },
			{ Opcode.Subc, "subc" },
			{ Opcode.Subv, "subv" },
			{ Opcode.Swap_b, "swap.b" },
			{ Opcode.Swap_w, "swap.w" },
			{ Opcode.Synco, "synco" },
			{ Opcode.Tas_b, "tas.b" },
			{ Opcode.Trapa, "trapa" },
			{ Opcode.Tst, "tst" },
			{ Opcode.Tst_b, "tst.b" },
			{ Opcode.Word, ".word" },
			{ Opcode.Xor, "xor" },
			{ Opcode.Xor_b, "xor.b" },
			{ Opcode.Xtrct, "xtrct" }
		};
	}
}
