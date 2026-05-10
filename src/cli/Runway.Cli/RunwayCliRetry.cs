using System.Globalization;
using Runway;

internal static class RunwayCliRetry
{
    public static bool IsRetryableFailureCode(string? failureCode)
    {
        if (string.IsNullOrWhiteSpace(failureCode))
        {
            return false;
        }

        return failureCode.StartsWith("INTERNAL.", StringComparison.Ordinal) ||
               failureCode.Equals("INTERNAL", StringComparison.Ordinal);
    }

    public static async Task<GetTasksResponse> SubmitAndWaitAsync(
        RunwayClient client,
        string runwayVersion,
        Func<CancellationToken, Task<Guid>> submitAsync,
        TimeSpan pollInterval,
        int retryOnInternalError,
        TimeSpan retryBackoff,
        IProgress<GetTasksResponse>? progress,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(submitAsync);

        var maxAttempts = Math.Max(0, retryOnInternalError) + 1;
        GetTasksResponse? lastTask = null;
        for (var attempt = 1; attempt <= maxAttempts; attempt++)
        {
            var taskId = await submitAsync(cancellationToken).ConfigureAwait(false);
            await Console.Error.WriteLineAsync(
                attempt == 1
                    ? string.Create(CultureInfo.InvariantCulture, $"Task ID: {taskId}")
                    : string.Create(CultureInfo.InvariantCulture, $"Task ID: {taskId} (retry {attempt - 1}/{maxAttempts - 1})"))
                .ConfigureAwait(false);

            var task = await client.WaitForTaskAsync(
                taskId,
                xRunwayVersion: runwayVersion,
                pollInterval: pollInterval,
                progress: progress,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            lastTask = task;

            if (!task.IsFailed)
            {
                return task;
            }

            var failureCode = task.Failed?.FailureCode;
            if (attempt >= maxAttempts || !IsRetryableFailureCode(failureCode))
            {
                return task;
            }

            var failureMessage = task.Failed?.Failure ?? "An unexpected error occurred.";
            await Console.Error.WriteLineAsync(string.Create(
                CultureInfo.InvariantCulture,
                $"Task {taskId} failed ({failureCode}): {failureMessage}. Retrying in {retryBackoff.TotalSeconds:0.#}s ({attempt}/{maxAttempts - 1})..."))
                .ConfigureAwait(false);
            if (retryBackoff > TimeSpan.Zero)
            {
                await Task.Delay(retryBackoff, cancellationToken).ConfigureAwait(false);
            }
        }

        return lastTask ?? throw new InvalidOperationException("Runway task submission did not produce a terminal task.");
    }
}
