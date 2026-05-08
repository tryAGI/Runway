using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

internal enum RunwayCliShortVideoPlannerKind
{
    Auto,
    Claude,
    Codex,
    Deterministic,
}

internal enum RunwayCliShortVideoPlannerTools
{
    ReadOnly,
    None,
}

internal sealed record RunwayCliShortVideoPlannerOptions(
    RunwayCliShortVideoPlannerKind Kind,
    string? Model,
    RunwayCliShortVideoPlannerTools Tools,
    TimeSpan Timeout);

internal static partial class RunwayCliShortVideo
{
    private const string DefaultClaudePlannerModel = "opus";
    private const int DefaultPlannerTimeoutSeconds = 180;

    public static RunwayCliShortVideoPlannerOptions CreatePlannerOptions(
        string? planner,
        string? model,
        string? tools,
        int? timeoutSeconds)
    {
        var kind = ParsePlannerKind(FirstNonEmpty(planner, Environment.GetEnvironmentVariable("RUNWAY_SHORT_VIDEO_PLANNER")) ?? "auto");
        var resolvedModel = FirstNonEmpty(model, Environment.GetEnvironmentVariable("RUNWAY_SHORT_VIDEO_PLANNER_MODEL"));
        var resolvedTools = ParsePlannerTools(FirstNonEmpty(tools, Environment.GetEnvironmentVariable("RUNWAY_SHORT_VIDEO_PLANNER_TOOLS")) ?? "read-only");
        var resolvedTimeoutSeconds = timeoutSeconds ??
            ParseOptionalPositiveInt(
                Environment.GetEnvironmentVariable("RUNWAY_SHORT_VIDEO_PLANNER_TIMEOUT_SECONDS"),
                "RUNWAY_SHORT_VIDEO_PLANNER_TIMEOUT_SECONDS") ??
            DefaultPlannerTimeoutSeconds;

        if (resolvedTimeoutSeconds <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(timeoutSeconds), "--planner-timeout-seconds must be greater than 0.");
        }

