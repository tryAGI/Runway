#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Runway.Cli.GeneratedApi.Commands;

internal static partial class WorkflowsCreateWorkflowsByIdCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"The ID of the published workflow to run. You can copy this value from the developer portal.",
    };

    private static Option<string?> XRunwayTags { get; } = new(
        name: @"--x-runway-tags")
    {
        Description = @"Comma-separated tags to attribute this generation's credit usage to, so you can filter and break down usage with `POST /v1/organization/usage`. Each tag is a plain label (`campaign-q4`) or a `key:value` pair (`team:growth`), split at the first colon. Tags are case-insensitive and stored lowercase. Up to 10 tags, each up to 64 characters of letters, numbers, and `_ - . / :`. An invalid tag rejects the request with a 400. Workflow runs pass their tags on to every generation they start.

**Tags appear in usage reports. Do not put end-user PII (like names or emails) in them.**",
    };

    private static Option<string> XRunwayVersion { get; } = new(
        name: @"--x-runway-version")
    {
        Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        DefaultValueFactory = _ => "2024-11-06",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object>?> NodeOutputs { get; } = new(
        name: @"--node-outputs")
    {
        Description = @"Optional node outputs to override default values. Keys are node IDs from the workflow graph, values are objects mapping output keys to typed values.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Runway.CreateWorkflowsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Runway.CreateWorkflowsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-workflows-by-id", @"Run a published workflow
Start a new task to execute a published workflow. You can optionally provide custom input values via `nodeOutputs` to override the defaults defined in the workflow graph.");
                        command.Arguments.Add(Id);
                        command.Options.Add(XRunwayTags);
                        command.Options.Add(XRunwayVersion);
                        command.Options.Add(NodeOutputs);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Runway.CreateWorkflowsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Runway.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var xRunwayTags = parseResult.GetValue(XRunwayTags);
                        var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);
                        var nodeOutputs = CliRuntime.WasSpecified(parseResult, NodeOutputs) ? parseResult.GetValue(NodeOutputs) : (__requestBase is { } __NodeOutputsBaseValue ? __NodeOutputsBaseValue.NodeOutputs : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Workflows.CreateWorkflowsByIdAsync(
                                    id: id,
                                    xRunwayTags: xRunwayTags,
                                    xRunwayVersion: xRunwayVersion,
                                    nodeOutputs: nodeOutputs,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Runway.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}