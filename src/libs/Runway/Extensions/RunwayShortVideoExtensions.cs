using System.Globalization;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

#pragma warning disable CS3001 // Argument type is not CLS-compliant

namespace Runway;

/// <summary>
/// Options for turning one scenario prompt into a planned multi-shot Runway short video.
/// </summary>
public sealed class RunwayShortVideoOptions
{
    /// <summary>
    /// The default text-to-video model used for short-video shots.
    /// </summary>
    public const string DefaultModel = "veo3.1_fast";

    /// <summary>
    /// The default output video ratio.
    /// </summary>
    public const string DefaultRatio = "1280:720";

    /// <summary>
    /// Number of shots to plan and generate. The supported range is 1 through 6.
    /// </summary>
    public int ShotCount { get; init; } = 3;

    /// <summary>
    /// Duration in seconds for each generated shot.
    /// </summary>
    public double ShotDurationSeconds { get; init; } = 4;

    /// <summary>
    /// Runway text-to-video model ID.
    /// </summary>
    public string Model { get; init; } = DefaultModel;

    /// <summary>
    /// Output video ratio.
    /// </summary>
    public string Ratio { get; init; } = DefaultRatio;

    /// <summary>
    /// Whether to request generated audio for models that support it.
    /// </summary>
    public bool Audio { get; init; }

    /// <summary>
    /// Optional base seed. When multiple shots are generated, each following shot increments this seed.
    /// </summary>
    public int? Seed { get; init; }

    /// <summary>
    /// Optional visual style guidance applied to every shot.
    /// </summary>
    public string? Style { get; init; }

    /// <summary>
    /// Optional public-figure moderation threshold, for example <c>auto</c> or <c>low</c>.
    /// </summary>
    public string? PublicFigureThreshold { get; init; }

    /// <summary>
    /// Whether short-video generation waits for each shot task to finish.
    /// </summary>
    public bool WaitForCompletion { get; init; } = true;

    /// <summary>
    /// Whether completed shot outputs should be downloaded when waiting is enabled.
    /// </summary>
    public bool DownloadOutputs { get; init; } = true;

    /// <summary>
    /// Optional output directory for downloaded shot files.
    /// </summary>
    public string? Output { get; init; }

    /// <summary>
    /// Polling interval used while waiting for each Runway task.
    /// </summary>
    public TimeSpan? PollInterval { get; init; }

    /// <summary>
    /// File-name prefix used for downloaded shot files.
    /// </summary>
    public string OutputStemPrefix { get; init; } = "runway-short-video-shot";
}

/// <summary>
/// Planned short-video storyboard.
/// </summary>
public sealed class RunwayShortVideoPlan
{
    /// <summary>
    /// Original scenario text supplied by the caller.
    /// </summary>
    public required string SourceText { get; init; }

    /// <summary>
    /// A compact scenario summary used to keep generated shots coherent.
    /// </summary>
    public required string Scenario { get; init; }

    /// <summary>
    /// Shared visual style applied to each shot.
    /// </summary>
    public required string Style { get; init; }

    /// <summary>
    /// Runway text-to-video model ID used for this plan.
    /// </summary>
    public required string Model { get; init; }

    /// <summary>
    /// Output video ratio used for this plan.
    /// </summary>
    public required string Ratio { get; init; }

    /// <summary>
    /// Planned shot duration in seconds.
    /// </summary>
    public double ShotDurationSeconds { get; init; }

    /// <summary>
    /// Ordered shot prompts.
    /// </summary>
    public IReadOnlyList<RunwayShortVideoShot> Shots { get; init; } = [];
}

/// <summary>
/// One planned short-video shot.
/// </summary>
public sealed class RunwayShortVideoShot
{
    /// <summary>
    /// One-based shot index.
    /// </summary>
    public int Index { get; init; }

    /// <summary>
    /// Total shots in the plan.
    /// </summary>
    public int Count { get; init; }

    /// <summary>
    /// Short title for the shot.
    /// </summary>
    public required string Title { get; init; }

    /// <summary>
    /// Scenario beat represented by this shot.
    /// </summary>
    public required string Beat { get; init; }

    /// <summary>
    /// Still-frame composition prompt for the shot.
    /// </summary>
    public required string KeyframePrompt { get; init; }

    /// <summary>
    /// Full Runway text-to-video prompt for this shot.
    /// </summary>
    public required string VideoPrompt { get; init; }
}

/// <summary>
/// Result from creating a Runway short video.
/// </summary>
public sealed class RunwayShortVideoResult
{
    /// <summary>
    /// Storyboard used for generation.
    /// </summary>
    public required RunwayShortVideoPlan Plan { get; init; }

