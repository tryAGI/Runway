# CreateSpeechToSpeech



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
using var client = new RunwayClient(apiKey);

var response = await client.StartGenerating.CreateSpeechToSpeechAsync(
    xRunwayVersion: "2024-11-06",
    request: new RequestElevenMultilingualStsV2
    {
        Media = new RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio
        {
            Uri = "https://example.com/speech.mp3",
        },
        Voice = new RequestElevenMultilingualStsV2VoiceRunwayPresetVoice
        {
            PresetId = RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetId.Eleanor,
        },
        RemoveBackgroundNoise = true,
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
        Console.WriteLine($"Transformed Audio URL: {output}");
    }
}
```