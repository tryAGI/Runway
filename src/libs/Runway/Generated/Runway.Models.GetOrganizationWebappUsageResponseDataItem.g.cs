
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationWebappUsageResponseDataItem
    {
        /// <summary>
        /// Unique ID of the credit transaction behind this row. Stable across requests, so use it to deduplicate overlapping pulls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// ID of the generation this row belongs to. A charge and its refunds share it. `null` for App Studio usage, which has no generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Current status of the generation when you request it, so it can change between pulls (upsert on `transactionId`). A refund row doesn't mean the generation failed. `null` when `taskId` is null or the generation no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Runway.GetOrganizationWebappUsageResponseDataItemStatus? Status { get; set; }

        /// <summary>
        /// Media type of the generation's output: one of the listed values, which won't be remapped. Agent sandbox sessions report `file`. `null` when `taskId` is null, the generation no longer exists, or the type wasn't recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        public global::Runway.GetOrganizationWebappUsageResponseDataItemOutputType? OutputType { get; set; }

        /// <summary>
        /// Number of output files the generation returned, including ones the user later deleted and excluding attachments such as playable proxies. Copying an output into a project can raise it. 0 when it returned no files, for example while it runs or after it failed. `null` when `taskId` is null or the generation no longer exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputCount")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// When the generation was charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// ID of the user who generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

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
        /// ID of the Runway web app project the generation was made in (not this API project). `null` when no project is recorded for it, which includes generations made outside a project, generations made before project tracking was rolled out (late May to mid-August 2026), and rows with a null `taskId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Current name of that project, so it changes when the project is renamed (group by `projectId`). Still returned after the project is archived or deleted. `null` when `projectId` is null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

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
        /// Unit of `credits`. Always `credits`.
        /// </summary>
        /// <default>"credits"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string Unit { get; set; } = "credits";

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
        /// <param name="transactionId">
        /// Unique ID of the credit transaction behind this row. Stable across requests, so use it to deduplicate overlapping pulls.
        /// </param>
        /// <param name="timestamp">
        /// When the generation was charged.
        /// </param>
        /// <param name="userId">
        /// ID of the user who generated.
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
        /// <param name="taskId">
        /// ID of the generation this row belongs to. A charge and its refunds share it. `null` for App Studio usage, which has no generation.
        /// </param>
        /// <param name="status">
        /// Current status of the generation when you request it, so it can change between pulls (upsert on `transactionId`). A refund row doesn't mean the generation failed. `null` when `taskId` is null or the generation no longer exists.
        /// </param>
        /// <param name="outputType">
        /// Media type of the generation's output: one of the listed values, which won't be remapped. Agent sandbox sessions report `file`. `null` when `taskId` is null, the generation no longer exists, or the type wasn't recorded.
        /// </param>
        /// <param name="outputCount">
        /// Number of output files the generation returned, including ones the user later deleted and excluding attachments such as playable proxies. Copying an output into a project can raise it. 0 when it returned no files, for example while it runs or after it failed. `null` when `taskId` is null or the generation no longer exists.
        /// </param>
        /// <param name="projectId">
        /// ID of the Runway web app project the generation was made in (not this API project). `null` when no project is recorded for it, which includes generations made outside a project, generations made before project tracking was rolled out (late May to mid-August 2026), and rows with a null `taskId`.
        /// </param>
        /// <param name="projectName">
        /// Current name of that project, so it changes when the project is renamed (group by `projectId`). Still returned after the project is archived or deleted. `null` when `projectId` is null.
        /// </param>
        /// <param name="unit">
        /// Unit of `credits`. Always `credits`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappUsageResponseDataItem(
            string transactionId,
            global::System.DateTime timestamp,
            int userId,
            string email,
            int workspaceId,
            string workspaceName,
            string tool,
            double credits,
            global::Runway.GetOrganizationWebappUsageResponseDataItemType type,
            string? taskId,
            global::Runway.GetOrganizationWebappUsageResponseDataItemStatus? status,
            global::Runway.GetOrganizationWebappUsageResponseDataItemOutputType? outputType,
            int? outputCount,
            global::System.Guid? projectId,
            string? projectName,
            string unit = "credits")
        {
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.TaskId = taskId;
            this.Status = status;
            this.OutputType = outputType;
            this.OutputCount = outputCount;
            this.Timestamp = timestamp;
            this.UserId = userId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Credits = credits;
            this.Unit = unit;
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