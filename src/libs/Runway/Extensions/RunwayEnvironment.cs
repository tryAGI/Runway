namespace Runway;

/// <summary>
/// Helpers for loading local Runway configuration from environment variables and dotenv files.
/// </summary>
public static class RunwayEnvironment
{
    private const string DotEnvDisabledVariable = "RUNWAY_DOTENV_DISABLED";

    /// <summary>
    /// Loads environment variables from a .env file without overriding existing process variables.
    /// </summary>
    /// <param name="path">Optional explicit .env path. When omitted, the current directory and its parents are searched.</param>
    /// <returns>True when a dotenv file was found and parsed; otherwise false.</returns>
    public static bool LoadDotEnv(string? path = null)
    {
        if (Environment.GetEnvironmentVariable(DotEnvDisabledVariable) is { Length: > 0 })
        {
            return false;
        }

        var dotEnvPath = path is { Length: > 0 }
            ? Path.GetFullPath(path)
            : FindDotEnvPath();

        if (dotEnvPath is null || !File.Exists(dotEnvPath))
        {
            return false;
        }

        foreach (var line in File.ReadLines(dotEnvPath))
        {
            if (!TryParseLine(line, out var name, out var value))
            {
                continue;
            }

            if (Environment.GetEnvironmentVariable(name) is not { Length: > 0 })
            {
                Environment.SetEnvironmentVariable(name, value);
            }
        }

        return true;
    }

    /// <summary>
    /// Gets the Runway API key from process variables or a discovered .env file.
    /// </summary>
    /// <returns>The configured Runway API key, or null when none is configured.</returns>
    public static string? GetApiKey()
    {
        LoadDotEnv();

        return Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } runwayApiKey
            ? runwayApiKey
            : Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET") is { Length: > 0 } runwayMlApiSecret
                ? runwayMlApiSecret
                : null;
    }

    private static string? FindDotEnvPath()
    {
        var directory = new DirectoryInfo(Environment.CurrentDirectory);
        while (directory is not null)
        {
            var candidate = Path.Combine(directory.FullName, ".env");
            if (File.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        return null;
    }

    private static bool TryParseLine(string line, out string name, out string value)
    {
        name = string.Empty;
        value = string.Empty;

        var trimmed = line.Trim();
        if (trimmed.Length == 0 || trimmed.StartsWith('#'))
        {
            return false;
        }

        if (trimmed.StartsWith("export ", StringComparison.Ordinal))
        {
            trimmed = trimmed["export ".Length..].TrimStart();
        }

        var separatorIndex = trimmed.IndexOf('=', StringComparison.Ordinal);
        if (separatorIndex <= 0)
        {
            return false;
        }

        name = trimmed[..separatorIndex].Trim();
        if (name.Length == 0)
        {
            return false;
        }

        value = RemoveInlineComment(trimmed[(separatorIndex + 1)..].Trim());
        value = Unquote(value);
        return true;
    }

    private static string RemoveInlineComment(string value)
    {
        if (value.StartsWith('"') || value.StartsWith('\''))
        {
            return value;
        }

        var commentIndex = value.IndexOf(" #", StringComparison.Ordinal);
        return commentIndex >= 0 ? value[..commentIndex].TrimEnd() : value;
    }

    private static string Unquote(string value)
    {
        if (value.Length < 2)
        {
            return value;
        }

        if (value[0] == '"' && value[^1] == '"')
        {
            return value[1..^1]
                .Replace("\\n", "\n", StringComparison.Ordinal)
                .Replace("\\r", "\r", StringComparison.Ordinal)
                .Replace("\\t", "\t", StringComparison.Ordinal)
                .Replace("\\\"", "\"", StringComparison.Ordinal)
                .Replace("\\\\", "\\", StringComparison.Ordinal);
        }

        return value[0] == '\'' && value[^1] == '\''
            ? value[1..^1]
            : value;
    }
}
