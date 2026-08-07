#nullable enable

namespace Runway
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Get a linked workspace audit log entry<br/>
        /// Get a single audit log entry, including its metadata and forensic details, for a linked Runway workspace you administer. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="organizationId"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.GetOrganizationWebappAuditLogsResponse2> GetOrganizationWebappAuditLogsByEventIdAsync(
            global::System.Guid eventId,
            global::System.Guid? organizationId = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a linked workspace audit log entry<br/>
        /// Get a single audit log entry, including its metadata and forensic details, for a linked Runway workspace you administer. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="organizationId"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappAuditLogsResponse2>> GetOrganizationWebappAuditLogsByEventIdAsResponseAsync(
            global::System.Guid eventId,
            global::System.Guid? organizationId = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}