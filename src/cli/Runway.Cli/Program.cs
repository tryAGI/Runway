using System.CommandLine;
using System.CommandLine.Parsing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Runway;

const string DefaultRunwayVersion = "2024-11-06";

var apiKeyOption = new Option<string?>("--api-key", ["-k"])
{
    Description = "Runway API key. Defaults to RUNWAY_API_KEY, RUNWAYML_API_SECRET, or .env.",
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
    Description = "Prompt text. Multiple words are joined, so quotes are optional.",
    Arity = ArgumentArity.OneOrMore,
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
    Description = "Image model: gemini-2.5-flash, gemini-image3-pro, gpt-image-2, gen4-image, or gen4-image-turbo.",
    DefaultValueFactory = _ => "gemini-2.5-flash",
};

var imageResolutionOption = new Option<string?>("--resolution")
{
    Description = "Deprecated GPT Image 2 resolution tier. Current API ignores this; use --ratio for output size.",
};

var imageQualityOption = new Option<string?>("--quality")
{
    Description = "Optional GPT Image 2 quality tier: low, medium, or high.",
};

var videoModelOption = new Option<string?>("--model")
{
    Description = "Video model. Text: gen4.5, veo3.1, veo3.1-fast, veo3. Image: gen4.5, gen4-turbo, gen3a-turbo, veo3.1, veo3.1-fast, veo3.",
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
        Guid taskId;

        if (json is { Length: > 0 })
        {
            taskId = await PostGenerationJsonAsync(
                client,
                runwayVersion,
                "v1/text_to_video",
                await RunwayCliGeneration.ReadJsonTextAsync(json, ct).ConfigureAwait(false),
                ct).ConfigureAwait(false);
        }
        else if (promptImages is { Length: > 0 } || lastImage is { Length: > 0 })
        {
            RunwayModelSchema.EnsureModelSupportsEndpoint(model ?? string.Empty, "image_to_video");
            var request = await RunwayCliGeneration.CreateImageToVideoRequestAsync(
                prompt,
                model,
                promptImages,
                lastImage,
                ratio,
                duration,
                seed,
                !parseResult.GetValue(noAudioOption),
                publicFigureThreshold,
                ct).ConfigureAwait(false);
            var response = await client.StartGenerating.CreateImageToVideoAsync(
                request: request,
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false);

            taskId = response.Id;
        }
        else
        {
            RunwayModelSchema.EnsureModelSupportsEndpoint(model ?? string.Empty, "text_to_video");
            var request = RunwayCliGeneration.CreateTextToVideoRequest(
                prompt,
                model,
                ratio,
                duration,
                seed,
                !parseResult.GetValue(noAudioOption),
                publicFigureThreshold);
            var response = await client.StartGenerating.CreateTextToVideoAsync(
                request: request,
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
    publicFigureThresholdOption,
    shortVideoPlanOnlyOption,
    shortVideoNoInteractiveOption,
    shortVideoPlannerOption,
    shortVideoPlannerModelOption,
    shortVideoPlannerToolsOption,
    shortVideoPlannerTimeoutSecondsOption,
    shortVideoNoConcatOption,
    ffmpegOption,
    noWaitOption,
    pollIntervalOption,
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
        options = CreateShortVideoOptions(parseResult, output.SegmentDirectory);
        var plannerOptions = CreateShortVideoPlannerOptions(parseResult);
        var brief = await ResolveMarketingBriefAsync(parseResult, cancellationToken).ConfigureAwait(false);
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

    Console.Error.WriteLine($"Short-video planner: {plannerName}");

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
    publicFigureThresholdOption,
    shortVideoNoConcatOption,
    ffmpegOption,
    noWaitOption,
    pollIntervalOption,
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
    var options = CreateShortVideoOptionsFromPlan(parseResult, output.SegmentDirectory, plan);
    return await RunShortVideoPlanAsync(parseResult, plan, options, output, cancellationToken).ConfigureAwait(false);
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
    seedOption,
    referenceImageOption2,
    referenceSubjectOption,
    soulIdReferenceOption,
    outputCountOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
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
        var seed = parseResult.GetValue(seedOption);
        var json = parseResult.GetValue(jsonOption);
        Guid taskId;
        if (json is { Length: > 0 })
        {
            taskId = await PostGenerationJsonAsync(
                client,
                runwayVersion,
                "v1/text_to_image",
                await RunwayCliGeneration.ReadJsonTextAsync(json, ct).ConfigureAwait(false),
                ct).ConfigureAwait(false);
        }
        else if (normalizedImageModel == "gpt_image_2")
        {
            var response = await client.StartGenerating.CreateGptImage2TextToImageAsync(
                request: await RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
                    prompt,
                    ratio,
                    referenceImages,
                    parseResult.GetValue(imageResolutionOption),
                    parseResult.GetValue(imageQualityOption),
                    parseResult.GetValue(outputCountOption),
                    ct).ConfigureAwait(false),
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false);
            taskId = response.Id;
        }
        else
        {
            var response = await client.StartGenerating.CreateTextToImageAsync(
                request: await RunwayCliGeneration.CreateTextToImageRequestAsync(
                    prompt,
                    imageModel,
                    ratio,
                    referenceImages,
                    parseResult.GetValue(referenceSubjectOption) ?? "object",
                    seed,
                    parseResult.GetValue(outputCountOption),
                    parseResult.GetValue(publicFigureThresholdOption),
                    ct).ConfigureAwait(false),
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
            defaultExtension: ".png",
            stemPrefix: "runway-image",
            cancellationToken: ct).ConfigureAwait(false);

        foreach (var path in downloaded)
        {
            Console.WriteLine(path);
        }
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
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(textToVideoCommand);
textToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        if (json is not { Length: > 0 })
        {
            var t2vModel = parseResult.GetValue(videoModelOption) ?? string.Empty;
            RunwayModelSchema.EnsureModelSupportsEndpoint(t2vModel, "text_to_video");
            RunwayModelSchema.EnsureRequiredParametersProvided(t2vModel, "text_to_video", new Dictionary<string, bool>
            {
                ["promptText"] = !string.IsNullOrWhiteSpace(RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToVideoPromptArgument))),
                ["ratio"] = true,
                ["duration"] = parseResult.GetValue(generationDurationOption).HasValue,
            });
        }

        var taskId = json is { Length: > 0 }
            ? await PostGenerationJsonAsync(client, runwayVersion, "v1/text_to_video", await RunwayCliGeneration.ReadJsonTextAsync(json, ct).ConfigureAwait(false), ct).ConfigureAwait(false)
            : (await client.StartGenerating.CreateTextToVideoAsync(
                request: RunwayCliGeneration.CreateTextToVideoRequest(
                    RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToVideoPromptArgument)),
                    parseResult.GetValue(videoModelOption),
                    parseResult.GetValue(videoRatioOption) ?? "1280:720",
                    parseResult.GetValue(generationDurationOption),
                    parseResult.GetValue(seedOption),
                    !parseResult.GetValue(noAudioOption),
                    parseResult.GetValue(publicFigureThresholdOption)),
                xRunwayVersion: runwayVersion,
                cancellationToken: ct).ConfigureAwait(false)).Id;

        await HandleGenerationTaskAsync(client, runwayVersion, taskId, parseResult, ".mp4", "runway-video", ct).ConfigureAwait(false);
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
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(imageToVideoCommand);
imageToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        if (json is not { Length: > 0 })
        {
            var i2vModel = parseResult.GetValue(videoModelOption) ?? string.Empty;
            var i2vPrompt = string.Join(' ', parseResult.GetValue(optionalVideoPromptArgument) ?? []).Trim();
            var i2vImages = MergeSoulIdImages(parseResult, parseResult.GetValue(promptImageOption));
            RunwayModelSchema.EnsureModelSupportsEndpoint(i2vModel, "image_to_video");
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
                ct).ConfigureAwait(false);

        var response = await client.StartGenerating.CreateImageToVideoAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp4", "runway-video", ct).ConfigureAwait(false);
    }, cancellationToken));

