#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class OrganizationGetOrganizationWebappMembersCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor from a previous response for fetching the next page of results.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of items to return per page.",
    };

    private static Option<global::System.Guid?> OrganizationId { get; } = new(
        name: @"--organization-id")
    {
        Description = @"Organization to report on. Optional when this API project is linked to a single organization; required when it is linked to more than one. If it is missing then, the 400 response lists the IDs and names of the linked organizations in `details.organizations`.",
    };

    private static Option<string?> WorkspaceIds { get; } = new(
        name: @"--workspace-ids")
    {
        Description = @"Restrict results to these workspace IDs, as a comma-separated list of up to 50 IDs. Defaults to every workspace you administer in the organization.",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.GetOrganizationWebappMembersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.GetOrganizationWebappMembersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-organization-webapp-members", @"List linked workspace members
List the members of the linked Runway workspaces you administer, one row per member per workspace, including pending invites and members who were removed. Ordered by `membershipId`. Authorized via the account link between this API project and the workspace.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(OrganizationId);
                        command.Options.Add(WorkspaceIds);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var organizationId = parseResult.GetValue(OrganizationId);
                        var workspaceIds = parseResult.GetValue(WorkspaceIds);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Organization.GetOrganizationWebappMembersAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    organizationId: organizationId,
                                    workspaceIds: workspaceIds,
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
        CustomizeCommand(ref command);
        return command;
    }
}