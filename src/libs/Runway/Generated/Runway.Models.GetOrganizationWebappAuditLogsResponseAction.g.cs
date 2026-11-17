
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
        AdAccountSelectionUpdated,
        /// <summary>
        ///
        /// </summary>
        AdAccountSyncRequested,
        /// <summary>
        ///
        /// </summary>
        AdConnectionAuthorizationStarted,
        /// <summary>
        ///
        /// </summary>
        AdConnectionConnected,
        /// <summary>
        ///
        /// </summary>
        AdConnectionDisconnected,
        /// <summary>
        ///
        /// </summary>
        AdCreativeApprovalRevoked,
        /// <summary>
        ///
        /// </summary>
        AdCreativeArchived,
        /// <summary>
        ///
        /// </summary>
        AdCreativeReviewCancelled,
        /// <summary>
        ///
        /// </summary>
        AdCreativeReviewDecided,
        /// <summary>
        ///
        /// </summary>
        AdCreativeReviewSubmitted,
        /// <summary>
        ///
        /// </summary>
        AdCreativeUnarchived,
        /// <summary>
        ///
        /// </summary>
        AdPublishBatchCancelled,
        /// <summary>
        ///
        /// </summary>
        AdPublishBatchQueued,
        /// <summary>
        ///
        /// </summary>
        AdPublishBatchRetried,
        /// <summary>
        ///
        /// </summary>
        AdWorkspaceOnboardingUpdated,
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
        AppStudioAiRunOpened,
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
        AwsMarketplaceEnterpriseSubscriptionLinked,
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
        CommentAgentCallRun,
        /// <summary>
        ///
        /// </summary>
        CommentCreated,
        /// <summary>
        ///
        /// </summary>
        CommentDeleted,
        /// <summary>
        ///
        /// </summary>
        CommentEdited,
        /// <summary>
        ///
        /// </summary>
        CommentRemovalReasonChanged,
        /// <summary>
        ///
        /// </summary>
        CommentRemovedByModerator,
        /// <summary>
        ///
        /// </summary>
        CommentRestoredByModerator,
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
        MemberInviteReminderSent,
        /// <summary>
        ///
        /// </summary>
        MemberInvited,
        /// <summary>
        ///
        /// </summary>
        MemberJoinedViaDomain,
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
        OnboardingBonusGranted,
        /// <summary>
        ///
        /// </summary>
        OrganizationAgentSandboxUpdated,
        /// <summary>
        ///
        /// </summary>
        OrganizationApiAccountMemberInvited,
        /// <summary>
        ///
        /// </summary>
        OrganizationApiAccountMemberRemoved,
        /// <summary>
        ///
        /// </summary>
        OrganizationApiAccountMemberRoleChanged,
        /// <summary>
        ///
        /// </summary>
        OrganizationApiAccountReleased,
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
        StudioSessionOpened,
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
        SubscriptionReactivatedWithOffer,
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
        UserGroupArchived,
        /// <summary>
        ///
        /// </summary>
        UserGroupCreated,
        /// <summary>
        ///
        /// </summary>
        UserGroupCreditCapUpdated,
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
        UserGroupRestored,
        /// <summary>
        ///
        /// </summary>
        UserGroupUpdated,
        /// <summary>
        ///
        /// </summary>
        UserGroupVisibilityUpdated,
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
                GetOrganizationWebappAuditLogsResponseAction.AdAccountSelectionUpdated => "AdAccountSelectionUpdated",
                GetOrganizationWebappAuditLogsResponseAction.AdAccountSyncRequested => "AdAccountSyncRequested",
                GetOrganizationWebappAuditLogsResponseAction.AdConnectionAuthorizationStarted => "AdConnectionAuthorizationStarted",
                GetOrganizationWebappAuditLogsResponseAction.AdConnectionConnected => "AdConnectionConnected",
                GetOrganizationWebappAuditLogsResponseAction.AdConnectionDisconnected => "AdConnectionDisconnected",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeApprovalRevoked => "AdCreativeApprovalRevoked",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeArchived => "AdCreativeArchived",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewCancelled => "AdCreativeReviewCancelled",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewDecided => "AdCreativeReviewDecided",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewSubmitted => "AdCreativeReviewSubmitted",
                GetOrganizationWebappAuditLogsResponseAction.AdCreativeUnarchived => "AdCreativeUnarchived",
                GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchCancelled => "AdPublishBatchCancelled",
                GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchQueued => "AdPublishBatchQueued",
                GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchRetried => "AdPublishBatchRetried",
                GetOrganizationWebappAuditLogsResponseAction.AdWorkspaceOnboardingUpdated => "AdWorkspaceOnboardingUpdated",
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
                GetOrganizationWebappAuditLogsResponseAction.AppStudioAiRunOpened => "AppStudioAiRunOpened",
                GetOrganizationWebappAuditLogsResponseAction.AssetCreated => "AssetCreated",
                GetOrganizationWebappAuditLogsResponseAction.AssetDeleted => "AssetDeleted",
                GetOrganizationWebappAuditLogsResponseAction.AssetDownloaded => "AssetDownloaded",
                GetOrganizationWebappAuditLogsResponseAction.AssetShared => "AssetShared",
                GetOrganizationWebappAuditLogsResponseAction.AssetUnshared => "AssetUnshared",
                GetOrganizationWebappAuditLogsResponseAction.AssetUpdated => "AssetUpdated",
                GetOrganizationWebappAuditLogsResponseAction.AwsMarketplaceEnterpriseSubscriptionLinked => "AwsMarketplaceEnterpriseSubscriptionLinked",
                GetOrganizationWebappAuditLogsResponseAction.BrandKitShared => "BrandKitShared",
                GetOrganizationWebappAuditLogsResponseAction.BrandKitUnshared => "BrandKitUnshared",
                GetOrganizationWebappAuditLogsResponseAction.CommentAgentCallRun => "CommentAgentCallRun",
                GetOrganizationWebappAuditLogsResponseAction.CommentCreated => "CommentCreated",
                GetOrganizationWebappAuditLogsResponseAction.CommentDeleted => "CommentDeleted",
                GetOrganizationWebappAuditLogsResponseAction.CommentEdited => "CommentEdited",
                GetOrganizationWebappAuditLogsResponseAction.CommentRemovalReasonChanged => "CommentRemovalReasonChanged",
                GetOrganizationWebappAuditLogsResponseAction.CommentRemovedByModerator => "CommentRemovedByModerator",
                GetOrganizationWebappAuditLogsResponseAction.CommentRestoredByModerator => "CommentRestoredByModerator",
                GetOrganizationWebappAuditLogsResponseAction.CreditsTransferred => "CreditsTransferred",
                GetOrganizationWebappAuditLogsResponseAction.EmailChangeRequested => "EmailChangeRequested",
                GetOrganizationWebappAuditLogsResponseAction.EmailChanged => "EmailChanged",
                GetOrganizationWebappAuditLogsResponseAction.EnterpriseSpendCapEnforcementUpdated => "EnterpriseSpendCapEnforcementUpdated",
                GetOrganizationWebappAuditLogsResponseAction.GenerationCreated => "GenerationCreated",
                GetOrganizationWebappAuditLogsResponseAction.InviteAccepted => "InviteAccepted",
                GetOrganizationWebappAuditLogsResponseAction.InviteLinkToggled => "InviteLinkToggled",
                GetOrganizationWebappAuditLogsResponseAction.MemberInviteReminderSent => "MemberInviteReminderSent",
                GetOrganizationWebappAuditLogsResponseAction.MemberInvited => "MemberInvited",
                GetOrganizationWebappAuditLogsResponseAction.MemberJoinedViaDomain => "MemberJoinedViaDomain",
                GetOrganizationWebappAuditLogsResponseAction.MemberRemoved => "MemberRemoved",
                GetOrganizationWebappAuditLogsResponseAction.MemberRoleChanged => "MemberRoleChanged",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingConfigUpdated => "MeteredBillingConfigUpdated",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRefillTriggered => "MeteredBillingRefillTriggered",
                GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRetryTriggered => "MeteredBillingRetryTriggered",
                GetOrganizationWebappAuditLogsResponseAction.OnboardingBonusGranted => "OnboardingBonusGranted",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationAgentSandboxUpdated => "OrganizationAgentSandboxUpdated",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberInvited => "OrganizationApiAccountMemberInvited",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberRemoved => "OrganizationApiAccountMemberRemoved",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberRoleChanged => "OrganizationApiAccountMemberRoleChanged",
                GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountReleased => "OrganizationApiAccountReleased",
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
                GetOrganizationWebappAuditLogsResponseAction.StudioSessionOpened => "StudioSessionOpened",
                GetOrganizationWebappAuditLogsResponseAction.SubscriptionCancelled => "SubscriptionCancelled",
                GetOrganizationWebappAuditLogsResponseAction.SubscriptionPlanSwitched => "SubscriptionPlanSwitched",
                GetOrganizationWebappAuditLogsResponseAction.SubscriptionReactivatedWithOffer => "SubscriptionReactivatedWithOffer",
                GetOrganizationWebappAuditLogsResponseAction.TeamSettingsUpdated => "TeamSettingsUpdated",
                GetOrganizationWebappAuditLogsResponseAction.UserAccountDeleted => "UserAccountDeleted",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupArchived => "UserGroupArchived",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupCreated => "UserGroupCreated",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupCreditCapUpdated => "UserGroupCreditCapUpdated",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupDeleted => "UserGroupDeleted",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberAdded => "UserGroupMemberAdded",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberRemoved => "UserGroupMemberRemoved",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupRestored => "UserGroupRestored",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupUpdated => "UserGroupUpdated",
                GetOrganizationWebappAuditLogsResponseAction.UserGroupVisibilityUpdated => "UserGroupVisibilityUpdated",
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
                "AdAccountSelectionUpdated" => GetOrganizationWebappAuditLogsResponseAction.AdAccountSelectionUpdated,
                "AdAccountSyncRequested" => GetOrganizationWebappAuditLogsResponseAction.AdAccountSyncRequested,
                "AdConnectionAuthorizationStarted" => GetOrganizationWebappAuditLogsResponseAction.AdConnectionAuthorizationStarted,
                "AdConnectionConnected" => GetOrganizationWebappAuditLogsResponseAction.AdConnectionConnected,
                "AdConnectionDisconnected" => GetOrganizationWebappAuditLogsResponseAction.AdConnectionDisconnected,
                "AdCreativeApprovalRevoked" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeApprovalRevoked,
                "AdCreativeArchived" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeArchived,
                "AdCreativeReviewCancelled" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewCancelled,
                "AdCreativeReviewDecided" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewDecided,
                "AdCreativeReviewSubmitted" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeReviewSubmitted,
                "AdCreativeUnarchived" => GetOrganizationWebappAuditLogsResponseAction.AdCreativeUnarchived,
                "AdPublishBatchCancelled" => GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchCancelled,
                "AdPublishBatchQueued" => GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchQueued,
                "AdPublishBatchRetried" => GetOrganizationWebappAuditLogsResponseAction.AdPublishBatchRetried,
                "AdWorkspaceOnboardingUpdated" => GetOrganizationWebappAuditLogsResponseAction.AdWorkspaceOnboardingUpdated,
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
                "AppStudioAiRunOpened" => GetOrganizationWebappAuditLogsResponseAction.AppStudioAiRunOpened,
                "AssetCreated" => GetOrganizationWebappAuditLogsResponseAction.AssetCreated,
                "AssetDeleted" => GetOrganizationWebappAuditLogsResponseAction.AssetDeleted,
                "AssetDownloaded" => GetOrganizationWebappAuditLogsResponseAction.AssetDownloaded,
                "AssetShared" => GetOrganizationWebappAuditLogsResponseAction.AssetShared,
                "AssetUnshared" => GetOrganizationWebappAuditLogsResponseAction.AssetUnshared,
                "AssetUpdated" => GetOrganizationWebappAuditLogsResponseAction.AssetUpdated,
                "AwsMarketplaceEnterpriseSubscriptionLinked" => GetOrganizationWebappAuditLogsResponseAction.AwsMarketplaceEnterpriseSubscriptionLinked,
                "BrandKitShared" => GetOrganizationWebappAuditLogsResponseAction.BrandKitShared,
                "BrandKitUnshared" => GetOrganizationWebappAuditLogsResponseAction.BrandKitUnshared,
                "CommentAgentCallRun" => GetOrganizationWebappAuditLogsResponseAction.CommentAgentCallRun,
                "CommentCreated" => GetOrganizationWebappAuditLogsResponseAction.CommentCreated,
                "CommentDeleted" => GetOrganizationWebappAuditLogsResponseAction.CommentDeleted,
                "CommentEdited" => GetOrganizationWebappAuditLogsResponseAction.CommentEdited,
                "CommentRemovalReasonChanged" => GetOrganizationWebappAuditLogsResponseAction.CommentRemovalReasonChanged,
                "CommentRemovedByModerator" => GetOrganizationWebappAuditLogsResponseAction.CommentRemovedByModerator,
                "CommentRestoredByModerator" => GetOrganizationWebappAuditLogsResponseAction.CommentRestoredByModerator,
                "CreditsTransferred" => GetOrganizationWebappAuditLogsResponseAction.CreditsTransferred,
                "EmailChangeRequested" => GetOrganizationWebappAuditLogsResponseAction.EmailChangeRequested,
                "EmailChanged" => GetOrganizationWebappAuditLogsResponseAction.EmailChanged,
                "EnterpriseSpendCapEnforcementUpdated" => GetOrganizationWebappAuditLogsResponseAction.EnterpriseSpendCapEnforcementUpdated,
                "GenerationCreated" => GetOrganizationWebappAuditLogsResponseAction.GenerationCreated,
                "InviteAccepted" => GetOrganizationWebappAuditLogsResponseAction.InviteAccepted,
                "InviteLinkToggled" => GetOrganizationWebappAuditLogsResponseAction.InviteLinkToggled,
                "MemberInviteReminderSent" => GetOrganizationWebappAuditLogsResponseAction.MemberInviteReminderSent,
                "MemberInvited" => GetOrganizationWebappAuditLogsResponseAction.MemberInvited,
                "MemberJoinedViaDomain" => GetOrganizationWebappAuditLogsResponseAction.MemberJoinedViaDomain,
                "MemberRemoved" => GetOrganizationWebappAuditLogsResponseAction.MemberRemoved,
                "MemberRoleChanged" => GetOrganizationWebappAuditLogsResponseAction.MemberRoleChanged,
                "MeteredBillingConfigUpdated" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingConfigUpdated,
                "MeteredBillingRefillTriggered" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRefillTriggered,
                "MeteredBillingRetryTriggered" => GetOrganizationWebappAuditLogsResponseAction.MeteredBillingRetryTriggered,
                "OnboardingBonusGranted" => GetOrganizationWebappAuditLogsResponseAction.OnboardingBonusGranted,
                "OrganizationAgentSandboxUpdated" => GetOrganizationWebappAuditLogsResponseAction.OrganizationAgentSandboxUpdated,
                "OrganizationApiAccountMemberInvited" => GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberInvited,
                "OrganizationApiAccountMemberRemoved" => GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberRemoved,
                "OrganizationApiAccountMemberRoleChanged" => GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountMemberRoleChanged,
                "OrganizationApiAccountReleased" => GetOrganizationWebappAuditLogsResponseAction.OrganizationApiAccountReleased,
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
                "StudioSessionOpened" => GetOrganizationWebappAuditLogsResponseAction.StudioSessionOpened,
                "SubscriptionCancelled" => GetOrganizationWebappAuditLogsResponseAction.SubscriptionCancelled,
                "SubscriptionPlanSwitched" => GetOrganizationWebappAuditLogsResponseAction.SubscriptionPlanSwitched,
                "SubscriptionReactivatedWithOffer" => GetOrganizationWebappAuditLogsResponseAction.SubscriptionReactivatedWithOffer,
                "TeamSettingsUpdated" => GetOrganizationWebappAuditLogsResponseAction.TeamSettingsUpdated,
                "UserAccountDeleted" => GetOrganizationWebappAuditLogsResponseAction.UserAccountDeleted,
                "UserGroupArchived" => GetOrganizationWebappAuditLogsResponseAction.UserGroupArchived,
                "UserGroupCreated" => GetOrganizationWebappAuditLogsResponseAction.UserGroupCreated,
                "UserGroupCreditCapUpdated" => GetOrganizationWebappAuditLogsResponseAction.UserGroupCreditCapUpdated,
                "UserGroupDeleted" => GetOrganizationWebappAuditLogsResponseAction.UserGroupDeleted,
                "UserGroupMemberAdded" => GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberAdded,
                "UserGroupMemberRemoved" => GetOrganizationWebappAuditLogsResponseAction.UserGroupMemberRemoved,
                "UserGroupRestored" => GetOrganizationWebappAuditLogsResponseAction.UserGroupRestored,
                "UserGroupUpdated" => GetOrganizationWebappAuditLogsResponseAction.UserGroupUpdated,
                "UserGroupVisibilityUpdated" => GetOrganizationWebappAuditLogsResponseAction.UserGroupVisibilityUpdated,
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