namespace Runway;

/// <summary>
/// Per-model output-ratio support matrix. Compiled directly from the per-model <c>Ratio</c>
/// enums (<see cref="CreateTextToImageRequestGen4ImageRatio"/>, <see cref="CreateImageToVideoRequestVeo31FastRatio"/>,
/// etc.) so it stays in sync with the spec on regeneration.
///
/// <para>
/// Helps consumers answer questions like "which models support 1:1?" without trial-and-error 400
/// responses, and explains why some aspects (e.g. <c>720:720</c> on <c>gen4_image</c> but not on
/// <c>veo3.1_fast</c>) work for the image surface but get rejected by image-to-video.
/// </para>
/// </summary>
public static class RunwayRatioSupport
{
    private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> Map = Build();

    /// <summary>
    /// Returns every Runway model that accepts the given <paramref name="ratio"/> string
    /// (e.g. <c>"1280:720"</c>) on at least one of its endpoints. Empty when no model supports it.
    /// </summary>
    public static System.Collections.Generic.IReadOnlyList<string> GetSupportingModels(string ratio)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ratio);
        return Map.TryGetValue(ratio, out var models) ? models : [];
    }

    /// <summary>
    /// Whether the given <paramref name="model"/> id (e.g. <c>"veo3.1_fast"</c>) accepts the given
    /// <paramref name="ratio"/> string (e.g. <c>"720:720"</c>) on at least one endpoint.
    /// </summary>
    public static bool IsSupportedBy(string ratio, string model)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(ratio);
        ArgumentException.ThrowIfNullOrWhiteSpace(model);
        return GetSupportingModels(ratio).Contains(model, StringComparer.Ordinal);
    }

    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> Build()
    {
        var pairs = new System.Collections.Generic.List<(string ratio, string model)>();

        // text_to_image
        Add<CreateTextToImageRequestGen4ImageRatio>(pairs, "gen4_image", v => v.ToValueString());
        Add<CreateTextToImageRequestGen4ImageTurboRatio>(pairs, "gen4_image_turbo", v => v.ToValueString());
        Add<CreateTextToImageRequestGptImage2Ratio>(pairs, "gpt_image_2", v => v.ToValueString());
        Add<CreateTextToImageRequestGemini25FlashRatio>(pairs, "gemini_2.5_flash", v => v.ToValueString());
        Add<CreateTextToImageRequestGeminiImage3ProRatio>(pairs, "gemini_image3_pro", v => v.ToValueString());
        // text_to_video
        Add<CreateTextToVideoRequestGen45Ratio>(pairs, "gen4.5", v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo31Ratio>(pairs, "veo3.1", v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo31FastRatio>(pairs, "veo3.1_fast", v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo3Ratio>(pairs, "veo3", v => v.ToValueString());
        // image_to_video
        Add<CreateImageToVideoRequestGen45Ratio>(pairs, "gen4.5", v => v.ToValueString());
        Add<CreateImageToVideoRequestGen4TurboRatio>(pairs, "gen4_turbo", v => v.ToValueString());
        Add<CreateImageToVideoRequestGen3aTurboRatio>(pairs, "gen3a_turbo", v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo31Ratio>(pairs, "veo3.1", v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo31FastRatio>(pairs, "veo3.1_fast", v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo3Ratio>(pairs, "veo3", v => v.ToValueString());
        // video_to_video
        Add<CreateVideoToVideoRequestGen4AlephRatio>(pairs, "gen4_aleph", v => v.ToValueString());
        // character_performance
        Add<CreateCharacterPerformanceRequestActTwoRatio>(pairs, "act_two", v => v.ToValueString());

        return pairs
            .GroupBy(p => p.ratio, StringComparer.Ordinal)
            .ToDictionary(
                g => g.Key,
                g => (System.Collections.Generic.IReadOnlyList<string>)g
                    .Select(p => p.model)
                    .Distinct(StringComparer.Ordinal)
                    .OrderBy(m => m, StringComparer.Ordinal)
                    .ToArray(),
                StringComparer.Ordinal);
    }

    private static void Add<TEnum>(
        System.Collections.Generic.List<(string ratio, string model)> pairs,
        string model,
        System.Func<TEnum, string> toValue)
        where TEnum : struct, Enum
    {
        foreach (var value in Enum.GetValues<TEnum>())
        {
            pairs.Add((toValue(value), model));
        }
    }
}
