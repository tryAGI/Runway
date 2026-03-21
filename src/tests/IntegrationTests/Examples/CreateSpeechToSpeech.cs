/*
 * order: 85
 * title: Speech to Speech
 * slug: speech-to-speech
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Transform the voice in an audio file while preserving the original speech content.
    //// Choose a preset voice to apply and optionally remove background noise.
    //// Accepts audio or video files as input media.

    [TestMethod]
    [Ignore("Requires paid API credits and audio input")]
    public async Task Example_SpeechToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateSpeechToSpeechAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateSpeechToSpeechRequestElevenMultilingualStsV2
            {
                Media = new CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio
                {
                    Uri = "https://example.com/speech.mp3",
                },
                Voice = new CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoice
                {
                    PresetId = CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId.Eleanor,
                },
                RemoveBackgroundNoise = true,
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
                Console.WriteLine($"Transformed Audio URL: {output}");
            }
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
