using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Text.Json;
using Runway;

const string DefaultRunwayVersion = "2024-11-06";

var apiKeyOption = new Option<string?>("--api-key", ["-k"])
{
    Description = "Runway API key. Defaults to RUNWAY_API_KEY or RUNWAYML_API_SECRET.",
    Recursive = true,
};

var runwayVersionOption = new Option<string>("--runway-version")
{
    Description = "Runway API version header.",
    DefaultValueFactory = _ => DefaultRunwayVersion,
    Recursive = true,
};

var rootCommand = new RootCommand("Runway API CLI for generating images, videos, and avatar workflows.")
{
    apiKeyOption,
    runwayVersionOption,
};

var avatarCommand = new Command("avatar", "Manage avatars, avatar conversations, usage, and avatar videos.");
rootCommand.Subcommands.Add(avatarCommand);

var presetsCommand = new Command("presets", "List preset avatar and live voice IDs.");
avatarCommand.Subcommands.Add(presetsCommand);
presetsCommand.SetAction(_ =>
{
    Console.WriteLine("Preset avatars:");
    foreach (var preset in Enum.GetValues<CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId>())
    {
        Console.WriteLine($"  {preset.ToValueString()}");
    }

    Console.WriteLine();
    Console.WriteLine("Live avatar voices:");
    foreach (var preset in Enum.GetValues<CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId>())
    {
        Console.WriteLine($"  {preset.ToValueString()}");
    }
});

var limitOption = new Option<int>("--limit")
{
    Description = "Maximum items to return.",
    DefaultValueFactory = _ => 20,
};

var cursorOption = new Option<string?>("--cursor")
{
    Description = "Pagination cursor returned by a previous page.",
};

