#nullable enable

namespace Runway
{
    public partial interface IModelRouterClient
    {
        /// <summary>
        /// Update Model Router<br/>
        /// Update a Model Router configuration. Settings changes append a new version; name and description updates do not. Settings are merged with the current snapshot — omitted fields keep their existing values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.PatchRoutersResponse> EditRoutersByIdAsync(
            global::System.Guid id,

            global::Runway.PatchRoutersRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model Router<br/>
        /// Update a Model Router configuration. Settings changes append a new version; name and description updates do not. Settings are merged with the current snapshot — omitted fields keep their existing values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.PatchRoutersResponse>> EditRoutersByIdAsResponseAsync(
            global::System.Guid id,

            global::Runway.PatchRoutersRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Model Router<br/>
        /// Update a Model Router configuration. Settings changes append a new version; name and description updates do not. Settings are merged with the current snapshot — omitted fields keep their existing values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// Display name. The slug is immutable and cannot be changed after creation.
        /// </param>
        /// <param name="description"></param>
        /// <param name="settings">
        /// Nested merge: omitted settings fields keep their current values. When models is present, omitted models.mode or models.ids are preserved (sending only optimizeFor does not clear the model allowlist or credit ceiling).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.PatchRoutersResponse> EditRoutersByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            string? name = default,
            string? description = default,
            global::Runway.PatchRoutersRequestSettings? settings = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}