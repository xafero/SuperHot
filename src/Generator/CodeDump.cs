using System;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using static Generator.FileTool;
using static Generator.JsonTool;

namespace Generator
{
	internal static class CodeDump
	{
		public static async Task Run(Options o)
		{
			if (CreateOrGetDir(o.OutputDir) is not { } outDir)
			{
				await Console.Error.WriteLineAsync("No output dir given!");
				return;
			}

			if (CreateOrGetDir(o.InputDir) is not { } inpDir)
			{
				await Console.Error.WriteLineAsync("No input dir given!");
				return;
			}

			const SearchOption so = SearchOption.TopDirectoryOnly;
			var files = Directory.EnumerateFiles(inpDir, "*.json", so);

			foreach (var file in files)
			{
				var cpu = ToTitle(Path.GetFileNameWithoutExtension(file));
				var lines = FromJson<ParsedLine>(await ReadFile(file));

				lines = lines.Take(5).ToArray();

				var jdf = Path.Combine(outDir, $"{cpu}Decoder.cs");
				var text = await GenerateCode(cpu, lines);

				Console.WriteLine($"Writing '{jdf}' with {lines.Length} values...");
				await WriteFile(jdf, text.ToString());
			}

			Console.WriteLine("Done.");
		}

		private static async Task<StringWriter> GenerateCode(string cpu, ParsedLine[] lines)
		{
			var t = new StringWriter();

			const string nsp = "SuperHot.Auto";
			var cln = $"{cpu}Decoder";

			await t.WriteLineAsync("using System;");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"namespace {nsp}");
			await t.WriteLineAsync("{");
			await t.WriteLineAsync($"\tpublic sealed class {cln} : IDecoder");
			await t.WriteLineAsync("\t{");
			await t.WriteLineAsync("\t\tpublic void Decode(IByteReader reader)");
			await t.WriteLineAsync("\t\t{");
			await t.WriteLineAsync("\t\t\tvar b0 = reader.ReadOne();");
			await t.WriteLineAsync("\t\t\tvar b1 = reader.ReadOne();");
			await t.WriteLineAsync();

			const string err = "throw new DecodeException(b0, b);";
			await t.WriteLineAsync("\t\t\tswitch (b0)");
			await t.WriteLineAsync("\t\t\t{");

			// 	case 0x00:
			// 		switch (second)
			// 		{
			// 			default: 
			// 				throw new InvalidOperationException("Not decoded!");
			// 		}

			await t.WriteLineAsync("\t\t\t\tdefault:");
			await t.WriteLineAsync($"\t\t\t\t\t{err}");
			await t.WriteLineAsync("\t\t\t}");
			await t.WriteLineAsync("\t\t}");
			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync("}");

			return t;
		}
	}
}