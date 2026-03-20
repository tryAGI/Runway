/*
 * order: 90
 * title: Error Handling
 * slug: error-handling
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Handle task failures gracefully by inspecting the `IsFailed` status.
    //// Failed tasks include a human-readable `Failure` message and a
    //// machine-readable `FailureCode` for programmatic error handling.
    //// See https://docs.dev.runwayml.com/errors/task-failures/ for error codes.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_ErrorHandling()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.StartGenerating.CreateImageToVideoAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestGen3aTurbo
            {
                PromptImage = "https://example.com/photo.jpg",
                PromptText = "A gentle zoom into the scene",
                Model = "gen3a_turbo",
                Duration = 5,
                Ratio = RequestGen3aTurboRatio.x1280_768,
            });

        Console.WriteLine($"Task ID: {response.Id}");
        response.Id.Should().NotBe(default(Guid));

        //// Poll the task until it reaches a terminal state.

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

            await Task.Delay(TimeSpan.FromSeconds(5));
        }
        while (!taskDetail.IsFailed && !taskDetail.IsSucceeded && !taskDetail.IsCancelled);

        //// Inspect the result — handle both success and failure cases.

        if (taskDetail.IsSucceeded)
        {
            foreach (var output in taskDetail.Succeeded!.Output)
            {
                Console.WriteLine($"Output URL: {output}");
            }
        }
        else if (taskDetail.IsFailed)
        {
            Console.WriteLine($"Failure reason: {taskDetail.Failed!.Failure}");
            Console.WriteLine($"Failure code: {taskDetail.Failed.FailureCode}");
        }
        else if (taskDetail.IsCancelled)
        {
            Console.WriteLine("Task was cancelled.");
        }

        (taskDetail.IsSucceeded || taskDetail.IsFailed || taskDetail.IsCancelled).Should().BeTrue();
    }
}
