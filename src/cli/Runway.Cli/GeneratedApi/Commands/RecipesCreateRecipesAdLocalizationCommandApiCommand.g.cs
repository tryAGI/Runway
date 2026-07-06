#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class RecipesCreateRecipesAdLocalizationCommandApiCommand
{
    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<global::Runway.CreateRecipesAdLocalizationRequestVersion> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Workflow version. Use a dated version (e.g. ""2026-06"") to pin behavior, or ""unsafe-latest"" to track the newest stable version (may break without notice).",
        Required = true,
    };

    private static Option<global::Runway.CreateRecipesAdLocalizationRequestReferenceImage> ReferenceImage { get; } = new(
        name: @"--reference-image")
    {
        Description = @"Reference ad image to localize. See [our docs](/assets/inputs#images) on image inputs.",
        Required = true,
    };

    private static Option<global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage> TargetLanguage { get; } = new(
        name: @"--target-language")
    {
        Description = @"Target language for the localized ad. Use ISO-style codes (e.g. ""ja"" for Japanese, ""es"" for Spanish).",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateRecipesAdLocalizationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateRecipesAdLocalizationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-recipes-ad-localization", @"Localize an ad image
Localize an existing ad image for a target language, preserving visual creative while adapting on-screen messaging.");
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(Version);
                        command.Options.Add(ReferenceImage);
                        command.Options.Add(TargetLanguage);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var version = parseResult.GetRequiredValue(Version);
                        var referenceImage = parseResult.GetRequiredValue(ReferenceImage);
                        var targetLanguage = parseResult.GetRequiredValue(TargetLanguage);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Recipes.CreateRecipesAdLocalizationAsync(
                                    xRunwayVersion: xRunwayVersion,
                                    version: version,
                                    referenceImage: referenceImage,
                                    targetLanguage: targetLanguage,
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