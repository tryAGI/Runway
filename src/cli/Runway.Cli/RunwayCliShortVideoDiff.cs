using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

internal sealed record RunwayCliShortVideoFieldDiff(
    string Field,
    string? ValueA,
    string? ValueB);

internal sealed record RunwayCliShortVideoShotDiff(
    int Index,
    string? TitleA,
    string? TitleB,
    IReadOnlyList<RunwayCliShortVideoFieldDiff> Fields);

internal sealed record RunwayCliShortVideoPlanDiff(
    IReadOnlyList<RunwayCliShortVideoFieldDiff> TopLevel,
    IReadOnlyList<RunwayCliShortVideoShotDiff> Shots,
    int ShotCountA,
    int ShotCountB)
{
    public bool HasChanges => TopLevel.Count > 0 || Shots.Count > 0;
}

internal static class RunwayCliShortVideoDiff
{
    private static readonly string[] LongFields = ["Beat", "KeyframePrompt", "VideoPrompt", "Scenario", "SourceText", "Style"];

    public static RunwayCliShortVideoPlanDiff Compute(RunwayShortVideoPlan a, RunwayShortVideoPlan b)
    {
        ArgumentNullException.ThrowIfNull(a);
        ArgumentNullException.ThrowIfNull(b);

        var topLevel = new List<RunwayCliShortVideoFieldDiff>();
        AppendIfDifferent(topLevel, "SourceText", a.SourceText, b.SourceText);
        AppendIfDifferent(topLevel, "Scenario", a.Scenario, b.Scenario);
        AppendIfDifferent(topLevel, "Style", a.Style, b.Style);
        AppendIfDifferent(topLevel, "Model", a.Model, b.Model);
        AppendIfDifferent(topLevel, "Ratio", a.Ratio, b.Ratio);
        AppendIfDifferent(
            topLevel,
            "ShotDurationSeconds",
            a.ShotDurationSeconds.ToString(CultureInfo.InvariantCulture),
            b.ShotDurationSeconds.ToString(CultureInfo.InvariantCulture));

        var shotsByIndexA = a.Shots.ToDictionary(shot => shot.Index);
        var shotsByIndexB = b.Shots.ToDictionary(shot => shot.Index);
        var allIndexes = shotsByIndexA.Keys.Union(shotsByIndexB.Keys).OrderBy(i => i);

        var shotDiffs = new List<RunwayCliShortVideoShotDiff>();
        foreach (var index in allIndexes)
        {
            shotsByIndexA.TryGetValue(index, out var shotA);
            shotsByIndexB.TryGetValue(index, out var shotB);

            var fieldDiffs = new List<RunwayCliShortVideoFieldDiff>();
            AppendIfDifferent(fieldDiffs, "Title", shotA?.Title, shotB?.Title);
            AppendIfDifferent(fieldDiffs, "Beat", shotA?.Beat, shotB?.Beat);
            AppendIfDifferent(fieldDiffs, "KeyframePrompt", shotA?.KeyframePrompt, shotB?.KeyframePrompt);
            AppendIfDifferent(fieldDiffs, "VideoPrompt", shotA?.VideoPrompt, shotB?.VideoPrompt);

            if (fieldDiffs.Count > 0 || shotA is null || shotB is null)
            {
                shotDiffs.Add(new RunwayCliShortVideoShotDiff(
                    Index: index,
                    TitleA: shotA?.Title,
                    TitleB: shotB?.Title,
                    Fields: fieldDiffs));
            }
        }

        return new RunwayCliShortVideoPlanDiff(
            TopLevel: topLevel,
            Shots: shotDiffs,
            ShotCountA: a.Shots.Count,
            ShotCountB: b.Shots.Count);
    }

    public static string RenderText(RunwayCliShortVideoPlanDiff diff)
    {
        ArgumentNullException.ThrowIfNull(diff);
        var builder = new StringBuilder();

        if (!diff.HasChanges && diff.ShotCountA == diff.ShotCountB)
        {
            builder.AppendLine("Plans are identical.");
            return builder.ToString();
        }

        if (diff.TopLevel.Count > 0)
        {
            builder.AppendLine("=== Top-level changes ===");
            foreach (var field in diff.TopLevel)
            {
                AppendField(builder, field, indent: "  ");
            }

            builder.AppendLine();
        }

        if (diff.ShotCountA != diff.ShotCountB)
        {
            builder.Append("=== Shot count: ").Append(diff.ShotCountA).Append(" -> ").Append(diff.ShotCountB).AppendLine(" ===");
            builder.AppendLine();
        }

        foreach (var shot in diff.Shots)
        {
            var titleA = shot.TitleA ?? "<NEW>";
            var titleB = shot.TitleB ?? "<REMOVED>";
            builder.Append("=== Shot ").Append(shot.Index).Append(": ").Append(titleA).Append(" -> ").Append(titleB).AppendLine(" ===");
            foreach (var field in shot.Fields)
            {
                AppendField(builder, field, indent: "  ");
            }

            if (shot.Fields.Count == 0)
            {
                builder.AppendLine(shot.TitleA is null
                    ? "  (shot added)"
                    : "  (shot removed)");
            }

            builder.AppendLine();
        }

        return builder.ToString().TrimEnd() + Environment.NewLine;
    }

    public static string RenderJson(RunwayCliShortVideoPlanDiff diff)
    {
        ArgumentNullException.ThrowIfNull(diff);
        var root = new JsonObject
        {
            ["shotCountA"] = diff.ShotCountA,
            ["shotCountB"] = diff.ShotCountB,
            ["topLevel"] = new JsonArray(diff.TopLevel
                .Select(field => (JsonNode)new JsonObject
                {
                    ["field"] = field.Field,
                    ["a"] = field.ValueA,
                    ["b"] = field.ValueB,
                })
                .ToArray()),
            ["shots"] = new JsonArray(diff.Shots
                .Select(shot => (JsonNode)new JsonObject
                {
                    ["index"] = shot.Index,
                    ["titleA"] = shot.TitleA,
                    ["titleB"] = shot.TitleB,
                    ["fields"] = new JsonArray(shot.Fields
                        .Select(field => (JsonNode)new JsonObject
                        {
                            ["field"] = field.Field,
                            ["a"] = field.ValueA,
                            ["b"] = field.ValueB,
                        })
                        .ToArray()),
                })
                .ToArray()),
        };

        return JsonSerializer.Serialize(root, new JsonSerializerOptions { WriteIndented = true });
    }

    private static void AppendIfDifferent(
        List<RunwayCliShortVideoFieldDiff> diffs,
        string field,
        string? a,
        string? b)
    {
        if (string.Equals(a, b, StringComparison.Ordinal))
        {
            return;
        }

        diffs.Add(new RunwayCliShortVideoFieldDiff(field, a, b));
    }

    private static void AppendField(StringBuilder builder, RunwayCliShortVideoFieldDiff field, string indent)
    {
        var isLong = LongFields.Contains(field.Field, StringComparer.Ordinal);
        var aValue = field.ValueA ?? "<unset>";
        var bValue = field.ValueB ?? "<unset>";

        if (!isLong && aValue.Length <= 80 && bValue.Length <= 80 && !aValue.Contains('\n') && !bValue.Contains('\n'))
        {
            builder.Append(indent).Append(field.Field).Append(": ").Append(aValue).Append(" -> ").AppendLine(bValue);
            return;
        }

        builder.Append(indent).Append(field.Field).AppendLine(":");
        builder.Append(indent).Append("  A: ").AppendLine(aValue);
        builder.Append(indent).Append("  B: ").AppendLine(bValue);
    }
}
