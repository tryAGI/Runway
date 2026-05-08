using System.Text.RegularExpressions;

internal static class RunwayCliNaming
{
    public static string SanitizeName(string name)
    {
        var trimmed = name.Trim();
        if (trimmed.Length == 0)
        {
            throw new ArgumentException("Run name cannot be empty.", nameof(name));
        }

        foreach (var invalid in Path.GetInvalidFileNameChars())
        {
            if (trimmed.Contains(invalid))
            {
                throw new ArgumentException($"Run name contains an invalid character: '{invalid}'.", nameof(name));
            }
        }

        return trimmed;
    }

    public static string ComputeNextNameWithPrefix(string stemPrefix, string namePrefix, string scanDirectory)
    {
        if (stemPrefix is null)
        {
            throw new ArgumentNullException(nameof(stemPrefix));
        }

        var sanitized = SanitizeName(namePrefix);

        if (!Directory.Exists(scanDirectory))
        {
            return $"{sanitized}1";
        }

        var pattern = new Regex(
            $@"^{Regex.Escape(stemPrefix)}{Regex.Escape(sanitized)}(\d+)(?:[^\d].*|$)",
            RegexOptions.IgnoreCase | RegexOptions.CultureInvariant,
            TimeSpan.FromMilliseconds(250));

        var maxN = 0;
        foreach (var entry in Directory.EnumerateFileSystemEntries(scanDirectory))
        {
            var entryName = Path.GetFileName(entry);
            var match = pattern.Match(entryName);
            if (match.Success && int.TryParse(match.Groups[1].Value, System.Globalization.CultureInfo.InvariantCulture, out var n) && n > maxN)
            {
                maxN = n;
            }
        }

        return $"{sanitized}{maxN + 1}";
    }

    public static string ResolveAutoNameScanDirectory(string? output)
    {
        if (string.IsNullOrWhiteSpace(output))
        {
            return Environment.CurrentDirectory;
        }

        var fullOutput = Path.GetFullPath(output);
        var looksLikeDirectory =
            output.EndsWith(Path.DirectorySeparatorChar) ||
            output.EndsWith(Path.AltDirectorySeparatorChar) ||
            Directory.Exists(fullOutput) ||
            string.IsNullOrWhiteSpace(Path.GetExtension(fullOutput));

        return looksLikeDirectory
            ? fullOutput
            : Path.GetDirectoryName(fullOutput) ?? Environment.CurrentDirectory;
    }
}
