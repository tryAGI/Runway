using System.Globalization;

namespace Runway;

/// <summary>
/// Helpers for polling Runway tasks and downloading completed task outputs.
/// </summary>
public static class RunwayTaskExtensions
{
    /// <summary>
    /// Polls a Runway task until it reaches a terminal state.
    /// </summary>
    public static async Task<GetTasksResponse> WaitForTaskAsync(
        this RunwayClient client,
        Guid taskId,
        string xRunwayVersion = "2024-11-06",
        TimeSpan? pollInterval = null,
        IProgress<GetTasksResponse>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        var effectivePollInterval = pollInterval.GetValueOrDefault(TimeSpan.FromSeconds(5));
        if (effectivePollInterval <= TimeSpan.Zero)
        {
            effectivePollInterval = TimeSpan.FromSeconds(1);
        }

        GetTasksResponse task;
        do
        {
            task = await client.TaskManagement.GetTasksByIdAsync(
                id: taskId,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            progress?.Report(task);

            if (!task.IsFailed && !task.IsSucceeded && !task.IsCancelled)
            {
                await Task.Delay(effectivePollInterval, cancellationToken).ConfigureAwait(false);
            }
        }
        while (!task.IsFailed && !task.IsSucceeded && !task.IsCancelled);

        return task;
    }

    /// <summary>
    /// Downloads output URLs from a succeeded Runway task to a file or directory.
    /// </summary>
    public static async Task<IReadOnlyList<string>> DownloadOutputsAsync(
        this GetTasksResponse task,
        string? output = null,
        string defaultExtension = ".bin",
        string stemPrefix = "runway-output",
        HttpClient? httpClient = null,
        CancellationToken cancellationToken = default)
    {
        var succeeded = task.Succeeded ?? throw CreateTerminalTaskException(task);
        var outputUrls = succeeded.Output;
        if (outputUrls.Count == 0)
        {
            throw new InvalidOperationException($"Runway task {succeeded.Id} succeeded but returned no output URLs.");
        }

        HttpClient? ownedHttpClient = null;
        var effectiveHttpClient = httpClient ?? (ownedHttpClient = new HttpClient());

        try
        {
            var paths = new List<string>(outputUrls.Count);
            var stem = string.Create(
                CultureInfo.InvariantCulture,
                $"{stemPrefix}-{DateTime.UtcNow:yyyyMMdd-HHmmss}-{succeeded.Id:N}");

            for (var index = 0; index < outputUrls.Count; index++)
            {
                var url = outputUrls[index];
                var outputUri = Uri.TryCreate(url, UriKind.Absolute, out var parsedOutputUri)
                    ? parsedOutputUri
                    : throw new InvalidOperationException($"Runway task output URL is invalid: {url}");
                var path = ResolveOutputPath(
                    output,
                    stem,
                    index,
                    outputUrls.Count,
                    GetOutputExtension(outputUri, defaultExtension));

                var directory = Path.GetDirectoryName(path);
                if (!string.IsNullOrWhiteSpace(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using var response = await effectiveHttpClient.GetAsync(
                    outputUri,
                    HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                using var inputStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                using var outputStream = File.Create(path);
                await inputStream.CopyToAsync(outputStream, cancellationToken).ConfigureAwait(false);

                paths.Add(path);
            }

            return paths;
        }
        finally
        {
            ownedHttpClient?.Dispose();
        }
    }

    /// <summary>
    /// Resolves a concrete output file path for one downloaded task output.
    /// </summary>
    public static string ResolveOutputPath(
        string? output,
        string stem,
        int index,
        int outputCount,
        string extension)
    {
        if (string.IsNullOrWhiteSpace(output))
        {
            return Path.Combine(Environment.CurrentDirectory, outputCount == 1 ? $"{stem}{extension}" : $"{stem}-{index + 1}{extension}");
        }

        var fullOutput = Path.GetFullPath(output);
        var outputLooksLikeDirectory =
            output.EndsWith(Path.DirectorySeparatorChar) ||
            output.EndsWith(Path.AltDirectorySeparatorChar) ||
            Directory.Exists(fullOutput) ||
            string.IsNullOrWhiteSpace(Path.GetExtension(fullOutput));

        if (outputLooksLikeDirectory)
        {
            return Path.Combine(fullOutput, outputCount == 1 ? $"{stem}{extension}" : $"{stem}-{index + 1}{extension}");
        }

        if (outputCount == 1)
        {
            return fullOutput;
        }

        var directory = Path.GetDirectoryName(fullOutput) ?? Environment.CurrentDirectory;
        var fileName = Path.GetFileNameWithoutExtension(fullOutput);
        var fileExtension = Path.GetExtension(fullOutput);
        return Path.Combine(directory, $"{fileName}-{index + 1}{fileExtension}");
    }

    /// <summary>
    /// Infers the output file extension from a URL path, falling back when no extension is present.
    /// </summary>
    public static string GetOutputExtension(Uri url, string fallback)
    {
        ArgumentNullException.ThrowIfNull(url);

        if (url.IsAbsoluteUri)
        {
            var extension = Path.GetExtension(url.LocalPath);
            if (extension is { Length: > 1 and <= 10 })
            {
                return extension;
            }
        }

        return fallback;
    }

    private static InvalidOperationException CreateTerminalTaskException(GetTasksResponse task)
    {
        if (task.Failed is { } failed)
        {
            return new InvalidOperationException(
                string.IsNullOrWhiteSpace(failed.FailureCode)
                    ? $"Runway task {failed.Id} failed: {failed.Failure}"
                    : $"Runway task {failed.Id} failed ({failed.FailureCode}): {failed.Failure}");
        }

        if (task.Cancelled is { } cancelled)
        {
            return new InvalidOperationException($"Runway task {cancelled.Id} was cancelled.");
        }

        return new InvalidOperationException("Runway task has not succeeded yet. Wait for completion before downloading outputs.");
    }
}
