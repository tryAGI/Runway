using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Machine-readable result of a generation command, emitted on stdout under `--format json`. Keeps the
/// task ID and the downloaded paths together so a CI step does not have to scrape them from the
/// human-readable stderr stream.
/// </summary>
internal sealed record RunwayCliGenerationResult
{
    /// <summary>The Runway task ID, so a later `runway task get`/`wait` can reference it.</summary>
    public string TaskId { get; init; } = string.Empty;

    /// <summary>Local paths of the downloaded outputs. Empty with `--no-wait`, which does not download.</summary>
    public IReadOnlyList<string> Outputs { get; init; } = [];
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = false)]
[JsonSerializable(typeof(RunwayCliGenerationResult))]
internal sealed partial class RunwayCliResultJsonSerializerContext : JsonSerializerContext
{
}

internal static class RunwayCliResult
{
    public static string ToJson(RunwayCliGenerationResult result) =>
        JsonSerializer.Serialize(result, RunwayCliResultJsonSerializerContext.Default.RunwayCliGenerationResult);
}
