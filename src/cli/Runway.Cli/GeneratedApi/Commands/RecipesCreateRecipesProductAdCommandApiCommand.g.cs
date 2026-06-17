#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RecipesCreateRecipesProductAdCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<global::Runway.CreateRecipesProductAdRequestVersion> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Workflow version. Use a dated version (e.g. ""2026-06"") to pin behavior, or ""unsafe-latest"" to track the newest stable version (may break without notice).",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage>> ProductImages { get; } = new(
        name: @"--product-images")
    {
        Description = @"Product images (1–10). Multiple angles of the same product. All images inform product analysis and reference generation; only the first image is used as the primary product reference in the storyboard grid. See [our docs](/assets/inputs#images) on image inputs.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>?> StyleImages { get; } = new(
        name: @"--style-images")
    {
        Description = @"Optional style reference images (0–4). Defines the visual treatment (lighting, palette, mood). Treated as a moodboard when multiple are provided.",
    };

    private static Option<string?> ProductInfo { get; } = new(
        name: @"--product-info")
    {
        Description = @"Optional product description and specifications to inform creative direction and which product elements to highlight.",
    };

    private static Option<string?> UserConcept { get; } = new(
        name: @"--user-concept")
    {
        Description = @"Optional creative direction describing brand voice, product framing, scene specifics, lighting, camera motion, and narrative.",
    };

    private static Option<global::Runway.CreateRecipesProductAdRequestRatio?> Ratio { get; } = new(
        name: @"--ratio")
    {
        Description = @"The resolution of the output video.",
    };

    private static Option<int?> Duration { get; } = new(
        name: @"--duration")
    {
        Description = @"Duration of the output video in seconds (4–15). Defaults to 10 seconds.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateRecipesProductAdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateRecipesProductAdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-recipes-product-ad", @"Create a product ad video
Generate a cinematic product ad from product images, optional style references, product info, and creative direction.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Version);
                        command.Options.Add(ProductImages);
                        command.Options.Add(StyleImages);
                        command.Options.Add(ProductInfo);
                        command.Options.Add(UserConcept);
                        command.Options.Add(Ratio);
                        command.Options.Add(Duration);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateRecipesProductAdRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var version = parseResult.GetRequiredValue(Version);
                        var productImages = parseResult.GetRequiredValue(ProductImages);
                        var styleImages = CliRuntime.WasSpecified(parseResult, StyleImages) ? parseResult.GetValue(StyleImages) : (__requestBase is { } __StyleImagesBaseValue ? __StyleImagesBaseValue.StyleImages : default);
                        var productInfo = CliRuntime.WasSpecified(parseResult, ProductInfo) ? parseResult.GetValue(ProductInfo) : (__requestBase is { } __ProductInfoBaseValue ? __ProductInfoBaseValue.ProductInfo : default);
                        var userConcept = CliRuntime.WasSpecified(parseResult, UserConcept) ? parseResult.GetValue(UserConcept) : (__requestBase is { } __UserConceptBaseValue ? __UserConceptBaseValue.UserConcept : default);
                        var ratio = CliRuntime.WasSpecified(parseResult, Ratio) ? parseResult.GetValue(Ratio) : (__requestBase is { } __RatioBaseValue ? __RatioBaseValue.Ratio : default);
                        var duration = CliRuntime.WasSpecified(parseResult, Duration) ? parseResult.GetValue(Duration) : (__requestBase is { } __DurationBaseValue ? __DurationBaseValue.Duration : default);
                        var audio = CliRuntime.WasSpecified(parseResult, Audio) ? parseResult.GetValue(Audio) : (__requestBase is { } __AudioBaseValue ? __AudioBaseValue.Audio : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recipes.CreateRecipesProductAdAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    version: version,
                                    productImages: productImages,
                                    styleImages: styleImages,
                                    productInfo: productInfo,
                                    userConcept: userConcept,
                                    ratio: ratio,
                                    duration: duration,
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