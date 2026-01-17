using System;

namespace SuperHot
{
	public sealed class DecodeException : Exception
	{
		public DecodeException(byte b0, byte b1)
			: base($"[{b0:X2} {b1:X2}] not decoded!")
		{
		}
	}
}