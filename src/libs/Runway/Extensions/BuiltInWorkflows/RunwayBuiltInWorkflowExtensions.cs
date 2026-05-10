using System.Globalization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;

#pragma warning disable CA1054 // Uri parameters; we genuinely accept https/runway/data URIs as strings here.
#pragma warning disable CA1308 // Lowercase media-type extensions are intentional.
#pragma warning disable CA2000 // StringContent / StreamContent are owned by MultipartFormDataContent and disposed with it.

namespace Runway;

/// <summary>
/// Extension methods on <see cref="RunwayClient"/> for invoking the curated set of built-in
/// workflows shipped with this SDK release.
/// </summary>
public static class RunwayBuiltInWorkflowExtensions
{
    /// <summary>
    /// Run one of the built-in workflows end-to-end: auto-upload any local-file or stream
    /// asset inputs, submit the workflow, optionally poll until a terminal status, and return
    /// the per-node output URIs.
    /// </summary>
    /// <param name="client">An authenticated <see cref="RunwayClient"/>.</param>
    /// <param name="workflow">The built-in workflow to invoke (look up via <see cref="BuiltInWorkflows"/>).</param>
    /// <param name="inputs">Per-flag inputs supplied by the caller. Required asset inputs missing → throws.</param>
    /// <param name="waitForCompletion">When true (default), polls until terminal status; when false, returns immediately after submission with <see cref="BuiltInWorkflowStatus.Pending"/>.</param>
    /// <param name="pollInterval">Polling cadence when waiting. Defaults to 5 seconds.</param>
    /// <param name="progress">Optional progress callback invoked with the running fraction in <c>[0,1]</c>.</param>
    /// <param name="xRunwayVersion">Runway API version header. Defaults to <c>2024-11-06</c>.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The invocation result: ID, status, per-node output URIs, and any failure reason.</returns>
    public static async Task<BuiltInWorkflowResult> RunBuiltInWorkflowAsync(
        this RunwayClient client,
        BuiltInWorkflow workflow,
        BuiltInWorkflowInputs inputs,
        bool waitForCompletion = true,
        TimeSpan? pollInterval = null,
        IProgress<double>? progress = null,
        string xRunwayVersion = "2024-11-06",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(workflow);
        ArgumentNullException.ThrowIfNull(inputs);

        // 1. Resolve every input value into a runway URI (for assets) or primitive (for prompts).
        var nodeOutputs = new JsonObject();
        foreach (var input in workflow.Inputs)
        {
            if (!inputs.Values.TryGetValue(input.Flag, out var value) || value is null)
            {
                if (input.Required)
                {
                    throw new ArgumentException($"{input.Flag} is required for {workflow.CommandName}.");
                }
                continue;
            }

            JsonNode wrapped = input.Kind switch
            {
                BuiltInWorkflowInputKind.Image or BuiltInWorkflowInputKind.Video or BuiltInWorkflowInputKind.Audio
                    => new JsonObject
                    {
                        ["type"] = AssetTypeName(input.Kind),
                        ["uri"] = await ResolveAssetUriAsync(client, input, value, xRunwayVersion, cancellationToken).ConfigureAwait(false),
                    },
                BuiltInWorkflowInputKind.Prompt => new JsonObject
                {
                    ["type"] = "primitive",
                    ["value"] = value switch
                    {
                        BuiltInWorkflowValue.TextValue t => t.Text,
                        _ => throw new ArgumentException($"{input.Flag} is a Prompt input; supply a text value via Set(string, string)."),
                    },
                },
                BuiltInWorkflowInputKind.Number => new JsonObject
                {
                    ["type"] = "primitive",
                    ["value"] = value switch
                    {
                        BuiltInWorkflowValue.NumberValue n => JsonValue.Create(n.Number),
                        BuiltInWorkflowValue.TextValue t when double.TryParse(t.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed) => JsonValue.Create(parsed),
                        _ => throw new ArgumentException($"{input.Flag} is a Number input; supply a numeric value via SetNumber."),
                    },
                },
                BuiltInWorkflowInputKind.Boolean => new JsonObject
                {
                    ["type"] = "primitive",
                    ["value"] = value switch
                    {
                        BuiltInWorkflowValue.BooleanValue b => JsonValue.Create(b.Boolean),
                        BuiltInWorkflowValue.TextValue t when bool.TryParse(t.Text, out var parsed) => JsonValue.Create(parsed),
                        _ => throw new ArgumentException($"{input.Flag} is a Boolean input; supply a boolean value via SetBoolean."),
                    },
                },
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

        // 2. Submit the workflow. Convert the JsonObject tree into a plain dict-of-dicts so
        //    the SDK's source-generated serializer can emit it without falling back on
        //    reflection-based deserialization (trim-safe).
        var nodeOutputsDict = new Dictionary<string, object>(StringComparer.Ordinal);
        foreach (var (key, val) in nodeOutputs)
        {
            if (val is not JsonObject obj) continue;
            var inner = new Dictionary<string, object>(StringComparer.Ordinal);
            foreach (var (innerKey, innerVal) in obj)
            {
                if (innerVal is null) continue;
                inner[innerKey] = innerVal;
            }
            nodeOutputsDict[key] = inner;
        }

        var request = new CreateWorkflowsRequest { NodeOutputs = nodeOutputsDict };
        var runResponse = await client.Workflows.CreateWorkflowsByIdAsync(
            id: workflow.WorkflowId,
            request: request,
            xRunwayVersion: xRunwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);
        var invocationId = runResponse.Id;

        if (!waitForCompletion)
        {
            return new BuiltInWorkflowResult(invocationId, BuiltInWorkflowStatus.Pending, EmptyOutputs);
        }

        // 3. Poll via raw HTTP, parsing the status field directly. The generated discriminator
        //    converter for GetWorkflowInvocationsResponse can populate multiple variants for the
        //    same payload (see tryAGI/AutoSDK#315), so we read the JSON directly.
        var interval = pollInterval ?? TimeSpan.FromSeconds(5);
        if (interval <= TimeSpan.Zero) interval = TimeSpan.FromSeconds(5);

        InvocationPoll poll;
        while (true)
        {
            poll = await PollInvocationAsync(client, xRunwayVersion, invocationId, cancellationToken).ConfigureAwait(false);
            if (poll.IsTerminal) break;
            if (poll.Progress is { } p) progress?.Report(p);
            await Task.Delay(interval, cancellationToken).ConfigureAwait(false);
        }

        return poll.Status switch
        {
            "SUCCEEDED" => new BuiltInWorkflowResult(invocationId, BuiltInWorkflowStatus.Succeeded, poll.Output ?? EmptyOutputs),
            "FAILED" => new BuiltInWorkflowResult(invocationId, BuiltInWorkflowStatus.Failed, EmptyOutputs, poll.Failure, poll.FailureCode),
            "CANCELLED" => new BuiltInWorkflowResult(invocationId, BuiltInWorkflowStatus.Cancelled, EmptyOutputs),
            _ => throw new InvalidOperationException($"Workflow ended in an unexpected state: {poll.Status}"),
        };
    }

    private static readonly IReadOnlyDictionary<Guid, IReadOnlyList<Uri>> EmptyOutputs =
        new Dictionary<Guid, IReadOnlyList<Uri>>();

    private static string AssetTypeName(BuiltInWorkflowInputKind kind) => kind switch
    {
        BuiltInWorkflowInputKind.Image => "image",
        BuiltInWorkflowInputKind.Video => "video",
        BuiltInWorkflowInputKind.Audio => "audio",
        _ => throw new InvalidOperationException($"Not an asset kind: {kind}"),
    };

    private static async Task<string> ResolveAssetUriAsync(
        RunwayClient client,
        BuiltInWorkflowInput input,
        BuiltInWorkflowValue value,
        string xRunwayVersion,
        CancellationToken cancellationToken)
    {
        switch (value)
        {
            case BuiltInWorkflowValue.UriValue u:
                return u.Uri.ToString();
            case BuiltInWorkflowValue.TextValue t:
                {
                    if (LooksLikeRemoteUri(t.Text)) return t.Text;
                    // Treat as a local file path.
                    return await UploadLocalFileAsync(client, t.Text, xRunwayVersion, cancellationToken).ConfigureAwait(false);
                }
            case BuiltInWorkflowValue.FilePathValue f:
                {
                    if (LooksLikeRemoteUri(f.Path)) return f.Path;
                    return await UploadLocalFileAsync(client, f.Path, xRunwayVersion, cancellationToken).ConfigureAwait(false);
                }
            case BuiltInWorkflowValue.StreamValue s:
                {
                    return await UploadStreamAsync(client, s.Stream, s.FileName, xRunwayVersion, cancellationToken).ConfigureAwait(false);
                }
            case BuiltInWorkflowValue.BytesValue b:
                {
                    using var ms = new MemoryStream(b.Bytes, writable: false);
                    return await UploadStreamAsync(client, ms, b.FileName, xRunwayVersion, cancellationToken).ConfigureAwait(false);
                }
            default:
                throw new ArgumentException($"{input.Flag} expects an asset (Image/Video/Audio); got {value.GetType().Name}.");
        }
    }

    private static bool LooksLikeRemoteUri(string value) =>
        value.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ||
        value.StartsWith("runway://", StringComparison.OrdinalIgnoreCase) ||
        value.StartsWith("data:", StringComparison.OrdinalIgnoreCase);

    private static async Task<string> UploadLocalFileAsync(
        RunwayClient client,
        string path,
        string xRunwayVersion,
        CancellationToken cancellationToken)
    {
        var fullPath = Path.GetFullPath(path);
        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Asset file not found: {fullPath}", fullPath);
        }
        var stream = File.OpenRead(fullPath);
        await using (stream.ConfigureAwait(false))
        {
            return await UploadStreamAsync(client, stream, Path.GetFileName(fullPath), xRunwayVersion, cancellationToken).ConfigureAwait(false);
        }
    }

    private static async Task<string> UploadStreamAsync(
        RunwayClient client,
        Stream stream,
        string fileName,
        string xRunwayVersion,
        CancellationToken cancellationToken)
    {
        var upload = await client.Uploads.CreateUploadsAsync(
            filename: fileName,
            xRunwayVersion: xRunwayVersion,
            type: CreateUploadsRequestType.Ephemeral,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        using var form = new MultipartFormDataContent();
        foreach (var (k, v) in upload.Fields)
        {
            form.Add(new StringContent(v), k);
        }
        var fileContent = new StreamContent(stream);
        if (!string.IsNullOrWhiteSpace(fileName))
        {
            var ext = Path.GetExtension(fileName).TrimStart('.').ToLowerInvariant();
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(ext switch
            {
                "png" => "image/png",
                "jpg" or "jpeg" => "image/jpeg",
                "webp" => "image/webp",
                "gif" => "image/gif",
                "mp4" => "video/mp4",
                "mov" => "video/quicktime",
                "webm" => "video/webm",
                "mp3" => "audio/mpeg",
                "wav" => "audio/wav",
                "ogg" => "audio/ogg",
                _ => "application/octet-stream",
            });
        }
        form.Add(fileContent, "file", fileName);

        using var http = new HttpClient();
        using var response = await http.PostAsync(new Uri(upload.UploadUrl), form, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            throw new InvalidOperationException($"Upload failed with HTTP {(int)response.StatusCode}: {body}");
        }
        return upload.RunwayUri;
    }

    private sealed record InvocationPoll(
        string Status,
        double? Progress,
        string? Failure,
        string? FailureCode,
        IReadOnlyDictionary<Guid, IReadOnlyList<Uri>>? Output)
    {
        public bool IsTerminal => Status is "SUCCEEDED" or "FAILED" or "CANCELLED";
    }

    private static async Task<InvocationPoll> PollInvocationAsync(
        RunwayClient client,
        string xRunwayVersion,
        Guid invocationId,
        CancellationToken cancellationToken)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/workflow_invocations/{invocationId}");
        request.Headers.Add("X-Runway-Version", xRunwayVersion);
        request.Headers.Authorization = GetBearerAuthorization(client);

        using var response = await client.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"Workflow invocation poll failed with HTTP {(int)response.StatusCode}: {body}");
        }
        return ParseInvocationPoll(body);
    }

    private static InvocationPoll ParseInvocationPoll(string body)
    {
        using var document = JsonDocument.Parse(body);
        var root = document.RootElement;
        var status = root.TryGetProperty("status", out var statusEl) && statusEl.ValueKind == JsonValueKind.String
            ? statusEl.GetString() ?? "UNKNOWN"
            : "UNKNOWN";

        double? progress = root.TryGetProperty("progress", out var progressEl) && progressEl.ValueKind == JsonValueKind.Number
            ? progressEl.GetDouble()
            : null;
        var failure = root.TryGetProperty("failure", out var failureEl) && failureEl.ValueKind == JsonValueKind.String
            ? failureEl.GetString()
            : null;
        var failureCode = root.TryGetProperty("failureCode", out var failureCodeEl) && failureCodeEl.ValueKind == JsonValueKind.String
            ? failureCodeEl.GetString()
            : null;

        Dictionary<Guid, IReadOnlyList<Uri>>? output = null;
        if (root.TryGetProperty("output", out var outputEl) && outputEl.ValueKind == JsonValueKind.Object)
        {
            output = new Dictionary<Guid, IReadOnlyList<Uri>>();
            foreach (var property in outputEl.EnumerateObject())
            {
                if (property.Value.ValueKind != JsonValueKind.Array) continue;
                if (!Guid.TryParse(property.Name, out var nodeId)) continue;
                var urls = new List<Uri>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.String &&
                        item.GetString() is { Length: > 0 } urlString &&
                        Uri.TryCreate(urlString, UriKind.Absolute, out var parsedUri))
                    {
                        urls.Add(parsedUri);
                    }
                }
                output[nodeId] = urls;
            }
        }

        return new InvocationPoll(status, progress, failure, failureCode, output);
    }

    private static AuthenticationHeaderValue GetBearerAuthorization(RunwayClient client)
    {
        foreach (var authorization in client.Authorizations)
        {
            if (authorization.Type == "Http" &&
                authorization.Name == "Bearer" &&
                authorization.Value is { Length: > 0 } value)
            {
                return new AuthenticationHeaderValue("Bearer", value);
            }
        }
        throw new InvalidOperationException("Runway client is missing bearer authorization.");
    }
}