var sourceVideoOption = new Option<string?>("--video")
{
    Description = "Local path, HTTPS URL, Runway URI, or data URI video input.",
};

var videoToVideoCommand = new Command("video-to-video", "Start a video-to-video generation task with gen4_aleph.")
{
    videoToVideoPromptArgument,
    sourceVideoOption,
    referenceImageOption2,
    outputOption,
    videoRatioOption,
    seedOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(videoToVideoCommand);
videoToVideoCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateVideoToVideoRequest>(json, ct).ConfigureAwait(false)
            : await RunwayCliGeneration.CreateVideoToVideoRequestAsync(
                RunwayCliGeneration.JoinPrompt(parseResult.GetValue(videoToVideoPromptArgument)),
                RequireOption(parseResult, sourceVideoOption),
                parseResult.GetValue(videoRatioOption),
                parseResult.GetValue(referenceImageOption2),
                parseResult.GetValue(seedOption),
                parseResult.GetValue(publicFigureThresholdOption),
                ct).ConfigureAwait(false);

        var response = await client.StartGenerating.CreateVideoToVideoAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp4", "runway-video", ct).ConfigureAwait(false);
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
    outputOption,
    videoRatioOption,
    seedOption,
    bodyControlOption,
    expressionIntensityOption,
    publicFigureThresholdOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
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
                parseResult.GetValue(videoRatioOption),
                parseResult.GetValue(seedOption),
                parseResult.GetValue(bodyControlOption),
                parseResult.GetValue(expressionIntensityOption),
                parseResult.GetValue(publicFigureThresholdOption),
                ct).ConfigureAwait(false);

        var response = await client.StartGenerating.CreateCharacterPerformanceAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp4", "runway-video", ct).ConfigureAwait(false);
    }, cancellationToken));

