using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
	internal static class FileTool
	{
		internal static string? CreateOrGetDir(string? dir)
		{
			if (string.IsNullOrWhiteSpace(dir))
				return null;
			var path = Path.GetFullPath(dir);
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
			return path;
		}

		internal static async Task WriteFile(string file, string text)
		{
			await File.WriteAllTextAsync(file, text, Encoding.UTF8);
		}

		internal static async Task<string> ReadFile(string file)
		{
			return await File.ReadAllTextAsync(file, Encoding.UTF8);
		}

		internal static string ToTitle(string? text)
		{
			if (string.IsNullOrWhiteSpace(text)) return string.Empty;
			return text[..1].ToUpper() + text[1..];
		}
	}
}