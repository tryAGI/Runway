using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;
using Runway.Cli.GeneratedApi.Commands;

// Historical CLI names → SDK types so the long-standing CLI surface stays callable.

const string DefaultRunwayVersion = "2024-11-06";

// --quiet is read straight off the raw args because the informational writers are shared by code paths
// that do not all have a ParseResult in hand, including static local functions. See RunwayCliConsole for
// the stdout/stderr contract this enforces.
var quietMode = args.Any(argument => argument is "--quiet" or "-q");
RunwayCliConsole.Quiet = quietMode;

var apiKeyOption = new Option<string?>("--api-key", ["-k"])
{
    Description = "Runway API key. Defaults to RUNWAY_API_KEY, RUNWAYML_API_SECRET, or .env.",
    Recursive = true,
};

var quietOption = new Option<bool>("--quiet", ["-q"])
{
    Description = "Suppress progress and informational output on stderr. Errors are still reported and stdout is unaffected.",
    Recursive = true,
};

var formatOption = new Option<string?>("--format")
{
    Description = "Format of the machine-readable stdout stream: `text` (default; one task ID or file path per line) or `json` (one object carrying the task ID and the output paths). Errors always go to stderr.",
    Recursive = true,
};

var baseUrlOption = new Option<string?>("--base-url")
{
    Description = "Runway API base URL. Defaults to RUNWAY_BASE_URL or .env, then the production API. Useful for proxies, staging, and local stubs.",
    Recursive = true,
};

var runwayVersionOption = new Option<string>("--runway-version")
{
    Description = "Runway API version header.",
    DefaultValueFactory = _ => DefaultRunwayVersion,
    Recursive = true,
};

var rootCommand = new RootCommand("Runway API CLI for generation, task, upload, voice, realtime, workflow, organization, and avatar workflows.")
{
    apiKeyOption,
    baseUrlOption,
    quietOption,
    formatOption,
    runwayVersionOption,
};
var apiCommand = ApiCommand.Create();
AttachJsonBodyValidation(apiCommand);
rootCommand.Subcommands.Add(apiCommand);

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

