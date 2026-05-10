using System.Text.RegularExpressions;

namespace Runway.IntegrationTests;

/// <summary>
/// Asserts that the auto-generated table sections in `.agents/skills/runway-cli/references/workflows/<category>.md`
/// (and the index in `.agents/skills/runway-cli/references/workflows.md`) match what
/// <c>BuiltInWorkflows.RenderCategoryTable</c> / <c>RenderIndex</c> produces from the live registry.
///
/// If a developer adds, renames, or removes a built-in workflow:
///   - These tests fail with the expected content printed in the assertion message.
///   - Set <c>RUNWAY_DOCS_REGEN=1</c> on a re-run and the test rewrites the markers in-place and passes.
/// </summary>
[TestClass]
public sealed class RunwaySkillMarkdownDriftTests
{
    /// <summary>
    /// When set, the drift tests rewrite the markdown markers in-place with the registry-derived
    /// content and pass instead of failing. Pattern: `RUNWAY_DOCS_REGEN=1 dotnet test --filter SkillMarkdownDrift`.
    /// Saves the copy-paste roundtrip when adding/renaming a built-in.
    /// </summary>
    private static bool RegenRequested =>
        Environment.GetEnvironmentVariable("RUNWAY_DOCS_REGEN") is { Length: > 0 } v &&
        v is "1" or "true" or "TRUE" or "yes" or "YES";

    private static string SkillRoot()
    {
        var root = CliHarness.FindRunwayRoot();
        return Path.Combine(root, ".agents", "skills", "runway-cli", "references");
    }

    [TestMethod]
    public void Workflows_Index_MatchesRegistry()
    {
        var path = Path.Combine(SkillRoot(), "workflows.md");
        AssertMarkerMatchesOrRegen(path, "index", BuiltInWorkflows.RenderIndex());
    }

    [TestMethod]
    [DataRow("PhotoRestyle", "photo-restyle.md")]
    [DataRow("SceneComposition", "scene-composition.md")]
    [DataRow("StorySequence", "story-sequence.md")]
    [DataRow("CharacterItem", "character-item.md")]
    [DataRow("VideoSandbox", "video-sandbox.md")]
    public void Workflows_CategoryTable_MatchesRegistry(string categoryName, string fileName)
    {
        var category = Enum.Parse<BuiltInWorkflowCategory>(categoryName);
        var path = Path.Combine(SkillRoot(), "workflows", fileName);
        File.Exists(path).Should().BeTrue(because: $"per-category file {path} must exist");
        AssertMarkerMatchesOrRegen(path, "builtins-table", BuiltInWorkflows.RenderCategoryTable(category));
    }

    private static void AssertMarkerMatchesOrRegen(string path, string markerName, string expected)
    {
        var content = File.ReadAllText(path);
        var actual = ExtractMarker(content, markerName);

        if (Normalize(actual) == Normalize(expected))
        {
            return;
        }

        if (RegenRequested)
        {
            var rewritten = ReplaceMarker(content, markerName, expected);
            File.WriteAllText(path, rewritten);
            Console.WriteLine($"[RUNWAY_DOCS_REGEN] rewrote '{markerName}' marker in {path}.");
            return;
        }

        Normalize(actual).Should().Be(Normalize(expected),
            because: $"the {markerName} block in {path} drifted from the registry. "
                   + $"Re-run with RUNWAY_DOCS_REGEN=1 to rewrite it in-place, or manually replace "
                   + $"the content between <!-- BEGIN:{markerName} --> and <!-- END:{markerName} --> with:"
                   + $"{Environment.NewLine}{Environment.NewLine}{expected}");
    }

    private static string ExtractMarker(string content, string markerName)
    {
        var pattern = $"<!-- BEGIN:{Regex.Escape(markerName)} -->(.*?)<!-- END:{Regex.Escape(markerName)} -->";
        var match = Regex.Match(content, pattern, RegexOptions.Singleline);
        match.Success.Should().BeTrue(
            because: $"missing <!-- BEGIN:{markerName} --> / <!-- END:{markerName} --> markers in markdown");
        return match.Groups[1].Value;
    }

    private static string ReplaceMarker(string content, string markerName, string newInner)
    {
        var pattern = $"(<!-- BEGIN:{Regex.Escape(markerName)} -->)(.*?)(<!-- END:{Regex.Escape(markerName)} -->)";
        return Regex.Replace(content, pattern, m =>
            $"{m.Groups[1].Value}{Environment.NewLine}{newInner}{Environment.NewLine}{m.Groups[3].Value}",
            RegexOptions.Singleline);
    }

    private static string Normalize(string s) => s.Replace("\r\n", "\n").Trim();

    [TestMethod]
    public void ReplaceMarker_ReplacesContentBetweenMarkersOnly()
    {
        // Direct test of the regen helper using a synthetic file so we don't mutate the real skill.
        var input = "before\n<!-- BEGIN:demo -->\nold content\n<!-- END:demo -->\nafter\n";
        var rewritten = typeof(RunwaySkillMarkdownDriftTests)
            .GetMethod("ReplaceMarker", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)!
            .Invoke(null, [input, "demo", "FRESH CONTENT"]) as string;

        rewritten.Should().NotBeNull();
        rewritten!.Should().Contain("before");
        rewritten.Should().Contain("after");
        rewritten.Should().Contain("FRESH CONTENT");
        rewritten.Should().NotContain("old content");
        // Surrounding markers preserved.
        rewritten.Should().Contain("<!-- BEGIN:demo -->");
        rewritten.Should().Contain("<!-- END:demo -->");
    }
}
