# Create Image To Video



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
RequireBillableExamplesEnabled("A 5 second seedance2 image-to-video", approximateCredits: 35);

using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateImageToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new CreateImageToVideoRequestSeedance2
    {
        PromptImage = "https://img.freepik.com/free-photo/beautiful-woman-with-long-blond-hair-looking-camera-outdoors-generated-by-artificial-intelligence_188544-240170.jpg",
        PromptText = "The girl smiles a little",
        Audio = true,
        Model = "seedance2",
        Duration = 5,
        Ratio = CreateImageToVideoRequestSeedance2Ratio.x1280_720,
    });

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
    Console.WriteLine($"Task ID: {taskDetail.Succeeded!.Id}");
    Console.WriteLine($"Task Status: {taskDetail.Succeeded.Status}");
    Console.WriteLine($"CreatedAt: {taskDetail.Succeeded.CreatedAt}");

    foreach (var output in taskDetail.Succeeded.Output)
    {
        Console.WriteLine($"Video URL: {output}");
    }
}
else if (taskDetail.IsFailed)
{
    Console.WriteLine($"Task ID: {taskDetail.Failed!.Id}");
    Console.WriteLine($"Task Status: {taskDetail.Failed.Status}");
    Console.WriteLine($"Failure: {taskDetail.Failed.Failure}");
    Console.WriteLine($"FailureCode: {taskDetail.Failed.FailureCode}");
}
```