var avatarAudioOption = new Option<string?>("--audio")
{
    Description = "HTTPS URL, Runway URI, data URI, or local audio file for the avatar to speak.",
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
    Description = "Optional TTS preset voice override, for example Maya or Claudia.",
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

var retryOnInternalErrorOption = new Option<int>("--retry-on-internal-error")
{
    Description = "Retry up to N times when the server returns an INTERNAL.* failure code (transient server flakes such as INTERNAL.BAD_OUTPUT.CODE01). Other failure codes are not retried.",
    DefaultValueFactory = _ => 0,
};

var retryBackoffSecondsOption = new Option<int>("--retry-backoff-seconds")
{
    Description = "Base delay in seconds between retries when --retry-on-internal-error fires.",
    DefaultValueFactory = _ => 5,
};

var recipeRetryOnInternalErrorOption = new Option<int>("--retry-on-internal-error")
{
    Description = "Retry up to N times when the server returns an INTERNAL.* failure code on any shot. Recipes default to 2 because losing a single shot to a transient flake should not abort a multi-shot recipe.",
    DefaultValueFactory = _ => 2,
};

var videoCommand = new Command("video", "Generate an avatar video from text or audio.")
{
    textOption,
    avatarAudioOption,
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
        RunwayModelSchema.EnsureModelSupportsEndpoint("gwm1_avatars", "avatar_videos");
        var text = parseResult.GetValue(textOption);
        var audio = parseResult.GetValue(avatarAudioOption);
        if (audio is not { Length: > 0 } && text is not { Length: > 0 })
        {
            throw new ArgumentException("Set --text or --audio.");
        }

        var avatar = CreateVideoAvatar(
            parseResult.GetValue(presetAvatarOption),
            parseResult.GetValue(customAvatarIdOption));
        Speech speech = audio is { Length: > 0 }
            ? new CreateAvatarVideosRequestSpeechAudioInput
            {
                Audio = await RunwayCliGeneration.NormalizeInputAssetAsync(audio, ct).ConfigureAwait(false),
            }
            : new CreateAvatarVideosRequestSpeechTextInput
            {
                Text = text!,
                Voice = CreateVideoVoice(
                    parseResult.GetValue(videoVoicePresetOption),
                    parseResult.GetValue(videoCustomVoiceIdOption)),
            };

        var response = await client.AvatarVideos.CreateAvatarVideosAsync(
            xRunwayVersion: runwayVersion,
            request: new CreateAvatarVideosRequest
            {
                Avatar = avatar,
                Speech = speech,
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

var shortVideoPromptArgument = new Argument<string[]>("scenario")
{
    Description = "Scenario text to expand into a short multi-shot video.",
    Arity = ArgumentArity.ZeroOrMore,
};

var imagePromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var textToVideoPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var videoToVideoPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional. Optional for models that can be steered by references alone (seedance2 family).",
    Arity = ArgumentArity.ZeroOrMore,
};

var soundEffectPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var textToSpeechPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
};

var outputOption = new Option<string?>("--output", ["-o"])
{
    Description = "Output file or directory. Defaults to the current directory.",
};

var jsonOption = new Option<string?>("--json")
{
    Description = "Full JSON request body, @path to a JSON file, or '-' for stdin. Overrides friendly options.",
};

var videoRatioOption = new Option<string>("--ratio")
{
    Description = "Video ratio/resolution. Common values: 1280:720, 720:1280, 1920:1080.",
    DefaultValueFactory = _ => "1280:720",
};

var shortVideoRatioOption = new Option<string?>("--ratio")
{
    Description = "Short-video ratio/resolution. Defaults to the plan value or 1280:720.",
};

var imageRatioOption = new Option<string?>("--ratio")
{
    Description = "Image ratio/resolution. Defaults are model-specific; GPT Image 2 commonly uses 1920:1088, 2560:1440, or 1920:1920.",
};

var imageModelOption = new Option<string>("--model")
{
    Description = "Image model, validated against the embedded OpenAPI spec: gemini-2.5-flash, gemini-image3-pro, gemini-image3.1-flash, gpt-image-2, gen4-image, gen4-image-turbo, muse-image, seedream5-pro, seedream5-lite, grok-imagine-image-2. Run `runway models schema <model>` for the exact parameter list.",
    DefaultValueFactory = _ => "gemini-2.5-flash",
};

var imageResolutionOption = new Option<string?>("--resolution")
{
    Description = "Deprecated GPT Image 2 resolution tier. Current API ignores this; use --ratio for output size.",
};

var imageQualityOption = new Option<string?>("--quality")
{
    Description = "Rendering quality for the models that accept it: gpt-image-2 (low, medium, high, auto) and grok-imagine-image-2 (low, medium).",
};

var imageOutputFormatOption = new Option<string?>("--output-format")
{
    Description = "Output file format for the seedream models: png or jpeg.",
};

var imageBackgroundOption = new Option<string?>("--background")
{
    Description = "Background treatment for gpt-image-2: opaque or auto.",
};

var imageGroundingOption = new Option<bool?>("--grounding")
{
    Description = "Enable live web search so the model can use current brand, trend, or event context (seedream5-pro, seedream5-lite).",
};

var imageEditOption = new Option<bool?>("--edit")
{
    Description = "With exactly one --reference-image, edit that image directly instead of using it as a style reference (grok-imagine-image-2).",
};

RunwayCliImageExtras BuildImageExtras(ParseResult parseResult) => new()
{
    OutputFormat = parseResult.GetValue(imageOutputFormatOption),
    Background = parseResult.GetValue(imageBackgroundOption),
    Grounding = parseResult.GetValue(imageGroundingOption),
    Edit = parseResult.GetValue(imageEditOption),
};

var videoModelOption = new Option<string?>("--model")
{
    Description = "Video model, validated against the embedded OpenAPI spec per endpoint. Text/image: gen4.5, gen4-turbo (image), veo3.1, veo3.1-fast, hailuo3, happyhorse-1-0, seedance2, seedance2-fast, seedance2-mini, seedance2-5, gemini-omni-flash, grok-imagine-1-5, wan3. Video-to-video: aleph2 (default), hailuo3, seedance2, seedance2-fast, seedance2-mini, seedance2-5, gemini-omni-flash. Run `runway models schema <model>` for the exact parameter list.",
};

var videoReferenceImageOption = new Option<string[]>("--reference-image")
{
    Description = "Image reference (local path, HTTPS URL, Runway URI, or data URI) passed as `references`. Repeat for more: up to 9 for hailuo3/seedance2, 10 for wan3, 7 for grok-imagine-1-5, 30 for seedance2-5.",
    Arity = ArgumentArity.ZeroOrMore,
};

var videoReferenceVideoOption = new Option<string[]>("--reference-video")
{
    Description = "Video reference passed as `referenceVideos` for additional motion/context. Repeat for more; combined duration is capped by the model (15s for most, 30s for seedance2-5).",
    Arity = ArgumentArity.ZeroOrMore,
};

var videoReferenceAudioOption = new Option<string[]>("--reference-audio")
{
    Description = "Audio reference passed as `referenceAudio` so the model can drive the output with the supplied audio. Repeat for more.",
    Arity = ArgumentArity.ZeroOrMore,
};

var videoKeyframeOption = new Option<string[]>("--keyframe")
{
    Description = "aleph2 timed guidance still, as <image>@<seconds> or <image>@<percent>%. Repeat up to five times.",
    Arity = ArgumentArity.ZeroOrMore,
};

var videoNegativePromptOption = new Option<string?>("--negative-prompt")
{
    Description = "What to avoid in the output (veo3.1 and veo3.1-fast).",
};

var videoResolutionOption = new Option<string?>("--resolution")
{
    Description = "Output resolution tier for models that size by resolution instead of ratio: hailuo3 (768P, 2K), happyhorse-1-0 (720P, 1080P), grok-imagine-1-5 (480p, 720p, 1080p).",
};

var videoModeOption = new Option<string?>("--mode")
{
    Description = "seedance2-5 video-to-video mode: reference or extend.",
};

var videoOutputFormatOption = new Option<string?>("--output-format")
{
    Description = "Delivery format for gen4.5 and aleph2: mp4, prores, png_sequence, sdr_rec709_10bit, and (gen4.5) hdr10, hlg, hdr_pq_12bit_master, hdr_prores, hdr_png_sequence, hdr_exr_sequence.",
};

var videoProresProfileOption = new Option<string?>("--prores-profile")
{
    Description = "ProRes tier when --output-format selects a ProRes mezzanine: 422, 422 Proxy, 422 LT, 422 HQ, 4444, 4444 XQ.",
};

var videoTargetAspectRatioOption = new Option<string?>("--target-aspect-ratio")
{
    Description = "aleph2 reframing target: 16:9, 4:3, 3:2, 1:1, 2:3, 3:4, 9:16, or 21:9. Replaces the deprecated --ratio on video-to-video.",
};

RunwayCliVideoExtras BuildVideoExtras(ParseResult parseResult) => new()
{
    ReferenceImages = parseResult.GetValue(videoReferenceImageOption),
    ReferenceVideos = parseResult.GetValue(videoReferenceVideoOption),
    ReferenceAudio = parseResult.GetValue(videoReferenceAudioOption),
    Keyframes = parseResult.GetValue(videoKeyframeOption),
    NegativePrompt = parseResult.GetValue(videoNegativePromptOption),
    Resolution = parseResult.GetValue(videoResolutionOption),
    Mode = parseResult.GetValue(videoModeOption),
    OutputFormat = parseResult.GetValue(videoOutputFormatOption),
    ProresProfile = parseResult.GetValue(videoProresProfileOption),
    TargetAspectRatio = parseResult.GetValue(videoTargetAspectRatioOption),
};

var generationDurationOption = new Option<double?>("--duration")
{
    Description = "Optional video duration in seconds.",
};

var seedOption = new Option<int?>("--seed")
{
    Description = "Optional seed for repeatable generations.",
};

var promptImageOption = new Option<string[]>("--image", ["-i"])
{
    Description = "Optional local path, HTTPS URL, Runway URI, or data URI image. Repeat to pass first/last frames when the model supports it.",
    Arity = ArgumentArity.ZeroOrMore,
};

var lastImageOption = new Option<string?>("--last-image")
{
    Description = "Optional last-frame image for supported image-to-video models.",
};

var referenceImageOption2 = new Option<string[]>("--reference-image")
{
    Description = "Optional local path, HTTPS URL, Runway URI, or data URI image reference. Repeat up to three times.",
    Arity = ArgumentArity.ZeroOrMore,
};

var referenceSubjectOption = new Option<string>("--reference-subject")
{
    Description = "Reference subject for gemini-image3-pro: object or human.",
    DefaultValueFactory = _ => "object",
};

var outputCountOption = new Option<double?>("--output-count")
{
    Description = "Number of outputs for models that support it.",
};

var publicFigureThresholdOption = new Option<string?>("--public-figure-threshold")
{
    Description = "Content moderation public figure threshold: auto or low.",
};

var noAudioOption = new Option<bool>("--no-audio")
{
    Description = "Disable generated audio for supported video models.",
};

var noWaitOption = new Option<bool>("--no-wait")
{
    Description = "Submit the task and print the task ID without waiting or downloading outputs.",
};

var noDownloadOption = new Option<bool>("--no-download")
{
    Description = "Skip downloading workflow outputs after completion. URLs are still printed.",
};

var shortVideoShotCountOption = new Option<int>("--shots")
{
    Description = "Number of planned shots to generate. Supported range: 1-6.",
    DefaultValueFactory = _ => 3,
};

var shortVideoStyleOption = new Option<string?>("--style")
{
    Description = "Optional shared visual style applied to every planned shot.",
};

var shortVideoAudioOption = new Option<bool>("--audio")
{
    Description = "Enable per-shot generated audio when the selected model supports it.",
};

var shortVideoPlanOnlyOption = new Option<bool>("--plan-only")
{
    Description = "Only print the scenario, keyframes, and prompts; do not call the Runway API.",
};

var shortVideoNoInteractiveOption = new Option<bool>("--no-interactive")
{
    Description = "Skip the marketing-brief questionnaire. Defaults to interactive when stdin is a terminal; auto-skipped when stdin is redirected.",
};

var shortVideoKeyframesOption = new Option<string?>("--keyframes")
{
    Description = "Generate a high-quality keyframe still per shot via the chosen image model (gemini-image3-pro, gpt-image-2, gen4-image-turbo, ...) and animate it with image-to-video instead of pure text-to-video. Picks the closest supported aspect to --ratio for the image model and uses --model for the video pass.",
};

var shortVideoPlannerOption = new Option<string?>("--planner")
{
    Description = "Short-video scenario planner: auto, claude, codex, or deterministic. Defaults to RUNWAY_SHORT_VIDEO_PLANNER or auto.",
};

var shortVideoPlannerModelOption = new Option<string?>("--planner-model")
{
    Description = "External planner model. Defaults to RUNWAY_SHORT_VIDEO_PLANNER_MODEL, or opus for Claude.",
};

var shortVideoPlannerToolsOption = new Option<string?>("--planner-tools")
{
    Description = "External planner tool access: read-only or none. Defaults to RUNWAY_SHORT_VIDEO_PLANNER_TOOLS or read-only.",
};

var shortVideoPlannerTimeoutSecondsOption = new Option<int?>("--planner-timeout-seconds")
{
    Description = "External planner timeout in seconds. Defaults to RUNWAY_SHORT_VIDEO_PLANNER_TIMEOUT_SECONDS or 180.",
};

var shortVideoNoConcatOption = new Option<bool>("--no-concat")
{
    Description = "Leave downloaded shot segments separate instead of trying to concatenate them with ffmpeg.",
};

var shortVideoNameOption = new Option<string?>("--name")
{
    Description = "Optional run name used for the segment directory and final mp4 filename. Replaces the timestamp stem (e.g., \"v4\" produces runway-short-video-v4/runway-short-video-v4.mp4). Ignored when --output is an explicit file path.",
};

var shortVideoAutoNameOption = new Option<string?>("--auto-name", ["--name-prefix"])
{
    Description = "Auto-generate --name as <prefix><N+1> by scanning the resolved --output directory for existing runway-short-video-<prefix><N>.* siblings (e.g., \"v\" emits v4 if v3 already exists). Alias: --name-prefix. Mutually exclusive with --name.",
};

var creativeRecipeNameOption = new Option<string?>("--name")
{
    Description = "Optional run name injected into per-job filename stems (e.g., \"v4\" produces runway-{kind}-v4-01-{label}.{ext}). Useful for keeping iterative recipe runs (v2/v3/v4) separate in a shared --output directory.",
};

var creativeRecipeAutoNameOption = new Option<string?>("--auto-name", ["--name-prefix"])
{
    Description = "Auto-generate --name as <prefix><N+1> by scanning the resolved --output directory for existing runway-{kind}-<prefix><N>-* siblings. Alias: --name-prefix. Mutually exclusive with --name.",
};

var shortVideoPlanOption = new Option<string?>("--plan")
{
    Description = "Short-video plan JSON file, @path, inline JSON, or '-' for stdin.",
};

var recipePromptOption = new Option<string?>("--prompt")
{
    Description = "Product, offer, or scenario prompt used to build the recipe plan.",
};

var recipeCountOption = new Option<int?>("--count")
{
    Description = "Number of image prompt jobs to plan.",
};

var recipeRatioOption = new Option<string?>("--ratio")
{
    Description = "Generation ratio/resolution. Defaults are recipe-specific.",
};

var recipeModelOption = new Option<string?>("--model")
{
    Description = "Runway generation model. Defaults are recipe-specific.",
};

var recipePlanOnlyOption = new Option<bool>("--plan-only")
{
    Description = "Only print the generated recipe plan JSON; do not call the Runway API.",
};

var productPhotoshootModeOption = new Option<string?>("--mode")
{
    Description = "Product photoshoot mode: product_shot, lifestyle_scene, hero_banner, social_carousel, ad_creative_pack, virtual_model_tryout, conceptual_product, or restyle.",
};

var productContextOption = new Option<string?>("--product-context")
{
    Description = "Extra product details, materials, differentiators, or usage context.",
};

var brandContextOption = new Option<string?>("--brand-context")
{
    Description = "Brand tone, audience, colors, campaign direction, or constraints.",
};

var marketplaceScopeOption = new Option<string?>("--scope")
{
    Description = "Marketplace card scope: main, product-images, aplus, or full-set.",
};

var marketplaceAssetOption = new Option<string[]>("--asset")
{
    Description = "Optional local path, HTTPS URL, Runway URI, or data URI product/brand asset. Repeat to provide multiple assets.",
    Arity = ArgumentArity.ZeroOrMore,
};

var marketplaceCategoryOption = new Option<string?>("--category")
{
    Description = "Marketplace product category or shelf context.",
};

var marketplaceVisualStyleOption = new Option<string?>("--visual-style")
{
    Description = "Visual style for the marketplace prompt bundle.",
};

var adVideoModeOption = new Option<string?>("--mode")
{
    Description = "Ad-video mode: ugc, unboxing, product_showcase, product_review, tv_spot, or virtual_try_on.",
};

var adVideoShotCountOption = new Option<int?>("--shots")
{
    Description = "Number of ad-video shots to plan. Supported range: 1-6.",
};

var adVideoStyleOption = new Option<string?>("--style")
{
    Description = "Optional shared visual style applied to every ad-video shot.",
};

var adVideoAudioOption = new Option<bool>("--audio")
{
    Description = "Enable generated audio when the selected video model supports it.",
};

var ffmpegOption = new Option<string?>("--ffmpeg")
{
    Description = "Optional ffmpeg binary path used to concatenate downloaded short-video shot segments.",
};

var generatePromptArgument = new Argument<string[]>("prompt")
{
    Description = "Prompt forwarded to the underlying per-modality command.",
};

var soulIdReferenceOption = new Option<string?>("--soul-id")
{
    Description = "Local soul-id from `runway soul-id list`. Photos are auto-attached as reference images.",
};

var soulIdNameOption = new Option<string?>("--name")
{
    Description = "Friendly name for the soul-id entry.",
};

var soulIdImageOption = new Option<string[]>("--image")
{
    Description = "Reference photo path. Repeat 5 to 20 times.",
    AllowMultipleArgumentsPerToken = false,
};

var soulIdVariantOption = new Option<string?>("--variant")
{
    Description = "Soul-id variant: soul-2 (default) or soul-cinematic.",
};

var soulIdIdArgument = new Argument<string>("id")
{
    Description = "Soul-id identifier returned by `soul-id create` or `soul-id list`.",
};

var soulIdJsonFlag = new Option<bool>("--json")
{
    Description = "Emit JSON instead of the default tabular list output.",
};

var authApiKeyOption = new Option<string?>("--api-key")
{
    Description = "Runway API key to store. Read from RUNWAY_API_KEY if omitted.",
};

var generateKindOption = new Option<string?>("--kind")
{
    Description = "Generation kind: image, video, image-to-video, text-to-speech, sound-effect. Auto-detected from inputs when omitted.",
};

var modelSchemaIdArgument = new Argument<string>("model")
{
    Description = "Runway model id (e.g. gen4_turbo, veo3.1_fast, gpt_image_2).",
};

var webproductsUrlOption = new Option<string>("--url")
{
    Description = "Public URL of the product page to fetch.",
    Required = true,
};

var galleryInputOption = new Option<string?>("--input")
{
    Description = "Directory containing generated videos. Defaults to the current directory.",
};

var galleryOutputOption = new Option<string?>("--output", ["-o"])
{
    Description = "Gallery HTML output path. Defaults to runway-gallery.html in the input directory.",
};

var galleryRecursiveOption = new Option<bool>("--recursive")
{
    Description = "Include videos in nested directories.",
};

var galleryTitleOption = new Option<string?>("--title")
{
    Description = "Gallery page title.",
};

var galleryMetadataOption = new Option<string?>("--metadata")
{
    Description = "Path to a plan JSON (e.g. a runway-short-video plan) used to render enriched tiles with paired keyframes, model metadata, and copyable regen commands.",
};

var generateVideoCommand = new Command("video", "Generate a video locally from a text prompt.")
{
    videoPromptArgument,
    promptImageOption,
    lastImageOption,
    outputOption,
    videoRatioOption,
    videoModelOption,
    generationDurationOption,
    seedOption,
    noAudioOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(generateVideoCommand);
generateVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var prompt = RunwayCliGeneration.JoinPrompt(parseResult.GetValue(videoPromptArgument));
        var promptImages = parseResult.GetValue(promptImageOption);
        var lastImage = parseResult.GetValue(lastImageOption);
        var ratio = parseResult.GetValue(videoRatioOption) ?? "1280:720";
        var duration = parseResult.GetValue(generationDurationOption);
        var seed = parseResult.GetValue(seedOption);
        var model = parseResult.GetValue(videoModelOption);
        var publicFigureThreshold = parseResult.GetValue(publicFigureThresholdOption);
        var json = parseResult.GetValue(jsonOption);

        if (json is not { Length: > 0 })
        {
            var resolvedModel = model ?? string.Empty;
            if (promptImages is { Length: > 0 } || lastImage is { Length: > 0 })
            {
                RunwayModelSchema.EnsureModelSupportsEndpoint(resolvedModel, "image_to_video");
                RunwayCliGeneration.ValidateImageToVideoRatio(ratio, resolvedModel);
            }
            else
            {
                RunwayModelSchema.EnsureModelSupportsEndpoint(resolvedModel, "text_to_video");
                RunwayCliGeneration.ValidateTextToVideoRatio(ratio, resolvedModel);
            }
        }

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                if (json is { Length: > 0 })
                {
                    return await PostGenerationJsonAsync(
                        client,
                        runwayVersion,
                        "v1/text_to_video",
                        await RunwayCliGeneration.ReadJsonTextAsync(json, submitCt).ConfigureAwait(false),
                        submitCt).ConfigureAwait(false);
                }

                if (promptImages is { Length: > 0 } || lastImage is { Length: > 0 })
                {
                    var i2vRequest = await RunwayCliGeneration.CreateImageToVideoRequestAsync(
                        prompt,
                        model,
                        promptImages,
                        lastImage,
                        ratio,
                        duration,
                        seed,
                        !parseResult.GetValue(noAudioOption),
                        publicFigureThreshold,
                        BuildVideoExtras(parseResult),
                        submitCt).ConfigureAwait(false);
                    var i2vResponse = await client.StartGenerating.CreateImageToVideoAsync(
                        request: i2vRequest,
                        xRunwayVersion: runwayVersion,
                        cancellationToken: submitCt).ConfigureAwait(false);
                    return i2vResponse.Id;
                }

                var t2vRequest = await RunwayCliGeneration.CreateTextToVideoRequestAsync(
                    prompt,
                    model,
                    ratio,
                    duration,
                    seed,
                    !parseResult.GetValue(noAudioOption),
                    publicFigureThreshold,
                    BuildVideoExtras(parseResult),
                    submitCt).ConfigureAwait(false);
                var t2vResponse = await client.StartGenerating.CreateTextToVideoAsync(
                    request: t2vRequest,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return t2vResponse.Id;
            },
            parseResult,
            ".mp4",
            "runway-video",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var shortVideoCommand = new Command("short-video", "Expand a scenario into keyframe prompts and generate a multi-shot short video.")
{
    shortVideoPromptArgument,
    outputOption,
    shortVideoNameOption,
    shortVideoAutoNameOption,
    shortVideoRatioOption,
    videoModelOption,
    generationDurationOption,
    shortVideoShotCountOption,
    shortVideoStyleOption,
    shortVideoAudioOption,
    seedOption,
    videoReferenceImageOption,
    videoReferenceVideoOption,
    videoReferenceAudioOption,
    soulIdReferenceOption,
    publicFigureThresholdOption,
    shortVideoPlanOnlyOption,
    shortVideoNoInteractiveOption,
    shortVideoKeyframesOption,
    shortVideoPlannerOption,
    shortVideoPlannerModelOption,
    shortVideoPlannerToolsOption,
    shortVideoPlannerTimeoutSecondsOption,
    shortVideoNoConcatOption,
    ffmpegOption,
    noWaitOption,
    pollIntervalOption,
    recipeRetryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(shortVideoCommand);
shortVideoCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    var scenarioParts = parseResult.GetValue(shortVideoPromptArgument);
    if (scenarioParts is not { Length: > 0 })
    {
        Console.Error.WriteLine("Missing required argument scenario.");
        return 1;
    }

    RunwayShortVideoPlan plan;
    RunwayShortVideoOptions options;
    RunwayCliShortVideoOutput output;
    string plannerName;
    try
    {
        var scenario = RunwayCliGeneration.JoinPrompt(scenarioParts);
        var resolvedName = ResolveShortVideoName(parseResult);
        output = RunwayCliShortVideo.ResolveOutput(parseResult.GetValue(outputOption), DateTime.UtcNow, resolvedName);
        var brief = await ResolveMarketingBriefAsync(parseResult, cancellationToken).ConfigureAwait(false);
        options = await CreateShortVideoOptionsAsync(parseResult, output.SegmentDirectory, cancellationToken, brief).ConfigureAwait(false);
        var plannerOptions = CreateShortVideoPlannerOptions(parseResult);
        var plannerResult = await RunwayCliShortVideo.CreatePlanResultAsync(
            scenario,
            options,
            plannerOptions,
            brief,
            cancellationToken).ConfigureAwait(false);
        plan = plannerResult.Plan;
        plannerName = plannerResult.Planner;
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    RunwayCliConsole.WriteInfo($"Short-video planner: {plannerName}");

    if (parseResult.GetValue(shortVideoPlanOnlyOption))
    {
        Console.WriteLine(RunwayCliShortVideo.ToJson(plan));
        return 0;
    }

    return await RunShortVideoPlanAsync(parseResult, plan, options, output, cancellationToken).ConfigureAwait(false);
});

var shortVideoRunCommand = new Command("run", "Generate a short video from an edited short-video plan JSON.")
{
    shortVideoPlanOption,
    outputOption,
    shortVideoNameOption,
    shortVideoAutoNameOption,
    shortVideoRatioOption,
    videoModelOption,
    generationDurationOption,
    shortVideoAudioOption,
    seedOption,
    videoReferenceImageOption,
    videoReferenceVideoOption,
    videoReferenceAudioOption,
    soulIdReferenceOption,
    publicFigureThresholdOption,
    shortVideoKeyframesOption,
    shortVideoNoConcatOption,
    ffmpegOption,
    noWaitOption,
    pollIntervalOption,
    recipeRetryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
shortVideoCommand.Subcommands.Add(shortVideoRunCommand);
shortVideoRunCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    RunwayShortVideoPlan plan;
    try
    {
        plan = await RunwayCliShortVideo.ReadPlanAsync(
            RequireOption(parseResult, shortVideoPlanOption),
            cancellationToken).ConfigureAwait(false);
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    string? resolvedName;
    try
    {
        resolvedName = ResolveShortVideoName(parseResult);
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    var output = RunwayCliShortVideo.ResolveOutput(parseResult.GetValue(outputOption), DateTime.UtcNow, resolvedName);
    var options = await CreateShortVideoOptionsFromPlanAsync(parseResult, output.SegmentDirectory, plan, cancellationToken).ConfigureAwait(false);
    return await RunShortVideoPlanAsync(parseResult, plan, options, output, cancellationToken).ConfigureAwait(false);
});

var shortVideoDiffPlanAOption = new Argument<string>("plan-a")
{
    Description = "First short-video plan JSON file path. Pass '-' to read from stdin.",
};
var shortVideoDiffPlanBOption = new Argument<string>("plan-b")
{
    Description = "Second short-video plan JSON file path. Pass '-' to read from stdin (only one of plan-a / plan-b can be stdin).",
};
var shortVideoDiffJsonOption = new Option<bool>("--json")
{
    Description = "Emit machine-readable JSON instead of the default human-readable text.",
};
var shortVideoDiffCommand = new Command("diff", "Compare two short-video plan JSON files and print the per-field differences.")
{
    shortVideoDiffPlanAOption,
    shortVideoDiffPlanBOption,
    shortVideoDiffJsonOption,
};
shortVideoCommand.Subcommands.Add(shortVideoDiffCommand);
shortVideoDiffCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    RunwayShortVideoPlan planA;
    RunwayShortVideoPlan planB;
    try
    {
        planA = await RunwayCliShortVideo.ReadPlanAsync(
            parseResult.GetValue(shortVideoDiffPlanAOption) ?? throw new ArgumentException("Missing required argument plan-a."),
            cancellationToken).ConfigureAwait(false);
        planB = await RunwayCliShortVideo.ReadPlanAsync(
            parseResult.GetValue(shortVideoDiffPlanBOption) ?? throw new ArgumentException("Missing required argument plan-b."),
            cancellationToken).ConfigureAwait(false);
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    var diff = RunwayCliShortVideoDiff.Compute(planA, planB);
    var rendered = parseResult.GetValue(shortVideoDiffJsonOption)
        ? RunwayCliShortVideoDiff.RenderJson(diff)
        : RunwayCliShortVideoDiff.RenderText(diff);
    Console.Write(rendered);
    if (!rendered.EndsWith('\n'))
    {
        Console.WriteLine();
    }

    return 0;
});

var productPhotoshootCommand = new Command("product-photoshoot", "Plan and generate Runway-native product photoshoot image recipes.");
rootCommand.Subcommands.Add(productPhotoshootCommand);
var productPhotoshootCreateCommand = new Command("create", "Create product photoshoot prompts and optionally generate images.")
{
    recipePromptOption,
    promptImageOption,
    soulIdReferenceOption,
    recipeCountOption,
    recipeRatioOption,
    recipeModelOption,
    outputOption,
    creativeRecipeNameOption,
    creativeRecipeAutoNameOption,
    productPhotoshootModeOption,
    productContextOption,
    brandContextOption,
    imageQualityOption,
    imageResolutionOption,
    recipePlanOnlyOption,
    publicFigureThresholdOption,
    noWaitOption,
    pollIntervalOption,
    recipeRetryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
productPhotoshootCommand.Subcommands.Add(productPhotoshootCreateCommand);
productPhotoshootCreateCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    RunwayCliCreativeRecipePlan plan;
    string? recipeName;
    try
    {
        plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
            RequireOption(parseResult, recipePromptOption),
            MergeSoulIdImages(parseResult, parseResult.GetValue(promptImageOption)),
            parseResult.GetValue(recipeCountOption),
            parseResult.GetValue(recipeRatioOption),
            parseResult.GetValue(recipeModelOption),
            parseResult.GetValue(productPhotoshootModeOption),
            parseResult.GetValue(productContextOption),
            parseResult.GetValue(brandContextOption),
            parseResult.GetValue(imageQualityOption),
            parseResult.GetValue(imageResolutionOption));
        recipeName = ResolveCreativeRecipeName(parseResult, plan);
        RunwayModelSchema.EnsureModelSupportsEndpoint(plan.Model, "text_to_image");
        RunwayModelSchema.EnsureRequiredParametersProvided(plan.Model, "text_to_image", new Dictionary<string, bool>
        {
            ["promptText"] = !string.IsNullOrWhiteSpace(plan.SourcePrompt),
            ["ratio"] = !string.IsNullOrWhiteSpace(plan.Ratio),
            ["referenceImages"] = plan.ReferenceImages.Count > 0,
        });
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    if (parseResult.GetValue(recipePlanOnlyOption))
    {
        Console.WriteLine(RunwayCliCreativeRecipes.ToJson(plan));
        return 0;
    }

    return await RunCreativeImageRecipeAsync(parseResult, plan, recipeName, cancellationToken).ConfigureAwait(false);
});

var marketplaceCardsCommand = new Command("marketplace-cards", "Plan and generate Runway-native marketplace-style image prompt bundles.");
rootCommand.Subcommands.Add(marketplaceCardsCommand);
var marketplaceCardsCreateCommand = new Command("create", "Create marketplace-style image cards and optionally generate images.")
{
    recipePromptOption,
    marketplaceAssetOption,
    soulIdReferenceOption,
    recipeCountOption,
    recipeRatioOption,
    recipeModelOption,
    outputOption,
    creativeRecipeNameOption,
    creativeRecipeAutoNameOption,
    marketplaceScopeOption,
    marketplaceCategoryOption,
    marketplaceVisualStyleOption,
    recipePlanOnlyOption,
    publicFigureThresholdOption,
    noWaitOption,
    pollIntervalOption,
    recipeRetryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
marketplaceCardsCommand.Subcommands.Add(marketplaceCardsCreateCommand);
marketplaceCardsCreateCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    RunwayCliCreativeRecipePlan plan;
    string? recipeName;
    try
    {
        plan = RunwayCliCreativeRecipes.CreateMarketplaceCardsPlan(
            RequireOption(parseResult, recipePromptOption),
            MergeSoulIdImages(parseResult, parseResult.GetValue(marketplaceAssetOption)),
            parseResult.GetValue(recipeCountOption),
            parseResult.GetValue(recipeRatioOption),
            parseResult.GetValue(recipeModelOption),
            parseResult.GetValue(marketplaceScopeOption),
            parseResult.GetValue(marketplaceCategoryOption),
            parseResult.GetValue(marketplaceVisualStyleOption));
        recipeName = ResolveCreativeRecipeName(parseResult, plan);
        RunwayModelSchema.EnsureModelSupportsEndpoint(plan.Model, "text_to_image");
        RunwayModelSchema.EnsureRequiredParametersProvided(plan.Model, "text_to_image", new Dictionary<string, bool>
        {
            ["promptText"] = !string.IsNullOrWhiteSpace(plan.SourcePrompt),
            ["ratio"] = !string.IsNullOrWhiteSpace(plan.Ratio),
            ["referenceImages"] = plan.Assets.Count > 0,
        });
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    if (parseResult.GetValue(recipePlanOnlyOption))
    {
        Console.WriteLine(RunwayCliCreativeRecipes.ToJson(plan));
        return 0;
    }

    return await RunCreativeImageRecipeAsync(parseResult, plan, recipeName, cancellationToken).ConfigureAwait(false);
});

var adVideoCommand = new Command("ad-video", "Plan and generate Runway-native ad video recipes.");
rootCommand.Subcommands.Add(adVideoCommand);
var adVideoCreateCommand = new Command("create", "Create ad video shot prompts and optionally generate videos.")
{
    recipePromptOption,
    promptImageOption,
    soulIdReferenceOption,
    recipeRatioOption,
    recipeModelOption,
    outputOption,
    creativeRecipeNameOption,
    creativeRecipeAutoNameOption,
    adVideoModeOption,
    adVideoShotCountOption,
    adVideoStyleOption,
    adVideoAudioOption,
    generationDurationOption,
    recipePlanOnlyOption,
    seedOption,
    publicFigureThresholdOption,
    noWaitOption,
    pollIntervalOption,
    recipeRetryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
adVideoCommand.Subcommands.Add(adVideoCreateCommand);
adVideoCreateCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    RunwayCliCreativeRecipePlan plan;
    string? recipeName;
    try
    {
        plan = RunwayCliCreativeRecipes.CreateAdVideoPlan(
            RequireOption(parseResult, recipePromptOption),
            MergeSoulIdImages(parseResult, parseResult.GetValue(promptImageOption)),
            parseResult.GetValue(adVideoShotCountOption),
            parseResult.GetValue(recipeRatioOption),
            parseResult.GetValue(recipeModelOption),
            parseResult.GetValue(adVideoModeOption),
            parseResult.GetValue(adVideoStyleOption),
            parseResult.GetValue(adVideoAudioOption),
            parseResult.GetValue(generationDurationOption));
        recipeName = ResolveCreativeRecipeName(parseResult, plan);
        var adVideoEndpoint = plan.ReferenceImages.Count > 0 ? "image_to_video" : "text_to_video";
        RunwayModelSchema.EnsureModelSupportsEndpoint(plan.Model, adVideoEndpoint);
        RunwayModelSchema.EnsureRequiredParametersProvided(plan.Model, adVideoEndpoint, new Dictionary<string, bool>
        {
            ["promptText"] = plan.Jobs.Count > 0 && !string.IsNullOrWhiteSpace(plan.Jobs[0].Prompt),
            ["promptImage"] = plan.ReferenceImages.Count > 0,
            ["ratio"] = !string.IsNullOrWhiteSpace(plan.Ratio),
            ["duration"] = plan.DurationSeconds.HasValue,
        });
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }

    if (parseResult.GetValue(recipePlanOnlyOption))
    {
        Console.WriteLine(RunwayCliCreativeRecipes.ToJson(plan));
        return 0;
    }

    return await RunCreativeVideoRecipeAsync(parseResult, plan, recipeName, cancellationToken).ConfigureAwait(false);
});

var generateImageCommand = new Command("image", "Generate an image locally from a text prompt.")
{
    imagePromptArgument,
    outputOption,
    imageRatioOption,
    imageModelOption,
    imageResolutionOption,
    imageQualityOption,
    imageOutputFormatOption,
    imageBackgroundOption,
    imageGroundingOption,
    imageEditOption,
    seedOption,
    referenceImageOption2,
    referenceSubjectOption,
    soulIdReferenceOption,
    outputCountOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(generateImageCommand);
generateImageCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var prompt = RunwayCliGeneration.JoinPrompt(parseResult.GetValue(imagePromptArgument));
        var imageModel = parseResult.GetValue(imageModelOption) ?? "gemini-2.5-flash";
        var normalizedImageModel = RunwayCliGeneration.NormalizeTextToImageModel(imageModel);
        RunwayModelSchema.EnsureModelSupportsEndpoint(normalizedImageModel, "text_to_image");
        var ratio = RunwayCliGeneration.ResolveTextToImageRatio(
            parseResult.GetValue(imageRatioOption),
            normalizedImageModel);
        var referenceImages = MergeSoulIdImages(parseResult, parseResult.GetValue(referenceImageOption2));
        RunwayModelSchema.EnsureRequiredParametersProvided(normalizedImageModel, "text_to_image", new Dictionary<string, bool>
        {
            ["promptText"] = !string.IsNullOrWhiteSpace(prompt),
            ["ratio"] = !string.IsNullOrWhiteSpace(ratio),
            ["referenceImages"] = referenceImages is { Length: > 0 },
        });
        RunwayCliGeneration.EnsureImageExtrasSupported(normalizedImageModel, BuildImageExtras(parseResult));
        var seed = parseResult.GetValue(seedOption);
        var json = parseResult.GetValue(jsonOption);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                if (json is { Length: > 0 })
                {
                    return await PostGenerationJsonAsync(
                        client,
                        runwayVersion,
                        "v1/text_to_image",
                        await RunwayCliGeneration.ReadJsonTextAsync(json, submitCt).ConfigureAwait(false),
                        submitCt).ConfigureAwait(false);
                }

                if (normalizedImageModel == "gpt_image_2")
                {
                    var gptResponse = await client.StartGenerating.CreateGptImage2TextToImageAsync(
                        request: await RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
                            prompt,
                            ratio,
                            referenceImages,
                            parseResult.GetValue(imageResolutionOption),
                            parseResult.GetValue(imageQualityOption),
                            parseResult.GetValue(outputCountOption),
                            submitCt).ConfigureAwait(false),
                        xRunwayVersion: runwayVersion,
                        cancellationToken: submitCt).ConfigureAwait(false);
                    return gptResponse.Id;
                }

                var t2iResponse = await client.StartGenerating.CreateTextToImageAsync(
                    request: await RunwayCliGeneration.CreateTextToImageRequestAsync(
                        prompt,
                        imageModel,
                        ratio,
                        referenceImages,
                        parseResult.GetValue(referenceSubjectOption) ?? "object",
                        seed,
                        parseResult.GetValue(outputCountOption),
                        parseResult.GetValue(publicFigureThresholdOption),
                        BuildImageExtras(parseResult),
                        submitCt).ConfigureAwait(false),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return t2iResponse.Id;
            },
            parseResult,
            ".png",
            "runway-image",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var textToVideoCommand = new Command("text-to-video", "Start a text-to-video generation task.")
{
    textToVideoPromptArgument,
    outputOption,
    videoRatioOption,
    videoModelOption,
    generationDurationOption,
    seedOption,
    noAudioOption,
    videoReferenceImageOption,
    videoReferenceVideoOption,
    videoReferenceAudioOption,
    videoNegativePromptOption,
    videoResolutionOption,
    videoOutputFormatOption,
    videoProresProfileOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(textToVideoCommand);
textToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        if (json is not { Length: > 0 })
        {
            var t2vModel = RunwayCliGeneration.NormalizeVideoModel(
                parseResult.GetValue(videoModelOption),
                RunwayCliGeneration.DefaultTextToVideoModel,
                RunwayCliGeneration.TextToVideoEndpoint);
            var t2vRatio = parseResult.GetValue(videoRatioOption) ?? "1280:720";
            RunwayModelSchema.EnsureModelSupportsEndpoint(t2vModel, "text_to_video");
            RunwayCliGeneration.ValidateTextToVideoRatio(t2vRatio, t2vModel);
            RunwayModelSchema.EnsureRequiredParametersProvided(t2vModel, "text_to_video", new Dictionary<string, bool>
            {
                ["promptText"] = !string.IsNullOrWhiteSpace(RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToVideoPromptArgument))),
                ["ratio"] = true,
                ["duration"] = parseResult.GetValue(generationDurationOption).HasValue,
            });
        }

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt => json is { Length: > 0 }
                ? await PostGenerationJsonAsync(client, runwayVersion, "v1/text_to_video", await RunwayCliGeneration.ReadJsonTextAsync(json, submitCt).ConfigureAwait(false), submitCt).ConfigureAwait(false)
                : (await client.StartGenerating.CreateTextToVideoAsync(
                    request: await RunwayCliGeneration.CreateTextToVideoRequestAsync(
                        RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToVideoPromptArgument)),
                        parseResult.GetValue(videoModelOption),
                        parseResult.GetValue(videoRatioOption) ?? "1280:720",
                        parseResult.GetValue(generationDurationOption),
                        parseResult.GetValue(seedOption),
                        !parseResult.GetValue(noAudioOption),
                        parseResult.GetValue(publicFigureThresholdOption),
                        BuildVideoExtras(parseResult),
                        submitCt).ConfigureAwait(false),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false)).Id,
            parseResult,
            ".mp4",
            "runway-video",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var optionalVideoPromptArgument = new Argument<string[]>("prompt")
{
    Description = "Optional prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.ZeroOrMore,
};

