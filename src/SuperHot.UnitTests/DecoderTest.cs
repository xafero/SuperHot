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
        public void ShouldDecode(string cpu)
        {
            var file = ResTool.Get<DecoderTest>(cpu);
        }
    }
}