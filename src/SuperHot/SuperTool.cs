using System;
using System.Linq;

namespace SuperHot
{
	public static class SuperTool
	{
		public static string ToHexString(this byte[] bytes)
		{
			return string.Join(" ", bytes.Select(ToHexString));
		}

		private static string ToHexString(byte b)
		{
			return $"{b:X2}";
		}

		public static string Format(ushort val)
		{
			return $"0x{val:x4}";
		}

		public static string GetName(Opcode code)
		{
			switch (code)
			{
				case Opcode.Word: return ".word";
				default: throw new InvalidOperationException($"{code} ?!");
			}
		}
	}
}