var imageToVideoCommand = new Command("image-to-video", "Start an image-to-video generation task.")
{
    optionalVideoPromptArgument,
    promptImageOption,
    lastImageOption,
    soulIdReferenceOption,
    outputOption,
    videoRatioOption,
    videoModelOption,
    generationDurationOption,
    seedOption,
    noAudioOption,
    videoReferenceVideoOption,
    videoReferenceAudioOption,
    videoNegativePromptOption,
    videoResolutionOption,
    videoOutputFormatOption,
    videoProresProfileOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(imageToVideoCommand);
imageToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        if (json is not { Length: > 0 })
        {
            var i2vModel = RunwayCliGeneration.NormalizeVideoModel(
                parseResult.GetValue(videoModelOption),
                RunwayCliGeneration.DefaultImageToVideoModel,
                RunwayCliGeneration.ImageToVideoEndpoint);
            var i2vPrompt = string.Join(' ', parseResult.GetValue(optionalVideoPromptArgument) ?? []).Trim();
            var i2vImages = MergeSoulIdImages(parseResult, parseResult.GetValue(promptImageOption));
            var i2vRatio = parseResult.GetValue(videoRatioOption) ?? "1280:720";
            RunwayModelSchema.EnsureModelSupportsEndpoint(i2vModel, "image_to_video");
            RunwayCliGeneration.ValidateImageToVideoRatio(i2vRatio, i2vModel);
            RunwayModelSchema.EnsureRequiredParametersProvided(i2vModel, "image_to_video", new Dictionary<string, bool>
            {
                ["promptText"] = !string.IsNullOrWhiteSpace(i2vPrompt),
                ["promptImage"] = i2vImages is { Length: > 0 },
                ["ratio"] = true,
                ["duration"] = parseResult.GetValue(generationDurationOption).HasValue,
            });
        }

        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateImageToVideoRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateImageToVideoRequestAsync(
                string.Join(' ', parseResult.GetValue(optionalVideoPromptArgument) ?? []).Trim(),
                parseResult.GetValue(videoModelOption),
                MergeSoulIdImages(parseResult, parseResult.GetValue(promptImageOption)),
                parseResult.GetValue(lastImageOption),
                parseResult.GetValue(videoRatioOption) ?? "1280:720",
                parseResult.GetValue(generationDurationOption),
                parseResult.GetValue(seedOption),
                !parseResult.GetValue(noAudioOption),
                parseResult.GetValue(publicFigureThresholdOption),
                BuildVideoExtras(parseResult),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateImageToVideoAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp4",
            "runway-video",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var sourceVideoOption = new Option<string?>("--video")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI video input.",
};

var videoToVideoCommand = new Command("video-to-video", "Start a video-to-video generation task (aleph2 restyle, or the seedance/hailuo/gemini reference models).")
{
    videoToVideoPromptArgument,
    sourceVideoOption,
    videoModelOption,
    videoReferenceImageOption,
    videoReferenceVideoOption,
    videoReferenceAudioOption,
    videoKeyframeOption,
    outputOption,
    videoRatioOption,
    videoTargetAspectRatioOption,
    videoResolutionOption,
    videoModeOption,
    videoOutputFormatOption,
    videoProresProfileOption,
    generationDurationOption,
    seedOption,
    noAudioOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(videoToVideoCommand);
videoToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVideoToVideoRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
                string.Join(' ', parseResult.GetValue(videoToVideoPromptArgument) ?? []).Trim(),
                parseResult.GetValue(videoModelOption),
                RequireOption(parseResult, sourceVideoOption),
                parseResult.GetValue(videoRatioOption),
                parseResult.GetValue(generationDurationOption),
                parseResult.GetValue(seedOption),
                !parseResult.GetValue(noAudioOption),
                parseResult.GetValue(publicFigureThresholdOption),
                BuildVideoExtras(parseResult),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateVideoToVideoAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp4",
            "runway-video",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var upscaleResolutionOption = new Option<string?>("--resolution")
{
    Description = "Target output resolution for magnific-video-upscaler-creative: 720p, 1k, 2k (default), or 4k.",
};

var upscaleTargetFramerateOption = new Option<string?>("--target-framerate")
{
    Description = "Target frames per second for enhance-frame-rate: 24, 25, 30, 48, 50, 60, 120, or the NTSC rates 23_98, 29_97, 59_94.",
};

var upscaleCreativityOption = new Option<int?>("--creativity")
{
    Description = "How much AI-generated detail to add, 0 (faithful) to 100 (magnific-video-upscaler-creative).",
};

var upscaleSharpenOption = new Option<int?>("--sharpen")
{
    Description = "Sharpness intensity, 0 to 100.",
};

var upscaleSmartGrainOption = new Option<int?>("--smart-grain")
{
    Description = "Grain and texture enhancement, 0 to 100.",
};

var upscaleUltraDetailOption = new Option<int?>("--ultra-detail")
{
    Description = "Fine detail enhancement, 0 to 100 (image upscale).",
};

var upscaleFlavorOption = new Option<string?>("--flavor")
{
    Description = "Processing style. Video: vivid or natural. Image: sublime, photo, or photo_denoiser.",
};

var upscaleFpsBoostOption = new Option<bool?>("--fps-boost")
{
    Description = "Increase the output frame rate (magnific-video-upscaler-creative).",
};

var upscaleScaleFactorOption = new Option<double?>("--scale-factor")
{
    Description = "Multiplies each input dimension on image upscale: 2, 4, 8, or 16.",
};

var videoUpscaleCommand = new Command("video-upscale", "Upscale a video, or interpolate it to a higher frame rate.")
{
    sourceVideoOption,
    videoModelOption,
    upscaleResolutionOption,
    upscaleTargetFramerateOption,
    upscaleCreativityOption,
    upscaleSharpenOption,
    upscaleSmartGrainOption,
    upscaleFlavorOption,
    upscaleFpsBoostOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(videoUpscaleCommand);
videoUpscaleCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVideoUpscaleRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateVideoUpscaleRequestAsync(
                RequireOption(parseResult, sourceVideoOption),
                parseResult.GetValue(videoModelOption),
                parseResult.GetValue(upscaleResolutionOption),
                parseResult.GetValue(upscaleTargetFramerateOption),
                parseResult.GetValue(upscaleCreativityOption),
                parseResult.GetValue(upscaleSharpenOption),
                parseResult.GetValue(upscaleSmartGrainOption),
                parseResult.GetValue(upscaleFlavorOption),
                parseResult.GetValue(upscaleFpsBoostOption),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt => (await client.StartGenerating.CreateVideoUpscaleAsync(
                request: request,
                xRunwayVersion: runwayVersion,
                cancellationToken: submitCt).ConfigureAwait(false)).Id,
            parseResult,
            ".mp4",
            "runway-video-upscale",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var upscaleImageOption = new Option<string?>("--image")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI image to upscale.",
};

var imageUpscaleCommand = new Command("image-upscale", "Upscale an image with the magnific precision upscaler.")
{
    upscaleImageOption,
    videoModelOption,
    upscaleScaleFactorOption,
    upscaleSharpenOption,
    upscaleSmartGrainOption,
    upscaleUltraDetailOption,
    upscaleFlavorOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(imageUpscaleCommand);
imageUpscaleCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateImageUpscaleRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateImageUpscaleRequestAsync(
                RequireOption(parseResult, upscaleImageOption),
                parseResult.GetValue(videoModelOption),
                parseResult.GetValue(upscaleScaleFactorOption),
                parseResult.GetValue(upscaleSharpenOption),
                parseResult.GetValue(upscaleSmartGrainOption),
                parseResult.GetValue(upscaleUltraDetailOption),
                parseResult.GetValue(upscaleFlavorOption),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt => (await client.StartGenerating.CreateImageUpscaleAsync(
                request: request,
                xRunwayVersion: runwayVersion,
                cancellationToken: submitCt).ConfigureAwait(false)).Id,
            parseResult,
            ".png",
            "runway-image-upscale",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var characterImageOption = new Option<string?>("--character-image")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI character image.",
};

var characterVideoOption = new Option<string?>("--character-video")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI character video.",
};

var referenceVideoOption = new Option<string?>("--reference-video")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI reference performance video.",
};

var bodyControlOption = new Option<bool?>("--body-control")
{
    Description = "Whether act_two should use body control.",
};

var expressionIntensityOption = new Option<int?>("--expression-intensity")
{
    Description = "Act_two expression intensity.",
};

var characterPerformanceCommand = new Command("character-performance", "Start an act_two character performance task.")
{
    characterImageOption,
    characterVideoOption,
    referenceVideoOption,
    videoModelOption,
    outputOption,
    videoRatioOption,
    seedOption,
    bodyControlOption,
    expressionIntensityOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(characterPerformanceCommand);
characterPerformanceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("act_two", "character_performance");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateCharacterPerformanceRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateCharacterPerformanceRequestAsync(
                parseResult.GetValue(characterImageOption),
                parseResult.GetValue(characterVideoOption),
                RequireOption(parseResult, referenceVideoOption),
                parseResult.GetValue(videoModelOption),
                parseResult.GetValue(videoRatioOption),
                parseResult.GetValue(seedOption),
                parseResult.GetValue(bodyControlOption),
                parseResult.GetValue(expressionIntensityOption),
                parseResult.GetValue(publicFigureThresholdOption),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateCharacterPerformanceAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp4",
            "runway-video",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var loopOption = new Option<bool>("--loop")
{
    Description = "Loop the generated sound effect.",
};

var audioModelOption = new Option<string?>("--model")
{
    Description = "Audio model, validated against the embedded OpenAPI spec. text-to-speech: eleven_multilingual_v2 (default), eleven_v3, seed_audio. sound-effect: eleven_text_to_sound_v2 (default), seed_audio.",
};

var audioReferenceOption = new Option<string[]>("--reference-audio")
{
    Description = "Reference audio clip. For seed_audio sound effects, repeat up to three times and address them in the prompt as @Audio1, @Audio2, @Audio3. For seed_audio text-to-speech, a single clip is cloned as the voice.",
    Arity = ArgumentArity.ZeroOrMore,
};

var audioOutputFormatOption = new Option<string?>("--output-format")
{
    Description = "Output container for seed_audio: wav, mp3, or ogg_opus.",
};

var audioSampleRateOption = new Option<int?>("--sample-rate")
{
    Description = "Output sample rate in Hz for seed_audio: 8000, 16000, 24000, 32000, 44100, or 48000.",
};

var audioSpeechRateOption = new Option<int?>("--speech-rate")
{
    Description = "Speech rate for seed_audio, -50 to 100.",
};

var audioPitchRateOption = new Option<int?>("--pitch-rate")
{
    Description = "Pitch shift for seed_audio, -12 to 12 semitones.",
};

var audioLoudnessRateOption = new Option<int?>("--loudness-rate")
{
    Description = "Loudness adjustment for seed_audio, -50 to 100.",
};

var audioStabilityOption = new Option<double?>("--stability")
{
    Description = "Voice stability for eleven_v3, 0 to 1.",
};

var audioStyleOption = new Option<double?>("--style")
{
    Description = "Style exaggeration for eleven_v3, 0 to 1.",
};

var audioSpeedOption = new Option<double?>("--speed")
{
    Description = "Speaking speed for eleven_v3, 0.7 to 1.2.",
};

var audioSimilarityBoostOption = new Option<double?>("--similarity-boost")
{
    Description = "Similarity to the reference voice for eleven_v3, 0 to 1.",
};

var audioLanguageCodeOption = new Option<string?>("--language-code")
{
    Description = "BCP-47 language code for eleven_v3, for example ru or en-US.",
};

var audioTextNormalizationOption = new Option<string?>("--apply-text-normalization")
{
    Description = "Text normalization for eleven_v3: auto, on, or off.",
};

var audioSpeakerBoostOption = new Option<bool?>("--use-speaker-boost")
{
    Description = "Speaker boost for eleven_v3.",
};

var audioNumSpeakersOption = new Option<int?>("--num-speakers")
{
    Description = "Speaker count hint for voice dubbing.",
};

var audioDisableVoiceCloningOption = new Option<bool?>("--disable-voice-cloning")
{
    Description = "Keep the original speakers' voices instead of cloning them when dubbing.",
};

var audioDropBackgroundOption = new Option<bool?>("--drop-background-audio")
{
    Description = "Drop the background audio bed when dubbing.",
};

RunwayCliAudioExtras BuildAudioExtras(ParseResult parseResult) => new()
{
    ReferenceAudios = parseResult.GetValue(audioReferenceOption),
    OutputFormat = parseResult.GetValue(audioOutputFormatOption),
    LanguageCode = parseResult.GetValue(audioLanguageCodeOption),
    ApplyTextNormalization = parseResult.GetValue(audioTextNormalizationOption),
    SampleRate = parseResult.GetValue(audioSampleRateOption),
    SpeechRate = parseResult.GetValue(audioSpeechRateOption),
    PitchRate = parseResult.GetValue(audioPitchRateOption),
    LoudnessRate = parseResult.GetValue(audioLoudnessRateOption),
    NumSpeakers = parseResult.GetValue(audioNumSpeakersOption),
    Seed = parseResult.GetValue(seedOption),
    Stability = parseResult.GetValue(audioStabilityOption),
    Style = parseResult.GetValue(audioStyleOption),
    Speed = parseResult.GetValue(audioSpeedOption),
    SimilarityBoost = parseResult.GetValue(audioSimilarityBoostOption),
    UseSpeakerBoost = parseResult.GetValue(audioSpeakerBoostOption),
    DisableVoiceCloning = parseResult.GetValue(audioDisableVoiceCloningOption),
    DropBackgroundAudio = parseResult.GetValue(audioDropBackgroundOption),
};

var soundEffectCommand = new Command("sound-effect", "Generate a sound effect (eleven_text_to_sound_v2, or seed_audio with reference clips).")
{
    soundEffectPromptArgument,
    outputOption,
    audioModelOption,
    generationDurationOption,
    loopOption,
    audioReferenceOption,
    audioOutputFormatOption,
    audioSampleRateOption,
    audioSpeechRateOption,
    audioPitchRateOption,
    audioLoudnessRateOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(soundEffectCommand);
soundEffectCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateSoundEffectRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateSoundEffectRequestAsync(
                RunwayCliGeneration.JoinPrompt(parseResult.GetValue(soundEffectPromptArgument)),
                parseResult.GetValue(audioModelOption),
                parseResult.GetValue(generationDurationOption),
                parseResult.GetValue(loopOption),
                BuildAudioExtras(parseResult),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateSoundEffectAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp3",
            "runway-audio",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var mediaOption = new Option<string?>("--media")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI media input.",
};

var mediaTypeOption = new Option<string>("--media-type")
{
    Description = "Media type: audio or video.",
    DefaultValueFactory = _ => "audio",
};

var runwayVoiceIdOption = new Option<string?>("--runway-voice-id")
{
    Description = "Optional Runway voice ID.",
};

var speechVoicePresetOption = new Option<string?>("--voice-preset")
{
    Description = "Runway preset voice ID, validated against the embedded spec. These are proper names (Maya, Arjun, Serene, Claudia, ...); run `runway voice presets` for the full list. Defaults to the first id the spec lists.",
};

var removeBackgroundNoiseOption = new Option<bool?>("--remove-background-noise")
{
    Description = "Whether to remove background noise before speech-to-speech conversion.",
};

var speechToSpeechCommand = new Command("speech-to-speech", "Start an eleven_multilingual_sts_v2 speech-to-speech task.")
{
    mediaOption,
    mediaTypeOption,
    speechVoicePresetOption,
    runwayVoiceIdOption,
    removeBackgroundNoiseOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(speechToSpeechCommand);
speechToSpeechCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("eleven_multilingual_sts_v2", "speech_to_speech");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateSpeechToSpeechRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateSpeechToSpeechRequestAsync(
                RequireOption(parseResult, mediaOption),
                parseResult.GetValue(mediaTypeOption) ?? "audio",
                parseResult.GetValue(speechVoicePresetOption),
                parseResult.GetValue(runwayVoiceIdOption),
                parseResult.GetValue(removeBackgroundNoiseOption),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateSpeechToSpeechAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp3",
            "runway-speech",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var textToSpeechCommand = new Command("text-to-speech", "Synthesize speech (eleven_multilingual_v2, eleven_v3, or seed_audio voice cloning).")
{
    textToSpeechPromptArgument,
    speechVoicePresetOption,
    outputOption,
    audioModelOption,
    audioReferenceOption,
    audioStabilityOption,
    audioStyleOption,
    audioSpeedOption,
    audioSimilarityBoostOption,
    audioLanguageCodeOption,
    audioTextNormalizationOption,
    audioSpeakerBoostOption,
    audioOutputFormatOption,
    audioSampleRateOption,
    audioSpeechRateOption,
    audioPitchRateOption,
    audioLoudnessRateOption,
    seedOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(textToSpeechCommand);
textToSpeechCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateTextToSpeechRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateTextToSpeechRequestAsync(
                RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToSpeechPromptArgument)),
                parseResult.GetValue(audioModelOption),
                parseResult.GetValue(speechVoicePresetOption),
                parseResult.GetValue(audioReferenceOption) is { Length: > 0 } ttsReference ? ttsReference[0] : null,
                // On text-to-speech, --reference-audio is the cloned voice (handled above), not the
                // `referenceAudios` array that seed_audio takes on the sound-effect endpoint.
                BuildAudioExtras(parseResult) with { ReferenceAudios = null },
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateTextToSpeechAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp3",
            "runway-speech",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var audioOption = new Option<string?>("--audio")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI audio input.",
};

var targetLanguageOption = new Option<string?>("--target-language")
{
    Description = "Target language code for voice dubbing.",
};

var voiceDubbingCommand = new Command("voice-dubbing", "Start an eleven_voice_dubbing task.")
{
    audioOption,
    targetLanguageOption,
    outputOption,
    audioNumSpeakersOption,
    audioDisableVoiceCloningOption,
    audioDropBackgroundOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(voiceDubbingCommand);
voiceDubbingCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("eleven_voice_dubbing", "voice_dubbing");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVoiceDubbingRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateVoiceDubbingRequestAsync(
                RequireOption(parseResult, audioOption),
                RequireOption(parseResult, targetLanguageOption),
                BuildAudioExtras(parseResult),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateVoiceDubbingAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp3",
            "runway-dubbing",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var voiceIsolationCommand = new Command("voice-isolation", "Start an eleven_voice_isolation task.")
{
    audioOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
    retryOnInternalErrorOption,
    retryBackoffSecondsOption,
};
rootCommand.Subcommands.Add(voiceIsolationCommand);
voiceIsolationCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("eleven_voice_isolation", "voice_isolation");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVoiceIsolationRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateVoiceIsolationRequestAsync(
                RequireOption(parseResult, audioOption),
                ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(
            client,
            runwayVersion,
            async submitCt =>
            {
                var response = await client.StartGenerating.CreateVoiceIsolationAsync(
                    request: request,
                    xRunwayVersion: runwayVersion,
                    cancellationToken: submitCt).ConfigureAwait(false);
                return response.Id;
            },
            parseResult,
            ".mp3",
            "runway-voice",
            ct).ConfigureAwait(false);
    }, cancellationToken));

var modelsJsonOption = new Option<bool>("--json")
{
    Description = "With --account, print the spec/account difference as JSON instead of prose, for scripting and CI checks.",
};

var modelsAccountOption = new Option<bool>("--account")
{
    Description = "Also call the Runway API and report models your account is entitled to that the embedded OpenAPI spec does not describe yet (and vice versa). Requires an API key; costs no credits.",
};

var modelsCommand = new Command("models", "List the model IDs each endpoint accepts, read from the embedded OpenAPI spec.")
{
    modelsAccountOption,
    modelsJsonOption,
};
rootCommand.Subcommands.Add(modelsCommand);
modelsCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
{
    var modelsAsJson = parseResult.GetValue(modelsJsonOption);
    if (modelsAsJson && !parseResult.GetValue(modelsAccountOption))
    {
        // The offline listing is prose by design; only the account comparison has a JSON shape.
        // Exit 2 like every other usage error, so CI can tell it apart from an API failure.
        Console.Error.WriteLine("--json applies to the account comparison; pass --account as well.");
        return Task.FromResult(2);
    }

    if (modelsAsJson)
    {
        return WriteModelGapJsonAsync(parseResult, cancellationToken);
    }

    // Endpoint families are grouped for readability, but the model lists themselves come from the spec,
    // so this never drifts from what the SDK can actually send.
    var groups = new (string Title, string[] Endpoints)[]
    {
        ("Video generation", ["text_to_video", "image_to_video", "video_to_video", "character_performance"]),
        ("Video post-processing", ["video_upscale", "video_to_hdr"]),
        ("Image generation", ["text_to_image", "image_upscale"]),
        ("Audio and voice", ["sound_effect", "text_to_speech", "speech_to_speech", "voice_dubbing", "voice_isolation"]),
        ("Avatars", ["avatar_videos"]),
    };

    var listed = new HashSet<string>(StringComparer.Ordinal);
    foreach (var (title, endpoints) in groups)
    {
        var rendered = new List<string>();
        foreach (var endpoint in endpoints)
        {
            var models = RunwayModelSchema.ModelsForEndpoint(endpoint);
            if (models.Count == 0)
            {
                continue;
            }

            foreach (var model in models)
            {
                listed.Add(model);
            }

            rendered.Add($"  {endpoint.Replace('_', '-')}: {string.Join(", ", models)}");
        }

        if (rendered.Count > 0)
        {
            Console.WriteLine($"{title}:");
            rendered.ForEach(Console.WriteLine);
            Console.WriteLine();
        }
    }

    var ungrouped = RunwayModelSchema.KnownModelIds()
        .Where(model => !listed.Contains(model))
        .OrderBy(model => model, StringComparer.Ordinal)
        .ToList();
    if (ungrouped.Count > 0)
    {
        Console.WriteLine("Other endpoints:");
        foreach (var model in ungrouped)
        {
            var endpoints = RunwayModelSchema.Lookup(model).Select(e => e.Endpoint).Distinct(StringComparer.Ordinal);
            Console.WriteLine($"  {model}: {string.Join(", ", endpoints)}");
        }

        Console.WriteLine();
    }

    // Orchestration commands are not spec endpoints, but they are the surface most users reach for, so
    // name the endpoint each one drives rather than leaving them undiscoverable here.
    Console.WriteLine("CLI orchestration (not spec endpoints):");
    Console.WriteLine("  short-video: multi-shot planner over text-to-video, or image-to-video with --keyframes");
    Console.WriteLine("  product-photoshoot, marketplace-cards: recipe planners over text-to-image");
    Console.WriteLine("  ad-video: recipe planner over text-to-video, or image-to-video with --image");
    Console.WriteLine("  built-ins, workflow: published Runway workflow graphs");
    Console.WriteLine();
    Console.WriteLine("Run `runway models schema <model>` for the per-endpoint parameter list.");

    if (!parseResult.GetValue(modelsAccountOption))
    {
        return Task.FromResult(0);
    }

    return RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var report = await BuildModelGapReportAsync(client, runwayVersion, ct).ConfigureAwait(false);
        var missingFromSpec = report.MissingFromSpec;
        var asEndpoints = report.EndpointCapabilities;
        var missingFromAccount = report.MissingFromAccount;

        Console.WriteLine();
        Console.WriteLine($"Account entitlements: {report.AccountModelCount} models. Embedded spec: {report.SpecModelCount} models.");

        if (missingFromSpec.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"In your account but not in the embedded spec ({missingFromSpec.Count}) — not reachable through the typed SDK until the spec catches up:");
            foreach (var model in missingFromSpec)
            {
                Console.WriteLine($"  {model}");
            }

            Console.WriteLine();
            Console.WriteLine("The spec refreshes every 3 hours via .github/workflows/auto-update.yml; re-run `generate.sh` after it lands.");
        }

        if (asEndpoints.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Reachable as dedicated endpoints rather than a --model value ({asEndpoints.Count}):");
            foreach (var model in asEndpoints)
            {
                Console.WriteLine($"  {model}");
            }
        }

        if (missingFromAccount.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"In the spec but not in your account's tier ({missingFromAccount.Count}) — requests would be rejected:");
            foreach (var model in missingFromAccount)
            {
                Console.WriteLine($"  {model}");
            }
        }

        if (missingFromSpec.Count == 0 && missingFromAccount.Count == 0 && asEndpoints.Count == 0)
        {
            Console.WriteLine("The embedded spec and your account entitlements match exactly.");
        }
    }, cancellationToken);
});

var documentCommand = new Command("document", "Manage knowledge documents.");
rootCommand.Subcommands.Add(documentCommand);

var documentIdArgument = new Argument<Guid>("id")
{
    Description = "Document ID.",
};

var documentNameOption = new Option<string?>("--name")
{
    Description = "Document name.",
};

var contentOption = new Option<string?>("--content")
{
    Description = "Document content.",
};

var contentFileOption = new Option<string?>("--content-file")
{
    Description = "Path to a markdown/plain-text document, or '-' for stdin.",
};

var documentSortOption = new Option<string>("--sort")
{
    Description = "Document sort field: createdAt or updatedAt.",
    DefaultValueFactory = _ => "createdAt",
};

var documentOrderOption = new Option<string>("--order")
{
    Description = "Document sort order: asc or desc.",
    DefaultValueFactory = _ => "desc",
};

var listDocumentsCommand = new Command("list", "List knowledge documents.")
{
    limitOption,
    cursorOption,
    documentSortOption,
    documentOrderOption,
};
documentCommand.Subcommands.Add(listDocumentsCommand);
listDocumentsCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Knowledge.GetDocumentsAsync(
            limit: parseResult.GetValue(limitOption),
            cursor: parseResult.GetValue(cursorOption),
            sort: ParseDocumentSort(parseResult.GetValue(documentSortOption)),
            order: ParseDocumentOrder(parseResult.GetValue(documentOrderOption)),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var getDocumentCommand = new Command("get", "Get one knowledge document.")
{
    documentIdArgument,
};
documentCommand.Subcommands.Add(getDocumentCommand);
getDocumentCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Knowledge.GetDocumentsByIdAsync(
            id: parseResult.GetValue(documentIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var createDocumentCommand = new Command("create", "Create a knowledge document.")
{
    documentNameOption,
    contentOption,
    contentFileOption,
};
documentCommand.Subcommands.Add(createDocumentCommand);
createDocumentCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Knowledge.CreateDocumentsAsync(
            name: RequireOption(parseResult, documentNameOption),
            content: await RequireContentAsync(parseResult, contentOption, contentFileOption, ct).ConfigureAwait(false),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var updateDocumentCommand = new Command("update", "Update a knowledge document.")
{
    documentIdArgument,
    documentNameOption,
    contentOption,
    contentFileOption,
};
documentCommand.Subcommands.Add(updateDocumentCommand);
updateDocumentCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var name = parseResult.GetValue(documentNameOption);
        var content = await ReadContentAsync(parseResult, contentOption, contentFileOption, ct).ConfigureAwait(false);
        if (name is not { Length: > 0 } && content is not { Length: > 0 })
        {
            throw new ArgumentException("Set --name, --content, or --content-file.");
        }

        await client.Knowledge.EditDocumentsByIdAsync(
            id: parseResult.GetValue(documentIdArgument),
            xRunwayVersion: runwayVersion,
            name: name,
            content: content,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Updated.");
    }, cancellationToken));

var deleteDocumentCommand = new Command("delete", "Delete a knowledge document.")
{
    documentIdArgument,
};
documentCommand.Subcommands.Add(deleteDocumentCommand);
deleteDocumentCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.Knowledge.DeleteDocumentsByIdAsync(
            id: parseResult.GetValue(documentIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Deleted.");
    }, cancellationToken));

var uploadCommand = new Command("upload", "Create ephemeral uploads for larger image, video, and audio assets.");
rootCommand.Subcommands.Add(uploadCommand);

var uploadFileOption = new Option<string?>("--file", ["-f"])
{
    Description = "Local file to upload after creating the ephemeral upload.",
};

var filenameOption = new Option<string?>("--filename")
{
    Description = "Filename to register with Runway. Defaults to --file name.",
};

var createUploadCommand = new Command("create", "Create an ephemeral upload, optionally posting a local file immediately.")
{
    uploadFileOption,
    filenameOption,
};
uploadCommand.Subcommands.Add(createUploadCommand);
createUploadCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var file = parseResult.GetValue(uploadFileOption);
        var filename =
            parseResult.GetValue(filenameOption) is { Length: > 0 } explicitFilename ? explicitFilename :
            file is { Length: > 0 } fileValue ? Path.GetFileName(fileValue) :
            throw new ArgumentException("Set --filename or --file.");

        var response = await client.Uploads.CreateUploadsAsync(
            filename: filename,
            xRunwayVersion: runwayVersion,
            type: CreateUploadsRequestType.Ephemeral,
            cancellationToken: ct).ConfigureAwait(false);

        if (file is { Length: > 0 })
        {
            await RunwayCliBuiltInWorkflows.UploadEphemeralFileAsync(response, file, ct).ConfigureAwait(false);
        }

        WriteJson(response);
    }, cancellationToken));

