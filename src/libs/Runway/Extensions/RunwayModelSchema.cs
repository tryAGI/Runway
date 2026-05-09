using System.Text.Json;

namespace Runway;

/// <summary>
/// One row of the Runway model→endpoint mapping derived from the embedded OpenAPI spec.
/// </summary>
public sealed record RunwayModelEndpoint(
    string Endpoint,
    IReadOnlyList<string> RequiredParameters,
    IReadOnlyList<string> OptionalParameters)
{
    /// <summary>
    /// All parameters the endpoint accepts for this model — required first, then optional.
    /// </summary>
    public IEnumerable<string> Parameters => RequiredParameters.Concat(OptionalParameters);
}

/// <summary>
/// Reads the Runway OpenAPI spec embedded in this assembly and exposes per-model endpoint metadata
/// (which endpoints accept which model id, plus required/optional request parameters per variant).
/// Designed for SDK consumers that want to discover model capabilities programmatically without
/// shelling out to <c>runway models schema</c> or hand-writing a model catalog.
/// </summary>
public static class RunwayModelSchema
{
    private const string EmbeddedSpecResource = "Runway.openapi.json";

    private static readonly Lazy<Dictionary<string, IReadOnlyList<RunwayModelEndpoint>>> Map = new(LoadMap);

    /// <summary>
    /// Maps spec property names to the CLI flag the user should add to satisfy them.
    /// Used by <see cref="EnsureRequiredParametersProvided"/> to render actionable errors.
    /// </summary>
    private static readonly Dictionary<string, string> SpecParamToCliFlag = new(StringComparer.Ordinal)
    {
        ["promptText"] = "--prompt",
        ["promptImage"] = "--image",
        ["referenceImages"] = "--reference-image",
        ["ratio"] = "--ratio",
        ["duration"] = "--duration",
        ["seed"] = "--seed",
        ["audio"] = "--audio (or remove --no-audio)",
        ["videoUri"] = "--video",
        ["references"] = "--reference-image",
        ["media"] = "--media",
        ["voice"] = "--voice-preset / --custom-voice-id",
        ["audioUri"] = "--audio",
        ["targetLang"] = "--target-language",
        ["character"] = "--character-image / --character-video",
        ["reference"] = "--reference-video",
        ["bodyControl"] = "--body-control",
        ["expressionIntensity"] = "--expression-intensity",
        ["avatar"] = "--preset-avatar / --avatar-id",
        ["speech"] = "--text or --audio",
        ["personality"] = "--personality",
        ["startScript"] = "--start-script",
        ["tools"] = "--tools-json",
        ["maxDuration"] = "--max-duration",
        ["outputCount"] = "--output-count",
        ["quality"] = "--quality",
        ["background"] = "--background",
        ["contentModeration"] = "--public-figure-threshold",
    };

    /// <summary>
    /// Returns the endpoints that accept <paramref name="modelId"/> per the embedded OpenAPI spec.
    /// Empty when the model id is unknown. Dash and underscore are interchangeable
    /// (e.g. <c>gen4-turbo</c> and <c>gen4_turbo</c> both resolve).
    /// </summary>
    public static IReadOnlyList<RunwayModelEndpoint> Lookup(string modelId)
    {
        if (string.IsNullOrWhiteSpace(modelId))
        {
            return [];
        }

        var map = Map.Value;
        if (map.TryGetValue(modelId, out var entries))
        {
            return entries;
        }

        var normalized = modelId.Trim().Replace('-', '_');
        return map.TryGetValue(normalized, out entries) ? entries : [];
    }

    /// <summary>
    /// Enumerates every model id discovered in the embedded spec.
    /// </summary>
    public static IEnumerable<string> KnownModelIds() => Map.Value.Keys;

    /// <summary>
    /// Annotates a spec property name with the CLI flag a Runway.Cli user should add (e.g.
    /// <c>"promptImage"</c> → <c>"promptImage (--image)"</c>). Unknown spec names fall through to
    /// the bare property name.
    /// </summary>
    public static string DescribeRequiredParam(string specName) =>
        SpecParamToCliFlag.TryGetValue(specName, out var flag) ? $"{specName} ({flag})" : specName;

