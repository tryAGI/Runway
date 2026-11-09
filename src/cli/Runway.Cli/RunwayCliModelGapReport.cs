using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Machine-readable form of `runway models --account`: the difference between the models described by
/// the OpenAPI spec embedded in the SDK and the models this account is entitled to. Scriptable so CI can
/// fail, or open an issue, when the spec falls behind what the account can already bill.
/// </summary>
internal sealed record RunwayCliModelGapReport
{
    /// <summary>How many distinct model ids the embedded spec describes.</summary>
    public int SpecModelCount { get; init; }

    /// <summary>How many models the account's tier lists.</summary>
    public int AccountModelCount { get; init; }

    /// <summary>
    /// Models the account can bill that the spec does not describe at all — unreachable through the typed
    /// SDK until the spec refresh lands and `generate.sh` is re-run.
    /// </summary>
    public IReadOnlyList<string> MissingFromSpec { get; init; } = [];

    /// <summary>
    /// Account capabilities that the spec exposes as a dedicated endpoint rather than a `model` value,
    /// such as the recipes. Reachable today, just not through `--model`.
    /// </summary>
    public IReadOnlyList<string> EndpointCapabilities { get; init; } = [];

    /// <summary>
    /// Models the spec describes that the account's tier does not list — requests would be rejected.
    /// </summary>
    public IReadOnlyList<string> MissingFromAccount { get; init; } = [];
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true)]
[JsonSerializable(typeof(RunwayCliModelGapReport))]
internal sealed partial class RunwayCliModelGapReportJsonSerializerContext : JsonSerializerContext
{
}

internal static class RunwayCliModelGap
{
    public static string ToJson(RunwayCliModelGapReport report) =>
        JsonSerializer.Serialize(report, RunwayCliModelGapReportJsonSerializerContext.Default.RunwayCliModelGapReport);
}
