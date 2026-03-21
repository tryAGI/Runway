/*
 * order: 50
 * title: Get Task Status
 * slug: get-task-status
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Check the status of a generation task by its ID. This is useful for polling
    //// task progress and retrieving results. Tasks can be in one of several states:
    //// PENDING, THROTTLED, RUNNING, SUCCEEDED, FAILED, or CANCELLED.

    [TestMethod]
    [Ignore("Requires a valid task ID from a previous generation")]
    public async Task Example_GetTaskStatus()
    {
        using var client = GetAuthenticatedClient();

        // Replace with an actual task ID from a previous generation
        var taskId = Guid.Parse("00000000-0000-0000-0000-000000000000");

        GetTasksResponse taskDetail = await client.TaskManagement.GetTasksByIdAsync(
            id: taskId,
            xRunwayVersion: "2024-11-06");

        if (taskDetail.IsPending)
        {
            Console.WriteLine($"Task {taskDetail.Pending!.Id} is pending.");
            Console.WriteLine($"Created at: {taskDetail.Pending.CreatedAt}");
        }
        else if (taskDetail.IsRunning)
        {
            Console.WriteLine($"Task {taskDetail.Running!.Id} is running.");
            Console.WriteLine($"Progress: {taskDetail.Running.Progress}");
        }
        else if (taskDetail.IsSucceeded)
        {
            Console.WriteLine($"Task {taskDetail.Succeeded!.Id} succeeded.");

            foreach (var output in taskDetail.Succeeded.Output)
            {
                Console.WriteLine($"Output URL: {output}");
            }
        }
        else if (taskDetail.IsFailed)
        {
            Console.WriteLine($"Task {taskDetail.Failed!.Id} failed.");
            Console.WriteLine($"Failure: {taskDetail.Failed.Failure}");
            Console.WriteLine($"Failure code: {taskDetail.Failed.FailureCode}");
        }
        else if (taskDetail.IsCancelled)
        {
            Console.WriteLine($"Task {taskDetail.Cancelled!.Id} was cancelled.");
        }

        taskDetail.Should().NotBeNull();
    }
}
