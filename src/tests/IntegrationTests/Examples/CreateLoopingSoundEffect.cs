/*
 * order: 75
 * title: Looping Sound Effects
 * slug: looping-sound-effects
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate a seamlessly looping sound effect.
    //// Set `Loop = true` to produce audio designed for continuous playback
    //// — ideal for ambient backgrounds, game environments, or video loops.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_LoopingSoundEffect()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateSoundEffectAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateSoundEffectRequestElevenTextToSoundV2
            {
                PromptText = "Gentle forest ambience with birds chirping and a light breeze",
                Duration = 15.0,
                Loop = true,
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
                Console.WriteLine($"Looping Audio URL: {output}");
            }
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
