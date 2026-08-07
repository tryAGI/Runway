#nullable enable

namespace Runway
{
    public partial interface IModelRouterClient
    {
        /// <summary>
        /// List Model Router requests<br/>
        /// Paginated routing history for live Model Router requests (successful routes and failures). Playground dry runs are not recorded.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetRoutersRequestsResponse> GetRoutersByIdRequestsAsync(
            global::System.Guid id,
            int limit,
            string? cursor = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Model Router requests<br/>
        /// Paginated routing history for live Model Router requests (successful routes and failures). Playground dry runs are not recorded.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetRoutersRequestsResponse>> GetRoutersByIdRequestsAsResponseAsync(
            global::System.Guid id,
            int limit,
            string? cursor = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}