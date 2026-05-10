using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

internal static class RunwayCliBuiltInWorkflows
{
    /// <summary>
    /// Built-in workflows now live in the SDK at <see cref="BuiltInWorkflows.All"/>. This property
    /// delegates to the SDK so the existing CLI code paths keep compiling unchanged.
    /// </summary>
    public static IReadOnlyList<BuiltInWorkflow> BuiltIns => BuiltInWorkflows.All;


    /// <summary>
    /// Delegates to <see cref="BuiltInWorkflows.RenderCategoryTable"/>. Kept as a CLI surface
    /// for the existing skill drift tests; new callers should reference the SDK helper directly.
    /// </summary>
    public static string RenderCategoryTable(BuiltInWorkflowCategory category) =>
        BuiltInWorkflows.RenderCategoryTable(category);

    /// <summary>
    /// Delegates to <see cref="BuiltInWorkflows.RenderIndex"/>. Kept as a CLI surface
    /// for the existing skill drift tests; new callers should reference the SDK helper directly.
    /// </summary>
    public static string RenderIndex() => BuiltInWorkflows.RenderIndex();

    /// <summary>
    /// Test-and-startup-time view of registered workflows. Defaults to built-ins only.
    /// Production code uses <see cref="LoadAllCommands"/> which merges built-ins with disk-registered entries.
    /// </summary>
    public static IReadOnlyList<BuiltInWorkflow> Registry => BuiltIns;

    public static BuiltInWorkflow? FindByCommandName(string commandName) =>
        Registry.FirstOrDefault(w => string.Equals(w.CommandName, commandName, StringComparison.Ordinal));

    /// <summary>
    /// Returns built-ins followed by user-registered workflows (de-duplicated by command name; built-ins win).
    /// </summary>
    public static IReadOnlyList<BuiltInWorkflow> LoadAllCommands()
    {
        var builtinNames = new HashSet<string>(BuiltIns.Select(w => w.CommandName), StringComparer.Ordinal);
        var merged = new List<BuiltInWorkflow>(BuiltIns);
        foreach (var registered in RunwayCliBuiltInWorkflowRegistry.LoadAll())
        {
            if (builtinNames.Add(registered.CommandName))
            {
                merged.Add(registered);
            }
        }
        return merged;
    }

    public static Option<string?> BuildOption(BuiltInWorkflowInput input)
    {
        var description = input.Required
            ? $"{input.Description} [required]"
            : input.DefaultPreview is { Length: > 0 } preview
                ? $"{input.Description} (default: {Truncate(preview, 80)})"
                : input.Description;
        return new Option<string?>(input.Flag) { Description = description };
    }

    public static IReadOnlyDictionary<string, string?> CollectFlagValues(
        BuiltInWorkflow workflow,
        ParseResult parseResult,
        IReadOnlyDictionary<string, Option<string?>> flagOptions)
    {
        var map = new Dictionary<string, string?>(StringComparer.Ordinal);
        foreach (var input in workflow.Inputs)
        {
            map[input.Flag] = flagOptions.TryGetValue(input.Flag, out var opt) ? parseResult.GetValue(opt) : null;
        }
        return map;
    }

