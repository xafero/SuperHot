using CommandLine;

namespace Generator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var parser = Parser.Default;
            parser.ParseArguments<Options>(args).WithParsed(o =>
            {
                if (o.TryDecode)
                {
                    ExecDump.Run(o);
                }
            });
        }
    }
}