using System.Globalization;
using Runway;

internal sealed record RunwayCliShortVideoKeyframeOptions(
    string ImageModel,
    string? ReferenceSubject);

internal sealed record RunwayCliShortVideoKeyframeShotResult(
    int Index,
    string KeyframePath,
    Guid KeyframeTaskId,
    Guid VideoTaskId,
    IReadOnlyList<string> VideoFiles);

internal sealed record RunwayCliShortVideoKeyframeResult(
    IReadOnlyList<RunwayCliShortVideoKeyframeShotResult> Shots,
    IReadOnlyList<string> DownloadedFiles);

internal static class RunwayCliShortVideoKeyframes
{
    /// <summary>
    /// Picks the supported image ratio that's closest in aspect to the requested video ratio.
    /// Lets the user keep their video <c>--ratio</c> as the canonical aspect target — the keyframe
    /// gets generated at whatever the image model supports nearest, and the i2v call resizes/crops.
    /// </summary>
    public static string PickClosestImageRatio(string videoRatio, IReadOnlyList<string> supported)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(videoRatio);
        ArgumentNullException.ThrowIfNull(supported);
        if (supported.Count == 0)
        {
            throw new ArgumentException("Supported ratio list cannot be empty.", nameof(supported));
        }

        // Bucket candidates by aspect distance (rounded to 2 decimals) so near-equivalent aspects
        // collapse into one bucket; within the closest bucket prefer the smallest pixel area to
        // avoid generating a 16MP keyframe when a 1MP one would feed image-to-video equally well.
        // Pick the smallest candidate whose aspect is within 5% of the target. If none qualify
        // (rare: only happens when the model has no near-aspect option, e.g. a video target with
        // an image model that doesn't support that orientation at all), fall back to the absolute
        // closest. Smallest-within-tolerance keeps cost low — the i2v call resizes anyway.
        var target = ToAspect(videoRatio);
        var tolerance = Math.Max(0.02, target * 0.05);
        var candidates = supported
            .Select(r => new { Ratio = r, Aspect = ToAspect(r), Area = ToArea(r) })
            .ToArray();
        var withinTolerance = candidates
            .Where(c => Math.Abs(c.Aspect - target) <= tolerance)
            .OrderBy(c => c.Area)
            .ThenBy(c => c.Ratio, StringComparer.Ordinal)
            .Select(c => c.Ratio)
            .FirstOrDefault();
        if (withinTolerance is { Length: > 0 })
        {
            return withinTolerance;
        }

