#nullable enable

namespace Runway
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List linked workspace audit logs<br/>
        /// List audit log entries for the linked Runway workspaces you administer, newest first. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="actions"></param>
        /// <param name="actorEmails"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetOrganizationWebappAuditLogsResponse> GetOrganizationWebappAuditLogsAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string? actions = default,
            string? actorEmails = default,
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List linked workspace audit logs<br/>
        /// List audit log entries for the linked Runway workspaces you administer, newest first. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="actions"></param>
        /// <param name="actorEmails"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappAuditLogsResponse>> GetOrganizationWebappAuditLogsAsResponseAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string? actions = default,
            string? actorEmails = default,
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}