var listCommand = new Command("list", "List custom avatars.")
{
    limitOption,
    cursorOption,
};
avatarCommand.Subcommands.Add(listCommand);
listCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Avatars.GetAvatarsAsync(
            limit: parseResult.GetValue(limitOption),
            cursor: parseResult.GetValue(cursorOption),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var avatarIdArgument = new Argument<Guid>("id")
{
    Description = "Avatar ID.",
};

var getCommand = new Command("get", "Get one custom avatar.")
{
    avatarIdArgument,
};
avatarCommand.Subcommands.Add(getCommand);
getCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Avatars.GetAvatarsByIdAsync(
            id: parseResult.GetValue(avatarIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var nameOption = new Option<string?>("--name")
{
    Description = "Avatar display name.",
};

var referenceImageOption = new Option<string?>("--reference-image")
{
    Description = "HTTPS URL, Runway URI, or data URI containing the avatar reference image.",
};

var personalityOption = new Option<string?>("--personality")
{
    Description = "System prompt that defines avatar behavior.",
};

var startScriptOption = new Option<string?>("--start-script")
{
    Description = "Optional opening message the avatar says when a session starts.",
};

var voicePresetOption = new Option<string?>("--voice-preset")
{
    Description = "Runway live voice preset ID, for example adrian or maya.",
};

var customVoiceIdOption = new Option<Guid?>("--custom-voice-id")
{
    Description = "Custom voice ID from the Voices API.",
};

var documentIdOption = new Option<Guid[]>("--document-id")
{
    Description = "Knowledge document ID to attach. Repeat for multiple documents.",
    Arity = ArgumentArity.ZeroOrMore,
};

var imageProcessingOption = new Option<string?>("--image-processing")
{
    Description = "Avatar image preprocessing mode: optimize or none.",
};

var createCommand = new Command("create", "Create a custom avatar.")
{
    nameOption,
    referenceImageOption,
    personalityOption,
    startScriptOption,
    voicePresetOption,
    customVoiceIdOption,
    documentIdOption,
    imageProcessingOption,
};
avatarCommand.Subcommands.Add(createCommand);
createCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var name = RequireOption(parseResult, nameOption);
        var referenceImage = RequireOption(parseResult, referenceImageOption);
        var personality = RequireOption(parseResult, personalityOption);
        var voice = CreateAvatarVoice(
            parseResult.GetValue(voicePresetOption),
            parseResult.GetValue(customVoiceIdOption));
        var imageProcessing = ParseCreateImageProcessing(parseResult.GetValue(imageProcessingOption));
        var documentIds = ToList(parseResult.GetValue(documentIdOption));

        var response = await client.Avatars.CreateAvatarsAsync(
            xRunwayVersion: runwayVersion,
            name: name,
            referenceImage: referenceImage,
            personality: personality,
            startScript: parseResult.GetValue(startScriptOption),
            voice: voice,
            documentIds: documentIds,
            imageProcessing: imageProcessing,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var updateCommand = new Command("update", "Update a custom avatar.")
{
    avatarIdArgument,
    nameOption,
    referenceImageOption,
    personalityOption,
    startScriptOption,
    voicePresetOption,
    customVoiceIdOption,
    documentIdOption,
    imageProcessingOption,
};
avatarCommand.Subcommands.Add(updateCommand);
updateCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var voice = CreatePatchAvatarVoice(
            parseResult.GetValue(voicePresetOption),
            parseResult.GetValue(customVoiceIdOption));
        var imageProcessing = ParsePatchImageProcessing(parseResult.GetValue(imageProcessingOption));
        var documentIds = ToList(parseResult.GetValue(documentIdOption));

        var response = await client.Avatars.EditAvatarsByIdAsync(
            id: parseResult.GetValue(avatarIdArgument),
            xRunwayVersion: runwayVersion,
            name: parseResult.GetValue(nameOption),
            referenceImage: parseResult.GetValue(referenceImageOption),
            personality: parseResult.GetValue(personalityOption),
            startScript: parseResult.GetValue(startScriptOption),
            voice: voice,
            documentIds: documentIds,
            imageProcessing: imageProcessing,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var deleteCommand = new Command("delete", "Delete a custom avatar.")
{
    avatarIdArgument,
};
avatarCommand.Subcommands.Add(deleteCommand);
deleteCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.Avatars.DeleteAvatarsByIdAsync(
            id: parseResult.GetValue(avatarIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Deleted.");
    }, cancellationToken));

var conversationsCommand = new Command("conversations", "Inspect realtime avatar conversations.");
avatarCommand.Subcommands.Add(conversationsCommand);

var avatarFilterOption = new Option<Guid?>("--avatar-id")
{
    Description = "Filter conversations to a custom avatar ID.",
};

var startDateOption = new Option<DateTime?>("--start-date")
{
    Description = "UTC start date, for example 2026-05-08.",
};

var endDateOption = new Option<DateTime?>("--end-date")
{
    Description = "UTC end date, for example 2026-05-11.",
};

var listConversationsCommand = new Command("list", "List avatar conversations.")
{
    limitOption,
    cursorOption,
    avatarFilterOption,
    startDateOption,
    endDateOption,
};
conversationsCommand.Subcommands.Add(listConversationsCommand);
listConversationsCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Avatars.GetAvatarConversationsAsync(
            limit: parseResult.GetValue(limitOption),
            cursor: parseResult.GetValue(cursorOption),
            avatar: parseResult.GetValue(avatarFilterOption),
            startDate: parseResult.GetValue(startDateOption),
            endDate: parseResult.GetValue(endDateOption),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var conversationIdArgument = new Argument<Guid>("id")
{
    Description = "Conversation ID.",
};

var getConversationCommand = new Command("get", "Get one avatar conversation.")
{
    conversationIdArgument,
};
conversationsCommand.Subcommands.Add(getConversationCommand);
getConversationCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Avatars.GetAvatarConversationsByIdAsync(
            id: parseResult.GetValue(conversationIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var deleteConversationCommand = new Command("delete", "Delete one avatar conversation.")
{
    conversationIdArgument,
};
conversationsCommand.Subcommands.Add(deleteConversationCommand);
deleteConversationCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.Avatars.DeleteAvatarConversationsByIdAsync(
            id: parseResult.GetValue(conversationIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Deleted.");
    }, cancellationToken));

var usageCommand = new Command("usage", "Get aggregate avatar conversation usage.")
{
    startDateOption,
    endDateOption,
};
avatarCommand.Subcommands.Add(usageCommand);
usageCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var endDate = parseResult.GetValue(endDateOption) ?? DateTime.UtcNow.Date;
        var startDate = parseResult.GetValue(startDateOption) ?? endDate.AddDays(-7);

        var response = await client.Avatars.GetAvatarUsageAsync(
            startDate: startDate,
            endDate: endDate,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var textOption = new Option<string?>("--text")
{
    Description = "Script text for the avatar to speak.",
};

var presetAvatarOption = new Option<string?>("--preset-avatar")
{
    Description = "Preset avatar ID, for example influencer or cooking-teacher.",
};

var customAvatarIdOption = new Option<Guid?>("--avatar-id")
{
    Description = "Custom avatar ID. Overrides --preset-avatar when provided.",
};

var videoVoicePresetOption = new Option<string?>("--voice-preset")
{
    Description = "Optional TTS voice preset override, for example clara.",
};

var videoCustomVoiceIdOption = new Option<Guid?>("--custom-voice-id")
{
    Description = "Optional custom TTS voice override ID.",
};

var waitOption = new Option<bool>("--wait")
{
    Description = "Poll the task until it reaches a terminal state.",
};

var pollIntervalOption = new Option<int>("--poll-interval-seconds")
{
    Description = "Polling interval when --wait is set.",
    DefaultValueFactory = _ => 5,
};

var videoCommand = new Command("video", "Generate an avatar video from text.")
{
    textOption,
    presetAvatarOption,
    customAvatarIdOption,
    videoVoicePresetOption,
    videoCustomVoiceIdOption,
    waitOption,
    pollIntervalOption,
};
avatarCommand.Subcommands.Add(videoCommand);
videoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var text = RequireOption(parseResult, textOption);
        var avatar = CreateVideoAvatar(
            parseResult.GetValue(presetAvatarOption),
            parseResult.GetValue(customAvatarIdOption));
        var voice = CreateVideoVoice(
            parseResult.GetValue(videoVoicePresetOption),
            parseResult.GetValue(videoCustomVoiceIdOption));

        var response = await client.AvatarVideos.CreateAvatarVideosAsync(
            xRunwayVersion: runwayVersion,
            request: new CreateAvatarVideosRequest
            {
                Avatar = avatar,
                Speech = new CreateAvatarVideosRequestSpeechTextInput
                {
                    Text = text,
                    Voice = voice,
                },
            },
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);

        if (parseResult.GetValue(waitOption))
        {
            var task = await client.WaitForTaskAsync(
                response.Id,
                xRunwayVersion: runwayVersion,
                pollInterval: TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
                cancellationToken: ct).ConfigureAwait(false);

            WriteJson(task);
        }
    }, cancellationToken));

var videoPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var imagePromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var outputOption = new Option<string?>("--output", ["-o"])
{
    Description = "Output file or directory. Defaults to the current directory.",
};

var videoRatioOption = new Option<string>("--ratio")
{
    Description = "Video ratio/resolution. Common values: 1280:720, 720:1280, 1920:1080.",
    DefaultValueFactory = _ => "1280:720",
};

var imageRatioOption = new Option<string>("--ratio")
{
    Description = "Image ratio/resolution. Default model supports 1024:1024, 1344:768, 768:1344, and related Gemini ratios.",
    DefaultValueFactory = _ => "1024:1024",
};

var imageModelOption = new Option<string>("--model")
{
    Description = "Image model: gemini-2.5-flash or gen4-image-turbo.",
    DefaultValueFactory = _ => "gemini-2.5-flash",
};

var generationDurationOption = new Option<double?>("--duration")
{
    Description = "Optional video duration in seconds.",
};

var seedOption = new Option<int?>("--seed")
{
    Description = "Optional seed for repeatable generations.",
};

var promptImageOption = new Option<string?>("--image", ["-i"])
{
    Description = "Optional local path, HTTPS URL, Runway URI, or data URI to use as the first frame.",
};

var referenceImageOption2 = new Option<string[]>("--reference-image")
{
    Description = "Optional local path, HTTPS URL, Runway URI, or data URI image reference. Repeat up to three times.",
    Arity = ArgumentArity.ZeroOrMore,
};

var noAudioOption = new Option<bool>("--no-audio")
{
    Description = "Disable generated audio for supported video models.",
};

var noWaitOption = new Option<bool>("--no-wait")
{
    Description = "Submit the task and print the task ID without waiting or downloading outputs.",
};

var generateVideoCommand = new Command("video", "Generate a video locally from a text prompt.")
{
    videoPromptArgument,
    promptImageOption,
    outputOption,
    videoRatioOption,
    generationDurationOption,
    seedOption,
    noAudioOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(generateVideoCommand);
generateVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var prompt = RunwayCliGeneration.JoinPrompt(parseResult.GetValue(videoPromptArgument));
        var promptImage = parseResult.GetValue(promptImageOption);
        var ratio = parseResult.GetValue(videoRatioOption) ?? "1280:720";
        var duration = parseResult.GetValue(generationDurationOption);
        var seed = parseResult.GetValue(seedOption);
        Guid taskId;

        if (promptImage is { Length: > 0 })
        {
            var asset = await RunwayCliGeneration.NormalizeInputAssetAsync(promptImage, ct).ConfigureAwait(false);
            var response = await client.StartGenerating.CreateImageToVideoAsync(
                request: new CreateImageToVideoRequestGen4Turbo
                {
                    PromptText = prompt,
                    PromptImage = asset,
                    Ratio = RunwayCliGeneration.ParseImageToVideoRatio(ratio),
                    Duration = RunwayCliGeneration.ToWholeSeconds(duration),
                    Seed = seed,
                },
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false);

            taskId = response.Id;
        }
        else
        {
            var response = await client.StartGenerating.CreateTextToVideoAsync(
                request: new CreateTextToVideoRequestVeo31Fast
                {
                    PromptText = prompt,
                    Ratio = RunwayCliGeneration.ParseTextToVideoRatio(ratio),
                    Audio = !parseResult.GetValue(noAudioOption),
                    Duration = duration,
                },
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false);

            taskId = response.Id;
        }

        await Console.Error.WriteLineAsync($"Task ID: {taskId}").ConfigureAwait(false);

        if (parseResult.GetValue(noWaitOption))
        {
            Console.WriteLine(taskId);
            return;
        }

        var task = await client.WaitForTaskAsync(
            taskId,
            xRunwayVersion: runwayVersion,
            pollInterval: TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
            progress: CreateConsoleProgress(),
            cancellationToken: ct).ConfigureAwait(false);

        var downloaded = await task.DownloadOutputsAsync(
            output: parseResult.GetValue(outputOption),
            defaultExtension: ".mp4",
            stemPrefix: "runway-video",
            cancellationToken: ct).ConfigureAwait(false);

        foreach (var path in downloaded)
        {
            Console.WriteLine(path);
        }
    }, cancellationToken));

var generateImageCommand = new Command("image", "Generate an image locally from a text prompt.")
{
    imagePromptArgument,
    outputOption,
    imageRatioOption,
    imageModelOption,
    seedOption,
    referenceImageOption2,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(generateImageCommand);
generateImageCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var prompt = RunwayCliGeneration.JoinPrompt(parseResult.GetValue(imagePromptArgument));
        var imageModel = parseResult.GetValue(imageModelOption) ?? "gemini-2.5-flash";
        var ratio = parseResult.GetValue(imageRatioOption) ?? "1024:1024";
        var referenceImages = parseResult.GetValue(referenceImageOption2);
        var seed = parseResult.GetValue(seedOption);
        var request = imageModel switch
        {
            "gemini-2.5-flash" or "gemini_2.5_flash" => CreateGemini25FlashImageRequest(prompt, ratio, referenceImages, seed, ct),
            "gen4-image-turbo" or "gen4_image_turbo" => CreateGen4ImageTurboRequest(prompt, ratio, referenceImages, seed, ct),
            _ => throw new ArgumentException($"Unsupported image model '{imageModel}'. Supported values: gemini-2.5-flash, gen4-image-turbo."),
        };

        var response = await client.StartGenerating.CreateTextToImageAsync(
            request: await request.ConfigureAwait(false),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await Console.Error.WriteLineAsync($"Task ID: {response.Id}").ConfigureAwait(false);

        if (parseResult.GetValue(noWaitOption))
        {
            Console.WriteLine(response.Id);
            return;
        }

        var task = await client.WaitForTaskAsync(
            response.Id,
            xRunwayVersion: runwayVersion,
            pollInterval: TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
            progress: CreateConsoleProgress(),
            cancellationToken: ct).ConfigureAwait(false);

        var downloaded = await task.DownloadOutputsAsync(
            output: parseResult.GetValue(outputOption),
            defaultExtension: ".png",
            stemPrefix: "runway-image",
            cancellationToken: ct).ConfigureAwait(false);

        foreach (var path in downloaded)
        {
            Console.WriteLine(path);
        }
    }, cancellationToken));

var taskCommand = new Command("task", "Inspect or cancel Runway generation tasks.");
rootCommand.Subcommands.Add(taskCommand);

var taskIdArgument = new Argument<Guid>("id")
{
    Description = "Task ID.",
};

var downloadOption = new Option<bool>("--download")
{
    Description = "Download outputs when the task has succeeded. Use with --wait to download after completion.",
};

var taskKindOption = new Option<string>("--kind")
{
    Description = "Output kind used to choose the default extension when downloading: video or image.",
    DefaultValueFactory = _ => "video",
};

var getTaskCommand = new Command("get", "Get a task status.")
{
    taskIdArgument,
    waitOption,
    downloadOption,
    outputOption,
    taskKindOption,
    pollIntervalOption,
};
taskCommand.Subcommands.Add(getTaskCommand);
getTaskCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var taskId = parseResult.GetValue(taskIdArgument);
        var task = parseResult.GetValue(waitOption)
            ? await client.WaitForTaskAsync(
                taskId,
                xRunwayVersion: runwayVersion,
                pollInterval: TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
                progress: CreateConsoleProgress(),
                cancellationToken: ct).ConfigureAwait(false)
            : await client.TaskManagement.GetTasksByIdAsync(
                id: taskId,
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false);

        if (parseResult.GetValue(downloadOption))
        {
            var kind = parseResult.GetValue(taskKindOption) ?? "video";
            var downloaded = await task.DownloadOutputsAsync(
                output: parseResult.GetValue(outputOption),
                defaultExtension: kind.Equals("image", StringComparison.OrdinalIgnoreCase) ? ".png" : ".mp4",
                stemPrefix: kind.Equals("image", StringComparison.OrdinalIgnoreCase) ? "runway-image" : "runway-video",
                cancellationToken: ct).ConfigureAwait(false);

            foreach (var path in downloaded)
            {
                Console.WriteLine(path);
            }

            return;
        }

        WriteJson(task);
    }, cancellationToken));

