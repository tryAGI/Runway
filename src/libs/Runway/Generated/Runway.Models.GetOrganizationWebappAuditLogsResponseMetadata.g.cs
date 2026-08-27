
#nullable enable

namespace Runway
{
    /// <summary>
    /// Action-specific details.
    /// </summary>
    public sealed partial class GetOrganizationWebappAuditLogsResponseMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Workspace")]
        public object? Workspace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Invited member")]
        public object? Invited_member { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Removed member")]
        public object? Removed_member { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Target member")]
        public object? Target_member { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Member email")]
        public object? Member_email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Previous role")]
        public object? Previous_role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("New role")]
        public object? New_role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Role")]
        public object? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Login method")]
        public object? Login_method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Platform")]
        public object? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Application")]
        public object? Application { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Plan")]
        public object? Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Amount")]
        public object? Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("New User")]
        public object? New_User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Group name")]
        public object? Group_name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Model")]
        public object? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Operation")]
        public object? Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Asset name")]
        public object? Asset_name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Tag name")]
        public object? Tag_name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Tag color")]
        public object? Tag_color { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Workspace ID")]
        public object? Workspace_ID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Workspace name")]
        public object? Workspace_name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Workspace picture")]
        public object? Workspace_picture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Workspace description")]
        public object? Workspace_description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Default task name template")]
        public object? Default_task_name_template { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Shared with workspace")]
        public object? Shared_with_workspace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Shared with projects")]
        public object? Shared_with_projects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Hard spend cap")]
        public object? Hard_spend_cap { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Spend cap")]
        public object? Spend_cap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponseMetadata" /> class.
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="invited_member"></param>
        /// <param name="removed_member"></param>
        /// <param name="target_member"></param>
        /// <param name="member_email"></param>
        /// <param name="previous_role"></param>
        /// <param name="new_role"></param>
        /// <param name="role"></param>
        /// <param name="login_method"></param>
        /// <param name="platform"></param>
        /// <param name="application"></param>
        /// <param name="plan"></param>
        /// <param name="amount"></param>
        /// <param name="new_User"></param>
        /// <param name="group_name"></param>
        /// <param name="model"></param>
        /// <param name="operation"></param>
        /// <param name="asset_name"></param>
        /// <param name="tag_name"></param>
        /// <param name="tag_color"></param>
        /// <param name="workspace_ID"></param>
        /// <param name="workspace_name"></param>
        /// <param name="workspace_picture"></param>
        /// <param name="workspace_description"></param>
        /// <param name="default_task_name_template"></param>
        /// <param name="shared_with_workspace"></param>
        /// <param name="shared_with_projects"></param>
        /// <param name="hard_spend_cap"></param>
        /// <param name="spend_cap"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappAuditLogsResponseMetadata(
            object? workspace,
            object? invited_member,
            object? removed_member,
            object? target_member,
            object? member_email,
            object? previous_role,
            object? new_role,
            object? role,
            object? login_method,
            object? platform,
            object? application,
            object? plan,
            object? amount,
            object? new_User,
            object? group_name,
            object? model,
            object? operation,
            object? asset_name,
            object? tag_name,
            object? tag_color,
            object? workspace_ID,
            object? workspace_name,
            object? workspace_picture,
            object? workspace_description,
            object? default_task_name_template,
            object? shared_with_workspace,
            object? shared_with_projects,
            object? hard_spend_cap,
            object? spend_cap)
        {
            this.Workspace = workspace;
            this.Invited_member = invited_member;
            this.Removed_member = removed_member;
            this.Target_member = target_member;
            this.Member_email = member_email;
            this.Previous_role = previous_role;
            this.New_role = new_role;
            this.Role = role;
            this.Login_method = login_method;
            this.Platform = platform;
            this.Application = application;
            this.Plan = plan;
            this.Amount = amount;
            this.New_User = new_User;
            this.Group_name = group_name;
            this.Model = model;
            this.Operation = operation;
            this.Asset_name = asset_name;
            this.Tag_name = tag_name;
            this.Tag_color = tag_color;
            this.Workspace_ID = workspace_ID;
            this.Workspace_name = workspace_name;
            this.Workspace_picture = workspace_picture;
            this.Workspace_description = workspace_description;
            this.Default_task_name_template = default_task_name_template;
            this.Shared_with_workspace = shared_with_workspace;
            this.Shared_with_projects = shared_with_projects;
            this.Hard_spend_cap = hard_spend_cap;
            this.Spend_cap = spend_cap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappAuditLogsResponseMetadata" /> class.
        /// </summary>
        public GetOrganizationWebappAuditLogsResponseMetadata()
        {
        }

    }
}