    /// <summary>
    /// Throws when <paramref name="modelId"/> is known but not accepted by <paramref name="endpoint"/>.
    /// Unknown models pass through silently so brand-new spec entries don't break callers.
    /// </summary>
    public static void EnsureModelSupportsEndpoint(string modelId, string endpoint)
    {
        if (string.IsNullOrWhiteSpace(modelId))
        {
            return;
        }

        var entries = Lookup(modelId);
        if (entries.Count == 0)
        {
            return;
        }

        var endpoints = entries.Select(static e => e.Endpoint).Distinct(StringComparer.Ordinal).ToList();
        if (endpoints.Contains(endpoint, StringComparer.Ordinal))
        {
            return;
        }

        throw new ArgumentException(
            $"Model `{modelId}` is not supported by `{endpoint}` per the Runway OpenAPI spec. Supported endpoints: {string.Join(", ", endpoints)}.");
    }

    /// <summary>
    /// Validates that every spec-required parameter for the chosen <paramref name="modelId"/> on
    /// <paramref name="endpoint"/> is marked as provided in <paramref name="providedFlags"/>. A param is
    /// only checked if the caller listed it in the dictionary — unknown params (not tracked by the
    /// caller) are not enforced. Unknown models pass through so brand-new spec entries don't break.
    /// </summary>
    public static void EnsureRequiredParametersProvided(
        string modelId,
        string endpoint,
        IReadOnlyDictionary<string, bool> providedFlags)
    {
        ArgumentNullException.ThrowIfNull(providedFlags);

        if (string.IsNullOrWhiteSpace(modelId))
        {
            return;
        }

        var entries = Lookup(modelId);
        if (entries.Count == 0)
        {
            return;
        }

        RunwayModelEndpoint? entry = null;
        foreach (var candidate in entries)
        {
            if (string.Equals(candidate.Endpoint, endpoint, StringComparison.Ordinal))
            {
                entry = candidate;
                break;
            }
        }

        if (entry is null)
        {
            return;
        }

        var missing = new List<string>();
        foreach (var required in entry.RequiredParameters)
        {
            if (providedFlags.TryGetValue(required, out var present) && !present)
            {
                missing.Add(required);
            }
        }

        if (missing.Count > 0)
        {
            var rendered = string.Join(", ", missing.Select(DescribeRequiredParam));
            throw new ArgumentException(
                $"Model `{modelId}` on `{endpoint}` requires {rendered} per the Runway OpenAPI spec. Run `runway models schema {modelId}` for the full parameter list.");
        }
    }

    private static Dictionary<string, IReadOnlyList<RunwayModelEndpoint>> LoadMap()
    {
        var assembly = typeof(RunwayModelSchema).Assembly;
        using var stream = assembly.GetManifestResourceStream(EmbeddedSpecResource)
            ?? throw new InvalidOperationException($"Embedded resource `{EmbeddedSpecResource}` missing from Runway assembly.");
        using var document = JsonDocument.Parse(stream, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });
        var root = document.RootElement.Clone();

        var result = new Dictionary<string, List<RunwayModelEndpoint>>(StringComparer.OrdinalIgnoreCase);

        if (!root.TryGetProperty("paths", out var paths) || paths.ValueKind != JsonValueKind.Object)
        {
            return ToReadOnly(result);
        }

