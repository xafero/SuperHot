using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperHot.UnitTests
{
    internal static class TestTool
    {
        public static async Task Compare(string t1, string t2)
        {
            var enc = Encoding.UTF8;
            var l1 = await File.ReadAllLinesAsync(t1, enc);
            var l2 = await File.ReadAllLinesAsync(t2, enc);

            foreach (var pair in l1.Zip(l2))
            {
                var first = pair.First.Replace('\t', ' ');
                var second = pair.Second.Replace('\t', ' ');
                Assert.Equal(first, second);
            }
        }
    }
}