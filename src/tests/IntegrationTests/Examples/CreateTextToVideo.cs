/*
 * order: 20
 * title: Create Text To Video
 * slug: create-text-to-video
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate a video from a text prompt using the Runway API.
    //// The task is polled until completion, then the output video URL is retrieved.

    [TestMethod]
    public async Task Example_CreateTextToVideo()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateTextToVideoAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateTextToVideoRequestVeo31Fast
            {
                PromptText = "A calm ocean with gentle waves under a starlit sky",
                Ratio = CreateTextToVideoRequestVeo31FastRatio.x1280_720,
                Duration = 5,
            });
        response.Id.Should().NotBe(default(Guid));

        Console.WriteLine($"Task ID: {response.Id}");

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

            await Task.Delay(TimeSpan.FromSeconds(10));
        }
        while (!taskDetail.IsFailed && !taskDetail.IsSucceeded && !taskDetail.IsCancelled);

        if (taskDetail.IsSucceeded)
        {
            Console.WriteLine($"Task Status: {taskDetail.Succeeded!.Status}");

            foreach (var output in taskDetail.Succeeded.Output)
            {
                Console.WriteLine($"Video URL: {output}");
            }
        }
        else if (taskDetail.IsFailed)
        {
            Console.WriteLine($"Failure: {taskDetail.Failed!.Failure}");
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
