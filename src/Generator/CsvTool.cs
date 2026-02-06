using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Generator
{
    internal static class CsvTool
    {
        private static readonly CultureInfo Cult = CultureInfo.InvariantCulture;

        public static T[] ReadCsv<T>(string file)
        {
            using var reader = File.OpenText(file);
            using var csv = new CsvReader(reader, Cult);
            var records = csv.GetRecords<T>();
            return records.ToArray();
        }

        public static void WriteCsv<T>(T[] records, string file)
        {
            using var writer = File.CreateText(file);
            using var csv = new CsvWriter(writer, Cult);
            csv.WriteRecords(records);
            csv.Flush();
        }
    }
}