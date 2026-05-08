/*
 * order: 70
 * title: Preset Avatars
 * slug: preset-avatars
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List preset avatar IDs that can be used directly with avatar video generation.
    //// The live preset voice IDs can be used when creating a custom avatar.

    [TestMethod]
    public void Example_ListPresetAvatars()
    {
        var avatars = Enum.GetValues<CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId>();

        foreach (var avatar in avatars)
        {
            Console.WriteLine(avatar.ToValueString());
        }

        avatars.Length.Should().BeGreaterThan(0);
        avatars.Should().Contain(CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.Influencer);
        avatars.Should().Contain(CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.CookingTeacher);

        var voices = Enum.GetValues<CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId>();

        foreach (var voice in voices)
        {
            Console.WriteLine(voice.ToValueString());
        }

        voices.Length.Should().BeGreaterThan(0);
        voices.Should().Contain(CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId.Adrian);
        voices.Should().Contain(CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId.Maya);
    }
}