var cancelTaskCommand = new Command("cancel", "Cancel or delete a task.")
{
    taskIdArgument,
};
taskCommand.Subcommands.Add(cancelTaskCommand);
cancelTaskCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.TaskManagement.DeleteTasksByIdAsync(
            id: parseResult.GetValue(taskIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Cancelled.");
    }, cancellationToken));

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);

static async Task<CreateTextToImageRequest> CreateGemini25FlashImageRequest(
    string prompt,
    string ratio,
    string[]? referenceImages,
    int? seed,
    CancellationToken cancellationToken)
{
    if (seed is not null)
    {
        throw new ArgumentException("--seed is only supported with --model gen4-image-turbo.");
    }

    var references = await RunwayCliGeneration.CreateGemini25FlashReferenceImagesAsync(
        referenceImages,
        cancellationToken).ConfigureAwait(false);

    return new CreateTextToImageRequestGemini25Flash
    {
        PromptText = prompt,
        Ratio = RunwayCliGeneration.ParseGemini25FlashImageRatio(ratio),
        ReferenceImages = references.Count > 0 ? references : null,
    };
}

static async Task<CreateTextToImageRequest> CreateGen4ImageTurboRequest(
    string prompt,
    string ratio,
    string[]? referenceImages,
    int? seed,
    CancellationToken cancellationToken)
{
    var references = await RunwayCliGeneration.CreateGen4ImageTurboReferenceImagesAsync(
        referenceImages,
        cancellationToken).ConfigureAwait(false);

    if (references.Count == 0)
    {
        throw new ArgumentException("--model gen4-image-turbo requires at least one --reference-image. Omit --model for prompt-only image generation.");
    }

    return new CreateTextToImageRequestGen4ImageTurbo
    {
        PromptText = prompt,
        Ratio = RunwayCliGeneration.ParseGen4ImageTurboRatio(ratio),
        Seed = seed,
        ReferenceImages = references,
    };
}

