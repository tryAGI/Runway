using System.Reflection;
using System.Text.Json;

namespace Runway;

/// <summary>
/// Static catalog of the built-in workflow commands shipped with this SDK release.
/// Each entry is materialized at startup from the corresponding embedded graph fixture
/// (<c>Fixtures/workflows/&lt;command&gt;.json</c>) so that workflow-author edits flow through
/// to the SDK on the next fixture refresh without touching this list.
/// </summary>
public static class BuiltInWorkflows
{
    /// <summary>
    /// View of the raw selection list (one entry per built-in). Useful for granular drift tests
    /// that materialize each selection individually and report which one breaks. Production
    /// callers consume <see cref="All"/> instead.
    /// </summary>
    public static IReadOnlyList<BuiltInWorkflowSelection> BuiltInSelections => Selections;

    private static readonly BuiltInWorkflowSelection[] Selections =
    [
        new("fabric-color-texture-swap.json", "fabric-color-texture-swap",
            "Run the published Fabric/Color/Texture Swap workflow with one source image and up to four 'Specifics of Product' change prompts. Returns four restyled images.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--image",    Guid.Parse("7381d0bb-4120-47ce-bf29-9daee9f3c6c6"), "Source product image. Local file path, https URL, runway:// URI, or data: URI."),
                new("--change-1", Guid.Parse("1f3f4dfa-8b05-49fb-86ca-cc7b2510434f"), "First change prompt. Omit to keep the workflow's authored default."),
                new("--change-2", Guid.Parse("74f561f3-a9cf-476f-844b-8e1be86018e8"), "Second change prompt."),
                new("--change-3", Guid.Parse("14ecf515-e134-4115-88c7-9359892f8795"), "Third change prompt."),
                new("--change-4", Guid.Parse("e2c2ec29-d26c-4547-947c-88be1da832ba"), "Fourth change prompt."),
            ]),
        new("video-style-transfer.json", "video-style-transfer",
            "Run the published Video Style Transfer workflow with one source video and an optional style prompt. Returns the restyled video.",
            BuiltInWorkflowCategory.VideoSandbox,
            [
                new("--video", Guid.Parse("2ad7872c-94ce-431b-87ab-245454d685dc"), "Source video. Local file path, https URL, runway:// URI, or data: URI."),
                new("--style", Guid.Parse("e1f923c4-464c-46d8-8ddc-3883814872e8"), "Visual style prompt. Omit to keep the workflow's authored default (modern cel-shaded anime)."),
            ]),
        new("ai-hair-salon.json", "ai-hair-salon",
            "Run the published AI Hair Salon workflow on one source portrait. Supply a hairstyle description and an optional background prompt. Returns four restyled looks.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--image",      Guid.Parse("62f5924c-4644-45a1-bec7-e175b89041fb"), "Source portrait of the person whose hairstyle should be restyled."),
                new("--hairstyle",  Guid.Parse("01d921be-fd98-4bb4-8614-c2040dceeb2b"), "Hairstyle to apply. The workflow internally fans out to render four variations of this style."),
                new("--background", Guid.Parse("d8a51b53-9974-4939-9e82-a49aa3136f8b"), "Background context applied to every render (e.g. 'plain seamless studio'). Omit to keep the workflow default."),
            ]),
        new("virtual-try-on.json", "virtual-try-on",
            "Run the published Virtual Try On workflow with one person photo and one garment photo. Returns the person wearing the garment in the described scene.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--person",  Guid.Parse("9f1fbba1-1b74-4083-add2-5ea30f3cd875"), "Source portrait of the person who should be wearing the garment."),
                new("--garment", Guid.Parse("b1ea2b9a-6948-4462-a63e-0ec24ad3c6df"), "Garment / clothing item to put on the person."),
                new("--scene",   Guid.Parse("a98c112d-660c-4c74-84a7-fe472e1b0a2e"), "Scene description (where the person is wearing the garment)."),
            ]),
        new("json-to-manga.json", "json-to-manga",
            "Run the published JSON to Manga workflow. Provide a structured page-by-page storyboard JSON and a character reference image; the workflow returns generated manga panels.",
            BuiltInWorkflowCategory.StorySequence,
            [
                new("--character",  Guid.Parse("d2c821d2-4adb-4629-9307-0606b4e55433"), "Character reference image for consistent identity across panels."),
                new("--storyboard", Guid.Parse("d0cebe4a-6b1b-40b1-b1c1-15b572cb984c"), "Page-by-page storyboard JSON (or @path / -). Defaults to the workflow's authored 8-page sample."),
            ]),
        new("b-roll-generator.json", "b-roll-generator",
            "Run the published B-Roll Generator workflow with one input image. Optionally supply b-roll shot prompts and a per-shot motion prompt.",
            BuiltInWorkflowCategory.StorySequence,
            [
                new("--image",  Guid.Parse("3f1afd78-a646-4edc-8362-47147db8f516"), "Source scene image used to seed b-roll generation."),
                new("--b-roll", Guid.Parse("cedf44b4-d10e-41e1-8378-6c3deb468d71"), "Description of the b-roll shots to generate from the source image."),
                new("--motion", Guid.Parse("125f99e8-b2ce-444e-9ca7-7a3db681cb66"), "Per-shot motion / animation hint applied to each generated b-roll clip."),
            ]),
        new("storyboard-to-film.json", "storyboard-to-film",
            "Run the published Storyboard to Film workflow. Provide a script (logline / treatment / scene text) and a character reference; the workflow returns rendered film shots.",
            BuiltInWorkflowCategory.StorySequence,
            [
                new("--character", Guid.Parse("97e75574-59ba-41e6-8c35-2eacc0f1dff4"), "Character reference image for consistent identity across shots."),
                new("--script",    Guid.Parse("e6e3c617-73bc-4d2a-8eec-5dfc40acd05d"), "Story script: logline, treatment, or scene-by-scene text. Pass @path or - to read from a file/stdin."),
                new("--style",     Guid.Parse("c0ee3288-f978-4ccb-b4f5-ae1ebb7d3ecd"), "Visual style applied across the storyboard shots."),
            ]),
        new("story-panels.json", "story-panels",
            "Run the published Story Panels workflow. Generates two parallel triptychs (16:9 horizontal + 9:16 vertical) from a source image and an input prompt; returns the panel sequence.",
            BuiltInWorkflowCategory.StorySequence,
            [
                new("--horizontal-image",  Guid.Parse("34b890a3-c361-4ebc-8adf-625c6775553d"), "Source image used for the 16:9 horizontal triptych pipeline."),
                new("--vertical-image",    Guid.Parse("b9e00b2c-832a-42cb-8ecc-a3ba2ff86b95"), "Source image used for the 9:16 vertical triptych pipeline."),
                new("--horizontal-prompt", Guid.Parse("a5d27447-1294-41c7-a2e3-704a720d1138"), "Sequence prompt for the 16:9 panels (e.g. 'New shots in the sequence')."),
                new("--vertical-prompt",   Guid.Parse("e824cfae-a838-4ddf-a820-8476cd095484"), "Sequence prompt for the 9:16 panels (e.g. 'New shots in the sequence showing forward progress')."),
            ]),
        new("storyboard-creator.json", "storyboard-creator",
            "Run the published Storyboard Creator workflow. Provide a one-line story prompt and the workflow expands it into a storyboard.",
            BuiltInWorkflowCategory.StorySequence,
            [
                new("--prompt", Guid.Parse("e06b9e1d-4a28-432d-9736-a05120f1d1f9"), "One-line story prompt (e.g. 'A skydiver nervously prepares for their first jump')."),
            ]),
        new("character-creator.json", "character-creator",
            "Run the published Character Creator workflow. Generates a single character with multiple expressions, poses, and a 360 turntable video from one description.",
            BuiltInWorkflowCategory.CharacterItem,
            [
                new("--description",     Guid.Parse("5ed3fc86-1972-4a6e-8bc7-dfbcb8800e51"), "Character description (style + visual identity). Drives every downstream view and expression."),
                new("--rotation-prompt", Guid.Parse("fedc7027-fad4-491a-bde7-06b6d63cf9f0"), "Turntable rotation video prompt."),
                new("--catchphrase",     Guid.Parse("65d7acbf-b610-4cfb-bcef-42b6fb2c1b78"), "Line the character speaks in the final talking-head video."),
            ]),
        new("image-variations.json", "image-variations",
            "Run the published Image Variations workflow on one source image with a free-form variation request.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--image",      Guid.Parse("8b9ce9f9-a782-410c-9fe8-398880d65506"), "Source image to vary."),
                new("--variations", Guid.Parse("b6a56feb-5e25-4281-afea-a1cddaef1712"), "Variation request, e.g. 'Vary: 3 Yellow outfit, white background.'."),
            ]),
        new("mockup-generator.json", "mockup-generator",
            "Run the published Mockup Generator workflow. Renders one product image as four mockup placements (e.g. bus stop ad, bus side, billboard, etc).",
            BuiltInWorkflowCategory.SceneComposition,
            [
                new("--image",  Guid.Parse("e4afdc95-d797-464c-b032-8f8c391fb88b"), "Product image to insert into the mockups."),
                new("--mockup", Guid.Parse("01d921be-fd98-4bb4-8614-c2040dceeb2b"), "Mockup details (placement / setting), e.g. 'Mockup details: Bus stop Ads, paper texture, night time'."),
            ]),
        new("build-system-prompt.json", "build-system-prompt",
            "Run the published Build Your System Prompt workflow. Iterates a system-prompt + style + subject through image and video generators to test prompt-engineering choices.",
            BuiltInWorkflowCategory.VideoSandbox,
            [
                new("--subject", Guid.Parse("cfbe3eb8-3d00-4f6a-a545-429325c9fdc4"), "Subject to render (e.g. 'A strawberry')."),
                new("--style",   Guid.Parse("0dda9e16-d9bc-4304-bf04-62f3d52b1e03"), "Style guidance (defaults to a macro close-up specification)."),
            ]),
        new("asset-reversioning.json", "asset-reversioning",
            "Run the published Asset Reversioning workflow. Generates restyled / re-versioned variants of one source image via the bundled Canvas Reversion Engine.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--image", Guid.Parse("7fa592fd-e10c-4bdd-a480-4aba6c716830"), "Source image to reversion."),
            ]),
        new("backplate-generator.json", "backplate-generator",
            "Run the published Backplate Generator workflow. Removes the foreground subject from one image, fills the background, and re-composites into a new scene.",
            BuiltInWorkflowCategory.SceneComposition,
            [
                new("--image", Guid.Parse("64384461-450d-443b-9b0b-85b38f3866eb"), "Source image whose background should become the backplate."),
                new("--scene", Guid.Parse("2c2b2d77-400f-4f81-9fb4-48f045685389"), "New background scene, e.g. 'inside the back of a taxi, on a rainy day'."),
                new("--blur",  Guid.Parse("2786ffeb-5fc6-440e-9706-1fea6f0553cf"), "Optional background blur instruction (defaults to 50% gaussian blur)."),
            ]),
        new("wine-label-generator.json", "wine-label-generator",
            "Run the published Wine Label Generator workflow. Composites two label artworks onto one bottle reference and produces a final video shot.",
            BuiltInWorkflowCategory.SceneComposition,
            [
                new("--label-1",      Guid.Parse("42266fcc-e90f-4adb-acbc-017f2e9249a0"), "First wine label artwork."),
                new("--label-2",      Guid.Parse("3508fd38-7ce5-4e98-8489-b9569ecc109d"), "Second wine label artwork."),
                new("--bottle",       Guid.Parse("8b97a029-cfd2-4685-b039-df51b6f870b2"), "Bottle reference image (the bottle the labels are applied to)."),
                new("--video-prompt", Guid.Parse("6535a68c-3a32-4081-8ece-8861a127f2b3"), "Final video prompt (e.g. shattered bottle suspended in mid-air)."),
            ]),
        new("game-item-generator.json", "game-item-generator",
            "Run the published Game Item Generator workflow. Generates four rarity variants of one game item description plus an animated icon video.",
            BuiltInWorkflowCategory.CharacterItem,
            [
                new("--item",                Guid.Parse("abd34341-4fcc-4213-ae4b-4d6c1abf3ee0"), "Item description (e.g. 'A realistic rendered shotgun with red tiger's stripe paint, wooden stock')."),
                new("--motion",              Guid.Parse("91a37ff7-8488-4a8a-99e3-1efad8e3d44d"), "Video animation prompt for the in-game icon (defaults to subtle levitating loop)."),
                new("--variant-instruction", Guid.Parse("302a234a-0180-49e9-9a20-2cf42e3107ef"), "Variant generation instruction. Defaults to 'four variations in valid JSON format using keys ID:1..4'."),
            ]),
        new("human-pose-replication.json", "human-pose-replication",
            "Run the published Human Pose Replication and Transfer workflow. Re-renders a character image in a target reference pose.",
            BuiltInWorkflowCategory.PhotoRestyle,
            [
                new("--character",      Guid.Parse("cec49020-ae0f-4160-8d75-92b0193fed0f"), "Main character image whose identity should be preserved."),
                new("--pose",           Guid.Parse("faf1f438-6eda-44ef-bcdc-fcd7055fe11a"), "Reference pose image to replicate onto the character."),
                new("--driving-prompt", Guid.Parse("3c75a7f1-9418-445d-8b2b-1d79ddb286d6"), "Optional pose-extraction driving prompt (defaults to anatomical-landmark analysis)."),
            ]),
    ];

    /// <summary>All curated built-in workflows shipped with this SDK release.</summary>
    public static IReadOnlyList<BuiltInWorkflow> All { get; } =
        [.. Selections.Select(BuiltInWorkflowSelection.Materialize)];

    /// <summary>Look up a built-in by its kebab-case command name. Returns null if absent.</summary>
    public static BuiltInWorkflow? FindByCommandName(string commandName) =>
        All.FirstOrDefault(w => string.Equals(w.CommandName, commandName, StringComparison.Ordinal));

    /// <summary>Look up a built-in by its strongly-typed kind enum.</summary>
    public static BuiltInWorkflow FindByKind(BuiltInWorkflowKind kind)
    {
        var commandName = KindToCommandName(kind);
        return FindByCommandName(commandName)
            ?? throw new InvalidOperationException($"Built-in workflow for kind '{kind}' not found.");
    }

    /// <summary>Fabric / Color / Texture Swap built-in.</summary>
    public static BuiltInWorkflow FabricColorTextureSwap => FindByCommandName("fabric-color-texture-swap")!;
    /// <summary>Video to Video — Style Transfer built-in.</summary>
    public static BuiltInWorkflow VideoStyleTransfer => FindByCommandName("video-style-transfer")!;
    /// <summary>AI Hair Salon built-in.</summary>
    public static BuiltInWorkflow AiHairSalon => FindByCommandName("ai-hair-salon")!;
    /// <summary>Virtual Try On built-in.</summary>
    public static BuiltInWorkflow VirtualTryOn => FindByCommandName("virtual-try-on")!;
    /// <summary>JSON to Manga built-in.</summary>
    public static BuiltInWorkflow JsonToManga => FindByCommandName("json-to-manga")!;
    /// <summary>B-Roll Generator built-in.</summary>
    public static BuiltInWorkflow BRollGenerator => FindByCommandName("b-roll-generator")!;
    /// <summary>Storyboard to Film built-in.</summary>
    public static BuiltInWorkflow StoryboardToFilm => FindByCommandName("storyboard-to-film")!;
    /// <summary>Story Panels built-in.</summary>
    public static BuiltInWorkflow StoryPanels => FindByCommandName("story-panels")!;
    /// <summary>Storyboard Creator built-in.</summary>
    public static BuiltInWorkflow StoryboardCreator => FindByCommandName("storyboard-creator")!;
    /// <summary>Character Creator built-in.</summary>
    public static BuiltInWorkflow CharacterCreator => FindByCommandName("character-creator")!;
    /// <summary>Image Variations built-in.</summary>
    public static BuiltInWorkflow ImageVariations => FindByCommandName("image-variations")!;
    /// <summary>Mockup Generator built-in.</summary>
    public static BuiltInWorkflow MockupGenerator => FindByCommandName("mockup-generator")!;
    /// <summary>Build Your System Prompt built-in.</summary>
    public static BuiltInWorkflow BuildSystemPrompt => FindByCommandName("build-system-prompt")!;
    /// <summary>Asset Reversioning built-in.</summary>
    public static BuiltInWorkflow AssetReversioning => FindByCommandName("asset-reversioning")!;
    /// <summary>Backplate Generator built-in.</summary>
    public static BuiltInWorkflow BackplateGenerator => FindByCommandName("backplate-generator")!;
    /// <summary>Wine Label Generator built-in.</summary>
    public static BuiltInWorkflow WineLabelGenerator => FindByCommandName("wine-label-generator")!;
    /// <summary>Game Item Generator built-in.</summary>
    public static BuiltInWorkflow GameItemGenerator => FindByCommandName("game-item-generator")!;
    /// <summary>Human Pose Replication built-in.</summary>
    public static BuiltInWorkflow HumanPoseReplication => FindByCommandName("human-pose-replication")!;

    private static string KindToCommandName(BuiltInWorkflowKind kind) => kind switch
    {
        BuiltInWorkflowKind.FabricColorTextureSwap => "fabric-color-texture-swap",
        BuiltInWorkflowKind.VideoStyleTransfer => "video-style-transfer",
        BuiltInWorkflowKind.AiHairSalon => "ai-hair-salon",
        BuiltInWorkflowKind.VirtualTryOn => "virtual-try-on",
        BuiltInWorkflowKind.JsonToManga => "json-to-manga",
        BuiltInWorkflowKind.BRollGenerator => "b-roll-generator",
        BuiltInWorkflowKind.StoryboardToFilm => "storyboard-to-film",
        BuiltInWorkflowKind.StoryPanels => "story-panels",
        BuiltInWorkflowKind.StoryboardCreator => "storyboard-creator",
        BuiltInWorkflowKind.CharacterCreator => "character-creator",
        BuiltInWorkflowKind.ImageVariations => "image-variations",
        BuiltInWorkflowKind.MockupGenerator => "mockup-generator",
        BuiltInWorkflowKind.BuildSystemPrompt => "build-system-prompt",
        BuiltInWorkflowKind.AssetReversioning => "asset-reversioning",
        BuiltInWorkflowKind.BackplateGenerator => "backplate-generator",
        BuiltInWorkflowKind.WineLabelGenerator => "wine-label-generator",
        BuiltInWorkflowKind.GameItemGenerator => "game-item-generator",
        BuiltInWorkflowKind.HumanPoseReplication => "human-pose-replication",
        _ => throw new InvalidOperationException($"Unknown built-in workflow kind: {kind}"),
    };

    /// <summary>
    /// Render the per-category Markdown table block (rows of <c>| `command` | required | optional |</c>).
    /// Used by docs generators and drift tests; safe to call from any consumer.
    /// </summary>
    public static string RenderCategoryTable(BuiltInWorkflowCategory category)
    {
        var inv = System.Globalization.CultureInfo.InvariantCulture;
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("| Command | Required | Optional |");
        sb.AppendLine("| --- | --- | --- |");
        foreach (var w in All.Where(b => b.Category == category))
        {
            var required = string.Join(", ", w.Inputs.Where(i => i.Required).Select(i => $"`{i.Flag}`"));
            var optional = string.Join(", ", w.Inputs.Where(i => !i.Required).Select(i => $"`{i.Flag}`"));
            sb.AppendLine(inv, $"| `{w.CommandName}` | {(required.Length == 0 ? "—" : required)} | {(optional.Length == 0 ? "—" : optional)} |");
        }
        return sb.ToString().TrimEnd('\n', '\r');
    }

    /// <summary>
    /// Render the categories index — bullet list of <c>- **[Category](workflows/slug.md)** — `cmd1`, `cmd2`</c>.
    /// </summary>
    public static string RenderIndex()
    {
        var inv = System.Globalization.CultureInfo.InvariantCulture;
        var sb = new System.Text.StringBuilder();
        foreach (var category in Enum.GetValues<BuiltInWorkflowCategory>())
        {
            if (category == BuiltInWorkflowCategory.Uncategorized) continue;
            var commands = All.Where(b => b.Category == category).Select(b => $"`{b.CommandName}`").ToList();
            if (commands.Count == 0) continue;
            sb.AppendLine(inv, $"- **[{category.DisplayName()}](workflows/{category.Slug()}.md)** — {string.Join(", ", commands)}");
        }
        return sb.ToString().TrimEnd('\n', '\r');
    }

    /// <summary>
    /// Render a human-readable category-grouped listing of the supplied workflows (or all
    /// built-ins by default). Used by the CLI's <c>workflow built-ins</c> human output and
    /// suitable for any consumer that wants a brief summary (a Telegram bot's <c>/help</c>
    /// command, a desktop app's about dialog, etc).
    /// </summary>
    public static string RenderHumanList(IEnumerable<BuiltInWorkflow>? workflows = null)
    {
        var inv = System.Globalization.CultureInfo.InvariantCulture;
        var sb = new System.Text.StringBuilder();
        var source = workflows ?? All;
        foreach (var group in source.GroupBy(w => w.Category).OrderBy(g => (int)g.Key))
        {
            sb.AppendLine(inv, $"## {group.Key.DisplayName()}");
            sb.AppendLine();
            foreach (var w in group)
            {
                var required = w.Inputs.Where(i => i.Required).Select(i => i.Flag).ToList();
                var optional = w.Inputs.Where(i => !i.Required).Select(i => i.Flag).ToList();
                sb.AppendLine(inv, $"{w.CommandName,-30}  {w.DisplayName}");
                if (required.Count > 0)
                {
                    sb.AppendLine(inv, $"  required:  {string.Join(", ", required)}");
                }
                if (optional.Count > 0)
                {
                    sb.AppendLine(inv, $"  optional:  {string.Join(", ", optional)}");
                }
                sb.AppendLine();
            }
        }
        return sb.ToString().TrimEnd('\n', '\r') + Environment.NewLine;
    }

    /// <summary>
    /// Re-derive a <see cref="BuiltInWorkflow"/> from a graph snapshot + a list of picks.
    /// Useful when consumers (CLI dynamic registry, custom tooling) want to materialize a
    /// workflow definition from a freshly-fetched <c>GET /v1/workflows/{id}</c> response.
    /// </summary>
    public static BuiltInWorkflow MaterializeFromGraph(
        string commandName,
        string description,
        BuiltInWorkflowCategory category,
        IReadOnlyList<BuiltInWorkflowPick> picks,
        string graphJson,
        string source)
        => BuiltInWorkflowSelection.MaterializeFromGraph(commandName, description, category, picks, graphJson, source);

    /// <summary>
    /// Open the embedded fixture JSON for the named built-in. Internal helper used by
    /// <see cref="BuiltInWorkflowSelection.Materialize"/>.
    /// </summary>
    internal static Stream OpenEmbeddedFixture(string fixtureFileName)
    {
        var resourceName = $"Runway.Fixtures.workflows.{fixtureFileName}";
        return typeof(BuiltInWorkflows).Assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Embedded workflow fixture '{resourceName}' not found.");
    }
}

