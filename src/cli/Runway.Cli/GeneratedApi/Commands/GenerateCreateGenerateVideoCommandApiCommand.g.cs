#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class GenerateCreateGenerateVideoCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string> ConfigId { get; } = new(
        name: @"--config-id")
    {
        Description = @"The slug of a saved Model Router config to route this request with.",
        Required = true,
    };

    private static Option<global::Runway.CreateGenerateVideoRequestInput> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model-agnostic video generation input. Fields are optional; the router selects a model and maps these options to it.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateGenerateVideoResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateGenerateVideoResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-generate-video", @"Routed video generation
Start a video generation task using a saved Model Router config instead of naming a model.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(ConfigId);
                        command.Options.Add(InputOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var configId = parseResult.GetRequiredValue(ConfigId);
                        var input = parseResult.GetRequiredValue(InputOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Generate.CreateGenerateVideoAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    configId: configId,
                                    input: input,
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