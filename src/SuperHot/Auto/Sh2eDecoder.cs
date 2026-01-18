using System;
using static SuperHot.Instruct;

// ReSharper disable RedundantAssignment

namespace SuperHot.Auto
{
	public sealed class Sh2eDecoder : IDecoder
	{
		public Instruction Decode(IByteReader r)
		{
			byte b0 = 0;
			byte b1 = 0;

			switch (b0 = r.ReadOne())
			{
				case 0x00: return Decode_00(r, ref b0, ref b1);
				case 0x01: return Decode_01(r, ref b0, ref b1);
				case 0x02: return Decode_02(r, ref b0, ref b1);
				case 0x03: return Decode_03(r, ref b0, ref b1);
				case 0x04: return Decode_04(r, ref b0, ref b1);
				case 0x05: return Decode_05(r, ref b0, ref b1);
				case 0x06: return Decode_06(r, ref b0, ref b1);
				case 0x07: return Decode_07(r, ref b0, ref b1);
				case 0x08: return Decode_08(r, ref b0, ref b1);
				case 0x09: return Decode_09(r, ref b0, ref b1);
				case 0x0a: return Decode_0a(r, ref b0, ref b1);
				case 0x0b: return Decode_0b(r, ref b0, ref b1);
				case 0x0c: return Decode_0c(r, ref b0, ref b1);
				case 0x0d: return Decode_0d(r, ref b0, ref b1);
				case 0x0e: return Decode_0e(r, ref b0, ref b1);
				case 0x0f: return Decode_0f(r, ref b0, ref b1);
				case 0x10: return Decode_10(r, ref b0, ref b1);
				case 0x11: return Decode_11(r, ref b0, ref b1);
				case 0x12: return Decode_12(r, ref b0, ref b1);
				case 0x13: return Decode_13(r, ref b0, ref b1);
				case 0x14: return Decode_14(r, ref b0, ref b1);
				case 0x15: return Decode_15(r, ref b0, ref b1);
				case 0x16: return Decode_16(r, ref b0, ref b1);
				case 0x17: return Decode_17(r, ref b0, ref b1);
				case 0x18: return Decode_18(r, ref b0, ref b1);
				case 0x19: return Decode_19(r, ref b0, ref b1);
				case 0x1a: return Decode_1a(r, ref b0, ref b1);
				case 0x1b: return Decode_1b(r, ref b0, ref b1);
				case 0x1c: return Decode_1c(r, ref b0, ref b1);
				case 0x1d: return Decode_1d(r, ref b0, ref b1);
				case 0x1e: return Decode_1e(r, ref b0, ref b1);
				case 0x1f: return Decode_1f(r, ref b0, ref b1);
				case 0x20: return Decode_20(r, ref b0, ref b1);
				case 0x21: return Decode_21(r, ref b0, ref b1);
				case 0x22: return Decode_22(r, ref b0, ref b1);
				case 0x23: return Decode_23(r, ref b0, ref b1);
				case 0x24: return Decode_24(r, ref b0, ref b1);
				case 0x25: return Decode_25(r, ref b0, ref b1);
				case 0x26: return Decode_26(r, ref b0, ref b1);
				case 0x27: return Decode_27(r, ref b0, ref b1);
				case 0x28: return Decode_28(r, ref b0, ref b1);
				case 0x29: return Decode_29(r, ref b0, ref b1);
				case 0x2a: return Decode_2a(r, ref b0, ref b1);
				case 0x2b: return Decode_2b(r, ref b0, ref b1);
				case 0x2c: return Decode_2c(r, ref b0, ref b1);
				case 0x2d: return Decode_2d(r, ref b0, ref b1);
				case 0x2e: return Decode_2e(r, ref b0, ref b1);
				case 0x2f: return Decode_2f(r, ref b0, ref b1);
				case 0x30: return Decode_30(r, ref b0, ref b1);
				case 0x31: return Decode_31(r, ref b0, ref b1);
				case 0x32: return Decode_32(r, ref b0, ref b1);
				case 0x33: return Decode_33(r, ref b0, ref b1);
				case 0x34: return Decode_34(r, ref b0, ref b1);
				case 0x35: return Decode_35(r, ref b0, ref b1);
				case 0x36: return Decode_36(r, ref b0, ref b1);
				case 0x37: return Decode_37(r, ref b0, ref b1);
				case 0x38: return Decode_38(r, ref b0, ref b1);
				case 0x39: return Decode_39(r, ref b0, ref b1);
				case 0x3a: return Decode_3a(r, ref b0, ref b1);
				case 0x3b: return Decode_3b(r, ref b0, ref b1);
				case 0x3c: return Decode_3c(r, ref b0, ref b1);
				case 0x3d: return Decode_3d(r, ref b0, ref b1);
				case 0x3e: return Decode_3e(r, ref b0, ref b1);
				case 0x3f: return Decode_3f(r, ref b0, ref b1);
				case 0x40: return Decode_40(r, ref b0, ref b1);
				case 0x41: return Decode_41(r, ref b0, ref b1);
				case 0x42: return Decode_42(r, ref b0, ref b1);
				case 0x43: return Decode_43(r, ref b0, ref b1);
				case 0x44: return Decode_44(r, ref b0, ref b1);
				case 0x45: return Decode_45(r, ref b0, ref b1);
				case 0x46: return Decode_46(r, ref b0, ref b1);
				case 0x47: return Decode_47(r, ref b0, ref b1);
				case 0x48: return Decode_48(r, ref b0, ref b1);
				case 0x49: return Decode_49(r, ref b0, ref b1);
				case 0x4a: return Decode_4a(r, ref b0, ref b1);
				case 0x4b: return Decode_4b(r, ref b0, ref b1);
				case 0x4c: return Decode_4c(r, ref b0, ref b1);
				case 0x4d: return Decode_4d(r, ref b0, ref b1);
				case 0x4e: return Decode_4e(r, ref b0, ref b1);
				case 0x4f: return Decode_4f(r, ref b0, ref b1);
				case 0x50: return Decode_50(r, ref b0, ref b1);
				case 0x51: return Decode_51(r, ref b0, ref b1);
				case 0x52: return Decode_52(r, ref b0, ref b1);
				case 0x53: return Decode_53(r, ref b0, ref b1);
				case 0x54: return Decode_54(r, ref b0, ref b1);
				case 0x55: return Decode_55(r, ref b0, ref b1);
				case 0x56: return Decode_56(r, ref b0, ref b1);
				case 0x57: return Decode_57(r, ref b0, ref b1);
				case 0x58: return Decode_58(r, ref b0, ref b1);
				case 0x59: return Decode_59(r, ref b0, ref b1);
				case 0x5a: return Decode_5a(r, ref b0, ref b1);
				case 0x5b: return Decode_5b(r, ref b0, ref b1);
				case 0x5c: return Decode_5c(r, ref b0, ref b1);
				case 0x5d: return Decode_5d(r, ref b0, ref b1);
				case 0x5e: return Decode_5e(r, ref b0, ref b1);
				case 0x5f: return Decode_5f(r, ref b0, ref b1);
				case 0x60: return Decode_60(r, ref b0, ref b1);
				case 0x61: return Decode_61(r, ref b0, ref b1);
				case 0x62: return Decode_62(r, ref b0, ref b1);
				case 0x63: return Decode_63(r, ref b0, ref b1);
				case 0x64: return Decode_64(r, ref b0, ref b1);
				case 0x65: return Decode_65(r, ref b0, ref b1);
				case 0x66: return Decode_66(r, ref b0, ref b1);
				case 0x67: return Decode_67(r, ref b0, ref b1);
				case 0x68: return Decode_68(r, ref b0, ref b1);
				case 0x69: return Decode_69(r, ref b0, ref b1);
				case 0x6a: return Decode_6a(r, ref b0, ref b1);
				case 0x6b: return Decode_6b(r, ref b0, ref b1);
				case 0x6c: return Decode_6c(r, ref b0, ref b1);
				case 0x6d: return Decode_6d(r, ref b0, ref b1);
				case 0x6e: return Decode_6e(r, ref b0, ref b1);
				case 0x6f: return Decode_6f(r, ref b0, ref b1);
				case 0x70: return Decode_70(r, ref b0, ref b1);
				case 0x71: return Decode_71(r, ref b0, ref b1);
				case 0x72: return Decode_72(r, ref b0, ref b1);
				case 0x73: return Decode_73(r, ref b0, ref b1);
				case 0x74: return Decode_74(r, ref b0, ref b1);
				case 0x75: return Decode_75(r, ref b0, ref b1);
				case 0x76: return Decode_76(r, ref b0, ref b1);
				case 0x77: return Decode_77(r, ref b0, ref b1);
				case 0x78: return Decode_78(r, ref b0, ref b1);
				case 0x79: return Decode_79(r, ref b0, ref b1);
				case 0x7a: return Decode_7a(r, ref b0, ref b1);
				case 0x7b: return Decode_7b(r, ref b0, ref b1);
				case 0x7c: return Decode_7c(r, ref b0, ref b1);
				case 0x7d: return Decode_7d(r, ref b0, ref b1);
				case 0x7e: return Decode_7e(r, ref b0, ref b1);
				case 0x7f: return Decode_7f(r, ref b0, ref b1);
				case 0x80: return Decode_80(r, ref b0, ref b1);
				case 0x81: return Decode_81(r, ref b0, ref b1);
				case 0x82: return Decode_82(r, ref b0, ref b1);
				case 0x83: return Decode_83(r, ref b0, ref b1);
				case 0x84: return Decode_84(r, ref b0, ref b1);
				case 0x85: return Decode_85(r, ref b0, ref b1);
				case 0x86: return Decode_86(r, ref b0, ref b1);
				case 0x87: return Decode_87(r, ref b0, ref b1);
				case 0x88: return Decode_88(r, ref b0, ref b1);
				case 0x89: return Decode_89(r, ref b0, ref b1);
				case 0x8a: return Decode_8a(r, ref b0, ref b1);
				case 0x8b: return Decode_8b(r, ref b0, ref b1);
				case 0x8c: return Decode_8c(r, ref b0, ref b1);
				case 0x8d: return Decode_8d(r, ref b0, ref b1);
				case 0x8e: return Decode_8e(r, ref b0, ref b1);
				case 0x8f: return Decode_8f(r, ref b0, ref b1);
				case 0x90: return Decode_90(r, ref b0, ref b1);
				case 0x91: return Decode_91(r, ref b0, ref b1);
				case 0x92: return Decode_92(r, ref b0, ref b1);
				case 0x93: return Decode_93(r, ref b0, ref b1);
				case 0x94: return Decode_94(r, ref b0, ref b1);
				case 0x95: return Decode_95(r, ref b0, ref b1);
				case 0x96: return Decode_96(r, ref b0, ref b1);
				case 0x97: return Decode_97(r, ref b0, ref b1);
				case 0x98: return Decode_98(r, ref b0, ref b1);
				case 0x99: return Decode_99(r, ref b0, ref b1);
				case 0x9a: return Decode_9a(r, ref b0, ref b1);
				case 0x9b: return Decode_9b(r, ref b0, ref b1);
				case 0x9c: return Decode_9c(r, ref b0, ref b1);
				case 0x9d: return Decode_9d(r, ref b0, ref b1);
				case 0x9e: return Decode_9e(r, ref b0, ref b1);
				case 0x9f: return Decode_9f(r, ref b0, ref b1);
				case 0xa0: return Decode_a0(r, ref b0, ref b1);
				case 0xa1: return Decode_a1(r, ref b0, ref b1);
				case 0xa2: return Decode_a2(r, ref b0, ref b1);
				case 0xa3: return Decode_a3(r, ref b0, ref b1);
				case 0xa4: return Decode_a4(r, ref b0, ref b1);
				case 0xa5: return Decode_a5(r, ref b0, ref b1);
				case 0xa6: return Decode_a6(r, ref b0, ref b1);
				case 0xa7: return Decode_a7(r, ref b0, ref b1);
				case 0xa8: return Decode_a8(r, ref b0, ref b1);
				case 0xa9: return Decode_a9(r, ref b0, ref b1);
				case 0xaa: return Decode_aa(r, ref b0, ref b1);
				case 0xab: return Decode_ab(r, ref b0, ref b1);
				case 0xac: return Decode_ac(r, ref b0, ref b1);
				case 0xad: return Decode_ad(r, ref b0, ref b1);
				case 0xae: return Decode_ae(r, ref b0, ref b1);
				case 0xaf: return Decode_af(r, ref b0, ref b1);
				case 0xb0: return Decode_b0(r, ref b0, ref b1);
				case 0xb1: return Decode_b1(r, ref b0, ref b1);
				case 0xb2: return Decode_b2(r, ref b0, ref b1);
				case 0xb3: return Decode_b3(r, ref b0, ref b1);
				case 0xb4: return Decode_b4(r, ref b0, ref b1);
				case 0xb5: return Decode_b5(r, ref b0, ref b1);
				case 0xb6: return Decode_b6(r, ref b0, ref b1);
				case 0xb7: return Decode_b7(r, ref b0, ref b1);
				case 0xb8: return Decode_b8(r, ref b0, ref b1);
				case 0xb9: return Decode_b9(r, ref b0, ref b1);
				case 0xba: return Decode_ba(r, ref b0, ref b1);
				case 0xbb: return Decode_bb(r, ref b0, ref b1);
				case 0xbc: return Decode_bc(r, ref b0, ref b1);
				case 0xbd: return Decode_bd(r, ref b0, ref b1);
				case 0xbe: return Decode_be(r, ref b0, ref b1);
				case 0xbf: return Decode_bf(r, ref b0, ref b1);
				case 0xc0: return Decode_c0(r, ref b0, ref b1);
				case 0xc1: return Decode_c1(r, ref b0, ref b1);
				case 0xc2: return Decode_c2(r, ref b0, ref b1);
				case 0xc3: return Decode_c3(r, ref b0, ref b1);
				case 0xc4: return Decode_c4(r, ref b0, ref b1);
				case 0xc5: return Decode_c5(r, ref b0, ref b1);
				case 0xc6: return Decode_c6(r, ref b0, ref b1);
				case 0xc7: return Decode_c7(r, ref b0, ref b1);
				case 0xc8: return Decode_c8(r, ref b0, ref b1);
				case 0xc9: return Decode_c9(r, ref b0, ref b1);
				case 0xca: return Decode_ca(r, ref b0, ref b1);
				case 0xcb: return Decode_cb(r, ref b0, ref b1);
				case 0xcc: return Decode_cc(r, ref b0, ref b1);
				case 0xcd: return Decode_cd(r, ref b0, ref b1);
				case 0xce: return Decode_ce(r, ref b0, ref b1);
				case 0xcf: return Decode_cf(r, ref b0, ref b1);
				case 0xd0: return Decode_d0(r, ref b0, ref b1);
				case 0xd1: return Decode_d1(r, ref b0, ref b1);
				case 0xd2: return Decode_d2(r, ref b0, ref b1);
				case 0xd3: return Decode_d3(r, ref b0, ref b1);
				case 0xd4: return Decode_d4(r, ref b0, ref b1);
				case 0xd5: return Decode_d5(r, ref b0, ref b1);
				case 0xd6: return Decode_d6(r, ref b0, ref b1);
				case 0xd7: return Decode_d7(r, ref b0, ref b1);
				case 0xd8: return Decode_d8(r, ref b0, ref b1);
				case 0xd9: return Decode_d9(r, ref b0, ref b1);
				case 0xda: return Decode_da(r, ref b0, ref b1);
				case 0xdb: return Decode_db(r, ref b0, ref b1);
				case 0xdc: return Decode_dc(r, ref b0, ref b1);
				case 0xdd: return Decode_dd(r, ref b0, ref b1);
				case 0xde: return Decode_de(r, ref b0, ref b1);
				case 0xdf: return Decode_df(r, ref b0, ref b1);
				case 0xe0: return Decode_e0(r, ref b0, ref b1);
				case 0xe1: return Decode_e1(r, ref b0, ref b1);
				case 0xe2: return Decode_e2(r, ref b0, ref b1);
				case 0xe3: return Decode_e3(r, ref b0, ref b1);
				case 0xe4: return Decode_e4(r, ref b0, ref b1);
				case 0xe5: return Decode_e5(r, ref b0, ref b1);
				case 0xe6: return Decode_e6(r, ref b0, ref b1);
				case 0xe7: return Decode_e7(r, ref b0, ref b1);
				case 0xe8: return Decode_e8(r, ref b0, ref b1);
				case 0xe9: return Decode_e9(r, ref b0, ref b1);
				case 0xea: return Decode_ea(r, ref b0, ref b1);
				case 0xeb: return Decode_eb(r, ref b0, ref b1);
				case 0xec: return Decode_ec(r, ref b0, ref b1);
				case 0xed: return Decode_ed(r, ref b0, ref b1);
				case 0xee: return Decode_ee(r, ref b0, ref b1);
				case 0xef: return Decode_ef(r, ref b0, ref b1);
				case 0xf0: return Decode_f0(r, ref b0, ref b1);
				case 0xf1: return Decode_f1(r, ref b0, ref b1);
				case 0xf2: return Decode_f2(r, ref b0, ref b1);
				case 0xf3: return Decode_f3(r, ref b0, ref b1);
				case 0xf4: return Decode_f4(r, ref b0, ref b1);
				case 0xf5: return Decode_f5(r, ref b0, ref b1);
				case 0xf6: return Decode_f6(r, ref b0, ref b1);
				case 0xf7: return Decode_f7(r, ref b0, ref b1);
				case 0xf8: return Decode_f8(r, ref b0, ref b1);
				case 0xf9: return Decode_f9(r, ref b0, ref b1);
				case 0xfa: return Decode_fa(r, ref b0, ref b1);
				case 0xfb: return Decode_fb(r, ref b0, ref b1);
				case 0xfc: return Decode_fc(r, ref b0, ref b1);
				case 0xfd: return Decode_fd(r, ref b0, ref b1);
				case 0xfe: return Decode_fe(r, ref b0, ref b1);
				case 0xff: return Decode_ff(r, ref b0, ref b1);
			}
		}

