using System.Text.Json.Serialization;

namespace Runway;

/// <summary>
/// Source-generated JSON serialization context for the built-in workflow public types.
/// Use this from AOT / trim-mode consumers (Telegram bots, desktop apps) so
/// <see cref="BuiltInWorkflowResult"/>, <see cref="BuiltInWorkflow"/>, and friends serialize
/// without falling back on reflection.
///
/// Example:
/// <code>
/// var json = System.Text.Json.JsonSerializer.Serialize(
///     result,
///     BuiltInWorkflowsJsonSerializerContext.Default.BuiltInWorkflowResult);
/// </code>
/// </summary>
[System.CLSCompliant(false)]
[JsonSourceGenerationOptions(
    WriteIndented = false,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    Converters = [
        typeof(JsonStringEnumConverter<BuiltInWorkflowCategory>),
        typeof(JsonStringEnumConverter<BuiltInWorkflowInputKind>),
        typeof(JsonStringEnumConverter<BuiltInWorkflowKind>),
        typeof(JsonStringEnumConverter<BuiltInWorkflowStatus>),
    ])]
[JsonSerializable(typeof(BuiltInWorkflow))]
[JsonSerializable(typeof(BuiltInWorkflowInput))]
[JsonSerializable(typeof(BuiltInWorkflowCategory))]
[JsonSerializable(typeof(BuiltInWorkflowInputKind))]
[JsonSerializable(typeof(BuiltInWorkflowKind))]
[JsonSerializable(typeof(BuiltInWorkflowStatus))]
[JsonSerializable(typeof(BuiltInWorkflowResult))]
[JsonSerializable(typeof(BuiltInWorkflowPick))]
[JsonSerializable(typeof(IReadOnlyList<BuiltInWorkflow>))]
[JsonSerializable(typeof(IReadOnlyList<BuiltInWorkflowInput>))]
[JsonSerializable(typeof(IReadOnlyList<BuiltInWorkflowPick>))]
[JsonSerializable(typeof(IReadOnlyDictionary<Guid, IReadOnlyList<Uri>>))]
[JsonSerializable(typeof(Dictionary<string, IReadOnlyList<string>>))]
public partial class BuiltInWorkflowsJsonSerializerContext : JsonSerializerContext;