var loopOption = new Option<bool>("--loop")
{
    Description = "Loop the generated sound effect.",
};

var soundEffectCommand = new Command("sound-effect", "Start an eleven_text_to_sound_v2 sound effect task.")
{
    soundEffectPromptArgument,
    outputOption,
    generationDurationOption,
    loopOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(soundEffectCommand);
soundEffectCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("eleven_text_to_sound_v2", "sound_effect");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateSoundEffectRequest>(json, ct).ConfigureAwait(false)
            : RunwayCliGeneration.CreateSoundEffectRequest(
                RunwayCliGeneration.JoinPrompt(parseResult.GetValue(soundEffectPromptArgument)),
                parseResult.GetValue(generationDurationOption),
                parseResult.GetValue(loopOption));

        var response = await client.StartGenerating.CreateSoundEffectAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp3", "runway-audio", ct).ConfigureAwait(false);
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
    Description = "Runway voice preset ID.",
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
                parseResult.GetValue(speechVoicePresetOption) ?? "clara",
                parseResult.GetValue(runwayVoiceIdOption),
                parseResult.GetValue(removeBackgroundNoiseOption),
                ct).ConfigureAwait(false);

        var response = await client.StartGenerating.CreateSpeechToSpeechAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp3", "runway-speech", ct).ConfigureAwait(false);
    }, cancellationToken));

