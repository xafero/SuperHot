using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Generator.Meta
{
    internal static class Comments
    {
        private static readonly Comment[] Data;

        static Comments()
        {
            Data = Load();
        }

        private static Comment[] Load()
        {
            var type = typeof(Comments);
            var dll = Path.GetFullPath(type.Assembly.Location);
            var dir = Path.GetDirectoryName(dll)!;
            var file = Path.Combine(dir, "Meta", "comments.json");
            var json = File.ReadAllText(file, Encoding.UTF8);
            return JsonTool.FromJson<Comment>(json);
        }

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        public static Comment? Find(string txt)
            => Data.FirstOrDefault(d =>
                txt.Equals(d.Item, Cmp) ||
                txt.Replace('.', '_').Equals(d.Item, Cmp) ||
                txt.Replace("/", "").Equals(d.Item, Cmp));
    }
}