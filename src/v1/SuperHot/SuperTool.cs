using System;
using System.Linq;

namespace SuperHot
{
	internal static class SuperTool
	{
		internal static string ToHexString(this byte[] bytes)
		{
			return string.Join(" ", bytes.Select(ToHexString));
		}

		private static string ToHexString(byte b)
		{
			return $"{b:X2}";
		}
	}
}