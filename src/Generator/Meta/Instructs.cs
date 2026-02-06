using System;
using System.Collections.Generic;
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

        private static Instruct? _word;

        private static Instruct[] Load()
        {
            var type = typeof(Instructs);
            var dll = Path.GetFullPath(type.Assembly.Location);
            var dir = Path.GetDirectoryName(dll)!;
            var file = Path.Combine(dir, "Meta", "instructs.csv");
            var list = new List<Instruct>(CsvTool.ReadCsv<Instruct>(file));
            list.Add(_word = new Instruct
            {
                TBit = "_", Summary = "Some random data", Format = ".WORD d",
                Instruction = "dddddddddddddddd", States = "0"
            });
            return list.ToArray();
        }

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        public static Instruct Find(string key)
        {
            if (Data.FirstOrDefault(x => key.Equals(x.Label, Cmp)) is { } f)
                return f;
            throw new InvalidOperationException(key);
        }
    }
}