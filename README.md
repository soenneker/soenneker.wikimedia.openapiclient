[![](https://img.shields.io/nuget/v/soenneker.wikimedia.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.wikimedia.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.wikimedia.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.wikimedia.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.wikimedia.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.wikimedia.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.wikimedia.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.wikimedia.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Wikimedia.OpenApiClient

A Kiota client for reading page summaries, HTML, media, and other content exposed by Wikimedia's REST API.

## Installation

```bash
dotnet add package Soenneker.Wikimedia.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Wikimedia.OpenApiClient;
using Soenneker.Wikimedia.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
    "MyApp/1.0 (https://example.com/contact)");

var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient)
{
    BaseUrl = "https://en.wikipedia.org/api/rest_v1"
};

var client = new WikimediaOpenApiClient(adapter);

Summary? summary = await client.Page.Summary["Earth"].GetAsync();
Console.WriteLine(summary?.Extract);
```

Set `BaseUrl` to the REST endpoint for the Wikimedia project and language you need, such as `https://commons.wikimedia.org/api/rest_v1`. Use an authentication provider instead of `AnonymousAuthenticationProvider` when the endpoint requires credentials.

Wikimedia requires automated clients to send an identifying user agent with contact information; see its [User-Agent policy](https://foundation.wikimedia.org/wiki/Policy:Wikimedia_Foundation_User-Agent_Policy/en).
