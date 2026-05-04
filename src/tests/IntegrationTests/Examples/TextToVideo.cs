/*
order: 10
title: Text-to-video
slug: text-to-video

Create a Haiper 2.x text-to-video generation and receive a generation id.
*/

namespace Haiper.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TextToVideo()
    {
        using var client = GetAuthenticatedClient();

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

        response.Value?.GenerationId.Should().NotBeNullOrWhiteSpace();
    }
}
