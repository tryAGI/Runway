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
            request: new CreateSoundEffectRequestElevenTextToSoundV2
            {
                PromptText = "A thunderstorm with heavy rain and distant thunder rumbling",
                Duration = 10.0,
                Loop = false,
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
