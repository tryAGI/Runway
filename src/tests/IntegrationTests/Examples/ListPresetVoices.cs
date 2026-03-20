/*
 * order: 65
 * title: Preset Voices
 * slug: preset-voices
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List all 48 available preset voices for the text-to-speech API.
    //// These voices are built-in and do not require any API call to enumerate.

    [TestMethod]
    public void Example_ListPresetVoices()
    {
        var voices = Enum.GetValues<RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId>();

        foreach (var voice in voices)
        {
            Console.WriteLine(voice.ToValueString());
        }

        voices.Length.Should().BeGreaterThan(0);
        voices.Should().Contain(RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Maya);
        voices.Should().Contain(RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Arjun);
        voices.Should().Contain(RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Eleanor);
    }
}
