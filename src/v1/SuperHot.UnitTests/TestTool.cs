using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperHot.UnitTests
{
    internal static class TestTool
    {
        internal static async Task Compare(string t1, string t2)
        {
            var enc = Encoding.UTF8;
            var l1 = await File.ReadAllLinesAsync(t1, enc);
            var l2 = await File.ReadAllLinesAsync(t2, enc);

            foreach (var pair in l1.Zip(l2))
            {
                var first = pair.First.Replace('\t', ' ');
                var second = pair.Second.Replace('\t', ' ');
                var bin = $"({GetBinaryStr(first)}) ";
                Assert.Equal(bin + first, bin + second);
            }
        }

        private static string GetBinaryStr(string first)
        {
            var txt = first.Split(' ', 3).Take(2).ToArray();
            var num = ushort.Parse($"{txt[0]}{txt[1]}", NumberStyles.HexNumber);
            return $"{num:b16}";
        }
    }
}