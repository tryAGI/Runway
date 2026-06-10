#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class VoicesCreateVoicesPreviewCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"A text description of the desired voice characteristics. Must be at least 20 characters.",
        Required = true,
    };

    private static Option<global::Runway.CreateVoicesPreviewRequestModel> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The voice design model to use. Prefer eleven_ttv_v3 (latest); eleven_multilingual_ttv_v2 is the previous generation.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateVoicesPreviewResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateVoicesPreviewResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-voices-preview", @"Preview a voice
Generate a short audio preview of a voice from a text description. Use this to audition a voice before creating it.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Prompt);
                        command.Options.Add(Model);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var model = parseResult.GetRequiredValue(Model);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.CreateVoicesPreviewAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    prompt: prompt,
                                    model: model,
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