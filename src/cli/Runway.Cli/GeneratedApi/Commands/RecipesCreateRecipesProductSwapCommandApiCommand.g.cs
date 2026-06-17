#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RecipesCreateRecipesProductSwapCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<global::Runway.CreateRecipesProductSwapRequestVersion> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Workflow version. Use a dated version (e.g. ""2026-06"") to pin behavior, or ""unsafe-latest"" to track the newest stable version (may break without notice).",
        Required = true,
    };

    private static Option<global::Runway.CreateRecipesProductSwapRequestReferenceVideo> ReferenceVideo { get; } = new(
        name: @"--reference-video")
    {
        Description = @"Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.",
        Required = true,
    };

    private static Option<global::Runway.CreateRecipesProductSwapRequestOriginalProductImage> OriginalProductImage { get; } = new(
        name: @"--original-product-image")
    {
        Description = @"Image of the original product being swapped out. See [our docs](/assets/inputs#images) on image inputs.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage>> NewProductImages { get; } = new(
        name: @"--new-product-images")
    {
        Description = @"Reference images of the new product (1–10). Supply multiple angles when the reference video shows the product from different views — optionally label each with `view` (""front"", ""side"", or ""back""). A single pre-composed reference sheet is also supported (omit `view`). See [our docs](/assets/inputs#images) on image inputs.",
        Required = true,
    };

    private static Option<int?> Duration { get; } = new(
        name: @"--duration")
    {
        Description = @"Duration of the output video in seconds (4–15). Defaults to 10 seconds.",
    };

    private static Option<global::Runway.CreateRecipesProductSwapRequestResolution?> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"Output video resolution. Defaults to 720p.",
    };

    private static Option<bool?> Audio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--audio",
        description: @"Whether to generate audio for the video.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateRecipesProductSwapResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateRecipesProductSwapResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-recipes-product-swap", @"Swap a product in a reference video
Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Version);
                        command.Options.Add(ReferenceVideo);
                        command.Options.Add(OriginalProductImage);
                        command.Options.Add(NewProductImages);
                        command.Options.Add(Duration);
                        command.Options.Add(Resolution);
                        command.Options.Add(Audio);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateRecipesProductSwapRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var version = parseResult.GetRequiredValue(Version);
                        var referenceVideo = parseResult.GetRequiredValue(ReferenceVideo);
                        var originalProductImage = parseResult.GetRequiredValue(OriginalProductImage);
                        var newProductImages = parseResult.GetRequiredValue(NewProductImages);
                        var duration = CliRuntime.WasSpecified(parseResult, Duration) ? parseResult.GetValue(Duration) : (__requestBase is { } __DurationBaseValue ? __DurationBaseValue.Duration : default);
                        var resolution = CliRuntime.WasSpecified(parseResult, Resolution) ? parseResult.GetValue(Resolution) : (__requestBase is { } __ResolutionBaseValue ? __ResolutionBaseValue.Resolution : default);
                        var audio = CliRuntime.WasSpecified(parseResult, Audio) ? parseResult.GetValue(Audio) : (__requestBase is { } __AudioBaseValue ? __AudioBaseValue.Audio : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recipes.CreateRecipesProductSwapAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    version: version,
                                    referenceVideo: referenceVideo,
                                    originalProductImage: originalProductImage,
                                    newProductImages: newProductImages,
                                    duration: duration,
                                    resolution: resolution,
                                    audio: audio,
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