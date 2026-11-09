namespace Runway;

/// <summary>
/// Builds the per-model reference lists shared by the video endpoints. Every Runway video model that
/// accepts references takes a plain list of <c>{ "uri": ... }</c> objects for image references and
/// <c>{ "type": ..., "uri": ... }</c> objects for video/audio references, but AutoSDK emits a distinct
/// CLR type per model variant. These helpers keep the per-model factories below to one line each.
/// </summary>
internal static class RunwayReferenceMapper
{
    internal static global::System.Collections.Generic.IList<T>? Map<T>(
        global::System.Collections.Generic.IEnumerable<string>? uris,
        global::System.Func<string, T> factory)
    {
        if (uris is null)
        {
            return null;
        }

        var items = new global::System.Collections.Generic.List<T>();
        foreach (var uri in uris)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(uri);
            items.Add(factory(uri));
        }

        return items.Count == 0 ? null : items;
    }
}

/// <summary>
/// Timed guidance images for the <c>aleph2</c> video-to-video restyle (<c>keyframes</c>). Place a still at
/// an absolute offset with <see cref="AtSeconds"/> or at a fraction of the clip with <see cref="AtFraction"/>.
/// </summary>
public static class RunwayVideoKeyframes
{
    /// <summary>Places a guidance image at an absolute offset, in seconds, into the input video.</summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static AnyOf<CreateVideoToVideoRequestVariant1KeyframeVariant1, CreateVideoToVideoRequestVariant1KeyframeVariant2> AtSeconds(
        string imageUri,
        double seconds,
        CreateVideoToVideoRequestVariant1KeyframeVariant1Range? range = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(imageUri);

        return new AnyOf<CreateVideoToVideoRequestVariant1KeyframeVariant1, CreateVideoToVideoRequestVariant1KeyframeVariant2>(
            new CreateVideoToVideoRequestVariant1KeyframeVariant1
            {
                Uri = imageUri,
                Seconds = seconds,
                Range = range,
            });
    }

    /// <summary>Places a guidance image at a fraction (0..1) of the input video's duration.</summary>
#pragma warning disable CA1054
    public static AnyOf<CreateVideoToVideoRequestVariant1KeyframeVariant1, CreateVideoToVideoRequestVariant1KeyframeVariant2> AtFraction(
        string imageUri,
        double at,
        CreateVideoToVideoRequestVariant1KeyframeVariant2Range? range = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(imageUri);

        return new AnyOf<CreateVideoToVideoRequestVariant1KeyframeVariant1, CreateVideoToVideoRequestVariant1KeyframeVariant2>(
            new CreateVideoToVideoRequestVariant1KeyframeVariant2
            {
                Uri = imageUri,
                At = at,
                Range = range,
            });
    }
}

