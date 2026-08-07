#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class OrganizationGetOrganizationWebappAuditLogsCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor from a previous response for fetching the next page of results.",
    };

    private static Option<int> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of items to return per page.",
        Required = true,
    };

    private static Option<global::System.Guid?> OrganizationId { get; } = new(
        name: @"--organization-id")
    {
        Description = @"Organization to report on. Optional when this API project is linked to a single organization; required when it is linked to more than one.",
    };

    private static Option<string?> WorkspaceIds { get; } = new(
        name: @"--workspace-ids")
    {
        Description = @"Restrict results to these workspace IDs, as a comma-separated list of up to 50 IDs. Defaults to every workspace you administer in the organization.",
    };

    private static Option<string?> Actions { get; } = new(
        name: @"--actions")
    {
        Description = @"Restrict results to these audit log actions, as a comma-separated list of up to 50 actions. Allowed values: `UserLogin`, `PasswordChanged`, `EmailChangeRequested`, `EmailChanged`, `UserRegistered`, `UserAccountDeleted`, `WorkspaceCreated`, `WorkspaceDeleted`, `MemberInvited`, `MemberRemoved`, `MemberRoleChanged`, `InviteAccepted`, `TeamSettingsUpdated`, `InviteLinkToggled`, `UserGroupCreated`, `UserGroupDeleted`, `UserGroupMemberAdded`, `UserGroupMemberRemoved`, `SSOLogin`, `SSOUserProvisioned`, `SSOConfigCreated`, `SSOUserAutoAddedToTeam`, `SSODomainRegistrationCloned`, `AssetCreated`, `AssetUpdated`, `AssetDeleted`, `AssetDownloaded`, `AssetShared`, `AssetUnshared`, `PermissionGranted`, `PermissionUpdated`, `PermissionRevoked`, `PermissionAccepted`, `SubscriptionCancelled`, `SubscriptionPlanSwitched`, `CreditsTransferred`, `SeatsTransferred`, `SessionShared`, `SessionUnshared`, `VideoProjectShared`, `VideoProjectUnshared`, `BrandKitShared`, `BrandKitUnshared`, `AgentCustomSkillCreated`, `AgentCustomSkillDeleted`, `AgentCustomSkillShared`, `AgentCustomSkillUnshared`, `AgentSessionShared`, `AgentSessionUnshared`, `AgentConnectorLinkTokenCreated`, `AgentConnectorConnected`, `AgentConnectorDisconnected`, `AgentConnectorAssetExported`, `AgentConnectorSessionEnabled`, `AgentConnectorSessionDisabled`, `GenerationCreated`, `AccountLinkCreated`, `AccountLinkDeleted`, `OrganizationSettingsUpdated`, `OrganizationDisabledModelsUpdated`, `WorkspaceCountryLockUpdated`, `WorkspaceTagCreated`, `WorkspaceTagUpdated`, `WorkspaceTagDeleted`, `WorkspaceTagAssigned`, `WorkspaceTagUnassigned`, `MeteredBillingConfigUpdated`, `MeteredBillingRefillTriggered`, `MeteredBillingRetryTriggered`, `EnterpriseSpendCapEnforcementUpdated`.",
    };

    private static Option<string?> ActorEmails { get; } = new(
        name: @"--actor-emails")
    {
        Description = @"Restrict results to entries performed by the users with these emails, as a comma-separated list of up to 50 emails.",
    };

    private static Option<global::System.DateTime?> From { get; } = new(
        name: @"--from")
    {
        Description = @"Start of the time window (inclusive), ISO-8601 datetime.",
    };

    private static Option<global::System.DateTime?> To { get; } = new(
        name: @"--to")
    {
        Description = @"End of the time window (exclusive), ISO-8601 datetime.",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.GetOrganizationWebappAuditLogsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.GetOrganizationWebappAuditLogsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-organization-webapp-audit-logs", @"List linked workspace audit logs
List audit log entries for the linked Runway workspaces you administer, newest first. Authorized via the account link between this API project and the workspace.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(OrganizationId);
                        command.Options.Add(WorkspaceIds);
                        command.Options.Add(Actions);
                        command.Options.Add(ActorEmails);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetRequiredValue(Limit);
                        var organizationId = parseResult.GetValue(OrganizationId);
                        var workspaceIds = parseResult.GetValue(WorkspaceIds);
                        var actions = parseResult.GetValue(Actions);
                        var actorEmails = parseResult.GetValue(ActorEmails);
                        var from = parseResult.GetValue(From);
                        var to = parseResult.GetValue(To);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Organization.GetOrganizationWebappAuditLogsAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    organizationId: organizationId,
                                    workspaceIds: workspaceIds,
                                    actions: actions,
                                    actorEmails: actorEmails,
                                    from: from,
                                    to: to,
                                    xRunwayVersion: xRunwayVersion,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Runway.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Runway.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}