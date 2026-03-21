/*
 * order: 40
 * title: Image to Video with Gen4 Turbo
 * slug: create-image-to-video-gen4-turbo
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Generate a video from an image using the Gen-4 Turbo model.
    //// This model provides faster generation with good quality results.
    //// The task is polled until completion, then the output video URL is retrieved.

    [TestMethod]
    public async Task Example_CreateImageToVideoGen4Turbo()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateImageToVideoAsync(
            xRunwayVersion: "2024-11-06",
            request: new CreateImageToVideoRequestGen4Turbo
            {
                PromptImage = "https://img.freepik.com/free-photo/beautiful-woman-with-long-blond-hair-looking-camera-outdoors-generated-by-artificial-intelligence_188544-240170.jpg",
                PromptText = "The woman slowly turns her head and smiles",
                Seed = 42,
                Model = "gen4_turbo",
                Duration = 5,
                Ratio = CreateImageToVideoRequestGen4TurboRatio.x1280_720,
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
            Console.WriteLine($"FailureCode: {taskDetail.Failed.FailureCode}");
        }

        taskDetail.IsSucceeded.Should().BeTrue();
        taskDetail.Succeeded!.Output.Should().NotBeNullOrEmpty();
    }
}
