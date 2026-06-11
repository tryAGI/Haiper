<div class="docs-hero">
  <h1>Haiper</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Haiper generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/Haiper/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/Haiper"></a>
    <a href="https://github.com/tryAGI/Haiper/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Haiper/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Haiper/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Haiper"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://docs.haiper.ai/api-reference/openapi.json">Haiper's OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Haiper;

using var client = new HaiperClient(apiKey);
```

### CLI

```bash
dotnet tool install --global Haiper.CLI --prerelease
haiper api --help
```

<!-- EXAMPLES:START -->
### Text-to-video
Create a Haiper 2.x text-to-video generation and receive a generation id.

```csharp
using var client = new HaiperClient(apiKey);

var response = await client.CreateTextToVideoAsync(new TextToVideoRequest
{
    Prompt = "A sweeping drone shot over a futuristic seaside city at sunrise.",
    GenMode = TextToVideoRequestGenMode.Standard,
    Settings = new VideoSettings
    {
        AspectRatio = VideoSettingsAspectRatio.x16_9,
        Duration = 4,
    },
    IsPublic = false,
});
```

### Get creation status
Check the status of an existing Haiper creation.

```csharp
using var client = new HaiperClient(apiKey);

var creationId =
    Environment.GetEnvironmentVariable("HAIPER_CREATION_ID") is { Length: > 0 } value
        ? value
        : throw new AssertInconclusiveException("HAIPER_CREATION_ID environment variable is not found.");

var response = await client.GetCreationStatusAsync(creationId);
```
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Haiper/issues">tryAGI/Haiper</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Haiper/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
