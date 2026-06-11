#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class KnowledgeEditDocumentsByIdCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"The document ID.",
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
        Description = @"A new name for the document.",
    };

    private static Option<string?> Content { get; } = new(
        name: @"--content")
    {
        Description = @"New markdown or plain text content for the document.",
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

    public static Command Create()
    {
        var command = new Command(@"edit-documents-by-id", @"Update document
Update a knowledge document. At least one of `name` or `content` must be provided.");
                        command.Arguments.Add(Id);
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(NameOption);
                        command.Options.Add(Content);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.PatchDocumentsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : __requestBase is not null ? __requestBase.Name : default;
                        var content = CliRuntime.WasSpecified(parseResult, Content) ? parseResult.GetValue(Content) : __requestBase is not null ? __requestBase.Content : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Knowledge.EditDocumentsByIdAsync(
                                    id: id,
                                    xRunwayVersion: xRunwayVersion,
                                    name: name,
                                    content: content,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}