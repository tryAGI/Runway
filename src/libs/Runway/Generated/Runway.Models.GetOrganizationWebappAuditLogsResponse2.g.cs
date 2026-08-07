
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationWebappAuditLogsResponse2
    {
        /// <summary>
        /// Unique identifier of the entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EventId { get; set; }

        /// <summary>
        /// When the action occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The action performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappAuditLogsResponseAction Action { get; set; }

        /// <summary>
        /// Username of the user who performed the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorUsername")]
        public string? ActorUsername { get; set; }

        /// <summary>
        /// Email of the user who performed the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorEmail")]
        public string? ActorEmail { get; set; }

        /// <summary>
        /// Whether the acting user has since been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorDeleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ActorDeleted { get; set; }

        /// <summary>
        /// ID of the owning workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// Name of the owning workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceName { get; set; }

        /// <summary>
        /// Action-specific details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappAuditLogsResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Type of the affected resource, if any. Currently one of `account_link`, `agent_custom_skill`, `asset`, `brand_kit`, `generation`, `invite_link`, `membership`, `organization`, `permission`, `promotion`, `session`, `shared_asset`, `sso_config`, `sso_domain_registration`, `subscription`, `team_settings`, `user`, `user_group`, `video_project`, `workspace`, or `workspace_tag`. New types may be added over time, so treat this as an open set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// ID of the affected resource, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// IP address of the client that performed the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIpAddress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientIpAddress { get; set; }

        /// <summary>
        /// User-Agent header of the client request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Request ID for correlation with other logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponse2" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier of the entry.
        /// </param>
        /// <param name="timestamp">
        /// When the action occurred.
        /// </param>
        /// <param name="action">
        /// The action performed.
        /// </param>
        /// <param name="actorDeleted">
        /// Whether the acting user has since been deleted.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the owning workspace.
        /// </param>
        /// <param name="workspaceName">
        /// Name of the owning workspace.
        /// </param>
        /// <param name="metadata">
        /// Action-specific details.
        /// </param>
        /// <param name="clientIpAddress">
        /// IP address of the client that performed the action.
        /// </param>
        /// <param name="actorUsername">
        /// Username of the user who performed the action.
        /// </param>
        /// <param name="actorEmail">
        /// Email of the user who performed the action.
        /// </param>
        /// <param name="resourceType">
        /// Type of the affected resource, if any. Currently one of `account_link`, `agent_custom_skill`, `asset`, `brand_kit`, `generation`, `invite_link`, `membership`, `organization`, `permission`, `promotion`, `session`, `shared_asset`, `sso_config`, `sso_domain_registration`, `subscription`, `team_settings`, `user`, `user_group`, `video_project`, `workspace`, or `workspace_tag`. New types may be added over time, so treat this as an open set.
        /// </param>
        /// <param name="resourceId">
        /// ID of the affected resource, if any.
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header of the client request.
        /// </param>
        /// <param name="requestId">
        /// Request ID for correlation with other logs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappAuditLogsResponse2(
            global::System.Guid eventId,
            global::System.DateTime timestamp,
            global::Runway.GetOrganizationWebappAuditLogsResponseAction action,
            bool actorDeleted,
            int workspaceId,
            string workspaceName,
            global::Runway.GetOrganizationWebappAuditLogsResponseMetadata metadata,
            string clientIpAddress,
            string? actorUsername,
            string? actorEmail,
            string? resourceType,
            string? resourceId,
            string? userAgent,
            string? requestId)
        {
            this.EventId = eventId;
            this.Timestamp = timestamp;
            this.Action = action;
            this.ActorUsername = actorUsername;
            this.ActorEmail = actorEmail;
            this.ActorDeleted = actorDeleted;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
            this.ClientIpAddress = clientIpAddress ?? throw new global::System.ArgumentNullException(nameof(clientIpAddress));
            this.UserAgent = userAgent;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponse2" /> class.
        /// </summary>
        public GetOrganizationWebappAuditLogsResponse2()
        {
        }

    }
}