    /// <summary>
    /// Builds the nodeOutputs JSON object for the workflow run request.
    /// Asset values are passed through (assumed already resolved to a runway://, https://, or data: URI).
    /// Skips inputs whose flag value is null/empty so the workflow's authored defaults apply.
    /// </summary>
    public static JsonObject BuildNodeOutputs(BuiltInWorkflow workflow, IReadOnlyDictionary<string, string?> flagValues)
    {
        ArgumentNullException.ThrowIfNull(workflow);
        ArgumentNullException.ThrowIfNull(flagValues);

        var nodeOutputs = new JsonObject();
        foreach (var input in workflow.Inputs)
        {
            if (!flagValues.TryGetValue(input.Flag, out var value) || string.IsNullOrWhiteSpace(value))
            {
                if (input.Required)
                {
                    throw new ArgumentException($"{input.Flag} is required for {workflow.CommandName}.");
                }
                continue;
            }

            JsonNode wrapped = input.Kind switch
            {
                BuiltInWorkflowInputKind.Image => new JsonObject { ["type"] = "image", ["uri"] = value },
                BuiltInWorkflowInputKind.Video => new JsonObject { ["type"] = "video", ["uri"] = value },
                BuiltInWorkflowInputKind.Audio => new JsonObject { ["type"] = "audio", ["uri"] = value },
                BuiltInWorkflowInputKind.Prompt => new JsonObject { ["type"] = "primitive", ["value"] = value },
                BuiltInWorkflowInputKind.Number => new JsonObject { ["type"] = "primitive", ["value"] = ParseNumber(input.Flag, value) },
                BuiltInWorkflowInputKind.Boolean => new JsonObject { ["type"] = "primitive", ["value"] = ParseBoolean(input.Flag, value) },
                _ => throw new InvalidOperationException($"Unsupported input kind: {input.Kind}"),
            };

            var nodeKey = input.NodeId.ToString();
            if (nodeOutputs[nodeKey] is not JsonObject node)
            {
                node = new JsonObject();
                nodeOutputs[nodeKey] = node;
            }
            node[input.OutputKey] = wrapped;
        }

        return nodeOutputs;
    }

    public static async Task<int> RunAsync(
        BuiltInWorkflow workflow,
        RunwayClient client,
        string runwayVersion,
        ParseResult parseResult,
        IReadOnlyDictionary<string, Option<string?>> flagOptions,
        Option<string?> outputOption,
        Option<bool> noWaitOption,
        Option<bool> noDownloadOption,
        Option<int> pollIntervalOption,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(workflow);
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(parseResult);
        ArgumentNullException.ThrowIfNull(flagOptions);

        var flagValues = CollectFlagValues(workflow, parseResult, flagOptions);

        // Resolve asset inputs: local paths get uploaded; remote URIs pass through.
        var resolved = new Dictionary<string, string?>(flagValues, StringComparer.Ordinal);
        foreach (var input in workflow.Inputs)
        {
            if (input.Kind is not (BuiltInWorkflowInputKind.Image or BuiltInWorkflowInputKind.Video or BuiltInWorkflowInputKind.Audio))
            {
                continue;
            }
            if (!resolved.TryGetValue(input.Flag, out var value) || string.IsNullOrWhiteSpace(value))
            {
                continue;
            }
            if (LooksLikeRemoteUri(value))
            {
                continue;
            }

            var fullPath = Path.GetFullPath(value);
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"{input.Flag} file not found: {fullPath}", fullPath);
            }

            var upload = await client.Uploads.CreateUploadsAsync(
                filename: Path.GetFileName(fullPath),
                xRunwayVersion: runwayVersion,
                type: CreateUploadsRequestType.Ephemeral,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            await UploadEphemeralFileAsync(upload, fullPath, cancellationToken).ConfigureAwait(false);
            resolved[input.Flag] = upload.RunwayUri;
            await Console.Error.WriteLineAsync($"{input.Flag}: uploaded {Path.GetFileName(fullPath)} -> {upload.RunwayUri}").ConfigureAwait(false);
        }

        var nodeOutputs = BuildNodeOutputs(workflow, resolved);
        var requestBody = new JsonObject { ["nodeOutputs"] = nodeOutputs };
        var request = RunwayCliGeneration.ToGenerated<CreateWorkflowsRequest>(requestBody);