		private static Instruction Decode_00(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0000);
				case 0x01: return Word(0x0001);
				case 0x02: return Stc(sr,r0);
				case 0x03: return Bsrf(r0);
				case 0x04: return Mov_b(r0,at(r0,r0));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_01(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0100);
				case 0x01: return Word(0x0101);
				case 0x02: return Stc(sr,r1);
				case 0x03: return Bsrf(r1);
				case 0x04: return Mov_b(r0,at(r0,r1));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_02(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0200);
				case 0x01: return Word(0x0201);
				case 0x02: return Stc(sr,r2);
				case 0x03: return Bsrf(r2);
				case 0x04: return Mov_b(r0,at(r0,r2));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_03(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0300);
				case 0x01: return Word(0x0301);
				case 0x02: return Stc(sr,r3);
				case 0x03: return Bsrf(r3);
				case 0x04: return Mov_b(r0,at(r0,r3));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_04(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0400);
				case 0x01: return Word(0x0401);
				case 0x02: return Stc(sr,r4);
				case 0x03: return Bsrf(r4);
				case 0x04: return Mov_b(r0,at(r0,r4));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_05(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0500);
				case 0x01: return Word(0x0501);
				case 0x02: return Stc(sr,r5);
				case 0x03: return Bsrf(r5);
				case 0x04: return Mov_b(r0,at(r0,r5));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_06(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0600);
				case 0x01: return Word(0x0601);
				case 0x02: return Stc(sr,r6);
				case 0x03: return Bsrf(r6);
				case 0x04: return Mov_b(r0,at(r0,r6));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_07(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0700);
				case 0x01: return Word(0x0701);
				case 0x02: return Stc(sr,r7);
				case 0x03: return Bsrf(r7);
				case 0x04: return Mov_b(r0,at(r0,r7));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_08(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0800);
				case 0x01: return Word(0x0801);
				case 0x02: return Stc(sr,r8);
				case 0x03: return Bsrf(r8);
				case 0x04: return Mov_b(r0,at(r0,r8));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_09(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0900);
				case 0x01: return Word(0x0901);
				case 0x02: return Stc(sr,r9);
				case 0x03: return Bsrf(r9);
				case 0x04: return Mov_b(r0,at(r0,r9));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0a00);
				case 0x01: return Word(0x0a01);
				case 0x02: return Stc(sr,r10);
				case 0x03: return Bsrf(r10);
				case 0x04: return Mov_b(r0,at(r0,r10));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0b00);
				case 0x01: return Word(0x0b01);
				case 0x02: return Stc(sr,r11);
				case 0x03: return Bsrf(r11);
				case 0x04: return Mov_b(r0,at(r0,r11));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0c00);
				case 0x01: return Word(0x0c01);
				case 0x02: return Stc(sr,r12);
				case 0x03: return Bsrf(r12);
				case 0x04: return Mov_b(r0,at(r0,r12));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0d00);
				case 0x01: return Word(0x0d01);
				case 0x02: return Stc(sr,r13);
				case 0x03: return Bsrf(r13);
				case 0x04: return Mov_b(r0,at(r0,r13));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0e00);
				case 0x01: return Word(0x0e01);
				case 0x02: return Stc(sr,r14);
				case 0x03: return Bsrf(r14);
				case 0x04: return Mov_b(r0,at(r0,r14));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_0f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x0f00);
				case 0x01: return Word(0x0f01);
				case 0x02: return Stc(sr,r15);
				case 0x03: return Bsrf(r15);
				case 0x04: return Mov_b(r0,at(r0,r15));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_10(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r0));
				case 0x01: return Mov_l(r0,at(4,r0));
				case 0x02: return Mov_l(r0,at(8,r0));
				case 0x03: return Mov_l(r0,at(12,r0));
				case 0x04: return Mov_l(r0,at(16,r0));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_11(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r1));
				case 0x01: return Mov_l(r0,at(4,r1));
				case 0x02: return Mov_l(r0,at(8,r1));
				case 0x03: return Mov_l(r0,at(12,r1));
				case 0x04: return Mov_l(r0,at(16,r1));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_12(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r2));
				case 0x01: return Mov_l(r0,at(4,r2));
				case 0x02: return Mov_l(r0,at(8,r2));
				case 0x03: return Mov_l(r0,at(12,r2));
				case 0x04: return Mov_l(r0,at(16,r2));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_13(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r3));
				case 0x01: return Mov_l(r0,at(4,r3));
				case 0x02: return Mov_l(r0,at(8,r3));
				case 0x03: return Mov_l(r0,at(12,r3));
				case 0x04: return Mov_l(r0,at(16,r3));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_14(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r4));
				case 0x01: return Mov_l(r0,at(4,r4));
				case 0x02: return Mov_l(r0,at(8,r4));
				case 0x03: return Mov_l(r0,at(12,r4));
				case 0x04: return Mov_l(r0,at(16,r4));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_15(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r5));
				case 0x01: return Mov_l(r0,at(4,r5));
				case 0x02: return Mov_l(r0,at(8,r5));
				case 0x03: return Mov_l(r0,at(12,r5));
				case 0x04: return Mov_l(r0,at(16,r5));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_16(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r6));
				case 0x01: return Mov_l(r0,at(4,r6));
				case 0x02: return Mov_l(r0,at(8,r6));
				case 0x03: return Mov_l(r0,at(12,r6));
				case 0x04: return Mov_l(r0,at(16,r6));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_17(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r7));
				case 0x01: return Mov_l(r0,at(4,r7));
				case 0x02: return Mov_l(r0,at(8,r7));
				case 0x03: return Mov_l(r0,at(12,r7));
				case 0x04: return Mov_l(r0,at(16,r7));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_18(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r8));
				case 0x01: return Mov_l(r0,at(4,r8));
				case 0x02: return Mov_l(r0,at(8,r8));
				case 0x03: return Mov_l(r0,at(12,r8));
				case 0x04: return Mov_l(r0,at(16,r8));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_19(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r9));
				case 0x01: return Mov_l(r0,at(4,r9));
				case 0x02: return Mov_l(r0,at(8,r9));
				case 0x03: return Mov_l(r0,at(12,r9));
				case 0x04: return Mov_l(r0,at(16,r9));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r10));
				case 0x01: return Mov_l(r0,at(4,r10));
				case 0x02: return Mov_l(r0,at(8,r10));
				case 0x03: return Mov_l(r0,at(12,r10));
				case 0x04: return Mov_l(r0,at(16,r10));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r11));
				case 0x01: return Mov_l(r0,at(4,r11));
				case 0x02: return Mov_l(r0,at(8,r11));
				case 0x03: return Mov_l(r0,at(12,r11));
				case 0x04: return Mov_l(r0,at(16,r11));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r12));
				case 0x01: return Mov_l(r0,at(4,r12));
				case 0x02: return Mov_l(r0,at(8,r12));
				case 0x03: return Mov_l(r0,at(12,r12));
				case 0x04: return Mov_l(r0,at(16,r12));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r13));
				case 0x01: return Mov_l(r0,at(4,r13));
				case 0x02: return Mov_l(r0,at(8,r13));
				case 0x03: return Mov_l(r0,at(12,r13));
				case 0x04: return Mov_l(r0,at(16,r13));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r14));
				case 0x01: return Mov_l(r0,at(4,r14));
				case 0x02: return Mov_l(r0,at(8,r14));
				case 0x03: return Mov_l(r0,at(12,r14));
				case 0x04: return Mov_l(r0,at(16,r14));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_1f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,r15));
				case 0x01: return Mov_l(r0,at(4,r15));
				case 0x02: return Mov_l(r0,at(8,r15));
				case 0x03: return Mov_l(r0,at(12,r15));
				case 0x04: return Mov_l(r0,at(16,r15));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_20(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r0);
				case 0x01: return Mov_w(r0,at_r0);
				case 0x02: return Mov_l(r0,at_r0);
				case 0x03: return Word(0x2003);
				case 0x04: return Mov_b(r0,at_s_r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_21(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r1);
				case 0x01: return Mov_w(r0,at_r1);
				case 0x02: return Mov_l(r0,at_r1);
				case 0x03: return Word(0x2103);
				case 0x04: return Mov_b(r0,at_s_r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_22(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r2);
				case 0x01: return Mov_w(r0,at_r2);
				case 0x02: return Mov_l(r0,at_r2);
				case 0x03: return Word(0x2203);
				case 0x04: return Mov_b(r0,at_s_r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_23(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r3);
				case 0x01: return Mov_w(r0,at_r3);
				case 0x02: return Mov_l(r0,at_r3);
				case 0x03: return Word(0x2303);
				case 0x04: return Mov_b(r0,at_s_r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_24(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r4);
				case 0x01: return Mov_w(r0,at_r4);
				case 0x02: return Mov_l(r0,at_r4);
				case 0x03: return Word(0x2403);
				case 0x04: return Mov_b(r0,at_s_r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_25(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r5);
				case 0x01: return Mov_w(r0,at_r5);
				case 0x02: return Mov_l(r0,at_r5);
				case 0x03: return Word(0x2503);
				case 0x04: return Mov_b(r0,at_s_r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_26(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r6);
				case 0x01: return Mov_w(r0,at_r6);
				case 0x02: return Mov_l(r0,at_r6);
				case 0x03: return Word(0x2603);
				case 0x04: return Mov_b(r0,at_s_r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_27(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r7);
				case 0x01: return Mov_w(r0,at_r7);
				case 0x02: return Mov_l(r0,at_r7);
				case 0x03: return Word(0x2703);
				case 0x04: return Mov_b(r0,at_s_r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_28(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r8);
				case 0x01: return Mov_w(r0,at_r8);
				case 0x02: return Mov_l(r0,at_r8);
				case 0x03: return Word(0x2803);
				case 0x04: return Mov_b(r0,at_s_r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_29(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r9);
				case 0x01: return Mov_w(r0,at_r9);
				case 0x02: return Mov_l(r0,at_r9);
				case 0x03: return Word(0x2903);
				case 0x04: return Mov_b(r0,at_s_r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r10);
				case 0x01: return Mov_w(r0,at_r10);
				case 0x02: return Mov_l(r0,at_r10);
				case 0x03: return Word(0x2a03);
				case 0x04: return Mov_b(r0,at_s_r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r11);
				case 0x01: return Mov_w(r0,at_r11);
				case 0x02: return Mov_l(r0,at_r11);
				case 0x03: return Word(0x2b03);
				case 0x04: return Mov_b(r0,at_s_r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r12);
				case 0x01: return Mov_w(r0,at_r12);
				case 0x02: return Mov_l(r0,at_r12);
				case 0x03: return Word(0x2c03);
				case 0x04: return Mov_b(r0,at_s_r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r13);
				case 0x01: return Mov_w(r0,at_r13);
				case 0x02: return Mov_l(r0,at_r13);
				case 0x03: return Word(0x2d03);
				case 0x04: return Mov_b(r0,at_s_r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r14);
				case 0x01: return Mov_w(r0,at_r14);
				case 0x02: return Mov_l(r0,at_r14);
				case 0x03: return Word(0x2e03);
				case 0x04: return Mov_b(r0,at_s_r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_2f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at_r15);
				case 0x01: return Mov_w(r0,at_r15);
				case 0x02: return Mov_l(r0,at_r15);
				case 0x03: return Word(0x2f03);
				case 0x04: return Mov_b(r0,at_s_r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_30(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r0);
				case 0x01: return Word(0x3001);
				case 0x02: return CmpHs(r0,r0);
				case 0x03: return CmpGe(r0,r0);
				case 0x04: return Div1(r0,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_31(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r1);
				case 0x01: return Word(0x3101);
				case 0x02: return CmpHs(r0,r1);
				case 0x03: return CmpGe(r0,r1);
				case 0x04: return Div1(r0,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_32(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r2);
				case 0x01: return Word(0x3201);
				case 0x02: return CmpHs(r0,r2);
				case 0x03: return CmpGe(r0,r2);
				case 0x04: return Div1(r0,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_33(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r3);
				case 0x01: return Word(0x3301);
				case 0x02: return CmpHs(r0,r3);
				case 0x03: return CmpGe(r0,r3);
				case 0x04: return Div1(r0,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_34(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r4);
				case 0x01: return Word(0x3401);
				case 0x02: return CmpHs(r0,r4);
				case 0x03: return CmpGe(r0,r4);
				case 0x04: return Div1(r0,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_35(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r5);
				case 0x01: return Word(0x3501);
				case 0x02: return CmpHs(r0,r5);
				case 0x03: return CmpGe(r0,r5);
				case 0x04: return Div1(r0,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_36(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r6);
				case 0x01: return Word(0x3601);
				case 0x02: return CmpHs(r0,r6);
				case 0x03: return CmpGe(r0,r6);
				case 0x04: return Div1(r0,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_37(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r7);
				case 0x01: return Word(0x3701);
				case 0x02: return CmpHs(r0,r7);
				case 0x03: return CmpGe(r0,r7);
				case 0x04: return Div1(r0,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_38(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r8);
				case 0x01: return Word(0x3801);
				case 0x02: return CmpHs(r0,r8);
				case 0x03: return CmpGe(r0,r8);
				case 0x04: return Div1(r0,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_39(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r9);
				case 0x01: return Word(0x3901);
				case 0x02: return CmpHs(r0,r9);
				case 0x03: return CmpGe(r0,r9);
				case 0x04: return Div1(r0,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r10);
				case 0x01: return Word(0x3a01);
				case 0x02: return CmpHs(r0,r10);
				case 0x03: return CmpGe(r0,r10);
				case 0x04: return Div1(r0,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r11);
				case 0x01: return Word(0x3b01);
				case 0x02: return CmpHs(r0,r11);
				case 0x03: return CmpGe(r0,r11);
				case 0x04: return Div1(r0,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r12);
				case 0x01: return Word(0x3c01);
				case 0x02: return CmpHs(r0,r12);
				case 0x03: return CmpGe(r0,r12);
				case 0x04: return Div1(r0,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r13);
				case 0x01: return Word(0x3d01);
				case 0x02: return CmpHs(r0,r13);
				case 0x03: return CmpGe(r0,r13);
				case 0x04: return Div1(r0,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r14);
				case 0x01: return Word(0x3e01);
				case 0x02: return CmpHs(r0,r14);
				case 0x03: return CmpGe(r0,r14);
				case 0x04: return Div1(r0,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_3f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(r0,r15);
				case 0x01: return Word(0x3f01);
				case 0x02: return CmpHs(r0,r15);
				case 0x03: return CmpGe(r0,r15);
				case 0x04: return Div1(r0,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_40(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r0);
				case 0x01: return Shlr(r0);
				case 0x02: return Sts_l(mach,at_s_r0);
				case 0x03: return Stc_l(sr,at_s_r0);
				case 0x04: return Rotl(r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_41(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r1);
				case 0x01: return Shlr(r1);
				case 0x02: return Sts_l(mach,at_s_r1);
				case 0x03: return Stc_l(sr,at_s_r1);
				case 0x04: return Rotl(r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_42(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r2);
				case 0x01: return Shlr(r2);
				case 0x02: return Sts_l(mach,at_s_r2);
				case 0x03: return Stc_l(sr,at_s_r2);
				case 0x04: return Rotl(r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_43(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r3);
				case 0x01: return Shlr(r3);
				case 0x02: return Sts_l(mach,at_s_r3);
				case 0x03: return Stc_l(sr,at_s_r3);
				case 0x04: return Rotl(r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_44(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r4);
				case 0x01: return Shlr(r4);
				case 0x02: return Sts_l(mach,at_s_r4);
				case 0x03: return Stc_l(sr,at_s_r4);
				case 0x04: return Rotl(r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_45(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r5);
				case 0x01: return Shlr(r5);
				case 0x02: return Sts_l(mach,at_s_r5);
				case 0x03: return Stc_l(sr,at_s_r5);
				case 0x04: return Rotl(r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_46(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r6);
				case 0x01: return Shlr(r6);
				case 0x02: return Sts_l(mach,at_s_r6);
				case 0x03: return Stc_l(sr,at_s_r6);
				case 0x04: return Rotl(r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_47(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r7);
				case 0x01: return Shlr(r7);
				case 0x02: return Sts_l(mach,at_s_r7);
				case 0x03: return Stc_l(sr,at_s_r7);
				case 0x04: return Rotl(r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_48(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r8);
				case 0x01: return Shlr(r8);
				case 0x02: return Sts_l(mach,at_s_r8);
				case 0x03: return Stc_l(sr,at_s_r8);
				case 0x04: return Rotl(r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_49(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r9);
				case 0x01: return Shlr(r9);
				case 0x02: return Sts_l(mach,at_s_r9);
				case 0x03: return Stc_l(sr,at_s_r9);
				case 0x04: return Rotl(r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r10);
				case 0x01: return Shlr(r10);
				case 0x02: return Sts_l(mach,at_s_r10);
				case 0x03: return Stc_l(sr,at_s_r10);
				case 0x04: return Rotl(r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r11);
				case 0x01: return Shlr(r11);
				case 0x02: return Sts_l(mach,at_s_r11);
				case 0x03: return Stc_l(sr,at_s_r11);
				case 0x04: return Rotl(r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r12);
				case 0x01: return Shlr(r12);
				case 0x02: return Sts_l(mach,at_s_r12);
				case 0x03: return Stc_l(sr,at_s_r12);
				case 0x04: return Rotl(r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r13);
				case 0x01: return Shlr(r13);
				case 0x02: return Sts_l(mach,at_s_r13);
				case 0x03: return Stc_l(sr,at_s_r13);
				case 0x04: return Rotl(r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r14);
				case 0x01: return Shlr(r14);
				case 0x02: return Sts_l(mach,at_s_r14);
				case 0x03: return Stc_l(sr,at_s_r14);
				case 0x04: return Rotl(r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_4f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Shll(r15);
				case 0x01: return Shlr(r15);
				case 0x02: return Sts_l(mach,at_s_r15);
				case 0x03: return Stc_l(sr,at_s_r15);
				case 0x04: return Rotl(r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_50(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r0);
				case 0x01: return Mov_l(at(4,r0),r0);
				case 0x02: return Mov_l(at(8,r0),r0);
				case 0x03: return Mov_l(at(12,r0),r0);
				case 0x04: return Mov_l(at(16,r0),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_51(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r1);
				case 0x01: return Mov_l(at(4,r0),r1);
				case 0x02: return Mov_l(at(8,r0),r1);
				case 0x03: return Mov_l(at(12,r0),r1);
				case 0x04: return Mov_l(at(16,r0),r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_52(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r2);
				case 0x01: return Mov_l(at(4,r0),r2);
				case 0x02: return Mov_l(at(8,r0),r2);
				case 0x03: return Mov_l(at(12,r0),r2);
				case 0x04: return Mov_l(at(16,r0),r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_53(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r3);
				case 0x01: return Mov_l(at(4,r0),r3);
				case 0x02: return Mov_l(at(8,r0),r3);
				case 0x03: return Mov_l(at(12,r0),r3);
				case 0x04: return Mov_l(at(16,r0),r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_54(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r4);
				case 0x01: return Mov_l(at(4,r0),r4);
				case 0x02: return Mov_l(at(8,r0),r4);
				case 0x03: return Mov_l(at(12,r0),r4);
				case 0x04: return Mov_l(at(16,r0),r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_55(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r5);
				case 0x01: return Mov_l(at(4,r0),r5);
				case 0x02: return Mov_l(at(8,r0),r5);
				case 0x03: return Mov_l(at(12,r0),r5);
				case 0x04: return Mov_l(at(16,r0),r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_56(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r6);
				case 0x01: return Mov_l(at(4,r0),r6);
				case 0x02: return Mov_l(at(8,r0),r6);
				case 0x03: return Mov_l(at(12,r0),r6);
				case 0x04: return Mov_l(at(16,r0),r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_57(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r7);
				case 0x01: return Mov_l(at(4,r0),r7);
				case 0x02: return Mov_l(at(8,r0),r7);
				case 0x03: return Mov_l(at(12,r0),r7);
				case 0x04: return Mov_l(at(16,r0),r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_58(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r8);
				case 0x01: return Mov_l(at(4,r0),r8);
				case 0x02: return Mov_l(at(8,r0),r8);
				case 0x03: return Mov_l(at(12,r0),r8);
				case 0x04: return Mov_l(at(16,r0),r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_59(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r9);
				case 0x01: return Mov_l(at(4,r0),r9);
				case 0x02: return Mov_l(at(8,r0),r9);
				case 0x03: return Mov_l(at(12,r0),r9);
				case 0x04: return Mov_l(at(16,r0),r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r10);
				case 0x01: return Mov_l(at(4,r0),r10);
				case 0x02: return Mov_l(at(8,r0),r10);
				case 0x03: return Mov_l(at(12,r0),r10);
				case 0x04: return Mov_l(at(16,r0),r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r11);
				case 0x01: return Mov_l(at(4,r0),r11);
				case 0x02: return Mov_l(at(8,r0),r11);
				case 0x03: return Mov_l(at(12,r0),r11);
				case 0x04: return Mov_l(at(16,r0),r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r12);
				case 0x01: return Mov_l(at(4,r0),r12);
				case 0x02: return Mov_l(at(8,r0),r12);
				case 0x03: return Mov_l(at(12,r0),r12);
				case 0x04: return Mov_l(at(16,r0),r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r13);
				case 0x01: return Mov_l(at(4,r0),r13);
				case 0x02: return Mov_l(at(8,r0),r13);
				case 0x03: return Mov_l(at(12,r0),r13);
				case 0x04: return Mov_l(at(16,r0),r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r14);
				case 0x01: return Mov_l(at(4,r0),r14);
				case 0x02: return Mov_l(at(8,r0),r14);
				case 0x03: return Mov_l(at(12,r0),r14);
				case 0x04: return Mov_l(at(16,r0),r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_5f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,r0),r15);
				case 0x01: return Mov_l(at(4,r0),r15);
				case 0x02: return Mov_l(at(8,r0),r15);
				case 0x03: return Mov_l(at(12,r0),r15);
				case 0x04: return Mov_l(at(16,r0),r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_60(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r0);
				case 0x01: return Mov_w(at_r0,r0);
				case 0x02: return Mov_l(at_r0,r0);
				case 0x03: return Mov(r0,r0);
				case 0x04: return Mov_b(at_r0_a,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_61(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r1);
				case 0x01: return Mov_w(at_r0,r1);
				case 0x02: return Mov_l(at_r0,r1);
				case 0x03: return Mov(r0,r1);
				case 0x04: return Mov_b(at_r0_a,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_62(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r2);
				case 0x01: return Mov_w(at_r0,r2);
				case 0x02: return Mov_l(at_r0,r2);
				case 0x03: return Mov(r0,r2);
				case 0x04: return Mov_b(at_r0_a,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_63(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r3);
				case 0x01: return Mov_w(at_r0,r3);
				case 0x02: return Mov_l(at_r0,r3);
				case 0x03: return Mov(r0,r3);
				case 0x04: return Mov_b(at_r0_a,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_64(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r4);
				case 0x01: return Mov_w(at_r0,r4);
				case 0x02: return Mov_l(at_r0,r4);
				case 0x03: return Mov(r0,r4);
				case 0x04: return Mov_b(at_r0_a,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_65(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r5);
				case 0x01: return Mov_w(at_r0,r5);
				case 0x02: return Mov_l(at_r0,r5);
				case 0x03: return Mov(r0,r5);
				case 0x04: return Mov_b(at_r0_a,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_66(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r6);
				case 0x01: return Mov_w(at_r0,r6);
				case 0x02: return Mov_l(at_r0,r6);
				case 0x03: return Mov(r0,r6);
				case 0x04: return Mov_b(at_r0_a,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_67(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r7);
				case 0x01: return Mov_w(at_r0,r7);
				case 0x02: return Mov_l(at_r0,r7);
				case 0x03: return Mov(r0,r7);
				case 0x04: return Mov_b(at_r0_a,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_68(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r8);
				case 0x01: return Mov_w(at_r0,r8);
				case 0x02: return Mov_l(at_r0,r8);
				case 0x03: return Mov(r0,r8);
				case 0x04: return Mov_b(at_r0_a,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_69(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r9);
				case 0x01: return Mov_w(at_r0,r9);
				case 0x02: return Mov_l(at_r0,r9);
				case 0x03: return Mov(r0,r9);
				case 0x04: return Mov_b(at_r0_a,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r10);
				case 0x01: return Mov_w(at_r0,r10);
				case 0x02: return Mov_l(at_r0,r10);
				case 0x03: return Mov(r0,r10);
				case 0x04: return Mov_b(at_r0_a,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r11);
				case 0x01: return Mov_w(at_r0,r11);
				case 0x02: return Mov_l(at_r0,r11);
				case 0x03: return Mov(r0,r11);
				case 0x04: return Mov_b(at_r0_a,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r12);
				case 0x01: return Mov_w(at_r0,r12);
				case 0x02: return Mov_l(at_r0,r12);
				case 0x03: return Mov(r0,r12);
				case 0x04: return Mov_b(at_r0_a,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r13);
				case 0x01: return Mov_w(at_r0,r13);
				case 0x02: return Mov_l(at_r0,r13);
				case 0x03: return Mov(r0,r13);
				case 0x04: return Mov_b(at_r0_a,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r14);
				case 0x01: return Mov_w(at_r0,r14);
				case 0x02: return Mov_l(at_r0,r14);
				case 0x03: return Mov(r0,r14);
				case 0x04: return Mov_b(at_r0_a,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_6f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at_r0,r15);
				case 0x01: return Mov_w(at_r0,r15);
				case 0x02: return Mov_l(at_r0,r15);
				case 0x03: return Mov(r0,r15);
				case 0x04: return Mov_b(at_r0_a,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_70(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r0);
				case 0x01: return Add(h_1,r0);
				case 0x02: return Add(h_2,r0);
				case 0x03: return Add(h_3,r0);
				case 0x04: return Add(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_71(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r1);
				case 0x01: return Add(h_1,r1);
				case 0x02: return Add(h_2,r1);
				case 0x03: return Add(h_3,r1);
				case 0x04: return Add(h_4,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_72(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r2);
				case 0x01: return Add(h_1,r2);
				case 0x02: return Add(h_2,r2);
				case 0x03: return Add(h_3,r2);
				case 0x04: return Add(h_4,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_73(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r3);
				case 0x01: return Add(h_1,r3);
				case 0x02: return Add(h_2,r3);
				case 0x03: return Add(h_3,r3);
				case 0x04: return Add(h_4,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_74(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r4);
				case 0x01: return Add(h_1,r4);
				case 0x02: return Add(h_2,r4);
				case 0x03: return Add(h_3,r4);
				case 0x04: return Add(h_4,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_75(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r5);
				case 0x01: return Add(h_1,r5);
				case 0x02: return Add(h_2,r5);
				case 0x03: return Add(h_3,r5);
				case 0x04: return Add(h_4,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_76(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r6);
				case 0x01: return Add(h_1,r6);
				case 0x02: return Add(h_2,r6);
				case 0x03: return Add(h_3,r6);
				case 0x04: return Add(h_4,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_77(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r7);
				case 0x01: return Add(h_1,r7);
				case 0x02: return Add(h_2,r7);
				case 0x03: return Add(h_3,r7);
				case 0x04: return Add(h_4,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_78(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r8);
				case 0x01: return Add(h_1,r8);
				case 0x02: return Add(h_2,r8);
				case 0x03: return Add(h_3,r8);
				case 0x04: return Add(h_4,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_79(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r9);
				case 0x01: return Add(h_1,r9);
				case 0x02: return Add(h_2,r9);
				case 0x03: return Add(h_3,r9);
				case 0x04: return Add(h_4,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r10);
				case 0x01: return Add(h_1,r10);
				case 0x02: return Add(h_2,r10);
				case 0x03: return Add(h_3,r10);
				case 0x04: return Add(h_4,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r11);
				case 0x01: return Add(h_1,r11);
				case 0x02: return Add(h_2,r11);
				case 0x03: return Add(h_3,r11);
				case 0x04: return Add(h_4,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r12);
				case 0x01: return Add(h_1,r12);
				case 0x02: return Add(h_2,r12);
				case 0x03: return Add(h_3,r12);
				case 0x04: return Add(h_4,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r13);
				case 0x01: return Add(h_1,r13);
				case 0x02: return Add(h_2,r13);
				case 0x03: return Add(h_3,r13);
				case 0x04: return Add(h_4,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r14);
				case 0x01: return Add(h_1,r14);
				case 0x02: return Add(h_2,r14);
				case 0x03: return Add(h_3,r14);
				case 0x04: return Add(h_4,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_7f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Add(h_0,r15);
				case 0x01: return Add(h_1,r15);
				case 0x02: return Add(h_2,r15);
				case 0x03: return Add(h_3,r15);
				case 0x04: return Add(h_4,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_80(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at(0,r0));
				case 0x01: return Mov_b(r0,at(1,r0));
				case 0x02: return Mov_b(r0,at(2,r0));
				case 0x03: return Mov_b(r0,at(3,r0));
				case 0x04: return Mov_b(r0,at(4,r0));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_81(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(r0,at(0,r0));
				case 0x01: return Mov_w(r0,at(2,r0));
				case 0x02: return Mov_w(r0,at(4,r0));
				case 0x03: return Mov_w(r0,at(6,r0));
				case 0x04: return Mov_w(r0,at(8,r0));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_82(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8200);
				case 0x01: return Word(0x8201);
				case 0x02: return Word(0x8202);
				case 0x03: return Word(0x8203);
				case 0x04: return Word(0x8204);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_83(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8300);
				case 0x01: return Word(0x8301);
				case 0x02: return Word(0x8302);
				case 0x03: return Word(0x8303);
				case 0x04: return Word(0x8304);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_84(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at(0,r0),r0);
				case 0x01: return Mov_b(at(1,r0),r0);
				case 0x02: return Mov_b(at(2,r0),r0);
				case 0x03: return Mov_b(at(3,r0),r0);
				case 0x04: return Mov_b(at(4,r0),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_85(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(at(0,r0),r0);
				case 0x01: return Mov_w(at(2,r0),r0);
				case 0x02: return Mov_w(at(4,r0),r0);
				case 0x03: return Mov_w(at(6,r0),r0);
				case 0x04: return Mov_w(at(8,r0),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_86(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8600);
				case 0x01: return Word(0x8601);
				case 0x02: return Word(0x8602);
				case 0x03: return Word(0x8603);
				case 0x04: return Word(0x8604);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_87(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8700);
				case 0x01: return Word(0x8701);
				case 0x02: return Word(0x8702);
				case 0x03: return Word(0x8703);
				case 0x04: return Word(0x8704);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_88(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return CmpEq(h_0,r0);
				case 0x01: return CmpEq(h_1,r0);
				case 0x02: return CmpEq(h_2,r0);
				case 0x03: return CmpEq(h_3,r0);
				case 0x04: return CmpEq(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_89(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bt(0x4);
				case 0x01: return Bt(0x6);
				case 0x02: return Bt(0x8);
				case 0x03: return Bt(0xa);
				case 0x04: return Bt(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8a00);
				case 0x01: return Word(0x8a01);
				case 0x02: return Word(0x8a02);
				case 0x03: return Word(0x8a03);
				case 0x04: return Word(0x8a04);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bf(0x4);
				case 0x01: return Bf(0x6);
				case 0x02: return Bf(0x8);
				case 0x03: return Bf(0xa);
				case 0x04: return Bf(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8c00);
				case 0x01: return Word(0x8c01);
				case 0x02: return Word(0x8c02);
				case 0x03: return Word(0x8c03);
				case 0x04: return Word(0x8c04);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bt_s(0x4);
				case 0x01: return Bt_s(0x6);
				case 0x02: return Bt_s(0x8);
				case 0x03: return Bt_s(0xa);
				case 0x04: return Bt_s(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Word(0x8e00);
				case 0x01: return Word(0x8e01);
				case 0x02: return Word(0x8e02);
				case 0x03: return Word(0x8e03);
				case 0x04: return Word(0x8e04);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_8f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bf_s(0x4);
				case 0x01: return Bf_s(0x6);
				case 0x02: return Bf_s(0x8);
				case 0x03: return Bf_s(0xa);
				case 0x04: return Bf_s(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_90(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r0);
				case 0x01: return Mov_w(0x6,r0);
				case 0x02: return Mov_w(0x8,r0);
				case 0x03: return Mov_w(0xa,r0);
				case 0x04: return Mov_w(0xc,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_91(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r1);
				case 0x01: return Mov_w(0x6,r1);
				case 0x02: return Mov_w(0x8,r1);
				case 0x03: return Mov_w(0xa,r1);
				case 0x04: return Mov_w(0xc,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_92(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r2);
				case 0x01: return Mov_w(0x6,r2);
				case 0x02: return Mov_w(0x8,r2);
				case 0x03: return Mov_w(0xa,r2);
				case 0x04: return Mov_w(0xc,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_93(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r3);
				case 0x01: return Mov_w(0x6,r3);
				case 0x02: return Mov_w(0x8,r3);
				case 0x03: return Mov_w(0xa,r3);
				case 0x04: return Mov_w(0xc,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_94(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r4);
				case 0x01: return Mov_w(0x6,r4);
				case 0x02: return Mov_w(0x8,r4);
				case 0x03: return Mov_w(0xa,r4);
				case 0x04: return Mov_w(0xc,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_95(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r5);
				case 0x01: return Mov_w(0x6,r5);
				case 0x02: return Mov_w(0x8,r5);
				case 0x03: return Mov_w(0xa,r5);
				case 0x04: return Mov_w(0xc,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_96(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r6);
				case 0x01: return Mov_w(0x6,r6);
				case 0x02: return Mov_w(0x8,r6);
				case 0x03: return Mov_w(0xa,r6);
				case 0x04: return Mov_w(0xc,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_97(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r7);
				case 0x01: return Mov_w(0x6,r7);
				case 0x02: return Mov_w(0x8,r7);
				case 0x03: return Mov_w(0xa,r7);
				case 0x04: return Mov_w(0xc,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_98(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r8);
				case 0x01: return Mov_w(0x6,r8);
				case 0x02: return Mov_w(0x8,r8);
				case 0x03: return Mov_w(0xa,r8);
				case 0x04: return Mov_w(0xc,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_99(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r9);
				case 0x01: return Mov_w(0x6,r9);
				case 0x02: return Mov_w(0x8,r9);
				case 0x03: return Mov_w(0xa,r9);
				case 0x04: return Mov_w(0xc,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9a(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r10);
				case 0x01: return Mov_w(0x6,r10);
				case 0x02: return Mov_w(0x8,r10);
				case 0x03: return Mov_w(0xa,r10);
				case 0x04: return Mov_w(0xc,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9b(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r11);
				case 0x01: return Mov_w(0x6,r11);
				case 0x02: return Mov_w(0x8,r11);
				case 0x03: return Mov_w(0xa,r11);
				case 0x04: return Mov_w(0xc,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9c(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r12);
				case 0x01: return Mov_w(0x6,r12);
				case 0x02: return Mov_w(0x8,r12);
				case 0x03: return Mov_w(0xa,r12);
				case 0x04: return Mov_w(0xc,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9d(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r13);
				case 0x01: return Mov_w(0x6,r13);
				case 0x02: return Mov_w(0x8,r13);
				case 0x03: return Mov_w(0xa,r13);
				case 0x04: return Mov_w(0xc,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9e(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r14);
				case 0x01: return Mov_w(0x6,r14);
				case 0x02: return Mov_w(0x8,r14);
				case 0x03: return Mov_w(0xa,r14);
				case 0x04: return Mov_w(0xc,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_9f(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(0x4,r15);
				case 0x01: return Mov_w(0x6,r15);
				case 0x02: return Mov_w(0x8,r15);
				case 0x03: return Mov_w(0xa,r15);
				case 0x04: return Mov_w(0xc,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0x4);
				case 0x01: return Bra(0x6);
				case 0x02: return Bra(0x8);
				case 0x03: return Bra(0xa);
				case 0x04: return Bra(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0x204);
				case 0x01: return Bra(0x206);
				case 0x02: return Bra(0x208);
				case 0x03: return Bra(0x20a);
				case 0x04: return Bra(0x20c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0x404);
				case 0x01: return Bra(0x406);
				case 0x02: return Bra(0x408);
				case 0x03: return Bra(0x40a);
				case 0x04: return Bra(0x40c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0x604);
				case 0x01: return Bra(0x606);
				case 0x02: return Bra(0x608);
				case 0x03: return Bra(0x60a);
				case 0x04: return Bra(0x60c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0x804);
				case 0x01: return Bra(0x806);
				case 0x02: return Bra(0x808);
				case 0x03: return Bra(0x80a);
				case 0x04: return Bra(0x80c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xa04);
				case 0x01: return Bra(0xa06);
				case 0x02: return Bra(0xa08);
				case 0x03: return Bra(0xa0a);
				case 0x04: return Bra(0xa0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xc04);
				case 0x01: return Bra(0xc06);
				case 0x02: return Bra(0xc08);
				case 0x03: return Bra(0xc0a);
				case 0x04: return Bra(0xc0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xe04);
				case 0x01: return Bra(0xe06);
				case 0x02: return Bra(0xe08);
				case 0x03: return Bra(0xe0a);
				case 0x04: return Bra(0xe0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffff004);
				case 0x01: return Bra(0xfffff006);
				case 0x02: return Bra(0xfffff008);
				case 0x03: return Bra(0xfffff00a);
				case 0x04: return Bra(0xfffff00c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_a9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffff204);
				case 0x01: return Bra(0xfffff206);
				case 0x02: return Bra(0xfffff208);
				case 0x03: return Bra(0xfffff20a);
				case 0x04: return Bra(0xfffff20c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_aa(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffff404);
				case 0x01: return Bra(0xfffff406);
				case 0x02: return Bra(0xfffff408);
				case 0x03: return Bra(0xfffff40a);
				case 0x04: return Bra(0xfffff40c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ab(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffff604);
				case 0x01: return Bra(0xfffff606);
				case 0x02: return Bra(0xfffff608);
				case 0x03: return Bra(0xfffff60a);
				case 0x04: return Bra(0xfffff60c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ac(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffff804);
				case 0x01: return Bra(0xfffff806);
				case 0x02: return Bra(0xfffff808);
				case 0x03: return Bra(0xfffff80a);
				case 0x04: return Bra(0xfffff80c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ad(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffffa04);
				case 0x01: return Bra(0xfffffa06);
				case 0x02: return Bra(0xfffffa08);
				case 0x03: return Bra(0xfffffa0a);
				case 0x04: return Bra(0xfffffa0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ae(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffffc04);
				case 0x01: return Bra(0xfffffc06);
				case 0x02: return Bra(0xfffffc08);
				case 0x03: return Bra(0xfffffc0a);
				case 0x04: return Bra(0xfffffc0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_af(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bra(0xfffffe04);
				case 0x01: return Bra(0xfffffe06);
				case 0x02: return Bra(0xfffffe08);
				case 0x03: return Bra(0xfffffe0a);
				case 0x04: return Bra(0xfffffe0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0x4);
				case 0x01: return Bsr(0x6);
				case 0x02: return Bsr(0x8);
				case 0x03: return Bsr(0xa);
				case 0x04: return Bsr(0xc);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0x204);
				case 0x01: return Bsr(0x206);
				case 0x02: return Bsr(0x208);
				case 0x03: return Bsr(0x20a);
				case 0x04: return Bsr(0x20c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0x404);
				case 0x01: return Bsr(0x406);
				case 0x02: return Bsr(0x408);
				case 0x03: return Bsr(0x40a);
				case 0x04: return Bsr(0x40c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0x604);
				case 0x01: return Bsr(0x606);
				case 0x02: return Bsr(0x608);
				case 0x03: return Bsr(0x60a);
				case 0x04: return Bsr(0x60c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0x804);
				case 0x01: return Bsr(0x806);
				case 0x02: return Bsr(0x808);
				case 0x03: return Bsr(0x80a);
				case 0x04: return Bsr(0x80c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xa04);
				case 0x01: return Bsr(0xa06);
				case 0x02: return Bsr(0xa08);
				case 0x03: return Bsr(0xa0a);
				case 0x04: return Bsr(0xa0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xc04);
				case 0x01: return Bsr(0xc06);
				case 0x02: return Bsr(0xc08);
				case 0x03: return Bsr(0xc0a);
				case 0x04: return Bsr(0xc0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xe04);
				case 0x01: return Bsr(0xe06);
				case 0x02: return Bsr(0xe08);
				case 0x03: return Bsr(0xe0a);
				case 0x04: return Bsr(0xe0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffff004);
				case 0x01: return Bsr(0xfffff006);
				case 0x02: return Bsr(0xfffff008);
				case 0x03: return Bsr(0xfffff00a);
				case 0x04: return Bsr(0xfffff00c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_b9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffff204);
				case 0x01: return Bsr(0xfffff206);
				case 0x02: return Bsr(0xfffff208);
				case 0x03: return Bsr(0xfffff20a);
				case 0x04: return Bsr(0xfffff20c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ba(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffff404);
				case 0x01: return Bsr(0xfffff406);
				case 0x02: return Bsr(0xfffff408);
				case 0x03: return Bsr(0xfffff40a);
				case 0x04: return Bsr(0xfffff40c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_bb(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffff604);
				case 0x01: return Bsr(0xfffff606);
				case 0x02: return Bsr(0xfffff608);
				case 0x03: return Bsr(0xfffff60a);
				case 0x04: return Bsr(0xfffff60c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_bc(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffff804);
				case 0x01: return Bsr(0xfffff806);
				case 0x02: return Bsr(0xfffff808);
				case 0x03: return Bsr(0xfffff80a);
				case 0x04: return Bsr(0xfffff80c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_bd(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffffa04);
				case 0x01: return Bsr(0xfffffa06);
				case 0x02: return Bsr(0xfffffa08);
				case 0x03: return Bsr(0xfffffa0a);
				case 0x04: return Bsr(0xfffffa0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_be(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffffc04);
				case 0x01: return Bsr(0xfffffc06);
				case 0x02: return Bsr(0xfffffc08);
				case 0x03: return Bsr(0xfffffc0a);
				case 0x04: return Bsr(0xfffffc0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_bf(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Bsr(0xfffffe04);
				case 0x01: return Bsr(0xfffffe06);
				case 0x02: return Bsr(0xfffffe08);
				case 0x03: return Bsr(0xfffffe0a);
				case 0x04: return Bsr(0xfffffe0c);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(r0,at(0,gbr));
				case 0x01: return Mov_b(r0,at(1,gbr));
				case 0x02: return Mov_b(r0,at(2,gbr));
				case 0x03: return Mov_b(r0,at(3,gbr));
				case 0x04: return Mov_b(r0,at(4,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(r0,at(0,gbr));
				case 0x01: return Mov_w(r0,at(2,gbr));
				case 0x02: return Mov_w(r0,at(4,gbr));
				case 0x03: return Mov_w(r0,at(6,gbr));
				case 0x04: return Mov_w(r0,at(8,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(r0,at(0,gbr));
				case 0x01: return Mov_l(r0,at(4,gbr));
				case 0x02: return Mov_l(r0,at(8,gbr));
				case 0x03: return Mov_l(r0,at(12,gbr));
				case 0x04: return Mov_l(r0,at(16,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Trapa(h_0);
				case 0x01: return Trapa(h_1);
				case 0x02: return Trapa(h_2);
				case 0x03: return Trapa(h_3);
				case 0x04: return Trapa(h_4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_b(at(0,gbr),r0);
				case 0x01: return Mov_b(at(1,gbr),r0);
				case 0x02: return Mov_b(at(2,gbr),r0);
				case 0x03: return Mov_b(at(3,gbr),r0);
				case 0x04: return Mov_b(at(4,gbr),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_w(at(0,gbr),r0);
				case 0x01: return Mov_w(at(2,gbr),r0);
				case 0x02: return Mov_w(at(4,gbr),r0);
				case 0x03: return Mov_w(at(6,gbr),r0);
				case 0x04: return Mov_w(at(8,gbr),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(at(0,gbr),r0);
				case 0x01: return Mov_l(at(4,gbr),r0);
				case 0x02: return Mov_l(at(8,gbr),r0);
				case 0x03: return Mov_l(at(12,gbr),r0);
				case 0x04: return Mov_l(at(16,gbr),r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mova(0x4,r0);
				case 0x01: return Mova(0x8,r0);
				case 0x02: return Mova(0xc,r0);
				case 0x03: return Mova(0x10,r0);
				case 0x04: return Mova(0x14,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Tst(h_0,r0);
				case 0x01: return Tst(h_1,r0);
				case 0x02: return Tst(h_2,r0);
				case 0x03: return Tst(h_3,r0);
				case 0x04: return Tst(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_c9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return And(h_0,r0);
				case 0x01: return And(h_1,r0);
				case 0x02: return And(h_2,r0);
				case 0x03: return And(h_3,r0);
				case 0x04: return And(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ca(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Xor(h_0,r0);
				case 0x01: return Xor(h_1,r0);
				case 0x02: return Xor(h_2,r0);
				case 0x03: return Xor(h_3,r0);
				case 0x04: return Xor(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_cb(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Or(h_0,r0);
				case 0x01: return Or(h_1,r0);
				case 0x02: return Or(h_2,r0);
				case 0x03: return Or(h_3,r0);
				case 0x04: return Or(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_cc(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Tst_b(h_0,at(r0,gbr));
				case 0x01: return Tst_b(h_1,at(r0,gbr));
				case 0x02: return Tst_b(h_2,at(r0,gbr));
				case 0x03: return Tst_b(h_3,at(r0,gbr));
				case 0x04: return Tst_b(h_4,at(r0,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_cd(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return And_b(h_0,at(r0,gbr));
				case 0x01: return And_b(h_1,at(r0,gbr));
				case 0x02: return And_b(h_2,at(r0,gbr));
				case 0x03: return And_b(h_3,at(r0,gbr));
				case 0x04: return And_b(h_4,at(r0,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ce(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Xor_b(h_0,at(r0,gbr));
				case 0x01: return Xor_b(h_1,at(r0,gbr));
				case 0x02: return Xor_b(h_2,at(r0,gbr));
				case 0x03: return Xor_b(h_3,at(r0,gbr));
				case 0x04: return Xor_b(h_4,at(r0,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_cf(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Or_b(h_0,at(r0,gbr));
				case 0x01: return Or_b(h_1,at(r0,gbr));
				case 0x02: return Or_b(h_2,at(r0,gbr));
				case 0x03: return Or_b(h_3,at(r0,gbr));
				case 0x04: return Or_b(h_4,at(r0,gbr));
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r0);
				case 0x01: return Mov_l(0x8,r0);
				case 0x02: return Mov_l(0xc,r0);
				case 0x03: return Mov_l(0x10,r0);
				case 0x04: return Mov_l(0x14,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r1);
				case 0x01: return Mov_l(0x8,r1);
				case 0x02: return Mov_l(0xc,r1);
				case 0x03: return Mov_l(0x10,r1);
				case 0x04: return Mov_l(0x14,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r2);
				case 0x01: return Mov_l(0x8,r2);
				case 0x02: return Mov_l(0xc,r2);
				case 0x03: return Mov_l(0x10,r2);
				case 0x04: return Mov_l(0x14,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r3);
				case 0x01: return Mov_l(0x8,r3);
				case 0x02: return Mov_l(0xc,r3);
				case 0x03: return Mov_l(0x10,r3);
				case 0x04: return Mov_l(0x14,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r4);
				case 0x01: return Mov_l(0x8,r4);
				case 0x02: return Mov_l(0xc,r4);
				case 0x03: return Mov_l(0x10,r4);
				case 0x04: return Mov_l(0x14,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r5);
				case 0x01: return Mov_l(0x8,r5);
				case 0x02: return Mov_l(0xc,r5);
				case 0x03: return Mov_l(0x10,r5);
				case 0x04: return Mov_l(0x14,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r6);
				case 0x01: return Mov_l(0x8,r6);
				case 0x02: return Mov_l(0xc,r6);
				case 0x03: return Mov_l(0x10,r6);
				case 0x04: return Mov_l(0x14,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r7);
				case 0x01: return Mov_l(0x8,r7);
				case 0x02: return Mov_l(0xc,r7);
				case 0x03: return Mov_l(0x10,r7);
				case 0x04: return Mov_l(0x14,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r8);
				case 0x01: return Mov_l(0x8,r8);
				case 0x02: return Mov_l(0xc,r8);
				case 0x03: return Mov_l(0x10,r8);
				case 0x04: return Mov_l(0x14,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_d9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r9);
				case 0x01: return Mov_l(0x8,r9);
				case 0x02: return Mov_l(0xc,r9);
				case 0x03: return Mov_l(0x10,r9);
				case 0x04: return Mov_l(0x14,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_da(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r10);
				case 0x01: return Mov_l(0x8,r10);
				case 0x02: return Mov_l(0xc,r10);
				case 0x03: return Mov_l(0x10,r10);
				case 0x04: return Mov_l(0x14,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_db(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r11);
				case 0x01: return Mov_l(0x8,r11);
				case 0x02: return Mov_l(0xc,r11);
				case 0x03: return Mov_l(0x10,r11);
				case 0x04: return Mov_l(0x14,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_dc(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r12);
				case 0x01: return Mov_l(0x8,r12);
				case 0x02: return Mov_l(0xc,r12);
				case 0x03: return Mov_l(0x10,r12);
				case 0x04: return Mov_l(0x14,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_dd(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r13);
				case 0x01: return Mov_l(0x8,r13);
				case 0x02: return Mov_l(0xc,r13);
				case 0x03: return Mov_l(0x10,r13);
				case 0x04: return Mov_l(0x14,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_de(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r14);
				case 0x01: return Mov_l(0x8,r14);
				case 0x02: return Mov_l(0xc,r14);
				case 0x03: return Mov_l(0x10,r14);
				case 0x04: return Mov_l(0x14,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_df(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov_l(0x4,r15);
				case 0x01: return Mov_l(0x8,r15);
				case 0x02: return Mov_l(0xc,r15);
				case 0x03: return Mov_l(0x10,r15);
				case 0x04: return Mov_l(0x14,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r0);
				case 0x01: return Mov(h_1,r0);
				case 0x02: return Mov(h_2,r0);
				case 0x03: return Mov(h_3,r0);
				case 0x04: return Mov(h_4,r0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r1);
				case 0x01: return Mov(h_1,r1);
				case 0x02: return Mov(h_2,r1);
				case 0x03: return Mov(h_3,r1);
				case 0x04: return Mov(h_4,r1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r2);
				case 0x01: return Mov(h_1,r2);
				case 0x02: return Mov(h_2,r2);
				case 0x03: return Mov(h_3,r2);
				case 0x04: return Mov(h_4,r2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r3);
				case 0x01: return Mov(h_1,r3);
				case 0x02: return Mov(h_2,r3);
				case 0x03: return Mov(h_3,r3);
				case 0x04: return Mov(h_4,r3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r4);
				case 0x01: return Mov(h_1,r4);
				case 0x02: return Mov(h_2,r4);
				case 0x03: return Mov(h_3,r4);
				case 0x04: return Mov(h_4,r4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r5);
				case 0x01: return Mov(h_1,r5);
				case 0x02: return Mov(h_2,r5);
				case 0x03: return Mov(h_3,r5);
				case 0x04: return Mov(h_4,r5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r6);
				case 0x01: return Mov(h_1,r6);
				case 0x02: return Mov(h_2,r6);
				case 0x03: return Mov(h_3,r6);
				case 0x04: return Mov(h_4,r6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r7);
				case 0x01: return Mov(h_1,r7);
				case 0x02: return Mov(h_2,r7);
				case 0x03: return Mov(h_3,r7);
				case 0x04: return Mov(h_4,r7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r8);
				case 0x01: return Mov(h_1,r8);
				case 0x02: return Mov(h_2,r8);
				case 0x03: return Mov(h_3,r8);
				case 0x04: return Mov(h_4,r8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_e9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r9);
				case 0x01: return Mov(h_1,r9);
				case 0x02: return Mov(h_2,r9);
				case 0x03: return Mov(h_3,r9);
				case 0x04: return Mov(h_4,r9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ea(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r10);
				case 0x01: return Mov(h_1,r10);
				case 0x02: return Mov(h_2,r10);
				case 0x03: return Mov(h_3,r10);
				case 0x04: return Mov(h_4,r10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_eb(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r11);
				case 0x01: return Mov(h_1,r11);
				case 0x02: return Mov(h_2,r11);
				case 0x03: return Mov(h_3,r11);
				case 0x04: return Mov(h_4,r11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ec(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r12);
				case 0x01: return Mov(h_1,r12);
				case 0x02: return Mov(h_2,r12);
				case 0x03: return Mov(h_3,r12);
				case 0x04: return Mov(h_4,r12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ed(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r13);
				case 0x01: return Mov(h_1,r13);
				case 0x02: return Mov(h_2,r13);
				case 0x03: return Mov(h_3,r13);
				case 0x04: return Mov(h_4,r13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ee(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r14);
				case 0x01: return Mov(h_1,r14);
				case 0x02: return Mov(h_2,r14);
				case 0x03: return Mov(h_3,r14);
				case 0x04: return Mov(h_4,r14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ef(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Mov(h_0,r15);
				case 0x01: return Mov(h_1,r15);
				case 0x02: return Mov(h_2,r15);
				case 0x03: return Mov(h_3,r15);
				case 0x04: return Mov(h_4,r15);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f0(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr0);
				case 0x01: return Fsub(fr0,fr0);
				case 0x02: return Fmul(fr0,fr0);
				case 0x03: return Fdiv(fr0,fr0);
				case 0x04: return FcmpEq(fr0,fr0);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f1(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr1);
				case 0x01: return Fsub(fr0,fr1);
				case 0x02: return Fmul(fr0,fr1);
				case 0x03: return Fdiv(fr0,fr1);
				case 0x04: return FcmpEq(fr0,fr1);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f2(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr2);
				case 0x01: return Fsub(fr0,fr2);
				case 0x02: return Fmul(fr0,fr2);
				case 0x03: return Fdiv(fr0,fr2);
				case 0x04: return FcmpEq(fr0,fr2);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f3(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr3);
				case 0x01: return Fsub(fr0,fr3);
				case 0x02: return Fmul(fr0,fr3);
				case 0x03: return Fdiv(fr0,fr3);
				case 0x04: return FcmpEq(fr0,fr3);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f4(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr4);
				case 0x01: return Fsub(fr0,fr4);
				case 0x02: return Fmul(fr0,fr4);
				case 0x03: return Fdiv(fr0,fr4);
				case 0x04: return FcmpEq(fr0,fr4);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f5(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr5);
				case 0x01: return Fsub(fr0,fr5);
				case 0x02: return Fmul(fr0,fr5);
				case 0x03: return Fdiv(fr0,fr5);
				case 0x04: return FcmpEq(fr0,fr5);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f6(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr6);
				case 0x01: return Fsub(fr0,fr6);
				case 0x02: return Fmul(fr0,fr6);
				case 0x03: return Fdiv(fr0,fr6);
				case 0x04: return FcmpEq(fr0,fr6);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f7(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr7);
				case 0x01: return Fsub(fr0,fr7);
				case 0x02: return Fmul(fr0,fr7);
				case 0x03: return Fdiv(fr0,fr7);
				case 0x04: return FcmpEq(fr0,fr7);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f8(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr8);
				case 0x01: return Fsub(fr0,fr8);
				case 0x02: return Fmul(fr0,fr8);
				case 0x03: return Fdiv(fr0,fr8);
				case 0x04: return FcmpEq(fr0,fr8);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_f9(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr9);
				case 0x01: return Fsub(fr0,fr9);
				case 0x02: return Fmul(fr0,fr9);
				case 0x03: return Fdiv(fr0,fr9);
				case 0x04: return FcmpEq(fr0,fr9);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_fa(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr10);
				case 0x01: return Fsub(fr0,fr10);
				case 0x02: return Fmul(fr0,fr10);
				case 0x03: return Fdiv(fr0,fr10);
				case 0x04: return FcmpEq(fr0,fr10);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_fb(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr11);
				case 0x01: return Fsub(fr0,fr11);
				case 0x02: return Fmul(fr0,fr11);
				case 0x03: return Fdiv(fr0,fr11);
				case 0x04: return FcmpEq(fr0,fr11);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_fc(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr12);
				case 0x01: return Fsub(fr0,fr12);
				case 0x02: return Fmul(fr0,fr12);
				case 0x03: return Fdiv(fr0,fr12);
				case 0x04: return FcmpEq(fr0,fr12);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_fd(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr13);
				case 0x01: return Fsub(fr0,fr13);
				case 0x02: return Fmul(fr0,fr13);
				case 0x03: return Fdiv(fr0,fr13);
				case 0x04: return FcmpEq(fr0,fr13);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_fe(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr14);
				case 0x01: return Fsub(fr0,fr14);
				case 0x02: return Fmul(fr0,fr14);
				case 0x03: return Fdiv(fr0,fr14);
				case 0x04: return FcmpEq(fr0,fr14);
				default: throw new DecodeException(b0, b1);
			}
		}

		private static Instruction Decode_ff(IByteReader r, ref byte b0, ref byte b1)
		{
			switch (b1 = r.ReadOne())
			{
				case 0x00: return Fadd(fr0,fr15);
				case 0x01: return Fsub(fr0,fr15);
				case 0x02: return Fmul(fr0,fr15);
				case 0x03: return Fdiv(fr0,fr15);
				case 0x04: return FcmpEq(fr0,fr15);
				default: throw new DecodeException(b0, b1);
			}
		}
	}
}
