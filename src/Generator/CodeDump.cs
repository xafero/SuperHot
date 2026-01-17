using System;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using static Generator.FileTool;
using static Generator.JsonTool;
using System.Collections.Generic;

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

				if (!cpu.Equals("sh2e", StringComparison.InvariantCultureIgnoreCase))
					continue;

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
			await t.WriteLineAsync("using I = SuperHot.Instruct;");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"namespace {nsp}");
			await t.WriteLineAsync("{");
			await t.WriteLineAsync($"\tpublic sealed class {cln} : IDecoder");
			await t.WriteLineAsync("\t{");
			await t.WriteLineAsync("\t\tpublic Instruction Decode(IByteReader r)");
			await t.WriteLineAsync("\t\t{");
			await t.WriteLineAsync("\t\t\tbyte b0 = default;");
			await t.WriteLineAsync("\t\t\tbyte b1 = default;");
			await t.WriteLineAsync();

			const string err = "throw new DecodeException(b0, b1);";
			await t.WriteLineAsync("\t\t\tswitch (b0 = r.ReadOne())");
			await t.WriteLineAsync("\t\t\t{");

			var a = new StringWriter();
			foreach (var groups in lines.GroupBy(l => l.H.Split(" ", 2)[0]))
			{
				var fKey = groups.Key;
				var dm = $"Decode_{fKey}";
				await t.WriteLineAsync($"\t\t\t\tcase 0x{fKey}: return {dm}(r, ref b0, ref b1);");

				await a.WriteLineAsync();
				await a.WriteLineAsync($"\t\tprivate static Instruction {dm}(IByteReader r, ref byte b0, ref byte b1)");
				await a.WriteLineAsync("\t\t{");
				await a.WriteLineAsync("\t\t\tswitch (b1 = r.ReadOne())");
				await a.WriteLineAsync("\t\t\t{");
				foreach (var sub in groups)
				{
					var sKey = sub.H.Split(" ", 2)[1];
					await a.WriteAsync($"\t\t\t\tcase 0x{sKey}:");
					var mName = GetMethodName(sub.M);
					await a.WriteLineAsync($" return I.{mName}(); // {sub.A};");
				}
				await a.WriteLineAsync("\t\t\t}");
				await a.WriteLineAsync("\t\t}");
			}

			await t.WriteLineAsync("\t\t\t}");
			await t.WriteLineAsync("\t\t}");
			await t.WriteLineAsync(a.ToString().TrimEnd());
			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync("}");

			return t;
		}

		private static string GetMethodName(string name)
		{
			var txt = name.Trim('.').Replace('.', '_');
			txt = ToTitle(txt);
			var tmp = txt.Split('/');
			if (tmp.Length >= 2)
				txt = string.Join("", tmp.Select(ToTitle));
			return txt;
		}
	}
}