        await Console.Error.WriteLineAsync($"Submitting {workflow.CommandName} (workflow {workflow.WorkflowId})...").ConfigureAwait(false);
        var runResponse = await client.Workflows.CreateWorkflowsByIdAsync(
            id: workflow.WorkflowId,
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var invocationId = runResponse.Id;
        await Console.Error.WriteLineAsync($"Invocation ID: {invocationId}").ConfigureAwait(false);

        if (parseResult.GetValue(noWaitOption))
        {
            Console.WriteLine(invocationId);
            return 0;
        }

        var pollSeconds = parseResult.GetValue(pollIntervalOption);
        if (pollSeconds <= 0) pollSeconds = 5;
        var pollInterval = TimeSpan.FromSeconds(pollSeconds);

        // Polling uses raw HTTP + JSON because the SDK's discriminated-union deserializer
        // for GetWorkflowInvocationsResponse can populate multiple variants for the same
        // payload (it scores by field presence, not the actual `status` value), making
        // status checks unreliable. Reading `status` from the raw body is deterministic.
        InvocationPoll poll;
        while (true)
        {
            poll = await PollInvocationAsync(client, runwayVersion, invocationId, cancellationToken).ConfigureAwait(false);

            if (poll.IsTerminal)
            {
                break;
            }
            if (poll.Status == "RUNNING" && poll.Progress is { } progress)
            {
                await Console.Error.WriteLineAsync($"Progress: {progress * 100:F1}% (RUNNING)").ConfigureAwait(false);
            }
            else
            {
                await Console.Error.WriteLineAsync($"Status: {poll.Status}").ConfigureAwait(false);
            }
            await Task.Delay(pollInterval, cancellationToken).ConfigureAwait(false);
        }

        if (poll.Status == "FAILED")
        {
            await Console.Error.WriteLineAsync($"Workflow FAILED ({poll.FailureCode ?? "n/a"}): {poll.Failure}").ConfigureAwait(false);
            Console.WriteLine(JsonSerializer.Serialize(new { id = invocationId, status = "FAILED", failure = poll.Failure, failureCode = poll.FailureCode }));
            return 1;
        }
        if (poll.Status == "CANCELLED")
        {
            await Console.Error.WriteLineAsync($"Workflow CANCELLED.").ConfigureAwait(false);
            Console.WriteLine(JsonSerializer.Serialize(new { id = invocationId, status = "CANCELLED" }));
            return 1;
        }

        if (poll.Status != "SUCCEEDED" || poll.Output is null)
        {
            throw new InvalidOperationException($"Workflow ended in an unexpected state: {poll.Status}");
        }

        await Console.Error.WriteLineAsync($"Workflow SUCCEEDED with {poll.Output.Count} output node(s).").ConfigureAwait(false);

        IReadOnlyList<string> downloadedFiles = [];
        if (!parseResult.GetValue(noDownloadOption))
        {
            var outputDir = parseResult.GetValue(outputOption) is { Length: > 0 } explicitOutput
                ? explicitOutput
                : Path.Combine(Environment.CurrentDirectory, $"runway-{workflow.CommandName}");
            downloadedFiles = await DownloadOutputUrlsAsync(invocationId, poll.Output, outputDir, cancellationToken).ConfigureAwait(false);
            await Console.Error.WriteLineAsync($"Downloaded {downloadedFiles.Count} file(s) to {outputDir}").ConfigureAwait(false);
            foreach (var file in downloadedFiles)
            {
                await Console.Error.WriteLineAsync($"  {file}").ConfigureAwait(false);
            }
        }

        Console.WriteLine(JsonSerializer.Serialize(new
        {
            id = invocationId,
            status = "SUCCEEDED",
            outputs = poll.Output,
            files = downloadedFiles,
        }));
        return 0;
    }

    internal sealed record InvocationPoll(
        string Status,
        double? Progress,
        string? Failure,
        string? FailureCode,
        IReadOnlyDictionary<string, IReadOnlyList<string>>? Output)
    {
        public bool IsTerminal => Status is "SUCCEEDED" or "FAILED" or "CANCELLED";
    }

