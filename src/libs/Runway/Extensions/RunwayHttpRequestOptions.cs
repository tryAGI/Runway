#nullable enable

namespace Runway;

/// <summary>
/// Typed <see cref="System.Net.Http.HttpRequestMessage.Options" /> keys exposed by the Runway SDK.
/// </summary>
public static class RunwayHttpRequestOptions
{
    /// <summary>
    /// Marker stamped by the SDK on an outgoing <see cref="System.Net.Http.HttpRequestMessage" />
    /// when the <c>Authorization</c> header carries a non-default, endpoint-supplied bearer
    /// token — currently the one-shot session key used by
    /// <see cref="RealtimeSessionsClient.ConsumeRealtimeSessionAsync(System.Guid, string, string, System.Threading.CancellationToken)" />
    /// against <c>POST /v1/realtime_sessions/{id}/consume</c>.
    /// </summary>
    /// <remarks>
    /// Consumers that install a <see cref="System.Net.Http.DelegatingHandler" /> to inject
    /// a fresh account-level API key per request (a common pattern with rotation-aware
    /// secret stores) should check for this marker and skip the overwrite, otherwise the
    /// account key clobbers the session-scoped credential and the server returns 404:
    /// <code>
    /// if (!request.Options.TryGetValue(RunwayHttpRequestOptions.SessionScopedAuthorization, out _))
    /// {
    ///     request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
    /// }
    /// </code>
    /// </remarks>
    public static readonly global::System.Net.Http.HttpRequestOptionsKey<bool> SessionScopedAuthorization =
        new("Runway.SessionScopedAuthorization");
}
