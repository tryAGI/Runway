/*
 * order: 55
 * title: Cancel Task
 * slug: cancel-task
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Cancel a running task or delete a completed one.
    //// Running, pending, and throttled tasks are cancelled immediately.
    //// Completed tasks are deleted along with their output data.

    [TestMethod]
    [Ignore("Requires paid API credits")]
    public async Task Example_CancelTask()
    {
        using var client = GetAuthenticatedClient();

        //// Start a generation task.

        var response = await client.StartGenerating.CreateImageToVideoAsync(
            xRunwayVersion: "2024-11-06",
            request: new RequestGen3aTurbo
            {
                PromptImage = "https://example.com/photo.jpg",
                PromptText = "A slow zoom out revealing the landscape",
                Model = "gen3a_turbo",
                Duration = 5,
                Ratio = RequestGen3aTurboRatio.x1280_768,
            });

        Console.WriteLine($"Task ID: {response.Id}");
        response.Id.Should().NotBe(default(Guid));

        //// Cancel the task before it finishes.

        await client.TaskManagement.DeleteTasksByIdAsync(
            id: response.Id,
            xRunwayVersion: "2024-11-06");

        Console.WriteLine("Task cancelled successfully.");

        //// Verify the task is no longer running.

        var taskDetail = await client.TaskManagement.GetTasksByIdAsync(
            id: response.Id,
            xRunwayVersion: "2024-11-06");

        taskDetail.IsRunning.Should().BeFalse();
    }
}
