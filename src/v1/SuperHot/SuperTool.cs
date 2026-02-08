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

		public static string Format(object? val)
		{
			if (val == null) return string.Empty;
			if (val is ushort us) return Format(us);
			throw new InvalidOperationException($"{val} ?!");
		}

		public static string Format(ushort val)
		{
			return $"0x{val:x4}";
		}
	}
}