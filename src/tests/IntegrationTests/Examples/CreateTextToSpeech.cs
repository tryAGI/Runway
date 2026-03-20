/*
 * order: 60
 * title: Text to Speech
 * slug: text-to-speech
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate speech from text using the Eleven Multilingual V2 model.
    //// Choose from 48 preset voices including Maya, Arjun, Eleanor, and more.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_TextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateTextToSpeechAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestElevenMultilingualV2
            {
                PromptText = "Hello! Welcome to Runway's text-to-speech API.",
                Voice = new RequestElevenMultilingualV2VoiceRunwayPresetVoice
                {
                    PresetId = RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Maya,
                },
            });

        Console.WriteLine($"Task ID: {response.Id}");

        response.Id.Should().NotBe(default(Guid));
    }
}
