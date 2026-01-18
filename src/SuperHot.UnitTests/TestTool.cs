using System.IO;
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
            Assert.Equal(l1, l2);
        }
    }
}