var textToSpeechCommand = new Command("text-to-speech", "Start an eleven_multilingual_v2 text-to-speech task.")
{
    textToSpeechPromptArgument,
    speechVoicePresetOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
};
rootCommand.Subcommands.Add(textToSpeechCommand);
textToSpeechCommand.SetAction((ParseResult parseResult, CancellationToken cancellationToken) =>
    RunWithClientAsync(parseResult, async (client, runwayVersion, ct) =>
    {
        RunwayModelSchema.EnsureModelSupportsEndpoint("eleven_multilingual_v2", "text_to_speech");
        var json = parseResult.GetValue(jsonOption);
        var request = json is { Length: > 0 }
            ? await RunwayCliGeneration.ReadGeneratedJsonAsync<CreateTextToSpeechRequest>(json, ct).ConfigureAwait(false)
            : RunwayCliGeneration.CreateTextToSpeechRequest(
                RunwayCliGeneration.JoinPrompt(parseResult.GetValue(textToSpeechPromptArgument)),
                parseResult.GetValue(speechVoicePresetOption) ?? "clara");

        var response = await client.StartGenerating.CreateTextToSpeechAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp3", "runway-speech", ct).ConfigureAwait(false);
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
    jsonOption,
    noWaitOption,
    pollIntervalOption,
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
                ct).ConfigureAwait(false);

        var response = await client.StartGenerating.CreateVoiceDubbingAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp3", "runway-dubbing", ct).ConfigureAwait(false);
    }, cancellationToken));

var voiceIsolationCommand = new Command("voice-isolation", "Start an eleven_voice_isolation task.")
{
    audioOption,
    outputOption,
    jsonOption,
    noWaitOption,
    pollIntervalOption,
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

        var response = await client.StartGenerating.CreateVoiceIsolationAsync(
            request: request,
            xRunwayVersion: runwayVersion,
            cancellationToken: ct).ConfigureAwait(false);

        await HandleGenerationTaskAsync(client, runwayVersion, response.Id, parseResult, ".mp3", "runway-voice", ct).ConfigureAwait(false);
    }, cancellationToken));

var modelsCommand = new Command("models", "List Runway API endpoint families and model IDs supported by the CLI.");
rootCommand.Subcommands.Add(modelsCommand);
modelsCommand.SetAction(_ =>
{
    Console.WriteLine("Video generation:");
    Console.WriteLine("  text-to-video: gen4.5, veo3.1, veo3.1_fast, veo3");
    Console.WriteLine("  short-video: multi-shot text-to-video orchestration over gen4.5, veo3.1, veo3.1_fast, veo3");
    Console.WriteLine("  image-to-video: gen4.5, gen4_turbo, gen3a_turbo, veo3.1, veo3.1_fast, veo3");
    Console.WriteLine("  video-to-video: gen4_aleph");
    Console.WriteLine("  character-performance: act_two");
    Console.WriteLine();
    Console.WriteLine("Image generation:");
    Console.WriteLine("  text-to-image: gen4_image_turbo, gen4_image, gemini_image3_pro, gpt_image_2, gemini_2.5_flash");
    Console.WriteLine();
    Console.WriteLine("Audio generation:");
    Console.WriteLine("  sound-effect: eleven_text_to_sound_v2");
    Console.WriteLine("  speech-to-speech: eleven_multilingual_sts_v2");
    Console.WriteLine("  text-to-speech: eleven_multilingual_v2");
    Console.WriteLine("  voice-dubbing: eleven_voice_dubbing");
    Console.WriteLine("  voice-isolation: eleven_voice_isolation");
    Console.WriteLine();
    Console.WriteLine("Realtime and avatar:");
    Console.WriteLine("  realtime sessions, avatar videos: gwm1_avatars");
    Console.WriteLine("  voice design: eleven_ttv_v3, eleven_multilingual_ttv_v2");
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
            await UploadEphemeralFileAsync(response, file, ct).ConfigureAwait(false);
        }

        WriteJson(response);
    }, cancellationToken));

var voiceCommand = new Command("voice", "Manage custom voices and voice previews.");
rootCommand.Subcommands.Add(voiceCommand);

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
        var response = await client.Organization.CreateOrganizationUsageAsync(
            xRunwayVersion: runwayVersion,
            startDate: parseResult.GetValue(startDateOption),
            beforeDate: parseResult.GetValue(beforeDateOption),
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

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);

