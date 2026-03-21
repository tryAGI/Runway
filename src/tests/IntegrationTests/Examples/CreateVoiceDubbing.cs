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
            request: new CreateVoiceDubbingRequestElevenVoiceDubbing
            {
                AudioUri = "https://example.com/audio.mp3",
                TargetLang = CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang.Es,
                DisableVoiceCloning = false,
                DropBackgroundAudio = false,
            });

        Console.WriteLine($"Task ID: {response.Id}");
        response.Id.Should().NotBe(default(Guid));

        //// Poll the task until it completes.

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
                Console.WriteLine($"Dubbed Audio URL: {output}");
            }
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
