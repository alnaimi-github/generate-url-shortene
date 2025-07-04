﻿using UrlShortener.Core.Urls;
using UrlShortener.Core.Urls.Add;

namespace UrlShortener.Api.Core.Tests.TestDoubles;

public class InMemoryUrlDataStore :Dictionary<string,ShortenedUrl> ,IUrlDataStore
{
    public async Task AddAsync(ShortenedUrl shortened, CancellationToken cancellationToken)
    {
        Add(shortened.ShortUrl,shortened);
        await Task.CompletedTask;
    }
}