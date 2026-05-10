#pragma warning disable CA1308 // Slug is intentionally lowercase ASCII for stable URL/JSON identifiers.

namespace Runway;

/// <summary>
/// Coarse-grained routing categories for the built-in workflows shipped with this SDK.
/// </summary>
public enum BuiltInWorkflowCategory
{
    /// <summary>Take one source image, return restyled image(s) of the same subject.</summary>
    PhotoRestyle,

    /// <summary>Place an existing subject into a new context (background, mockup, label).</summary>
    SceneComposition,

    /// <summary>Turn text or one image into a multi-shot piece (panels, b-roll, storyboard, manga, film).</summary>
    StorySequence,

    /// <summary>Generate fresh assets (multi-view characters, item variants) from a description.</summary>
    CharacterItem,

    /// <summary>Restyle a clip; iterate prompt-engineering choices.</summary>
    VideoSandbox,

    /// <summary>Default category for workflows that aren't part of the curated built-in set.</summary>
    Uncategorized,
}

/// <summary>
/// Friendly names / slugs / descriptions for <see cref="BuiltInWorkflowCategory"/>.
/// </summary>
public static class BuiltInWorkflowCategoryExtensions
{
    /// <summary>
    /// Human-readable display name for the category (e.g. "Photo / Identity Restyle").
    /// </summary>
    public static string DisplayName(this BuiltInWorkflowCategory category) => category switch
    {
        BuiltInWorkflowCategory.PhotoRestyle => "Photo / Identity Restyle",
        BuiltInWorkflowCategory.SceneComposition => "Composition / Scene",
        BuiltInWorkflowCategory.StorySequence => "Story / Sequence",
        BuiltInWorkflowCategory.CharacterItem => "Character & Item Generation",
        BuiltInWorkflowCategory.VideoSandbox => "Video & Prompt Sandbox",
        BuiltInWorkflowCategory.Uncategorized => "Other / User-registered",
        _ => category.ToString(),
    };

    /// <summary>
    /// Stable lowercase slug for the category (e.g. "photo-restyle").
    /// </summary>
    public static string Slug(this BuiltInWorkflowCategory category) => category switch
    {
        BuiltInWorkflowCategory.PhotoRestyle => "photo-restyle",
        BuiltInWorkflowCategory.SceneComposition => "scene-composition",
        BuiltInWorkflowCategory.StorySequence => "story-sequence",
        BuiltInWorkflowCategory.CharacterItem => "character-item",
        BuiltInWorkflowCategory.VideoSandbox => "video-sandbox",
        BuiltInWorkflowCategory.Uncategorized => "uncategorized",
        _ => category.ToString().ToLowerInvariant(),
    };

    /// <summary>
    /// One-line description of when to reach for the category.
    /// </summary>
    public static string Description(this BuiltInWorkflowCategory category) => category switch
    {
        BuiltInWorkflowCategory.PhotoRestyle => "Take one source image, return restyled image(s) of the same subject (color/fabric/hairstyle/pose/outfit/variations).",
        BuiltInWorkflowCategory.SceneComposition => "Place an existing subject into a new context (background, mockup, label-on-bottle).",
        BuiltInWorkflowCategory.StorySequence => "Turn text or one image into a multi-shot piece (panels, b-roll, storyboard, manga, film).",
        BuiltInWorkflowCategory.CharacterItem => "Generate fresh assets (multi-view characters, item variants) from a description.",
        BuiltInWorkflowCategory.VideoSandbox => "Restyle a clip; iterate prompt-engineering choices.",
        BuiltInWorkflowCategory.Uncategorized => "Default category for workflows that aren't part of the curated built-in set.",
        _ => string.Empty,
    };

    /// <summary>
    /// Resolve a user-supplied category token (enum name OR display slug, case-insensitive) to the enum value.
    /// Returns null if no match.
    /// </summary>
    public static BuiltInWorkflowCategory? TryResolve(string token)
    {
        if (string.IsNullOrWhiteSpace(token)) return null;
        if (Enum.TryParse<BuiltInWorkflowCategory>(token, ignoreCase: true, out var byName))
        {
            return byName;
        }
        foreach (var c in Enum.GetValues<BuiltInWorkflowCategory>())
        {
            if (string.Equals(c.Slug(), token, StringComparison.OrdinalIgnoreCase))
            {
                return c;
            }
        }
        return null;
    }
}

/// <summary>
/// The kind of value a workflow input expects.
/// </summary>
public enum BuiltInWorkflowInputKind
{
    /// <summary>An image asset (uploaded or referenced by URI).</summary>
    Image,
    /// <summary>A video asset.</summary>
    Video,
    /// <summary>An audio asset.</summary>
    Audio,
    /// <summary>A free-form text prompt.</summary>
    Prompt,
    /// <summary>A numeric primitive.</summary>
    Number,
    /// <summary>A boolean primitive.</summary>
    Boolean,
}