var voiceCommand = new Command("voice", "Manage custom voices and voice previews.");
rootCommand.Subcommands.Add(voiceCommand);

var voicePresetsCommand = new Command("presets", "List the preset voice IDs each speech endpoint accepts.");
voiceCommand.Subcommands.Add(voicePresetsCommand);
voicePresetsCommand.SetAction(_ =>
{
    // Read from the embedded spec rather than a hand-kept list, and printed per endpoint because the
    // vocabularies differ: the speech endpoints use capitalized proper names while the avatar endpoints
    // use lowercase ones, so `clara` is a valid avatar voice but not a valid text-to-speech voice.
    foreach (var (endpoint, model) in new[]
             {
                 (RunwayCliGeneration.TextToSpeechEndpoint, "eleven_multilingual_v2"),
                 (RunwayCliGeneration.TextToSpeechEndpoint, "eleven_v3"),
                 (RunwayCliGeneration.SpeechToSpeechEndpoint, "eleven_multilingual_sts_v2"),
             })
    {
        var presets = RunwayModelSchema.GetItemPropertyValues(model, endpoint, "voice", "presetId");
        if (presets.Count == 0)
        {
            continue;
        }

        Console.WriteLine($"{endpoint.Replace('_', '-')} ({model}) — {presets.Count} preset voices:");
        foreach (var preset in presets)
        {
            Console.WriteLine($"  {preset}");
        }

        Console.WriteLine();
    }

    Console.WriteLine("Avatar voices use a separate, lowercase vocabulary — run `runway avatar presets` for those.");
    Console.WriteLine("seed_audio does not use presets; clone a voice with `text-to-speech --model seed_audio --reference-audio <file>`.");
});

