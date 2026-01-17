using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;

namespace Generator
{
    internal static class ExecDump
    {
        private static readonly string Nl = Environment.NewLine;

        public static async Task Run(Options o)
        {
            if (FileTool.CreateOrGetDir(o.TempDir) is not { } tmpDir)
            {
                await Console.Error.WriteLineAsync("No temp dir given!");
                return;
            }

            var numbers = Enumerable.Range(ushort.MinValue, ushort.MaxValue + 1).ToArray();
            const int chunkSize = 200;
            var cpuS = (o.Misc ?? "").Split(';');

            var tasks = new List<Task<ParsedCpu>>();
            foreach (var chunk in numbers.Chunk(chunkSize))
            {
                var bits = chunk.Select(c => BitConverter.GetBytes((ushort)c)).ToArray();
                foreach (var cpu in cpuS)
                    tasks.Add(RunOnce(tmpDir, bits, cpu));
            }
            await Task.WhenAll(tasks);

            foreach (var (cpu, lines) in ToDicts(tasks))
            {
                var val = lines.Values;
                var jdf = Path.Combine(tmpDir, $"dump_{cpu}.json");
                Console.WriteLine($"Writing '{jdf}' with {val.Count} values...");
                await FileTool.WriteFile(jdf, JsonTool.ToJson(val));
            }

            Console.WriteLine("Done.");
        }

        private static Dictionary<string, IDictionary<string, ParsedLine>> ToDicts(List<Task<ParsedCpu>> tasks)
        {
            var res = new Dictionary<string, IDictionary<string, ParsedLine>>();
            foreach (var task in tasks)
            {
                var (cpu, lines) = task.Result;
                if (!res.TryGetValue(cpu, out var dict))
                    res[cpu] = dict = new SortedDictionary<string, ParsedLine>();
                foreach (var it in lines)
                    dict.Add(it.H, it);
            }
            return res;
        }

        private static TempFile CreateTf(byte[] bytes)
        {
            var t = new TempFile();
            File.WriteAllBytes(t.FileName, bytes);
            return t;
        }

        private static async Task<ParsedCpu> RunOnce(string tmpDir, byte[][] dBytes, string cpu)
        {
            var aOut = dBytes.Select(CreateTf).ToArray();

            List<string> dArgs = ["-D", "-b", "binary", "-m", cpu, "-z"];
            dArgs.AddRange(aOut.Select(a => a.FileName));

            const string cmd = "sh-elf-objdump";
            var dumpCmd = await Cli.Wrap(cmd)
                .WithArguments(dArgs)
                .WithWorkingDirectory(tmpDir)
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync();

            var error = dumpCmd.StandardError;
            if (!string.IsNullOrWhiteSpace(error) || dumpCmd.ExitCode != 0)
                throw new InvalidOperationException($"[{dumpCmd.ExitCode}] {error}");

            Array.ForEach(aOut, a => a.Dispose());

            var output = dumpCmd.StandardOutput;
            var lines = output.Split(Nl).Where(l => l.StartsWith("   0:"));
            var parsed = lines.Select(ParseLine).ToArray();

            return new(cpu, parsed);
        }

        private static ParsedLine ParseLine(string one)
        {
            try
            {
                var line = one.Trim();
                line = line.Split(':', 2).Last().Trim();
                var parts = line.Split("  ", 2);
                var hex = parts[0].Trim();
                var txt = parts[1].Trim();
                parts = txt.Split('\t', 2);
                if (parts.Length != 2 && txt.StartsWith('.'))
                    parts = txt.Split(' ', 2);
                var mne = parts[0].Trim();
                var arg = parts.Length == 2 ? parts[1].Trim() : string.Empty;
                return new ParsedLine(hex, mne, arg);
            }
            catch (Exception e)
            {
                Console.Error.WriteLineAsync(e + Nl + one);
                throw;
            }
        }
    }
}