/// <summary>
/// One curated input on a built-in workflow.
/// </summary>
/// <param name="Flag">CLI-style flag identifier (e.g. <c>"--image"</c>). Use this as the key when supplying values.</param>
/// <param name="NodeId">The workflow graph node ID this input maps to. Used internally when building the request body.</param>
/// <param name="OutputKey">The node output key (e.g. <c>"image"</c> / <c>"prompt"</c>). Internal.</param>
/// <param name="Kind">The kind of value expected.</param>
/// <param name="Required">Whether the workflow can run without this input.</param>
/// <param name="Description">Human-readable description (for help text or routing prose).</param>
/// <param name="DefaultPreview">Excerpt of the workflow's authored default value, when one exists.</param>
public sealed record BuiltInWorkflowInput(
    string Flag,
    Guid NodeId,
    string OutputKey,
    BuiltInWorkflowInputKind Kind,
    bool Required,
    string Description,
    string? DefaultPreview);

/// <summary>
/// One built-in workflow command shipped with this SDK release.
/// </summary>
/// <param name="CommandName">Stable kebab-case identifier (e.g. <c>"ai-hair-salon"</c>).</param>
/// <param name="WorkflowId">The published workflow's GUID; passed to <c>POST /v1/workflows/{id}</c>.</param>
/// <param name="DisplayName">Human-readable workflow title from the dev portal.</param>
/// <param name="Description">One-paragraph "what this workflow does" summary.</param>
/// <param name="Category">Routing category.</param>
/// <param name="Inputs">User-facing inputs curated from the workflow's exposed nodes.</param>
public sealed record BuiltInWorkflow(
    string CommandName,
    Guid WorkflowId,
    string DisplayName,
    string Description,
    BuiltInWorkflowCategory Category,
    IReadOnlyList<BuiltInWorkflowInput> Inputs);

/// <summary>
/// Strongly-typed identifier for each built-in workflow. Useful for switch statements, lookup tables,
/// and IntelliSense discovery (<c>BuiltInWorkflowKind.AiHairSalon</c>). Maps to <see cref="BuiltInWorkflow.CommandName"/>
/// 1:1 via <see cref="BuiltInWorkflows.FindByKind"/>.
/// </summary>
public enum BuiltInWorkflowKind
{
    /// <summary>Fabric / Color / Texture Swap — restyle a product image with up to four change prompts.</summary>
    FabricColorTextureSwap,
    /// <summary>Video to Video — Style Transfer — restyle a clip with a single style prompt.</summary>
    VideoStyleTransfer,
    /// <summary>AI Hair Salon — restyle a portrait with a new hairstyle and optional background.</summary>
    AiHairSalon,
    /// <summary>Virtual Try On — put a garment from one image onto a person from another.</summary>
    VirtualTryOn,
    /// <summary>JSON to Manga — render a structured page-by-page storyboard JSON into manga panels.</summary>
    JsonToManga,
    /// <summary>B-Roll Generator — generate b-roll clips from one source frame.</summary>
    BRollGenerator,
    /// <summary>Storyboard to Film — convert a script + character reference into rendered film shots.</summary>
    StoryboardToFilm,
    /// <summary>Story Panels — two parallel triptychs (16:9 + 9:16) from a source image and a sequence prompt.</summary>
    StoryPanels,
    /// <summary>Storyboard Creator — expand a one-line story into a multi-shot storyboard.</summary>
    StoryboardCreator,
    /// <summary>Character Creator — generate a character with multiple expressions, poses, and a 360 turntable.</summary>
    CharacterCreator,
    /// <summary>Image Variations — produce free-form variations of one source image.</summary>
    ImageVariations,
    /// <summary>Mockup Generator — composite one product image into four advertising mockup placements.</summary>
    MockupGenerator,
    /// <summary>Build Your System Prompt — iterate subject + style through image and video generators.</summary>
    BuildSystemPrompt,
    /// <summary>Asset Reversioning — generate restyled / reversioned variants of one source image.</summary>
    AssetReversioning,
    /// <summary>Backplate Generator — remove the foreground subject and re-composite into a new scene.</summary>
    BackplateGenerator,
    /// <summary>Wine Label Generator — composite labels onto a bottle and produce a final hero video.</summary>
    WineLabelGenerator,
    /// <summary>Game Item Generator — four rarity variants of an item description plus an animated icon.</summary>
    GameItemGenerator,
    /// <summary>Human Pose Replication — re-render a character image in a target reference pose.</summary>
    HumanPoseReplication,
}
