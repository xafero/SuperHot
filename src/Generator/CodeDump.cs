using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static Generator.FileTool;
using static Generator.JsonTool;
using E = System.Linq.Enumerable;

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
			
			var allMeth = new Dictionary<string, string>();
			var allMeta = new SortedDictionary<string, OpMetaTmp>();
			StringWriter text;

			foreach (var file in files.OrderBy(f => f))
			{
				var cpu = ToTitle(Path.GetFileNameWithoutExtension(file));
				var lines = FromJson<ParsedLine>(await ReadFile(file));
				Collect(lines, allMeta, cpu);

				var jdf = Path.Combine(outDir, $"{cpu}Decoder.cs");
				text = await GenerateCode(lines, allMeth, cpu);

				Console.WriteLine($"Writing '{jdf}' with {lines.Length} values...");
				await WriteFile(jdf, text.ToString());
			}

			var edf = Path.Combine(outDir, "Opcode.cs");
			text = await GenerateEnum(allMeta);

			Console.WriteLine($"Writing '{edf}' with {allMeta.Count} values...");
			await WriteFile(edf, text.ToString());

			var idf = Path.Combine(outDir, "Instruct.cs");
			text = await GenerateInst(allMeta);
			
			Console.WriteLine($"Writing '{idf}' with {allMeta.Count} values...");
			await WriteFile(idf, text.ToString());

			Console.WriteLine("Done.");
		}

		private static void Collect(ParsedLine[] lines, IDictionary<string, OpMetaTmp> dict, string cpu)
		{
			foreach (var line in lines)
			{
				var txt = GetMethodName(line.M);
				var arg = GetMethodArgs(line.A);
				var aCnt = GetArgCount(arg);
				if (!dict.TryGetValue(txt, out var meta))
					dict[txt] = meta = new();
				meta.Dialects.Add(cpu);
				meta.Counts.Add(aCnt);
				meta.Args.Add(line.A);
				meta.Names.Add(line.M);
			}
		}

		private static int GetArgCount(string txt)
		{
			if (string.IsNullOrWhiteSpace(txt)) return 0;
			var tmp = txt.Split(',');
			var count = 0;
			foreach (var one in tmp)
			{
				if (one.Contains('(') && !one.Contains(')'))
					continue;
				count++;
			}
			return count;
		}

		private static async Task<StringWriter> GenerateInst(IDictionary<string, OpMetaTmp> meta)
		{
			var t = new StringWriter();

			const string nsp = "SuperHot.Auto";
			const string cln = "Instruct";

			await t.WriteLineAsync("using SuperHot.Args;");
			await t.WriteLineAsync("using O = SuperHot.Auto.Opcode;");
			await t.WriteLineAsync("using I = SuperHot.Instruction;");
			await t.WriteLineAsync("using A = SuperHot.Args.Arg;");
			await t.WriteLineAsync();
			await t.WriteLineAsync("// ReSharper disable InconsistentNaming");
			await t.WriteLineAsync("// ReSharper disable IdentifierTypo");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"namespace {nsp}");
			await t.WriteLineAsync("{");
			await t.WriteLineAsync($"\tinternal static class {cln}");
			await t.WriteAsync("\t{");

			foreach (var (key, val) in meta)
			{
				var argCount = val.Counts.Single();
				var args = string.Join(", ", E.Range(1, argCount).Select(x => $"A a{x}"));
				var prm = string.Join(", ", E.Range(1, argCount).Select(x => $"a{x}"));
				var call = $"O.{key}, {prm}".Trim(',', ' ').Trim();
				await t.WriteLineAsync();
				await t.WriteLineAsync($"\t\tinternal static I {key}({args})");
				await t.WriteLineAsync("\t\t{");
				await t.WriteLineAsync($"\t\t\treturn new I({call});");
				await t.WriteLineAsync("\t\t}");
			}

			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync("}");

			return t;
		}

		private static async Task<StringWriter> GenerateEnum(IDictionary<string, OpMetaTmp> meta)
		{
			var t = new StringWriter();

			const string nsp = "SuperHot.Auto";
			const string cln = "Opcode";

			await t.WriteLineAsync("using System.Collections.Generic;");
			await t.WriteLineAsync("using D = SuperHot.Dialect;");
			await t.WriteLineAsync("using O = SuperHot.OpMeta;");
			await t.WriteLineAsync();
			await t.WriteLineAsync("// ReSharper disable InconsistentNaming");
			await t.WriteLineAsync("// ReSharper disable IdentifierTypo");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"namespace {nsp}");
			await t.WriteLineAsync("{");
			await t.WriteLineAsync($"\tpublic enum {cln}");
			await t.WriteLineAsync("\t{");
			await t.WriteLineAsync("\t\tNone = 0,");

			var last = meta.Keys.Last();
			foreach (var (key, val) in meta)
			{
				var end = last == key ? "" : ",";
				var argCount = val.Counts.Single();
				var dia = string.Join(",", val.Dialects.Select(d => $"D.{d}"));
				var min = val.Args.MinBy(a => a.Length) ?? string.Empty;
				var max = val.Args.MaxBy(a => a.Length) ?? string.Empty;
				await t.WriteLineAsync();
				var suf = max.Length >= 1 ? $", {argCount}, \"{min}\", \"{max}\"" : null;
				await t.WriteLineAsync($"\t\t[O([{dia}]{suf})]");
				await t.WriteLineAsync($"\t\t{key}{end}");
			}

			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync();

			await t.WriteLineAsync($"\tpublic static class {cln}Ext");
			await t.WriteLineAsync("\t{");
			await t.WriteLineAsync("\t\tpublic static string ToName(this Opcode code) => _names[code];");
			await t.WriteLineAsync();
			await t.WriteLineAsync("\t\tprivate static readonly Dictionary<Opcode, string> _names = new()");
			await t.WriteLineAsync("\t\t{");
			foreach (var (key, val) in meta)
			{
				var end = last == key ? "" : ",";
				var oName = val.Names.Single();
				await t.WriteLineAsync($"\t\t\t{{ Opcode.{key}, \"{oName}\" }}{end}");
			}
			await t.WriteLineAsync("\t\t};");
			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync("}");

			return t;
		}

		private static async Task<StringWriter> GenerateCode(ParsedLine[] lines,
			Dictionary<string, string> allMeth, string cpu)
		{
			var t = new StringWriter();

			const string nsp = "SuperHot.Auto";
			var cln = $"{cpu}Decoder";

			await t.WriteLineAsync("using static SuperHot.InstructV;");
			await t.WriteLineAsync("using static SuperHot.Auto.Instruct;");
			await t.WriteLineAsync("using static SuperHot.Register;");
			await t.WriteLineAsync();
			await t.WriteLineAsync("// ReSharper disable RedundantAssignment");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"namespace {nsp}");
			await t.WriteLineAsync("{");
			await t.WriteLineAsync($"\tpublic sealed class {cln} : IDecoder");
			await t.WriteLineAsync("\t{");
			await t.WriteLineAsync("\t\tpublic Instruction? Decode(IByteReader r, bool fail)");
			await t.WriteLineAsync("\t\t{");
			await t.WriteLineAsync("\t\t\tbyte b0 = 0;");
			await t.WriteLineAsync("\t\t\tbyte b1 = 0;");
			await t.WriteLineAsync();

			const string err = "throw new DecodeException(b0, b1)";
			await t.WriteLineAsync("\t\t\tvar i = (b0 = r.ReadOne()) switch");
			await t.WriteLineAsync("\t\t\t{");

			var grouped = lines.GroupBy(l => l.H.Split(" ", 2)[0]);
			var aa = new List<string>();
			foreach (var groups in grouped)
			{
				var fKey = groups.Key;
				var dm = $"Decode_{fKey}";

				var a = new StringWriter();
				await a.WriteLineAsync();
				await a.WriteLineAsync($"\t\tinternal static Instruction? {dm}(IByteReader r, ref byte b0, ref byte b1)");
				await a.WriteLineAsync("\t\t{");
				await a.WriteLineAsync("\t\t\treturn (b1 = r.ReadOne()) switch");
				await a.WriteLineAsync("\t\t\t{");
				foreach (var sub in groups)
				{
					var sKey = sub.H.Split(" ", 2)[1];
					await a.WriteAsync($"\t\t\t\t0x{sKey} =>");
					var mName = GetMethodName(sub.M);
					var mArg = GetMethodArgs(sub.A);
					await a.WriteLineAsync($" {mName}({mArg}),");
				}
				await a.WriteLineAsync("\t\t\t};");
				await a.WriteLineAsync("\t\t}");
				var mfKey = $"{cln}.{dm}";
				var mfBody = a.ToString();
				if (allMeth.TryGetValue(mfBody, out var existingMk))
					dm = existingMk;
				else
				{
					allMeth[mfBody] = mfKey;
					aa.Add(mfBody);
				}
				await t.WriteLineAsync($"\t\t\t\t0x{fKey} => {dm}(r, ref b0, ref b1),");
			}

			await t.WriteLineAsync("\t\t\t};");
			await t.WriteLineAsync();
			await t.WriteLineAsync($"\t\t\treturn fail ? {err} : i;");
			await t.WriteLineAsync("\t\t}");
			foreach (var a in aa)
				await t.WriteLineAsync(a.TrimEnd());
			await t.WriteLineAsync("\t}");
			await t.WriteLineAsync("}");

			return t;
		}

		private static string GetMethodArgs(string txt)
		{
			var mArg = txt.Trim();

			mArg = mArg.Replace("@@(", "atb(");
			mArg = Regex.Replace(mArg, @"@r(\d+)\+", "at(p(r$1))");
			mArg = Regex.Replace(mArg, @"@-r(\d+)", "at(m(r$1))");
			mArg = Regex.Replace(mArg, @"@r(\d+)", "at(r$1)");
			mArg = Regex.Replace(mArg, @"#-(\d+)", "h(-$1)");
			mArg = Regex.Replace(mArg, @"#(\d+)", "h($1)");
			mArg = mArg.Replace("@(", "at(");

			return mArg.Trim();
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