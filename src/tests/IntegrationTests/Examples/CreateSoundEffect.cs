/*
 * order: 70
 * title: Sound Effects
 * slug: sound-effects
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate sound effects from a text description.
    //// Optionally specify duration (0.5-30 seconds) and whether the sound should loop seamlessly.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_SoundEffect()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateSoundEffectAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestElevenTextToSoundV2
            {
                PromptText = "A thunderstorm with heavy rain and distant thunder rumbling",
                Duration = 10.0,
                Loop = false,
            });

        Console.WriteLine($"Task ID: {response.Id}");

        response.Id.Should().NotBe(default(Guid));
    }
}