var voiceIdArgument = new Argument<Guid>("id")
{
    Description = "Voice ID.",
};

var voiceNameOption = new Option<string?>("--name")
{
    Description = "Voice name.",
};

var descriptionOption = new Option<string?>("--description")
{
    Description = "Voice description.",
};

var voicePromptOption = new Option<string?>("--prompt")
{
    Description = "Text description of the desired voice.",
};

var voiceDesignModelOption = new Option<string>("--model")
{
    Description = "Voice design model: eleven_ttv_v3 or eleven_multilingual_ttv_v2.",
    DefaultValueFactory = _ => "eleven_ttv_v3",
};

var voiceAudioOption = new Option<string?>("--audio")
{
    Description = "HTTPS URL, Runway URI, data URI, or local audio file to clone.",
};

var listVoicesCommand = new Command("list", "List custom voices.")
{
    limitOption,
    cursorOption,
};
voiceCommand.Subcommands.Add(listVoicesCommand);
listVoicesCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Voices.GetVoicesAsync(
            limit: parseResult.GetValue(limitOption),
            cursor: parseResult.GetValue(cursorOption),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var getVoiceCommand = new Command("get", "Get one custom voice.")
{
    voiceIdArgument,
};
voiceCommand.Subcommands.Add(getVoiceCommand);
getVoiceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Voices.GetVoicesByIdAsync(
            id: parseResult.GetValue(voiceIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var createVoiceCommand = new Command("create", "Create a voice from text design or audio clone.")
{
    voiceNameOption,
    descriptionOption,
    voicePromptOption,
    voiceDesignModelOption,
    voiceAudioOption,
    jsonOption,
};
voiceCommand.Subcommands.Add(createVoiceCommand);
createVoiceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVoicesRequest>(json, ct).ConfigureAwait(false)
            : new CreateVoicesRequest
            {
                Name = RequireOption(parseResult, voiceNameOption),
                Description = parseResult.GetValue(descriptionOption),
                From = await CreateVoiceSourceAsync(parseResult, ct).ConfigureAwait(false),
            };

        var response = await client.Voices.CreateVoicesAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var updateVoiceCommand = new Command("update", "Update a custom voice.")
{
    voiceIdArgument,
    voiceNameOption,
    descriptionOption,
};
voiceCommand.Subcommands.Add(updateVoiceCommand);
updateVoiceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Voices.EditVoicesByIdAsync(
            id: parseResult.GetValue(voiceIdArgument),
            xRunwayVersion: runwayVersion,
            name: parseResult.GetValue(voiceNameOption),
            description: parseResult.GetValue(descriptionOption),
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var deleteVoiceCommand = new Command("delete", "Delete a custom voice.")
{
    voiceIdArgument,
};
voiceCommand.Subcommands.Add(deleteVoiceCommand);
deleteVoiceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.Voices.DeleteVoicesByIdAsync(
            id: parseResult.GetValue(voiceIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Deleted.");
    }, cancellationToken));

var previewVoiceCommand = new Command("preview", "Preview a voice from a text description.")
{
    voicePromptOption,
    voiceDesignModelOption,
    jsonOption,
};
voiceCommand.Subcommands.Add(previewVoiceCommand);
previewVoiceCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVoicesPreviewRequest>(json, ct).ConfigureAwait(false)
            : new CreateVoicesPreviewRequest
            {
                Prompt = RequireOption(parseResult, voicePromptOption),
                Model = ParseVoicePreviewModel(parseResult.GetValue(voiceDesignModelOption)),
            };

        var response = await client.Voices.CreateVoicesPreviewAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var realtimeCommand = new Command("realtime", "Manage realtime avatar sessions.");
rootCommand.Subcommands.Add(realtimeCommand);

var realtimeSessionIdArgument = new Argument<Guid>("id")
{
    Description = "Realtime session ID.",
};

var realtimePresetAvatarOption = new Option<string?>("--preset-avatar")
{
    Description = "Preset avatar ID, for example influencer.",
};

var realtimeAvatarIdOption = new Option<Guid?>("--avatar-id")
{
    Description = "Custom avatar ID.",
};

var maxDurationOption = new Option<int?>("--max-duration")
{
    Description = "Maximum session duration in seconds.",
};

var toolsJsonOption = new Option<string?>("--tools-json")
{
    Description = "Realtime tools JSON array, @path, or '-' for stdin.",
};

var createRealtimeCommand = new Command("create", "Create a realtime session.")
{
    realtimePresetAvatarOption,
    realtimeAvatarIdOption,
    maxDurationOption,
    personalityOption,
    startScriptOption,
    toolsJsonOption,
    jsonOption,
};
realtimeCommand.Subcommands.Add(createRealtimeCommand);
createRealtimeCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("gwm1_avatars", "realtime_sessions");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateRealtimeSessionsRequest>(json, ct).ConfigureAwait(false)
            : await CreateRealtimeSessionRequestAsync(parseResult, ct).ConfigureAwait(false);

        var response = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var getRealtimeCommand = new Command("get", "Get a realtime session.")
{
    realtimeSessionIdArgument,
};
realtimeCommand.Subcommands.Add(getRealtimeCommand);
getRealtimeCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.RealtimeSessions.GetRealtimeSessionsByIdAsync(
            id: parseResult.GetValue(realtimeSessionIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var deleteRealtimeCommand = new Command("delete", "Cancel a realtime session.")
{
    realtimeSessionIdArgument,
};
realtimeCommand.Subcommands.Add(deleteRealtimeCommand);
deleteRealtimeCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        await client.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(
            id: parseResult.GetValue(realtimeSessionIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        Console.WriteLine("Cancelled.");
    }, cancellationToken));

var organizationCommand = new Command("organization", "Inspect organization metadata and credit usage.");
rootCommand.Subcommands.Add(organizationCommand);

var getOrganizationCommand = new Command("get", "Get organization information.");
organizationCommand.Subcommands.Add(getOrganizationCommand);
getOrganizationCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Organization.GetOrganizationAsync(
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var beforeDateOption = new Option<DateTime?>("--before-date")
{
    Description = "UTC end date, not inclusive, for organization usage.",
};

var organizationUsageCommand = new Command("usage", "Query organization credit usage.")
{
    startDateOption,
    beforeDateOption,
};
organizationCommand.Subcommands.Add(organizationUsageCommand);
organizationUsageCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        // The spec types these as `format: date`, but the generated model carries DateTime, which
        // serializes as a full ISO-8601 timestamp and the API rejects ("Invalid ISO date"). Carry the
        // plain dates through the request's extension data instead, which serializes verbatim.
        var usageRequest = new CreateOrganizationUsageRequest();
        if (parseResult.GetValue(startDateOption) is { } usageStartDate)
        {
            usageRequest.AdditionalProperties["startDate"] = usageStartDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        if (parseResult.GetValue(beforeDateOption) is { } usageBeforeDate)
        {
            usageRequest.AdditionalProperties["beforeDate"] = usageBeforeDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        var response = await client.Organization.CreateOrganizationUsageAsync(
            request: usageRequest,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var workflowCommand = new Command("workflow", "Run and inspect published workflows.");
rootCommand.Subcommands.Add(workflowCommand);

var workflowIdArgument = new Argument<Guid>("id")
{
    Description = "Published workflow ID.",
};

var workflowInvocationIdArgument = new Argument<Guid>("id")
{
    Description = "Workflow invocation ID.",
};

var nodeOutputsJsonOption = new Option<string?>("--node-outputs-json")
{
    Description = "nodeOutputs object JSON, @path, or '-' for stdin.",
};

var listWorkflowsCommand = new Command("list", "List published workflows.");
workflowCommand.Subcommands.Add(listWorkflowsCommand);
listWorkflowsCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Workflows.GetWorkflowsAsync(
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var getWorkflowCommand = new Command("get", "Get published workflow details.")
{
    workflowIdArgument,
};
workflowCommand.Subcommands.Add(getWorkflowCommand);
getWorkflowCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Workflows.GetWorkflowsByIdAsync(
            id: parseResult.GetValue(workflowIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var runWorkflowCommand = new Command("run", "Run a published workflow.")
{
    workflowIdArgument,
    nodeOutputsJsonOption,
    jsonOption,
};
workflowCommand.Subcommands.Add(runWorkflowCommand);
runWorkflowCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateWorkflowsRequest>(json, ct).ConfigureAwait(false)
            : await CreateWorkflowRequestAsync(parseResult, ct).ConfigureAwait(false);

        var response = await client.Workflows.CreateWorkflowsByIdAsync(
            id: parseResult.GetValue(workflowIdArgument),
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var getWorkflowInvocationCommand = new Command("invocation", "Get workflow invocation details.")
{
    workflowInvocationIdArgument,
};
workflowCommand.Subcommands.Add(getWorkflowInvocationCommand);
getWorkflowInvocationCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Workflows.GetWorkflowInvocationsByIdAsync(
            id: parseResult.GetValue(workflowInvocationIdArgument),
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        WriteJson(response);
    }, cancellationToken));

var workflowRegisterIdArgument = new Argument<Guid>("id")
{
    Description = "Published workflow ID to fetch and persist locally as a top-level subcommand.",
};
var workflowRegisterNameOption = new Option<string?>("--name")
{
    Description = "Override the generated subcommand name (defaults to a slug of the workflow's display name).",
};
var workflowRegisterCommand = new Command("register", "Fetch a published workflow and register it locally as a top-level subcommand named by its slug. Stored under ~/.runway-cli/workflows/<command>.json.")
{
    workflowRegisterIdArgument,
    workflowRegisterNameOption,
};
workflowCommand.Subcommands.Add(workflowRegisterCommand);
workflowRegisterCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var workflowId = parseResult.GetValue(workflowRegisterIdArgument);
        using var request = new HttpRequestMessage(HttpMethod.Get, $"/v1/workflows/{workflowId}");
        request.Headers.Add("X-Runway-Version", runwayVersion);
        request.Headers.Authorization = GetBearerAuthorization(client);
        using var response = await client.HttpClient.SendAsync(request, ct).ConfigureAwait(false);
        var body = await response.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"Workflow fetch failed with HTTP {(int)response.StatusCode}: {body}");
        }

        var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(body, parseResult.GetValue(workflowRegisterNameOption));
        if (RunwayCliBuiltInWorkflows.BuiltIns.Any(b => string.Equals(b.CommandName, analyzed.CommandName, StringComparison.Ordinal)))
        {
            throw new InvalidOperationException($"Subcommand '{analyzed.CommandName}' clashes with a built-in. Pass --name to choose a different one.");
        }

        var path = RunwayCliBuiltInWorkflowRegistry.Save(analyzed.CommandName, analyzed.Description, analyzed.Picks, body);
        // Materialize once for the user-facing summary so the printed inputs reflect the same
        // shape that LoadAll would re-derive on next CLI invocation.
        var workflow = BuiltInWorkflowSelection.MaterializeFromGraph(
            analyzed.CommandName, analyzed.Description, BuiltInWorkflowCategory.Uncategorized, analyzed.Picks, body, source: $"register:{analyzed.WorkflowId}");
        await RunwayCliConsole.WriteInfoAsync($"Registered workflow '{workflow.DisplayName}' as '{workflow.CommandName}' ({workflow.Inputs.Count} inputs).").ConfigureAwait(false);
        await RunwayCliConsole.WriteInfoAsync($"  Saved to: {path}").ConfigureAwait(false);
        Console.WriteLine(JsonSerializer.Serialize(new
        {
            commandName = workflow.CommandName,
            workflowId = workflow.WorkflowId,
            displayName = workflow.DisplayName,
            description = workflow.Description,
            inputs = workflow.Inputs.Select(i => new { flag = i.Flag, kind = i.Kind.ToString(), required = i.Required, description = i.Description, defaultPreview = i.DefaultPreview, nodeId = i.NodeId }),
        }));
    }, cancellationToken));

var workflowBuiltInsCommand = new Command("built-ins", "List the built-in workflow subcommands shipped with this CLI release. Use --json for an agent-routing-friendly summary.");
var workflowBuiltInsJsonOption = new Option<bool>("--json")
{
    Description = "Emit machine-readable JSON instead of the default human-readable table.",
};
var workflowBuiltInsCategoryOption = new Option<string?>("--category")
{
    Description = "Filter by category (enum name like 'PhotoRestyle' or slug like 'photo-restyle'; case-insensitive).",
};
workflowBuiltInsCommand.Options.Add(workflowBuiltInsJsonOption);
workflowBuiltInsCommand.Options.Add(workflowBuiltInsCategoryOption);
workflowCommand.Subcommands.Add(workflowBuiltInsCommand);
workflowBuiltInsCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
{
    var asJson = parseResult.GetValue(workflowBuiltInsJsonOption);
    var categoryFilter = parseResult.GetValue(workflowBuiltInsCategoryOption);
    BuiltInWorkflowCategory? filter = null;
    if (categoryFilter is { Length: > 0 })
    {
        filter = BuiltInWorkflowCategoryExtensions.TryResolve(categoryFilter);
        if (filter is null)
        {
            var valid = string.Join(", ", Enum.GetNames<BuiltInWorkflowCategory>());
            Console.Error.WriteLine($"Unknown --category '{categoryFilter}'. Valid values: {valid} (or their slug forms).");
            return Task.FromResult(1);
        }
    }

    var builtIns = filter is { } f
        ? RunwayCliBuiltInWorkflows.BuiltIns.Where(w => w.Category == f).ToList()
        : (IReadOnlyList<BuiltInWorkflow>)RunwayCliBuiltInWorkflows.BuiltIns;

    if (asJson)
    {
        // Top-level shape: { categories: [...], workflows: [...] }. Categories appear even when
        // a --category filter narrows the workflow list, so an agent can always enumerate
        // available routes without a second call.
        var categoryList = Enum.GetValues<BuiltInWorkflowCategory>()
            .Where(c => c != BuiltInWorkflowCategory.Uncategorized)
            .Where(c => filter is null || c == filter)
            .Select(c => new
            {
                name = c.ToString(),
                displayName = c.DisplayName(),
                slug = c.Slug(),
                description = c.Description(),
                count = RunwayCliBuiltInWorkflows.BuiltIns.Count(w => w.Category == c),
            });
        var workflows = builtIns.Select(w => new
        {
            commandName = w.CommandName,
            displayName = w.DisplayName,
            description = w.Description,
            workflowId = w.WorkflowId,
            category = w.Category.ToString(),
            categoryDisplay = w.Category.DisplayName(),
            required = w.Inputs.Where(i => i.Required).Select(i => new
            {
                flag = i.Flag,
                kind = i.Kind.ToString(),
                description = i.Description,
            }),
            optional = w.Inputs.Where(i => !i.Required).Select(i => new
            {
                flag = i.Flag,
                kind = i.Kind.ToString(),
                description = i.Description,
                defaultPreview = i.DefaultPreview,
            }),
        });
        Console.WriteLine(JsonSerializer.Serialize(new { categories = categoryList, workflows }));
    }
    else
    {
        Console.Write(BuiltInWorkflows.RenderHumanList(builtIns));
    }
    return Task.FromResult(0);
});

var workflowRegisteredCommand = new Command("registered", "Manage locally registered workflow subcommands stored under ~/.runway-cli/workflows/.");
workflowCommand.Subcommands.Add(workflowRegisteredCommand);

var workflowRegisteredListCommand = new Command("list", "List locally registered workflows.");
workflowRegisteredCommand.Subcommands.Add(workflowRegisteredListCommand);
workflowRegisteredListCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
{
    try
    {
        var entries = RunwayCliBuiltInWorkflowRegistry.EnumerateRaw();
        var summary = entries.Select(e => new
        {
            commandName = e.CommandName,
            workflowId = e.WorkflowId,
            displayName = e.DisplayName,
            picks = e.PicksCount,
            path = e.FilePath,
            error = e.Error,
        });
        Console.WriteLine(JsonSerializer.Serialize(summary));
        return Task.FromResult(0);
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return Task.FromResult(1);
    }
});

var workflowRegisteredNameArgument = new Argument<string>("name")
{
    Description = "Locally-registered subcommand name.",
};

var workflowRegisteredShowCommand = new Command("show", "Print one registered workflow record.")
{
    workflowRegisteredNameArgument,
};
workflowRegisteredCommand.Subcommands.Add(workflowRegisteredShowCommand);
workflowRegisteredShowCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
{
    try
    {
        var name = parseResult.GetValue(workflowRegisteredNameArgument) ?? throw new ArgumentException("Missing required argument name.");
        var workflow = RunwayCliBuiltInWorkflows.LoadAllCommands().FirstOrDefault(w => string.Equals(w.CommandName, name, StringComparison.Ordinal))
            ?? throw new InvalidOperationException($"No registered workflow named '{name}'.");
        Console.WriteLine(JsonSerializer.Serialize(new
        {
            commandName = workflow.CommandName,
            workflowId = workflow.WorkflowId,
            displayName = workflow.DisplayName,
            description = workflow.Description,
            inputs = workflow.Inputs.Select(i => new { flag = i.Flag, kind = i.Kind.ToString(), required = i.Required, description = i.Description, defaultPreview = i.DefaultPreview, nodeId = i.NodeId }),
        }));
        return Task.FromResult(0);
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return Task.FromResult(1);
    }
});

var workflowRegisteredRemoveCommand = new Command("remove", "Delete a locally registered workflow record.")
{
    workflowRegisteredNameArgument,
};
workflowRegisteredCommand.Subcommands.Add(workflowRegisteredRemoveCommand);
workflowRegisteredRemoveCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
{
    try
    {
        var name = parseResult.GetValue(workflowRegisteredNameArgument) ?? throw new ArgumentException("Missing required argument name.");
        if (RunwayCliBuiltInWorkflows.BuiltIns.Any(b => string.Equals(b.CommandName, name, StringComparison.Ordinal)))
        {
            throw new InvalidOperationException($"Cannot remove '{name}': it is a built-in subcommand, not a registered one.");
        }
        var removed = RunwayCliBuiltInWorkflowRegistry.Remove(name);
        RunwayCliConsole.WriteInfo(removed ? $"Removed '{name}'." : $"No registered workflow named '{name}'.");
        return Task.FromResult(removed ? 0 : 1);
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return Task.FromResult(1);
    }
});

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

var galleryCommand = new Command("gallery", "Create a local HTML gallery for generated Runway videos.");
rootCommand.Subcommands.Add(galleryCommand);

var galleryCreateCommand = new Command("create", "Create a local HTML gallery for generated MP4 files.")
{
    galleryInputOption,
    galleryOutputOption,
    galleryRecursiveOption,
    galleryTitleOption,
    galleryMetadataOption,
};
galleryCommand.Subcommands.Add(galleryCreateCommand);
galleryCreateCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    try
    {
        var path = await RunwayCliGallery.CreateAsync(
            parseResult.GetValue(galleryInputOption),
            parseResult.GetValue(galleryOutputOption),
            parseResult.GetValue(galleryRecursiveOption),
            parseResult.GetValue(galleryTitleOption),
            parseResult.GetValue(galleryMetadataOption),
            cancellationToken).ConfigureAwait(false);

        Console.WriteLine(path);
        return 0;
    }
    catch (Exception ex)
    {
        await WriteErrorAsync(ex).ConfigureAwait(false);
        return 1;
    }
});

