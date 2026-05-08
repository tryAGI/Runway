using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

internal sealed class RunwayCliWebProductDossier
{
    public string Url { get; set; } = string.Empty;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public string? SiteName { get; set; }

    public string? Type { get; set; }

    public List<string> AdditionalImages { get; set; } = [];
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(RunwayCliWebProductDossier))]
internal sealed partial class RunwayCliMarketingStudioJsonSerializerContext : JsonSerializerContext
{
}

internal static partial class RunwayCliMarketingStudio
{
    public static RunwayCliWebProductDossier ParseProductDossier(string url, string html)
    {
        var dossier = new RunwayCliWebProductDossier { Url = url };

        dossier.Title = ReadMeta(html, "og:title") ?? ReadMeta(html, "twitter:title") ?? ReadTitle(html);
        dossier.Description = ReadMeta(html, "og:description") ?? ReadMeta(html, "twitter:description") ?? ReadMeta(html, "description");
        dossier.Image = ReadMeta(html, "og:image") ?? ReadMeta(html, "twitter:image");
        dossier.SiteName = ReadMeta(html, "og:site_name");
        dossier.Type = ReadMeta(html, "og:type");

        foreach (Match match in MetaImageRegex().Matches(html))
        {
            var value = match.Groups["value"].Value;
            if (!string.IsNullOrWhiteSpace(value)
                && !string.Equals(value, dossier.Image, StringComparison.Ordinal)
                && !dossier.AdditionalImages.Contains(value, StringComparer.Ordinal))
            {
                dossier.AdditionalImages.Add(value);
            }
        }

        return dossier;
    }

    public static string ToJson(RunwayCliWebProductDossier dossier)
    {
        return JsonSerializer.Serialize(dossier, RunwayCliMarketingStudioJsonSerializerContext.Default.RunwayCliWebProductDossier);
    }

    private static string? ReadMeta(string html, string key)
    {
        foreach (Match match in MetaPropertyRegex().Matches(html))
        {
            if (string.Equals(match.Groups["key"].Value, key, StringComparison.OrdinalIgnoreCase))
            {
                return match.Groups["value"].Value;
            }
        }

        foreach (Match match in MetaNameRegex().Matches(html))
        {
            if (string.Equals(match.Groups["key"].Value, key, StringComparison.OrdinalIgnoreCase))
            {
                return match.Groups["value"].Value;
            }
        }

        return null;
    }

    private static string? ReadTitle(string html)
    {
        var match = TitleRegex().Match(html);
        return match.Success ? match.Groups["value"].Value.Trim() : null;
    }

    [GeneratedRegex("<meta[^>]+property=[\"'](?<key>[^\"']+)[\"'][^>]+content=[\"'](?<value>[^\"']+)[\"']", RegexOptions.IgnoreCase)]
    private static partial Regex MetaPropertyRegex();

    [GeneratedRegex("<meta[^>]+name=[\"'](?<key>[^\"']+)[\"'][^>]+content=[\"'](?<value>[^\"']+)[\"']", RegexOptions.IgnoreCase)]
    private static partial Regex MetaNameRegex();

    [GeneratedRegex("<title[^>]*>(?<value>[^<]*)</title>", RegexOptions.IgnoreCase)]
    private static partial Regex TitleRegex();

    [GeneratedRegex("<meta[^>]+(?:property|name)=[\"']og:image(?::secure_url)?[\"'][^>]+content=[\"'](?<value>[^\"']+)[\"']", RegexOptions.IgnoreCase)]
    private static partial Regex MetaImageRegex();
}
