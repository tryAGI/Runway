using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

// Historical CLI names → SDK types. New CLI code should use the SDK names directly.

/// <summary>
/// Reads/writes user-registered custom workflow definitions to ~/.runway-cli/workflows/<command>.json.
///
/// Storage shape: { commandName, description, picks: [{flag,nodeId,description}], graph: <full GET response> }.
/// Inputs (kind/outputKey/required/defaultPreview) are NOT stored; they're re-derived from the cached
/// graph each time LoadAll runs. This mirrors how built-in workflows work
/// (see <see cref="BuiltInWorkflows.MaterializeFromGraph"/>) and keeps `runway --help` accurate
/// when the workflow author edits defaults — the user just re-runs `workflow register --id <uuid>` and
/// every dynamic command picks up the new metadata on next invocation.
///
/// Storage location can be overridden by RUNWAY_CLI_HOME (matches the auth/soul-id pattern).
/// </summary>
internal static class RunwayCliBuiltInWorkflowRegistry
{
    public const string DirectoryName = "workflows";

    private static readonly JsonSerializerOptions WriteOptions = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    public static string GetDirectory()
    {
        var home = Environment.GetEnvironmentVariable("RUNWAY_CLI_HOME") is { Length: > 0 } overridden
            ? overridden
            : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(home, ".runway-cli", DirectoryName);
    }

    public static IReadOnlyList<BuiltInWorkflow> LoadAll()
    {
        var directory = GetDirectory();
        if (!Directory.Exists(directory)) return [];

        var workflows = new List<BuiltInWorkflow>();
        foreach (var path in Directory.EnumerateFiles(directory, "*.json"))
        {
            if (TryReadEntry(path, out var workflow, out _))
            {
                workflows.Add(workflow);
            }
        }
        return workflows;
    }

    public sealed record RawEntry(string FilePath, string CommandName, Guid? WorkflowId, string DisplayName, int PicksCount, string? Error);

    public static IReadOnlyList<RawEntry> EnumerateRaw()
    {
        var directory = GetDirectory();
        if (!Directory.Exists(directory)) return [];

        var entries = new List<RawEntry>();
        foreach (var path in Directory.EnumerateFiles(directory, "*.json"))
        {
            try
            {
                var node = JsonNode.Parse(File.ReadAllText(path)) as JsonObject
                    ?? throw new InvalidOperationException("File is not a JSON object.");
                var commandName = node["commandName"]?.GetValue<string>() ?? string.Empty;
                var picks = node["picks"] as JsonArray;
                Guid? workflowId = null;
                var displayName = string.Empty;
                if (node["graph"] is JsonObject graph)
                {
                    if (graph["id"]?.GetValue<string>() is { Length: > 0 } gid && Guid.TryParse(gid, out var parsedId))
                    {
                        workflowId = parsedId;
                    }
                    displayName = graph["name"]?.GetValue<string>() ?? string.Empty;
                }
                entries.Add(new RawEntry(path, commandName, workflowId, displayName, picks?.Count ?? 0, null));
            }
            catch (Exception ex)
            {
                entries.Add(new RawEntry(path, Path.GetFileNameWithoutExtension(path), null, string.Empty, 0, ex.Message));
            }
        }
        return entries;
    }

    /// <summary>
    /// Persists a registered workflow as { commandName, description, picks, graph } under
    /// ~/.runway-cli/workflows/&lt;command&gt;.json. Returns the file path.
    /// </summary>
    public static string Save(string commandName, string description, IReadOnlyList<BuiltInWorkflowPick> picks, string graphJson)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(commandName);
        ArgumentNullException.ThrowIfNull(picks);
        ArgumentException.ThrowIfNullOrWhiteSpace(graphJson);
        if (picks.Count == 0)
        {
            throw new InvalidOperationException(
                $"Refusing to register '{commandName}' with no picks: a command without overrides would just re-run the workflow's authored defaults every time. "
                + "If the analyzer found no exposed inputs, mark at least one node `exposedToApp: true` in the workflow editor and republish.");
        }

