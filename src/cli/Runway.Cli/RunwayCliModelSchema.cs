using System.Text.Json;

internal sealed record RunwayCliModelEndpoint(string Endpoint, IReadOnlyList<string> Parameters);

internal static class RunwayCliModelSchema
{
    private const string EmbeddedSpecResource = "Runway.Cli.openapi.json";

    private static readonly Lazy<IReadOnlyDictionary<string, IReadOnlyList<RunwayCliModelEndpoint>>> Map = new(LoadMap);

    public static IReadOnlyList<RunwayCliModelEndpoint> Lookup(string modelId)
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

    public static IEnumerable<string> KnownModelIds() => Map.Value.Keys;

    private static IReadOnlyDictionary<string, IReadOnlyList<RunwayCliModelEndpoint>> LoadMap()
    {
        var assembly = typeof(RunwayCliModelSchema).Assembly;
        using var stream = assembly.GetManifestResourceStream(EmbeddedSpecResource)
            ?? throw new InvalidOperationException($"Embedded resource `{EmbeddedSpecResource}` missing from Runway.Cli.");
        using var document = JsonDocument.Parse(stream, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });
        var root = document.RootElement.Clone();

        var result = new Dictionary<string, List<RunwayCliModelEndpoint>>(StringComparer.OrdinalIgnoreCase);

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
                    var paramNames = new List<string>();
                    foreach (var prop in properties.EnumerateObject())
                    {
                        if (!string.Equals(prop.Name, "model", StringComparison.Ordinal))
                        {
                            paramNames.Add(prop.Name);
                        }
                    }

                    paramNames.Sort(StringComparer.Ordinal);

                    foreach (var modelId in EnumerateModelIds(modelResolved))
                    {
                        if (!result.TryGetValue(modelId, out var list))
                        {
                            list = [];
                            result[modelId] = list;
                        }

                        list.Add(new RunwayCliModelEndpoint(endpointName, paramNames));
                    }
                }
            }
        }

        return ToReadOnly(result);
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

    private static IReadOnlyDictionary<string, IReadOnlyList<RunwayCliModelEndpoint>> ToReadOnly(
        Dictionary<string, List<RunwayCliModelEndpoint>> source)
    {
        var copy = new Dictionary<string, IReadOnlyList<RunwayCliModelEndpoint>>(source.Count, StringComparer.OrdinalIgnoreCase);
        foreach (var kvp in source)
        {
            copy[kvp.Key] = kvp.Value;
        }

        return copy;
    }
}