        return new RunwayCliShortVideoPlannerOptions(
            kind,
            resolvedModel,
            resolvedTools,
            TimeSpan.FromSeconds(resolvedTimeoutSeconds));
    }

    public static async Task<RunwayShortVideoPlan> CreatePlanAsync(
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        return plannerOptions.Kind switch
        {
            RunwayCliShortVideoPlannerKind.Deterministic => RunwayShortVideoExtensions.CreateShortVideoPlan(scenarioText, options),
            RunwayCliShortVideoPlannerKind.Claude => await CreatePlanWithRequiredExternalPlannerAsync(
                RunwayCliShortVideoPlannerKind.Claude,
                scenarioText,
                options,
                plannerOptions,
                cancellationToken).ConfigureAwait(false),
            RunwayCliShortVideoPlannerKind.Codex => await CreatePlanWithRequiredExternalPlannerAsync(
                RunwayCliShortVideoPlannerKind.Codex,
                scenarioText,
                options,
                plannerOptions,
                cancellationToken).ConfigureAwait(false),
            _ => await CreatePlanWithAutoPlannerAsync(scenarioText, options, plannerOptions, cancellationToken).ConfigureAwait(false),
        };
    }

    public static string CreatePlannerJsonSchema()
    {
        return """
            {
              "$schema": "https://json-schema.org/draft/2020-12/schema",
              "type": "object",
              "additionalProperties": false,
              "required": ["sourceText", "scenario", "style", "model", "ratio", "shotDurationSeconds", "shots"],
              "properties": {
                "sourceText": { "type": "string", "minLength": 1 },
                "scenario": { "type": "string", "minLength": 1 },
                "style": { "type": "string", "minLength": 1 },
                "model": { "type": "string", "minLength": 1 },
                "ratio": { "type": "string", "minLength": 1 },
                "shotDurationSeconds": { "type": "number" },
                "shots": {
                  "type": "array",
                  "minItems": 1,
                  "maxItems": 6,
                  "items": {
                    "type": "object",
                    "additionalProperties": false,
                    "required": ["index", "count", "title", "beat", "keyframePrompt", "videoPrompt"],
                    "properties": {
                      "index": { "type": "integer", "minimum": 1 },
                      "count": { "type": "integer", "minimum": 1, "maximum": 6 },
                      "title": { "type": "string", "minLength": 1 },
                      "beat": { "type": "string", "minLength": 1 },
                      "keyframePrompt": { "type": "string", "minLength": 1 },
                      "videoPrompt": { "type": "string", "minLength": 1 }
                    }
                  }
                }
              }
            }
            """;
    }

    private static async Task<RunwayShortVideoPlan> CreatePlanWithAutoPlannerAsync(
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        if (FindExecutableOnPath("claude") is { Length: > 0 })
        {
            try
            {
                return await CreatePlanWithExternalPlannerAsync(
                    RunwayCliShortVideoPlannerKind.Claude,
                    scenarioText,
                    options,
                    plannerOptions,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
            }
        }

        if (FindExecutableOnPath("codex") is { Length: > 0 })
        {
            try
            {
                return await CreatePlanWithExternalPlannerAsync(
                    RunwayCliShortVideoPlannerKind.Codex,
                    scenarioText,
                    options,
                    plannerOptions,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
            }
        }

        return RunwayShortVideoExtensions.CreateShortVideoPlan(scenarioText, options);
    }

    private static async Task<RunwayShortVideoPlan> CreatePlanWithRequiredExternalPlannerAsync(
        RunwayCliShortVideoPlannerKind kind,
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        var executableName = GetPlannerExecutableName(kind);
        if (FindExecutableOnPath(executableName) is not { Length: > 0 })
        {
            throw new InvalidOperationException($"{GetPlannerDisplayName(kind)} planner was requested but `{executableName}` was not found on PATH.");
        }

        return await CreatePlanWithExternalPlannerAsync(
            kind,
            scenarioText,
            options,
            plannerOptions,
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task<RunwayShortVideoPlan> CreatePlanWithExternalPlannerAsync(
        RunwayCliShortVideoPlannerKind kind,
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        var result = kind switch
        {
            RunwayCliShortVideoPlannerKind.Claude => await RunClaudePlannerAsync(
                scenarioText,
                options,
                plannerOptions,
                cancellationToken).ConfigureAwait(false),
            RunwayCliShortVideoPlannerKind.Codex => await RunCodexPlannerAsync(
                scenarioText,
                options,
                plannerOptions,
                cancellationToken).ConfigureAwait(false),
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, "Unsupported external planner."),
        };

        var plan = DeserializePlannerOutput(result, GetPlannerDisplayName(kind), scenarioText, options);
        return await RunwayShortVideoExtensions.CreateShortVideoPlanAsync(
            scenarioText,
            (_, _, _) => ValueTask.FromResult<RunwayShortVideoPlan?>(plan),
            options,
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task<string> RunClaudePlannerAsync(
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        var tempDirectory = CreatePlannerTempDirectory();
        try
        {
            var startInfo = CreatePlannerStartInfo("claude", tempDirectory);
            Add(startInfo, "--print", "--model", plannerOptions.Model ?? DefaultClaudePlannerModel);
            Add(startInfo, "--json-schema", CreatePlannerJsonSchema(), "--permission-mode", "plan", "--no-session-persistence");
            AddClaudeToolArguments(startInfo, plannerOptions.Tools);
            Add(startInfo, "--", CreatePlannerPrompt(scenarioText, options, plannerOptions.Tools));

            var result = await RunPlannerProcessAsync(
                startInfo,
                GetPlannerDisplayName(RunwayCliShortVideoPlannerKind.Claude),
                plannerOptions.Timeout,
                cancellationToken).ConfigureAwait(false);

            return result.Output;
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    private static async Task<string> RunCodexPlannerAsync(
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerOptions plannerOptions,
        CancellationToken cancellationToken)
    {
        var tempDirectory = CreatePlannerTempDirectory();
        var schemaPath = Path.Combine(tempDirectory, "runway-short-video-plan.schema.json");
        var outputPath = Path.Combine(tempDirectory, "runway-short-video-plan.output.json");

        try
        {
            await File.WriteAllTextAsync(schemaPath, CreatePlannerJsonSchema(), Encoding.UTF8, cancellationToken).ConfigureAwait(false);

            var startInfo = CreatePlannerStartInfo("codex", tempDirectory);
            Add(startInfo, "exec", "--sandbox", "read-only", "--ephemeral", "--skip-git-repo-check", "--cd", tempDirectory);
            Add(startInfo, "-c", "approval_policy=\"never\"", "--output-schema", schemaPath, "--output-last-message", outputPath);
            if (plannerOptions.Model is { Length: > 0 } model)
            {
                Add(startInfo, "--model", model);
            }

            Add(startInfo, CreatePlannerPrompt(scenarioText, options, plannerOptions.Tools));

            var result = await RunPlannerProcessAsync(
                startInfo,
                GetPlannerDisplayName(RunwayCliShortVideoPlannerKind.Codex),
                plannerOptions.Timeout,
                cancellationToken).ConfigureAwait(false);

            return File.Exists(outputPath)
                ? await File.ReadAllTextAsync(outputPath, cancellationToken).ConfigureAwait(false)
                : result.Output;
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    private static ProcessStartInfo CreatePlannerStartInfo(string executableName, string workingDirectory)
    {
        return new ProcessStartInfo
        {
            FileName = FindExecutableOnPath(executableName) ?? executableName,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            WorkingDirectory = workingDirectory,
        };
    }

    private static void AddClaudeToolArguments(
        ProcessStartInfo startInfo,
        RunwayCliShortVideoPlannerTools tools)
    {
        if (tools == RunwayCliShortVideoPlannerTools.None)
        {
            Add(startInfo, "--tools", string.Empty);
            return;
        }

        Add(startInfo, "--tools", "Read,Grep,Glob,WebFetch,WebSearch");
        Add(startInfo, "--disallowedTools", "Bash,Edit,MultiEdit,Write,NotebookEdit");
    }

    private static async Task<RunwayCliProcessResult> RunPlannerProcessAsync(
        ProcessStartInfo startInfo,
        string displayName,
        TimeSpan timeout,
        CancellationToken cancellationToken)
    {
        using var process = new Process { StartInfo = startInfo };
        if (!process.Start())
        {
            throw new InvalidOperationException($"{displayName} planner failed to start.");
        }

        var output = process.StandardOutput.ReadToEndAsync();
        var error = process.StandardError.ReadToEndAsync();

        using var timeoutToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeoutToken.CancelAfter(timeout);

        try
        {
            await process.WaitForExitAsync(timeoutToken.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            TryKill(process);
            throw new TimeoutException(string.Create(
                CultureInfo.InvariantCulture,
                $"{displayName} planner timed out after {timeout.TotalSeconds:0} seconds."));
        }

        var result = new RunwayCliProcessResult(
            process.ExitCode,
            await output.ConfigureAwait(false),
            await error.ConfigureAwait(false));
        if (result.ExitCode != 0)
        {
            throw new InvalidOperationException(string.Create(
                CultureInfo.InvariantCulture,
                $"{displayName} planner failed with exit code {result.ExitCode}: {TrimPlannerError(result.Error)}"));
        }

        return result;
    }

    private static RunwayShortVideoPlan DeserializePlannerOutput(
        string output,
        string displayName,
        string scenarioText,
        RunwayShortVideoOptions options)
    {
        try
        {
            var json = ExtractPlannerJsonObject(output);
            json = NormalizePlannerJsonForDeserialization(json, scenarioText, options);
            return JsonSerializer.Deserialize(
                json,
                RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan)
                ?? throw new JsonException("Planner output was empty.");
        }
        catch (Exception ex) when (ex is JsonException or ArgumentException or InvalidOperationException)
        {
            throw new InvalidOperationException($"{displayName} planner returned invalid short-video JSON: {ex.Message}", ex);
        }
    }

    private static string CreatePlannerPrompt(
        string scenarioText,
        RunwayShortVideoOptions options,
        RunwayCliShortVideoPlannerTools tools)
    {
        var style = string.IsNullOrWhiteSpace(options.Style)
            ? "cinematic, coherent visual continuity, natural motion, high production value, no captions"
            : options.Style.Trim();
        var toolPolicy = tools == RunwayCliShortVideoPlannerTools.None
            ? "Do not use tools, inspect files, run shell commands, or fetch external resources."
            : "Tool access is read-only only. You may read/search/fetch context if useful, but do not run shell commands and do not write or edit files.";

        return string.Create(
            CultureInfo.InvariantCulture,
            $"""
            You are Runway CLI's bundled director/storyboard planner. Your planning shape is informed by storyboard-creation workflows, but no external skill is installed or required.

            Return exactly one JSON object matching the provided schema. Do not include Markdown, prose, code fences, comments, or extra keys.

            {toolPolicy}

            Scenario text:
            {scenarioText.Trim()}

            Required Runway plan constraints:
            - sourceText: the original scenario text, normalized only for whitespace
            - scenario: one compact scenario summary for a coherent short film
            - style: shared visual style for every shot; use "{style}"
            - model: "{options.Model}"
            - ratio: "{options.Ratio}"
            - shotDurationSeconds: {options.ShotDurationSeconds}
            - shots: exactly {options.ShotCount} shots
            - each shot index must be 1-based and count must be {options.ShotCount}
            - each shot object must include exactly these required keys: "index", "count", "title", "beat", "keyframePrompt", "videoPrompt"
            - use the exact key "beat" for the story beat; do not use "storyBeat", "description", or "summary"
            - keyframePrompt describes a still composition with subject, setting, lighting, composition, palette, and continuity anchors
            - videoPrompt describes camera movement, subject action, motion continuity, timing, and visual style for Runway text-to-video
            - avoid captions, subtitles, logos, UI text, and unreadable text unless explicitly requested by the scenario
            - keep prompts visual, concrete, production-ready, and safe to send directly to Runway
            """);
    }

    private static string NormalizePlannerJsonForDeserialization(
        string json,
        string scenarioText,
        RunwayShortVideoOptions options)
    {
        var root = JsonNode.Parse(json)?.AsObject()
            ?? throw new InvalidOperationException("Planner output did not contain a JSON object.");

        SetDefaultString(root, "sourceText", scenarioText.Trim());
        SetDefaultString(root, "scenario", scenarioText.Trim());
        SetDefaultString(root, "style", string.IsNullOrWhiteSpace(options.Style)
            ? "cinematic, coherent visual continuity, natural motion, high production value, no captions"
            : options.Style.Trim());
        SetDefaultString(root, "model", options.Model);
        SetDefaultString(root, "ratio", options.Ratio);
        if (!root.TryGetPropertyValue("shotDurationSeconds", out var duration) ||
            duration is null ||
            duration.GetValueKind() is not JsonValueKind.Number)
        {
            root["shotDurationSeconds"] = options.ShotDurationSeconds;
        }

        if (root["shots"] is not JsonArray shots)
        {
            throw new InvalidOperationException("Planner output did not contain a shots array.");
        }

        for (var i = 0; i < shots.Count; i++)
        {
            if (shots[i] is not JsonObject shot)
            {
                throw new InvalidOperationException("Planner output contained a non-object shot.");
            }

            shot["index"] = GetInt(shot, "index") ?? i + 1;
            shot["count"] = GetInt(shot, "count") ?? shots.Count;
            SetDefaultString(shot, "title", string.Create(CultureInfo.InvariantCulture, $"Shot {i + 1}"));

            var beat = FirstString(shot, "beat", "storyBeat", "description", "summary", "action", "visualBeat");
            if (!string.IsNullOrWhiteSpace(beat))
            {
                shot["beat"] = beat;
            }

            var keyframePrompt = FirstString(shot, "keyframePrompt", "keyframe", "imagePrompt", "visualPrompt", "stillPrompt", "beat", "title");
            if (!string.IsNullOrWhiteSpace(keyframePrompt))
            {
                shot["keyframePrompt"] = keyframePrompt;
            }

            var videoPrompt = FirstString(shot, "videoPrompt", "prompt", "motionPrompt", "animationPrompt", "keyframePrompt", "beat");
            if (!string.IsNullOrWhiteSpace(videoPrompt))
            {
                shot["videoPrompt"] = videoPrompt;
            }
        }

        return root.ToJsonString();
    }

    private static void SetDefaultString(JsonObject value, string propertyName, string? defaultValue)
    {
        if (string.IsNullOrWhiteSpace(FirstString(value, propertyName)) &&
            !string.IsNullOrWhiteSpace(defaultValue))
        {
            value[propertyName] = defaultValue.Trim();
        }
    }

    private static string? FirstString(JsonObject value, params string[] propertyNames)
    {
        foreach (var propertyName in propertyNames)
        {
            if (value.TryGetPropertyValue(propertyName, out var node) &&
                node is not null &&
                node.GetValueKind() == JsonValueKind.String &&
                node.GetValue<string>() is { Length: > 0 } text)
            {
                return text.Trim();
            }
        }

        return null;
    }

    private static int? GetInt(JsonObject value, string propertyName)
    {
        return value.TryGetPropertyValue(propertyName, out var node) &&
               node is not null &&
               node.GetValueKind() == JsonValueKind.Number &&
               node.GetValue<int>() is var result
            ? result
            : null;
    }

    private static string ExtractPlannerJsonObject(string value)
    {
        var candidate = value.Trim();
        if (candidate.StartsWith("```", StringComparison.Ordinal))
        {
            var firstLineEnd = candidate.IndexOf('\n', StringComparison.Ordinal);
            var lastFence = candidate.LastIndexOf("```", StringComparison.Ordinal);
            if (firstLineEnd >= 0 && lastFence > firstLineEnd)
            {
                candidate = candidate[(firstLineEnd + 1)..lastFence].Trim();
            }
        }

        if (IsJsonObject(candidate))
        {
            return candidate;
        }

        var start = candidate.IndexOf('{', StringComparison.Ordinal);
        var end = candidate.LastIndexOf('}');
        if (start < 0 || end <= start)
        {
            throw new InvalidOperationException("Planner output did not contain a JSON object.");
        }

        candidate = candidate[start..(end + 1)];
        return IsJsonObject(candidate)
            ? candidate
            : throw new InvalidOperationException("Planner output did not contain a valid JSON object.");
    }

    private static bool IsJsonObject(string value)
    {
        try
        {
            using var document = JsonDocument.Parse(value);
            return document.RootElement.ValueKind == JsonValueKind.Object;
        }
        catch (JsonException)
        {
            return false;
        }
    }

    private static RunwayCliShortVideoPlannerKind ParsePlannerKind(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "auto" => RunwayCliShortVideoPlannerKind.Auto,
            "claude" => RunwayCliShortVideoPlannerKind.Claude,
            "codex" => RunwayCliShortVideoPlannerKind.Codex,
            "deterministic" => RunwayCliShortVideoPlannerKind.Deterministic,
            _ => throw new ArgumentException("--planner must be auto, claude, codex, or deterministic."),
        };
    }

    private static RunwayCliShortVideoPlannerTools ParsePlannerTools(string value)
    {
        return value.Trim().ToLowerInvariant() switch
        {
            "read-only" => RunwayCliShortVideoPlannerTools.ReadOnly,
            "none" => RunwayCliShortVideoPlannerTools.None,
            _ => throw new ArgumentException("--planner-tools must be read-only or none."),
        };
    }

    private static int? ParseOptionalPositiveInt(string? value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed) && parsed > 0
            ? parsed
            : throw new ArgumentException($"{name} must be a positive integer.");
    }

    private static string? FirstNonEmpty(string? primary, string? fallback)
    {
        return primary is { Length: > 0 } ? primary :
            fallback is { Length: > 0 } ? fallback :
            null;
    }

    private static string GetPlannerExecutableName(RunwayCliShortVideoPlannerKind kind)
    {
        return kind switch
        {
            RunwayCliShortVideoPlannerKind.Claude => "claude",
            RunwayCliShortVideoPlannerKind.Codex => "codex",
            _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, "Planner does not use an external executable."),
        };
    }

    private static string GetPlannerDisplayName(RunwayCliShortVideoPlannerKind kind)
    {
        return kind switch
        {
            RunwayCliShortVideoPlannerKind.Claude => "Claude",
            RunwayCliShortVideoPlannerKind.Codex => "Codex",
            _ => "External",
        };
    }

    private static string CreatePlannerTempDirectory()
    {
        var directory = Path.Combine(Path.GetTempPath(), $"runway-short-video-planner-{Guid.NewGuid():N}");
        Directory.CreateDirectory(directory);
        return directory;
    }

    private static void TryDeleteDirectory(string directory)
    {
        try
        {
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory, recursive: true);
            }
        }
        catch
        {
        }
    }

    private static void TryKill(Process process)
    {
        try
        {
            if (!process.HasExited)
            {
                process.Kill(entireProcessTree: true);
            }
        }
        catch
        {
        }
    }

    private static string TrimPlannerError(string value)
    {
        var normalized = value.Trim();
        return normalized.Length <= 400 ? normalized : normalized[..400];
    }
}