    /// <summary>
    /// Per-shot task and download results.
    /// </summary>
    public IReadOnlyList<RunwayShortVideoShotResult> Shots { get; init; } = [];

    /// <summary>
    /// Flattened list of downloaded shot files.
    /// </summary>
    public IReadOnlyList<string> DownloadedFiles { get; init; } = [];
}

/// <summary>
/// Per-shot generation result.
/// </summary>
public sealed class RunwayShortVideoShotResult
{
    /// <summary>
    /// Planned shot.
    /// </summary>
    public required RunwayShortVideoShot Shot { get; init; }

    /// <summary>
    /// Runway task ID for this shot.
    /// </summary>
    public Guid TaskId { get; init; }

    /// <summary>
    /// Final task state when waiting was enabled.
    /// </summary>
    public GetTasksResponse? Task { get; init; }

    /// <summary>
    /// Downloaded local files for this shot.
    /// </summary>
    public IReadOnlyList<string> DownloadedFiles { get; init; } = [];
}

/// <summary>
/// Progress stage for multi-shot short-video generation.
/// </summary>
public enum RunwayShortVideoProgressStage
{
    /// <summary>
    /// A shot is about to be submitted.
    /// </summary>
    StartingShot,

    /// <summary>
    /// A Runway task was created for a shot.
    /// </summary>
    TaskCreated,

    /// <summary>
    /// A task status update was received.
    /// </summary>
    TaskUpdated,

    /// <summary>
    /// A shot output was downloaded.
    /// </summary>
    ShotDownloaded,
}

/// <summary>
/// Progress information for multi-shot short-video generation.
/// </summary>
public sealed class RunwayShortVideoProgress
{
    /// <summary>
    /// Current progress stage.
    /// </summary>
    public RunwayShortVideoProgressStage Stage { get; init; }

    /// <summary>
    /// Shot associated with this progress event.
    /// </summary>
    public required RunwayShortVideoShot Shot { get; init; }

    /// <summary>
    /// Runway task ID, when available.
    /// </summary>
    public Guid? TaskId { get; init; }

    /// <summary>
    /// Task status, when available.
    /// </summary>
    public GetTasksResponse? Task { get; init; }
}

/// <summary>
/// Creates a short-video plan from scenario text, options, and a cancellation token.
/// </summary>
/// <param name="scenarioText">Plain text describing the desired short video.</param>
/// <param name="options">Planning and generation options.</param>
/// <param name="cancellationToken">The token to cancel the operation with.</param>
/// <returns>A planned short-video storyboard.</returns>
public delegate ValueTask<RunwayShortVideoPlan?> RunwayShortVideoPlanner(
    string scenarioText,
    RunwayShortVideoOptions options,
    CancellationToken cancellationToken);

/// <summary>
/// High-level helpers for creating short, planned multi-shot Runway videos.
/// </summary>
public static class RunwayShortVideoExtensions
{
    private static readonly string[] SupportedTextToVideoModels = ["gen4.5", "veo3.1", "veo3.1_fast", "veo3"];

    /// <summary>
    /// Creates a deterministic storyboard plan from a plain scenario prompt.
    /// </summary>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <returns>A short-video plan with keyframe prompts and text-to-video prompts.</returns>
    public static RunwayShortVideoPlan CreateShortVideoPlan(
        string scenarioText,
        RunwayShortVideoOptions? options = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(scenarioText);

        var effectiveOptions = ValidateOptions(options);
        var shotCount = effectiveOptions.ShotCount;
        var sourceText = NormalizeWhitespace(scenarioText);
        var style = string.IsNullOrWhiteSpace(effectiveOptions.Style)
            ? "cinematic, coherent visual continuity, natural motion, high production value, no captions"
            : NormalizeWhitespace(effectiveOptions.Style);
        var scenario = CreateScenarioSummary(sourceText, shotCount);
        var beats = SplitIntoBeats(sourceText);
        var shots = new List<RunwayShortVideoShot>(shotCount);

        for (var index = 1; index <= shotCount; index++)
        {
            var beat = SelectBeat(beats, index, shotCount);
            var role = GetShotRole(index, shotCount);
            var motion = GetShotMotion(index, shotCount);
            var keyframePrompt = TrimToLength(
                string.Create(
                    CultureInfo.InvariantCulture,
                    $"{role}. {beat}. Compose a clear story keyframe with consistent subjects, setting, color palette, lighting, and production design. {style}."),
                900);
            var videoPrompt = TrimToLength(
                string.Create(
                    CultureInfo.InvariantCulture,
                    $"Short film shot {index} of {shotCount}. Scenario: {scenario}. Keyframe: {keyframePrompt} Motion: {motion}. Keep continuity with the other shots; avoid jump cuts, captions, subtitles, logos, and unreadable text unless explicitly requested."),
                1000);

            shots.Add(new RunwayShortVideoShot
            {
                Index = index,
                Count = shotCount,
                Title = string.Create(CultureInfo.InvariantCulture, $"Shot {index}: {role}"),
                Beat = beat,
                KeyframePrompt = keyframePrompt,
                VideoPrompt = videoPrompt,
            });
        }

        return new RunwayShortVideoPlan
        {
            SourceText = sourceText,
            Scenario = scenario,
            Style = style,
            Model = NormalizeTextToVideoModel(effectiveOptions.Model),
            Ratio = effectiveOptions.Ratio,
            ShotDurationSeconds = effectiveOptions.ShotDurationSeconds,
            Shots = shots,
        };
    }

