
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationWebappUsageResponseDataItem
    {
        /// <summary>
        /// When the generation was charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Email of the user who generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

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
        /// Model/task display name for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// Credits charged for this generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// Whether the row is a credit charge for a generation or a task refund (negative credits).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetOrganizationWebappUsageResponseDataItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappUsageResponseDataItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappUsageResponseDataItem" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// When the generation was charged.
        /// </param>
        /// <param name="email">
        /// Email of the user who generated.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the owning workspace.
        /// </param>
        /// <param name="workspaceName">
        /// Name of the owning workspace.
        /// </param>
        /// <param name="tool">
        /// Model/task display name for the generation.
        /// </param>
        /// <param name="credits">
        /// Credits charged for this generation.
        /// </param>
        /// <param name="type">
        /// Whether the row is a credit charge for a generation or a task refund (negative credits).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappUsageResponseDataItem(
            global::System.DateTime timestamp,
            string email,
            int workspaceId,
            string workspaceName,
            string tool,
            double credits,
            global::Runway.GetOrganizationWebappUsageResponseDataItemType type)
        {
            this.Timestamp = timestamp;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Credits = credits;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappUsageResponseDataItem" /> class.
        /// </summary>
        public GetOrganizationWebappUsageResponseDataItem()
        {
        }

    }
}