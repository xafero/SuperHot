using System;
using System.Threading.Tasks;
using System.IO;

namespace Generator
{
	internal static class CodeDump
	{
		public static async Task Run(Options o)
		{
			if (FileTool.CreateOrGetDir(o.OutputDir) is not { } outDir)
			{
				await Console.Error.WriteLineAsync("No output dir given!");
				return;
			}

			if (FileTool.CreateOrGetDir(o.InputDir) is not { } inpDir)
			{
				await Console.Error.WriteLineAsync("No input dir given!");
				return;
			}

			const SearchOption so = SearchOption.TopDirectoryOnly;
			var files = Directory.EnumerateFiles(inpDir, "*.json", so);


			






			/*
			foreach (var (cpu, lines) in ToDicts(tasks))
			{
				var val = lines.Values;
				var jdf = Path.Combine(outDir, $"dump_{cpu}.json");
				Console.WriteLine($"Writing '{jdf}' with {val.Count} values...");
				await FileTool.WriteFile(jdf, JsonTool.ToJson(val));
			}
			*/

			Console.WriteLine("Done.");
		}
	}
}