    /// <summary>
    /// Creates a short-video plan by calling a supplied planner delegate.
    /// </summary>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="planner">Planner delegate. Return <see langword="null"/> to use the deterministic planner.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A validated short-video plan.</returns>
    public static async Task<RunwayShortVideoPlan> CreateShortVideoPlanAsync(
        string scenarioText,
        RunwayShortVideoPlanner planner,
        RunwayShortVideoOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(scenarioText);
        ArgumentNullException.ThrowIfNull(planner);

        var effectiveOptions = ValidateOptions(options);
        var planned = await planner(
            NormalizeWhitespace(scenarioText),
            effectiveOptions,
            cancellationToken).ConfigureAwait(false);

        return planned is null
            ? CreateShortVideoPlan(scenarioText, effectiveOptions)
            : NormalizePlan(planned, effectiveOptions);
    }

    /// <summary>
    /// Creates a short-video plan by asking a <see cref="IChatClient"/> to produce structured storyboard JSON.
    /// </summary>
    /// <param name="chatClient">The chat client used to expand the scenario into shots.</param>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A validated short-video plan.</returns>
    public static async Task<RunwayShortVideoPlan> CreateShortVideoPlanAsync(
        this IChatClient chatClient,
        string scenarioText,
        RunwayShortVideoOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(chatClient);
        ArgumentException.ThrowIfNullOrWhiteSpace(scenarioText);

        var effectiveOptions = ValidateOptions(options);
        ChatMessage[] messages =
        [
            new ChatMessage(ChatRole.System, CreateShortVideoPlannerSystemPrompt()),
            new ChatMessage(ChatRole.User, CreateShortVideoPlannerUserPrompt(scenarioText, effectiveOptions)),
        ];
        var response = await GetShortVideoPlannerResponseAsync(
            chatClient,
            messages,
            cancellationToken).ConfigureAwait(false);

        var json = ExtractJsonObject(response.Text);
        var plan = JsonSerializer.Deserialize(
            json,
            RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan)
            ?? throw new InvalidOperationException("Planner response did not contain a short-video plan.");

        return NormalizePlan(plan, effectiveOptions);
    }

