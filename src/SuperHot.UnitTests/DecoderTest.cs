using System.Threading.Tasks;
using Generator;
using Xunit;
using static Generator.FileTool;
using static Generator.JsonTool;
using static SuperHot.UnitTests.ResTool;

namespace SuperHot.UnitTests
{
    public class DecoderTest
    {
        [Theory]
        [InlineData("sh")]
        [InlineData("sh2")]
        [InlineData("sh2a")]
        [InlineData("sh2e")]
        [InlineData("sh3")]
        [InlineData("sh3e")]
        [InlineData("sh4")]
        [InlineData("sh4a")]
        public async Task ShouldDecode(string cpu)
        {
            var l = FromJson<ParsedLine>(await ReadFile(Get<DecoderTest>(cpu)));
            Assert.Equal(65536, l.Length);
        }
    }
}