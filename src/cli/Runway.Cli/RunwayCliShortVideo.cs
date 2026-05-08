using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using Runway;

internal static partial class RunwayCliShortVideo
{
    public static RunwayCliShortVideoOutput ResolveOutput(string? output, DateTime utcNow, string? name = null)
    {
        var stem = !string.IsNullOrWhiteSpace(name)
            ? $"runway-short-video-{RunwayCliNaming.SanitizeName(name)}"
            : string.Create(CultureInfo.InvariantCulture, $"runway-short-video-{utcNow:yyyyMMdd-HHmmss}");
        if (string.IsNullOrWhiteSpace(output))
        {
            var defaultDirectory = Path.Combine(Environment.CurrentDirectory, stem);
            return new RunwayCliShortVideoOutput(defaultDirectory, Path.Combine(defaultDirectory, $"{stem}.mp4"));
        }

        var fullOutput = Path.GetFullPath(output);
        var outputLooksLikeDirectory =
            output.EndsWith(Path.DirectorySeparatorChar) ||
            output.EndsWith(Path.AltDirectorySeparatorChar) ||
            Directory.Exists(fullOutput) ||
            string.IsNullOrWhiteSpace(Path.GetExtension(fullOutput));

        if (outputLooksLikeDirectory)
        {
            return new RunwayCliShortVideoOutput(fullOutput, Path.Combine(fullOutput, $"{stem}.mp4"));
        }

        var directory = Path.GetDirectoryName(fullOutput) ?? Environment.CurrentDirectory;
        var segmentDirectory = Path.Combine(directory, $"{Path.GetFileNameWithoutExtension(fullOutput)}-segments");
        return new RunwayCliShortVideoOutput(segmentDirectory, fullOutput);
    }

    public static string ToJson(RunwayShortVideoPlan plan)
    {
        var options = new JsonSerializerOptions(RunwayShortVideoJsonSerializerContext.Default.Options)
        {
            WriteIndented = true,
        };

        return JsonSerializer.Serialize(plan, typeof(RunwayShortVideoPlan), options);
    }

    public static string ResolvePlanOutputPath(RunwayCliShortVideoOutput output)
    {
        var directory = Path.GetDirectoryName(Path.GetFullPath(output.FinalOutput)) ?? Environment.CurrentDirectory;
        return Path.Combine(directory, $"{Path.GetFileNameWithoutExtension(output.FinalOutput)}.plan.json");
    }

    public static async Task<string> WritePlanAsync(
        RunwayShortVideoPlan plan,
        RunwayCliShortVideoOutput output,
        CancellationToken cancellationToken)
    {
        var path = ResolvePlanOutputPath(output);
        var directory = Path.GetDirectoryName(path);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        await File.WriteAllTextAsync(
            path,
            ToJson(plan),
            new UTF8Encoding(encoderShouldEmitUTF8Identifier: false),
            cancellationToken).ConfigureAwait(false);
        return path;
    }

    public static async Task<RunwayShortVideoPlan> ReadPlanAsync(
        string value,
        CancellationToken cancellationToken)
    {
        var json = await RunwayCliGeneration.ReadJsonTextAsync(value, cancellationToken).ConfigureAwait(false);
        return JsonSerializer.Deserialize(
            json,
            RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan)
            ?? throw new ArgumentException("Short-video plan JSON did not deserialize to a plan.");
    }

    public static async Task<RunwayCliConcatResult> TryConcatAsync(
        IReadOnlyList<string> files,
        string finalOutput,
        string? ffmpegBinary,
        CancellationToken cancellationToken)
    {
        if (files.Count == 0)
        {
            return new RunwayCliConcatResult(null, "No downloaded shot files were available to concatenate.");
        }

        if (files.Count == 1)
        {
            return new RunwayCliConcatResult(files[0], null);
        }

        var ffmpeg = ResolveFfmpeg(ffmpegBinary);
        if (ffmpeg is null)
        {
            return new RunwayCliConcatResult(null, "ffmpeg was not found; leaving individual shot files in place.");
        }

        var directory = Path.GetDirectoryName(Path.GetFullPath(finalOutput));
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var listPath = Path.Combine(directory ?? Environment.CurrentDirectory, $"{Path.GetFileNameWithoutExtension(finalOutput)}.concat.txt");
        await File.WriteAllLinesAsync(
            listPath,
            CreateConcatListLines(files),
            new UTF8Encoding(encoderShouldEmitUTF8Identifier: false),
            cancellationToken).ConfigureAwait(false);

        var copyResult = await RunFfmpegAsync(
            CreateConcatStartInfo(ffmpeg, listPath, finalOutput, streamCopy: true),
            cancellationToken).ConfigureAwait(false);
        if (copyResult.ExitCode == 0)
        {
            return new RunwayCliConcatResult(finalOutput, null);
        }

        var transcodeResult = await RunFfmpegAsync(
            CreateConcatStartInfo(ffmpeg, listPath, finalOutput, streamCopy: false),
            cancellationToken).ConfigureAwait(false);
        if (transcodeResult.ExitCode == 0)
        {
            return new RunwayCliConcatResult(finalOutput, null);
        }

        return new RunwayCliConcatResult(
            null,
            $"ffmpeg concat failed. copy: {copyResult.Error.Trim()} transcode: {transcodeResult.Error.Trim()}");
    }

