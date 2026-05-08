using System.Text.Json;
using System.Text.Json.Serialization;

internal sealed class RunwayCliCredentials
{
    public string? ApiKey { get; set; }

    public DateTimeOffset? UpdatedAt { get; set; }
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(RunwayCliCredentials))]
internal sealed partial class RunwayCliCredentialsJsonSerializerContext : JsonSerializerContext
{
}

internal static class RunwayCliAuth
{
    public static string GetCredentialsDirectory()
    {
        var home = Environment.GetEnvironmentVariable("RUNWAY_CLI_HOME") is { Length: > 0 } overrideHome
            ? overrideHome
            : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(home, ".runway-cli");
    }

    public static string GetCredentialsFile() => Path.Combine(GetCredentialsDirectory(), "credentials.json");

    public static string? Read()
    {
        var path = GetCredentialsFile();
        if (!File.Exists(path))
        {
            return null;
        }

        try
        {
            var json = File.ReadAllText(path);
            var creds = JsonSerializer.Deserialize(json, RunwayCliCredentialsJsonSerializerContext.Default.RunwayCliCredentials);
            return creds?.ApiKey is { Length: > 0 } apiKey ? apiKey : null;
        }
        catch (JsonException)
        {
            return null;
        }
    }

    public static void Write(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentException("API key cannot be empty.", nameof(apiKey));
        }

        var dir = GetCredentialsDirectory();
        Directory.CreateDirectory(dir);
        var path = GetCredentialsFile();
        var creds = new RunwayCliCredentials
        {
            ApiKey = apiKey.Trim(),
            UpdatedAt = DateTimeOffset.UtcNow,
        };
        var json = JsonSerializer.Serialize(creds, RunwayCliCredentialsJsonSerializerContext.Default.RunwayCliCredentials);
        File.WriteAllText(path, json);

        if (!OperatingSystem.IsWindows())
        {
            try
            {
                File.SetUnixFileMode(path, UnixFileMode.UserRead | UnixFileMode.UserWrite);
            }
            catch (PlatformNotSupportedException)
            {
            }
        }
    }

    public static bool Clear()
    {
        var path = GetCredentialsFile();
        if (!File.Exists(path))
        {
            return false;
        }

        File.Delete(path);
        return true;
    }

    public static string Mask(string apiKey)
    {
        if (string.IsNullOrEmpty(apiKey))
        {
            return string.Empty;
        }

        if (apiKey.Length <= 8)
        {
            return new string('*', apiKey.Length);
        }

        return string.Concat(apiKey.AsSpan(0, 4), new string('*', apiKey.Length - 8), apiKey.AsSpan(apiKey.Length - 4));
    }
}
