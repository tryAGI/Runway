/*
 * order: 30
 * title: Create Text To Image
 * slug: create-text-to-image
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate an image from a text prompt using the Runway API.
    //// The task is polled until completion, then the output image URL is retrieved.

    [TestMethod]
    public async Task Example_CreateTextToImage()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateTextToImageAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestGen4ImageTurbo
            {
                PromptText = "A vibrant coral reef teeming with tropical fish",
                Ratio = RequestGen4ImageTurboRatio.x1280_720,
                ReferenceImages = [],
            });
        response.Id.Should().NotBe(default(Guid));

        Console.WriteLine($"Task ID: {response.Id}");

        Response taskDetail;
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
                Console.WriteLine($"Image URL: {output}");
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