var soulIdCommand = new Command("soul-id", "Manage local soul-id reference photo bundles for face-faithful generation. Stored client-side; no Runway server-side identity training.");
rootCommand.Subcommands.Add(soulIdCommand);

var soulIdCreateCommand = new Command("create", "Create a soul-id from 5 to 20 reference photos. Prints the JSON entry on success.")
{
    soulIdNameOption,
    soulIdImageOption,
    soulIdVariantOption,
};
soulIdCommand.Subcommands.Add(soulIdCreateCommand);
soulIdCreateCommand.SetAction(parseResult =>
{
    try
    {
        var name = RequireOption(parseResult, soulIdNameOption);
        var photos = parseResult.GetValue(soulIdImageOption) ?? [];
        var variant = parseResult.GetValue(soulIdVariantOption);
        var entry = RunwayCliSoulId.Create(name, photos, variant);
        Console.WriteLine(RunwayCliSoulId.ToJson(entry));
        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var soulIdListCommand = new Command("list", "List local soul-id entries.")
{
    soulIdJsonFlag,
};
soulIdCommand.Subcommands.Add(soulIdListCommand);
soulIdListCommand.SetAction(parseResult =>
{
    try
    {
        var entries = RunwayCliSoulId.List();
        if (parseResult.GetValue(soulIdJsonFlag))
        {
            Console.WriteLine(RunwayCliSoulId.ToJson(entries));
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.Id}\t{entry.Variant}\t{entry.Name}\t{entry.Photos.Count} photos\t{entry.CreatedAt:O}");
            }
        }

        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var soulIdGetCommand = new Command("get", "Show one soul-id entry.")
{
    soulIdIdArgument,
};
soulIdCommand.Subcommands.Add(soulIdGetCommand);
soulIdGetCommand.SetAction(parseResult =>
{
    try
    {
        var id = parseResult.GetValue(soulIdIdArgument)
            ?? throw new ArgumentException("Missing soul-id argument.");
        var entry = RunwayCliSoulId.Get(id) ?? throw new ArgumentException($"Soul-id `{id}` not found.");
        Console.WriteLine(RunwayCliSoulId.ToJson(entry));
        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var soulIdWaitCommand = new Command("wait", "Wait for soul-id to finish training. Local registry is always ready, so this is a no-op for parity.")
{
    soulIdIdArgument,
};
soulIdCommand.Subcommands.Add(soulIdWaitCommand);
soulIdWaitCommand.SetAction(parseResult =>
{
    try
    {
        var id = parseResult.GetValue(soulIdIdArgument)
            ?? throw new ArgumentException("Missing soul-id argument.");
        var entry = RunwayCliSoulId.Get(id) ?? throw new ArgumentException($"Soul-id `{id}` not found.");
        Console.WriteLine(RunwayCliSoulId.ToJson(entry));
        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var soulIdDeleteCommand = new Command("delete", "Delete a soul-id entry from the local registry.")
{
    soulIdIdArgument,
};
soulIdCommand.Subcommands.Add(soulIdDeleteCommand);
soulIdDeleteCommand.SetAction(parseResult =>
{
    try
    {
        var id = parseResult.GetValue(soulIdIdArgument)
            ?? throw new ArgumentException("Missing soul-id argument.");
        var deleted = RunwayCliSoulId.Delete(id);
        Console.WriteLine(deleted ? $"Deleted {id}." : $"Soul-id `{id}` not found.");
        return deleted ? 0 : 1;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var authCommand = new Command("auth", "Manage Runway API key stored under ~/.runway-cli/credentials.json. Env var RUNWAY_API_KEY still takes precedence.");
rootCommand.Subcommands.Add(authCommand);

var authSetCommand = new Command("set", "Store a Runway API key in ~/.runway-cli/credentials.json.")
{
    authApiKeyOption,
};
authCommand.Subcommands.Add(authSetCommand);
authSetCommand.SetAction(parseResult =>
{
    try
    {
        var apiKey =
            parseResult.GetValue(authApiKeyOption) is { Length: > 0 } provided ? provided :
            Environment.GetEnvironmentVariable("RUNWAY_API_KEY") is { Length: > 0 } envValue ? envValue :
            throw new ArgumentException("Set --api-key, or export RUNWAY_API_KEY before running auth set.");
        RunwayCliAuth.Write(apiKey);
        Console.WriteLine($"Stored API key in {RunwayCliAuth.GetCredentialsFile()} (mode 0600).");
        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 1;
    }
});

var authShowCommand = new Command("show", "Show the active Runway API key source (env var, stored file, or .env). Key value is masked.");
authCommand.Subcommands.Add(authShowCommand);
authShowCommand.SetAction(_ =>
{
    var envValue = Environment.GetEnvironmentVariable("RUNWAY_API_KEY");
    var envSecret = Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET");
    var stored = RunwayCliAuth.Read();

    if (!string.IsNullOrEmpty(envValue))
    {
        Console.WriteLine($"source: env RUNWAY_API_KEY  apiKey: {RunwayCliAuth.Mask(envValue)}");
    }
    else if (!string.IsNullOrEmpty(envSecret))
    {
        Console.WriteLine($"source: env RUNWAYML_API_SECRET  apiKey: {RunwayCliAuth.Mask(envSecret)}");
    }
    else if (!string.IsNullOrEmpty(stored))
    {
        Console.WriteLine($"source: {RunwayCliAuth.GetCredentialsFile()}  apiKey: {RunwayCliAuth.Mask(stored)}");
    }
    else
    {
        Console.WriteLine("No API key configured. Run `runway auth set --api-key <key>` or export RUNWAY_API_KEY.");
    }

    return 0;
});

var authClearCommand = new Command("clear", "Delete the stored Runway API key file (does not affect env vars).");
authCommand.Subcommands.Add(authClearCommand);
authClearCommand.SetAction(_ =>
{
    var deleted = RunwayCliAuth.Clear();
    Console.WriteLine(deleted
        ? $"Deleted {RunwayCliAuth.GetCredentialsFile()}."
        : "No stored credentials file to delete.");
    return 0;
});

var accountCommand = new Command("account", "Show organization information and credit usage. Alias for `organization get`.");
rootCommand.Subcommands.Add(accountCommand);
accountCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Organization.GetOrganizationAsync(
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);
        WriteJson(response);
    }, cancellationToken));

var generateUmbrellaCommand = new Command("generate", "Higgsfield-parity router. Forwards <prompt> to image/video/image-to-video/text-to-speech/sound-effect based on --kind. Pass per-modality options through the dedicated command directly.")
{
    generatePromptArgument,
    generateKindOption,
};
rootCommand.Subcommands.Add(generateUmbrellaCommand);
generateUmbrellaCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    var prompt = string.Join(' ', parseResult.GetValue(generatePromptArgument) ?? []).Trim();
    var kind = (parseResult.GetValue(generateKindOption) ?? "image").Trim().ToLowerInvariant();
    var subcommand = kind switch
    {
        "image" or "text-to-image" or "txt2img" => "image",
        "video" or "text-to-video" or "txt2vid" => "video",
        "image-to-video" or "img2vid" or "i2v" => "image-to-video",
        "text-to-speech" or "tts" or "speech" => "text-to-speech",
        "sound-effect" or "sfx" or "audio" => "sound-effect",
        _ => throw new ArgumentException($"Unknown --kind `{kind}`. Supported: image, video, image-to-video, text-to-speech, sound-effect."),
    };
    var forwarded = string.IsNullOrEmpty(prompt) ? new[] { subcommand } : new[] { subcommand, prompt };
    cancellationToken.ThrowIfCancellationRequested();
    return await rootCommand.Parse(forwarded).InvokeAsync().ConfigureAwait(false);
});

var modelSchemaCommand = new Command("schema", "Print known parameters for a Runway model id.")
{
    modelSchemaIdArgument,
};
modelsCommand.Subcommands.Add(modelSchemaCommand);
modelSchemaCommand.SetAction(parseResult =>
{
    var model = parseResult.GetValue(modelSchemaIdArgument) ?? string.Empty;
    var entries = RunwayModelSchema.Lookup(model);
    if (entries.Count == 0)
    {
        Console.WriteLine($"model: {model}");
        Console.WriteLine("No schema entry found in the embedded Runway OpenAPI spec. Run `runway models` for the catalog or check Runway docs for newly added models.");
        return 1;
    }

    Console.WriteLine($"model: {model}");
    var endpointNames = entries.Select(static e => e.Endpoint)
        .Distinct(StringComparer.Ordinal)
        .OrderBy(static e => e, StringComparer.Ordinal);
    Console.WriteLine($"endpoints: {string.Join(", ", endpointNames)}");

    var requiredUnion = entries.SelectMany(static e => e.RequiredParameters)
        .Distinct(StringComparer.Ordinal)
        .OrderBy(static p => p, StringComparer.Ordinal)
        .ToList();
    var optionalUnion = entries.SelectMany(static e => e.OptionalParameters)
        .Distinct(StringComparer.Ordinal)
        .Except(requiredUnion, StringComparer.Ordinal)
        .OrderBy(static p => p, StringComparer.Ordinal)
        .ToList();

    if (requiredUnion.Count > 0)
    {
        Console.WriteLine($"required: {string.Join(", ", requiredUnion)}");
    }

    if (optionalUnion.Count > 0)
    {
        Console.WriteLine($"optional: {string.Join(", ", optionalUnion)}");
    }

    if (entries.Count > 1)
    {
        Console.WriteLine();
        Console.WriteLine("per-endpoint:");
        foreach (var entry in entries.OrderBy(static e => e.Endpoint, StringComparer.Ordinal))
        {
            var required = entry.RequiredParameters.Count > 0 ? string.Join(", ", entry.RequiredParameters) : "(none)";
            var optional = entry.OptionalParameters.Count > 0 ? string.Join(", ", entry.OptionalParameters) : "(none)";
            Console.WriteLine($"  {entry.Endpoint}");
            Console.WriteLine($"    required: {required}");
            Console.WriteLine($"    optional: {optional}");
            var perEndpointRatios = RunwayRatioSupport.GetSupportedRatios(model, entry.Endpoint);
            if (perEndpointRatios.Count > 0)
            {
                Console.WriteLine($"    ratios: {string.Join(", ", perEndpointRatios)}");
            }
        }
    }
    else
    {
        var ratios = RunwayRatioSupport.GetSupportedRatios(model);
        if (ratios.Count > 0)
        {
            Console.WriteLine($"ratios: {string.Join(", ", ratios)}");
        }
    }

    return 0;
});

var marketingStudioCommand = new Command("marketing-studio", "Higgsfield Marketing Studio parity surface. Only the subcommands that map to Runway primitives (avatars, webproducts) are exposed; products/hooks/settings/ad-references have no Runway analog.");
rootCommand.Subcommands.Add(marketingStudioCommand);

var marketingAvatarsCommand = new Command("avatars", "List or get Runway avatars. Alias for the existing `avatar` command tree.");
marketingStudioCommand.Subcommands.Add(marketingAvatarsCommand);

var marketingAvatarsListCommand = new Command("list", "List custom avatars.")
{
    limitOption,
    cursorOption,
};
marketingAvatarsCommand.Subcommands.Add(marketingAvatarsListCommand);
marketingAvatarsListCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var response = await client.Avatars.GetAvatarsAsync(
            xRunwayVersion: runwayVersion,
            limit: parseResult.GetValue(limitOption),
            cursor: parseResult.GetValue(cursorOption),
            cancellationToken: ct).ConfigureAwait(false);
        WriteJson(response);
    }, cancellationToken));

var marketingWebproductsCommand = new Command("webproducts", "Fetch a public product URL and extract OG/Twitter metadata as a structured product dossier.");
marketingStudioCommand.Subcommands.Add(marketingWebproductsCommand);

var marketingWebproductsFetchCommand = new Command("fetch", "Fetch a public product URL and print its OG metadata as JSON.")
{
    webproductsUrlOption,
};
marketingWebproductsCommand.Subcommands.Add(marketingWebproductsFetchCommand);
marketingWebproductsFetchCommand.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
{
    try
    {
        var url = parseResult.GetValue(webproductsUrlOption) ?? string.Empty;
        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentException("--url is required.");
        }

        using var http = new HttpClient();
        http.DefaultRequestHeaders.UserAgent.ParseAdd("Runway.Cli/marketing-studio");
        var html = await http.GetStringAsync(url, cancellationToken).ConfigureAwait(false);
        var dossier = RunwayCliMarketingStudio.ParseProductDossier(url, html);
        Console.WriteLine(RunwayCliMarketingStudio.ToJson(dossier));
        return 0;
    }
    catch (Exception ex)
    {
        await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
        return 1;
    }
});

foreach (var workflow in RunwayCliBuiltInWorkflows.LoadAllCommands())
{
    var workflowCmd = new Command(workflow.CommandName, workflow.Description);
    var flagOptions = new Dictionary<string, Option<string?>>(StringComparer.Ordinal);
    foreach (var input in workflow.Inputs)
    {
        var option = RunwayCliBuiltInWorkflows.BuildOption(input);
        workflowCmd.Options.Add(option);
        flagOptions[input.Flag] = option;
    }
    workflowCmd.Options.Add(outputOption);
    workflowCmd.Options.Add(noWaitOption);
    workflowCmd.Options.Add(noDownloadOption);
    workflowCmd.Options.Add(pollIntervalOption);

    var capturedWorkflow = workflow;
    var capturedFlagOptions = flagOptions;
    workflowCmd.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
        RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
        {
            await RunwayCliBuiltInWorkflows.RunAsync(
                capturedWorkflow,
                client,
                runwayVersion,
                parseResult,
                capturedFlagOptions,
                outputOption,
                noWaitOption,
                noDownloadOption,
                pollIntervalOption,
                ct).ConfigureAwait(false);
        }, cancellationToken));

    rootCommand.Subcommands.Add(workflowCmd);
}

var completionShellArgument = new Argument<string>("shell")
{
    Description = $"Shell to emit a completion script for: {string.Join(", ", RunwayCliCompletion.SupportedShells)}.",
};

var completionCommand = new Command(
    "completion",
    "Print a shell completion script on stdout. Generated from the live command tree and the embedded OpenAPI spec, so subcommands, options and --model values stay correct across spec refreshes.")
{
    completionShellArgument,
};
rootCommand.Subcommands.Add(completionCommand);
completionCommand.SetAction(parseResult =>
{
    try
    {
        Console.WriteLine(RunwayCliCompletion.Generate(parseResult.GetValue(completionShellArgument)!, rootCommand));
        return 0;
    }
    catch (ArgumentException ex)
    {
        Console.Error.WriteLine(ex.Message);
        return 2;
    }
});

var parseResultForInvocation = rootCommand.Parse(args);

// System.CommandLine exits 1 for a parse or validation error, which is the same code a failed
// generation uses. Let it print its usual message and usage block, then map it onto 2 so the contract
// documented in the README holds for every usage error, including the spec checks attached to the
// generated `runway api …` commands.
var invocationExitCode = await parseResultForInvocation.InvokeAsync().ConfigureAwait(false);
return parseResultForInvocation.Errors.Count > 0 ? 2 : invocationExitCode;

static async Task<Guid> PostGenerationJsonAsync(
    RunwayClient client,
    string runwayVersion,
    string relativePath,
    string json,
    CancellationToken cancellationToken)
{
    // Same reason as the typed --json path: a hand-written body gets the spec checks too.
    RunwayCliJsonBodyValidator.EnsureValid(json);

    using var request = new HttpRequestMessage(HttpMethod.Post, relativePath);
    request.Headers.Add("X-Runway-Version", runwayVersion);
    request.Headers.Authorization = GetBearerAuthorization(client);
    request.Content = new StringContent(json, Encoding.UTF8, "application/json");

    using var response = await client.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
    var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
    if (!response.IsSuccessStatusCode)
    {
        throw new ApiException($"Runway API error {(int)response.StatusCode}.", response.StatusCode)
        {
            ResponseBody = responseBody,
            ResponseHeaders = ToHeaderDictionary(response),
        };
    }

    using var document = JsonDocument.Parse(responseBody);
    return document.RootElement.TryGetProperty("id", out var idProperty) &&
           Guid.TryParse(idProperty.GetString(), out var id)
        ? id
        : throw new InvalidOperationException($"Runway response did not include a task ID: {responseBody}");
}

static AuthenticationHeaderValue GetBearerAuthorization(RunwayClient client)
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

static Dictionary<string, IEnumerable<string>> ToHeaderDictionary(HttpResponseMessage response)
{
    var headers = new Dictionary<string, IEnumerable<string>>(StringComparer.OrdinalIgnoreCase);
    foreach (var header in response.Headers)
    {
        headers[header.Key] = header.Value;
    }

    foreach (var header in response.Content.Headers)
    {
        headers[header.Key] = header.Value;
    }

    return headers;
}

async Task HandleGenerationTaskAsync(
    RunwayClient client,
    string runwayVersion,
    Func<CancellationToken, Task<Guid>> submitAsync,
    ParseResult parseResult,
    string defaultExtension,
    string stemPrefix,
    CancellationToken cancellationToken,
    int? retryOnInternalErrorOverride = null)
{
    var asJson = IsJsonFormat(parseResult);
    var quiet = parseResult.GetValue(quietOption);

    if (parseResult.GetValue(noWaitOption))
    {
        var taskId = await submitAsync(cancellationToken).ConfigureAwait(false);
        if (!quiet)
        {
            await Console.Error.WriteLineAsync($"Task ID: {taskId}").ConfigureAwait(false);
        }

        // stdout is the machine-readable channel: the bare id in text mode, the full result in JSON.
        Console.WriteLine(asJson
            ? RunwayCliResult.ToJson(new RunwayCliGenerationResult { TaskId = taskId.ToString(), Outputs = [] })
            : taskId.ToString());
        return;
    }

    var retries = retryOnInternalErrorOverride ?? parseResult.GetValue(retryOnInternalErrorOption);
    var task = await RunwayCliRetry.SubmitAndWaitAsync(
        client,
        runwayVersion,
        submitAsync,
        pollInterval: TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
        retryOnInternalError: retries,
        retryBackoff: TimeSpan.FromSeconds(parseResult.GetValue(retryBackoffSecondsOption)),
        progress: quiet ? null : CreateConsoleProgress(),
        quiet: quiet,
        cancellationToken: cancellationToken).ConfigureAwait(false);

    if (task.IsFailed)
    {
        var failed = task.Failed;
        throw new InvalidOperationException(
            string.IsNullOrWhiteSpace(failed?.FailureCode)
                ? $"Runway task {failed?.Id} failed: {failed?.Failure}"
                : $"Runway task {failed?.Id} failed ({failed!.FailureCode}): {failed.Failure}");
    }

    var downloaded = await task.DownloadOutputsAsync(
        output: parseResult.GetValue(outputOption),
        defaultExtension: defaultExtension,
        stemPrefix: stemPrefix,
        cancellationToken: cancellationToken).ConfigureAwait(false);

    if (asJson)
    {
        Console.WriteLine(RunwayCliResult.ToJson(new RunwayCliGenerationResult
        {
            TaskId = task.Succeeded?.Id.ToString() ?? string.Empty,
            Outputs = [.. downloaded],
        }));
        return;
    }

    foreach (var path in downloaded)
    {
        Console.WriteLine(path);
    }
}

/// <summary>
/// Reads and validates the global <c>--format</c>. An unknown value fails instead of falling back, so a
/// typo in a CI script cannot silently produce text where JSON was expected.
/// </summary>
bool IsJsonFormat(ParseResult parseResult)
{
    if (parseResult.GetValue(formatOption) is not { Length: > 0 } format)
    {
        return false;
    }

    return format.Trim().ToLowerInvariant() switch
    {
        "json" => true,
        "text" => false,
        _ => throw new ArgumentException($"Unsupported --format '{format}'. Accepted values: text, json."),
    };
}

async Task<RunwayShortVideoOptions> CreateShortVideoOptionsAsync(
    ParseResult parseResult,
    string segmentOutput,
    CancellationToken cancellationToken,
    RunwayCliMarketingBrief? brief = null)
{
    var explicitRatio = parseResult.GetValue(shortVideoRatioOption);
    var ratio = !string.IsNullOrWhiteSpace(explicitRatio) ? explicitRatio
        : !string.IsNullOrWhiteSpace(brief?.FormatAspectRatio) ? brief!.FormatAspectRatio!
        : RunwayShortVideoOptions.DefaultRatio;

    return new RunwayShortVideoOptions
    {
        ShotCount = parseResult.GetValue(shortVideoShotCountOption),
        ShotDurationSeconds = parseResult.GetValue(generationDurationOption) ?? 4,
        Model = parseResult.GetValue(videoModelOption) ?? RunwayShortVideoOptions.DefaultModel,
        Ratio = ratio,
        Audio = parseResult.GetValue(shortVideoAudioOption),
        Seed = parseResult.GetValue(seedOption),
        Style = parseResult.GetValue(shortVideoStyleOption),
        PublicFigureThreshold = parseResult.GetValue(publicFigureThresholdOption),
        ReferenceImageUris = await ResolveShortVideoReferenceImagesAsync(parseResult, cancellationToken).ConfigureAwait(false),
        ReferenceVideoUris = await ResolveReferenceListAsync(parseResult, videoReferenceVideoOption, cancellationToken).ConfigureAwait(false),
        ReferenceAudioUris = await ResolveReferenceListAsync(parseResult, videoReferenceAudioOption, cancellationToken).ConfigureAwait(false),
        WaitForCompletion = !parseResult.GetValue(noWaitOption),
        DownloadOutputs = !parseResult.GetValue(noWaitOption),
        Output = segmentOutput,
        PollInterval = TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
        RetryOnInternalError = parseResult.GetValue(recipeRetryOnInternalErrorOption),
        RetryBackoff = TimeSpan.FromSeconds(parseResult.GetValue(retryBackoffSecondsOption)),
    };
}

// Short-video shots are text-to-video, which now accepts image references on the seedance/hailuo/wan3/
// grok models — so --soul-id and --reference-image can flow straight into every shot instead of forcing
// the image -> image-to-video chain. Local paths are inlined as data URIs here because the library-side
// short-video runner takes URIs, not paths.
async Task<IReadOnlyList<string>?> ResolveShortVideoReferenceImagesAsync(ParseResult parseResult, CancellationToken cancellationToken) =>
    await RunwayCliGeneration.NormalizeReferenceAssetsAsync(
        MergeSoulIdImages(parseResult, parseResult.GetValue(videoReferenceImageOption)),
        cancellationToken).ConfigureAwait(false);

async Task<IReadOnlyList<string>?> ResolveReferenceListAsync(ParseResult parseResult, Option<string[]> option, CancellationToken cancellationToken) =>
    await RunwayCliGeneration.NormalizeReferenceAssetsAsync(
        parseResult.GetValue(option),
        cancellationToken).ConfigureAwait(false);

RunwayCliShortVideoPlannerOptions CreateShortVideoPlannerOptions(ParseResult parseResult)
{
    return RunwayCliShortVideo.CreatePlannerOptions(
        parseResult.GetValue(shortVideoPlannerOption),
        parseResult.GetValue(shortVideoPlannerModelOption),
        parseResult.GetValue(shortVideoPlannerToolsOption),
        parseResult.GetValue(shortVideoPlannerTimeoutSecondsOption));
}

async Task<RunwayCliMarketingBrief> ResolveMarketingBriefAsync(
    ParseResult parseResult,
    CancellationToken cancellationToken)
{
    var directory = Environment.CurrentDirectory;
    var brief = await RunwayCliMarketingBriefStore.ReadAsync(directory, cancellationToken).ConfigureAwait(false);

    var noInteractive = parseResult.GetValue(shortVideoNoInteractiveOption);
    if (noInteractive || Console.IsInputRedirected)
    {
        if (!brief.IsEmpty)
        {
            await RunwayCliConsole.WriteInfoAsync(string.Create(
                System.Globalization.CultureInfo.InvariantCulture,
                $"Loaded MARKETING.md from {directory}.")).ConfigureAwait(false);
        }

        return brief;
    }

    var collected = await RunwayCliMarketingBriefStore.AskMissingAsync(
        brief,
        Console.In,
        Console.Out,
        cancellationToken).ConfigureAwait(false);

    var wrote = await RunwayCliMarketingBriefStore.WriteAsync(directory, collected, cancellationToken).ConfigureAwait(false);
    if (wrote)
    {
        await RunwayCliConsole.WriteInfoAsync(string.Create(
            System.Globalization.CultureInfo.InvariantCulture,
            $"Updated {Path.Combine(directory, RunwayCliMarketingBriefStore.FileName)}.")).ConfigureAwait(false);
    }

    return collected;
}

async Task<RunwayShortVideoOptions> CreateShortVideoOptionsFromPlanAsync(
    ParseResult parseResult,
    string segmentOutput,
    RunwayShortVideoPlan plan,
    CancellationToken cancellationToken)
{
    return new RunwayShortVideoOptions
    {
        ShotCount = plan.Shots.Count,
        ShotDurationSeconds = parseResult.GetValue(generationDurationOption) ?? plan.ShotDurationSeconds,
        Model = parseResult.GetValue(videoModelOption) ?? plan.Model,
        Ratio = parseResult.GetValue(shortVideoRatioOption) ?? plan.Ratio,
        Audio = parseResult.GetValue(shortVideoAudioOption),
        Seed = parseResult.GetValue(seedOption),
        Style = plan.Style,
        PublicFigureThreshold = parseResult.GetValue(publicFigureThresholdOption),
        ReferenceImageUris = await ResolveShortVideoReferenceImagesAsync(parseResult, cancellationToken).ConfigureAwait(false),
        ReferenceVideoUris = await ResolveReferenceListAsync(parseResult, videoReferenceVideoOption, cancellationToken).ConfigureAwait(false),
        ReferenceAudioUris = await ResolveReferenceListAsync(parseResult, videoReferenceAudioOption, cancellationToken).ConfigureAwait(false),
        WaitForCompletion = !parseResult.GetValue(noWaitOption),
        DownloadOutputs = !parseResult.GetValue(noWaitOption),
        Output = segmentOutput,
        PollInterval = TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
        RetryOnInternalError = parseResult.GetValue(recipeRetryOnInternalErrorOption),
        RetryBackoff = TimeSpan.FromSeconds(parseResult.GetValue(retryBackoffSecondsOption)),
    };
}

Task<int> RunShortVideoPlanAsync(
    ParseResult parseResult,
    RunwayShortVideoPlan plan,
    RunwayShortVideoOptions options,
    RunwayCliShortVideoOutput output,
    CancellationToken cancellationToken)
{
    return RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var planPath = await RunwayCliShortVideo.WritePlanAsync(plan, output, ct).ConfigureAwait(false);
        await RunwayCliConsole.WriteInfoAsync($"Short-video plan JSON: {planPath}").ConfigureAwait(false);

        WriteShortVideoPlan(plan);

        IReadOnlyList<string> downloadedFiles;
        IReadOnlyList<string> shotTaskIds;
        var keyframesModel = parseResult.GetValue(shortVideoKeyframesOption);
        if (!string.IsNullOrWhiteSpace(keyframesModel))
        {
            await RunwayCliConsole.WriteInfoAsync(string.Create(
                System.Globalization.CultureInfo.InvariantCulture,
                $"Keyframes mode: {keyframesModel} -> image-to-video ({options.Model}).")).ConfigureAwait(false);
            var keyframesResult = await RunwayCliShortVideoKeyframes.RunPlanAsync(
                client,
                plan,
                options,
                new RunwayCliShortVideoKeyframeOptions(keyframesModel, ReferenceSubject: "human"),
                xRunwayVersion: runwayVersion,
                log: quietMode ? null : line => Console.Error.WriteLine(line),
                cancellationToken: ct).ConfigureAwait(false);
            downloadedFiles = keyframesResult.DownloadedFiles;
            shotTaskIds = keyframesResult.Shots.Select(shot => shot.VideoTaskId.ToString()).ToArray();
        }
        else
        {
            var result = await client.CreateShortVideoAsync(
                plan,
                options,
                runwayVersion,
                progress: new RunwayCliInlineProgress<RunwayShortVideoProgress>(WriteShortVideoProgress),
                cancellationToken: ct).ConfigureAwait(false);
            downloadedFiles = result.DownloadedFiles;
            shotTaskIds = result.Shots.Select(shot => shot.TaskId.ToString()).ToArray();
        }

        if (parseResult.GetValue(noWaitOption))
        {
            foreach (var taskId in shotTaskIds)
            {
                Console.WriteLine(taskId);
            }

            return;
        }

        if (parseResult.GetValue(shortVideoNoConcatOption))
        {
            foreach (var path in downloadedFiles)
            {
                Console.WriteLine(path);
            }

            return;
        }

        var concat = await RunwayCliShortVideo.TryConcatAsync(
            downloadedFiles,
            output.FinalOutput,
            parseResult.GetValue(ffmpegOption),
            ct).ConfigureAwait(false);
        if (concat.Warning is { Length: > 0 })
        {
            await Console.Error.WriteLineAsync(concat.Warning).ConfigureAwait(false);
        }

        if (concat.Output is { Length: > 0 })
        {
            Console.WriteLine(concat.Output);
            return;
        }

        foreach (var path in downloadedFiles)
        {
            Console.WriteLine(path);
        }
    }, cancellationToken);
}