async Task<int> RunWithClientAsync(
    ParseResult parseResult,
    Func<RunwayClient, string, CancellationToken, Task> action,
    CancellationToken cancellationToken)
{
    try
    {
        using var client = CreateClient(parseResult);
        var runwayVersion = parseResult.GetValue(runwayVersionOption) ?? DefaultRunwayVersion;
        await action(client, runwayVersion, cancellationToken).ConfigureAwait(false);
        return 0;
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }
}

RunwayClient CreateClient(ParseResult parseResult)
{
    var apiKey =
        parseResult.GetValue(apiKeyOption) is { Length: > 0 } optionValue ? optionValue :
        Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } runwayApiKey ? runwayApiKey :
        Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET") is { Length: > 0 } runwayMlApiKey ? runwayMlApiKey :
        throw new InvalidOperationException("Set --api-key, RUNWAY_API_KEY, or RUNWAYML_API_SECRET.");

    return new RunwayClient(apiKey);
}

static async Task WriteErrorAsync(Exception exception)
{
    if (exception is ApiException apiException)
    {
        await Console.Error.WriteLineAsync($"Runway API error {(int)apiException.StatusCode}: {apiException.Message}").ConfigureAwait(false);
        if (!string.IsNullOrWhiteSpace(apiException.ResponseBody))
        {
            await Console.Error.WriteLineAsync(apiException.ResponseBody).ConfigureAwait(false);
        }

        return;
    }

    await Console.Error.WriteLineAsync(exception.Message).ConfigureAwait(false);
}