static async Task<Guid> PostGenerationJsonAsync(
    RunwayClient client,
    string runwayVersion,
    string relativePath,
    string json,
    CancellationToken cancellationToken)
{
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
    Guid taskId,
    ParseResult parseResult,
    string defaultExtension,
    string stemPrefix,
    CancellationToken cancellationToken)
{
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
        cancellationToken: cancellationToken).ConfigureAwait(false);

    var downloaded = await task.DownloadOutputsAsync(
        output: parseResult.GetValue(outputOption),
        defaultExtension: defaultExtension,
        stemPrefix: stemPrefix,
        cancellationToken: cancellationToken).ConfigureAwait(false);

    foreach (var path in downloaded)
    {
        Console.WriteLine(path);
    }
}

RunwayShortVideoOptions CreateShortVideoOptions(
    ParseResult parseResult,
    string segmentOutput)
{
    return new RunwayShortVideoOptions
    {
        ShotCount = parseResult.GetValue(shortVideoShotCountOption),
        ShotDurationSeconds = parseResult.GetValue(generationDurationOption) ?? 4,
        Model = parseResult.GetValue(videoModelOption) ?? RunwayShortVideoOptions.DefaultModel,
        Ratio = parseResult.GetValue(shortVideoRatioOption) ?? RunwayShortVideoOptions.DefaultRatio,
        Audio = parseResult.GetValue(shortVideoAudioOption),
        Seed = parseResult.GetValue(seedOption),
        Style = parseResult.GetValue(shortVideoStyleOption),
        PublicFigureThreshold = parseResult.GetValue(publicFigureThresholdOption),
        WaitForCompletion = !parseResult.GetValue(noWaitOption),
        DownloadOutputs = !parseResult.GetValue(noWaitOption),
        Output = segmentOutput,
        PollInterval = TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
    };
}

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
            await Console.Error.WriteLineAsync(string.Create(
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
        await Console.Error.WriteLineAsync(string.Create(
            System.Globalization.CultureInfo.InvariantCulture,
            $"Updated {Path.Combine(directory, RunwayCliMarketingBriefStore.FileName)}.")).ConfigureAwait(false);
    }

    return collected;
}

RunwayShortVideoOptions CreateShortVideoOptionsFromPlan(
    ParseResult parseResult,
    string segmentOutput,
    RunwayShortVideoPlan plan)
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
        WaitForCompletion = !parseResult.GetValue(noWaitOption),
        DownloadOutputs = !parseResult.GetValue(noWaitOption),
        Output = segmentOutput,
        PollInterval = TimeSpan.FromSeconds(parseResult.GetValue(pollIntervalOption)),
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
        await Console.Error.WriteLineAsync($"Short-video plan JSON: {planPath}").ConfigureAwait(false);

        WriteShortVideoPlan(plan);

        var result = await client.CreateShortVideoAsync(
            plan,
            options,
            runwayVersion,
            progress: new RunwayCliInlineProgress<RunwayShortVideoProgress>(WriteShortVideoProgress),
            cancellationToken: ct).ConfigureAwait(false);

        if (parseResult.GetValue(noWaitOption))
        {
            foreach (var shot in result.Shots)
            {
                Console.WriteLine(shot.TaskId);
            }

            return;
        }

        if (parseResult.GetValue(shortVideoNoConcatOption))
        {
            foreach (var path in result.DownloadedFiles)
            {
                Console.WriteLine(path);
            }

            return;
        }

        var concat = await RunwayCliShortVideo.TryConcatAsync(
            result.DownloadedFiles,
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

        foreach (var path in result.DownloadedFiles)
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

        foreach (var job in plan.Jobs)
        {
            Guid taskId;
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
                        ct).ConfigureAwait(false),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: ct).ConfigureAwait(false);
                taskId = response.Id;
            }
            else
            {
                var response = await client.StartGenerating.CreateTextToImageAsync(
                    request: await RunwayCliGeneration.CreateTextToImageRequestAsync(
                        job.Prompt,
                        job.Model,
                        job.Ratio,
                        job.ReferenceImages.ToArray(),
                        "object",
                        null,
                        1,
                        parseResult.GetValue(publicFigureThresholdOption),
                        ct).ConfigureAwait(false),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: ct).ConfigureAwait(false);
                taskId = response.Id;
            }

            await HandleGenerationTaskAsync(
                client,
                runwayVersion,
                taskId,
                parseResult,
                ".png",
                CreateRecipeStem(plan, job, name),
                ct).ConfigureAwait(false);
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

        foreach (var job in plan.Jobs)
        {
            Guid taskId;
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
                        ct).ConfigureAwait(false),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: ct).ConfigureAwait(false);
                taskId = response.Id;
            }
            else
            {
                var response = await client.StartGenerating.CreateTextToVideoAsync(
                    request: RunwayCliGeneration.CreateTextToVideoRequest(
                        job.Prompt,
                        job.Model,
                        job.Ratio,
                        job.DurationSeconds,
                        parseResult.GetValue(seedOption),
                        job.Audio == true,
                        parseResult.GetValue(publicFigureThresholdOption)),
                    xRunwayVersion: runwayVersion,
                    cancellationToken: ct).ConfigureAwait(false);
                taskId = response.Id;
            }

            await HandleGenerationTaskAsync(
                client,
                runwayVersion,
                taskId,
                parseResult,
                ".mp4",
                CreateRecipeStem(plan, job, name),
                ct).ConfigureAwait(false);
        }
    }, cancellationToken);
}

