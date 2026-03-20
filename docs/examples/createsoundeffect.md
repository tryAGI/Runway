# CreateSoundEffect



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateSoundEffectAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestElevenTextToSoundV2
    {
        PromptText = "A thunderstorm with heavy rain and distant thunder rumbling",
        Duration = 10.0,
        Loop = false,
    });

Console.WriteLine($"Task ID: {response.Id}");

// Poll the task until it completes.

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

if (taskDetail.IsSucceeded)
{
    foreach (var output in taskDetail.Succeeded!.Output)
    {
        Console.WriteLine($"Audio URL: {output}");
    }
}
```