#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Get avatar usage<br/>
        /// Get aggregate usage statistics for avatar conversations, including total duration, session counts, average duration, and a per-day breakdown. Per-day buckets are keyed by UTC calendar date. The date range must not exceed 90 days.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetAvatarUsageResponse> GetAvatarUsageAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get avatar usage<br/>
        /// Get aggregate usage statistics for avatar conversations, including total duration, session counts, average duration, and a per-day breakdown. Per-day buckets are keyed by UTC calendar date. The date range must not exceed 90 days.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetAvatarUsageResponse>> GetAvatarUsageAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}