static string RequireOption(ParseResult parseResult, Option<string?> option)
{
    return parseResult.GetValue(option) is { Length: > 0 } value
        ? value
        : throw new ArgumentException($"Missing required option {option.Name}.");
}

static IList<Guid>? ToList(Guid[]? values)
{
    return values is { Length: > 0 } ? values : null;
}

static Voice CreateAvatarVoice(string? presetId, Guid? customVoiceId)
{
    if (customVoiceId is { } id)
    {
        return new CreateAvatarsRequestVoiceCustomVoice
        {
            Id = id,
        };
    }

    return new CreateAvatarsRequestVoiceRunwayLivePresetVoice
    {
        PresetId = ParseCreateAvatarVoicePreset(presetId ?? "adrian"),
    };
}

static Voice2? CreatePatchAvatarVoice(string? presetId, Guid? customVoiceId)
{
    if (customVoiceId is { } id)
    {
        return new PatchAvatarsRequestVoiceCustomVoice
        {
            Id = id,
        };
    }

    if (presetId is not { Length: > 0 })
    {
        return null;
    }

    return new PatchAvatarsRequestVoiceRunwayLivePresetVoice
    {
        PresetId = ParsePatchAvatarVoicePreset(presetId),
    };
}

static Avatar CreateVideoAvatar(string? presetId, Guid? customAvatarId)
{
    if (customAvatarId is { } id)
    {
        return new CreateAvatarVideosRequestAvatarCustomAvatar
        {
            AvatarId = id,
        };
    }

    return new CreateAvatarVideosRequestAvatarRunwayPresetAvatar
    {
        PresetId = ParseVideoAvatarPreset(presetId ?? "influencer"),
    };
}

