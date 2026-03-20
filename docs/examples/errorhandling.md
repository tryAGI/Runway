# ErrorHandling



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

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

// Poll the task until it reaches a terminal state.

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

// Inspect the result — handle both success and failure cases.

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
```