#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class ModelRouterCreateGenerateImageCommandApiCommand
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

    private static Option<global::Runway.CreateGenerateImageRequestInput> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model-agnostic image generation input. The router selects a model and maps these options to it.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateGenerateImageResponse2 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateGenerateImageResponse2 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-generate-image", @"Routed image generation
Start an image generation task using a saved Model Router config instead of naming a model.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(ConfigId);
                        command.Options.Add(InputOption);

          command.Options.Add(Wait);
          command.Options.Add(PollInterval);
          command.Options.Add(WaitTimeout);
        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var configId = parseResult.GetRequiredValue(ConfigId);
                        var input = parseResult.GetRequiredValue(InputOption);          var wait = parseResult.GetValue(Wait);
          var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
          var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);

                                if (wait)
                                {
                                var createResponse = await client.ModelRouter.CreateGenerateImageAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    configId: configId,
                                    input: input,
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

                                var response = await client.ModelRouter.CreateGenerateImageAsync(
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