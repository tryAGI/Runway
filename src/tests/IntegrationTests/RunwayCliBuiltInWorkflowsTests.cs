using System.Text.Json.Nodes;

namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliBuiltInWorkflowsTests
{
    [TestMethod]
    public void Registry_ContainsAllPublishedWorkflows()
    {
        var registry = RunwayCliBuiltInWorkflows.Registry;

        registry.Should().HaveCount(18);
        registry.Select(w => w.CommandName).Should().BeEquivalentTo(
        [
            "fabric-color-texture-swap",
            "video-style-transfer",
            "ai-hair-salon",
            "virtual-try-on",
            "json-to-manga",
            "b-roll-generator",
            "storyboard-to-film",
            "story-panels",
            "storyboard-creator",
            "character-creator",
            "image-variations",
            "mockup-generator",
            "build-system-prompt",
            "asset-reversioning",
            "backplate-generator",
            "wine-label-generator",
            "game-item-generator",
            "human-pose-replication",
        ]);
    }

    [TestMethod]
    public void Selection_AllPicksMatchEmbeddedFixtures()
    {
        // Lower-level than Registry_NodeIdsMatchSavedFixtures: this materializes each selection
        // *individually* and reports which one breaks (rather than blowing up the static
        // initializer of RunwayCliBuiltInWorkflows).
        var failures = new List<string>();
        foreach (var selection in BuiltInWorkflows.BuiltInSelections)
        {
            try
            {
                var workflow = BuiltInWorkflowSelection.Materialize(selection);

                workflow.CommandName.Should().Be(selection.CommandName);
                workflow.Inputs.Should().HaveCount(selection.Picks.Count,
                    because: $"materialized inputs of {selection.CommandName} must match picks count");

                for (var i = 0; i < selection.Picks.Count; i++)
                {
                    var pick = selection.Picks[i];
                    var input = workflow.Inputs[i];
                    input.Flag.Should().Be(pick.Flag);
                    input.NodeId.Should().Be(pick.NodeId);
                    input.Description.Should().Be(pick.Description);
                    input.OutputKey.Should().NotBeNullOrEmpty();
                }
            }
            catch (Exception ex)
            {
                failures.Add($"{selection.CommandName} ({selection.FixtureFileName}): {ex.Message}");
            }
        }

        failures.Should().BeEmpty(
            because: "every BuiltInWorkflowSelection must materialize cleanly against its embedded fixture; failures: " + Environment.NewLine + string.Join(Environment.NewLine, failures));
    }

    [TestMethod]
    public void Registry_NodeIdsMatchSavedFixtures()
    {
        // Each built-in's WorkflowId + per-input NodeId must match the canonical IDs in the
        // saved fixture, otherwise the request body targets nodes that don't exist.
        var fixtureFor = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["fabric-color-texture-swap"] = "fabric-color-texture-swap.json",
            ["video-style-transfer"] = "video-style-transfer.json",
            ["ai-hair-salon"] = "ai-hair-salon.json",
            ["virtual-try-on"] = "virtual-try-on.json",
            ["json-to-manga"] = "json-to-manga.json",
            ["b-roll-generator"] = "b-roll-generator.json",
            ["storyboard-to-film"] = "storyboard-to-film.json",
            ["story-panels"] = "story-panels.json",
            ["storyboard-creator"] = "storyboard-creator.json",
            ["character-creator"] = "character-creator.json",
            ["image-variations"] = "image-variations.json",
            ["mockup-generator"] = "mockup-generator.json",
            ["build-system-prompt"] = "build-system-prompt.json",
            ["asset-reversioning"] = "asset-reversioning.json",
            ["backplate-generator"] = "backplate-generator.json",
            ["wine-label-generator"] = "wine-label-generator.json",
            ["game-item-generator"] = "game-item-generator.json",
            ["human-pose-replication"] = "human-pose-replication.json",
        };

        foreach (var workflow in RunwayCliBuiltInWorkflows.BuiltIns)
        {
            var fixture = Path.Combine(AppContext.BaseDirectory, "Fixtures", "workflows", fixtureFor[workflow.CommandName]);
            using var doc = System.Text.Json.JsonDocument.Parse(File.ReadAllText(fixture));
            var root = doc.RootElement;
            Guid.Parse(root.GetProperty("id").GetString()!).Should().Be(workflow.WorkflowId,
                because: $"{workflow.CommandName} workflow ID must match the published version");

            var nodeIds = new HashSet<Guid>();
            foreach (var node in root.GetProperty("graph").GetProperty("nodes").EnumerateArray())
            {
                if (Guid.TryParse(node.GetProperty("id").GetString(), out var nodeId))
                {
                    nodeIds.Add(nodeId);
                }
            }
            foreach (var input in workflow.Inputs)
            {
                nodeIds.Should().Contain(input.NodeId,
                    because: $"{workflow.CommandName} input {input.Flag} -> {input.NodeId} must point at a node that exists in the workflow graph");
            }
        }
    }

    [TestMethod]
    public void Registry_FabricSwap_HasExpectedShape()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap");

        workflow.Should().NotBeNull();
        workflow!.WorkflowId.Should().Be(Guid.Parse("bd4dd01e-bb65-46ae-9db4-170c997c36f2"));
        workflow.Inputs.Should().HaveCount(5);
        workflow.Inputs[0].Flag.Should().Be("--image");
        workflow.Inputs[0].Kind.Should().Be(BuiltInWorkflowInputKind.Image);
        workflow.Inputs[0].Required.Should().BeTrue();
        workflow.Inputs.Skip(1).Should().AllSatisfy(input =>
        {
            input.Kind.Should().Be(BuiltInWorkflowInputKind.Prompt);
            input.Required.Should().BeFalse();
        });
        workflow.Inputs.Select(i => i.Flag).Should().BeEquivalentTo(
            new[] { "--image", "--change-1", "--change-2", "--change-3", "--change-4" },
            o => o.WithStrictOrdering());
    }

    [TestMethod]
    public void Registry_VideoStyleTransfer_HasExpectedShape()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("video-style-transfer");

        workflow.Should().NotBeNull();
        workflow!.WorkflowId.Should().Be(Guid.Parse("d1d344d1-8321-4f29-9d9d-90503abcd4fd"));
        workflow.Inputs.Should().HaveCount(2);
        workflow.Inputs[0].Flag.Should().Be("--video");
        workflow.Inputs[0].Kind.Should().Be(BuiltInWorkflowInputKind.Video);
        workflow.Inputs[0].Required.Should().BeTrue();
        workflow.Inputs[1].Flag.Should().Be("--style");
        workflow.Inputs[1].Kind.Should().Be(BuiltInWorkflowInputKind.Prompt);
        workflow.Inputs[1].Required.Should().BeFalse();
    }

    [TestMethod]
    public void BuildNodeOutputs_OmitsUnsetOptionalInputs()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--image"] = "runway://upload/abc",
            ["--change-1"] = "Change: color to teal",
            ["--change-2"] = null,
            ["--change-3"] = "",
            ["--change-4"] = "   ",
        };

        var nodeOutputs = RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);

        nodeOutputs.Should().HaveCount(2);
        nodeOutputs[workflow.Inputs[0].NodeId.ToString()].Should().NotBeNull();
        nodeOutputs[workflow.Inputs[1].NodeId.ToString()].Should().NotBeNull();
        nodeOutputs[workflow.Inputs[2].NodeId.ToString()].Should().BeNull();
        nodeOutputs[workflow.Inputs[3].NodeId.ToString()].Should().BeNull();
        nodeOutputs[workflow.Inputs[4].NodeId.ToString()].Should().BeNull();
    }

    [TestMethod]
    public void BuildNodeOutputs_WrapsImageAsAssetReference()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--image"] = "runway://upload/abc",
        };

        var nodeOutputs = RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);

        var imageNode = nodeOutputs[workflow.Inputs[0].NodeId.ToString()] as JsonObject;
        imageNode.Should().NotBeNull();
        var imageOutput = imageNode!["image"] as JsonObject;
        imageOutput.Should().NotBeNull();
        imageOutput!["type"]!.GetValue<string>().Should().Be("image");
        imageOutput["uri"]!.GetValue<string>().Should().Be("runway://upload/abc");
    }

    [TestMethod]
    public void BuildNodeOutputs_WrapsVideoAsAssetReference()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("video-style-transfer")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--video"] = "https://example.com/clip.mp4",
            ["--style"] = "modern Pixar style",
        };

        var nodeOutputs = RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);

        var videoNode = nodeOutputs[workflow.Inputs[0].NodeId.ToString()] as JsonObject;
        videoNode!["video"]!["type"]!.GetValue<string>().Should().Be("video");
        videoNode["video"]!["uri"]!.GetValue<string>().Should().Be("https://example.com/clip.mp4");

        var styleNode = nodeOutputs[workflow.Inputs[1].NodeId.ToString()] as JsonObject;
        styleNode!["prompt"]!["type"]!.GetValue<string>().Should().Be("primitive");
        styleNode["prompt"]!["value"]!.GetValue<string>().Should().Be("modern Pixar style");
    }

    [TestMethod]
    public void BuildNodeOutputs_ThrowsWhenRequiredFlagMissing()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--change-1"] = "Change: color to teal",
        };

        var act = () => RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);

        act.Should().Throw<ArgumentException>().WithMessage("*--image*required*");
    }

    [TestMethod]
    public void BuildNodeOutputs_PromptValuePreservedVerbatim()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--image"] = "runway://upload/abc",
            ["--change-1"] = "  Change: color to TEAL\nwith extra notes  ",
        };

        var nodeOutputs = RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);

        var changeNode = nodeOutputs[workflow.Inputs[1].NodeId.ToString()] as JsonObject;
        changeNode!["prompt"]!["value"]!.GetValue<string>().Should().Be("  Change: color to TEAL\nwith extra notes  ");
    }

    [TestMethod]
    public void BuildNodeOutputs_AllNodesEmittedAsValidJson()
    {
        var workflow = RunwayCliBuiltInWorkflows.FindByCommandName("fabric-color-texture-swap")!;
        var values = new Dictionary<string, string?>(StringComparer.Ordinal)
        {
            ["--image"] = "runway://upload/abc",
            ["--change-1"] = "a",
            ["--change-2"] = "b",
            ["--change-3"] = "c",
            ["--change-4"] = "d",
        };

        var nodeOutputs = RunwayCliBuiltInWorkflows.BuildNodeOutputs(workflow, values);
        var json = nodeOutputs.ToJsonString();

        json.Should().Contain("\"type\":\"image\"");
        json.Should().Contain("\"type\":\"primitive\"");
        json.Should().Contain("\"value\":\"a\"");
        json.Should().Contain("\"value\":\"d\"");
    }

}
