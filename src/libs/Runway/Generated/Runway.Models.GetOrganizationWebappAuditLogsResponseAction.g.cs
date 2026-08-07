
#nullable enable

namespace Runway
{
    /// <summary>
    /// The action performed.
    /// </summary>
    public enum GetOrganizationWebappAuditLogsResponseAction
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
    public static class GetOrganizationWebappAuditLogsResponseActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappAuditLogsResponseAction value)
        {
            return value switch
            {
                GetOrganizationWebappAuditLogsResponseAction.AccountLinkCreated => "AccountLinkCreated",
                GetOrganizationWebappAuditLogsResponseAction.AccountLinkDeleted => "AccountLinkDeleted",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorAssetExported => "AgentConnectorAssetExported",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorConnected => "AgentConnectorConnected",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorDisconnected => "AgentConnectorDisconnected",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorLinkTokenCreated => "AgentConnectorLinkTokenCreated",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorSessionDisabled => "AgentConnectorSessionDisabled",
                GetOrganizationWebappAuditLogsResponseAction.AgentConnectorSessionEnabled => "AgentConnectorSessionEnabled",
                GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillCreated => "AgentCustomSkillCreated",
                GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillDeleted => "AgentCustomSkillDeleted",
                GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillShared => "AgentCustomSkillShared",
                GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillUnshared => "AgentCustomSkillUnshared",
                GetOrganizationWebappAuditLogsResponseAction.AgentSessionShared => "AgentSessionShared",
                GetOrganizationWebappAuditLogsResponseAction.AgentSessionUnshared => "AgentSessionUnshared",
                GetOrganizationWebappAuditLogsResponseAction.AssetCreated => "AssetCreated",
                GetOrganizationWebappAuditLogsResponseAction.AssetDeleted => "AssetDeleted",
                GetOrganizationWebappAuditLogsResponseAction.AssetDownloaded => "AssetDownloaded",
                GetOrganizationWebappAuditLogsResponseAction.AssetShared => "AssetShared",
                GetOrganizationWebappAuditLogsResponseAction.AssetUnshared => "AssetUnshared",
                GetOrganizationWebappAuditLogsResponseAction.AssetUpdated => "AssetUpdated",
                GetOrganizationWebappAuditLogsResponseAction.BrandKitShared => "BrandKitShared",
                GetOrganizationWebappAuditLogsResponseAction.BrandKitUnshared => "BrandKitUnshared",
                GetOrganizationWebappAuditLogsResponseAction.CreditsTransferred => "CreditsTransferred",
                GetOrganizationWebappAuditLogsResponseAction.EmailChangeRequested => "EmailChangeRequested",
                GetOrganizationWebappAuditLogsResponseAction.EmailChanged => "EmailChanged",
                GetOrganizationWebappAuditLogsResponseAction.EnterpriseSpendCapEnforcementUpdated => "EnterpriseSpendCapEnforcementUpdated",
                GetOrganizationWebappAuditLogsResponseAction.GenerationCreated => "GenerationCreated",
                GetOrganizationWebappAuditLogsResponseAction.InviteAccepted => "InviteAccepted",
                GetOrganizationWebappAuditLogsResponseAction.InviteLinkToggled => "InviteLinkToggled",
                GetOrganizationWebappAuditLogsResponseAction.MemberInvited => "MemberInvited",
                GetOrganizationWebappAuditLogsResponseAction.MemberRemoved => "MemberRemoved",
                GetOrganizationWebappAuditLogsResponseAction.MemberRoleChanged => "MemberRoleChanged",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingConfigUpdated => "MeteredBillingConfigUpdated",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRefillTriggered => "MeteredBillingRefillTriggered",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRetryTriggered => "MeteredBillingRetryTriggered",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationDisabledModelsUpdated => "OrganizationDisabledModelsUpdated",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationSettingsUpdated => "OrganizationSettingsUpdated",
                GetOrganizationWebappAuditLogsResponseAction.PasswordChanged => "PasswordChanged",
                GetOrganizationWebappAuditLogsResponseAction.PermissionAccepted => "PermissionAccepted",
                GetOrganizationWebappAuditLogsResponseAction.PermissionGranted => "PermissionGranted",
                GetOrganizationWebappAuditLogsResponseAction.PermissionRevoked => "PermissionRevoked",
                GetOrganizationWebappAuditLogsResponseAction.PermissionUpdated => "PermissionUpdated",
                GetOrganizationWebappAuditLogsResponseAction.SSOConfigCreated => "SSOConfigCreated",
                GetOrganizationWebappAuditLogsResponseAction.SSODomainRegistrationCloned => "SSODomainRegistrationCloned",
                GetOrganizationWebappAuditLogsResponseAction.SSOLogin => "SSOLogin",
                GetOrganizationWebappAuditLogsResponseAction.SSOUserAutoAddedToTeam => "SSOUserAutoAddedToTeam",
                GetOrganizationWebappAuditLogsResponseAction.SSOUserProvisioned => "SSOUserProvisioned",
                GetOrganizationWebappAuditLogsResponseAction.SeatsTransferred => "SeatsTransferred",
                GetOrganizationWebappAuditLogsResponseAction.SessionShared => "SessionShared",
                GetOrganizationWebappAuditLogsResponseAction.SessionUnshared => "SessionUnshared",
                GetOrganizationWebappAuditLogsResponseAction.SubscriptionCancelled => "SubscriptionCancelled",
                GetOrganizationWebappAuditLogsResponseAction.SubscriptionPlanSwitched => "SubscriptionPlanSwitched",
                GetOrganizationWebappAuditLogsResponseAction.TeamSettingsUpdated => "TeamSettingsUpdated",
                GetOrganizationWebappAuditLogsResponseAction.UserAccountDeleted => "UserAccountDeleted",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupCreated => "UserGroupCreated",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupDeleted => "UserGroupDeleted",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberAdded => "UserGroupMemberAdded",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberRemoved => "UserGroupMemberRemoved",
                GetOrganizationWebappAuditLogsResponseAction.UserLogin => "UserLogin",
                GetOrganizationWebappAuditLogsResponseAction.UserRegistered => "UserRegistered",
                GetOrganizationWebappAuditLogsResponseAction.VideoProjectShared => "VideoProjectShared",
                GetOrganizationWebappAuditLogsResponseAction.VideoProjectUnshared => "VideoProjectUnshared",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceCountryLockUpdated => "WorkspaceCountryLockUpdated",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceCreated => "WorkspaceCreated",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceDeleted => "WorkspaceDeleted",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagAssigned => "WorkspaceTagAssigned",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagCreated => "WorkspaceTagCreated",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagDeleted => "WorkspaceTagDeleted",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagUnassigned => "WorkspaceTagUnassigned",
                GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagUpdated => "WorkspaceTagUpdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappAuditLogsResponseAction? ToEnum(string value)
        {
            return value switch
            {
                "AccountLinkCreated" => GetOrganizationWebappAuditLogsResponseAction.AccountLinkCreated,
                "AccountLinkDeleted" => GetOrganizationWebappAuditLogsResponseAction.AccountLinkDeleted,
                "AgentConnectorAssetExported" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorAssetExported,
                "AgentConnectorConnected" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorConnected,
                "AgentConnectorDisconnected" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorDisconnected,
                "AgentConnectorLinkTokenCreated" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorLinkTokenCreated,
                "AgentConnectorSessionDisabled" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorSessionDisabled,
                "AgentConnectorSessionEnabled" => GetOrganizationWebappAuditLogsResponseAction.AgentConnectorSessionEnabled,
                "AgentCustomSkillCreated" => GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillCreated,
                "AgentCustomSkillDeleted" => GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillDeleted,
                "AgentCustomSkillShared" => GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillShared,
                "AgentCustomSkillUnshared" => GetOrganizationWebappAuditLogsResponseAction.AgentCustomSkillUnshared,
                "AgentSessionShared" => GetOrganizationWebappAuditLogsResponseAction.AgentSessionShared,
                "AgentSessionUnshared" => GetOrganizationWebappAuditLogsResponseAction.AgentSessionUnshared,
                "AssetCreated" => GetOrganizationWebappAuditLogsResponseAction.AssetCreated,
                "AssetDeleted" => GetOrganizationWebappAuditLogsResponseAction.AssetDeleted,
                "AssetDownloaded" => GetOrganizationWebappAuditLogsResponseAction.AssetDownloaded,
                "AssetShared" => GetOrganizationWebappAuditLogsResponseAction.AssetShared,
                "AssetUnshared" => GetOrganizationWebappAuditLogsResponseAction.AssetUnshared,
                "AssetUpdated" => GetOrganizationWebappAuditLogsResponseAction.AssetUpdated,
                "BrandKitShared" => GetOrganizationWebappAuditLogsResponseAction.BrandKitShared,
                "BrandKitUnshared" => GetOrganizationWebappAuditLogsResponseAction.BrandKitUnshared,
                "CreditsTransferred" => GetOrganizationWebappAuditLogsResponseAction.CreditsTransferred,
                "EmailChangeRequested" => GetOrganizationWebappAuditLogsResponseAction.EmailChangeRequested,
                "EmailChanged" => GetOrganizationWebappAuditLogsResponseAction.EmailChanged,
                "EnterpriseSpendCapEnforcementUpdated" => GetOrganizationWebappAuditLogsResponseAction.EnterpriseSpendCapEnforcementUpdated,
                "GenerationCreated" => GetOrganizationWebappAuditLogsResponseAction.GenerationCreated,
                "InviteAccepted" => GetOrganizationWebappAuditLogsResponseAction.InviteAccepted,
                "InviteLinkToggled" => GetOrganizationWebappAuditLogsResponseAction.InviteLinkToggled,
                "MemberInvited" => GetOrganizationWebappAuditLogsResponseAction.MemberInvited,
                "MemberRemoved" => GetOrganizationWebappAuditLogsResponseAction.MemberRemoved,
                "MemberRoleChanged" => GetOrganizationWebappAuditLogsResponseAction.MemberRoleChanged,
                "MeteredBillingConfigUpdated" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingConfigUpdated,
                "MeteredBillingRefillTriggered" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRefillTriggered,
                "MeteredBillingRetryTriggered" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRetryTriggered,
                "OrganizationDisabledModelsUpdated" => GetOrganizationWebappAuditLogsResponseAction.OrganizationDisabledModelsUpdated,
                "OrganizationSettingsUpdated" => GetOrganizationWebappAuditLogsResponseAction.OrganizationSettingsUpdated,
                "PasswordChanged" => GetOrganizationWebappAuditLogsResponseAction.PasswordChanged,
                "PermissionAccepted" => GetOrganizationWebappAuditLogsResponseAction.PermissionAccepted,
                "PermissionGranted" => GetOrganizationWebappAuditLogsResponseAction.PermissionGranted,
                "PermissionRevoked" => GetOrganizationWebappAuditLogsResponseAction.PermissionRevoked,
                "PermissionUpdated" => GetOrganizationWebappAuditLogsResponseAction.PermissionUpdated,
                "SSOConfigCreated" => GetOrganizationWebappAuditLogsResponseAction.SSOConfigCreated,
                "SSODomainRegistrationCloned" => GetOrganizationWebappAuditLogsResponseAction.SSODomainRegistrationCloned,
                "SSOLogin" => GetOrganizationWebappAuditLogsResponseAction.SSOLogin,
                "SSOUserAutoAddedToTeam" => GetOrganizationWebappAuditLogsResponseAction.SSOUserAutoAddedToTeam,
                "SSOUserProvisioned" => GetOrganizationWebappAuditLogsResponseAction.SSOUserProvisioned,
                "SeatsTransferred" => GetOrganizationWebappAuditLogsResponseAction.SeatsTransferred,
                "SessionShared" => GetOrganizationWebappAuditLogsResponseAction.SessionShared,
                "SessionUnshared" => GetOrganizationWebappAuditLogsResponseAction.SessionUnshared,
                "SubscriptionCancelled" => GetOrganizationWebappAuditLogsResponseAction.SubscriptionCancelled,
                "SubscriptionPlanSwitched" => GetOrganizationWebappAuditLogsResponseAction.SubscriptionPlanSwitched,
                "TeamSettingsUpdated" => GetOrganizationWebappAuditLogsResponseAction.TeamSettingsUpdated,
                "UserAccountDeleted" => GetOrganizationWebappAuditLogsResponseAction.UserAccountDeleted,
                "UserGroupCreated" => GetOrganizationWebappAuditLogsResponseAction.UserGroupCreated,
                "UserGroupDeleted" => GetOrganizationWebappAuditLogsResponseAction.UserGroupDeleted,
                "UserGroupMemberAdded" => GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberAdded,
                "UserGroupMemberRemoved" => GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberRemoved,
                "UserLogin" => GetOrganizationWebappAuditLogsResponseAction.UserLogin,
                "UserRegistered" => GetOrganizationWebappAuditLogsResponseAction.UserRegistered,
                "VideoProjectShared" => GetOrganizationWebappAuditLogsResponseAction.VideoProjectShared,
                "VideoProjectUnshared" => GetOrganizationWebappAuditLogsResponseAction.VideoProjectUnshared,
                "WorkspaceCountryLockUpdated" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceCountryLockUpdated,
                "WorkspaceCreated" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceCreated,
                "WorkspaceDeleted" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceDeleted,
                "WorkspaceTagAssigned" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagAssigned,
                "WorkspaceTagCreated" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagCreated,
                "WorkspaceTagDeleted" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagDeleted,
                "WorkspaceTagUnassigned" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagUnassigned,
                "WorkspaceTagUpdated" => GetOrganizationWebappAuditLogsResponseAction.WorkspaceTagUpdated,
                _ => null,
            };
        }
    }
}