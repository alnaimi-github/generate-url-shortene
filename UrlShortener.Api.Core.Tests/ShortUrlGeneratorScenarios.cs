namespace UrlShortener.Api.Core.Tests;

public class ShortUrlGeneratorScenarios
{
    [Fact]
    public void Should_return_short_url_for_10001()
    {
        var tokenProvider = new TokenProvider();
        tokenProvider.AssignRange(10001, 20000);
        var shortUrlGenerator = new ShortUrlGenerator(tokenProvider);

        var shortUrl = shortUrlGenerator.GenerateUniqueUrl();
        
        shortUrl.Should().Be("2bJ");
    }
    [Fact]
    public void Should_return_short_url_for_zero()
    { 
        var tokenProvider = new TokenProvider();
        tokenProvider.AssignRange(0, 10);
        var shortUrlGenerator = new ShortUrlGenerator(tokenProvider);
        var shortUrl = shortUrlGenerator.GenerateShortUrl();
        shortUrl.Should().Be("0");
    }
}

public class TokenProvider
{
    public void AssignRange(int i, int i1)
    {
        throw new NotImplementedException();
    }
}

public class ShortUrlGenerator
{
    public ShortUrlGenerator(TokenProvider tokenProvider)
    {
        
    }
   
    public object GenerateShortUrl()
    {
        return "0";
    }

    public object GenerateUniqueUrl()
    {
        throw new NotImplementedException();
    }
}