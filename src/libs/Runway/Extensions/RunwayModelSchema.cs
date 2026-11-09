using System.Text.Json;

namespace Runway;

/// <summary>
/// Spec detail for one request parameter of one model variant: whether it is required, the enum values
/// it accepts, and — for array parameters such as <c>referenceImages</c> or <c>references</c> — the item
/// ceiling and the properties each item may carry. Lets callers size and shape reference lists from the
/// spec instead of hard-coding per-model limits that go stale.
/// </summary>
/// <param name="Name">The wire name of the parameter, e.g. <c>referenceImages</c>.</param>
/// <param name="Required">Whether the model variant requires the parameter.</param>
/// <param name="AllowedValues">The parameter's enum values, or empty when it is not an enum.</param>
/// <param name="MaxItems">The array's <c>maxItems</c>, or null when the parameter is not a bounded array.</param>
/// <param name="ItemProperties">
/// The properties each array item may carry, e.g. <c>uri</c>, <c>tag</c>, <c>subject</c>. Empty for
/// non-array parameters. Sending a property absent from this list is rejected by models whose schema is
/// <c>additionalProperties: false</c>.
/// </param>
public sealed record RunwayModelParameter(
    string Name,
    bool Required,
    IReadOnlyList<string> AllowedValues,
    int? MaxItems,
    IReadOnlyList<string> ItemProperties)
{
    /// <summary>
    /// Enum values declared by the properties of this parameter's item/variant shapes, keyed by property
    /// name — for example the 49 preset voice ids under <c>voice.presetId</c>. Empty for properties that
    /// are not enum-backed.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlyList<string>> ItemPropertyValues { get; init; }
        = new Dictionary<string, IReadOnlyList<string>>(StringComparer.Ordinal);
}

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

    /// <summary>
    /// Per-parameter spec detail, keyed by wire name. Populated by <see cref="RunwayModelSchema"/>.
    /// </summary>
    public IReadOnlyDictionary<string, RunwayModelParameter> ParameterDetails { get; init; }
        = new Dictionary<string, RunwayModelParameter>(StringComparer.Ordinal);
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
    private static readonly Lazy<IReadOnlyList<string>> Endpoints = new(LoadEndpoints);

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
        ["promptVideo"] = "--video",
        ["references"] = "--reference-image",
        ["referenceVideos"] = "--reference-video",
        ["referenceAudio"] = "--reference-audio",
        ["resolution"] = "--resolution",
        ["negativePrompt"] = "--negative-prompt",
        ["mode"] = "--mode",
        ["outputFormat"] = "--output-format",
        ["proresProfile"] = "--prores-profile",
        ["targetAspectRatio"] = "--target-aspect-ratio",
        ["keyframes"] = "--keyframe",
        ["imageUri"] = "--image",
        ["targetFramerate"] = "--target-framerate",
        ["creativity"] = "--creativity",
        ["sharpen"] = "--sharpen",
        ["smartGrain"] = "--smart-grain",
        ["ultraDetail"] = "--ultra-detail",
        ["scaleFactor"] = "--scale-factor",
        ["flavor"] = "--flavor",
        ["fpsBoost"] = "--fps-boost",
        ["grounding"] = "--grounding",
        ["edit"] = "--edit",
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
    /// Every POST endpoint the embedded spec declares, named the way <see cref="RunwayModelEndpoint.Endpoint"/>
    /// names them — <c>text_to_video</c>, <c>recipes/product_ad</c>, and so on. Some Runway capabilities are
    /// whole endpoints rather than a <c>model</c> value (the recipes in particular), so a caller comparing a
    /// list of model names against the spec needs these too.
    /// </summary>
    public static IReadOnlyList<string> KnownEndpoints() => Endpoints.Value;

    /// <summary>
    /// Returns true when the embedded spec can address <paramref name="name"/> at all: either as a
    /// <c>model</c> value on some endpoint, or as an endpoint of its own (<c>product_ad</c> resolving to
    /// <c>recipes/product_ad</c>). Lets callers tell "the spec has not caught up with this model yet" apart
    /// from "this capability is an endpoint, not a model".
    /// </summary>
    public static bool IsKnown(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return false;
        }

        var trimmed = name.Trim();
        if (Lookup(trimmed).Count > 0)
        {
            return true;
        }

        foreach (var endpoint in Endpoints.Value)
        {
            if (string.Equals(endpoint, trimmed, StringComparison.OrdinalIgnoreCase) ||
                endpoint.EndsWith("/" + trimmed, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Returns every model id the embedded spec accepts on <paramref name="endpoint"/> (e.g. <c>text_to_video</c>),
    /// sorted for stable help output. Lets callers build model allow-lists straight from the spec instead of
    /// hand-maintaining one that goes stale whenever Runway ships a new model.
    /// </summary>
    public static IReadOnlyList<string> ModelsForEndpoint(string endpoint)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);

        var models = new List<string>();
        foreach (var kvp in Map.Value)
        {
            foreach (var entry in kvp.Value)
            {
                if (string.Equals(entry.Endpoint, endpoint, StringComparison.Ordinal))
                {
                    models.Add(kvp.Key);
                    break;
                }
            }
        }

        models.Sort(StringComparer.Ordinal);
        return models;
    }

    /// <summary>
    /// Returns the spec detail for one parameter of <paramref name="modelId"/> on
    /// <paramref name="endpoint"/>, or null when the model does not declare it.
    /// </summary>
    public static RunwayModelParameter? GetParameter(string modelId, string endpoint, string parameterName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(parameterName);

        foreach (var entry in Lookup(modelId))
        {
            if (string.Equals(entry.Endpoint, endpoint, StringComparison.Ordinal) &&
                entry.ParameterDetails.TryGetValue(parameterName, out var detail))
            {
                return detail;
            }
        }

        return null;
    }

    /// <summary>
    /// Returns the <c>maxItems</c> ceiling the spec sets for an array parameter (for example how many
    /// <c>referenceImages</c> the model accepts), or null when it is unbounded or not an array.
    /// </summary>
    public static int? GetMaxItems(string modelId, string endpoint, string parameterName) =>
        GetParameter(modelId, endpoint, parameterName)?.MaxItems;

    /// <summary>
    /// Returns true when items of an array parameter may carry <paramref name="itemProperty"/> — e.g.
    /// whether a model's <c>referenceImages</c> entries accept a <c>tag</c> or a <c>subject</c>.
    /// </summary>
    public static bool SupportsItemProperty(string modelId, string endpoint, string parameterName, string itemProperty)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(itemProperty);

        var detail = GetParameter(modelId, endpoint, parameterName);
        if (detail is null)
        {
            return false;
        }

        foreach (var property in detail.ItemProperties)
        {
            if (string.Equals(property, itemProperty, StringComparison.Ordinal))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Returns the enum values a parameter accepts for the given model, or an empty list when it is not
    /// enum-backed or the model does not declare it.
    /// </summary>
    public static IReadOnlyList<string> GetAllowedValues(string modelId, string endpoint, string parameterName) =>
        GetParameter(modelId, endpoint, parameterName)?.AllowedValues ?? [];

    /// <summary>
    /// Returns the enum values declared by one property of a parameter's item/variant shapes — for
    /// example the preset voice ids under <c>voice.presetId</c> on <c>text_to_speech</c>. Empty when the
    /// property is not enum-backed or the model does not declare it.
    /// </summary>
    public static IReadOnlyList<string> GetItemPropertyValues(
        string modelId,
        string endpoint,
        string parameterName,
        string itemProperty)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(itemProperty);

        return GetParameter(modelId, endpoint, parameterName)?.ItemPropertyValues
            .TryGetValue(itemProperty, out var values) == true
            ? values
            : [];
    }

    /// <summary>
    /// Returns true when the embedded spec says <paramref name="modelId"/> accepts
    /// <paramref name="parameterName"/> on <paramref name="endpoint"/> (required or optional).
    /// Unknown models return false so callers omit parameters they can't prove are supported.
    /// </summary>
    public static bool SupportsParameter(string modelId, string endpoint, string parameterName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(parameterName);

        foreach (var entry in Lookup(modelId))
        {
            if (!string.Equals(entry.Endpoint, endpoint, StringComparison.Ordinal))
            {
                continue;
            }

            foreach (var parameter in entry.Parameters)
            {
                if (string.Equals(parameter, parameterName, StringComparison.Ordinal))
                {
                    return true;
                }
            }
        }

        return false;
    }

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

    private static List<string> LoadEndpoints()
    {
        using var document = OpenSpec();
        var root = document.RootElement;
        var endpoints = new List<string>();

        if (!root.TryGetProperty("paths", out var paths) || paths.ValueKind != JsonValueKind.Object)
        {
            return endpoints;
        }

        foreach (var pathProperty in paths.EnumerateObject())
        {
            if (pathProperty.Value.ValueKind != JsonValueKind.Object ||
                !pathProperty.Value.TryGetProperty("post", out _))
            {
                continue;
            }

            endpoints.Add(NormalizeEndpointName(pathProperty.Name));
        }

        endpoints.Sort(StringComparer.Ordinal);
        return endpoints;
    }

    private static string NormalizeEndpointName(string path)
    {
        var name = path.TrimStart('/');
        return name.StartsWith("v1/", StringComparison.OrdinalIgnoreCase) ? name["v1/".Length..] : name;
    }

    private static JsonDocument OpenSpec()
    {
        var assembly = typeof(RunwayModelSchema).Assembly;
        using var stream = assembly.GetManifestResourceStream(EmbeddedSpecResource)
            ?? throw new InvalidOperationException($"Embedded resource `{EmbeddedSpecResource}` missing from Runway assembly.");
        return JsonDocument.Parse(stream, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });
    }

    private static Dictionary<string, IReadOnlyList<RunwayModelEndpoint>> LoadMap()
    {
        using var document = OpenSpec();
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

                var endpointName = NormalizeEndpointName(pathProperty.Name);

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
                    var details = new Dictionary<string, RunwayModelParameter>(StringComparer.Ordinal);
                    foreach (var prop in properties.EnumerateObject())
                    {
                        if (string.Equals(prop.Name, "model", StringComparison.Ordinal))
                        {
                            continue;
                        }

                        var isRequired = requiredSet.Contains(prop.Name);
                        if (isRequired)
                        {
                            requiredParams.Add(prop.Name);
                        }
                        else
                        {
                            optionalParams.Add(prop.Name);
                        }

                        details[prop.Name] = ReadParameterDetail(prop.Name, isRequired, Resolve(prop.Value, root), root);
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

                        list.Add(new RunwayModelEndpoint(endpointName, requiredParams, optionalParams)
                        {
                            ParameterDetails = details,
                        });
                    }
                }
            }
        }

        return ToReadOnly(result);
    }

    /// <summary>
    /// Reads enum values, the array ceiling, and the item property names for one request parameter.
    /// Array items declared as a union (<c>anyOf</c>/<c>oneOf</c>) contribute the union of their
    /// properties, so a caller sees every property some item shape accepts.
    /// </summary>
    private static RunwayModelParameter ReadParameterDetail(
        string name,
        bool required,
        JsonElement schema,
        JsonElement root)
    {
        var allowedValues = ReadEnumValues(schema);

        int? maxItems = null;
        var itemProperties = new List<string>();
        var itemPropertyValues = new Dictionary<string, IReadOnlyList<string>>(StringComparer.Ordinal);
        if (schema.ValueKind == JsonValueKind.Object)
        {
            if (schema.TryGetProperty("maxItems", out var maxItemsValue) &&
                maxItemsValue.ValueKind == JsonValueKind.Number &&
                maxItemsValue.TryGetInt32(out var parsedMaxItems))
            {
                maxItems = parsedMaxItems;
            }

            // For an array parameter the shapes live under `items`; for a parameter that is itself a union
            // of object shapes (text_to_speech `voice` is a preset id or a cloned reference clip) they are
            // the union's own variants. Both cases answer "which properties may this value carry".
            var hasItems = schema.TryGetProperty("items", out var items);
            var shapeSource = hasItems ? Resolve(items, root) : schema;
            var isUnion = schema.TryGetProperty("oneOf", out _) || schema.TryGetProperty("anyOf", out _);
            if (hasItems || isUnion)
            {
                foreach (var shape in EnumerateVariants(shapeSource, root))
                {
                    if (shape.ValueKind != JsonValueKind.Object ||
                        !shape.TryGetProperty("properties", out var itemProps) ||
                        itemProps.ValueKind != JsonValueKind.Object)
                    {
                        continue;
                    }

                    foreach (var itemProp in itemProps.EnumerateObject())
                    {
                        if (!itemProperties.Contains(itemProp.Name, StringComparer.Ordinal))
                        {
                            itemProperties.Add(itemProp.Name);
                        }

                        if (ReadEnumValues(Resolve(itemProp.Value, root)) is { Count: > 0 } values &&
                            !itemPropertyValues.ContainsKey(itemProp.Name))
                        {
                            itemPropertyValues[itemProp.Name] = values;
                        }
                    }
                }

                itemProperties.Sort(StringComparer.Ordinal);
            }
        }

        return new RunwayModelParameter(name, required, allowedValues, maxItems, itemProperties)
        {
            ItemPropertyValues = itemPropertyValues,
        };
    }

    /// <summary>Reads a schema's <c>enum</c> values, or its single <c>const</c>, as strings.</summary>
    private static List<string> ReadEnumValues(JsonElement schema)
    {
        var values = new List<string>();
        if (schema.ValueKind != JsonValueKind.Object)
        {
            return values;
        }

        if (schema.TryGetProperty("enum", out var enumArray) && enumArray.ValueKind == JsonValueKind.Array)
        {
            foreach (var value in enumArray.EnumerateArray())
            {
                if (value.ValueKind is JsonValueKind.String or JsonValueKind.Number)
                {
                    values.Add(value.ToString());
                }
            }
        }
        else if (schema.TryGetProperty("const", out var constValue) &&
                 constValue.ValueKind is JsonValueKind.String or JsonValueKind.Number)
        {
            values.Add(constValue.ToString());
        }

        return values;
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

        // `anyOf` item shapes (e.g. an aleph2 keyframe addressed by `seconds` or by `at`) each contribute
        // their own properties, so callers see every property some shape accepts.
        if (schema.TryGetProperty("anyOf", out var anyOf) && anyOf.ValueKind == JsonValueKind.Array)
        {
            foreach (var variant in anyOf.EnumerateArray())
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