        return candidates
            .OrderBy(c => Math.Abs(c.Aspect - target))
            .ThenBy(c => c.Area)
            .ThenBy(c => c.Ratio, StringComparer.Ordinal)
            .Select(c => c.Ratio)
            .First();
    }

    public static (int Width, int Height) ParseRatio(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        var parts = value.Split(':');
        if (parts.Length != 2 ||
            !int.TryParse(parts[0].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var width) ||
            !int.TryParse(parts[1].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var height) ||
            width <= 0 || height <= 0)
        {
            throw new ArgumentException($"Invalid ratio '{value}'. Expected format 'WIDTH:HEIGHT' with positive integers.");
        }

        return (width, height);
    }

    public static async Task<RunwayCliShortVideoKeyframeResult> RunPlanAsync(
        RunwayClient client,
        RunwayShortVideoPlan plan,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoKeyframeOptions keyframes,
        string xRunwayVersion,
        Action<string>? log,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(plan);
        ArgumentNullException.ThrowIfNull(options);
        ArgumentNullException.ThrowIfNull(keyframes);

        var imageModel = RunwayCliGeneration.NormalizeTextToImageModel(keyframes.ImageModel);
        var supportedImageRatios = RunwayCliGeneration.GetSupportedTextToImageRatios(imageModel);
        var imageRatio = supportedImageRatios is { Count: > 0 }
            ? PickClosestImageRatio(options.Ratio, supportedImageRatios)
            : options.Ratio;

        Directory.CreateDirectory(options.Output);

        var shotResults = new List<RunwayCliShortVideoKeyframeShotResult>(plan.Shots.Count);
        var downloadedFiles = new List<string>();

        foreach (var shot in plan.Shots)
        {
            log?.Invoke(string.Create(
                CultureInfo.InvariantCulture,
                $"Keyframe {shot.Index}/{plan.Shots.Count} ({imageModel} {imageRatio}): {shot.Title}"));

            var imageRequest = await RunwayCliGeneration.CreateTextToImageRequestAsync(
                prompt: shot.KeyframePrompt,
                model: imageModel,
                ratio: imageRatio,
                referenceImages: null,
                referenceSubject: keyframes.ReferenceSubject ?? "object",
                seed: null,
                outputCount: null,
                publicFigureThreshold: options.PublicFigureThreshold,
                cancellationToken).ConfigureAwait(false);

            var imageResponse = await client.StartGenerating.CreateTextToImageAsync(
                request: imageRequest,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var imageTask = await client.WaitForTaskAsync(
                imageResponse.Id,
                xRunwayVersion: xRunwayVersion,
                pollInterval: options.PollInterval,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var keyframePaths = await imageTask.DownloadOutputsAsync(
                output: options.Output,
                defaultExtension: ".png",
                stemPrefix: string.Create(CultureInfo.InvariantCulture, $"keyframe-{shot.Index:00}"),
                cancellationToken: cancellationToken).ConfigureAwait(false);
            if (keyframePaths.Count == 0)
            {
                throw new InvalidOperationException(string.Create(
                    CultureInfo.InvariantCulture,
                    $"Keyframe {shot.Index} did not produce any image output."));
            }

            var keyframePath = keyframePaths[0];
            log?.Invoke(string.Create(CultureInfo.InvariantCulture, $"Keyframe {shot.Index} saved to {keyframePath}"));

            log?.Invoke(string.Create(
                CultureInfo.InvariantCulture,
                $"Animating shot {shot.Index}/{plan.Shots.Count} ({options.Model} {options.Ratio} {options.ShotDurationSeconds}s)"));

            var videoRequest = await RunwayCliGeneration.CreateImageToVideoRequestAsync(
                prompt: shot.VideoPrompt,
                model: options.Model,
                promptImages: [keyframePath],
                lastImage: null,
                ratio: options.Ratio,
                duration: options.ShotDurationSeconds,
                seed: options.Seed,
                audio: options.Audio,
                publicFigureThreshold: options.PublicFigureThreshold,
                cancellationToken).ConfigureAwait(false);

            var videoResponse = await client.StartGenerating.CreateImageToVideoAsync(
                request: videoRequest,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            IReadOnlyList<string> shotFiles = [];
            if (options.WaitForCompletion)
            {
                var videoTask = await client.WaitForTaskAsync(
                    videoResponse.Id,
                    xRunwayVersion: xRunwayVersion,
                    pollInterval: options.PollInterval,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if (options.DownloadOutputs)
                {
                    shotFiles = await videoTask.DownloadOutputsAsync(
                        output: options.Output,
                        defaultExtension: ".mp4",
                        stemPrefix: string.Create(CultureInfo.InvariantCulture, $"shot-{shot.Index:00}"),
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    downloadedFiles.AddRange(shotFiles);
                    log?.Invoke(string.Create(CultureInfo.InvariantCulture, $"Shot {shot.Index} downloaded ({shotFiles.Count} file(s))"));
                }
            }

            shotResults.Add(new RunwayCliShortVideoKeyframeShotResult(
                Index: shot.Index,
                KeyframePath: keyframePath,
                KeyframeTaskId: imageResponse.Id,
                VideoTaskId: videoResponse.Id,
                VideoFiles: shotFiles));
        }

        return new RunwayCliShortVideoKeyframeResult(shotResults, downloadedFiles);
    }

    private static double ToAspect(string ratio)
    {
        var (w, h) = ParseRatio(ratio);
        return (double)w / h;
    }

    private static long ToArea(string ratio)
    {
        var (w, h) = ParseRatio(ratio);
        return (long)w * h;
    }
}
