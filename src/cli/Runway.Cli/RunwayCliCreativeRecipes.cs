using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

internal static class RunwayCliCreativeRecipes
{
    public const string ProductPhotoshootKind = "product_photoshoot";
    public const string MarketplaceCardsKind = "marketplace_cards";
    public const string AdVideoKind = "ad_video";

    public const string DefaultImageModel = "gpt_image_2";
    public const string DefaultImageRatio = "1024:1024";
    public const string DefaultImageResolution = "1K";
    public const string DefaultImageQuality = "low";
    public const string DefaultVideoModel = "veo3.1_fast";
    public const string DefaultVideoRatio = "1280:720";
    public const double DefaultVideoDurationSeconds = 4;

    private static readonly string[] ProductPhotoshootModes =
    [
        "product_shot",
        "lifestyle_scene",
        "hero_banner",
        "social_carousel",
        "ad_creative_pack",
        "virtual_model_tryout",
        "conceptual_product",
        "restyle",
    ];

    private static readonly string[] MarketplaceScopes =
    [
        "main",
        "product-images",
        "aplus",
        "full-set",
    ];

    private static readonly string[] AdVideoModes =
    [
        "ugc",
        "unboxing",
        "product_showcase",
        "product_review",
        "tv_spot",
        "virtual_try_on",
    ];

    public static RunwayCliCreativeRecipePlan CreateProductPhotoshootPlan(
        string prompt,
        string[]? referenceImages,
        int? count,
        string? ratio,
        string? model,
        string? mode,
        string? productContext,
        string? brandContext,
        string? quality,
        string? resolution)
    {
        var normalizedMode = NormalizeChoice(mode, "product_shot", ProductPhotoshootModes, "product photoshoot mode");
        var resolvedCount = ValidateCount(count ?? GetDefaultProductPhotoshootCount(normalizedMode), 1, 16, "--count");
        var resolvedRatio = FirstNonEmpty(ratio, DefaultImageRatio)!;
        var resolvedModel = FirstNonEmpty(model, DefaultImageModel)!;
        var resolvedQuality = FirstNonEmpty(quality, DefaultImageQuality);
        var resolvedResolution = FirstNonEmpty(resolution, DefaultImageResolution);
        var references = ToList(referenceImages);
        var labels = ExpandLabels(GetProductPhotoshootLabels(normalizedMode), resolvedCount);
        var jobs = new List<RunwayCliCreativeRecipeJob>(resolvedCount);

        for (var index = 0; index < labels.Count; index++)
        {
            var label = labels[index];
            jobs.Add(new RunwayCliCreativeRecipeJob
            {
                Index = index + 1,
                Count = resolvedCount,
                Label = label,
                Prompt = BuildProductPhotoshootPrompt(
                    prompt,
                    normalizedMode,
                    label,
                    productContext,
                    brandContext,
                    references),
                Model = resolvedModel,
                Ratio = resolvedRatio,
                Quality = resolvedQuality,
                Resolution = resolvedResolution,
                ReferenceImages = [.. references],
            });
        }

        return new RunwayCliCreativeRecipePlan
        {
            Kind = ProductPhotoshootKind,
            Mode = normalizedMode,
            SourcePrompt = prompt,
            Prompt = BuildPlanPromptSummary(prompt, productContext, brandContext),
            Model = resolvedModel,
            Ratio = resolvedRatio,
            Count = resolvedCount,
            Quality = resolvedQuality,
            Resolution = resolvedResolution,
            ReferenceImages = references,
            Notes =
            [
                "Runway-native image recipe for GPT Image 2 or another selected Runway image model.",
                "Prompt structure uses concise sensory detail, camera, lighting, styling, and positive phrasing.",
                "Reference images are treated as product identity and styling anchors when supplied.",
            ],
            Jobs = jobs,
        };
    }

