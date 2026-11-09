using System.Text.Json;
using Runway;

/// <summary>
/// Validates a raw JSON request body against the OpenAPI spec embedded in the SDK, for the paths that
/// bypass the friendly flags: the curated commands' <c>--json</c> escape hatch and the generated
/// <c>runway api …</c> group, which only ever takes a whole body.
///
/// <para>
/// This exists for the same reason the flag-level checks do: the generated converters read an unknown
/// enum value as <c>ToEnum(value) ?? default</c>, so a typo inside a posted body silently renders with a
/// different setting. A CI step that posts an exact body is exactly where that is hardest to notice.
/// </para>
///
/// <para>
/// The endpoint is inferred from the body's own <c>model</c>, so no command-name mapping is needed and
/// the checks keep working when the generated command surface is regenerated. A value is reported only
/// when it is invalid for <em>every</em> endpoint that accepts that model, so an ambiguous model such as
/// <c>veo3.1</c> (text-to-video and image-to-video) can never produce a false positive. Unknown models
/// pass through untouched, so a body for a model the spec has not described yet is never blocked.
/// </para>
/// </summary>
internal static class RunwayCliJsonBodyValidator
{
    /// <summary>Properties whose accepted values live one level down, on a variant shape.</summary>
    private static readonly (string Parameter, string Property)[] NestedEnums =
    [
        ("voice", "presetId"),
        ("avatar", "presetId"),
        ("media", "type"),
    ];

    /// <summary>
    /// Returns one message per spec violation found in <paramref name="json"/>, or an empty list when the
    /// body is acceptable, unparseable (the deserializer will report that better), or describes a model
    /// the spec does not know.
    /// </summary>
    public static IReadOnlyList<string> FindViolations(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        JsonElement root;
        JsonDocument document;
        try
        {
            document = JsonDocument.Parse(json, new JsonDocumentOptions { CommentHandling = JsonCommentHandling.Skip });
            root = document.RootElement;
        }
        catch (JsonException)
        {
            return [];
        }

        using (document)
        {
            if (root.ValueKind != JsonValueKind.Object ||
                !root.TryGetProperty("model", out var modelElement) ||
                modelElement.ValueKind != JsonValueKind.String ||
                modelElement.GetString() is not { Length: > 0 } model)
            {
                return [];
            }

            var endpoints = RunwayModelSchema.Lookup(model)
                .Select(entry => entry.Endpoint)
                .Distinct(StringComparer.Ordinal)
                .ToList();
            if (endpoints.Count == 0)
            {
                return [];
            }

            var violations = new List<string>();
            foreach (var property in root.EnumerateObject())
            {
                if (string.Equals(property.Name, "model", StringComparison.Ordinal))
                {
                    continue;
                }

                CheckTopLevel(model, endpoints, property, violations);
                CheckNested(model, endpoints, property, violations);
            }

            return violations;
        }
    }

    /// <summary>Throws with every violation at once, so a CI run does not fix them one per attempt.</summary>
    public static void EnsureValid(string? json)
    {
        if (FindViolations(json) is { Count: > 0 } violations)
        {
            throw new ArgumentException(
                $"The request body does not match the Runway OpenAPI spec:{Environment.NewLine}  " +
                string.Join(Environment.NewLine + "  ", violations));
        }
    }

    private static void CheckTopLevel(
        string model,
        List<string> endpoints,
        JsonProperty property,
        List<string> violations)
    {
        if (RenderScalar(property.Value) is not { } value)
        {
            return;
        }

        var accepted = new List<string>();
        var declaredAnywhere = false;
        foreach (var endpoint in endpoints)
        {
            var allowed = RunwayModelSchema.GetAllowedValues(model, endpoint, property.Name);
            if (allowed.Count == 0)
            {
                continue;
            }

            declaredAnywhere = true;
            if (allowed.Contains(value, StringComparer.OrdinalIgnoreCase))
            {
                return;
            }

            foreach (var option in allowed)
            {
                if (!accepted.Contains(option, StringComparer.Ordinal))
                {
                    accepted.Add(option);
                }
            }
        }

        if (declaredAnywhere)
        {
            violations.Add($"`{property.Name}`: '{value}' is not accepted by {model}. Accepted values: {string.Join(", ", accepted)}.");
        }
    }

    private static void CheckNested(
        string model,
        List<string> endpoints,
        JsonProperty property,
        List<string> violations)
    {
        foreach (var (parameter, nestedProperty) in NestedEnums)
        {
            if (!string.Equals(property.Name, parameter, StringComparison.Ordinal) ||
                property.Value.ValueKind != JsonValueKind.Object ||
                !property.Value.TryGetProperty(nestedProperty, out var nested) ||
                RenderScalar(nested) is not { } value)
            {
                continue;
            }

            var accepted = new List<string>();
            var declaredAnywhere = false;
            foreach (var endpoint in endpoints)
            {
                var allowed = RunwayModelSchema.GetItemPropertyValues(model, endpoint, parameter, nestedProperty);
                if (allowed.Count == 0)
                {
                    continue;
                }

                declaredAnywhere = true;
                if (allowed.Contains(value, StringComparer.OrdinalIgnoreCase))
                {
                    return;
                }

                foreach (var option in allowed)
                {
                    if (!accepted.Contains(option, StringComparer.Ordinal))
                    {
                        accepted.Add(option);
                    }
                }
            }

            if (declaredAnywhere)
            {
                violations.Add(
                    $"`{parameter}.{nestedProperty}`: '{value}' is not accepted by {model}. Accepted values: {string.Join(", ", accepted)}.");
            }
        }
    }

    /// <summary>Renders a scalar the way the spec writes enum values, or null for anything else.</summary>
    private static string? RenderScalar(JsonElement element) => element.ValueKind switch
    {
        JsonValueKind.String => element.GetString(),
        JsonValueKind.Number => element.ToString(),
        _ => null,
    };
}
