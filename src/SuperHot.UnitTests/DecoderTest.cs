using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

			var src = l.Select(i => $"{i.H}\t{i.M}\t{i.A}").ToArray();
			var got = new List<string>();

			var decoder = Decoders.GetDecoder(dialect);
			foreach (var num in NumTool.Iter16Bit())
			{
				var reader = new ArrayReader(BitConverter.GetBytes((ushort)num));
				string? text;
				try
				{
					Instruction instr = decoder.Decode(reader);
					text = instr.ToString();
				}
				catch (Exception e)
				{
					text = e.Message;
				}
				got.Add(text!);
			}

			var t1F = $"{cpu}_orig.txt";
			await File.WriteAllLinesAsync(t1F, src, Encoding.UTF8);

			var t2F = $"{cpu}_mine.txt";
			await File.WriteAllLinesAsync(t2F, got, Encoding.UTF8);

			await TestTool.Compare(t1F, t2F);
		}
	}
}