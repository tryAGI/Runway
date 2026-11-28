
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationWebappMembersResponseDataItem
    {
        /// <summary>
        /// Unique ID of the membership. Stable across requests, so use it to update a member's row between pulls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MembershipId { get; set; }

        /// <summary>
        /// ID of the member's Runway user. It doesn't change when their email does. `null` for an invite to an email with no Runway account yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Email of the member, or the email the invite was sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Role in the workspace. `non-generating-admin` is a Billing Admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetOrganizationWebappMembersResponseDataItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappMembersResponseDataItemRole Role { get; set; }

        /// <summary>
        /// `active`: a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.GetOrganizationWebappMembersResponseDataItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.GetOrganizationWebappMembersResponseDataItemStatus Status { get; set; }

        /// <summary>
        /// Why the membership is `deactivated`. `removed`: the member was removed from the workspace. `invite_ended`: the invite was declined or revoked, which are recorded the same way. `suspended`: the user is suspended. `null` unless `status` is `deactivated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivationReason")]
        public global::Runway.GetOrganizationWebappMembersResponseDataItemDeactivationReason? DeactivationReason { get; set; }

        /// <summary>
        /// When the member was added, or when the invite was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisionedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProvisionedAt { get; set; }

        /// <summary>
        /// Approximately when the member was removed, or the invite was declined or revoked: the membership's last change. `null` when the membership was not ended, including for a suspended user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprovisionedAt")]
        public global::System.DateTime? DeprovisionedAt { get; set; }

        /// <summary>
        /// Last UTC date the member used Runway, on the web or mobile app and in any workspace. `null` when they never accepted the invite or have no recorded activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastActiveDate")]
        public global::System.DateTime? LastActiveDate { get; set; }

        /// <summary>
        /// ID of the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// Name of the workspace.
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
        /// Initializes a new instance of the <see cref="GetOrganizationWebappMembersResponseDataItem" /> class.
        /// </summary>
        /// <param name="membershipId">
        /// Unique ID of the membership. Stable across requests, so use it to update a member's row between pulls.
        /// </param>
        /// <param name="email">
        /// Email of the member, or the email the invite was sent to.
        /// </param>
        /// <param name="role">
        /// Role in the workspace. `non-generating-admin` is a Billing Admin.
        /// </param>
        /// <param name="status">
        /// `active`: a member of the workspace. `invited`: invited, and the invite is not accepted yet. `deactivated`: no longer a member; `deactivationReason` says why.
        /// </param>
        /// <param name="provisionedAt">
        /// When the member was added, or when the invite was sent.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="workspaceName">
        /// Name of the workspace.
        /// </param>
        /// <param name="userId">
        /// ID of the member's Runway user. It doesn't change when their email does. `null` for an invite to an email with no Runway account yet.
        /// </param>
        /// <param name="deactivationReason">
        /// Why the membership is `deactivated`. `removed`: the member was removed from the workspace. `invite_ended`: the invite was declined or revoked, which are recorded the same way. `suspended`: the user is suspended. `null` unless `status` is `deactivated`.
        /// </param>
        /// <param name="deprovisionedAt">
        /// Approximately when the member was removed, or the invite was declined or revoked: the membership's last change. `null` when the membership was not ended, including for a suspended user.
        /// </param>
        /// <param name="lastActiveDate">
        /// Last UTC date the member used Runway, on the web or mobile app and in any workspace. `null` when they never accepted the invite or have no recorded activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationWebappMembersResponseDataItem(
            int membershipId,
            string email,
            global::Runway.GetOrganizationWebappMembersResponseDataItemRole role,
            global::Runway.GetOrganizationWebappMembersResponseDataItemStatus status,
            global::System.DateTime provisionedAt,
            int workspaceId,
            string workspaceName,
            int? userId,
            global::Runway.GetOrganizationWebappMembersResponseDataItemDeactivationReason? deactivationReason,
            global::System.DateTime? deprovisionedAt,
            global::System.DateTime? lastActiveDate)
        {
            this.MembershipId = membershipId;
            this.UserId = userId;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.Status = status;
            this.DeactivationReason = deactivationReason;
            this.ProvisionedAt = provisionedAt;
            this.DeprovisionedAt = deprovisionedAt;
            this.LastActiveDate = lastActiveDate;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationWebappMembersResponseDataItem" /> class.
        /// </summary>
        public GetOrganizationWebappMembersResponseDataItem()
        {
        }

    }
}