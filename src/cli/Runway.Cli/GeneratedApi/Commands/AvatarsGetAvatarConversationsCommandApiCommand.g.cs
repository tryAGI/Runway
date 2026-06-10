#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarsGetAvatarConversationsCommandApiCommand
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

    private static Option<global::System.Guid?> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"Filter to conversations that used the given custom avatar.",
    };

    private static Option<global::System.DateTime?> StartDate { get; } = new(
        name: @"--start-date")
    {
        Description = @"Filter conversations created on or after this timestamp (inclusive).",
    };

    private static Option<global::System.DateTime?> EndDate { get; } = new(
        name: @"--end-date")
    {
        Description = @"Filter conversations created before this timestamp (exclusive).",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.GetAvatarConversationsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.GetAvatarConversationsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-avatar-conversations", @"List conversations
List realtime avatar conversations for the authenticated user with cursor-based pagination. Each conversation corresponds to a realtime session, and the conversation ID matches the realtime session ID. Pass `avatar` to restrict results to a single avatar.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Avatar);
                        command.Options.Add(StartDate);
                        command.Options.Add(EndDate);
                        command.Options.Add(XRunwayVersion);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetRequiredValue(Limit);
                        var avatar = parseResult.GetValue(Avatar);
                        var startDate = parseResult.GetValue(StartDate);
                        var endDate = parseResult.GetValue(EndDate);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Avatars.GetAvatarConversationsAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    avatar: avatar,
                                    startDate: startDate,
                                    endDate: endDate,
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