/// <summary>
/// Short-named factory helpers for the per-model variants of <c>POST /v1/text_to_video</c>.
/// Each helper builds the model-specific request body and wraps it in the <see cref="CreateTextToVideoRequest"/>
/// discriminated union, so call sites read
/// <c>RunwayTextToVideo.Veo31Fast(prompt, ratio)</c> instead of constructing the full
/// <c>CreateTextToVideoRequestVeo31Fast</c> + <c>CreateTextToVideoRequest</c> chain by hand.
/// Reference inputs are taken as plain URI strings (HTTPS, <c>runway://</c>, or <c>data:</c>).
/// </summary>
public static class RunwayTextToVideo
{
    /// <summary>Builds a <c>veo3.1_fast</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest Veo31Fast(
        string promptText,
        CreateTextToVideoRequestVeo31FastRatio ratio,
        bool? audio = null,
        double? duration = null,
        string? negativePrompt = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestVeo31Fast
        {
            PromptText = promptText,
            Ratio = ratio,
            Audio = audio,
            Duration = duration,
            NegativePrompt = negativePrompt,
        });
    }

    /// <summary>Builds a <c>veo3.1</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest Veo31(
        string promptText,
        CreateTextToVideoRequestVeo31Ratio ratio,
        bool? audio = null,
        double? duration = null,
        string? negativePrompt = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestVeo31
        {
            PromptText = promptText,
            Ratio = ratio,
            Audio = audio,
            Duration = duration,
            NegativePrompt = negativePrompt,
        });
    }

    /// <summary>
    /// Builds a <c>gen4.5</c> text-to-video request. <paramref name="duration"/> is required for this model.
    /// Pass <paramref name="outputFormat"/> for ProRes, PNG sequence, or HDR delivery instead of the default MP4.
    /// </summary>
    public static CreateTextToVideoRequest Gen45(
        string promptText,
        CreateTextToVideoRequestGen45Ratio ratio,
        int duration,
        int? seed = null,
        CreateTextToVideoRequestGen45OutputFormat? outputFormat = null,
        CreateTextToVideoRequestGen45ProresProfile? proresProfile = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestGen45
        {
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
            Seed = seed,
            OutputFormat = outputFormat,
            ProresProfile = proresProfile,
        });
    }

    /// <summary>Builds a <c>hailuo3</c> (MiniMax H3) text-to-video request. Accepts up to 9 image references.</summary>
    public static CreateTextToVideoRequest Hailuo3(
        string promptText,
        CreateTextToVideoRequestHailuo3Ratio? ratio = null,
        CreateTextToVideoRequestHailuo3Resolution? resolution = null,
        int? duration = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestHailuo3
        {
            PromptText = promptText,
            Ratio = ratio,
            Resolution = resolution,
            Duration = duration,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestHailuo3Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestHailuo3ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestHailuo3ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>happyhorse_1_0</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest HappyHorse10(
        string promptText,
        CreateTextToVideoRequestHappyhorse10Ratio? ratio = null,
        int? duration = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestHappyhorse10
        {
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>seedance2</c> text-to-video request. Accepts up to 9 image references.</summary>
    public static CreateTextToVideoRequest Seedance2(
        string promptText,
        bool? audio = null,
        int? duration = null,
        CreateTextToVideoRequestSeedance2Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestSeedance2
        {
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestSeedance2Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestSeedance2ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestSeedance2ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_fast</c> text-to-video request. Accepts up to 9 image references.</summary>
    public static CreateTextToVideoRequest Seedance2Fast(
        string promptText,
        bool? audio = null,
        int? duration = null,
        CreateTextToVideoRequestSeedance2FastRatio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestSeedance2Fast
        {
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestSeedance2FastReference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestSeedance2FastReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestSeedance2FastReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_mini</c> text-to-video request. Accepts up to 9 image references.</summary>
    public static CreateTextToVideoRequest Seedance2Mini(
        string promptText,
        bool? audio = null,
        int? duration = null,
        CreateTextToVideoRequestSeedance2MiniRatio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestSeedance2Mini
        {
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestSeedance2MiniReference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestSeedance2MiniReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestSeedance2MiniReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>
    /// Builds a <c>seedance2_5</c> text-to-video request. This model accepts up to 30 image references,
    /// 10 video references, and 10 audio references, and <paramref name="promptText"/> is optional when
    /// references carry the intent.
    /// </summary>
    public static CreateTextToVideoRequest Seedance25(
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateTextToVideoRequestSeedance25Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        return new CreateTextToVideoRequest(new CreateTextToVideoRequestSeedance25
        {
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestSeedance25Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestSeedance25ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestSeedance25ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>gemini_omni_flash</c> text-to-video request.</summary>
    public static CreateTextToVideoRequest GeminiOmniFlash(
        string promptText,
        CreateTextToVideoRequestGeminiOmniFlashRatio? ratio = null,
        int? duration = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestGeminiOmniFlash
        {
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
        });
    }

    /// <summary>
    /// Builds a <c>grok_imagine_1_5</c> text-to-video request. Up to 7 image references can be addressed
    /// from the prompt as <c>[Image 1]</c>, <c>[Image 2]</c>, and so on; audio references require at least
    /// one image reference.
    /// </summary>
    public static CreateTextToVideoRequest GrokImagine15(
        string promptText,
        CreateTextToVideoRequestGrokImagine15Ratio? ratio = null,
        CreateTextToVideoRequestGrokImagine15Resolution? resolution = null,
        int? duration = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestGrokImagine15
        {
            PromptText = promptText,
            Ratio = ratio,
            Resolution = resolution,
            Duration = duration,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestGrokImagine15Reference { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestGrokImagine15ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>wan3</c> text-to-video request. Accepts up to 10 image references.</summary>
    public static CreateTextToVideoRequest Wan3(
        string promptText,
        bool? audio = null,
        int? duration = null,
        CreateTextToVideoRequestWan3Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateTextToVideoRequest(new CreateTextToVideoRequestWan3
        {
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateTextToVideoRequestWan3Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateTextToVideoRequestWan3ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateTextToVideoRequestWan3ReferenceAudioItem { Uri = uri }),
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
        double? duration = null,
        string? negativePrompt = null)
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
            NegativePrompt = negativePrompt,
        });
    }

    /// <summary>Builds a <c>veo3.1</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Veo31(
        string promptImageUri,
        CreateImageToVideoRequestVeo31Ratio ratio,
        string? promptText = null,
        bool? audio = null,
        double? duration = null,
        string? negativePrompt = null)
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
            NegativePrompt = negativePrompt,
        });
    }

    /// <summary>
    /// Builds a <c>gen4.5</c> image-to-video request. <paramref name="promptText"/> and
    /// <paramref name="duration"/> are required for this model. Pass <paramref name="outputFormat"/> for
    /// ProRes, PNG sequence, or HDR delivery instead of the default MP4.
    /// </summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Gen45(
        string promptImageUri,
        string promptText,
        CreateImageToVideoRequestGen45Ratio ratio,
        int duration,
        int? seed = null,
        CreateImageToVideoRequestGen45OutputFormat? outputFormat = null,
        CreateImageToVideoRequestGen45ProresProfile? proresProfile = null)
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
            OutputFormat = outputFormat,
            ProresProfile = proresProfile,
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

    /// <summary>Builds a <c>hailuo3</c> (MiniMax H3) image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Hailuo3(
        string promptImageUri,
        string promptText,
        CreateImageToVideoRequestHailuo3Ratio? ratio = null,
        CreateImageToVideoRequestHailuo3Resolution? resolution = null,
        int? duration = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestHailuo3
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<object>>(promptImageUri),
            PromptText = promptText,
            Ratio = ratio,
            Resolution = resolution,
            Duration = duration,
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestHailuo3ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>happyhorse_1_0</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest HappyHorse10(
        string promptImageUri,
        string? promptText = null,
        CreateImageToVideoRequestHappyhorse10Resolution? resolution = null,
        int? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestHappyhorse10
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Resolution = resolution,
            Duration = duration,
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
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
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
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestSeedance2ReferenceAudioItem { Uri = uri }),
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
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
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
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestSeedance2FastReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_mini</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Seedance2Mini(
        string promptImageUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateImageToVideoRequestSeedance2MiniRatio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestSeedance2Mini
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance2MiniPromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestSeedance2MiniReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_5</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Seedance25(
        string promptImageUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateImageToVideoRequestSeedance25Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestSeedance25
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestSeedance25PromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestSeedance25ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>gemini_omni_flash</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest GeminiOmniFlash(
        string promptImageUri,
        string? promptText = null,
        CreateImageToVideoRequestGeminiOmniFlashRatio? ratio = null,
        int? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestGeminiOmniFlash
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Ratio = ratio,
            Duration = duration,
        });
    }

    /// <summary>Builds a <c>grok_imagine_1_5</c> image-to-video request.</summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest GrokImagine15(
        string promptImageUri,
        string? promptText = null,
        CreateImageToVideoRequestGrokImagine15Resolution? resolution = null,
        int? duration = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestGrokImagine15
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>(promptImageUri),
            PromptText = promptText,
            Resolution = resolution,
            Duration = duration,
        });
    }

    /// <summary>
    /// Builds a <c>wan3</c> image-to-video request. <paramref name="promptText"/> is required for this model,
    /// which also accepts up to 5 video and 5 audio references alongside the prompt image.
    /// </summary>
#pragma warning disable CA1054
    public static CreateImageToVideoRequest Wan3(
        string promptImageUri,
        string promptText,
        bool? audio = null,
        int? duration = null,
        CreateImageToVideoRequestWan3Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptImageUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateImageToVideoRequest(new CreateImageToVideoRequestWan3
        {
            PromptImage = new AnyOf<string?, global::System.Collections.Generic.IList<object>>(promptImageUri),
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateImageToVideoRequestWan3ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateImageToVideoRequestWan3ReferenceAudioItem { Uri = uri }),
        });
    }
}

/// <summary>
/// Short-named factory helpers for the per-model variants of <c>POST /v1/video_to_video</c>.
/// </summary>
public static class RunwayVideoToVideo
{
    /// <summary>
    /// Builds an <c>aleph2</c> video-to-video request from an input video URI and a prompt.
    /// Pass <paramref name="keyframes"/> (built with <see cref="RunwayVideoKeyframes"/>) to pin the restyle
    /// to specific stills, and <paramref name="targetAspectRatio"/> to reframe the output (the per-model
    /// <c>ratio</c> field is deprecated for this endpoint).
    /// </summary>
#pragma warning disable CA1054 // Runway accepts HTTPS URLs, runway:// URIs, and data: URIs interchangeably.
    public static CreateVideoToVideoRequest Aleph2(
        string videoUri,
        string promptText,
        int? seed = null,
        CreateVideoToVideoRequestVariant1ContentModeration? contentModeration = null,
        CreateVideoToVideoRequestVariant1TargetAspectRatio? targetAspectRatio = null,
        CreateVideoToVideoRequestVariant1OutputFormat? outputFormat = null,
        CreateVideoToVideoRequestVariant1ProresProfile? proresProfile = null,
        global::System.Collections.Generic.IEnumerable<AnyOf<CreateVideoToVideoRequestVariant1KeyframeVariant1, CreateVideoToVideoRequestVariant1KeyframeVariant2>>? keyframes = null)
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
            TargetAspectRatio = targetAspectRatio,
            OutputFormat = outputFormat,
            ProresProfile = proresProfile,
            Keyframes = keyframes is null ? null : [.. keyframes],
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

    /// <summary>Builds a <c>hailuo3</c> (MiniMax H3) video-to-video request. Accepts up to 9 image references.</summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest Hailuo3(
        string promptVideoUri,
        string promptText,
        CreateVideoToVideoRequestHailuo3Ratio? ratio = null,
        CreateVideoToVideoRequestHailuo3Resolution? resolution = null,
        int? duration = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptVideoUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestHailuo3
        {
            PromptVideo = promptVideoUri,
            PromptText = promptText,
            Ratio = ratio,
            Resolution = resolution,
            Duration = duration,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestHailuo3Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateVideoToVideoRequestHailuo3ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateVideoToVideoRequestHailuo3ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2</c> video-to-video request. Accepts up to 9 image references.</summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest Seedance2(
        string promptVideoUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateVideoToVideoRequestSeedance2Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptVideoUri);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestSeedance2
        {
            PromptVideo = promptVideoUri,
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestSeedance2Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateVideoToVideoRequestSeedance2ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateVideoToVideoRequestSeedance2ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_fast</c> video-to-video request. Accepts up to 9 image references.</summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest Seedance2Fast(
        string promptVideoUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateVideoToVideoRequestSeedance2FastRatio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptVideoUri);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestSeedance2Fast
        {
            PromptVideo = promptVideoUri,
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestSeedance2FastReference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateVideoToVideoRequestSeedance2FastReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateVideoToVideoRequestSeedance2FastReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>seedance2_mini</c> video-to-video request. Accepts up to 9 image references.</summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest Seedance2Mini(
        string promptVideoUri,
        string? promptText = null,
        bool? audio = null,
        int? duration = null,
        CreateVideoToVideoRequestSeedance2MiniRatio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptVideoUri);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestSeedance2Mini
        {
            PromptVideo = promptVideoUri,
            PromptText = promptText,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestSeedance2MiniReference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateVideoToVideoRequestSeedance2MiniReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateVideoToVideoRequestSeedance2MiniReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>
    /// Builds a <c>seedance2_5</c> video-to-video request. <paramref name="mode"/> selects whether the input
    /// video is used as a style/content reference or extended, and the model accepts up to 30 image references.
    /// </summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest Seedance25(
        string promptVideoUri,
        string? promptText = null,
        CreateVideoToVideoRequestSeedance25Mode? mode = null,
        bool? audio = null,
        int? duration = null,
        CreateVideoToVideoRequestSeedance25Ratio? ratio = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceVideoUris = null,
        global::System.Collections.Generic.IEnumerable<string>? referenceAudioUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(promptVideoUri);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestSeedance25
        {
            PromptVideo = promptVideoUri,
            PromptText = promptText,
            Mode = mode,
            Audio = audio,
            Duration = duration,
            Ratio = ratio,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestSeedance25Reference { Uri = uri }),
            ReferenceVideos = RunwayReferenceMapper.Map(referenceVideoUris, static uri => new CreateVideoToVideoRequestSeedance25ReferenceVideo { Uri = uri }),
            ReferenceAudio = RunwayReferenceMapper.Map(referenceAudioUris, static uri => new CreateVideoToVideoRequestSeedance25ReferenceAudioItem { Uri = uri }),
        });
    }

    /// <summary>Builds a <c>gemini_omni_flash</c> video-to-video request. Accepts up to 5 image references.</summary>
#pragma warning disable CA1054
    public static CreateVideoToVideoRequest GeminiOmniFlash(
        string videoUri,
        string promptText,
        global::System.Collections.Generic.IEnumerable<string>? referenceImageUris = null)
#pragma warning restore CA1054
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(videoUri);
        ArgumentException.ThrowIfNullOrWhiteSpace(promptText);

        return new CreateVideoToVideoRequest(new CreateVideoToVideoRequestGeminiOmniFlash
        {
            VideoUri = videoUri,
            PromptText = promptText,
            References = RunwayReferenceMapper.Map(referenceImageUris, static uri => new CreateVideoToVideoRequestGeminiOmniFlashReference { Uri = uri }),
        });
    }
}
