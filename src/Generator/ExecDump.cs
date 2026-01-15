using System;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;

namespace Generator
{
    internal static class ExecDump
    {
        public static async Task Run(Options options)
        {
            var dumpCmd = await Cli.Wrap("sh-elf-objdump")
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync();

            Console.WriteLine("'" + dumpCmd.StandardOutput + "'");
            Console.WriteLine("'" + dumpCmd.StandardError + "'");

            Console.WriteLine(dumpCmd.ExitCode + " " + dumpCmd.ExitTime + " "
                              + dumpCmd.IsSuccess + " " + dumpCmd.RunTime + " " + dumpCmd.StartTime);
        }
    }
}