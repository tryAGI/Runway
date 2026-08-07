
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationWebappAuditLogsResponseDataItem
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetOrganizationWebappAuditLogsResponseDataItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction Action { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponseDataItem" /> class.
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
        /// <param name="actorUsername">
        /// Username of the user who performed the action.
        /// </param>
        /// <param name="actorEmail">
        /// Email of the user who performed the action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappAuditLogsResponseDataItem(
            global::System.Guid eventId,
            global::System.DateTime timestamp,
            global::Runway.GetOrganizationWebappAuditLogsResponseDataItemAction action,
            bool actorDeleted,
            int workspaceId,
            string workspaceName,
            string? actorUsername,
            string? actorEmail)
        {
            this.EventId = eventId;
            this.Timestamp = timestamp;
            this.Action = action;
            this.ActorUsername = actorUsername;
            this.ActorEmail = actorEmail;
            this.ActorDeleted = actorDeleted;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponseDataItem" /> class.
        /// </summary>
        public GetOrganizationWebappAuditLogsResponseDataItem()
        {
        }

    }
}