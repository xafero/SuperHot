using System;
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

            var dumpCmd = await Cli.Wrap("sh-elf-objdump")
                .WithArguments(["--geko"])
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