static Voice3? CreateVideoVoice(string? presetId, Guid? customVoiceId)
{
    if (customVoiceId is { } id)
    {
        return new CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice
        {
            Id = id,
        };
    }

    if (presetId is not { Length: > 0 })
    {
        return null;
    }

    return new CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoice
    {
        PresetId = ParseVideoVoicePreset(presetId),
    };
}

static CreateAvatarsRequestImageProcessing? ParseCreateImageProcessing(string? value)
{
    return value is { Length: > 0 }
        ? CreateAvatarsRequestImageProcessingExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported image processing mode '{value}'.")
        : null;
}

static PatchAvatarsRequestImageProcessing? ParsePatchImageProcessing(string? value)
{
    return value is { Length: > 0 }
        ? PatchAvatarsRequestImageProcessingExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported image processing mode '{value}'.")
        : null;
}

static CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetId ParseCreateAvatarVoicePreset(string value)
{
    return CreateAvatarsRequestVoiceRunwayLivePresetVoicePresetIdExtensions.ToEnum(value)
        ?? throw new ArgumentException($"Unsupported avatar voice preset '{value}'. Run 'runway avatar presets' to list IDs.");
}

static PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetId ParsePatchAvatarVoicePreset(string value)
{
    return PatchAvatarsRequestVoiceRunwayLivePresetVoicePresetIdExtensions.ToEnum(value)
        ?? throw new ArgumentException($"Unsupported avatar voice preset '{value}'. Run 'runway avatar presets' to list IDs.");
}

static CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetId ParseVideoAvatarPreset(string value)
{
    return CreateAvatarVideosRequestAvatarRunwayPresetAvatarPresetIdExtensions.ToEnum(value)
        ?? throw new ArgumentException($"Unsupported avatar preset '{value}'. Run 'runway avatar presets' to list IDs.");
}

static CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetId ParseVideoVoicePreset(string value)
{
    return CreateAvatarVideosRequestSpeechTextInputVoiceRunwayPresetVoicePresetIdExtensions.ToEnum(value)
        ?? throw new ArgumentException($"Unsupported video voice preset '{value}'. Run 'runway avatar presets' to list IDs.");
}

static IProgress<GetTasksResponse> CreateConsoleProgress()
{
    return new Progress<GetTasksResponse>(WriteTaskProgress);
}

static void WriteTaskProgress(GetTasksResponse task)
{
    if (task.Running is { } running)
    {
        Console.Error.WriteLine(string.Create(CultureInfo.InvariantCulture, $"Status: {running.Status} ({running.Progress:P0})"));
    }
    else if (task.Pending is { } pending)
    {
        Console.Error.WriteLine($"Status: {pending.Status}");
    }
    else if (task.Throttled is { } throttled)
    {
        Console.Error.WriteLine($"Status: {throttled.Status}");
    }
    else if (task.Succeeded is { } succeeded)
    {
        Console.Error.WriteLine($"Status: {succeeded.Status}");
    }
    else if (task.Failed is { } failed)
    {
        Console.Error.WriteLine($"Status: {failed.Status}");
    }
    else if (task.Cancelled is { } cancelled)
    {
        Console.Error.WriteLine($"Status: {cancelled.Status}");
    }
}

static void WriteJson<T>(T value)
{
    Console.WriteLine(JsonSerializer.Serialize(
        value,
        typeof(T),
        SourceGenerationContext.Default));
}
