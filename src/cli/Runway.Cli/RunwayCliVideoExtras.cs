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
