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
            request: new CreateTextToSpeechRequestElevenMultilingualV2
            {
                PromptText = "Hello! Welcome to Runway's text-to-speech API.",
                Voice = new CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoice
                {
                    PresetId = CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetId.Maya,
                },
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
                Console.WriteLine($"Audio URL: {output}");
            }
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
