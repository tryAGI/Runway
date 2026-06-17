#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RecipesCreateRecipesMarketingStockImageCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<global::Runway.CreateRecipesMarketingStockImageRequestVersion> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Workflow version. Use a dated version (e.g. ""2026-06"") to pin behavior, or ""unsafe-latest"" to track the newest stable version (may break without notice).",
        Required = true,
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Marketing image brief. Describe the subject, audience, channel, desired mood, setting, and any constraints.",
        Required = true,
    };

    private static Option<global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage?> ReferenceImage { get; } = new(
        name: @"--reference-image")
    {
        Description = @"Optional brand logo image to guide the generated marketing stock image. See [our docs](/assets/inputs#images) on image inputs.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateRecipesMarketingStockImageResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateRecipesMarketingStockImageResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-recipes-marketing-stock-image", @"Create a marketing stock image
Generate a polished marketing stock image from a text brief and optional brand logo image.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Version);
                        command.Options.Add(Prompt);
                        command.Options.Add(ReferenceImage);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateRecipesMarketingStockImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var version = parseResult.GetRequiredValue(Version);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var referenceImage = CliRuntime.WasSpecified(parseResult, ReferenceImage) ? parseResult.GetValue(ReferenceImage) : (__requestBase is { } __ReferenceImageBaseValue ? __ReferenceImageBaseValue.ReferenceImage : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recipes.CreateRecipesMarketingStockImageAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    version: version,
                                    prompt: prompt,
                                    referenceImage: referenceImage,
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