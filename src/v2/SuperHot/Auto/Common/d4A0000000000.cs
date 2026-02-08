using static SuperHot.InstructV;
using static SuperHot.Register;
using I = SuperHot.InstructH;

#pragma warning disable CS0164
#pragma warning disable CS0162
// ReSharper disable RedundantAssignment
// ReSharper disable InconsistentNaming

namespace SuperHot.Auto.Common
{
	internal static class d4A0000000000
	{
		internal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)
		{
			switch (n0)
			{
				case 0b0000:
					switch (n1)
					{
						case 0b0000:
							switch (n2)
							{
								case 0b1010:
									switch (n3)
									{
										case 0b1011:
											return I.Synco();
									}
									break;
							}
							goto j001;
						default: j001:
							switch (n2)
							{
								case 0b0110:
									switch (n3)
									{
										case 0b0011:
											return I.Movli_l(m: at(R(n1)), r0);
									}
									break;
								case 0b0111:
									switch (n3)
									{
										case 0b0011:
											return I.Movco_l(r0, n: at(R(n1)));
									}
									break;
								case 0b1101:
									switch (n3)
									{
										case 0b0011:
											return I.Prefi(n: at(R(n1)));
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b0011:
											return I.Icbi(n: at(R(n1)));
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
								case 0b1010:
									switch (n3)
									{
										case 0b1001:
											return I.Movua_l(m: at(R(n1)), r0);
									}
									break;
								case 0b1110:
									switch (n3)
									{
										case 0b1001:
											return I.Movua_l(m: at(p(R(n1))), r0);
									}
									break;
							}
							break;
					}
					break;
				case 0b1111:
					switch (n1)
					{
						case 0b0111:
							switch (n2)
							{
								case 0b1111:
									switch (n3)
									{
										case 0b1101:
											return I.Fpchg();
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
