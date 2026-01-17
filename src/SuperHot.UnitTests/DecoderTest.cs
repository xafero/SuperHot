using System.Threading.Tasks;
using Generator;
using Xunit;

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
            var file = ResTool.Get<DecoderTest>(cpu);
            var json = await FileTool.ReadFile(file);
            var list = JsonTool.FromJson<ParsedLine>(json);
            Assert.Equal(65536, list.Length);
        }
    }
}