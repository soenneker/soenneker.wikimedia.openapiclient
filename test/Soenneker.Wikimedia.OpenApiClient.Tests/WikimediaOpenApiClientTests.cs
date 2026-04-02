using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Wikimedia.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WikimediaOpenApiClientTests : FixturedUnitTest
{
    public WikimediaOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
