
#nullable enable

namespace Runway
{
    /// <summary>
    /// The action performed.
    /// </summary>
    public enum GetOrganizationWebappAuditLogsResponseDataItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        AccountLinkCreated,
        /// <summary>
        /// 
        /// </summary>
        AccountLinkDeleted,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorAssetExported,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorConnected,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorDisconnected,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorLinkTokenCreated,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorSessionDisabled,
        /// <summary>
        /// 
        /// </summary>
        AgentConnectorSessionEnabled,
        /// <summary>
        /// 
        /// </summary>
        AgentCustomSkillCreated,
        /// <summary>
        /// 
        /// </summary>
        AgentCustomSkillDeleted,
        /// <summary>
        /// 
        /// </summary>
        AgentCustomSkillShared,
        /// <summary>
        /// 
        /// </summary>
        AgentCustomSkillUnshared,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionShared,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionUnshared,
        /// <summary>
        /// 
        /// </summary>
        AssetCreated,
        /// <summary>
        /// 
        /// </summary>
        AssetDeleted,
        /// <summary>
        /// 
        /// </summary>
        AssetDownloaded,
        /// <summary>
        /// 
        /// </summary>
        AssetShared,
        /// <summary>
        /// 
        /// </summary>
        AssetUnshared,
        /// <summary>
        /// 
        /// </summary>
        AssetUpdated,
        /// <summary>
        /// 
        /// </summary>
        BrandKitShared,
        /// <summary>
        /// 
        /// </summary>
        BrandKitUnshared,
        /// <summary>
        /// 
        /// </summary>
        CreditsTransferred,
        /// <summary>
        /// 
        /// </summary>
        EmailChangeRequested,
        /// <summary>
        /// 
        /// </summary>
        EmailChanged,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseSpendCapEnforcementUpdated,
        /// <summary>
        /// 
        /// </summary>
        GenerationCreated,
        /// <summary>
        /// 
        /// </summary>
        InviteAccepted,
        /// <summary>
        /// 
        /// </summary>
        InviteLinkToggled,
        /// <summary>
        /// 
        /// </summary>
        MemberInvited,
        /// <summary>
        /// 
        /// </summary>
        MemberRemoved,
        /// <summary>
        /// 
        /// </summary>
        MemberRoleChanged,
        /// <summary>
        /// 
        /// </summary>
        MeteredBillingConfigUpdated,
        /// <summary>
        /// 
        /// </summary>
        MeteredBillingRefillTriggered,
        /// <summary>
        /// 
        /// </summary>
        MeteredBillingRetryTriggered,
        /// <summary>
        /// 
        /// </summary>
        OrganizationDisabledModelsUpdated,
        /// <summary>
        /// 
        /// </summary>
        OrganizationSettingsUpdated,
        /// <summary>
        /// 
        /// </summary>
        PasswordChanged,
        /// <summary>
        /// 
        /// </summary>
        PermissionAccepted,
        /// <summary>
        /// 
        /// </summary>
        PermissionGranted,
        /// <summary>
        /// 
        /// </summary>
        PermissionRevoked,
        /// <summary>
        /// 
        /// </summary>
        PermissionUpdated,
        /// <summary>
        /// 
        /// </summary>
        SSOConfigCreated,
        /// <summary>
        /// 
        /// </summary>
        SSODomainRegistrationCloned,
        /// <summary>
        /// 
        /// </summary>
        SSOLogin,
        /// <summary>
        /// 
        /// </summary>
        SSOUserAutoAddedToTeam,
        /// <summary>
        /// 
        /// </summary>
        SSOUserProvisioned,
        /// <summary>
        /// 
        /// </summary>
        SeatsTransferred,
        /// <summary>
        /// 
        /// </summary>
        SessionShared,
        /// <summary>
        /// 
        /// </summary>
        SessionUnshared,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCancelled,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPlanSwitched,
        /// <summary>
        /// 
        /// </summary>
        TeamSettingsUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserGroupCreated,
        /// <summary>
        /// 
        /// </summary>
        UserGroupDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserGroupMemberAdded,
        /// <summary>
        /// 
        /// </summary>
        UserGroupMemberRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserLogin,
        /// <summary>
        /// 
        /// </summary>
        UserRegistered,
        /// <summary>
        /// 
        /// </summary>
        VideoProjectShared,
        /// <summary>
        /// 
        /// </summary>
        VideoProjectUnshared,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceCountryLockUpdated,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceCreated,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceDeleted,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceTagAssigned,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceTagCreated,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceTagDeleted,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceTagUnassigned,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceTagUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappAuditLogsResponseDataItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappAuditLogsResponseDataItemAction value)
        {
            return value switch
            {
                GetOrganizationWebappAuditLogsResponseDataItemAction.AccountLinkCreated => "AccountLinkCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AccountLinkDeleted => "AccountLinkDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorAssetExported => "AgentConnectorAssetExported",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorConnected => "AgentConnectorConnected",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorDisconnected => "AgentConnectorDisconnected",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorLinkTokenCreated => "AgentConnectorLinkTokenCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorSessionDisabled => "AgentConnectorSessionDisabled",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorSessionEnabled => "AgentConnectorSessionEnabled",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillCreated => "AgentCustomSkillCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillDeleted => "AgentCustomSkillDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillShared => "AgentCustomSkillShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillUnshared => "AgentCustomSkillUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentSessionShared => "AgentSessionShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AgentSessionUnshared => "AgentSessionUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetCreated => "AssetCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetDeleted => "AssetDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetDownloaded => "AssetDownloaded",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetShared => "AssetShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetUnshared => "AssetUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.AssetUpdated => "AssetUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.BrandKitShared => "BrandKitShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.BrandKitUnshared => "BrandKitUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.CreditsTransferred => "CreditsTransferred",
                GetOrganizationWebappAuditLogsResponseDataItemAction.EmailChangeRequested => "EmailChangeRequested",
                GetOrganizationWebappAuditLogsResponseDataItemAction.EmailChanged => "EmailChanged",
                GetOrganizationWebappAuditLogsResponseDataItemAction.EnterpriseSpendCapEnforcementUpdated => "EnterpriseSpendCapEnforcementUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.GenerationCreated => "GenerationCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.InviteAccepted => "InviteAccepted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.InviteLinkToggled => "InviteLinkToggled",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MemberInvited => "MemberInvited",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MemberRemoved => "MemberRemoved",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MemberRoleChanged => "MemberRoleChanged",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingConfigUpdated => "MeteredBillingConfigUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingRefillTriggered => "MeteredBillingRefillTriggered",
                GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingRetryTriggered => "MeteredBillingRetryTriggered",
                GetOrganizationWebappAuditLogsResponseDataItemAction.OrganizationDisabledModelsUpdated => "OrganizationDisabledModelsUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.OrganizationSettingsUpdated => "OrganizationSettingsUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.PasswordChanged => "PasswordChanged",
                GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionAccepted => "PermissionAccepted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionGranted => "PermissionGranted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionRevoked => "PermissionRevoked",
                GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionUpdated => "PermissionUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SSOConfigCreated => "SSOConfigCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SSODomainRegistrationCloned => "SSODomainRegistrationCloned",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SSOLogin => "SSOLogin",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SSOUserAutoAddedToTeam => "SSOUserAutoAddedToTeam",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SSOUserProvisioned => "SSOUserProvisioned",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SeatsTransferred => "SeatsTransferred",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SessionShared => "SessionShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SessionUnshared => "SessionUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SubscriptionCancelled => "SubscriptionCancelled",
                GetOrganizationWebappAuditLogsResponseDataItemAction.SubscriptionPlanSwitched => "SubscriptionPlanSwitched",
                GetOrganizationWebappAuditLogsResponseDataItemAction.TeamSettingsUpdated => "TeamSettingsUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserAccountDeleted => "UserAccountDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupCreated => "UserGroupCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupDeleted => "UserGroupDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupMemberAdded => "UserGroupMemberAdded",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupMemberRemoved => "UserGroupMemberRemoved",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserLogin => "UserLogin",
                GetOrganizationWebappAuditLogsResponseDataItemAction.UserRegistered => "UserRegistered",
                GetOrganizationWebappAuditLogsResponseDataItemAction.VideoProjectShared => "VideoProjectShared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.VideoProjectUnshared => "VideoProjectUnshared",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceCountryLockUpdated => "WorkspaceCountryLockUpdated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceCreated => "WorkspaceCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceDeleted => "WorkspaceDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagAssigned => "WorkspaceTagAssigned",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagCreated => "WorkspaceTagCreated",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagDeleted => "WorkspaceTagDeleted",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagUnassigned => "WorkspaceTagUnassigned",
                GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagUpdated => "WorkspaceTagUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappAuditLogsResponseDataItemAction? ToEnum(string value)
        {
            return value switch
            {
                "AccountLinkCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.AccountLinkCreated,
                "AccountLinkDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.AccountLinkDeleted,
                "AgentConnectorAssetExported" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorAssetExported,
                "AgentConnectorConnected" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorConnected,
                "AgentConnectorDisconnected" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorDisconnected,
                "AgentConnectorLinkTokenCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorLinkTokenCreated,
                "AgentConnectorSessionDisabled" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorSessionDisabled,
                "AgentConnectorSessionEnabled" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentConnectorSessionEnabled,
                "AgentCustomSkillCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillCreated,
                "AgentCustomSkillDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillDeleted,
                "AgentCustomSkillShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillShared,
                "AgentCustomSkillUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentCustomSkillUnshared,
                "AgentSessionShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentSessionShared,
                "AgentSessionUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AgentSessionUnshared,
                "AssetCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetCreated,
                "AssetDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetDeleted,
                "AssetDownloaded" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetDownloaded,
                "AssetShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetShared,
                "AssetUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetUnshared,
                "AssetUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.AssetUpdated,
                "BrandKitShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.BrandKitShared,
                "BrandKitUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.BrandKitUnshared,
                "CreditsTransferred" => GetOrganizationWebappAuditLogsResponseDataItemAction.CreditsTransferred,
                "EmailChangeRequested" => GetOrganizationWebappAuditLogsResponseDataItemAction.EmailChangeRequested,
                "EmailChanged" => GetOrganizationWebappAuditLogsResponseDataItemAction.EmailChanged,
                "EnterpriseSpendCapEnforcementUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.EnterpriseSpendCapEnforcementUpdated,
                "GenerationCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.GenerationCreated,
                "InviteAccepted" => GetOrganizationWebappAuditLogsResponseDataItemAction.InviteAccepted,
                "InviteLinkToggled" => GetOrganizationWebappAuditLogsResponseDataItemAction.InviteLinkToggled,
                "MemberInvited" => GetOrganizationWebappAuditLogsResponseDataItemAction.MemberInvited,
                "MemberRemoved" => GetOrganizationWebappAuditLogsResponseDataItemAction.MemberRemoved,
                "MemberRoleChanged" => GetOrganizationWebappAuditLogsResponseDataItemAction.MemberRoleChanged,
                "MeteredBillingConfigUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingConfigUpdated,
                "MeteredBillingRefillTriggered" => GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingRefillTriggered,
                "MeteredBillingRetryTriggered" => GetOrganizationWebappAuditLogsResponseDataItemAction.MeteredBillingRetryTriggered,
                "OrganizationDisabledModelsUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.OrganizationDisabledModelsUpdated,
                "OrganizationSettingsUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.OrganizationSettingsUpdated,
                "PasswordChanged" => GetOrganizationWebappAuditLogsResponseDataItemAction.PasswordChanged,
                "PermissionAccepted" => GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionAccepted,
                "PermissionGranted" => GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionGranted,
                "PermissionRevoked" => GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionRevoked,
                "PermissionUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.PermissionUpdated,
                "SSOConfigCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.SSOConfigCreated,
                "SSODomainRegistrationCloned" => GetOrganizationWebappAuditLogsResponseDataItemAction.SSODomainRegistrationCloned,
                "SSOLogin" => GetOrganizationWebappAuditLogsResponseDataItemAction.SSOLogin,
                "SSOUserAutoAddedToTeam" => GetOrganizationWebappAuditLogsResponseDataItemAction.SSOUserAutoAddedToTeam,
                "SSOUserProvisioned" => GetOrganizationWebappAuditLogsResponseDataItemAction.SSOUserProvisioned,
                "SeatsTransferred" => GetOrganizationWebappAuditLogsResponseDataItemAction.SeatsTransferred,
                "SessionShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.SessionShared,
                "SessionUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.SessionUnshared,
                "SubscriptionCancelled" => GetOrganizationWebappAuditLogsResponseDataItemAction.SubscriptionCancelled,
                "SubscriptionPlanSwitched" => GetOrganizationWebappAuditLogsResponseDataItemAction.SubscriptionPlanSwitched,
                "TeamSettingsUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.TeamSettingsUpdated,
                "UserAccountDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserAccountDeleted,
                "UserGroupCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupCreated,
                "UserGroupDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupDeleted,
                "UserGroupMemberAdded" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupMemberAdded,
                "UserGroupMemberRemoved" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserGroupMemberRemoved,
                "UserLogin" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserLogin,
                "UserRegistered" => GetOrganizationWebappAuditLogsResponseDataItemAction.UserRegistered,
                "VideoProjectShared" => GetOrganizationWebappAuditLogsResponseDataItemAction.VideoProjectShared,
                "VideoProjectUnshared" => GetOrganizationWebappAuditLogsResponseDataItemAction.VideoProjectUnshared,
                "WorkspaceCountryLockUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceCountryLockUpdated,
                "WorkspaceCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceCreated,
                "WorkspaceDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceDeleted,
                "WorkspaceTagAssigned" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagAssigned,
                "WorkspaceTagCreated" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagCreated,
                "WorkspaceTagDeleted" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagDeleted,
                "WorkspaceTagUnassigned" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagUnassigned,
                "WorkspaceTagUpdated" => GetOrganizationWebappAuditLogsResponseDataItemAction.WorkspaceTagUpdated,
                _ => null,
            };
        }
    }
}