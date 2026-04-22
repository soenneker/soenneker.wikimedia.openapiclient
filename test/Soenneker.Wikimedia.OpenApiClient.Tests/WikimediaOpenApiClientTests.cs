using Soenneker.Tests.HostedUnit;

namespace Soenneker.Wikimedia.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WikimediaOpenApiClientTests : HostedUnitTest
{
    public WikimediaOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
