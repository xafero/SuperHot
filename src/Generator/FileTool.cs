using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    internal static class FileTool
    {
        public static string? CreateOrGetDir(string? dir)
        {
            if (string.IsNullOrWhiteSpace(dir))
                return null;
            var path = Path.GetFullPath(dir);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }

        public static async Task WriteFile(string file, string text)
        {
            await File.WriteAllTextAsync(file, text, Encoding.UTF8);
        }
    }
}