Task<int> RunCreativeImageRecipeAsync(
    ParseResult parseResult,
    RunwayCliCreativeRecipePlan plan,
    string? name,
    CancellationToken cancellationToken)
{
    return RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        WriteCreativeRecipePlan(plan);

        var recipeRetries = parseResult.GetValue(recipeRetryOnInternalErrorOption);
        foreach (var job in plan.Jobs)
        {
            await HandleGenerationTaskAsync(
                client,
                runwayVersion,
                async submitCt =>
                {
                    if (RunwayCliGeneration.NormalizeTextToImageModel(job.Model) == "gpt_image_2")
                    {
                        var response = await client.StartGenerating.CreateGptImage2TextToImageAsync(
                            request: await RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
                                job.Prompt,
                                job.Ratio,
                                job.ReferenceImages.ToArray(),
                                job.Resolution,
                                job.Quality,
                                1,
                                submitCt).ConfigureAwait(false),
                            xRunwayVersion: runwayVersion,
                            cancellationToken: submitCt).ConfigureAwait(false);
                        return response.Id;
                    }

                    var fallback = await client.StartGenerating.CreateTextToImageAsync(
                        request: await RunwayCliGeneration.CreateTextToImageRequestAsync(
                            job.Prompt,
                            job.Model,
                            job.Ratio,
                            job.ReferenceImages.ToArray(),
                            "object",
                            null,
                            1,
                            parseResult.GetValue(publicFigureThresholdOption),
                            RunwayCliImageExtras.None,
                            submitCt).ConfigureAwait(false),
                        xRunwayVersion: runwayVersion,
                        cancellationToken: submitCt).ConfigureAwait(false);
                    return fallback.Id;
                },
                parseResult,
                ".png",
                CreateRecipeStem(plan, job, name),
                ct,
                retryOnInternalErrorOverride: recipeRetries).ConfigureAwait(false);
        }
    }, cancellationToken);
}

