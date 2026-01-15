using System.IO;

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
    }
}