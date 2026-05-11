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
    /// <para>
    /// Prefer the universal <see cref="AutoSDKHttpRequestOptions.AuthorizationOverride" /> key —
    /// it's stamped by the same code path and is shared across every AutoSDK-generated SDK,
    /// so a single rotation-aware <see cref="System.Net.Http.DelegatingHandler" /> can detect
    /// call-scoped credentials uniformly:
    /// </para>
    /// <code>
    /// if (!AutoSDKHttpRequestOptions.HasAuthorizationOverride(request))
    /// {
    ///     request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
    /// }
    /// </code>
    /// <para>
    /// This Runway-specific key remains for source-compat with handlers wired to it before the
    /// universal marker existed; the SDK stamps both. New code should target the AutoSDK key.
    /// </para>
    /// </remarks>
    [System.Obsolete("Use AutoSDKHttpRequestOptions.AuthorizationOverride / HasAuthorizationOverride for universal cross-SDK behavior. This key is still stamped for backward compatibility.")]
    public static readonly global::System.Net.Http.HttpRequestOptionsKey<bool> SessionScopedAuthorization =
        new("Runway.SessionScopedAuthorization");
}
