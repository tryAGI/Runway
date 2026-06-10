#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RealtimeSessionsCreateRealtimeSessionsCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The realtime session model type.",
        DefaultValueFactory = _ => "gwm1_avatars",
    };

    private static Option<global::Runway.Avatar2> Avatar { get; } = new(
        name: @"--avatar")
    {
        Description = @"The avatar configuration for the session.",
        Required = true,
    };

    private static Option<int?> MaxDuration { get; } = new(
        name: @"--max-duration")
    {
        Description = @"Maximum session duration in seconds.",
    };

    private static Option<string?> Personality { get; } = new(
        name: @"--personality")
    {
        Description = @"Override the avatar personality for this session. If not provided, uses the avatar default.",
    };

    private static Option<string?> StartScript { get; } = new(
        name: @"--start-script")
    {
        Description = @"Override the avatar start script for this session. If not provided, uses the avatar default.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Runway.ToolsItem>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tools available to the avatar during the session.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateRealtimeSessionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateRealtimeSessionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-realtime-sessions", @"Create realtime session
Create a new realtime session with the specified model configuration. The returned ID is also the conversation ID used later to fetch transcripts and recordings from the avatar conversation endpoints.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Model);
                        command.Options.Add(Avatar);
                        command.Options.Add(MaxDuration);
                        command.Options.Add(Personality);
                        command.Options.Add(StartScript);
                        command.Options.Add(Tools);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateRealtimeSessionsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var model = parseResult.GetRequiredValue(Model);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var maxDuration = CliRuntime.WasSpecified(parseResult, MaxDuration) ? parseResult.GetValue(MaxDuration) : __requestBase is not null ? __requestBase.MaxDuration : default;
                        var personality = CliRuntime.WasSpecified(parseResult, Personality) ? parseResult.GetValue(Personality) : __requestBase is not null ? __requestBase.Personality : default;
                        var startScript = CliRuntime.WasSpecified(parseResult, StartScript) ? parseResult.GetValue(StartScript) : __requestBase is not null ? __requestBase.StartScript : default;
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : __requestBase is not null ? __requestBase.Tools : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    model: model,
                                    avatar: avatar,
                                    maxDuration: maxDuration,
                                    personality: personality,
                                    startScript: startScript,
                                    tools: tools,
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