/// <summary>
/// One pick into a workflow graph: which node to expose under which flag.
/// Returned by analyzers (e.g. when registering a user-published workflow at runtime) and consumed
/// by <see cref="BuiltInWorkflows.MaterializeFromGraph"/> to derive a <see cref="BuiltInWorkflow"/>.
/// </summary>
/// <param name="Flag">CLI-style flag identifier (e.g. <c>"--image"</c>).</param>
/// <param name="NodeId">The workflow graph node ID this pick targets.</param>
/// <param name="Description">Human-readable description for help text / routing prose.</param>
public sealed record BuiltInWorkflowPick(
    string Flag,
    Guid NodeId,
    string Description);

/// <summary>
/// Selection record — pairs a fixture filename with the curated picks for that workflow.
/// Materialized at startup into the <see cref="BuiltInWorkflow"/> instances exposed via
/// <see cref="BuiltInWorkflows.All"/>. Exposed publicly so consumers can drift-test or
/// re-render docs from the registry.
/// </summary>
public sealed record BuiltInWorkflowSelection(
    string FixtureFileName,
    string CommandName,
    string Description,
    BuiltInWorkflowCategory Category,
    IReadOnlyList<BuiltInWorkflowPick> Picks)
{
    /// <summary>Materialize a selection by reading its embedded fixture and resolving each pick.</summary>
    public static BuiltInWorkflow Materialize(BuiltInWorkflowSelection selection)
    {
        ArgumentNullException.ThrowIfNull(selection);
        using var stream = BuiltInWorkflows.OpenEmbeddedFixture(selection.FixtureFileName);
        using var reader = new StreamReader(stream);
        return MaterializeFromGraph(
            selection.CommandName,
            selection.Description,
            selection.Category,
            selection.Picks,
            reader.ReadToEnd(),
            selection.FixtureFileName);
    }

    /// <summary>
    /// Re-derives a <see cref="BuiltInWorkflow"/> from a graph snapshot + the picks list.
    /// </summary>
    public static BuiltInWorkflow MaterializeFromGraph(
        string commandName,
        string description,
        BuiltInWorkflowCategory category,
        IReadOnlyList<BuiltInWorkflowPick> picks,
        string graphJson,
        string source)
    {
        ArgumentNullException.ThrowIfNull(picks);
        using var document = JsonDocument.Parse(graphJson);
        var root = document.RootElement;

        if (!root.TryGetProperty("id", out var idEl) || !Guid.TryParse(idEl.GetString(), out var workflowId))
        {
            throw new InvalidOperationException($"{source} missing valid 'id'.");
        }
        var displayName = root.TryGetProperty("name", out var nameEl) && nameEl.ValueKind == JsonValueKind.String
            ? nameEl.GetString() ?? string.Empty
            : string.Empty;

        var nodes = root.GetProperty("graph").GetProperty("nodes");

        var inputs = new List<BuiltInWorkflowInput>(picks.Count);
        foreach (var pick in picks)
        {
            var input = ResolvePick(pick, nodes, source);
            inputs.Add(input);
        }

        return new BuiltInWorkflow(
            CommandName: commandName,
            WorkflowId: workflowId,
            DisplayName: displayName,
            Description: description,
            Category: category,
            Inputs: inputs);
    }

    private static BuiltInWorkflowInput ResolvePick(BuiltInWorkflowPick pick, JsonElement nodes, string source)
    {
        foreach (var node in nodes.EnumerateArray())
        {
            if (!node.TryGetProperty("id", out var idEl) || !Guid.TryParse(idEl.GetString(), out var nodeId)) continue;
            if (nodeId != pick.NodeId) continue;
            return BuildInput(pick, node)
                ?? throw new InvalidOperationException(
                    $"{source} node {pick.NodeId} is present but not an exposed asset/constant input. Pick: {pick.Flag}.");
        }
        throw new InvalidOperationException(
            $"{source} does not contain a node with id {pick.NodeId} for flag {pick.Flag}.");
    }

    private static BuiltInWorkflowInput? BuildInput(BuiltInWorkflowPick pick, JsonElement node)
    {
        if (!node.TryGetProperty("nodeType", out var nodeTypeEl) || nodeTypeEl.ValueKind != JsonValueKind.String) return null;
        var nodeType = nodeTypeEl.GetString();

        BuiltInWorkflowInputKind? kind = null;
        string? outputKey = null;
        if (nodeType == "asset-node" && node.TryGetProperty("assetNodeType", out var assetEl) && assetEl.ValueKind == JsonValueKind.String)
        {
            switch (assetEl.GetString())
            {
                case "image": kind = BuiltInWorkflowInputKind.Image; outputKey = "image"; break;
                case "video": kind = BuiltInWorkflowInputKind.Video; outputKey = "video"; break;
                case "audio": kind = BuiltInWorkflowInputKind.Audio; outputKey = "audio"; break;
            }
        }
        else if (nodeType == "constant-node" && node.TryGetProperty("constantNodeType", out var constEl) && constEl.ValueKind == JsonValueKind.String)
        {
            switch (constEl.GetString())
            {
                case "prompt": kind = BuiltInWorkflowInputKind.Prompt; outputKey = "prompt"; break;
                case "number": kind = BuiltInWorkflowInputKind.Number; outputKey = "number"; break;
                case "boolean": kind = BuiltInWorkflowInputKind.Boolean; outputKey = "boolean"; break;
            }
        }
        if (kind is null || outputKey is null) return null;

        string? defaultPreview = null;
        if (node.TryGetProperty("nodeOutputs", out var outputsEl) &&
            outputsEl.ValueKind == JsonValueKind.Object &&
            outputsEl.TryGetProperty(outputKey, out var outputEl) &&
            outputEl.ValueKind == JsonValueKind.Object &&
            outputEl.TryGetProperty("value", out var valueEl))
        {
            defaultPreview = valueEl.ValueKind switch
            {
                JsonValueKind.String => valueEl.GetString(),
                JsonValueKind.Number => valueEl.GetRawText(),
                JsonValueKind.True => "true",
                JsonValueKind.False => "false",
                _ => null,
            };
            if (kind is BuiltInWorkflowInputKind.Image or BuiltInWorkflowInputKind.Video or BuiltInWorkflowInputKind.Audio)
            {
                defaultPreview = null;
            }
        }

        var required = kind is BuiltInWorkflowInputKind.Image or BuiltInWorkflowInputKind.Video or BuiltInWorkflowInputKind.Audio;
        return new BuiltInWorkflowInput(
            Flag: pick.Flag,
            NodeId: pick.NodeId,
            OutputKey: outputKey,
            Kind: kind.Value,
            Required: required,
            Description: pick.Description,
            DefaultPreview: defaultPreview);
    }
}
