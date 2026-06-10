#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarsCreateAvatarsCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"The character name for the avatar.",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string> ReferenceImage { get; } = new(
        name: @"--reference-image")
    {
        Description = @"A HTTPS URL, Runway URI, or data URI containing the avatar reference image. See [our docs](/assets/inputs#images) for supported formats.",
        Required = true,
    };

    private static Option<string> Personality { get; } = new(
        name: @"--personality")
    {
        Description = @"System prompt defining how the avatar should behave in conversations.",
        Required = true,
    };

    private static Option<string?> StartScript { get; } = new(
        name: @"--start-script")
    {
        Description = @"Optional opening message that the avatar will say when a session starts.",
    };

    private static Option<global::Runway.Voice> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice configuration for the avatar.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Guid>?> DocumentIds { get; } = new(
        name: @"--document-ids")
    {
        Description = @"Optional list of knowledge document IDs to attach to this avatar. Documents provide additional context during conversations.",
    };

    private static Option<global::Runway.CreateAvatarsRequestImageProcessing?> ImageProcessing { get; } = new(
        name: @"--image-processing")
    {
        Description = @"Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateAvatarsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateAvatarsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-avatars", @"Create avatar
Create a new avatar with a reference image and voice.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(ReferenceImage);
                        command.Options.Add(Personality);
                        command.Options.Add(StartScript);
                        command.Options.Add(Voice);
                        command.Options.Add(DocumentIds);
                        command.Options.Add(ImageProcessing);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateAvatarsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var referenceImage = parseResult.GetRequiredValue(ReferenceImage);
                        var personality = parseResult.GetRequiredValue(Personality);
                        var startScript = CliRuntime.WasSpecified(parseResult, StartScript) ? parseResult.GetValue(StartScript) : __requestBase is not null ? __requestBase.StartScript : default;
                        var voice = parseResult.GetRequiredValue(Voice);
                        var documentIds = CliRuntime.WasSpecified(parseResult, DocumentIds) ? parseResult.GetValue(DocumentIds) : __requestBase is not null ? __requestBase.DocumentIds : default;
                        var imageProcessing = CliRuntime.WasSpecified(parseResult, ImageProcessing) ? parseResult.GetValue(ImageProcessing) : __requestBase is not null ? __requestBase.ImageProcessing : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Avatars.CreateAvatarsAsync(
                                    name: name,
                                    xRunwayVersion: xRunwayVersion,
                                    referenceImage: referenceImage,
                                    personality: personality,
                                    startScript: startScript,
                                    voice: voice,
                                    documentIds: documentIds,
                                    imageProcessing: imageProcessing,
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