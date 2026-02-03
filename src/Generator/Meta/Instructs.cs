using System;
using System.IO;
using System.Linq;

namespace Generator.Meta
{
    internal static class Instructs
    {
        private static readonly Instruct[] Data;

        static Instructs()
        {
            Data = Load();
        }

        private static Instruct[] Load()
        {
            var type = typeof(Instructs);
            var dll = Path.GetFullPath(type.Assembly.Location);
            var dir = Path.GetDirectoryName(dll)!;
            var file = Path.Combine(dir, "Meta", "instructs.csv");
            return CsvTool.FromCsv<Instruct>(file);
        }

        private static string? Lbl(Instruct instruct)
        {
            var txt = instruct.Format?.Split(' ').FirstOrDefault();
            return txt;
        }

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        public static Instruct? Find(string txt)
            => Data.FirstOrDefault(d => txt.Equals(Lbl(d), Cmp));
    }
}