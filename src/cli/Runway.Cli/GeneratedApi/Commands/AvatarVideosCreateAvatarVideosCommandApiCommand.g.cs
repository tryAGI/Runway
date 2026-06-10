#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarVideosCreateAvatarVideosCommandApiCommand
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


    public static Command Create()
    {
        var command = new Command(@"create-avatar-videos", @"Generate avatar video from audio or text
Start an asynchronous task to generate a video of an avatar speaking. Provide `speech` with `type: ""audio""` (audio file) or `type: ""text""` (text script for TTS). Poll `GET /v1/tasks/:id` to check progress and retrieve the output video URL once complete.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Model);
                        command.Options.Add(Avatar);
                        command.Options.Add(Speech);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var model = parseResult.GetRequiredValue(Model);
                        var avatar = parseResult.GetRequiredValue(Avatar);
                        var speech = parseResult.GetRequiredValue(Speech);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AvatarVideos.CreateAvatarVideosAsync(
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
        return command;
    }
}