Task<int> RunCreativeVideoRecipeAsync(
    ParseResult parseResult,
    RunwayCliCreativeRecipePlan plan,
    string? name,
    CancellationToken cancellationToken)
{
    return RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        WriteCreativeRecipePlan(plan);

        var recipeRetries = parseResult.GetValue(recipeRetryOnInternalErrorOption);
        foreach (var job in plan.Jobs)
        {
            await HandleGenerationTaskAsync(
                client,
                runwayVersion,
                async submitCt =>
                {
                    if (job.ReferenceImages.Count > 0)
                    {
                        var response = await client.StartGenerating.CreateImageToVideoAsync(
                            request: await RunwayCliGeneration.CreateImageToVideoRequestAsync(
                                job.Prompt,
                                job.Model,
                                job.ReferenceImages.ToArray(),
                                null,
                                job.Ratio,
                                job.DurationSeconds,
                                parseResult.GetValue(seedOption),
                                job.Audio == true,
                                parseResult.GetValue(publicFigureThresholdOption),
                                RunwayCliVideoExtras.None,
                                submitCt).ConfigureAwait(false),
                            xRunwayVersion: runwayVersion,
                            cancellationToken: submitCt).ConfigureAwait(false);
                        return response.Id;
                    }

                    var fallback = await client.StartGenerating.CreateTextToVideoAsync(
                        request: await RunwayCliGeneration.CreateTextToVideoRequestAsync(
                            job.Prompt,
                            job.Model,
                            job.Ratio,
                            job.DurationSeconds,
                            parseResult.GetValue(seedOption),
                            job.Audio == true,
                            parseResult.GetValue(publicFigureThresholdOption),
                            RunwayCliVideoExtras.None,
                            submitCt).ConfigureAwait(false),
                        xRunwayVersion: runwayVersion,
                        cancellationToken: submitCt).ConfigureAwait(false);
                    return fallback.Id;
                },
                parseResult,
                ".mp4",
                CreateRecipeStem(plan, job, name),
                ct,
                retryOnInternalErrorOverride: recipeRetries).ConfigureAwait(false);
        }
    }, cancellationToken);
}

static void WriteShortVideoPlan(RunwayShortVideoPlan plan)
{
    RunwayCliConsole.WriteInfo("Short-video plan:");
    foreach (var shot in plan.Shots)
    {
        RunwayCliConsole.WriteInfo($"  {shot.Index}. {shot.Title}");
        RunwayCliConsole.WriteInfo($"     {shot.Beat}");
    }
}

static void WriteCreativeRecipePlan(RunwayCliCreativeRecipePlan plan)
{
    RunwayCliConsole.WriteInfo($"{ToDisplayName(plan.Kind)} plan:");
    foreach (var job in plan.Jobs)
    {
        RunwayCliConsole.WriteInfo($"  {job.Index}. {job.Label}");
    }
}

string? ResolveCreativeRecipeName(ParseResult parseResult, RunwayCliCreativeRecipePlan plan)
{
    var explicitName = parseResult.GetValue(creativeRecipeNameOption);
    var autoNamePrefix = parseResult.GetValue(creativeRecipeAutoNameOption);

    if (explicitName is { Length: > 0 } && autoNamePrefix is { Length: > 0 })
    {
        throw new ArgumentException("--name and --auto-name are mutually exclusive.");
    }

    if (autoNamePrefix is { Length: > 0 })
    {
        var scanDirectory = RunwayCliNaming.ResolveAutoNameScanDirectory(parseResult.GetValue(outputOption));
        var stemPrefix = $"runway-{SanitizeStem(plan.Kind)}-";
        var resolved = RunwayCliNaming.ComputeNextNameWithPrefix(
            stemPrefix: stemPrefix,
            namePrefix: autoNamePrefix,
            scanDirectory: scanDirectory);
        RunwayCliConsole.WriteInfo($"Auto-name resolved to: {resolved}");
        return resolved;
    }

    return explicitName;
}

string? ResolveShortVideoName(ParseResult parseResult)
{
    var explicitName = parseResult.GetValue(shortVideoNameOption);
    var autoNamePrefix = parseResult.GetValue(shortVideoAutoNameOption);

    if (explicitName is { Length: > 0 } && autoNamePrefix is { Length: > 0 })
    {
        throw new ArgumentException("--name and --auto-name are mutually exclusive.");
    }

    if (autoNamePrefix is { Length: > 0 })
    {
        var scanDirectory = RunwayCliNaming.ResolveAutoNameScanDirectory(parseResult.GetValue(outputOption));
        var resolved = RunwayCliNaming.ComputeNextNameWithPrefix(
            stemPrefix: "runway-short-video-",
            namePrefix: autoNamePrefix,
            scanDirectory: scanDirectory);
        RunwayCliConsole.WriteInfo($"Auto-name resolved to: {resolved}");
        return resolved;
    }

    return explicitName;
}

static string CreateRecipeStem(RunwayCliCreativeRecipePlan plan, RunwayCliCreativeRecipeJob job, string? name = null)
{
    if (string.IsNullOrWhiteSpace(name))
    {
        return string.Create(
            CultureInfo.InvariantCulture,
            $"runway-{SanitizeStem(plan.Kind)}-{job.Index:00}-{SanitizeStem(job.Label)}");
    }

    var sanitizedName = SanitizeStem(RunwayCliNaming.SanitizeName(name));
    return string.Create(
        CultureInfo.InvariantCulture,
        $"runway-{SanitizeStem(plan.Kind)}-{sanitizedName}-{job.Index:00}-{SanitizeStem(job.Label)}");
}

static string SanitizeStem(string value)
{
    var builder = new StringBuilder(value.Length);
    foreach (var character in value)
    {
        if (char.IsLetterOrDigit(character))
        {
            builder.Append(char.ToLowerInvariant(character));
        }
        else if (character is '-' or '_' or ' ')
        {
            builder.Append('-');
        }
    }

    var sanitized = builder.ToString().Trim('-');
    return sanitized.Length > 0 ? sanitized : "recipe";
}

static string ToDisplayName(string value)
{
    return value.Replace("_", " ", StringComparison.Ordinal)
        .Replace("-", " ", StringComparison.Ordinal);
}

static void WriteShortVideoProgress(RunwayShortVideoProgress progress)
{
    switch (progress.Stage)
    {
        case RunwayShortVideoProgressStage.StartingShot:
            RunwayCliConsole.WriteInfo($"Starting shot {progress.Shot.Index}/{progress.Shot.Count}: {progress.Shot.Title}");
            break;

        case RunwayShortVideoProgressStage.TaskCreated:
            RunwayCliConsole.WriteInfo($"Shot {progress.Shot.Index} task ID: {progress.TaskId}");
            break;

        case RunwayShortVideoProgressStage.TaskUpdated:
            if (progress.Task is { } task)
            {
                WriteTaskProgress(task);
            }

            break;

        case RunwayShortVideoProgressStage.ShotDownloaded:
            RunwayCliConsole.WriteInfo($"Downloaded shot {progress.Shot.Index}.");
            break;

        default:
            break;
    }
}

async Task<string> RequireContentAsync(
    ParseResult parseResult,
    Option<string?> inlineOption,
    Option<string?> fileOption,
    CancellationToken cancellationToken)
{
    return await ReadContentAsync(parseResult, inlineOption, fileOption, cancellationToken).ConfigureAwait(false)
        ?? throw new ArgumentException($"Set {inlineOption.Name} or {fileOption.Name}.");
}

static async Task<string?> ReadContentAsync(
    ParseResult parseResult,
    Option<string?> inlineOption,
    Option<string?> fileOption,
    CancellationToken cancellationToken)
{
    if (parseResult.GetValue(inlineOption) is { Length: > 0 } inlineValue)
    {
        return inlineValue;
    }

    if (parseResult.GetValue(fileOption) is not { Length: > 0 } fileValue)
    {
        return null;
    }

    return fileValue == "-"
        ? await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false)
        : await File.ReadAllTextAsync(fileValue, cancellationToken).ConfigureAwait(false);
}

async Task<From> CreateVoiceSourceAsync(ParseResult parseResult, CancellationToken cancellationToken)
{
    if (parseResult.GetValue(voiceAudioOption) is { Length: > 0 } audio)
    {
        return new CreateVoicesRequestFromVoiceFromAudio
        {
            Audio = await RunwayCliGeneration.NormalizeInputAssetAsync(audio, cancellationToken).ConfigureAwait(false),
        };
    }

    return new CreateVoicesRequestFromVoiceFromText
    {
        Prompt = RequireOption(parseResult, voicePromptOption),
        Model = ParseVoiceDesignModel(parseResult.GetValue(voiceDesignModelOption)),
    };
}

async Task<CreateRealtimeSessionsRequest> CreateRealtimeSessionRequestAsync(
    ParseResult parseResult,
    CancellationToken cancellationToken)
{
    var body = new JsonObject
    {
        ["model"] = "gwm1_avatars",
        ["avatar"] = parseResult.GetValue(realtimeAvatarIdOption) is { } customAvatarId
            ? new JsonObject
            {
                ["type"] = "custom",
                ["avatarId"] = customAvatarId.ToString(),
            }
            : new JsonObject
            {
                ["type"] = "runway-preset",
                // Validated against the spec: this body is deserialized into the generated request, and
                // the generated enum would coerce an unknown id to its first member (cat-character).
                ["presetId"] = RunwayCliGeneration.NormalizePresetId(
                    parseResult.GetValue(realtimePresetAvatarOption),
                    "gwm1_avatars",
                    "realtime_sessions",
                    "avatar",
                    "--preset-avatar",
                    "runway avatar presets"),
            },
    };

    if (parseResult.GetValue(maxDurationOption) is { } maxDuration)
    {
        body["maxDuration"] = maxDuration;
    }

    if (parseResult.GetValue(personalityOption) is { Length: > 0 } personality)
    {
        body["personality"] = personality;
    }

    if (parseResult.GetValue(startScriptOption) is { Length: > 0 } startScript)
    {
        body["startScript"] = startScript;
    }

    if (parseResult.GetValue(toolsJsonOption) is { Length: > 0 } toolsJson)
    {
        body["tools"] = JsonNode.Parse(await RunwayCliGeneration.ReadJsonTextAsync(toolsJson, cancellationToken).ConfigureAwait(false))
            ?? new JsonArray();
    }

    return RunwayCliGeneration.ToGenerated<CreateRealtimeSessionsRequest>(body);
}

async Task<CreateWorkflowsRequest> CreateWorkflowRequestAsync(
    ParseResult parseResult,
    CancellationToken cancellationToken)
{
    var body = new JsonObject();
    if (parseResult.GetValue(nodeOutputsJsonOption) is { Length: > 0 } nodeOutputsJson)
    {
        body["nodeOutputs"] = JsonNode.Parse(await RunwayCliGeneration.ReadJsonTextAsync(nodeOutputsJson, cancellationToken).ConfigureAwait(false))
            ?? new JsonObject();
    }

    return RunwayCliGeneration.ToGenerated<CreateWorkflowsRequest>(body);
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
        return ExitCodeFor(ex);
    }
}

/// <summary>
/// Exit-code convention so CI can tell a broken invocation from a failed generation: 2 for anything the
/// caller can fix on the command line (unknown model, a value outside the spec enum, a missing option, a
/// path that does not exist, no API key), 1 for everything that failed on Runway's side or in transit.
/// </summary>
static int ExitCodeFor(Exception exception) => exception switch
{
    ArgumentException => 2,
    FormatException => 2,
    FileNotFoundException => 2,
    DirectoryNotFoundException => 2,
    InvalidOperationException invalid when invalid.Message.StartsWith("Set --api-key", StringComparison.Ordinal) => 2,
    _ => 1,
};

string[]? MergeSoulIdImages(ParseResult parseResult, string[]? baseImages)
{
    if (parseResult.GetValue(soulIdReferenceOption) is not { Length: > 0 } soulIdValue)
    {
        return baseImages;
    }

    var resolved = RunwayCliSoulId.ResolvePhotos(soulIdValue);
    if (baseImages is null || baseImages.Length == 0)
    {
        return [.. resolved];
    }

    return [.. baseImages, .. resolved];
}

/// <summary>
/// Walks the generated `runway api …` command tree and makes every command that accepts a whole request
/// body validate it against the embedded spec first. Done here, in hand-written code, because
/// `GeneratedApi/` is deleted and regenerated by `generate.sh` — which CI runs every three hours — so an
/// edit inside it would not survive the next spec refresh.
/// </summary>
static void AttachJsonBodyValidation(Command command)
{
    var bodyOptions = command.Options
        .Where(option => option.Name is "--request-json" or "--request-file" or "--input")
        .ToList();

    if (bodyOptions.Count > 0)
    {
        command.Validators.Add(result =>
        {
            foreach (var option in bodyOptions)
            {
                if (result.GetResult(option) is null)
                {
                    continue;
                }

                // Only inline JSON and real files are checked. `-` is stdin, and consuming it here
                // would starve the handler that needs to read the same body.
                var raw = result.GetResult(option)?.Tokens is [{ Value: { Length: > 0 } token }, ..]
                    ? token
                    : null;
                if (string.IsNullOrWhiteSpace(raw) || raw == "-")
                {
                    continue;
                }

                var json = raw.TrimStart() is ['{', ..] or ['[', ..]
                    ? raw
                    : File.Exists(raw) ? File.ReadAllText(raw) : null;

                if (json is null)
                {
                    continue;
                }

                foreach (var violation in RunwayCliJsonBodyValidator.FindViolations(json))
                {
                    result.AddError(violation);
                }
            }
        });
    }

    foreach (var subcommand in command.Subcommands)
    {
        AttachJsonBodyValidation(subcommand);
    }
}

/// <summary>
/// Computes the difference between the models the embedded spec describes and the models this account is
/// entitled to. The spec refreshes on a schedule, so it lags behind what the account can already bill.
/// </summary>
async Task<RunwayCliModelGapReport> BuildModelGapReportAsync(
    RunwayClient client,
    string runwayVersion,
    CancellationToken cancellationToken)
{
    var organization = await client.Organization.GetOrganizationAsync(
        xRunwayVersion: runwayVersion,
        cancellationToken: cancellationToken).ConfigureAwait(false);

    var entitled = organization.Tier.Models.Keys.ToHashSet(StringComparer.Ordinal);
    var described = RunwayModelSchema.KnownModelIds().ToHashSet(StringComparer.Ordinal);

    // A capability can be an endpoint rather than a model value (the recipes are), so RunwayModelSchema is
    // asked whether it can address the name at all before calling it absent from the spec.
    return new RunwayCliModelGapReport
    {
        SpecModelCount = described.Count,
        AccountModelCount = entitled.Count,
        MissingFromSpec = [.. entitled
            .Where(model => !RunwayModelSchema.IsKnown(model))
            .OrderBy(model => model, StringComparer.Ordinal)],
        EndpointCapabilities = [.. entitled
            .Where(model => !described.Contains(model) && RunwayModelSchema.IsKnown(model))
            .OrderBy(model => model, StringComparer.Ordinal)],
        MissingFromAccount = [.. described
            .Except(entitled, StringComparer.Ordinal)
            .OrderBy(model => model, StringComparer.Ordinal)],
    };
}

Task<int> WriteModelGapJsonAsync(ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var report = await BuildModelGapReportAsync(client, runwayVersion, ct).ConfigureAwait(false);
        Console.WriteLine(RunwayCliModelGap.ToJson(report));
    }, cancellationToken);

Uri? ResolveBaseUri(ParseResult parseResult)
{
    if (parseResult.GetValue(baseUrlOption) is not { Length: > 0 } value)
    {
        return RunwayEnvironment.GetBaseUrl();
    }

    return Uri.TryCreate(value.Trim(), UriKind.Absolute, out var uri) &&
           (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)
        ? uri
        : throw new ArgumentException($"--base-url must be an absolute http or https URL, but was '{value}'.");
}

RunwayClient CreateClient(ParseResult parseResult)
{
    var apiKey =
        parseResult.GetValue(apiKeyOption) is { Length: > 0 } optionValue ? optionValue :
        RunwayEnvironment.GetApiKey() is { Length: > 0 } configuredApiKey ? configuredApiKey :
        RunwayCliAuth.Read() is { Length: > 0 } storedApiKey ? storedApiKey :
        throw new InvalidOperationException("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, run `runway auth set --api-key <key>`, or add a .env file.");

    // --base-url wins over RUNWAY_BASE_URL / .env, which in turn wins over the SDK's production default.
    // The generated `api` command group already honored the env var; the curated commands did not.
    var baseUri = ResolveBaseUri(parseResult);

    return new RunwayClient(apiKey, baseUri: baseUri);
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

static GetDocumentsSort ParseDocumentSort(string? value)
{
    return value is { Length: > 0 }
        ? GetDocumentsSortExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported document sort '{value}'.")
        : GetDocumentsSort.CreatedAt;
}

static GetDocumentsOrder ParseDocumentOrder(string? value)
{
    return value is { Length: > 0 }
        ? GetDocumentsOrderExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported document order '{value}'.")
        : GetDocumentsOrder.Desc;
}

static CreateVoicesRequestFromVoiceFromTextModel ParseVoiceDesignModel(string? value)
{
    return value is { Length: > 0 }
        ? CreateVoicesRequestFromVoiceFromTextModelExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported voice design model '{value}'.")
        : CreateVoicesRequestFromVoiceFromTextModel.ElevenTtvV3;
}

static CreateVoicesPreviewRequestModel ParseVoicePreviewModel(string? value)
{
    return value is { Length: > 0 }
        ? CreateVoicesPreviewRequestModelExtensions.ToEnum(value)
          ?? throw new ArgumentException($"Unsupported voice preview model '{value}'.")
        : CreateVoicesPreviewRequestModel.ElevenTtvV3;
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
