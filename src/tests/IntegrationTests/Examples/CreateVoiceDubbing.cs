/*
 * order: 80
 * title: Voice Dubbing
 * slug: voice-dubbing
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Dub audio content to a target language with automatic voice cloning.
    //// Supports multi-speaker detection and optional background audio removal.

    [TestMethod]
    [Ignore("Requires paid API credits and audio input")]
    public async Task Example_VoiceDubbing()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateVoiceDubbingAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestElevenVoiceDubbing
            {
                AudioUri = "https://example.com/audio.mp3",
                TargetLang = RequestElevenVoiceDubbingTargetLang.Es,
                DisableVoiceCloning = false,
                DropBackgroundAudio = false,
            });

        Console.WriteLine($"Task ID: {response.Id}");

        response.Id.Should().NotBe(default(Guid));
    }
}
