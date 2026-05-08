#pragma warning disable CS3002 // Return type is not CLS-compliant

using System.ComponentModel;
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Runway;

/// <summary>
/// Extensions for exposing Runway generation endpoints as Microsoft.Extensions.AI tools.
/// </summary>
public static class RunwayClientToolExtensions
{
    /// <summary>
    /// Returns the default Runway generation tools for agent workflows.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <returns>A list of AI functions for creating and inspecting Runway generation tasks.</returns>
    public static IList<AIFunction> AsTools(
        this RunwayClient client,
        string runwayVersion = "2024-11-06")
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsShortVideoTool(runwayVersion),
            client.AsTextToVideoTool(runwayVersion),
            client.AsGenerateImageTool(runwayVersion),
            client.AsImageToVideoTool(runwayVersion),
            client.AsGetTaskTool(runwayVersion),
        ];
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that expands a scenario into a multi-shot short-video plan and starts one task per shot.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <param name="shotCount">Number of shots to plan and submit.</param>
    /// <param name="ratio">The output video ratio.</param>
    /// <param name="duration">Duration in seconds for each shot.</param>
    /// <param name="audio">Whether to request generated audio for models that support it.</param>
    /// <returns>An AI function that returns the planned shots and task IDs.</returns>
    public static AIFunction AsShortVideoTool(
        this RunwayClient client,
        string runwayVersion = "2024-11-06",
        int shotCount = 3,
        string ratio = RunwayShortVideoOptions.DefaultRatio,
        double duration = 4,
        bool audio = false)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Scenario text to turn into a coherent multi-shot short video.")] string scenario,
                [Description("Optional visual style guidance shared by all planned shots.")] string? style,
                CancellationToken cancellationToken) =>
            {
                var result = await client.CreateShortVideoAsync(
                    scenario,
                    new RunwayShortVideoOptions
                    {
                        ShotCount = shotCount,
                        Ratio = ratio,
                        ShotDurationSeconds = duration,
                        Audio = audio,
                        Style = style,
                        WaitForCompletion = false,
                        DownloadOutputs = false,
                    },
                    runwayVersion,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatShortVideoResult(result);
            },
            name: "Runway_ShortVideo",
            description: "Expands a scenario into keyframe prompts, starts one Runway text-to-video task per shot, and returns the task IDs to poll or download later.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that starts a Runway text-to-video task.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <param name="ratio">The output video ratio.</param>
    /// <param name="duration">Optional duration in seconds.</param>
    /// <param name="audio">Whether to generate audio when the selected model supports it.</param>
    /// <returns>An AI function that starts a text-to-video generation task.</returns>
    public static AIFunction AsTextToVideoTool(
        this RunwayClient client,
        string runwayVersion = "2024-11-06",
        CreateTextToVideoRequestVeo31FastRatio ratio = CreateTextToVideoRequestVeo31FastRatio.x1280_720,
        double? duration = null,
        bool audio = true)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Detailed prompt describing the video content, visual style, camera movement, and motion.")] string prompt,
                CancellationToken cancellationToken) =>
            {
                var response = await client.StartGenerating.CreateTextToVideoAsync(
                    request: new CreateTextToVideoRequestVeo31Fast
                    {
                        PromptText = prompt,
                        Ratio = ratio,
                        Duration = duration,
                        Audio = audio,
                    },
                    xRunwayVersion: runwayVersion,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreatedTask(response.Id, "text-to-video");
            },
            name: "Runway_TextToVideo",
            description: "Starts a Runway text-to-video generation task. Returns a task ID; call Runway_GetTask to check status and output URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that starts a Runway image-to-video task.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <param name="ratio">The output video ratio.</param>
    /// <param name="duration">Optional duration in whole seconds.</param>
    /// <returns>An AI function that starts an image-to-video generation task.</returns>
    public static AIFunction AsImageToVideoTool(
        this RunwayClient client,
        string runwayVersion = "2024-11-06",
        CreateImageToVideoRequestGen4TurboRatio ratio = CreateImageToVideoRequestGen4TurboRatio.x1280_720,
        int? duration = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("HTTPS URL, Runway URI, or data URI for the source image.")] string image,
                [Description("Optional prompt describing how the source image should move or transform.")] string? prompt,
                CancellationToken cancellationToken) =>
            {
                var response = await client.StartGenerating.CreateImageToVideoAsync(
                    request: new CreateImageToVideoRequestGen4Turbo
                    {
                        PromptImage = image,
                        PromptText = prompt,
                        Ratio = ratio,
                        Duration = duration,
                    },
                    xRunwayVersion: runwayVersion,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreatedTask(response.Id, "image-to-video");
            },
            name: "Runway_ImageToVideo",
            description: "Starts a Runway image-to-video generation task from an image URL, Runway URI, or data URI. Returns a task ID; call Runway_GetTask to check status and output URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that starts a Runway text-to-image task.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <param name="ratio">The output image ratio.</param>
    /// <returns>An AI function that starts a text-to-image generation task.</returns>
    public static AIFunction AsGenerateImageTool(
        this RunwayClient client,
        string runwayVersion = "2024-11-06",
        CreateTextToImageRequestGemini25FlashRatio ratio = CreateTextToImageRequestGemini25FlashRatio.x1024_1024)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Detailed prompt describing the desired image content, composition, lighting, and style.")] string prompt,
                [Description("Optional HTTPS URL, Runway URI, or data URI image reference.")] string? referenceImage,
                CancellationToken cancellationToken) =>
            {
                var referenceImages = string.IsNullOrWhiteSpace(referenceImage)
                    ? null
                    : new List<CreateTextToImageRequestGemini25FlashReferenceImage>
                    {
                        new()
                        {
                            Uri = referenceImage,
                            Tag = "reference1",
                        },
                    };

                var response = await client.StartGenerating.CreateTextToImageAsync(
                    request: new CreateTextToImageRequestGemini25Flash
                    {
                        PromptText = prompt,
                        Ratio = ratio,
                        ReferenceImages = referenceImages,
                    },
                    xRunwayVersion: runwayVersion,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreatedTask(response.Id, "text-to-image");
            },
            name: "Runway_GenerateImage",
            description: "Starts a Runway text-to-image generation task. Returns a task ID; call Runway_GetTask to check status and output URLs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves or waits for a Runway task.
    /// </summary>
    /// <param name="client">The Runway client.</param>
    /// <param name="runwayVersion">The Runway API version header.</param>
    /// <returns>An AI function that returns task status and output URLs when available.</returns>
    public static AIFunction AsGetTaskTool(
        this RunwayClient client,
        string runwayVersion = "2024-11-06")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Runway task ID returned by a generation tool.")] string taskId,
                [Description("Whether to poll until the task reaches succeeded, failed, or cancelled.")] bool? wait,
                [Description("Polling interval in seconds when wait is true. Defaults to 5.")] int? pollIntervalSeconds,
                CancellationToken cancellationToken) =>
            {
                var id = Guid.Parse(taskId);
                var task = wait == true
                    ? await client.WaitForTaskAsync(
                        id,
                        xRunwayVersion: runwayVersion,
                        pollInterval: TimeSpan.FromSeconds(pollIntervalSeconds ?? 5),
                        cancellationToken: cancellationToken).ConfigureAwait(false)
                    : await client.TaskManagement.GetTasksByIdAsync(
                        id: id,
                        xRunwayVersion: runwayVersion,
                        cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(task);
            },
            name: "Runway_GetTask",
            description: "Gets a Runway task status by ID. Can optionally wait for completion. When complete, returns output URLs that should be downloaded before they expire.");
    }

    private static string FormatCreatedTask(Guid taskId, string taskType)
    {
        return string.Create(
            CultureInfo.InvariantCulture,
            $"Runway {taskType} task created.\nTask ID: {taskId}");
    }

    private static string FormatShortVideoResult(RunwayShortVideoResult result)
    {
        var lines = new List<string>
        {
            "Runway short-video tasks created.",
            $"Scenario: {result.Plan.Scenario}",
            "Shots:",
        };

        foreach (var shot in result.Shots)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"- {shot.Shot.Index}. {shot.Shot.Title}"));
            lines.Add($"  Beat: {shot.Shot.Beat}");
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"  Task ID: {shot.TaskId}"));
        }

        return string.Join("\n", lines);
    }

    private static string FormatTask(GetTasksResponse task)
    {
        var lines = new List<string>();

        if (task.Succeeded is { } succeeded)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {succeeded.Id}"));
            lines.Add($"Status: {succeeded.Status}");
            lines.Add("Outputs:");
            foreach (var output in succeeded.Output)
            {
                lines.Add($"- {output}");
            }
        }
        else if (task.Failed is { } failed)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {failed.Id}"));
            lines.Add($"Status: {failed.Status}");
            lines.Add($"Failure: {failed.Failure}");
            if (!string.IsNullOrWhiteSpace(failed.FailureCode))
            {
                lines.Add($"Failure code: {failed.FailureCode}");
            }
        }
        else if (task.Running is { } running)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {running.Id}"));
            lines.Add($"Status: {running.Status}");
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Progress: {running.Progress:P0}"));
        }
        else if (task.Pending is { } pending)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {pending.Id}"));
            lines.Add($"Status: {pending.Status}");
        }
        else if (task.Throttled is { } throttled)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {throttled.Id}"));
            lines.Add($"Status: {throttled.Status}");
        }
        else if (task.Cancelled is { } cancelled)
        {
            lines.Add(string.Create(CultureInfo.InvariantCulture, $"Task ID: {cancelled.Id}"));
            lines.Add($"Status: {cancelled.Status}");
        }
        else
        {
            lines.Add("Task status is unknown.");
        }

        return string.Join("\n", lines);
    }
}
