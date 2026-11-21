#nullable enable

namespace Runway
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List linked workspace members<br/>
        /// List the members of the linked Runway workspaces you administer, one row per member per workspace, including pending invites and members who were removed. Ordered by `membershipId`. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetOrganizationWebappMembersResponse> GetOrganizationWebappMembersAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List linked workspace members<br/>
        /// List the members of the linked Runway workspaces you administer, one row per member per workspace, including pending invites and members who were removed. Ordered by `membershipId`. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappMembersResponse>> GetOrganizationWebappMembersAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}