    internal static async Task<InvocationPoll> PollInvocationAsync(
        RunwayClient client,
        string runwayVersion,
        Guid invocationId,
        CancellationToken cancellationToken)
    {
        var response = await client.Workflows.GetWorkflowInvocationsByIdAsync(
            id: invocationId,
            xRunwayVersion: runwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var status = response.Status?.ToValueString() ?? "UNKNOWN";
        var progress = response.Running?.Progress;
        var failure = response.Failed?.Failure;
        var failureCode = response.Failed?.FailureCode;

        Dictionary<string, IReadOnlyList<string>>? output = null;
        var rawOutput = response.Succeeded?.Output ?? response.Running?.Output;
        if (rawOutput is not null)
        {
            output = new Dictionary<string, IReadOnlyList<string>>(StringComparer.Ordinal);
            foreach (var entry in rawOutput)
            {
                output[entry.Key] = entry.Value
                    .Where(static x => !string.IsNullOrEmpty(x))
                    .ToArray();
            }
        }

        return new InvocationPoll(status, progress, failure, failureCode, output);
    }

    public static async Task<IReadOnlyList<string>> DownloadOutputUrlsAsync(
        Guid invocationId,
        IReadOnlyDictionary<string, IReadOnlyList<string>> output,
        string outputDirectory,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(output);
        Directory.CreateDirectory(outputDirectory);

        var paths = new List<string>();
        using var http = new HttpClient();
        var stem = string.Create(CultureInfo.InvariantCulture, $"runway-{invocationId:N}");

        foreach (var (nodeId, urls) in output)
        {
            var nodeShort = nodeId.Length >= 8 ? nodeId[..8] : nodeId;
            for (var i = 0; i < urls.Count; i++)
            {
                var url = urls[i];
                if (!Uri.TryCreate(url, UriKind.Absolute, out var parsed))
                {
                    continue;
                }
                var ext = RunwayTaskExtensions.GetOutputExtension(parsed, ".bin");
                var fileName = urls.Count == 1
                    ? $"{stem}-{nodeShort}{ext}"
                    : $"{stem}-{nodeShort}-{i + 1}{ext}";
                var filePath = Path.Combine(outputDirectory, fileName);

                using var response = await http.GetAsync(parsed, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                using var input = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                using var fileStream = File.Create(filePath);
                await input.CopyToAsync(fileStream, cancellationToken).ConfigureAwait(false);
                paths.Add(filePath);
            }
        }

        return paths;
    }

    public static async Task UploadEphemeralFileAsync(
        CreateUploadsResponse upload,
        string file,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(upload);
        var path = Path.GetFullPath(file);
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Upload file was not found: {path}", path);
        }

        using var form = new MultipartFormDataContent();
        foreach (var field in upload.Fields)
        {
            form.Add(new StringContent(field.Value), field.Key);
        }

        var fileContent = new ByteArrayContent(await File.ReadAllBytesAsync(path, cancellationToken).ConfigureAwait(false));
        fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(RunwayCliGeneration.GetMediaType(path));
        form.Add(fileContent, "file", Path.GetFileName(path));

        using var httpClient = new HttpClient();
        using var response = await httpClient.PostAsync(upload.UploadUrl, form, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            throw new InvalidOperationException($"Upload failed with HTTP {(int)response.StatusCode}: {responseBody}");
        }
    }

    private static bool LooksLikeRemoteUri(string value) =>
        value.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ||
        value.StartsWith("runway://", StringComparison.OrdinalIgnoreCase) ||
        value.StartsWith("data:", StringComparison.OrdinalIgnoreCase);

    private static double ParseNumber(string flag, string value) =>
        double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var n)
            ? n
            : throw new ArgumentException($"{flag} expects a number, got: {value}");

    private static bool ParseBoolean(string flag, string value) =>
        bool.TryParse(value, out var b)
            ? b
            : throw new ArgumentException($"{flag} expects 'true' or 'false', got: {value}");

    private static string Truncate(string value, int max) =>
        value.Length <= max ? value : string.Concat(value.AsSpan(0, max - 1), "…");
}
