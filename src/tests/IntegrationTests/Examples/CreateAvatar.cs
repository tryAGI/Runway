/*
 * order: 75
 * title: Create Avatar
 * slug: create-avatar
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Create a custom realtime avatar from a reference image, personality prompt, and voice.
    //// The response is a discriminated union because an avatar can be processing, ready, or failed.

    [TestMethod]
    [Ignore("Requires paid API credits and a reference image")]
    public async Task Example_CreateAvatar()
    {
        using var client = GetAuthenticatedClient();

        var avatar = await client.Avatars.CreateAvatarsAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateAvatarsRequest
            {
                Name = "Hackathon Producer",
                ReferenceImage = "https://example.com/reference.jpg",
                Personality = "You are a concise creative producer who helps teams turn rough ideas into practical video plans.",
                StartScript = "Tell me what you want to make and I will help shape the shot list.",
                Voice = new CreateAvatarsRequestVoiceRunwayLivePresetVoice
                {
                    PresetId = CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId.Adrian,
                },
                ImageProcessing = CreateAvatarsRequestImageProcessing.Optimize,
            });

        var avatarId = avatar.Match(
            processing: processing => processing!.Id,
            ready: ready => ready!.Id,
            failed: failed => failed!.Id);

        Console.WriteLine($"Avatar ID: {avatarId}");
        avatarId.Should().NotBe(Guid.Empty);
    }
}
