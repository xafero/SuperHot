using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;

namespace Generator
{
    internal static class ExecDump
    {
        public static async Task Run(Options o)
        {
            if (FileTool.CreateOrGetDir(o.TempDir) is not { } tmpDir)
            {
                await Console.Error.WriteLineAsync("No temp dir given!");
                return;
            }

            byte[] bytes = [50, 30, 40];
            const string cpu = "sh3";

            using var aOut = new TempFile();
            var aName = aOut.FileName;
            await File.WriteAllBytesAsync(aName, bytes);

            const string cmd = "sh-elf-objdump";
            var dumpCmd = await Cli.Wrap(cmd)
                .WithArguments(["-D", "-b", "binary", "-m", cpu, "-z", aName])
                .WithWorkingDirectory(tmpDir)
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync();

            var error = dumpCmd.StandardError;
            if (!string.IsNullOrWhiteSpace(error) || dumpCmd.ExitCode != 0)
                throw new InvalidOperationException($"[{dumpCmd.ExitCode}] {error}");

            var output = dumpCmd.StandardOutput;
            var lines = output.Split(Environment.NewLine);
            var line = lines.Skip(7).Take(1).Single().Trim();
            line = line.Split(':', 2).Last().Trim();
            var parts = line.Split("  ", 2);
            var hex = parts[0].Trim();
            var txt = parts[1].Trim();
            parts = txt.Split('\t', 2);
            var mne = parts[0].Trim();
            var arg = parts[1].Trim();
            Console.WriteLine($"'{hex}' '{mne}' '{arg}'");
        }
    }
}