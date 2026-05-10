using System.Text.Json;

namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliBuiltInWorkflowRegistryTests
{
    private static string LoadFixture(string fileName) =>
        File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Fixtures", "workflows", fileName));

    [TestMethod]
    public void Slugify_NormalizesCommonInputs()
    {
        RunwayCliBuiltInWorkflowRegistry.Slugify("Fabric, Color, Texture Swap (Copy)").Should().Be("fabric-color-texture-swap-copy");
        RunwayCliBuiltInWorkflowRegistry.Slugify("Specifics of Product").Should().Be("specifics-of-product");
        RunwayCliBuiltInWorkflowRegistry.Slugify("  spaces and  multiple-dashes ").Should().Be("spaces-and-multiple-dashes");
        RunwayCliBuiltInWorkflowRegistry.Slugify("UPPER_lower_123").Should().Be("upper-lower-123");
        RunwayCliBuiltInWorkflowRegistry.Slugify("").Should().Be("");
    }

    [TestMethod]
    public void AnalyzeGraph_FabricSwap_DerivesAllPicks()
    {
        var json = LoadFixture("fabric-color-texture-swap.json");

        var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(json, overrideCommandName: null);

        analyzed.WorkflowId.Should().Be(Guid.Parse("bd4dd01e-bb65-46ae-9db4-170c997c36f2"));
        analyzed.CommandName.Should().Be("fabric-color-texture-swap-copy");
        analyzed.DisplayName.Should().Be("Fabric, Color, Texture Swap (Copy)");
        analyzed.Picks.Should().HaveCount(6);

        // 4 prompt nodes share the same nodeProps.name "Specifics of Product" -> dedup with -1, -2, -3, -4.
        analyzed.Picks
            .Where(p => p.Description == "Specifics of Product")
            .Select(p => p.Flag)
            .Should().BeEquivalentTo(new[]
            {
                "--specifics-of-product-1",
                "--specifics-of-product-2",
                "--specifics-of-product-3",
                "--specifics-of-product-4",
            }, o => o.WithStrictOrdering());

        // The unnamed system prompt falls back to --prompt-1 (type-indexed).
        analyzed.Picks.Should().ContainSingle(p => p.Flag == "--prompt-1");

        // Image input has no nodeProps.name -> falls back to type-indexed slug.
        analyzed.Picks.Should().ContainSingle(p => p.Flag == "--image-1");
    }

    [TestMethod]
    public void AnalyzeGraph_ThenMaterialize_FabricSwap_ResolvesKinds()
    {
        var json = LoadFixture("fabric-color-texture-swap.json");
        var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(json, overrideCommandName: null);

        var workflow = BuiltInWorkflows.MaterializeFromGraph(
            analyzed.CommandName, analyzed.Description, BuiltInWorkflowCategory.Uncategorized, analyzed.Picks, json, source: "test");

        var image = workflow.Inputs.Single(i => i.Flag == "--image-1");
        image.Kind.Should().Be(BuiltInWorkflowInputKind.Image);
        image.Required.Should().BeTrue();
        image.DefaultPreview.Should().BeNull();

        workflow.Inputs.Where(i => i.Flag.StartsWith("--specifics-of-product-")).Should().HaveCount(4);
        workflow.Inputs.Where(i => i.Flag.StartsWith("--specifics-of-product-"))
            .Should().AllSatisfy(i =>
            {
                i.Kind.Should().Be(BuiltInWorkflowInputKind.Prompt);
                i.Required.Should().BeFalse();
                i.DefaultPreview.Should().NotBeNullOrEmpty();
            });
    }

    [TestMethod]
    public void AnalyzeGraph_VideoStyleTransfer_DerivesNamedAndIndexedPicks()
    {
        var json = LoadFixture("video-style-transfer.json");
        var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(json, overrideCommandName: null);

        analyzed.WorkflowId.Should().Be(Guid.Parse("d1d344d1-8321-4f29-9d9d-90503abcd4fd"));
        analyzed.CommandName.Should().Be("video-to-video-style-transfer-copy");

        analyzed.Picks.Should().ContainSingle(p => p.Flag == "--video-1");
        // Two unnamed prompt nodes -> --prompt-1, --prompt-2 in graph-position order.
        var prompts = analyzed.Picks.Where(p => p.Flag.StartsWith("--prompt-")).ToList();
        prompts.Should().HaveCount(2);
        prompts.Select(p => p.Flag).Should().BeEquivalentTo(new[] { "--prompt-1", "--prompt-2" }, o => o.WithStrictOrdering());
    }

    [TestMethod]
    public void AnalyzeGraph_OverrideCommandNameWins()
    {
        var json = LoadFixture("fabric-color-texture-swap.json");

        var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(json, overrideCommandName: "Custom Name 42");

        analyzed.CommandName.Should().Be("custom-name-42");
    }

    [TestMethod]
    public void RoundTrip_SaveAndLoad_RederivesInputsFromGraph()
    {
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-cli-registry-{Guid.NewGuid():N}");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);
            try
            {
                var fixture = LoadFixture("fabric-color-texture-swap.json");
                var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(fixture, overrideCommandName: "round-trip-test");

                var path = RunwayCliBuiltInWorkflowRegistry.Save(
                    analyzed.CommandName, analyzed.Description, analyzed.Picks, fixture);
                File.Exists(path).Should().BeTrue();

                // Stored file shape: only commandName/description/picks/graph; no derived inputs persisted.
                using var doc = JsonDocument.Parse(File.ReadAllText(path));
                doc.RootElement.GetProperty("commandName").GetString().Should().Be("round-trip-test");
                doc.RootElement.TryGetProperty("inputs", out _).Should().BeFalse(
                    because: "derived inputs must NOT be persisted; LoadAll re-derives them from the cached graph");
                doc.RootElement.GetProperty("picks").GetArrayLength().Should().Be(analyzed.Picks.Count);
                doc.RootElement.GetProperty("graph").GetProperty("id").GetString().Should().Be(analyzed.WorkflowId.ToString());

                var all = RunwayCliBuiltInWorkflowRegistry.LoadAll();
                all.Should().ContainSingle();
                var loaded = all[0];
                loaded.CommandName.Should().Be("round-trip-test");
                loaded.WorkflowId.Should().Be(analyzed.WorkflowId);
                loaded.Inputs.Should().HaveCount(analyzed.Picks.Count);
                loaded.Inputs.Single(i => i.Flag == "--image-1").Kind.Should().Be(BuiltInWorkflowInputKind.Image);

                RunwayCliBuiltInWorkflowRegistry.Remove("round-trip-test").Should().BeTrue();
                RunwayCliBuiltInWorkflowRegistry.LoadAll().Should().BeEmpty();
            }
            finally
            {
                Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", null);
            }
        }
        finally
        {
            if (Directory.Exists(sandbox)) Directory.Delete(sandbox, recursive: true);
        }
    }

    [TestMethod]
    public void LoadAll_PicksUpDefaultEditsToCachedGraph()
    {
        // Demonstrates the "re-derive on load" behavior: edit a default value in the cached
        // graph snapshot and LoadAll picks it up without rewriting the picks list.
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-cli-registry-{Guid.NewGuid():N}");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);
            try
            {
                var fixture = LoadFixture("video-style-transfer.json");
                var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(fixture, overrideCommandName: "edit-test");
                var path = RunwayCliBuiltInWorkflowRegistry.Save(
                    analyzed.CommandName, analyzed.Description, analyzed.Picks, fixture);

                var first = RunwayCliBuiltInWorkflowRegistry.LoadAll().Single();
                var promptPick = analyzed.Picks.First(p => p.Flag == "--prompt-1");

                // Surgically edit the default 'value' on the prompt node in the cached graph.
                var node = System.Text.Json.Nodes.JsonNode.Parse(File.ReadAllText(path)) as System.Text.Json.Nodes.JsonObject;
                node.Should().NotBeNull();
                // Saved JSON wraps the full GET /v1/workflows/{id} response under "graph",
                // and that response itself has its node array at .graph.nodes.
                var nodes = node!["graph"]!["graph"]!["nodes"]!.AsArray();
                foreach (var n in nodes)
                {
                    if (n is System.Text.Json.Nodes.JsonObject obj &&
                        obj["id"]?.GetValue<string>() == promptPick.NodeId.ToString())
                    {
                        obj["nodeOutputs"]!["prompt"]!["value"] = "EDITED DEFAULT VALUE";
                    }
                }
                File.WriteAllText(path, node.ToJsonString());

                var second = RunwayCliBuiltInWorkflowRegistry.LoadAll().Single();
                second.Inputs.First(i => i.Flag == "--prompt-1")
                    .DefaultPreview.Should().Be("EDITED DEFAULT VALUE",
                        because: "LoadAll re-derives DefaultPreview from the embedded graph each load");
            }
            finally
            {
                Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", null);
            }
        }
        finally
        {
            if (Directory.Exists(sandbox)) Directory.Delete(sandbox, recursive: true);
        }
    }

    [TestMethod]
    public void LoadAllCommands_MergesBuiltinsAndRegistered()
    {
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-cli-registry-{Guid.NewGuid():N}");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);
            try
            {
                var fixture = LoadFixture("fabric-color-texture-swap.json");
                var analyzed = RunwayCliBuiltInWorkflowRegistry.AnalyzeGraph(fixture, overrideCommandName: "my-fashion-tool");
                RunwayCliBuiltInWorkflowRegistry.Save(analyzed.CommandName, analyzed.Description, analyzed.Picks, fixture);

                var all = RunwayCliBuiltInWorkflows.LoadAllCommands();

                all.Select(w => w.CommandName).Should().Contain("fabric-color-texture-swap");
                all.Select(w => w.CommandName).Should().Contain("video-style-transfer");
                all.Select(w => w.CommandName).Should().Contain("my-fashion-tool");
            }
            finally
            {
                Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", null);
            }
        }
        finally
        {
            if (Directory.Exists(sandbox)) Directory.Delete(sandbox, recursive: true);
        }
    }

    [TestMethod]
    public void Save_RejectsEmptyPicks()
    {
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-cli-registry-{Guid.NewGuid():N}");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);
            try
            {
                var fixture = LoadFixture("video-style-transfer.json");

                var act = () => RunwayCliBuiltInWorkflowRegistry.Save(
                    "no-picks-test", "should not register", picks: [], fixture);

                act.Should().Throw<InvalidOperationException>()
                    .WithMessage("*Refusing to register*no picks*");
                File.Exists(Path.Combine(sandbox, ".runway-cli", "workflows", "no-picks-test.json"))
                    .Should().BeFalse(because: "no file should be written when Save rejects the input");
            }
            finally
            {
                Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", null);
            }
        }
        finally
        {
            if (Directory.Exists(sandbox)) Directory.Delete(sandbox, recursive: true);
        }
    }

    [TestMethod]
    public void LoadAllCommands_DoesNotShadowBuiltins()
    {
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-cli-registry-{Guid.NewGuid():N}");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);
            try
            {
                // Hand-craft a registered entry that tries to shadow the built-in by reusing its commandName.
                var fixture = LoadFixture("fabric-color-texture-swap.json");
                var picks = new[]
                {
                    new BuiltInWorkflowPick("--clobber", Guid.Parse("7381d0bb-4120-47ce-bf29-9daee9f3c6c6"), "would-clobber image"),
                };
                RunwayCliBuiltInWorkflowRegistry.Save("fabric-color-texture-swap", "shadowing entry", picks, fixture);

                var all = RunwayCliBuiltInWorkflows.LoadAllCommands();
                var match = all.Single(w => w.CommandName == "fabric-color-texture-swap");

                // Built-in wins (it has 5 inputs).
                match.Inputs.Should().HaveCount(5);
                match.Inputs.Should().NotContain(i => i.Flag == "--clobber");
            }
            finally
            {
                Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", null);
            }
        }
        finally
        {
            if (Directory.Exists(sandbox)) Directory.Delete(sandbox, recursive: true);
        }
    }
}
