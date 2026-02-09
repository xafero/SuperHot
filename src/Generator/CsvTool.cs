using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Generator
{
    internal static class CsvTool
    {
        private static readonly CultureInfo Cult = CultureInfo.InvariantCulture;

        internal static T[] ReadCsv<T>(string file)
        {
            using var reader = File.OpenText(file);
            using var csv = new CsvReader(reader, Cult);
            var records = csv.GetRecords<T>();
            return records.ToArray();
        }
    }
}