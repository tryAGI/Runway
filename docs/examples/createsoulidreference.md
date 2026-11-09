# CreateSoulIdReference



This example assumes `using Runway;` is in scope and `apiKey` contains your Runway API key.

```csharp
var sandbox = Path.Combine(Path.GetTempPath(), $"runway-soulid-test-{Guid.NewGuid():N}");
var previousHome = Environment.GetEnvironmentVariable("RUNWAY_CLI_HOME");
try
{
    Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);

    var photos = new List<string>(5);
    for (var index = 1; index <= 5; index++)
    {
        var path = Path.Combine(sandbox, $"photo{index}.jpg");
        Directory.CreateDirectory(sandbox);
        File.WriteAllBytes(path, [(byte)index, 0, 0, 0]);
        photos.Add(path);
    }

    var entry = RunwayCliSoulId.Create(name: "alice", photoPaths: photos, variant: "soul-2");

    var listed = RunwayCliSoulId.List();

    var fetched = RunwayCliSoulId.Get(entry.Id);

    var resolved = RunwayCliSoulId.ResolvePhotos(entry.Id);
    foreach (var photo in resolved)
    {
    }
}
finally
{
    Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", previousHome);
    if (Directory.Exists(sandbox))
    {
        Directory.Delete(sandbox, recursive: true);
    }
}
```