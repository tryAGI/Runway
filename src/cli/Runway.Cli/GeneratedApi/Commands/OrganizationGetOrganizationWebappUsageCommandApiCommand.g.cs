#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class OrganizationGetOrganizationWebappUsageCommandApiCommand
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

    private static Option<global::System.DateTime> From { get; } = new(
        name: @"--from")
    {
        Description = @"Start of the time window (inclusive), ISO-8601 datetime.",
        Required = true,
    };

    private static Option<global::System.DateTime> To { get; } = new(
        name: @"--to")
    {
        Description = @"End of the time window (exclusive), ISO-8601 datetime. A `cursor` can only narrow this window, never extend it past `to`.",
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
        Description = @"Restrict results to these workspace IDs, as a comma-separated list. Defaults to every workspace you administer in the organization.",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.GetOrganizationWebappUsageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.GetOrganizationWebappUsageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-organization-webapp-usage", @"List linked workspace usage
List per-generation credit-usage rows for the linked Runway workspaces you administer, newest first. Unlike `/v1/organization/usage` (this API project's own usage), this reports usage from the workspace linked to this API project. Authorized via that account link.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(OrganizationId);
                        command.Options.Add(WorkspaceIds);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetRequiredValue(Limit);
                        var from = parseResult.GetRequiredValue(From);
                        var to = parseResult.GetRequiredValue(To);
                        var organizationId = parseResult.GetValue(OrganizationId);
                        var workspaceIds = parseResult.GetValue(WorkspaceIds);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Organization.GetOrganizationWebappUsageAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    from: from,
                                    to: to,
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
        return command;
    }
}