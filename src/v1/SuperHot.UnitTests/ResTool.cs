using System.IO;

namespace SuperHot.UnitTests
{
    internal static class ResTool
    {
        public static string Get<T>(string name)
        {
            var type = typeof(T).Assembly.Location;
            var dir = Path.GetDirectoryName(type)!;
            var fld = Path.Combine(dir, "Resources");
            var tgt = Path.Combine(fld, $"{name}.json");
            return tgt;
        }
    }
}