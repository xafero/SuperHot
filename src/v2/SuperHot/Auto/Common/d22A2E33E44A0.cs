using System;
using SuperHot;
using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d22A2E33E44A0
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b0000:
					switch (n1)
					{
						default: j001:
							switch (n2)
							{
								case 0b0000:
									switch (n3)
									{
										case 0b0011:
											return I.Bsrf(n: R(n1));
									}
									goto j002;
								case 0b0010:
									switch (n3)
									{
										case 0b0011:
											return I.Braf(n: R(n1));
									}
									goto j002;
								default: j002:
									switch (n3)
									{
										case 0b0111:
											return I.Mul_l(m: R(n2), n: R(n1));
										case 0b1111:
											return I.Mac_l(m: at(p(R(n2))), n: at(p(R(n1))));
									}
									break;
							}
							break;
					}
					break;
				case 0b0011:
					switch (n1)
					{
						default: j003:
							switch (n2)
							{
								default: j004:
									switch (n3)
									{
										case 0b0101:
											return I.Dmulu_l(m: R(n2), n: R(n1));
										case 0b1101:
											return I.Dmuls_l(m: R(n2), n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b0100:
					switch (n1)
					{
						default: j005:
							switch (n2)
							{
								case 0b0001:
									switch (n3)
									{
										case 0b0000:
											return I.Dt(n: R(n1));
									}
									break;
							}
							break;
					}
					break;
				case 0b1000:
					switch (n1)
					{
						case 0b1101:
							switch (n2)
							{
								default: j006:
									switch (n3)
									{
										default: j007:
											return I.Bt_s(d: (n2 << 4) | n3);
									}
									break;
							}
							break;
						case 0b1111:
							switch (n2)
							{
								default: j008:
									switch (n3)
									{
										default: j009:
											return I.Bf_s(d: (n2 << 4) | n3);
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
