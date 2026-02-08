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
	internal static class d2A33E44A0000
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
								case 0b1000:
									switch (n3)
									{
										case 0b0011:
											return I.Pref(n: at(R(n1)));
									}
									break;
							}
							break;
					}
					break;
				case 0b0100:
					switch (n1)
					{
						default: j002:
							switch (n2)
							{
								default: j003:
									switch (n3)
									{
										case 0b1100:
											return I.Shad(m: R(n2), n: R(n1));
										case 0b1101:
											return I.Shld(m: R(n2), n: R(n1));
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
