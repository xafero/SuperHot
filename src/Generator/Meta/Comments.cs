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
            const string file = "Meta/comments.json";
            var json = File.ReadAllText(file, Encoding.UTF8);
            return JsonTool.FromJson<Comment>(json);
        }

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        public static Comment? Find(string txt)
            => Data.FirstOrDefault(d => txt.Equals(d.Item, Cmp));
    }
}