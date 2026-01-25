// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace SuperHot
{
    /// <summary>
    /// Registers of the SuperH processors
    /// </summary>
    public enum Register
    {
        None = 0,

        #region General-purpose registers for data manipulation and addressing

        /// <summary>
        /// R0: General Purpose Register 0
        /// </summary>
        r0,

        /// <summary>
        /// R1: General Purpose Register 1
        /// </summary>
        r1,

        /// <summary>
        /// R2: General Purpose Register 2
        /// </summary>
        r2,

        /// <summary>
        /// R3: General Purpose Register 3
        /// </summary>
        r3,

        /// <summary>
        /// R4: General Purpose Register 4
        /// </summary>
        r4,

        /// <summary>
        /// R5: General Purpose Register 5
        /// </summary>
        r5,

        /// <summary>
        /// R6: General Purpose Register 6
        /// </summary>
        r6,

        /// <summary>
        /// R7: General Purpose Register 7
        /// </summary>
        r7,

        /// <summary>
        /// R8: General Purpose Register 8
        /// </summary>
        r8,

        /// <summary>
        /// R9: General Purpose Register 9
        /// </summary>
        r9,

        /// <summary>
        /// R10: General Purpose Register 10
        /// </summary>
        r10,

        /// <summary>
        /// R11: General Purpose Register 11
        /// </summary>
        r11,

        /// <summary>
        /// R12: General Purpose Register 12
        /// </summary>
        r12,

        /// <summary>
        /// R13: General Purpose Register 13 
        /// </summary>
        r13,

        /// <summary>
        /// R14: General Purpose Register 14
        /// </summary>
        r14,

        /// <summary>
        /// R15: General Purpose Register 15 (stack pointer)
        /// </summary>
        r15,

        #endregion

        #region Banked versions of general registers for interrupt/exception handling

        /// <summary>
        /// R0_BANK: Banked General Purpose Register 0
        /// </summary>
        r0_bank,

        /// <summary>
        /// R1_BANK: Banked General Purpose Register 1
        /// </summary>
        r1_bank,

        /// <summary>
        /// R2_BANK: Banked General Purpose Register 2
        /// </summary>
        r2_bank,

        /// <summary>
        /// R3_BANK: Banked General Purpose Register 3
        /// </summary>
        r3_bank,

        /// <summary>
        /// R4_BANK: Banked General Purpose Register 4
        /// </summary>
        r4_bank,

        /// <summary>
        /// R5_BANK: Banked General Purpose Register 5
        /// </summary>
        r5_bank,

        /// <summary>
        /// R6_BANK: Banked General Purpose Register 6
        /// </summary>
        r6_bank,

        /// <summary>
        /// R7_BANK: Banked General Purpose Register 7
        /// </summary>
        r7_bank,

        #endregion

        #region Control and status registers for processor state management

        /// <summary>
        /// PC: Program Counter
        /// </summary>
        pc,

        /// <summary>
        /// PR: Procedure Register
        /// </summary>
        pr,

        /// <summary>
        /// SR: Status Register
        /// </summary>
        sr,

        /// <summary>
        /// GBR: Global Base Register
        /// </summary>
        gbr,

        /// <summary>
        /// VBR: Vector Base Register
        /// </summary>
        vbr,

        /// <summary>
        /// TBR: Jump Table Base Register
        /// </summary>
        tbr,

        /// <summary>
        /// DBR: Debug Base Register
        /// </summary>
        dbr,

        #endregion

        #region Registers that preserve state during exceptions

        /// <summary>
        /// SPC: Saved Program Counter
        /// </summary>
        spc,

        /// <summary>
        /// SSR: Saved Status Register
        /// </summary>
        ssr,

        /// <summary>
        /// SGR: Saved General Register 15 (stack pointer)",
        /// </summary>
        sgr,

        #endregion

        #region Registers for multiply and accumulate operations

        /// <summary>
        /// MACH: Multiply-Accumulate Register High
        /// </summary>
        mach,

        /// <summary>
        /// MACL: Multiply-Accumulate Register Low
        /// </summary>
        macl,

        #endregion

        #region Single-precision floating-point registers

        /// <summary>
        /// FR0: Floating-Point Register 0
        /// </summary>
        fr0,

        /// <summary>
        /// FR1: Floating-Point Register 1
        /// </summary>
        fr1,

        /// <summary>
        /// FR2: Floating-Point Register 2
        /// </summary>
        fr2,

        /// <summary>
        /// FR3: Floating-Point Register 3
        /// </summary>
        fr3,

        /// <summary>
        /// FR4: Floating-Point Register 4
        /// </summary>
        fr4,

        /// <summary>
        /// FR5: Floating-Point Register 5
        /// </summary>
        fr5,

        /// <summary>
        /// FR6: Floating-Point Register 6
        /// </summary>
        fr6,

        /// <summary>
        /// FR7: Floating-Point Register 7
        /// </summary>
        fr7,

        /// <summary>
        /// FR8: Floating-Point Register 8
        /// </summary>
        fr8,

        /// <summary>
        /// FR9: Floating-Point Register 9
        /// </summary>
        fr9,

        /// <summary>
        /// FR10: Floating-Point Register 10
        /// </summary>
        fr10,

        /// <summary>
        /// FR11: Floating-Point Register 11
        /// </summary>
        fr11,

        /// <summary>
        /// FR12: Floating-Point Register 12
        /// </summary>
        fr12,

        /// <summary>
        /// FR13: Floating-Point Register 13
        /// </summary>
        fr13,

        /// <summary>
        /// FR14: Floating-Point Register 14
        /// </summary>
        fr14,

        /// <summary>
        /// FR15: Floating-Point Register 15 
        /// </summary>
        fr15,

        #endregion

        #region Double-precision floating-point registers

        /// <summary>
        /// DR0: Double-Precision FP Register 0
        /// </summary>
        dr0,

        /// <summary>
        /// DR2: Double-Precision FP Register 2
        /// </summary>
        dr2,

        /// <summary>
        /// DR4: Double-Precision FP Register 4
        /// </summary>
        dr4,

        /// <summary>
        /// DR6: Double-Precision FP Register 6
        /// </summary>
        dr6,

        /// <summary>
        /// DR8: Double-Precision FP Register 8
        /// </summary>
        dr8,

        /// <summary>
        /// DR10: Double-Precision FP Register 10
        /// </summary>
        dr10,

        /// <summary>
        /// DR12: Double-Precision FP Register 12
        /// </summary>
        dr12,

        /// <summary>
        /// DR14: Double-Precision FP Register 14
        /// </summary>
        dr14,

        #endregion

        #region Vector floating-point registers

        /// <summary>
        /// FV0: FP Vector Register 0
        /// </summary>
        fv0,

        /// <summary>
        /// FV4: FP Vector Register 4
        /// </summary>
        fv4,

        /// <summary>
        /// FV8: FP Vector Register 8
        /// </summary>
        fv8,

        /// <summary>
        /// FV12: FP Vector Register 12
        /// </summary>
        fv12,

        #endregion

        #region Floating-point control and communication registers

        /// <summary>
        /// FPSCR: Floating-Point Status/Control Register
        /// </summary>
        fpscr,

        /// <summary>
        /// FPUL: Floating-Point Communication Register
        /// </summary>
        fpul,

        /// <summary>
        /// XMTRX: Extended Register Matrix
        /// </summary>
        xmtrx

        #endregion
    }
}