    private static async Task<ChatResponse> GetShortVideoPlannerResponseAsync(
        IChatClient chatClient,
        ChatMessage[] messages,
        CancellationToken cancellationToken)
    {
        try
        {
            return await chatClient.GetResponseAsync(
                messages,
                CreateShortVideoPlannerChatOptions(useJsonSchema: true),
                cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex) when (IsUnsupportedPlannerResponseFormatException(ex))
        {
            return await chatClient.GetResponseAsync(
                messages,
                CreateShortVideoPlannerChatOptions(useJsonSchema: false),
                cancellationToken).ConfigureAwait(false);
        }
    }

    private static ChatOptions CreateShortVideoPlannerChatOptions(bool useJsonSchema)
    {
        return new ChatOptions
        {
            ResponseFormat = useJsonSchema
                ? ChatResponseFormat.ForJsonSchema<RunwayShortVideoPlan>(
                    RunwayShortVideoJsonSerializerContext.Default.Options,
                    "runway_short_video_plan",
                    "A Runway short-video storyboard plan with one prompt per shot.")
                : ChatResponseFormat.Json,
            Temperature = 0.2f,
        };
    }

    private static bool IsUnsupportedPlannerResponseFormatException(Exception exception)
    {
        return (exception is NotSupportedException || exception is InvalidOperationException) &&
            IsResponseFormatUnsupportedMessage(exception.Message);
    }

    private static bool IsResponseFormatUnsupportedMessage(string? message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            return false;
        }

        return (message.Contains("response format", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("responseFormat", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("response_format", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("json schema", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("json_schema", StringComparison.OrdinalIgnoreCase) ||
                message.Contains("structured output", StringComparison.OrdinalIgnoreCase)) &&
            (message.Contains("not support", StringComparison.OrdinalIgnoreCase) ||
             message.Contains("unsupported", StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Starts Runway text-to-video tasks for a planned short video and optionally waits for downloaded outputs.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <param name="xRunwayVersion">The Runway API version header.</param>
    /// <param name="progress">Optional progress callback.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A result containing the plan, task IDs, task states, and downloaded files.</returns>
    public static async Task<RunwayShortVideoResult> CreateShortVideoAsync(
        this RunwayClient client,
        string scenarioText,
        RunwayShortVideoOptions? options = null,
        string xRunwayVersion = "2024-11-06",
        IProgress<RunwayShortVideoProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        var effectiveOptions = ValidateOptions(options);
        var plan = CreateShortVideoPlan(scenarioText, effectiveOptions);
        return await CreateShortVideoAsyncCore(
            client,
            plan,
            effectiveOptions,
            xRunwayVersion,
            progress,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Starts Runway text-to-video tasks using a supplied planner delegate.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="planner">Planner delegate. Return <see langword="null"/> to use the deterministic planner.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <param name="xRunwayVersion">The Runway API version header.</param>
    /// <param name="progress">Optional progress callback.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A result containing the plan, task IDs, task states, and downloaded files.</returns>
    public static async Task<RunwayShortVideoResult> CreateShortVideoAsync(
        this RunwayClient client,
        string scenarioText,
        RunwayShortVideoPlanner planner,
        RunwayShortVideoOptions? options = null,
        string xRunwayVersion = "2024-11-06",
        IProgress<RunwayShortVideoProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(planner);

        var effectiveOptions = ValidateOptions(options);
        var plan = await CreateShortVideoPlanAsync(
            scenarioText,
            planner,
            effectiveOptions,
            cancellationToken).ConfigureAwait(false);

        return await CreateShortVideoAsyncCore(
            client,
            plan,
            effectiveOptions,
            xRunwayVersion,
            progress,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Starts Runway text-to-video tasks using a supplied <see cref="IChatClient"/> planner.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="scenarioText">Plain text describing the desired short video.</param>
    /// <param name="planner">The chat client used to expand the scenario into shots.</param>
    /// <param name="options">Optional planning and generation options.</param>
    /// <param name="xRunwayVersion">The Runway API version header.</param>
    /// <param name="progress">Optional progress callback.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A result containing the plan, task IDs, task states, and downloaded files.</returns>
    public static async Task<RunwayShortVideoResult> CreateShortVideoAsync(
        this RunwayClient client,
        string scenarioText,
        IChatClient planner,
        RunwayShortVideoOptions? options = null,
        string xRunwayVersion = "2024-11-06",
        IProgress<RunwayShortVideoProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(planner);

        var effectiveOptions = ValidateOptions(options);
        var plan = await planner.CreateShortVideoPlanAsync(
            scenarioText,
            effectiveOptions,
            cancellationToken).ConfigureAwait(false);

        return await CreateShortVideoAsyncCore(
            client,
            plan,
            effectiveOptions,
            xRunwayVersion,
            progress,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Starts Runway text-to-video tasks from a previously created or edited short-video plan.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="plan">The plan to execute.</param>
    /// <param name="options">Optional generation options. Defaults are taken from the plan.</param>
    /// <param name="xRunwayVersion">The Runway API version header.</param>
    /// <param name="progress">Optional progress callback.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A result containing the plan, task IDs, task states, and downloaded files.</returns>
    public static async Task<RunwayShortVideoResult> CreateShortVideoAsync(
        this RunwayClient client,
        RunwayShortVideoPlan plan,
        RunwayShortVideoOptions? options = null,
        string xRunwayVersion = "2024-11-06",
        IProgress<RunwayShortVideoProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(plan);

        var effectiveOptions = ValidateOptions(options ?? CreateOptionsFromPlan(plan));
        var normalizedPlan = NormalizePlan(plan, effectiveOptions);
        return await CreateShortVideoAsyncCore(
            client,
            normalizedPlan,
            effectiveOptions,
            xRunwayVersion,
            progress,
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task<RunwayShortVideoResult> CreateShortVideoAsyncCore(
        RunwayClient client,
        RunwayShortVideoPlan plan,
        RunwayShortVideoOptions effectiveOptions,
        string xRunwayVersion,
        IProgress<RunwayShortVideoProgress>? progress,
        CancellationToken cancellationToken)
    {
        var shotResults = new List<RunwayShortVideoShotResult>(plan.Shots.Count);
        var downloadedFiles = new List<string>();

        foreach (var shot in plan.Shots)
        {
            progress?.Report(new RunwayShortVideoProgress
            {
                Stage = RunwayShortVideoProgressStage.StartingShot,
                Shot = shot,
            });

            var response = await client.StartGenerating.CreateTextToVideoAsync(
                request: CreateTextToVideoRequest(shot.VideoPrompt, effectiveOptions, shot.Index),
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            progress?.Report(new RunwayShortVideoProgress
            {
                Stage = RunwayShortVideoProgressStage.TaskCreated,
                Shot = shot,
                TaskId = response.Id,
            });

            GetTasksResponse? task = null;
            IReadOnlyList<string> shotDownloadedFiles = [];
            if (effectiveOptions.WaitForCompletion)
            {
                task = await client.WaitForTaskAsync(
                    response.Id,
                    xRunwayVersion: xRunwayVersion,
                    pollInterval: effectiveOptions.PollInterval,
                    progress: new InlineProgress<GetTasksResponse>(taskUpdate => progress?.Report(new RunwayShortVideoProgress
                    {
                        Stage = RunwayShortVideoProgressStage.TaskUpdated,
                        Shot = shot,
                        TaskId = response.Id,
                        Task = taskUpdate,
                    })),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if (effectiveOptions.DownloadOutputs)
                {
                    shotDownloadedFiles = await task.Value.DownloadOutputsAsync(
                        output: ResolveShotOutput(effectiveOptions.Output, plan.Shots.Count),
                        defaultExtension: ".mp4",
                        stemPrefix: string.Create(
                            CultureInfo.InvariantCulture,
                            $"{effectiveOptions.OutputStemPrefix}-{shot.Index:00}"),
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    downloadedFiles.AddRange(shotDownloadedFiles);

                    progress?.Report(new RunwayShortVideoProgress
                    {
                        Stage = RunwayShortVideoProgressStage.ShotDownloaded,
                        Shot = shot,
                        TaskId = response.Id,
                        Task = task,
                    });
                }
            }

            shotResults.Add(new RunwayShortVideoShotResult
            {
                Shot = shot,
                TaskId = response.Id,
                Task = task,
                DownloadedFiles = shotDownloadedFiles,
            });
        }

        return new RunwayShortVideoResult
        {
            Plan = plan,
            Shots = shotResults,
            DownloadedFiles = downloadedFiles,
        };
    }

    /// <summary>
    /// Creates the generated Runway text-to-video request for one short-video shot.
    /// </summary>
    /// <param name="prompt">The text-to-video prompt.</param>
    /// <param name="options">Short-video options.</param>
    /// <param name="shotIndex">One-based shot index used to offset the seed.</param>
    /// <returns>A generated text-to-video request union.</returns>
    public static CreateTextToVideoRequest CreateTextToVideoRequest(
        string prompt,
        RunwayShortVideoOptions? options = null,
        int shotIndex = 1)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(prompt);

        var effectiveOptions = ValidateOptions(options);
        var seed = effectiveOptions.Seed is { } baseSeed
            ? checked(baseSeed + Math.Max(shotIndex, 1) - 1)
            : (int?)null;
        var model = NormalizeTextToVideoModel(effectiveOptions.Model);

        return model switch
        {
            "gen4.5" => CreateGen45Request(prompt, effectiveOptions, seed),
            "veo3.1" => CreateVeo31Request(prompt, effectiveOptions, seed),
            "veo3.1_fast" => CreateVeo31FastRequest(prompt, effectiveOptions, seed),
            "veo3" => CreateVeo3Request(prompt, effectiveOptions, seed),
            _ => throw new ArgumentException($"Unsupported model '{effectiveOptions.Model}'."),
        };
    }

    private static CreateTextToVideoRequest CreateGen45Request(
        string prompt,
        RunwayShortVideoOptions options,
        int? seed)
    {
        var duration = ToWholeDuration(options.ShotDurationSeconds, "gen4.5");
        var request = new CreateTextToVideoRequestGen45
        {
            PromptText = prompt,
            Ratio = CreateTextToVideoRequestGen45RatioExtensions.ToEnum(options.Ratio)
                ?? throw new ArgumentException("gen4.5 supports ratios: 1280:720, 720:1280."),
            Duration = duration,
            Seed = seed,
            ContentModeration = CreateGen45ContentModeration(options.PublicFigureThreshold),
        };

        return request;
    }

    private static CreateTextToVideoRequest CreateVeo31Request(
        string prompt,
        RunwayShortVideoOptions options,
        int? seed)
    {
        var request = new CreateTextToVideoRequestVeo31
        {
            PromptText = prompt,
            Ratio = CreateTextToVideoRequestVeo31RatioExtensions.ToEnum(options.Ratio)
                ?? throw new ArgumentException("veo3.1 supports ratios: 1080:1920, 1280:720, 1920:1080, 720:1280."),
            Duration = options.ShotDurationSeconds,
            Audio = options.Audio,
        };
        AddAdditionalRequestProperties(request.AdditionalProperties, seed, options.PublicFigureThreshold);
        return request;
    }

    private static CreateTextToVideoRequest CreateVeo31FastRequest(
        string prompt,
        RunwayShortVideoOptions options,
        int? seed)
    {
        var request = new CreateTextToVideoRequestVeo31Fast
        {
            PromptText = prompt,
            Ratio = CreateTextToVideoRequestVeo31FastRatioExtensions.ToEnum(options.Ratio)
                ?? throw new ArgumentException("veo3.1_fast supports ratios: 1080:1920, 1280:720, 1920:1080, 720:1280."),
            Duration = options.ShotDurationSeconds,
            Audio = options.Audio,
        };
        AddAdditionalRequestProperties(request.AdditionalProperties, seed, options.PublicFigureThreshold);
        return request;
    }

    private static CreateTextToVideoRequest CreateVeo3Request(
        string prompt,
        RunwayShortVideoOptions options,
        int? seed)
    {
        var request = new CreateTextToVideoRequestVeo3
        {
            PromptText = prompt,
            Ratio = CreateTextToVideoRequestVeo3RatioExtensions.ToEnum(options.Ratio)
                ?? throw new ArgumentException("veo3 supports ratios: 1080:1920, 1280:720, 1920:1080, 720:1280."),
            Duration = options.ShotDurationSeconds,
        };
        AddAdditionalRequestProperties(request.AdditionalProperties, seed, options.PublicFigureThreshold);
        return request;
    }

    private static RunwayShortVideoOptions CreateOptionsFromPlan(RunwayShortVideoPlan plan)
    {
        return new RunwayShortVideoOptions
        {
            ShotCount = plan.Shots.Count,
            ShotDurationSeconds = plan.ShotDurationSeconds > 0 ? plan.ShotDurationSeconds : 4,
            Model = string.IsNullOrWhiteSpace(plan.Model) ? RunwayShortVideoOptions.DefaultModel : plan.Model,
            Ratio = string.IsNullOrWhiteSpace(plan.Ratio) ? RunwayShortVideoOptions.DefaultRatio : plan.Ratio,
        };
    }

    private static RunwayShortVideoPlan NormalizePlan(
        RunwayShortVideoPlan plan,
        RunwayShortVideoOptions options)
    {
        if (plan.Shots.Count == 0)
        {
            throw new ArgumentException("Short-video plan must contain at least one shot.", nameof(plan));
        }

        if (plan.Shots.Count != options.ShotCount)
        {
            throw new ArgumentException(
                string.Create(
                    CultureInfo.InvariantCulture,
                    $"Short-video plan contains {plan.Shots.Count} shots, but options request {options.ShotCount}."),
                nameof(plan));
        }

        var normalizedShots = new List<RunwayShortVideoShot>(plan.Shots.Count);
        for (var i = 0; i < plan.Shots.Count; i++)
        {
            var shot = plan.Shots[i];
            var title = NormalizeRequired(shot.Title, $"Shot {i + 1} title");
            var beat = NormalizeRequired(shot.Beat, $"Shot {i + 1} beat");
            var keyframePrompt = TrimToLength(NormalizeRequired(shot.KeyframePrompt, $"Shot {i + 1} keyframePrompt"), 900);
            var videoPrompt = TrimToLength(NormalizeRequired(shot.VideoPrompt, $"Shot {i + 1} videoPrompt"), 1000);

            normalizedShots.Add(new RunwayShortVideoShot
            {
                Index = i + 1,
                Count = plan.Shots.Count,
                Title = title,
                Beat = beat,
                KeyframePrompt = keyframePrompt,
                VideoPrompt = videoPrompt,
            });
        }

        return new RunwayShortVideoPlan
        {
            SourceText = NormalizeRequired(plan.SourceText, nameof(plan.SourceText)),
            Scenario = TrimToLength(NormalizeRequired(plan.Scenario, nameof(plan.Scenario)), 360),
            Style = string.IsNullOrWhiteSpace(plan.Style)
                ? "cinematic, coherent visual continuity, natural motion, high production value, no captions"
                : NormalizeWhitespace(plan.Style),
            Model = NormalizeTextToVideoModel(options.Model),
            Ratio = options.Ratio,
            ShotDurationSeconds = options.ShotDurationSeconds,
            Shots = normalizedShots,
        };
    }

    private static string NormalizeRequired(string? value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{name} is required.");
        }

        return NormalizeWhitespace(value);
    }

    private static string CreateShortVideoPlannerSystemPrompt()
    {
        return """
            You are a film storyboard planner for Runway text-to-video.
            Return only compact JSON. Do not wrap it in Markdown.
            The JSON must match this shape:
            {
              "sourceText": "original user scenario",
              "scenario": "one compact scenario summary",
              "style": "shared visual style",
              "model": "Runway model id",
              "ratio": "output ratio",
              "shotDurationSeconds": 4,
              "shots": [
                {
                  "index": 1,
                  "count": 3,
                  "title": "short shot title",
                  "beat": "story beat",
                  "keyframePrompt": "still-frame composition prompt",
                  "videoPrompt": "Runway text-to-video prompt with camera movement and continuity"
                }
              ]
            }
            Keep prompts visual, concrete, and suitable for direct Runway text-to-video generation.
            Avoid captions, subtitles, logos, and unreadable text unless explicitly requested.
            """;
    }

    private static string CreateShortVideoPlannerUserPrompt(
        string scenarioText,
        RunwayShortVideoOptions options)
    {
        var style = string.IsNullOrWhiteSpace(options.Style)
            ? "cinematic, coherent visual continuity, natural motion, high production value, no captions"
            : NormalizeWhitespace(options.Style);

        return string.Create(
            CultureInfo.InvariantCulture,
            $"""
            Create a {options.ShotCount}-shot short-video plan.

            Scenario:
            {NormalizeWhitespace(scenarioText)}

            Constraints:
            - model: {NormalizeTextToVideoModel(options.Model)}
            - ratio: {options.Ratio}
            - duration per shot: {options.ShotDurationSeconds} seconds
            - shared style: {style}
            - return exactly {options.ShotCount} shots
            - each shot needs a keyframePrompt and a direct Runway videoPrompt
            """);
    }

    private static string ExtractJsonObject(string value)
    {
        var candidate = NormalizeWhitespace(value).Trim();
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
            throw new InvalidOperationException("Planner response did not contain a JSON object.");
        }

        candidate = candidate[start..(end + 1)];
        return IsJsonObject(candidate)
            ? candidate
            : throw new InvalidOperationException("Planner response did not contain valid JSON.");
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

    private static RunwayShortVideoOptions ValidateOptions(RunwayShortVideoOptions? options)
    {
        var effectiveOptions = options ?? new RunwayShortVideoOptions();
        if (effectiveOptions.ShotCount is < 1 or > 6)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "ShotCount must be between 1 and 6.");
        }

        if (effectiveOptions.ShotDurationSeconds <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "ShotDurationSeconds must be greater than zero.");
        }

        _ = NormalizeTextToVideoModel(effectiveOptions.Model);
        if (string.IsNullOrWhiteSpace(effectiveOptions.Ratio))
        {
            throw new ArgumentException("Ratio is required.", nameof(options));
        }

        return effectiveOptions;
    }

    private static string NormalizeTextToVideoModel(string? value)
    {
        var candidate = string.IsNullOrWhiteSpace(value) ? RunwayShortVideoOptions.DefaultModel : value.Trim();
        candidate = candidate switch
        {
            "gen45" or "gen4_5" or "gen4-5" => "gen4.5",
            "veo3.1-fast" or "veo3_1_fast" or "veo3-1-fast" => "veo3.1_fast",
            "veo3_1" or "veo3-1" => "veo3.1",
            _ => candidate,
        };

        return SupportedTextToVideoModels.Contains(candidate)
            ? candidate
            : throw new ArgumentException($"Unsupported model '{value}'. Supported values: {string.Join(", ", SupportedTextToVideoModels)}.");
    }

    private static CreateTextToVideoRequestGen45ContentModeration? CreateGen45ContentModeration(
        string? publicFigureThreshold)
    {
        if (string.IsNullOrWhiteSpace(publicFigureThreshold))
        {
            return null;
        }

        return new CreateTextToVideoRequestGen45ContentModeration
        {
            PublicFigureThreshold = CreateTextToVideoRequestGen45ContentModerationPublicFigureThresholdExtensions.ToEnum(publicFigureThreshold)
                ?? throw new ArgumentException("PublicFigureThreshold supports values: auto, low."),
        };
    }

    private static void AddAdditionalRequestProperties(
        IDictionary<string, object> additionalProperties,
        int? seed,
        string? publicFigureThreshold)
    {
        if (seed is { } seedValue)
        {
            additionalProperties["seed"] = seedValue;
        }

        if (!string.IsNullOrWhiteSpace(publicFigureThreshold))
        {
            additionalProperties["contentModeration"] = new Dictionary<string, object>
            {
                ["publicFigureThreshold"] = publicFigureThreshold,
            };
        }
    }

    private static string? ResolveShotOutput(string? output, int shotCount)
    {
        if (string.IsNullOrWhiteSpace(output) || shotCount == 1)
        {
            return output;
        }

        var fullOutput = Path.GetFullPath(output);
        var outputLooksLikeFile = !Directory.Exists(fullOutput) && !string.IsNullOrWhiteSpace(Path.GetExtension(fullOutput));
        return outputLooksLikeFile
            ? Path.Combine(Path.GetDirectoryName(fullOutput) ?? Environment.CurrentDirectory, $"{Path.GetFileNameWithoutExtension(fullOutput)}-segments")
            : fullOutput;
    }

    private static int ToWholeDuration(double duration, string model)
    {
        if (duration % 1 != 0)
        {
            throw new ArgumentException($"{model} short-video duration must be a whole number of seconds.");
        }

        var wholeDuration = checked((int)duration);
        if (wholeDuration is < 2 or > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(duration), $"{model} short-video duration must be between 2 and 10 seconds.");
        }

        return wholeDuration;
    }

    private static string CreateScenarioSummary(string sourceText, int shotCount)
    {
        return TrimToLength(
            string.Create(
                CultureInfo.InvariantCulture,
                $"{shotCount}-shot short film with a clear opening, escalation, and final payoff: {sourceText}"),
            360);
    }

    private static List<string> SplitIntoBeats(string sourceText)
    {
        var beats = new List<string>();
        var current = new StringBuilder();
        foreach (var character in sourceText)
        {
            current.Append(character);
            if (character is '.' or '!' or '?' or ';' or '\n')
            {
                AddBeat(beats, current);
            }
        }

        AddBeat(beats, current);
        if (beats.Count == 0)
        {
            beats.Add(sourceText);
        }

        return beats;
    }

    private static void AddBeat(List<string> beats, StringBuilder current)
    {
        var beat = CleanBeat(current.ToString());
        current.Clear();
        if (beat.Length > 0)
        {
            beats.Add(beat);
        }
    }

    private static string SelectBeat(List<string> beats, int index, int shotCount)
    {
        if (beats.Count == 1)
        {
            return beats[0];
        }

        var beatIndex = shotCount == 1
            ? 0
            : (int)Math.Round((double)(index - 1) * (beats.Count - 1) / (shotCount - 1), MidpointRounding.AwayFromZero);
        return beats[Math.Clamp(beatIndex, 0, beats.Count - 1)];
    }

    private static string GetShotRole(int index, int count)
    {
        if (count == 1)
        {
            return "Complete cinematic beat";
        }

        if (index == 1)
        {
            return "Establishing keyframe";
        }

        if (index == count)
        {
            return "Resolution keyframe";
        }

        return index == 2 ? "Action keyframe" : "Transition keyframe";
    }

    private static string GetShotMotion(int index, int count)
    {
        if (count == 1)
        {
            return "slow cinematic camera move with a clear beginning, middle, and ending in one continuous shot";
        }

        if (index == 1)
        {
            return "slow establishing push-in, reveal the subject and world with readable visual context";
        }

        if (index == count)
        {
            return "settled resolving move, hold on the final visual payoff";
        }

        return index == 2
            ? "controlled action movement, clear subject motion, maintain spatial continuity"
            : "smooth transitional camera move, connect the prior beat to the final payoff";
    }

    private static string CleanBeat(string value)
    {
        var beat = NormalizeWhitespace(value).Trim(' ', '-', '*', '#', ':');
        while (beat.Length > 0 && char.IsDigit(beat[0]))
        {
            beat = beat[1..].TrimStart(' ', '.', ')', '-');
        }

        return beat;
    }

    private static string NormalizeWhitespace(string value)
    {
        var builder = new StringBuilder(value.Length);
        var previousWasWhitespace = false;
        foreach (var character in value)
        {
            if (char.IsWhiteSpace(character))
            {
                if (!previousWasWhitespace)
                {
                    builder.Append(' ');
                    previousWasWhitespace = true;
                }

                continue;
            }

            builder.Append(character);
            previousWasWhitespace = false;
        }

        return builder.ToString().Trim();
    }

    private static string TrimToLength(string value, int maxLength)
    {
        if (value.Length <= maxLength)
        {
            return value;
        }

        var trimAt = value.LastIndexOf(' ', maxLength - 4, maxLength - 4);
        if (trimAt < maxLength / 2)
        {
            trimAt = maxLength - 3;
        }

        return string.Concat(value.AsSpan(0, trimAt).TrimEnd(), "...");
    }

    private sealed class InlineProgress<T>(Action<T> report) : IProgress<T>
    {
        private readonly Action<T> _report = report;

        public void Report(T value)
        {
            _report(value);
        }
    }
}
