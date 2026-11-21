#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarVideosCreateAvatarVideosCommandApiCommand
{
    private static Option<string?> XRunwayTags { get; } = new(
        name: @"--x-runway-tags")
    {
        Description = @"Comma-separated tags to attribute this generation's credit usage to, so you can filter and break down usage with `POST /v1/organization/usage`. Each tag is a plain label (`campaign-q4`) or a `key:value` pair (`team:growth`), split at the first colon. Tags are case-insensitive and stored lowercase. Up to 10 tags, each up to 64 characters of letters, numbers, and `_ - . / :`. An invalid tag rejects the request with a 400. Workflow runs pass their tags on to every generation they start.

**Tags appear in usage reports. Do not put end-user PII (like names or emails) in them.**",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use for avatar video generation.",
        DefaultValueFactory = _ => "gwm1_avatars",
    };

    private static Option<global::Runway.Avatar> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"The avatar configuration for the session.",
        Required = true,
    };

    private static Option<global::Runway.Speech> Speech { get; } = new(
        name: @"--speech")
    {
        Description = @"The speech source for avatar video generation. Either an audio file or text script.",
        Required = true,
    };
      private static Option<bool> Wait { get; } = new("--wait")
      {
          Description = "Poll the generated wait helper until the resource reaches a terminal state.",
      };

      private static Option<string> PollInterval { get; } = new("--poll-interval")
      {
          Description = "Polling interval, for example 250ms, 2s, 30m, or 01:00:00.",
          DefaultValueFactory = _ => "2s",
      };

      private static Option<string> WaitTimeout { get; } = new("--wait-timeout")
      {
          Description = "Maximum time to wait before timing out, for example 30m or 00:30:00.",
          DefaultValueFactory = _ => "30m",
      };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateAvatarVideosResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateAvatarVideosResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-avatar-videos", @"Generate avatar video from audio or text
Start an asynchronous task to generate a video of an avatar speaking. Provide `speech` with `type: ""audio""` (audio file) or `type: ""text""` (text script for TTS). Poll `GET /v1/tasks/:id` to check progress and retrieve the output video URL once complete.");
                        command.Options.Add(XRunwayTags);
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Model);
                        command.Options.Add(Avatar);
                        command.Options.Add(Speech);

          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayTags = parseResult.GetValue(XRunwayTags);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var model = parseResult.GetRequiredValue(Model);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var speech = parseResult.GetRequiredValue(Speech);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.AvatarVideos.CreateAvatarVideosAsync(
                                    xRunwayTags: xRunwayTags,
                                    xRunwayVersion: xRunwayVersion,
                                    model: model,
                                    avatar: avatar,
                                    speech: speech,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);
                                    var resourceId = global::System.Convert.ToString(
                                        createResponse.Id,
                                        global::System.Globalization.CultureInfo.InvariantCulture);
                                    if (string.IsNullOrWhiteSpace(resourceId))
                                    {
                                        throw new CliException("The create response did not contain a job id.");
                                    }

                                    var waitResponse = await CliRuntime.PollUntilTerminalAsync(
                                        fetchAsync: token => client.TaskManagement.GetTasksByIdAsync(
                                            id: global::System.Guid.Parse(resourceId),
                                            cancellationToken: token),
                                        pollInterval: pollInterval,
                                        waitTimeout: waitTimeout,
                                        context: global::Runway.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteResponseAsync(
                                        parseResult,
                                        waitResponse,
                                        global::Runway.SourceGenerationContext.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    return;
                                }

                                var response = await client.AvatarVideos.CreateAvatarVideosAsync(
                                    xRunwayTags: xRunwayTags,
                                    xRunwayVersion: xRunwayVersion,
                                    model: model,
                                    avatar: avatar,
                                    speech: speech,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Runway.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}