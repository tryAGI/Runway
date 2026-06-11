namespace Runway;

/// <summary>
/// Short-named factory helpers for the per-model variants of <c>POST /v1/text_to_video</c>.
/// Each helper builds the model-specific request body and wraps it in the <see cref="CreateTextToVideoRequest"/>
/// discriminated union, so call sites read
/// <c>RunwayTextToVideo.Veo31Fast(prompt, ratio)</c> instead of constructing the full
/// <c>CreateTextToVideoRequestVeo31Fast</c> + <c>CreateTextToVideoRequest</c> chain by hand.
/// </summary>
public static class RunwayTextToVideo
{
    /// <summary>Builds a <c>veo3.1_fast</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest Veo31Fast(
        string promptText,
        CreateTextToVideoRequestVeo31FastRatio ratio,
        bool? audio = null,
        double? duration = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestVeo31Fast
        {
            PromptText = promptText,
            Ratio = ratio,
            Audio = audio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>veo3.1</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest Veo31(
        string promptText,
        CreateTextToVideoRequestVeo31Ratio ratio,
        bool? audio = null,
        double? duration = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestVeo31
        {
            PromptText = promptText,
            Ratio = ratio,
            Audio = audio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>veo3</c> text-to-video request. Duration defaults to 8s when omitted.</summary>
    public static CreateTextToVideoRequest Veo3(
        string promptText,
        CreateTextToVideoRequestVeo3Ratio ratio,
        double? duration = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        var body = new CreateTextToVideoRequestVeo3
        {
            PromptText = promptText,
            Ratio = ratio,
        };
        if (duration is { } d)
        {
            body.Duration = d;
        }

        return new CreateTextToVideoRequest(body);
    }

    /// <summary>Builds a <c>gen4.5</c> text-to-video request. <paramref name="duration"/> is required for this model.</summary>
    public static CreateTextToVideoRequest Gen45(
        string promptText,
        CreateTextToVideoRequestGen45Ratio ratio,
        int duration,
        int? seed = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestGen45
        {
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
            Seed = seed,
        });
    }
}

/// <summary>
/// Short-named factory helpers for the per-model variants of <c>POST /v1/image_to_video</c>.
/// Each helper takes a single HTTPS/Runway/data URI for the prompt image and wraps it in the
/// model-specific request body and the <see cref="CreateImageToVideoRequest"/> discriminated union.
/// For multi-frame inputs (first + last frame), construct the underlying
/// <c>CreateImageToVideoRequest...</c> type directly.
/// </summary>
public static class RunwayImageToVideo
{
    /// <summary>Builds a <c>veo3.1_fast</c> image-to-video request.</summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static CreateImageToVideoRequest Veo31Fast(
        string promptImageUri,
        CreateImageToVideoRequestVeo31FastRatio ratio,
        string? promptText = null,
        bool? audio = null,
        double? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestVeo31Fast
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>(promptImageUri),
            Ratio = ratio,
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>veo3.1</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Veo31(
        string promptImageUri,
        CreateImageToVideoRequestVeo31Ratio ratio,
        string? promptText = null,
        bool? audio = null,
        double? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestVeo31
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestVeo31PromptImagePromptImage>>(promptImageUri),
            Ratio = ratio,
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>veo3</c> image-to-video request. Duration defaults to 8s when omitted.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Veo3(
        string promptImageUri,
        CreateImageToVideoRequestVeo3Ratio ratio,
        string? promptText = null,
        double? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        var body = new CreateImageToVideoRequestVeo3
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestVeo3PromptImagePromptImage>>(promptImageUri),
            Ratio = ratio,
            PromptText = promptText,
        };
        if (duration is { } d)
        {
            body.Duration = d;
        }

        return new CreateImageToVideoRequest(body);
    }

    /// <summary>Builds a <c>gen4.5</c> image-to-video request. <paramref name="promptText"/> and <paramref name="duration"/> are required for this model.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Gen45(
        string promptImageUri,
        string promptText,
        CreateImageToVideoRequestGen45Ratio ratio,
        int duration,
        int? seed = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestGen45
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestGen45PromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
            Seed = seed,
        });
    }

    /// <summary>Builds a <c>gen4_turbo</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Gen4Turbo(
        string promptImageUri,
        CreateImageToVideoRequestGen4TurboRatio ratio,
        string? promptText = null,
        int? duration = null,
        int? seed = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestGen4Turbo
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>(promptImageUri),
            Ratio = ratio,
            PromptText = promptText,
            Duration = duration,
            Seed = seed,
        });
    }

    /// <summary>Builds a <c>seedance2</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Seedance2(
        string promptImageUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateImageToVideoRequestSeedance2Ratio? ratio = null,
        global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance2ReferenceAudioItem>? referenceAudio = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestSeedance2
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance2PromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            ReferenceAudio = referenceAudio,
        });
    }

    /// <summary>Builds a <c>seedance2_fast</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Seedance2Fast(
        string promptImageUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateImageToVideoRequestSeedance2FastRatio? ratio = null,
        global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance2FastReferenceAudioItem>? referenceAudio = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestSeedance2Fast
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance2FastPromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            ReferenceAudio = referenceAudio,
        });
    }
}

/// <summary>
/// Short-named factory helpers for <c>POST /v1/video_to_video</c>.
/// </summary>
public static class RunwayVideoToVideo
{
    /// <summary>
    /// Builds an <c>aleph2</c> video-to-video request from an input video URI and a prompt.
    /// </summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static CreateVideoToVideoRequest Aleph2(
        string videoUri,
        string promptText,
        int? seed = null,
        CreateVideoToVideoRequestVariant1ContentModeration? contentModeration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(videoUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestVariant1
        {
            VideoUri = videoUri,
            PromptText = promptText,
            Seed = seed,
            ContentModeration = contentModeration,
        });
    }

    /// <summary>
    /// Builds an <c>aleph2</c> video-to-video request from an input video URI and a prompt.
    /// </summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static CreateVideoToVideoRequest Gen4Aleph(
        string videoUri,
        string promptText,
        int? seed = null,
        CreateVideoToVideoRequestVariant1ContentModeration? contentModeration = null)
#pragma warning restore CA1054
    {
        return Aleph2(videoUri, promptText, seed, contentModeration);
    }
}
