using CommandLine;

// ReSharper disable ClassNeverInstantiated.Global

namespace Generator
{
    public class Options
    {
        [Option('f', "find", HelpText = "Find binary codes.")]
        public bool TryDecode { get; set; }

        [Option('t', "temp", HelpText = "Set temp directory.")]
        public string? TempDir { get; set; }
    }
}