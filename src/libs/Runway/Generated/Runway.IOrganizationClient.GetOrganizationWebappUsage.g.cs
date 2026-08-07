#nullable enable

namespace Runway
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List linked workspace usage<br/>
        /// List per-generation credit-usage rows for the linked Runway workspaces you administer, newest first. Unlike `/v1/organization/usage` (this API project's own usage), this reports usage from the workspace linked to this API project. Authorized via that account link.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetOrganizationWebappUsageResponse> GetOrganizationWebappUsageAsync(
            int limit,
            global::System.DateTime from,
            global::System.DateTime to,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List linked workspace usage<br/>
        /// List per-generation credit-usage rows for the linked Runway workspaces you administer, newest first. Unlike `/v1/organization/usage` (this API project's own usage), this reports usage from the workspace linked to this API project. Authorized via that account link.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappUsageResponse>> GetOrganizationWebappUsageAsResponseAsync(
            int limit,
            global::System.DateTime from,
            global::System.DateTime to,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}