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
/// <summary>
/// Endpoint families that accept a <c>ratio</c> field. Used by
/// <see cref="RunwayRatioSupport.GetSupportedRatios(string, string)"/> to scope the lookup.
/// </summary>
public static class RunwayRatioEndpoints
{
    /// <summary>POST /v1/text_to_image</summary>
    public const string TextToImage = "text_to_image";

    /// <summary>POST /v1/text_to_video</summary>
    public const string TextToVideo = "text_to_video";

    /// <summary>POST /v1/image_to_video</summary>
    public const string ImageToVideo = "image_to_video";

    /// <summary>POST /v1/video_to_video</summary>
    public const string VideoToVideo = "video_to_video";

    /// <summary>POST /v1/character_performance</summary>
    public const string CharacterPerformance = "character_performance";
}

/// <summary>
/// Per-model output-ratio support matrix. Compiled directly from the per-model <c>Ratio</c>
/// enums so it stays in sync with the spec on regeneration.
/// </summary>
public static class RunwayRatioSupport
{
    // BuildTriples must run before the three lookup tables — declare it first so static-init order
    // (top-to-bottom) initializes the backing field before Build/BuildByModel/BuildByModelEndpoint read it.
    private static readonly System.Collections.Generic.List<(string ratio, string model, string endpoint)> _triples = BuildTriples();
    private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> Map = Build();
    private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> ByModel = BuildByModel();
    private static readonly System.Collections.Generic.Dictionary<(string Model, string Endpoint), System.Collections.Generic.IReadOnlyList<string>> ByModelEndpoint = BuildByModelEndpoint();

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
    /// Returns every output ratio the given <paramref name="model"/> accepts across all its endpoints.
    /// Empty when the model has no enum-backed ratio set in the generated SDK (e.g. audio-only models
    /// or models the client doesn't know about yet).
    /// </summary>
    public static System.Collections.Generic.IReadOnlyList<string> GetSupportedRatios(string model)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(model);
        return ByModel.TryGetValue(model, out var ratios) ? ratios : [];
    }

    /// <summary>
    /// Returns every output ratio the given <paramref name="model"/> accepts on the specific
    /// <paramref name="endpoint"/> (e.g. <c>"text_to_image"</c>, <c>"image_to_video"</c>;
    /// see <see cref="RunwayRatioEndpoints"/>). Empty when the model isn't valid for that endpoint.
    /// </summary>
    public static System.Collections.Generic.IReadOnlyList<string> GetSupportedRatios(string model, string endpoint)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(model);
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        return ByModelEndpoint.TryGetValue((model, endpoint), out var ratios) ? ratios : [];
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

    private static System.Collections.Generic.List<(string ratio, string model, string endpoint)> BuildTriples()
    {
        var triples = new System.Collections.Generic.List<(string ratio, string model, string endpoint)>();

        // text_to_image
        Add<CreateTextToImageRequestGen4ImageRatio>(triples, "gen4_image", RunwayRatioEndpoints.TextToImage, v => v.ToValueString());
        Add<CreateTextToImageRequestGen4ImageTurboRatio>(triples, "gen4_image_turbo", RunwayRatioEndpoints.TextToImage, v => v.ToValueString());
        Add<CreateTextToImageRequestGptImage2Ratio>(triples, "gpt_image_2", RunwayRatioEndpoints.TextToImage, v => v.ToValueString());
        Add<CreateTextToImageRequestGemini25FlashRatio>(triples, "gemini_2.5_flash", RunwayRatioEndpoints.TextToImage, v => v.ToValueString());
        Add<CreateTextToImageRequestGeminiImage3ProRatio>(triples, "gemini_image3_pro", RunwayRatioEndpoints.TextToImage, v => v.ToValueString());
        // text_to_video
        Add<CreateTextToVideoRequestGen45Ratio>(triples, "gen4.5", RunwayRatioEndpoints.TextToVideo, v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo31Ratio>(triples, "veo3.1", RunwayRatioEndpoints.TextToVideo, v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo31FastRatio>(triples, "veo3.1_fast", RunwayRatioEndpoints.TextToVideo, v => v.ToValueString());
        Add<CreateTextToVideoRequestVeo3Ratio>(triples, "veo3", RunwayRatioEndpoints.TextToVideo, v => v.ToValueString());
        // image_to_video
        Add<CreateImageToVideoRequestGen45Ratio>(triples, "gen4.5", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        Add<CreateImageToVideoRequestGen4TurboRatio>(triples, "gen4_turbo", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        Add<CreateImageToVideoRequestGen3aTurboRatio>(triples, "gen3a_turbo", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo31Ratio>(triples, "veo3.1", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo31FastRatio>(triples, "veo3.1_fast", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        Add<CreateImageToVideoRequestVeo3Ratio>(triples, "veo3", RunwayRatioEndpoints.ImageToVideo, v => v.ToValueString());
        // video_to_video
        Add<CreateVideoToVideoRequestGen4AlephRatio>(triples, "gen4_aleph", RunwayRatioEndpoints.VideoToVideo, v => v.ToValueString());
        // character_performance
        Add<CreateCharacterPerformanceRequestActTwoRatio>(triples, "act_two", RunwayRatioEndpoints.CharacterPerformance, v => v.ToValueString());

        return triples;
    }

    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> Build()
    {
        return _triples
            .GroupBy(t => t.ratio, StringComparer.Ordinal)
            .ToDictionary(
                g => g.Key,
                g => (System.Collections.Generic.IReadOnlyList<string>)g
                    .Select(t => t.model)
                    .Distinct(StringComparer.Ordinal)
                    .OrderBy(m => m, StringComparer.Ordinal)
                    .ToArray(),
                StringComparer.Ordinal);
    }

    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> BuildByModel()
    {
        return _triples
            .GroupBy(t => t.model, StringComparer.Ordinal)
            .ToDictionary(
                g => g.Key,
                g => (System.Collections.Generic.IReadOnlyList<string>)g
                    .Select(t => t.ratio)
                    .Distinct(StringComparer.Ordinal)
                    .OrderBy(r => r, StringComparer.Ordinal)
                    .ToArray(),
                StringComparer.Ordinal);
    }

    private static System.Collections.Generic.Dictionary<(string Model, string Endpoint), System.Collections.Generic.IReadOnlyList<string>> BuildByModelEndpoint()
    {
        return _triples
            .GroupBy(t => (t.model, t.endpoint))
            .ToDictionary(
                g => g.Key,
                g => (System.Collections.Generic.IReadOnlyList<string>)g
                    .Select(t => t.ratio)
                    .Distinct(StringComparer.Ordinal)
                    .OrderBy(r => r, StringComparer.Ordinal)
                    .ToArray());
    }

    private static void Add<TEnum>(
        System.Collections.Generic.List<(string ratio, string model, string endpoint)> triples,
        string model,
        string endpoint,
        System.Func<TEnum, string> toValue)
        where TEnum : struct, Enum
    {
        foreach (var value in Enum.GetValues<TEnum>())
        {
            triples.Add((toValue(value), model, endpoint));
        }
    }
}