    public static RunwayCliCreativeRecipePlan CreateMarketplaceCardsPlan(
        string prompt,
        string[]? assets,
        int? count,
        string? ratio,
        string? model,
        string? scope,
        string? category,
        string? visualStyle)
    {
        var normalizedScope = NormalizeChoice(scope, "main", MarketplaceScopes, "marketplace card scope");
        var resolvedRatio = FirstNonEmpty(ratio, DefaultImageRatio)!;
        var resolvedModel = FirstNonEmpty(model, DefaultImageModel)!;
        var references = ToList(assets);
        var baseLabels = GetMarketplaceLabels(normalizedScope);
        var resolvedCount = ValidateCount(count ?? baseLabels.Count, 1, 16, "--count");
        var labels = ExpandLabels(baseLabels, resolvedCount);
        var jobs = new List<RunwayCliCreativeRecipeJob>(resolvedCount);

        for (var index = 0; index < labels.Count; index++)
        {
            var label = labels[index];
            jobs.Add(new RunwayCliCreativeRecipeJob
            {
                Index = index + 1,
                Count = resolvedCount,
                Label = label,
                Prompt = BuildMarketplacePrompt(prompt, normalizedScope, label, category, visualStyle, references),
                Model = resolvedModel,
                Ratio = resolvedRatio,
                Quality = DefaultImageQuality,
                Resolution = DefaultImageResolution,
                ReferenceImages = [.. references],
            });
        }

        return new RunwayCliCreativeRecipePlan
        {
            Kind = MarketplaceCardsKind,
            Scope = normalizedScope,
            SourcePrompt = prompt,
            Prompt = BuildPlanPromptSummary(prompt, category, visualStyle),
            Model = resolvedModel,
            Ratio = resolvedRatio,
            Count = resolvedCount,
            Quality = DefaultImageQuality,
            Resolution = DefaultImageResolution,
            Assets = references,
            Notes =
            [
                "Runway-native marketplace-style image prompt bundle; it does not claim marketplace compliance.",
                "Use generated labels to review, edit, or execute each planned card independently.",
                "Asset references are used as product, package, or brand anchors when supplied.",
            ],
            Jobs = jobs,
        };
    }

    public static RunwayCliCreativeRecipePlan CreateAdVideoPlan(
        string prompt,
        string[]? referenceImages,
        int? shots,
        string? ratio,
        string? model,
        string? mode,
        string? style,
        bool audio,
        double? duration)
    {
        var normalizedMode = NormalizeChoice(mode, "ugc", AdVideoModes, "ad video mode");
        var resolvedShots = ValidateCount(shots ?? 1, 1, 6, "--shots");
        var resolvedRatio = FirstNonEmpty(ratio, DefaultVideoRatio)!;
        var resolvedModel = FirstNonEmpty(model, DefaultVideoModel)!;
        var resolvedDuration = duration ?? DefaultVideoDurationSeconds;
        if (resolvedDuration <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(duration), "--duration must be greater than 0.");
        }

        var references = ToList(referenceImages);
        var labels = ExpandLabels(GetAdVideoLabels(normalizedMode), resolvedShots);
        var jobs = new List<RunwayCliCreativeRecipeJob>(resolvedShots);

        for (var index = 0; index < labels.Count; index++)
        {
            var label = labels[index];
            jobs.Add(new RunwayCliCreativeRecipeJob
            {
                Index = index + 1,
                Count = resolvedShots,
                Label = label,
                Prompt = BuildAdVideoPrompt(
                    prompt,
                    normalizedMode,
                    label,
                    index + 1,
                    resolvedShots,
                    style,
                    audio,
                    references),
                Model = resolvedModel,
                Ratio = resolvedRatio,
                DurationSeconds = resolvedDuration,
                Audio = audio,
                ReferenceImages = [.. references],
            });
        }

