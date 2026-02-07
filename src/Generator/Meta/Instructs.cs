using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Generator.Meta
{
    internal static class Instructs
    {
        internal static readonly Instruct[] Data;

        static Instructs()
        {
            Data = Load();
        }

        internal static Instruct? _word;

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
                Instruction = "dddddddddddddddd", States = "0", Group = "Fake",
                UsedIn = " sh sh2 sh2a sh2e sh3 sh3e sh4 sh4a ",
                Label = ".word", Description = "None"
            });
            return list.ToArray();
        }

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        internal static Instruct Find(string txt)
        {
            if (Data.FirstOrDefault(d =>
                {
                    var dd = d.Label ?? string.Empty;
                    return txt.Equals(dd, Cmp) ||
                           txt.Replace('.', '/').Equals(dd, Cmp);
                }) is { } f)
                return f;
            throw new InvalidOperationException(txt);
        }
    }
}