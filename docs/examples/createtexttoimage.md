# CreateTextToImage



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateTextToImageAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestGen4ImageTurbo
    {
        PromptText = "A vibrant coral reef teeming with tropical fish",
        Ratio = RequestGen4ImageTurboRatio.x1280_720,
        ReferenceImages = [],
    });

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
```