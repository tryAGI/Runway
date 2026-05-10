using System.Globalization;
using Runway;

internal static class RunwayCliRatioHints
{
    /// <summary>
    /// Builds a "Supported values: ... Other Runway models that DO accept '<ratio>': ... Closest accepted aspects:
    /// ..." trailer for a ratio-rejection error. Closest aspects are computed by the same aspect-distance math
    /// used in <c>RunwayCliShortVideoKeyframes.PickClosestImageRatio</c>.
    /// </summary>
    public static string BuildRejectionTrailer(
        string ratio,
        string normalizedModel,
        IReadOnlyList<string> supportedByThisModel)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ratio);
        ArgumentException.ThrowIfNullOrWhiteSpace(normalizedModel);
        ArgumentNullException.ThrowIfNull(supportedByThisModel);

        var supportedList = string.Join(", ", supportedByThisModel);

        var alternates = RunwayRatioSupport.GetSupportingModels(ratio)
            .Where(m => !string.Equals(m, normalizedModel, StringComparison.Ordinal))
            .ToArray();
        var alternateHint = alternates.Length > 0
            ? $" Other Runway models that DO accept '{ratio}': {string.Join(", ", alternates)}."
            : string.Empty;

        var closestAspects = TryGetClosestAspects(ratio, supportedByThisModel, count: 2);
        var closestHint = closestAspects.Count > 0
            ? $" Closest accepted aspects: {string.Join(", ", closestAspects)}."
            : string.Empty;

        return $"Supported values: {supportedList}.{alternateHint}{closestHint}";
    }

    /// <summary>
    /// Returns up to <paramref name="count"/> ratios from <paramref name="candidates"/> that are aspect-closest
    /// to <paramref name="target"/>, ordered by distance and then pixel area. Empty when the inputs can't be
    /// parsed (e.g. malformed strings).
    /// </summary>
    public static IReadOnlyList<string> TryGetClosestAspects(string target, IReadOnlyList<string> candidates, int count = 2)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(target);
        ArgumentNullException.ThrowIfNull(candidates);

        if (count <= 0 || candidates.Count == 0 || !TryToAspect(target, out var targetAspect))
        {
            return [];
        }

        var ranked = new List<(string Ratio, double Distance, long Area)>(candidates.Count);
        foreach (var candidate in candidates)
        {
            if (!TryToAspect(candidate, out var aspect) || !TryToArea(candidate, out var area))
            {
                continue;
            }

            ranked.Add((candidate, Math.Abs(aspect - targetAspect), area));
        }

        return ranked
            .OrderBy(c => c.Distance)
            .ThenBy(c => c.Area)
            .ThenBy(c => c.Ratio, StringComparer.Ordinal)
            .Take(count)
            .Select(c => c.Ratio)
            .ToArray();
    }

    private static bool TryToAspect(string ratio, out double aspect)
    {
        if (!TryParseRatio(ratio, out var width, out var height))
        {
            aspect = 0;
            return false;
        }

        aspect = (double)width / height;
        return true;
    }

    private static bool TryToArea(string ratio, out long area)
    {
        if (!TryParseRatio(ratio, out var width, out var height))
        {
            area = 0;
            return false;
        }

        area = (long)width * height;
        return true;
    }

    private static bool TryParseRatio(string value, out int width, out int height)
    {
        width = 0;
        height = 0;
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var parts = value.Split(':');
        return parts.Length == 2 &&
               int.TryParse(parts[0].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out width) &&
               int.TryParse(parts[1].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out height) &&
               width > 0 && height > 0;
    }
}
