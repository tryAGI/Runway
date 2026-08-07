#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class OrganizationGetOrganizationWebappAuditLogsByEventIdCommandApiCommand
{
    private static Argument<global::System.Guid> EventId { get; } = new(
        name: @"event-id")
    {
        Description = @"The `eventId` of an entry returned by the list endpoint.",
    };

    private static Option<global::System.Guid?> OrganizationId { get; } = new(
        name: @"--organization-id")
    {
        Description = @"Organization to report on. Optional when this API project is linked to a single organization; required when it is linked to more than one.",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.GetOrganizationWebappAuditLogsResponse2 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.GetOrganizationWebappAuditLogsResponse2 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-organization-webapp-audit-logs-by-event-id", @"Get a linked workspace audit log entry
Get a single audit log entry, including its metadata and forensic details, for a linked Runway workspace you administer. Authorized via the account link between this API project and the workspace.");
                        command.Arguments.Add(EventId);
                        command.Options.Add(OrganizationId);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var eventId = parseResult.GetRequiredValue(EventId);
                        var organizationId = parseResult.GetValue(OrganizationId);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Organization.GetOrganizationWebappAuditLogsByEventIdAsync(
                                    eventId: eventId,
                                    organizationId: organizationId,
                                    xRunwayVersion: xRunwayVersion,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Runway.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}