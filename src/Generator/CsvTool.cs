using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace Generator
{
    internal static class CsvTool
    {
        public static T[] FromCsv<T>(string file)
        {
            var enc = Encoding.UTF8;
            var cult = CultureInfo.InvariantCulture;
            using var reader = new StreamReader(file, enc);
            using var csv = new CsvReader(reader, cult);
            return csv.GetRecords<T>().ToArray();
        }
    }
}