    internal static ProcessStartInfo CreateConcatStartInfo(
        string ffmpegBinary,
        string listPath,
        string outputPath,
        bool streamCopy)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = ffmpegBinary,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
        };

        Add(startInfo, "-y", "-hide_banner", "-loglevel", "error", "-f", "concat", "-safe", "0", "-i", listPath);
        if (streamCopy)
        {
            Add(startInfo, "-c", "copy");
        }
        else
        {
            Add(startInfo, "-c:v", "libx264", "-pix_fmt", "yuv420p", "-c:a", "aac", "-movflags", "+faststart");
        }

        Add(startInfo, outputPath);
        return startInfo;
    }

    internal static IReadOnlyList<string> CreateConcatListLines(IReadOnlyList<string> files)
    {
        return files
            .Select(file => $"file '{EscapeConcatPath(Path.GetFullPath(file))}'")
            .ToArray();
    }

    private static async Task<RunwayCliProcessResult> RunFfmpegAsync(
        ProcessStartInfo startInfo,
        CancellationToken cancellationToken)
    {
        using var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start ffmpeg.");

        var stdout = process.StandardOutput.ReadToEndAsync(cancellationToken);
        var stderr = process.StandardError.ReadToEndAsync(cancellationToken);
        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);

        return new RunwayCliProcessResult(
            process.ExitCode,
            await stdout.ConfigureAwait(false),
            await stderr.ConfigureAwait(false));
    }

    private static string? ResolveFfmpeg(string? ffmpegBinary)
    {
        if (!string.IsNullOrWhiteSpace(ffmpegBinary))
        {
            return ffmpegBinary;
        }

        if (Environment.GetEnvironmentVariable("FFMPEG_BINARY") is { Length: > 0 } configured)
        {
            return configured;
        }

        return FindExecutableOnPath("ffmpeg");
    }

    private static string? FindExecutableOnPath(string name)
    {
        var path = Environment.GetEnvironmentVariable("PATH");
        if (string.IsNullOrWhiteSpace(path))
        {
            return null;
        }

        foreach (var directory in path.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries))
        {
            var candidate = Path.Combine(directory, name);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            if (OperatingSystem.IsWindows() &&
                Environment.GetEnvironmentVariable("PATHEXT") is { Length: > 0 } pathExt)
            {
                foreach (var extension in pathExt.Split(';', StringSplitOptions.RemoveEmptyEntries))
                {
                    candidate = Path.Combine(directory, $"{name}{extension}");
                    if (File.Exists(candidate))
                    {
                        return candidate;
                    }
                }
            }
        }

        return null;
    }

    private static string EscapeConcatPath(string value)
    {
        return value.Replace("\\", "\\\\", StringComparison.Ordinal)
            .Replace("'", "\\'", StringComparison.Ordinal);
    }

    private static void Add(ProcessStartInfo startInfo, params string[] arguments)
    {
        foreach (var argument in arguments)
        {
            startInfo.ArgumentList.Add(argument);
        }
    }
}

internal sealed record RunwayCliShortVideoOutput(string SegmentDirectory, string FinalOutput);

internal sealed record RunwayCliConcatResult(string? Output, string? Warning);

internal sealed record RunwayCliProcessResult(int ExitCode, string Output, string Error);

internal sealed class RunwayCliInlineProgress<T>(Action<T> report) : IProgress<T>
{
    private readonly Action<T> _report = report;

    public void Report(T value)
    {
        _report(value);
    }
}
