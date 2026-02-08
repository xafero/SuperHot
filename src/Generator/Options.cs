using CommandLine;

// ReSharper disable ClassNeverInstantiated.Global

namespace Generator
{
	public class Options
	{
		[Option('f', "find", HelpText = "Find binary codes.")]
		public bool TryDecode { get; set; }

		[Option('g', "code", HelpText = "Create C# decoder.")]
		public bool TryCoder { get; set; }

		[Option('k', "kode", HelpText = "Create C# dekoder.")]
		public bool TryKoder { get; set; }

		[Option('m', "misc", HelpText = "Set misc parameters.")]
		public string? Misc { get; set; }

		[Option('i', "input", HelpText = "Set input directory.")]
		public string? InputDir { get; set; }

		[Option('o', "output", HelpText = "Set output directory.")]
		public string? OutputDir { get; set; }
	}
}