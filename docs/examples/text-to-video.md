# Text-to-video

Create a Haiper 2.x text-to-video generation and receive a generation id.

This example assumes `using Haiper;` is in scope and `apiKey` contains your Haiper API key.

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