        foreach (var pathProperty in paths.EnumerateObject())
        {
            if (pathProperty.Value.ValueKind != JsonValueKind.Object)
            {
                continue;
            }

            foreach (var methodProperty in pathProperty.Value.EnumerateObject())
            {
                if (!string.Equals(methodProperty.Name, "post", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (!methodProperty.Value.TryGetProperty("requestBody", out var body) ||
                    !body.TryGetProperty("content", out var content) ||
                    !content.TryGetProperty("application/json", out var jsonContent) ||
                    !jsonContent.TryGetProperty("schema", out var schema))
                {
                    continue;
                }

                var endpointName = pathProperty.Name.TrimStart('/');
                if (endpointName.StartsWith("v1/", StringComparison.OrdinalIgnoreCase))
                {
                    endpointName = endpointName["v1/".Length..];
                }

                var resolvedSchema = Resolve(schema, root);
                foreach (var variant in EnumerateVariants(resolvedSchema, root))
                {
                    if (!variant.TryGetProperty("properties", out var properties) ||
                        properties.ValueKind != JsonValueKind.Object ||
                        !properties.TryGetProperty("model", out var modelProperty))
                    {
                        continue;
                    }

                    var modelResolved = Resolve(modelProperty, root);
                    var requiredSet = ReadRequiredSet(variant);
                    var requiredParams = new List<string>();
                    var optionalParams = new List<string>();
                    foreach (var prop in properties.EnumerateObject())
                    {
                        if (string.Equals(prop.Name, "model", StringComparison.Ordinal))
                        {
                            continue;
                        }

                        if (requiredSet.Contains(prop.Name))
                        {
                            requiredParams.Add(prop.Name);
                        }
                        else
                        {
                            optionalParams.Add(prop.Name);
                        }
                    }

                    requiredParams.Sort(StringComparer.Ordinal);
                    optionalParams.Sort(StringComparer.Ordinal);

                    foreach (var modelId in EnumerateModelIds(modelResolved))
                    {
                        if (!result.TryGetValue(modelId, out var list))
                        {
                            list = [];
                            result[modelId] = list;
                        }

                        list.Add(new RunwayModelEndpoint(endpointName, requiredParams, optionalParams));
                    }
                }
            }
        }

        return ToReadOnly(result);
    }

    private static HashSet<string> ReadRequiredSet(JsonElement variant)
    {
        var set = new HashSet<string>(StringComparer.Ordinal);
        if (variant.ValueKind != JsonValueKind.Object ||
            !variant.TryGetProperty("required", out var required) ||
            required.ValueKind != JsonValueKind.Array)
        {
            return set;
        }

        foreach (var value in required.EnumerateArray())
        {
            if (value.ValueKind == JsonValueKind.String && value.GetString() is { Length: > 0 } name)
            {
                set.Add(name);
            }
        }

        return set;
    }

    private static IEnumerable<string> EnumerateModelIds(JsonElement modelSchema)
    {
        if (modelSchema.ValueKind != JsonValueKind.Object)
        {
            yield break;
        }

        if (modelSchema.TryGetProperty("enum", out var enumArray) && enumArray.ValueKind == JsonValueKind.Array)
        {
            foreach (var value in enumArray.EnumerateArray())
            {
                if (value.ValueKind == JsonValueKind.String && value.GetString() is { Length: > 0 } modelId)
                {
                    yield return modelId;
                }
            }

            yield break;
        }

        if (modelSchema.TryGetProperty("const", out var constValue) &&
            constValue.ValueKind == JsonValueKind.String &&
            constValue.GetString() is { Length: > 0 } constModel)
        {
            yield return constModel;
        }
    }

    private static IEnumerable<JsonElement> EnumerateVariants(JsonElement schema, JsonElement root)
    {
        if (schema.ValueKind != JsonValueKind.Object)
        {
            yield break;
        }

        if (schema.TryGetProperty("oneOf", out var oneOf) && oneOf.ValueKind == JsonValueKind.Array)
        {
            foreach (var variant in oneOf.EnumerateArray())
            {
                yield return Resolve(variant, root);
            }

            yield break;
        }

        if (schema.TryGetProperty("allOf", out var allOf) && allOf.ValueKind == JsonValueKind.Array)
        {
            foreach (var variant in allOf.EnumerateArray())
            {
                yield return Resolve(variant, root);
            }

            yield break;
        }

        yield return schema;
    }

    private static JsonElement Resolve(JsonElement element, JsonElement root, int depth = 0)
    {
        if (depth > 8 || element.ValueKind != JsonValueKind.Object)
        {
            return element;
        }

        if (!element.TryGetProperty("$ref", out var refProperty) || refProperty.ValueKind != JsonValueKind.String)
        {
            return element;
        }

        var refValue = refProperty.GetString();
        if (string.IsNullOrEmpty(refValue) || !refValue.StartsWith("#/", StringComparison.Ordinal))
        {
            return element;
        }

        var parts = refValue[2..].Split('/');
        var node = root;
        foreach (var part in parts)
        {
            if (node.ValueKind != JsonValueKind.Object || !node.TryGetProperty(part, out node))
            {
                return element;
            }
        }

        return Resolve(node, root, depth + 1);
    }

    private static Dictionary<string, IReadOnlyList<RunwayModelEndpoint>> ToReadOnly(
        Dictionary<string, List<RunwayModelEndpoint>> source)
    {
        var copy = new Dictionary<string, IReadOnlyList<RunwayModelEndpoint>>(source.Count, StringComparer.OrdinalIgnoreCase);
        foreach (var kvp in source)
        {
            copy[kvp.Key] = kvp.Value;
        }

        return copy;
    }
}
