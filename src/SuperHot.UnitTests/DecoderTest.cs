using System;
using System.Threading.Tasks;
using Generator;
using Xunit;
using static Generator.FileTool;
using static Generator.JsonTool;
using static SuperHot.UnitTests.ResTool;

namespace SuperHot.UnitTests
{
	public class DecoderTest
	{
		[Theory]
		[InlineData(Dialect.Sh)]
		[InlineData(Dialect.Sh2)]
		[InlineData(Dialect.Sh2a)]
		[InlineData(Dialect.Sh2e)]
		[InlineData(Dialect.Sh3)]
		[InlineData(Dialect.Sh3e)]
		[InlineData(Dialect.Sh4)]
		[InlineData(Dialect.Sh4a)]
		public async Task ShouldDecode(Dialect dialect)
		{
			var cpu = dialect.ToString().ToLowerInvariant();
			var l = FromJson<ParsedLine>(await ReadFile(Get<DecoderTest>(cpu)));
			Assert.Equal(65536, l.Length);

			var decoder = Decoders.GetDecoder(dialect);
			foreach (var num in NumTool.Iter16Bit())
			{
				var reader = new ArrayReader(BitConverter.GetBytes((ushort)num));
				decoder.Decode(reader);
			}
		}
	}
}