
#nullable enable

namespace Runway
{
    /// <summary>
    /// Type of the affected resource, if any. Currently one of `account_link`, `agent_custom_skill`, `asset`, `brand_kit`, `generation`, `invite_link`, `membership`, `organization`, `permission`, `promotion`, `session`, `shared_asset`, `sso_config`, `sso_domain_registration`, `subscription`, `team_settings`, `user`, `user_group`, `video_project`, `workspace`, or `workspace_tag`. New types may be added over time, so treat this as an open set.
    /// </summary>
    public sealed partial class GetOrganizationWebappAuditLogsResponseResourceType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}