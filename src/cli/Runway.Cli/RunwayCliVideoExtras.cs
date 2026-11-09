/// <summary>
/// The per-model video generation knobs that are not part of every model variant: reference inputs
/// (images, videos, audio), aleph2 keyframes, and the steering/delivery options. Carried as one value so
/// adding a Runway capability does not mean threading another parameter through every call site.
/// </summary>
internal sealed record RunwayCliVideoExtras
{
    /// <summary>Image references (`references`), e.g. characters, products, or style plates.</summary>
    public string[]? ReferenceImages { get; init; }

    /// <summary>Video references (`referenceVideos`) used as additional motion/context.</summary>
    public string[]? ReferenceVideos { get; init; }

    /// <summary>Audio references (`referenceAudio`) the model can drive the output with.</summary>
    public string[]? ReferenceAudio { get; init; }

    /// <summary>aleph2 timed guidance stills, each `&lt;image&gt;@&lt;seconds&gt;` or `&lt;image&gt;@&lt;percent&gt;%`.</summary>
    public string[]? Keyframes { get; init; }

    /// <summary>What to avoid in the output (veo3.1 family).</summary>
    public string? NegativePrompt { get; init; }

    /// <summary>Output resolution tier for models that size by resolution instead of ratio.</summary>
    public string? Resolution { get; init; }

    /// <summary>seedance2_5 video-to-video mode: `reference` or `extend`.</summary>
    public string? Mode { get; init; }

    /// <summary>Delivery container/colour pipeline (gen4.5, aleph2): mp4, prores, HDR, EXR, PNG sequence.</summary>
    public string? OutputFormat { get; init; }

    /// <summary>ProRes tier when `--output-format` selects a ProRes mezzanine.</summary>
    public string? ProresProfile { get; init; }

    /// <summary>aleph2 reframing target, e.g. `9:16`.</summary>
    public string? TargetAspectRatio { get; init; }

    /// <summary>No extras — every option left at the model default.</summary>
    public static RunwayCliVideoExtras None { get; } = new();
}

/// <summary>
/// The per-model image generation knobs that only some `text_to_image` variants declare. Gated against
/// the embedded spec so a flag the chosen model does not accept fails with the list of models that do,
/// rather than being sent into an `additionalProperties: false` schema.
/// </summary>
internal sealed record RunwayCliImageExtras
{
    /// <summary>Output file format for the seedream models: `png` or `jpeg`.</summary>
    public string? OutputFormat { get; init; }

    /// <summary>Background treatment for `gpt_image_2`: `opaque` or `auto`.</summary>
    public string? Background { get; init; }

    /// <summary>Live web search for current brand/trend/event context (seedream models).</summary>
    public bool? Grounding { get; init; }

    /// <summary>Edit the single reference image directly instead of treating it as a style reference (`grok_imagine_image_2`).</summary>
    public bool? Edit { get; init; }

    /// <summary>No extras — every option left at the model default.</summary>
    public static RunwayCliImageExtras None { get; } = new();
}

/// <summary>
/// The per-model audio knobs on `text_to_speech`, `sound_effect` and `voice_dubbing`. The CLI used to
/// hardcode one model per endpoint, so the expressiveness controls of `eleven_v3` and the rate/format
/// controls of `seed_audio` were unreachable. Each is gated against the embedded spec.
/// </summary>
internal sealed record RunwayCliAudioExtras
{
    /// <summary>Reference clips for `seed_audio` sound effects, addressed in the prompt as @Audio1..@Audio3.</summary>
    public string[]? ReferenceAudios { get; init; }

    /// <summary>Output container for `seed_audio`: wav, mp3, or ogg_opus.</summary>
    public string? OutputFormat { get; init; }

    /// <summary>BCP-47 language code (`eleven_v3`).</summary>
    public string? LanguageCode { get; init; }

    /// <summary>Text normalization for `eleven_v3`: auto, on, or off.</summary>
    public string? ApplyTextNormalization { get; init; }

    /// <summary>Output sample rate in Hz for `seed_audio`: 8000, 16000, 24000, 32000, 44100, or 48000.</summary>
    public int? SampleRate { get; init; }

    /// <summary>Speech rate for `seed_audio`, -50 to 100.</summary>
    public int? SpeechRate { get; init; }

    /// <summary>Pitch shift for `seed_audio`, -12 to 12 semitones.</summary>
    public int? PitchRate { get; init; }

    /// <summary>Loudness adjustment for `seed_audio`, -50 to 100.</summary>
    public int? LoudnessRate { get; init; }

    /// <summary>Speaker count hint for voice dubbing.</summary>
    public int? NumSpeakers { get; init; }

    /// <summary>Seed for reproducible `eleven_v3` output.</summary>
    public int? Seed { get; init; }

    /// <summary>Voice stability for `eleven_v3`, 0 to 1.</summary>
    public double? Stability { get; init; }

    /// <summary>Style exaggeration for `eleven_v3`, 0 to 1.</summary>
    public double? Style { get; init; }

    /// <summary>Speaking speed for `eleven_v3`, 0.7 to 1.2.</summary>
    public double? Speed { get; init; }

    /// <summary>Similarity to the reference voice for `eleven_v3`, 0 to 1.</summary>
    public double? SimilarityBoost { get; init; }

    /// <summary>Speaker boost for `eleven_v3`.</summary>
    public bool? UseSpeakerBoost { get; init; }

    /// <summary>Keep the original speakers' voices instead of cloning them (voice dubbing).</summary>
    public bool? DisableVoiceCloning { get; init; }

    /// <summary>Drop the background audio bed when dubbing.</summary>
    public bool? DropBackgroundAudio { get; init; }

    /// <summary>No extras — every option left at the model default.</summary>
    public static RunwayCliAudioExtras None { get; } = new();
}
