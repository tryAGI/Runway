using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

internal sealed class RunwayCliSoulIdEntry
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Variant { get; set; } = "soul-2";

    public DateTimeOffset CreatedAt { get; set; }

    public string Status { get; set; } = "ready";

    public List<string> Photos { get; set; } = [];
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(RunwayCliSoulIdEntry))]
[JsonSerializable(typeof(List<RunwayCliSoulIdEntry>))]
internal sealed partial class RunwayCliSoulIdJsonSerializerContext : JsonSerializerContext
{
}

internal static class RunwayCliSoulId
{
    public const string DefaultVariant = "soul-2";

    private static readonly string[] SupportedVariants = ["soul-2", "soul-cinematic"];

    public static string GetRegistryRoot()
    {
        var home = Environment.GetEnvironmentVariable("RUNWAY_CLI_HOME") is { Length: > 0 } overrideHome
            ? overrideHome
            : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(home, ".runway-cli", "soul-ids");
    }

    public static RunwayCliSoulIdEntry Create(string name, IReadOnlyList<string> photoPaths, string? variant, string? id = null)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("--name is required.", nameof(name));
        }

        if (photoPaths.Count < 5 || photoPaths.Count > 20)
        {
            throw new ArgumentException(
                $"Provide between 5 and 20 reference photos (got {photoPaths.Count.ToString(CultureInfo.InvariantCulture)}).",
                nameof(photoPaths));
        }

        var resolvedVariant = NormalizeVariant(variant);
        var resolvedId = string.IsNullOrWhiteSpace(id)
            ? Guid.NewGuid().ToString("N")[..12]
            : id.Trim();

        var registryRoot = GetRegistryRoot();
        var entryDir = Path.Combine(registryRoot, resolvedId);
        if (Directory.Exists(entryDir))
        {
            throw new InvalidOperationException($"Soul-id `{resolvedId}` already exists at {entryDir}.");
        }

        Directory.CreateDirectory(entryDir);
        var copiedPhotos = new List<string>(photoPaths.Count);
        for (var index = 0; index < photoPaths.Count; index++)
        {
            var source = photoPaths[index];
            if (!File.Exists(source))
            {
                throw new FileNotFoundException($"Reference photo not found: {source}", source);
            }

            var ext = Path.GetExtension(source);
            var fileName = string.Create(CultureInfo.InvariantCulture, $"photo-{index + 1:00}{ext}");
            var dest = Path.Combine(entryDir, fileName);
            File.Copy(source, dest, overwrite: false);
            copiedPhotos.Add(dest);
        }

        var entry = new RunwayCliSoulIdEntry
        {
            Id = resolvedId,
            Name = name.Trim(),
            Variant = resolvedVariant,
            CreatedAt = DateTimeOffset.UtcNow,
            Status = "ready",
            Photos = copiedPhotos,
        };

        WriteMetadata(entry);
        return entry;
    }

    public static IReadOnlyList<RunwayCliSoulIdEntry> List()
    {
        var registryRoot = GetRegistryRoot();
        if (!Directory.Exists(registryRoot))
        {
            return [];
        }

        var entries = new List<RunwayCliSoulIdEntry>();
        foreach (var dir in Directory.EnumerateDirectories(registryRoot))
        {
            if (TryReadMetadata(dir, out var entry))
            {
                entries.Add(entry);
            }
        }

        entries.Sort(static (a, b) => b.CreatedAt.CompareTo(a.CreatedAt));
        return entries;
    }

    public static RunwayCliSoulIdEntry? Get(string id)
    {
        var dir = Path.Combine(GetRegistryRoot(), id);
        return TryReadMetadata(dir, out var entry) ? entry : null;
    }

    public static bool Delete(string id)
    {
        var dir = Path.Combine(GetRegistryRoot(), id);
        if (!Directory.Exists(dir))
        {
            return false;
        }

        Directory.Delete(dir, recursive: true);
        return true;
    }

    public static IReadOnlyList<string> ResolvePhotos(string id)
    {
        return Get(id)?.Photos ?? throw new ArgumentException($"Soul-id `{id}` not found in {GetRegistryRoot()}.");
    }

    public static string ToJson(RunwayCliSoulIdEntry entry)
    {
        return JsonSerializer.Serialize(entry, RunwayCliSoulIdJsonSerializerContext.Default.RunwayCliSoulIdEntry);
    }

    public static string ToJson(IReadOnlyList<RunwayCliSoulIdEntry> entries)
    {
        return JsonSerializer.Serialize(entries.ToList(), RunwayCliSoulIdJsonSerializerContext.Default.ListRunwayCliSoulIdEntry);
    }

    private static string NormalizeVariant(string? variant)
    {
        var normalized = (variant ?? DefaultVariant).Trim().ToLowerInvariant().Replace('_', '-');
        foreach (var supported in SupportedVariants)
        {
            if (string.Equals(normalized, supported, StringComparison.Ordinal))
            {
                return supported;
            }
        }

        throw new ArgumentException($"Unsupported soul-id variant `{variant}`. Supported: {string.Join(", ", SupportedVariants)}.");
    }

    private static void WriteMetadata(RunwayCliSoulIdEntry entry)
    {
        var dir = Path.Combine(GetRegistryRoot(), entry.Id);
        Directory.CreateDirectory(dir);
        var json = JsonSerializer.Serialize(entry, RunwayCliSoulIdJsonSerializerContext.Default.RunwayCliSoulIdEntry);
        File.WriteAllText(Path.Combine(dir, "metadata.json"), json);
    }

    private static bool TryReadMetadata(string dir, out RunwayCliSoulIdEntry entry)
    {
        entry = new RunwayCliSoulIdEntry();
        var metadataPath = Path.Combine(dir, "metadata.json");
        if (!File.Exists(metadataPath))
        {
            return false;
        }

        try
        {
            var json = File.ReadAllText(metadataPath);
            var deserialized = JsonSerializer.Deserialize(json, RunwayCliSoulIdJsonSerializerContext.Default.RunwayCliSoulIdEntry);
            if (deserialized is null)
            {
                return false;
            }

            entry = deserialized;
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
