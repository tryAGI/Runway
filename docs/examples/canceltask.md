# CancelTask



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
RequireBillableExamplesEnabled("Submitting a seedance2 video just to cancel it", approximateCredits: 35);

using var client = new RunwayClient(apiKey);

// Start a generation task.

var response = await client.StartGenerating.CreateImageToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateImageToVideoRequestSeedance2
    {
        PromptImage = "https://example.com/photo.jpg",
        PromptText = "A slow zoom out revealing the landscape",
        Model = "seedance2",
        Duration = 5,
        Ratio = CreateImageToVideoRequestSeedance2Ratio.x1280_720,
    });

Console.WriteLine($"Task ID: {response.Id}");

// Cancel the task before it finishes.

await client.TaskManagement.DeleteTasksByIdAsync(
    id: response.Id,
    xRunwayVersion: "2024-11-06");

Console.WriteLine("Task cancelled successfully.");

// Verify the task is no longer running.

var taskDetail = await client.TaskManagement.GetTasksByIdAsync(
    id: response.Id,
    xRunwayVersion: "2024-11-06");
```