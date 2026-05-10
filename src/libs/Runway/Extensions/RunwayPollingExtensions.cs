namespace Runway;

/// <summary>
/// Polling helpers for <c>/v1/avatars/{id}</c> and <c>/v1/realtime_sessions/{id}</c>.
/// Mirrors <see cref="RunwayTaskExtensions.WaitForTaskAsync"/> so consumers don't need to
/// hand-roll the same poll-until-terminal loop per resource.
/// </summary>
public static class RunwayPollingExtensions
{
    /// <summary>
    /// Polls <c>/v1/avatars/{id}</c> until the avatar reaches a terminal state
    /// (<see cref="GetAvatarsResponse2.IsReady"/> or <see cref="GetAvatarsResponse2.IsFailed"/>).
    /// Returns the terminal response so the caller can inspect <c>Ready</c>/<c>Failed</c>.
    /// </summary>
    public static async Task<GetAvatarsResponse2> WaitForAvatarAsync(
        this IAvatarsClient client,
        Guid avatarId,
        string xRunwayVersion = "2024-11-06",
        TimeSpan? pollInterval = null,
        IProgress<GetAvatarsResponse2>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        var effectivePollInterval = pollInterval.GetValueOrDefault(TimeSpan.FromSeconds(2));
        if (effectivePollInterval <= TimeSpan.Zero)
        {
            effectivePollInterval = TimeSpan.FromSeconds(1);
        }

        GetAvatarsResponse2 response;
        do
        {
            response = await client.GetAvatarsByIdAsync(
                id: avatarId,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            progress?.Report(response);

            if (!response.IsReady && !response.IsFailed)
            {
                await Task.Delay(effectivePollInterval, cancellationToken).ConfigureAwait(false);
            }
        }
        while (!response.IsReady && !response.IsFailed);

        return response;
    }

    /// <summary>
    /// Polls <c>/v1/realtime_sessions/{id}</c> until the session leaves the <c>NotReady</c> state
    /// (i.e. it's <c>Ready</c>, <c>Running</c>, <c>Completed</c>, <c>Failed</c>, or <c>Cancelled</c>).
    /// </summary>
    public static async Task<GetRealtimeSessionsResponse> WaitForRealtimeSessionAsync(
        this IRealtimeSessionsClient client,
        Guid sessionId,
        string xRunwayVersion = "2024-11-06",
        TimeSpan? pollInterval = null,
        IProgress<GetRealtimeSessionsResponse>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        var effectivePollInterval = pollInterval.GetValueOrDefault(TimeSpan.FromSeconds(1));
        if (effectivePollInterval <= TimeSpan.Zero)
        {
            effectivePollInterval = TimeSpan.FromMilliseconds(500);
        }

        GetRealtimeSessionsResponse response;
        do
        {
            response = await client.GetRealtimeSessionsByIdAsync(
                id: sessionId,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            progress?.Report(response);

            if (response.IsNotReady)
            {
                await Task.Delay(effectivePollInterval, cancellationToken).ConfigureAwait(false);
            }
        }
        while (response.IsNotReady);

        return response;
    }
}
