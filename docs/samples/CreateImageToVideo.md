```csharp
using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateImageToVideoAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestGen3aTurbo
    {
        PromptImage = "https://img.freepik.com/free-photo/beautiful-woman-with-long-blond-hair-looking-camera-outdoors-generated-by-artificial-intelligence_188544-240170.jpg",
        PromptText = "The girl smiles a little",
        Seed = 999999999,
        Model = "gen3a_turbo",
        Duration = 5,
        Ratio = RequestGen3aTurboRatio.x1280_768,
    });

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