        var directory = GetDirectory();
        Directory.CreateDirectory(directory);
        var path = Path.Combine(directory, $"{commandName}.json");

        var picksArray = new JsonArray();
        foreach (var pick in picks)
        {
            picksArray.Add(new JsonObject
            {
                ["flag"] = pick.Flag,
                ["nodeId"] = pick.NodeId.ToString(),
                ["description"] = pick.Description,
            });
        }

        var entry = new JsonObject
        {
            ["commandName"] = commandName,
            ["description"] = description,
            ["picks"] = picksArray,
            ["graph"] = JsonNode.Parse(graphJson),
        };

        File.WriteAllText(path, entry.ToJsonString(WriteOptions));
        return path;
    }

    public static bool Remove(string commandName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(commandName);
        var path = Path.Combine(GetDirectory(), $"{commandName}.json");
        if (!File.Exists(path)) return false;
        File.Delete(path);
        return true;
    }

    public static bool TryReadEntry(string path, out BuiltInWorkflow workflow, out string? error)
    {
        workflow = default!;
        error = null;
        try
        {
            var node = JsonNode.Parse(File.ReadAllText(path)) as JsonObject
                ?? throw new InvalidOperationException("File is not a JSON object.");
            var commandName = node["commandName"]?.GetValue<string>()
                ?? throw new InvalidOperationException("Missing 'commandName'.");
            var description = node["description"]?.GetValue<string>() ?? string.Empty;
            var picksJson = node["picks"] as JsonArray
                ?? throw new InvalidOperationException("Missing 'picks' array.");
            var graphNode = node["graph"]
                ?? throw new InvalidOperationException("Missing 'graph' snapshot.");

            var picks = new List<BuiltInWorkflowPick>(picksJson.Count);
            foreach (var item in picksJson)
            {
                if (item is not JsonObject obj) continue;
                var flag = obj["flag"]?.GetValue<string>() ?? throw new InvalidOperationException("Pick missing flag.");
                var nodeIdStr = obj["nodeId"]?.GetValue<string>() ?? throw new InvalidOperationException($"Pick {flag} missing nodeId.");
                if (!Guid.TryParse(nodeIdStr, out var nodeId))
                {
                    throw new InvalidOperationException($"Pick {flag} has invalid nodeId {nodeIdStr}.");
                }
                var description2 = obj["description"]?.GetValue<string>() ?? string.Empty;
                picks.Add(new BuiltInWorkflowPick(flag, nodeId, description2));
            }

            workflow = BuiltInWorkflows.MaterializeFromGraph(
                commandName: commandName,
                description: description,
                category: BuiltInWorkflowCategory.Uncategorized,
                picks: picks,
                graphJson: graphNode.ToJsonString(),
                source: $"registered workflow at {path}");
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }

    /// <summary>
    /// Walks a workflow graph and derives a default pick list (one pick per exposed asset/constant input)
    /// using slug rules: nodeProps.name (slugified) when set, type-indexed fallback otherwise; duplicate
    /// labels get -N suffixes by graph position.
    /// Returns the picks plus a derived (commandName, description) for the workflow as a whole.
    /// </summary>
    public static AnalyzedWorkflow AnalyzeGraph(string responseJson, string? overrideCommandName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(responseJson);
        using var document = JsonDocument.Parse(responseJson);
        return AnalyzeGraph(document.RootElement, overrideCommandName);
    }

    public sealed record AnalyzedWorkflow(
        string CommandName,
        Guid WorkflowId,
        string DisplayName,
        string Description,
        IReadOnlyList<BuiltInWorkflowPick> Picks);

    public static AnalyzedWorkflow AnalyzeGraph(JsonElement root, string? overrideCommandName)
    {
        if (!root.TryGetProperty("id", out var idEl) || !Guid.TryParse(idEl.GetString(), out var workflowId))
        {
            throw new InvalidOperationException("Workflow response missing 'id'.");
        }

        var displayName = root.TryGetProperty("name", out var nameEl) && nameEl.ValueKind == JsonValueKind.String
            ? nameEl.GetString() ?? string.Empty
            : string.Empty;
        var description = root.TryGetProperty("description", out var descEl) && descEl.ValueKind == JsonValueKind.String
            ? descEl.GetString() ?? string.Empty
            : $"Run the published Runway workflow '{displayName}'.";

        var commandName = overrideCommandName is { Length: > 0 } o
            ? Slugify(o)
            : Slugify(displayName) is { Length: > 0 } nameSlug
                ? nameSlug
                : workflowId.ToString();

        if (!root.TryGetProperty("graph", out var graphEl) || graphEl.ValueKind != JsonValueKind.Object ||
            !graphEl.TryGetProperty("nodes", out var nodesEl) || nodesEl.ValueKind != JsonValueKind.Array)
        {
            return new AnalyzedWorkflow(commandName, workflowId, displayName, description, []);
        }

        var collected = new List<NodeCollect>();
        foreach (var node in nodesEl.EnumerateArray())
        {
            if (TryReadInput(node, out var c)) collected.Add(c);
        }
        collected.Sort((a, b) =>
        {
            var dy = a.Y.CompareTo(b.Y);
            if (dy != 0) return dy;
            var dx = a.X.CompareTo(b.X);
            if (dx != 0) return dx;
            return a.NodeId.CompareTo(b.NodeId);
        });

        var labelCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        foreach (var item in collected)
        {
            if (item.Label is { Length: > 0 } label)
            {
                labelCounts[label] = labelCounts.TryGetValue(label, out var c) ? c + 1 : 1;
            }
        }

        var labelSeen = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var typeIndices = new Dictionary<BuiltInWorkflowInputKind, int>();
        var picks = new List<BuiltInWorkflowPick>();
        foreach (var item in collected)
        {
            string slug;
            if (item.Label is { Length: > 0 } label)
            {
                var labelSlug = Slugify(label);
                if (labelCounts[label] > 1)
                {
                    var n = labelSeen.TryGetValue(label, out var taken) ? taken + 1 : 1;
                    labelSeen[label] = n;
                    slug = $"{labelSlug}-{n}";
                }
                else
                {
                    slug = labelSlug;
                }
            }
            else
            {
                var typeName = TypeNameFor(item.Kind);
                var index = typeIndices.TryGetValue(item.Kind, out var taken) ? taken : 0;
                typeIndices[item.Kind] = index + 1;
                slug = $"{typeName}-{index + 1}";
            }

            picks.Add(new BuiltInWorkflowPick(
                Flag: $"--{slug}",
                NodeId: item.NodeId,
                Description: item.Label is { Length: > 0 } l ? l : $"Override the {TypeNameFor(item.Kind)} input on node {item.NodeId.ToString()[..8]}."));
        }

        return new AnalyzedWorkflow(commandName, workflowId, displayName, description, picks);
    }

    private static bool TryReadInput(JsonElement node, out NodeCollect collect)
    {
        collect = default!;
        if (!node.TryGetProperty("nodeType", out var nodeTypeEl) || nodeTypeEl.ValueKind != JsonValueKind.String) return false;

        var nodeType = nodeTypeEl.GetString();
        BuiltInWorkflowInputKind? kind = null;
        string? outputKey = null;
        if (nodeType == "asset-node" && node.TryGetProperty("assetNodeType", out var assetEl) && assetEl.ValueKind == JsonValueKind.String)
        {
            switch (assetEl.GetString())
            {
                case "image": kind = BuiltInWorkflowInputKind.Image; outputKey = "image"; break;
                case "video": kind = BuiltInWorkflowInputKind.Video; outputKey = "video"; break;
                case "audio": kind = BuiltInWorkflowInputKind.Audio; outputKey = "audio"; break;
            }
        }
        else if (nodeType == "constant-node" && node.TryGetProperty("constantNodeType", out var constEl) && constEl.ValueKind == JsonValueKind.String)
        {
            switch (constEl.GetString())
            {
                case "prompt": kind = BuiltInWorkflowInputKind.Prompt; outputKey = "prompt"; break;
                case "number": kind = BuiltInWorkflowInputKind.Number; outputKey = "number"; break;
                case "boolean": kind = BuiltInWorkflowInputKind.Boolean; outputKey = "boolean"; break;
            }
        }
        if (kind is null || outputKey is null) return false;

        if (!node.TryGetProperty("id", out var idEl) || !Guid.TryParse(idEl.GetString(), out var nodeId)) return false;

        if (!node.TryGetProperty("nodeOutputs", out var outputsEl) || outputsEl.ValueKind != JsonValueKind.Object) return false;
        if (!outputsEl.TryGetProperty(outputKey, out var outputEl) || outputEl.ValueKind != JsonValueKind.Object) return false;
        var exposed = outputEl.TryGetProperty("exposedToApp", out var exposedEl) && exposedEl.ValueKind == JsonValueKind.True;
        if (!exposed) return false;

        string? label = null;
        if (node.TryGetProperty("nodeProps", out var propsEl) && propsEl.ValueKind == JsonValueKind.Object &&
            propsEl.TryGetProperty("name", out var nameEl) && nameEl.ValueKind == JsonValueKind.String &&
            nameEl.GetString() is { Length: > 0 } propName)
        {
            label = propName;
        }
        else if (outputEl.TryGetProperty("label", out var labelEl) && labelEl.ValueKind == JsonValueKind.String &&
                 labelEl.GetString() is { Length: > 0 } outputLabel)
        {
            label = outputLabel;
        }

        double y = 0, x = 0;
        if (node.TryGetProperty("nodeProps", out var props2El) && props2El.ValueKind == JsonValueKind.Object &&
            props2El.TryGetProperty("position", out var posEl) && posEl.ValueKind == JsonValueKind.Object)
        {
            if (posEl.TryGetProperty("y", out var yEl) && yEl.ValueKind == JsonValueKind.Number) y = yEl.GetDouble();
            if (posEl.TryGetProperty("x", out var xEl) && xEl.ValueKind == JsonValueKind.Number) x = xEl.GetDouble();
        }

        collect = new NodeCollect(nodeId, kind.Value, outputKey, label, y, x);
        return true;
    }

    private static string TypeNameFor(BuiltInWorkflowInputKind kind) => kind switch
    {
        BuiltInWorkflowInputKind.Image => "image",
        BuiltInWorkflowInputKind.Video => "video",
        BuiltInWorkflowInputKind.Audio => "audio",
        BuiltInWorkflowInputKind.Prompt => "prompt",
        BuiltInWorkflowInputKind.Number => "number",
        BuiltInWorkflowInputKind.Boolean => "boolean",
        _ => "input",
    };

    public static string Slugify(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return string.Empty;

        var sb = new System.Text.StringBuilder(value.Length);
        var lastWasDash = true;
        foreach (var ch in value)
        {
            if (ch is >= 'a' and <= 'z' or >= '0' and <= '9')
            {
                sb.Append(ch);
                lastWasDash = false;
            }
            else if (ch is >= 'A' and <= 'Z')
            {
                sb.Append(char.ToLower(ch, CultureInfo.InvariantCulture));
                lastWasDash = false;
            }
            else if (!lastWasDash)
            {
                sb.Append('-');
                lastWasDash = true;
            }
        }
        return sb.ToString().Trim('-');
    }

    private readonly record struct NodeCollect(
        Guid NodeId,
        BuiltInWorkflowInputKind Kind,
        string OutputKey,
        string? Label,
        double Y,
        double X);
}