        return new RunwayCliCreativeRecipePlan
        {
            Kind = AdVideoKind,
            Mode = normalizedMode,
            SourcePrompt = prompt,
            Prompt = BuildPlanPromptSummary(prompt, style, audio ? "with generated audio" : null),
            Model = resolvedModel,
            Ratio = resolvedRatio,
            Count = resolvedShots,
            DurationSeconds = resolvedDuration,
            Audio = audio,
            ReferenceImages = references,
            Notes =
            [
                "Runway-native ad-video wrapper using text-to-video, or image-to-video when reference images are supplied.",
                "Prompts are structured as shot beats with product action, camera movement, lighting, and concise sensory direction.",
                "Runway avatar commands can cover presenter-style videos, but this SDK does not provide Higgsfield-style reusable face-model training.",
            ],
            Jobs = jobs,
        };
    }

    public static string ToJson(RunwayCliCreativeRecipePlan plan)
    {
        var options = new JsonSerializerOptions(RunwayCliCreativeRecipeJsonSerializerContext.Default.Options)
        {
            WriteIndented = true,
        };
        var context = new RunwayCliCreativeRecipeJsonSerializerContext(options);

        return JsonSerializer.Serialize(plan, context.RunwayCliCreativeRecipePlan);
    }

    private static string BuildProductPhotoshootPrompt(
        string prompt,
        string mode,
        string label,
        string? productContext,
        string? brandContext,
        IReadOnlyList<string> references)
    {
        return JoinSentences(
            "Runway GPT Image 2 product photoshoot prompt.",
            $"Subject: {prompt}.",
            $"Mode: {ToDisplay(mode)}.",
            $"Frame label: {ToDisplay(label)}.",
            GetProductPhotoshootDirection(mode, label),
            Optional("Product context", productContext),
            Optional("Brand context", brandContext),
            references.Count > 0
                ? "Use reference images as anchors for product identity, silhouette, materials, color, packaging, and logo placement."
                : null,
            "Compose with clear product readability, a precise camera angle, tactile materials, controlled lighting, and positive phrasing.",
            "Keep props intentional and on-brand, preserve packaging accuracy, and include only requested text or logos.");
    }

    private static string BuildMarketplacePrompt(
        string prompt,
        string scope,
        string label,
        string? category,
        string? visualStyle,
        IReadOnlyList<string> references)
    {
        return JoinSentences(
            "Runway GPT Image 2 marketplace-style image prompt.",
            $"Product: {prompt}.",
            $"Scope: {ToDisplay(scope)}.",
            $"Card label: {ToDisplay(label)}.",
            Optional("Category", category),
            Optional("Visual style", visualStyle),
            GetMarketplaceDirection(label),
            references.Count > 0
                ? "Use supplied assets as anchors for the exact product, packaging, color, and visible brand elements."
                : null,
            "Make the image clear, legible, product-forward, and useful for a commerce asset review.",
            "This is a creative marketplace-style prompt, not a compliance guarantee for any marketplace.");
    }

    private static string BuildAdVideoPrompt(
        string prompt,
        string mode,
        string label,
        int index,
        int count,
        string? style,
        bool audio,
        IReadOnlyList<string> references)
    {
        return JoinSentences(
            $"Runway ad video shot {index.ToString(CultureInfo.InvariantCulture)} of {count.ToString(CultureInfo.InvariantCulture)}.",
            $"Product or offer: {prompt}.",
            $"Mode: {ToDisplay(mode)}.",
            $"Beat: {ToDisplay(label)}.",
            Optional("Style", style),
            GetAdVideoDirection(mode, label, index, count),
            references.Count > 0
                ? "Use reference images as visual anchors for product identity, shape, materials, color, and packaging."
                : null,
            audio
                ? "Include natural production audio cues that match the shot without overpowering the visual."
                : "Design the shot to work silently with visual storytelling.",
            "Use concise sensory detail, positive phrasing, clear camera movement, specific lighting, and a simple readable action.");
    }

    private static string GetProductPhotoshootDirection(string mode, string label)
    {
        return mode switch
        {
            "lifestyle_scene" => "Place the product in an aspirational real-use scene with believable hands, surfaces, and environmental cues.",
            "hero_banner" => "Create a wide premium hero composition with negative space for later layout, strong silhouette, and refined brand atmosphere.",
            "social_carousel" => $"Create a social carousel panel focused on {ToDisplay(label)} with a direct visual hook and clean product readability.",
            "ad_creative_pack" => $"Create an ad creative variation focused on {ToDisplay(label)} with a strong thumb-stopping composition.",
            "virtual_model_tryout" => "Show the product naturally worn, held, or presented by a realistic model while preserving product proportions.",
            "conceptual_product" => "Use a tasteful conceptual set, metaphor, or material world that reinforces the product promise without losing clarity.",
            "restyle" => "Restyle the supplied product image into a fresh campaign look while preserving the recognizable product identity.",
            _ => "Create a clean studio product shot with crisp edges, natural shadows, accurate materials, and a premium commercial finish.",
        };
    }

    private static string GetMarketplaceDirection(string label)
    {
        return label switch
        {
            "main" => "Show the product as the main subject with clean separation, accurate shape, and minimal distractions.",
            "front-angle" => "Show a clear front three-quarter angle that explains size, finish, and primary design details.",
            "detail-closeup" => "Focus on a useful detail close-up with texture, controls, material quality, or packaging specifics.",
            "scale-context" => "Show scale and use context with believable placement, hands, desk, shelf, home, or studio cues as appropriate.",
            "lifestyle-use" => "Show the product actively used in a plausible lifestyle scene with a clear benefit moment.",
            "brand-story" => "Create a brand-story visual that communicates mood, material quality, and product promise.",
            "feature-callout" => "Create a clean feature-focused visual with space for later annotations outside the generated image.",
            "comparison-lifestyle" => "Create a comparison-friendly lifestyle visual with clear before-and-after or problem-solution framing.",
            "usage-sequence" => "Create a sequence-friendly visual that suggests setup, use, or outcome in one readable image.",
            _ => $"Create a marketplace-style card for {ToDisplay(label)} with product clarity and controlled composition.",
        };
    }

    private static string GetAdVideoDirection(string mode, string label, int index, int count)
    {
        var arc = count == 1
            ? "single complete ad beat"
            : index == 1
                ? "opening hook"
                : index == count
                    ? "closing payoff"
                    : "middle proof beat";

        return mode switch
        {
            "unboxing" => $"Show the {arc} for an unboxing sequence: package contact, reveal timing, tactile details, and a satisfying product reveal.",
            "product_showcase" => $"Show the {arc} for a polished product showcase: elegant motion, precise highlights, and a clear product benefit.",
            "product_review" => $"Show the {arc} for a review-style ad: human-scale handling, credible product detail, and a simple evaluation moment.",
            "tv_spot" => $"Show the {arc} for a cinematic TV spot: controlled camera move, premium lighting, and a memorable brand moment.",
            "virtual_try_on" => $"Show the {arc} for a virtual try-on: realistic fit, model movement, natural pose, and product confidence.",
            _ => $"Show the {arc} for a UGC ad: handheld energy, authentic product interaction, clear benefit, and natural room light.",
        };
    }

    private static int GetDefaultProductPhotoshootCount(string mode)
    {
        return mode switch
        {
            "social_carousel" => 4,
            "ad_creative_pack" => 4,
            _ => 1,
        };
    }

    private static IReadOnlyList<string> GetProductPhotoshootLabels(string mode)
    {
        return mode switch
        {
            "social_carousel" => ["hook", "benefit", "detail", "lifestyle"],
            "ad_creative_pack" => ["hero", "problem-solution", "detail", "offer"],
            "lifestyle_scene" => ["lifestyle"],
            "hero_banner" => ["hero-banner"],
            "virtual_model_tryout" => ["model-tryout"],
            "conceptual_product" => ["conceptual"],
            "restyle" => ["restyle"],
            _ => ["studio-product"],
        };
    }

    private static IReadOnlyList<string> GetMarketplaceLabels(string scope)
    {
        return scope switch
        {
            "product-images" => ["front-angle", "detail-closeup", "scale-context", "lifestyle-use"],
            "aplus" => ["brand-story", "feature-callout", "comparison-lifestyle", "usage-sequence"],
            "full-set" => ["main", "front-angle", "detail-closeup", "scale-context", "lifestyle-use", "brand-story", "feature-callout", "comparison-lifestyle", "usage-sequence"],
            _ => ["main"],
        };
    }

    private static IReadOnlyList<string> GetAdVideoLabels(string mode)
    {
        return mode switch
        {
            "unboxing" => ["package-arrival", "opening-reveal", "first-use", "payoff"],
            "product_showcase" => ["hero-intro", "detail-pass", "benefit-demo", "final-beauty"],
            "product_review" => ["review-hook", "hands-on-proof", "favorite-detail", "recommendation"],
            "tv_spot" => ["cinematic-hook", "product-world", "benefit-moment", "end-card-ready"],
            "virtual_try_on" => ["before-try-on", "fit-reveal", "movement-check", "confidence-payoff"],
            _ => ["ugc-hook", "problem", "product-demo", "reaction"],
        };
    }

    private static string NormalizeChoice(
        string? value,
        string defaultValue,
        IReadOnlyList<string> supported,
        string displayName)
    {
        var normalized = FirstNonEmpty(value, defaultValue)!
            .Trim()
            .Replace("-", "_", StringComparison.Ordinal)
            .ToLowerInvariant();

        foreach (var item in supported)
        {
            var comparable = item.Replace("-", "_", StringComparison.Ordinal);
            if (string.Equals(normalized, comparable, StringComparison.Ordinal))
            {
                return item;
            }
        }

        throw new ArgumentException($"Unsupported {displayName} `{value}`. Supported values: {string.Join(", ", supported)}.");
    }

    private static List<string> ExpandLabels(IReadOnlyList<string> labels, int count)
    {
        var result = new List<string>(count);
        for (var index = 0; index < count; index++)
        {
            var label = labels[index % labels.Count];
            result.Add(index < labels.Count
                ? label
                : string.Create(CultureInfo.InvariantCulture, $"{label}-{(index / labels.Count) + 1}"));
        }

        return result;
    }

    private static int ValidateCount(int count, int min, int max, string option)
    {
        if (count < min || count > max)
        {
            throw new ArgumentOutOfRangeException(nameof(count), $"{option} must be between {min.ToString(CultureInfo.InvariantCulture)} and {max.ToString(CultureInfo.InvariantCulture)}.");
        }

        return count;
    }

    private static List<string> ToList(string[]? values)
    {
        return values is { Length: > 0 }
            ? values.Where(static value => !string.IsNullOrWhiteSpace(value)).Select(static value => value.Trim()).ToList()
            : [];
    }

    private static string BuildPlanPromptSummary(string prompt, params string?[] details)
    {
        return JoinSentences([prompt, .. details.Where(static detail => !string.IsNullOrWhiteSpace(detail))]);
    }

    private static string? Optional(string label, string? value)
    {
        return string.IsNullOrWhiteSpace(value) ? null : $"{label}: {value.Trim()}.";
    }

    private static string JoinSentences(params string?[] parts)
    {
        return JoinSentences((IEnumerable<string?>)parts);
    }

    private static string JoinSentences(IEnumerable<string?> parts)
    {
        return string.Join(
            ' ',
            parts.Where(static part => !string.IsNullOrWhiteSpace(part))
                .Select(static part => part!.Trim()));
    }

    private static string? FirstNonEmpty(params string?[] values)
    {
        foreach (var value in values)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value.Trim();
            }
        }

        return null;
    }

    private static string ToDisplay(string value)
    {
        return value.Replace("_", " ", StringComparison.Ordinal)
            .Replace("-", " ", StringComparison.Ordinal);
    }
}

