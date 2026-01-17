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
			var text = new StringWriter();

			const string nsp = "SuperHot.Auto";
			var cln = $"{cpu}Decoder";

			await text.WriteLineAsync($"namespace {nsp}");
			await text.WriteLineAsync("{");
			await text.WriteLineAsync($"\tpublic sealed class {cln}");
			await text.WriteLineAsync("\t{");
			await text.WriteLineAsync("\t}");
			await text.WriteLineAsync("}");

			return text;
		}
	}
}