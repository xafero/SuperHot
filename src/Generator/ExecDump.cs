using System;
using System.IO;
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

            const string cpu = "sh3";
            const string cmd = "sh-elf-objdump";

            using var aOut = new TempFile();
            var aName = aOut.FileName;
            await File.WriteAllBytesAsync(aName, [50, 30, 40]);

            var dumpCmd = await Cli.Wrap(cmd)
                .WithArguments(["-D", "-b", "binary", "-m", cpu, "-z", aName])
                .WithWorkingDirectory(tmpDir)
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync();

            var error = dumpCmd.StandardError;
            if (!string.IsNullOrWhiteSpace(error))
                throw new InvalidOperationException(error);

            var output = dumpCmd.StandardOutput;
            Console.WriteLine($"'{output}' ({dumpCmd.ExitCode})");
        }
    }
}