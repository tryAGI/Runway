#nullable enable

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class AvatarsEditAvatarsByIdCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"The character name for the avatar.",
    };

    private static Option<string?> ReferenceImage { get; } = new(
        name: @"--reference-image")
    {
        Description = @"A HTTPS URL, Runway URI, or data URI containing the avatar reference image. See [our docs](/assets/inputs#images) for supported formats.",
    };

    private static Option<string?> Personality { get; } = new(
        name: @"--personality")
    {
        Description = @"System prompt defining how the avatar should behave in conversations.",
    };

    private static Option<string?> StartScript { get; } = new(
        name: @"--start-script")
    {
        Description = @"Optional opening message that the avatar will say when a session starts. Set to null to clear.",
    };

    private static Option<global::Runway.Voice2?> Voice { get; } = new(
        name: @"--voice")
    {
        Description = @"The voice configuration for the avatar.",
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Guid>?> DocumentIds { get; } = new(
        name: @"--document-ids")
    {
        Description = @"List of knowledge document IDs to attach to this avatar. Replaces all current attachments. Documents provide additional context during conversations.",
    };

    private static Option<global::Runway.PatchAvatarsRequestImageProcessing?> ImageProcessing { get; } = new(
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.PatchAvatarsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.PatchAvatarsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-avatars-by-id", @"Update avatar
Update an existing avatar. At least one field must be provided.");
                        command.Arguments.Add(Id);
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(NameOption);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.PatchAvatarsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : __requestBase is not null ? __requestBase.Name : default;
                        var referenceImage = CliRuntime.WasSpecified(parseResult, ReferenceImage) ? parseResult.GetValue(ReferenceImage) : __requestBase is not null ? __requestBase.ReferenceImage : default;
                        var personality = CliRuntime.WasSpecified(parseResult, Personality) ? parseResult.GetValue(Personality) : __requestBase is not null ? __requestBase.Personality : default;
                        var startScript = CliRuntime.WasSpecified(parseResult, StartScript) ? parseResult.GetValue(StartScript) : __requestBase is not null ? __requestBase.StartScript : default;
                        var voice = CliRuntime.WasSpecified(parseResult, Voice) ? parseResult.GetValue(Voice) : __requestBase is not null ? __requestBase.Voice : default;
                        var documentIds = CliRuntime.WasSpecified(parseResult, DocumentIds) ? parseResult.GetValue(DocumentIds) : __requestBase is not null ? __requestBase.DocumentIds : default;
                        var imageProcessing = CliRuntime.WasSpecified(parseResult, ImageProcessing) ? parseResult.GetValue(ImageProcessing) : __requestBase is not null ? __requestBase.ImageProcessing : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Avatars.EditAvatarsByIdAsync(
                                    id: id,
                                    xRunwayVersion: xRunwayVersion,
                                    name: name,
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