static void WriteShortVideoPlan(RunwayShortVideoPlan plan)
{
    Console.Error.WriteLine("Short-video plan:");
    foreach (var shot in plan.Shots)
    {
        Console.Error.WriteLine($"  {shot.Index}. {shot.Title}");
        Console.Error.WriteLine($"     {shot.Beat}");
    }
}

static void WriteCreativeRecipePlan(RunwayCliCreativeRecipePlan plan)
{
    Console.Error.WriteLine($"{ToDisplayName(plan.Kind)} plan:");
    foreach (var job in plan.Jobs)
    {
        Console.Error.WriteLine($"  {job.Index}. {job.Label}");
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
        Console.Error.WriteLine($"Auto-name resolved to: {resolved}");
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
        Console.Error.WriteLine($"Auto-name resolved to: {resolved}");
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
            Console.Error.WriteLine($"Starting shot {progress.Shot.Index}/{progress.Shot.Count}: {progress.Shot.Title}");
            break;

        case RunwayShortVideoProgressStage.TaskCreated:
            Console.Error.WriteLine($"Shot {progress.Shot.Index} task ID: {progress.TaskId}");
            break;

        case RunwayShortVideoProgressStage.TaskUpdated:
            if (progress.Task is { } task)
            {
                WriteTaskProgress(task);
            }

            break;

        case RunwayShortVideoProgressStage.ShotDownloaded:
            Console.Error.WriteLine($"Downloaded shot {progress.Shot.Index}.");
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

async Task UploadEphemeralFileAsync(
    CreateUploadsResponse upload,
    string file,
    CancellationToken cancellationToken)
{
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
                ["presetId"] = parseResult.GetValue(realtimePresetAvatarOption) ?? "influencer",
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
        return 1;
    }
}

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

RunwayClient CreateClient(ParseResult parseResult)
{
    var apiKey =
        parseResult.GetValue(apiKeyOption) is { Length: > 0 } optionValue ? optionValue :
        RunwayEnvironment.GetApiKey() is { Length: > 0 } configuredApiKey ? configuredApiKey :
        RunwayCliAuth.Read() is { Length: > 0 } storedApiKey ? storedApiKey :
        throw new InvalidOperationException("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, run `runway auth set --api-key <key>`, or add a .env file.");

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
