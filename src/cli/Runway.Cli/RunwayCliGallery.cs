using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;

internal static class RunwayCliGallery
{
    public static async Task<string> CreateAsync(
        string? input,
        string? output,
        bool recursive,
        string? title,
        string? metadata,
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

        string html;
        if (!string.IsNullOrWhiteSpace(metadata))
        {
            var plan = await ReadPlanAsync(metadata, cancellationToken).ConfigureAwait(false);
            var tiles = plan.Shots
                .Select(shot => CreatePairedItem(inputDirectory, plan, shot))
                .ToList();
            html = CreatePairedHtml(title, plan, inputDirectory, tiles);
        }
        else
        {
            var videos = Directory.EnumerateFiles(
                    inputDirectory,
                    "*.mp4",
                    recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                .OrderByDescending(File.GetLastWriteTimeUtc)
                .Select(path => CreateItem(inputDirectory, path))
                .ToList();
            html = CreateHtml(title, inputDirectory, videos);
        }

        await File.WriteAllTextAsync(
            outputPath,
            html,
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

    private static async Task<RunwayCliGalleryPlan> ReadPlanAsync(string path, CancellationToken cancellationToken)
    {
        var fullPath = Path.GetFullPath(path);
        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Gallery metadata plan was not found: {fullPath}", fullPath);
        }

        await using var stream = File.OpenRead(fullPath);
        using var document = await JsonDocument.ParseAsync(stream, cancellationToken: cancellationToken).ConfigureAwait(false);
        return RunwayCliGalleryPlan.FromJson(document.RootElement);
    }

    private static RunwayCliGalleryPairedItem CreatePairedItem(
        string inputDirectory,
        RunwayCliGalleryPlan plan,
        RunwayCliGalleryShot shot)
    {
        var keyframePath = TryFindShotFile(inputDirectory, shot, ["png", "jpg", "jpeg", "webp"], "keyframe", "keyframes");
        var videoPath = TryFindShotFile(inputDirectory, shot, ["mp4", "mov", "webm"], "shot", "shots");

        return new RunwayCliGalleryPairedItem(
            Shot: shot,
            KeyframeHref: keyframePath is null ? null : ToHref(inputDirectory, keyframePath),
            KeyframeSize: keyframePath is null ? null : new FileInfo(keyframePath).Length,
            VideoHref: videoPath is null ? null : ToHref(inputDirectory, videoPath),
            VideoSize: videoPath is null ? null : new FileInfo(videoPath).Length,
            VideoModified: videoPath is null ? null : File.GetLastWriteTime(videoPath),
            ImageModel: shot.ImageModel ?? plan.ImageModel ?? plan.Model,
            VideoModel: shot.VideoModel ?? plan.VideoModel ?? plan.Model,
            ImageRatio: shot.ImageRatio ?? plan.ImageRatio ?? plan.Ratio,
            VideoRatio: shot.VideoRatio ?? plan.VideoRatio ?? plan.Ratio,
            DurationSeconds: shot.DurationSeconds ?? plan.ShotDurationSeconds);
    }

    private static string? TryFindShotFile(
        string inputDirectory,
        RunwayCliGalleryShot shot,
        IReadOnlyList<string> extensions,
        string indexedPrefix,
        string subdirectory)
    {
        var candidates = new List<string>();
        if (!string.IsNullOrWhiteSpace(shot.Id))
        {
            candidates.Add(Path.Combine(subdirectory, shot.Id));
            candidates.Add(shot.Id);
        }

        if (shot.Index is { } idx)
        {
            var indexed = string.Create(CultureInfo.InvariantCulture, $"{indexedPrefix}-{idx:00}");
            candidates.Add(Path.Combine(subdirectory, indexed));
            candidates.Add(indexed);
        }

        foreach (var stem in candidates)
        {
            foreach (var extension in extensions)
            {
                var path = Path.Combine(inputDirectory, $"{stem}.{extension}");
                if (File.Exists(path))
                {
                    return path;
                }
            }
        }

        return null;
    }

    private static string CreatePairedHtml(
        string? title,
        RunwayCliGalleryPlan plan,
        string inputDirectory,
        IReadOnlyList<RunwayCliGalleryPairedItem> tiles)
    {
        var resolvedTitle = string.IsNullOrWhiteSpace(title)
            ? plan.Title is { Length: > 0 } planTitle ? planTitle : "Runway Gallery"
            : title.Trim();
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
        builder.AppendLine("    h1{font-size:28px;margin:0 0 4px;} h2{font-size:16px;margin:0 0 6px;color:#1f2328;}");
        builder.AppendLine("    p{margin:0 0 24px;color:#656d76;}");
        builder.AppendLine("    .lead{margin-bottom:8px;}");
        builder.AppendLine("    .grid{display:grid;grid-template-columns:1fr;gap:18px;}");
        builder.AppendLine("    .item{background:#fff;border:1px solid #d8dee4;border-radius:8px;padding:14px;box-shadow:0 1px 2px rgba(31,35,40,.06);}");
        builder.AppendLine("    .pair{display:grid;grid-template-columns:1fr 1fr;gap:12px;}");
        builder.AppendLine("    @media (max-width:720px){.pair{grid-template-columns:1fr;}}");
        builder.AppendLine("    .pair img,.pair video{width:100%;border-radius:6px;background:#111;display:block;}");
        builder.AppendLine("    .placeholder{background:#eef0f4;color:#656d76;border:1px dashed #d8dee4;border-radius:6px;display:flex;align-items:center;justify-content:center;font-size:13px;min-height:160px;}");
        builder.AppendLine("    .name{font-weight:650;margin-top:10px;overflow-wrap:anywhere;}");
        builder.AppendLine("    .beat{font-style:italic;margin:8px 0 0;color:#3b414a;}");
        builder.AppendLine("    .meta{font-size:13px;color:#656d76;margin-top:4px;}");
        builder.AppendLine("    details{margin-top:8px;font-size:13px;}");
        builder.AppendLine("    details pre{white-space:pre-wrap;background:#f3f4f6;border-radius:6px;padding:8px;margin:6px 0;font-size:12px;}");
        builder.AppendLine("    .actions{display:flex;flex-wrap:wrap;gap:8px;margin-top:10px;}");
        builder.AppendLine("    .actions button{font:inherit;font-size:12px;padding:6px 10px;border-radius:6px;border:1px solid #d8dee4;background:#fff;cursor:pointer;}");
        builder.AppendLine("    .actions button:hover{background:#eef0f4;}");
        builder.AppendLine("    .actions button.copied{background:#dafbe1;border-color:#1a7f37;color:#1a7f37;}");
        builder.AppendLine("    a{color:#0969da;text-decoration:none;} a:hover{text-decoration:underline;}");
        builder.AppendLine("    @media (prefers-color-scheme:dark){body{background:#0d1117;color:#e6edf3}.item{background:#161b22;border-color:#30363d}.meta,p{color:#8b949e}.beat{color:#c9d1d9}.placeholder{background:#161b22;border-color:#30363d;color:#8b949e}details pre{background:#0d1117}.actions button{background:#161b22;border-color:#30363d;color:#e6edf3}.actions button:hover{background:#21262d}a{color:#58a6ff}}");
        builder.AppendLine("  </style>");
        builder.AppendLine("</head>");
        builder.AppendLine("<body>");
        builder.AppendLine($"  <h1>{Html(resolvedTitle)}</h1>");
        if (plan.Subtitle is { Length: > 0 } subtitle)
        {
            builder.AppendLine($"  <p class=\"lead\">{Html(subtitle)}</p>");
        }

        builder.AppendLine($"  <p>{tiles.Count} shot{(tiles.Count == 1 ? string.Empty : "s")} from {Html(inputDirectory)}</p>");
        builder.AppendLine("  <main class=\"grid\">");

        foreach (var tile in tiles)
        {
            var displayName = !string.IsNullOrWhiteSpace(tile.Shot.Title)
                ? tile.Shot.Title
                : !string.IsNullOrWhiteSpace(tile.Shot.Id)
                    ? tile.Shot.Id
                    : tile.Shot.Index is { } i
                        ? string.Create(CultureInfo.InvariantCulture, $"Shot {i}")
                        : "Shot";

            builder.AppendLine("    <section class=\"item\">");
            builder.AppendLine($"      <h2>{Html(displayName)}</h2>");
            if (tile.Shot.Beat is { Length: > 0 } beat)
            {
                builder.AppendLine($"      <p class=\"beat\">{Html(beat)}</p>");
            }

            builder.AppendLine("      <div class=\"pair\">");
            if (tile.KeyframeHref is { Length: > 0 } keyframeHref)
            {
                builder.AppendLine($"        <a href=\"{Html(keyframeHref)}\"><img src=\"{Html(keyframeHref)}\" alt=\"keyframe\" loading=\"lazy\"></a>");
            }
            else
            {
                builder.AppendLine("        <div class=\"placeholder\">no keyframe</div>");
            }

            if (tile.VideoHref is { Length: > 0 } videoHref)
            {
                builder.AppendLine($"        <video src=\"{Html(videoHref)}\" controls preload=\"metadata\"></video>");
            }
            else
            {
                builder.AppendLine("        <div class=\"placeholder\">no clip yet</div>");
            }

            builder.AppendLine("      </div>");

            var imageMeta = FormatAssetMeta("image", tile.ImageModel, tile.ImageRatio, tile.KeyframeSize, durationSeconds: null, modified: null);
            if (imageMeta is { Length: > 0 })
            {
                builder.AppendLine($"      <div class=\"meta\">{Html(imageMeta)}</div>");
            }

            var videoMeta = FormatAssetMeta("video", tile.VideoModel, tile.VideoRatio, tile.VideoSize, tile.DurationSeconds, tile.VideoModified);
            if (videoMeta is { Length: > 0 })
            {
                builder.AppendLine($"      <div class=\"meta\">{Html(videoMeta)}</div>");
            }

            var seedBits = new List<string>();
            if (tile.Shot.ImageSeed is { } imageSeed)
            {
                seedBits.Add(string.Create(CultureInfo.InvariantCulture, $"image seed {imageSeed}"));
            }

            if (tile.Shot.VideoSeed is { } videoSeed)
            {
                seedBits.Add(string.Create(CultureInfo.InvariantCulture, $"video seed {videoSeed}"));
            }

            if (seedBits.Count > 0)
            {
                builder.AppendLine($"      <div class=\"meta\">{Html(string.Join(" · ", seedBits))}</div>");
            }

            var imagePrompt = tile.Shot.ImagePrompt;
            var videoPrompt = tile.Shot.VideoPrompt;
            if (imagePrompt is { Length: > 0 } || videoPrompt is { Length: > 0 })
            {
                builder.AppendLine("      <details>");
                builder.AppendLine("        <summary>Prompts</summary>");
                if (imagePrompt is { Length: > 0 })
                {
                    builder.AppendLine($"        <div class=\"meta\">image:</div><pre>{Html(imagePrompt)}</pre>");
                }

                if (videoPrompt is { Length: > 0 })
                {
                    builder.AppendLine($"        <div class=\"meta\">motion:</div><pre>{Html(videoPrompt)}</pre>");
                }

                builder.AppendLine("      </details>");
            }

            var imageCommand = BuildImageCommand(tile);
            var videoCommand = BuildVideoCommand(tile);
            if (imageCommand is { Length: > 0 } || videoCommand is { Length: > 0 })
            {
                builder.AppendLine("      <div class=\"actions\">");
                if (imageCommand is { Length: > 0 })
                {
                    builder.AppendLine($"        <button type=\"button\" data-copy=\"{Html(imageCommand)}\">Copy image regen</button>");
                }

                if (videoCommand is { Length: > 0 })
                {
                    builder.AppendLine($"        <button type=\"button\" data-copy=\"{Html(videoCommand)}\">Copy video regen</button>");
                }

                builder.AppendLine("      </div>");
            }

            builder.AppendLine("    </section>");
        }

        builder.AppendLine("  </main>");
        builder.AppendLine("  <script>");
        builder.AppendLine("    document.querySelectorAll('button[data-copy]').forEach(function(button){button.addEventListener('click',function(){var text=button.getAttribute('data-copy')||'';var done=function(){var label=button.textContent;button.classList.add('copied');button.textContent='Copied';setTimeout(function(){button.classList.remove('copied');button.textContent=label;},1500);};if(navigator.clipboard&&navigator.clipboard.writeText){navigator.clipboard.writeText(text).then(done,function(){done();});}else{var area=document.createElement('textarea');area.value=text;document.body.appendChild(area);area.select();try{document.execCommand('copy');}catch(_){/* ignore */}area.remove();done();}});});");
        builder.AppendLine("  </script>");
        builder.AppendLine("</body>");
        builder.AppendLine("</html>");
        return builder.ToString();
    }

    private static string? FormatAssetMeta(
        string label,
        string? model,
        string? ratio,
        long? sizeBytes,
        double? durationSeconds,
        DateTime? modified)
    {
        var bits = new List<string>();
        if (model is { Length: > 0 })
        {
            bits.Add(model);
        }

        if (ratio is { Length: > 0 })
        {
            bits.Add(ratio);
        }

        if (durationSeconds is { } d && d > 0)
        {
            bits.Add(string.Create(CultureInfo.InvariantCulture, $"{d:0.##}s"));
        }

        if (sizeBytes is { } size)
        {
            bits.Add(FormatBytes(size));
        }

        if (modified is { } when_)
        {
            bits.Add(when_.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        if (bits.Count == 0)
        {
            return null;
        }

        return $"{label}: {string.Join(" · ", bits)}";
    }

    private static string? BuildImageCommand(RunwayCliGalleryPairedItem tile)
    {
        var prompt = tile.Shot.ImagePrompt;
        if (string.IsNullOrWhiteSpace(prompt))
        {
            return null;
        }

        var args = new List<string> { "dnx", "Runway.Cli", "image", ShellQuote(prompt) };
        if (tile.ImageModel is { Length: > 0 } model)
        {
            args.Add("--model");
            args.Add(model);
        }

        if (tile.ImageRatio is { Length: > 0 } ratio)
        {
            args.Add("--ratio");
            args.Add(ratio);
        }

        if (tile.Shot.ImageSeed is { } seed)
        {
            args.Add("--seed");
            args.Add(seed.ToString(CultureInfo.InvariantCulture));
        }

        args.Add("--output");
        args.Add("./keyframes");
        return string.Join(' ', args);
    }

    private static string? BuildVideoCommand(RunwayCliGalleryPairedItem tile)
    {
        var prompt = tile.Shot.VideoPrompt;
        if (string.IsNullOrWhiteSpace(prompt))
        {
            return null;
        }

        var args = new List<string> { "dnx", "Runway.Cli", "image-to-video", ShellQuote(prompt) };
        var keyframeName = !string.IsNullOrWhiteSpace(tile.Shot.Id)
            ? tile.Shot.Id
            : tile.Shot.Index is { } i ? string.Create(CultureInfo.InvariantCulture, $"keyframe-{i:00}") : null;
        if (keyframeName is { Length: > 0 })
        {
            args.Add("--image");
            args.Add($"./keyframes/{keyframeName}.png");
        }

        if (tile.VideoModel is { Length: > 0 } model)
        {
            args.Add("--model");
            args.Add(model);
        }

        if (tile.VideoRatio is { Length: > 0 } ratio)
        {
            args.Add("--ratio");
            args.Add(ratio);
        }

        if (tile.DurationSeconds is { } d && d > 0)
        {
            args.Add("--duration");
            args.Add(((int)Math.Round(d)).ToString(CultureInfo.InvariantCulture));
        }

        if (tile.Shot.VideoSeed is { } seed)
        {
            args.Add("--seed");
            args.Add(seed.ToString(CultureInfo.InvariantCulture));
        }

        args.Add("--output");
        args.Add("./shots");
        return string.Join(' ', args);
    }

    private static string ShellQuote(string value)
    {
        return "'" + value.Replace("'", "'\\''", StringComparison.Ordinal) + "'";
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

        return string.Create(CultureInfo.InvariantCulture, $"{value:0.#} {units[unit]}");
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

internal sealed record RunwayCliGalleryPairedItem(
    RunwayCliGalleryShot Shot,
    string? KeyframeHref,
    long? KeyframeSize,
    string? VideoHref,
    long? VideoSize,
    DateTime? VideoModified,
    string? ImageModel,
    string? VideoModel,
    string? ImageRatio,
    string? VideoRatio,
    double? DurationSeconds);

internal sealed class RunwayCliGalleryPlan
{
    public string? Title { get; init; }

    public string? Subtitle { get; init; }

    public string? Model { get; init; }

    public string? ImageModel { get; init; }

    public string? VideoModel { get; init; }

    public string? Ratio { get; init; }

    public string? ImageRatio { get; init; }

    public string? VideoRatio { get; init; }

    public double? ShotDurationSeconds { get; init; }

    public IReadOnlyList<RunwayCliGalleryShot> Shots { get; init; } = [];

    public static RunwayCliGalleryPlan FromJson(JsonElement root)
    {
        if (root.ValueKind != JsonValueKind.Object)
        {
            throw new InvalidOperationException("Gallery metadata plan must be a JSON object.");
        }

        var shots = new List<RunwayCliGalleryShot>();
        if (TryGetProperty(root, out var shotsElement, "shots") && shotsElement.ValueKind == JsonValueKind.Array)
        {
            var fallbackIndex = 1;
            foreach (var shotElement in shotsElement.EnumerateArray())
            {
                if (shotElement.ValueKind != JsonValueKind.Object)
                {
                    fallbackIndex++;
                    continue;
                }

                shots.Add(RunwayCliGalleryShot.FromJson(shotElement, fallbackIndex));
                fallbackIndex++;
            }
        }

        return new RunwayCliGalleryPlan
        {
            Title = TryGetString(root, "title"),
            Subtitle = TryGetString(root, "subtitle"),
            Model = TryGetString(root, "model"),
            ImageModel = TryGetString(root, "imageModel", "image_model"),
            VideoModel = TryGetString(root, "videoModel", "video_model"),
            Ratio = TryGetString(root, "ratio"),
            ImageRatio = TryGetString(root, "imageRatio", "image_ratio"),
            VideoRatio = TryGetString(root, "videoRatio", "video_ratio"),
            ShotDurationSeconds = TryGetDouble(root, "shotDurationSeconds", "durationPerShot", "duration_per_shot"),
            Shots = shots,
        };
    }

    internal static bool TryGetProperty(JsonElement element, out JsonElement value, params string[] names)
    {
        foreach (var name in names)
        {
            if (element.TryGetProperty(name, out value))
            {
                return true;
            }
        }

        value = default;
        return false;
    }

    internal static string? TryGetString(JsonElement element, params string[] names)
    {
        if (!TryGetProperty(element, out var found, names))
        {
            return null;
        }

        return found.ValueKind switch
        {
            JsonValueKind.String => found.GetString(),
            JsonValueKind.Number => found.ToString(),
            _ => null,
        };
    }

    internal static double? TryGetDouble(JsonElement element, params string[] names)
    {
        if (!TryGetProperty(element, out var found, names))
        {
            return null;
        }

        if (found.ValueKind == JsonValueKind.Number && found.TryGetDouble(out var d))
        {
            return d;
        }

        if (found.ValueKind == JsonValueKind.String &&
            double.TryParse(found.GetString(), NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed))
        {
            return parsed;
        }

        return null;
    }

    internal static long? TryGetInt64(JsonElement element, params string[] names)
    {
        if (!TryGetProperty(element, out var found, names))
        {
            return null;
        }

        if (found.ValueKind == JsonValueKind.Number && found.TryGetInt64(out var n))
        {
            return n;
        }

        if (found.ValueKind == JsonValueKind.String &&
            long.TryParse(found.GetString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            return parsed;
        }

        return null;
    }
}

internal sealed class RunwayCliGalleryShot
{
    public string? Id { get; init; }

    public int? Index { get; init; }

    public string? Title { get; init; }

    public string? Beat { get; init; }

    public string? ImagePrompt { get; init; }

    public string? VideoPrompt { get; init; }

    public string? ImageModel { get; init; }

    public string? VideoModel { get; init; }

    public string? ImageRatio { get; init; }

    public string? VideoRatio { get; init; }

    public double? DurationSeconds { get; init; }

    public long? ImageSeed { get; init; }

    public long? VideoSeed { get; init; }

    public static RunwayCliGalleryShot FromJson(JsonElement element, int fallbackIndex)
    {
        var index = (int?)RunwayCliGalleryPlan.TryGetInt64(element, "index", "segment", "shot");
        var sharedSeed = RunwayCliGalleryPlan.TryGetInt64(element, "seed");
        return new RunwayCliGalleryShot
        {
            Id = RunwayCliGalleryPlan.TryGetString(element, "id"),
            Index = index ?? fallbackIndex,
            Title = RunwayCliGalleryPlan.TryGetString(element, "title", "label"),
            Beat = RunwayCliGalleryPlan.TryGetString(element, "beat"),
            ImagePrompt = RunwayCliGalleryPlan.TryGetString(element, "image", "imagePrompt", "keyframePrompt"),
            VideoPrompt = RunwayCliGalleryPlan.TryGetString(element, "motion", "videoPrompt", "prompt"),
            ImageModel = RunwayCliGalleryPlan.TryGetString(element, "imageModel", "image_model"),
            VideoModel = RunwayCliGalleryPlan.TryGetString(element, "videoModel", "video_model", "model"),
            ImageRatio = RunwayCliGalleryPlan.TryGetString(element, "imageRatio", "image_ratio"),
            VideoRatio = RunwayCliGalleryPlan.TryGetString(element, "videoRatio", "video_ratio", "ratio"),
            DurationSeconds = RunwayCliGalleryPlan.TryGetDouble(element, "duration", "durationSeconds", "shotDurationSeconds"),
            ImageSeed = RunwayCliGalleryPlan.TryGetInt64(element, "imageSeed", "image_seed") ?? sharedSeed,
            VideoSeed = RunwayCliGalleryPlan.TryGetInt64(element, "videoSeed", "video_seed") ?? sharedSeed,
        };
    }
}