internal sealed class RunwayCliCreativeRecipePlan
{
    public string Kind { get; set; } = string.Empty;

    public string? Mode { get; set; }

    public string? Scope { get; set; }

    public string SourcePrompt { get; set; } = string.Empty;

    public string Prompt { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string Ratio { get; set; } = string.Empty;

    public int Count { get; set; }

    public string? Quality { get; set; }

    public string? Resolution { get; set; }

    public double? DurationSeconds { get; set; }

    public bool? Audio { get; set; }

    public List<string> ReferenceImages { get; set; } = [];

    public List<string> Assets { get; set; } = [];

    public List<string> Notes { get; set; } = [];

    public List<RunwayCliCreativeRecipeJob> Jobs { get; set; } = [];
}

internal sealed class RunwayCliCreativeRecipeJob
{
    public int Index { get; set; }

    public int Count { get; set; }

    public string Label { get; set; } = string.Empty;

    public string Prompt { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string Ratio { get; set; } = string.Empty;

    public string? Quality { get; set; }

    public string? Resolution { get; set; }

    public double? DurationSeconds { get; set; }

    public bool? Audio { get; set; }

    public List<string> ReferenceImages { get; set; } = [];
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(RunwayCliCreativeRecipePlan))]
[JsonSerializable(typeof(RunwayCliCreativeRecipeJob))]
[JsonSerializable(typeof(List<RunwayCliCreativeRecipeJob>))]
internal sealed partial class RunwayCliCreativeRecipeJsonSerializerContext : JsonSerializerContext
{
}
