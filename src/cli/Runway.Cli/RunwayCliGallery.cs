using System.Net;
using System.Text;

internal static class RunwayCliGallery
{
    public static async Task<string> CreateAsync(
        string? input,
        string? output,
        bool recursive,
        string? title,
        CancellationToken cancellationToken)
    {
        var inputDirectory = Path.GetFullPath(string.IsNullOrWhiteSpace(input) ? Environment.CurrentDirectory : input);
        if (!Directory.Exists(inputDirectory))
        {
            throw new DirectoryNotFoundException($"Gallery input directory was not found: {inputDirectory}");
        }

        var outputPath = Path.GetFullPath(string.IsNullOrWhiteSpace(output)
            ? Path.Combine(inputDirectory, "runway-gallery.html")
            : output);
        var outputDirectory = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrWhiteSpace(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        var videos = Directory.EnumerateFiles(
                inputDirectory,
                "*.mp4",
                recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
            .OrderByDescending(File.GetLastWriteTimeUtc)
            .Select(path => CreateItem(inputDirectory, path))
            .ToList();

        await File.WriteAllTextAsync(
            outputPath,
            CreateHtml(title, inputDirectory, videos),
            new UTF8Encoding(encoderShouldEmitUTF8Identifier: false),
            cancellationToken).ConfigureAwait(false);

        return outputPath;
    }

    private static RunwayCliGalleryItem CreateItem(string inputDirectory, string videoPath)
    {
        var planPath = Path.Combine(
            Path.GetDirectoryName(videoPath) ?? inputDirectory,
            $"{Path.GetFileNameWithoutExtension(videoPath)}.plan.json");

        return new RunwayCliGalleryItem(
            Path.GetFileName(videoPath),
            ToHref(inputDirectory, videoPath),
            File.Exists(planPath) ? ToHref(inputDirectory, planPath) : null,
            new FileInfo(videoPath).Length,
            File.GetLastWriteTime(videoPath));
    }

    private static string CreateHtml(
        string? title,
        string inputDirectory,
        IReadOnlyList<RunwayCliGalleryItem> videos)
    {
        var resolvedTitle = string.IsNullOrWhiteSpace(title) ? "Runway Gallery" : title.Trim();
        var builder = new StringBuilder();
        builder.AppendLine("<!doctype html>");
        builder.AppendLine("<html lang=\"en\">");
        builder.AppendLine("<head>");
        builder.AppendLine("  <meta charset=\"utf-8\">");
        builder.AppendLine("  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
        builder.AppendLine($"  <title>{Html(resolvedTitle)}</title>");
        builder.AppendLine("  <style>");
        builder.AppendLine("    :root{color-scheme:light dark;font-family:Inter,system-ui,-apple-system,BlinkMacSystemFont,\"Segoe UI\",sans-serif;}");
        builder.AppendLine("    body{margin:0;padding:32px;background:#f7f8fa;color:#1f2328;}");
        builder.AppendLine("    h1{font-size:28px;margin:0 0 4px;} p{margin:0 0 24px;color:#656d76;}");
        builder.AppendLine("    .grid{display:grid;grid-template-columns:repeat(auto-fill,minmax(280px,1fr));gap:18px;}");
        builder.AppendLine("    .item{background:#fff;border:1px solid #d8dee4;border-radius:8px;padding:12px;box-shadow:0 1px 2px rgba(31,35,40,.06);}");
        builder.AppendLine("    video{width:100%;border-radius:6px;background:#111;display:block;}");
        builder.AppendLine("    .name{font-weight:650;margin-top:10px;overflow-wrap:anywhere;}.meta{font-size:13px;color:#656d76;margin-top:4px;}");
        builder.AppendLine("    a{color:#0969da;text-decoration:none;} a:hover{text-decoration:underline;}");
        builder.AppendLine("    @media (prefers-color-scheme:dark){body{background:#0d1117;color:#e6edf3}.item{background:#161b22;border-color:#30363d}.meta,p{color:#8b949e}a{color:#58a6ff}}");
        builder.AppendLine("  </style>");
        builder.AppendLine("</head>");
        builder.AppendLine("<body>");
        builder.AppendLine($"  <h1>{Html(resolvedTitle)}</h1>");
        builder.AppendLine($"  <p>{videos.Count} video{(videos.Count == 1 ? string.Empty : "s")} from {Html(inputDirectory)}</p>");
        builder.AppendLine("  <main class=\"grid\">");

        foreach (var video in videos)
        {
            builder.AppendLine("    <section class=\"item\">");
            builder.AppendLine($"      <video src=\"{Html(video.VideoHref)}\" controls preload=\"metadata\"></video>");
            builder.AppendLine($"      <div class=\"name\"><a href=\"{Html(video.VideoHref)}\">{Html(video.Name)}</a></div>");
            builder.AppendLine($"      <div class=\"meta\">{FormatBytes(video.Size)} &middot; {Html(video.Modified.ToString("yyyy-MM-dd HH:mm"))}</div>");
            if (video.PlanHref is { Length: > 0 } planHref)
            {
                builder.AppendLine($"      <div class=\"meta\"><a href=\"{Html(planHref)}\">View plan JSON</a></div>");
            }

            builder.AppendLine("    </section>");
        }

        builder.AppendLine("  </main>");
        builder.AppendLine("</body>");
        builder.AppendLine("</html>");
        return builder.ToString();
    }

    private static string ToHref(string inputDirectory, string path)
    {
        var relative = Path.GetRelativePath(inputDirectory, path)
            .Replace(Path.DirectorySeparatorChar, '/')
            .Replace(Path.AltDirectorySeparatorChar, '/');
        return string.Join('/', relative.Split('/').Select(Uri.EscapeDataString));
    }

    private static string FormatBytes(long bytes)
    {
        string[] units = ["B", "KB", "MB", "GB"];
        var value = (double)bytes;
        var unit = 0;
        while (value >= 1024 && unit < units.Length - 1)
        {
            value /= 1024;
            unit++;
        }

        return $"{value:0.#} {units[unit]}";
    }

    private static string Html(string value)
    {
        return WebUtility.HtmlEncode(value);
    }
}

internal sealed record RunwayCliGalleryItem(
    string Name,
    string VideoHref,
    string? PlanHref,
    long Size,
    DateTime Modified);
