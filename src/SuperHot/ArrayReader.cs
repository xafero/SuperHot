namespace SuperHot
{
	public sealed class ArrayReader : IByteReader
	{
		private readonly byte[] _bytes;
		private int _index;

		public ArrayReader(byte[] bytes)
		{
			_bytes = bytes;
			_index = 0;
		}

		public byte ReadOne()
		{
			return _bytes[_index++];
		}

		public override string ToString()
		{
			return _bytes.ToHexString();
		}
	}
}