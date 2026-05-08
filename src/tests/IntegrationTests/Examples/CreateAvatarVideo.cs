/*
 * order: 80
 * title: Avatar Video
 * slug: avatar-video
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate a talking-avatar video from text. Use a preset avatar for quick demos,
    //// or replace Avatar with CreateAvatarVideosRequestAvatarCustomAvatar to use your own avatar.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_CreateAvatarVideo()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.AvatarVideos.CreateAvatarVideosAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateAvatarVideosRequest
            {
                Avatar = new CreateAvatarVideosRequestAvatarRunwayPresetAvatar
                {
                    PresetId = CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId.Influencer,
                },
                Speech = new CreateAvatarVideosRequestSpeechTextInput
                {
                    Text = "Welcome to the Runway API hackathon. Here is a quick prototype walkthrough.",
                    Voice = new CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
                    {
                        PresetId = CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId.Clara,
                    },
                },
            });

        Console.WriteLine($"Task ID: {response.Id}");
        response.Id.Should().NotBe(default(Guid));

        GetTasksResponse taskDetail;
        do
        {
            taskDetail = await client.TaskManagement.GetTasksByIdAsync(
                id: response.Id,
                xRunwayVersion: "2024-11-06");

            if (taskDetail.IsRunning)
            {
                Console.WriteLine($"Progress: {taskDetail.Running!.Progress}");
            }

            await Task.Delay(TimeSpan.FromSeconds(5));
        }
        while (!taskDetail.IsFailed && !taskDetail.IsSucceeded && !taskDetail.IsCancelled);

        if (taskDetail.IsSucceeded)
        {
            foreach (var output in taskDetail.Succeeded!.Output)
            {
                Console.WriteLine($"Avatar video URL: {output}");
            }
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
