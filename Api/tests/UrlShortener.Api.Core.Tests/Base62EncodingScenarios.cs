using System.Text;

namespace UrlShortener.Api.Core.Tests;

public class Base62EncodingScenarios
{
    [Theory]
    [InlineData(0,"0")]
    [InlineData(1,"1")]
    [InlineData(20,"k")]
    [InlineData(62,"10")]
    public void Should_encode_number_to_base62(long number,string expected)
    {
        number.EncodeToBase62()
            .Should()
            .Be(expected);
    }
}