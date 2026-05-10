namespace Runway.IntegrationTests;

[TestClass]
public sealed class BuiltInWorkflowsSdkTests
{
    [TestMethod]
    public void Catalog_All_HasEighteenEntries()
    {
        BuiltInWorkflows.All.Should().HaveCount(18);

        // Every built-in must have a non-empty command name and at least one input.
        BuiltInWorkflows.All.Should().AllSatisfy(w =>
        {
            w.CommandName.Should().NotBeNullOrWhiteSpace();
            w.DisplayName.Should().NotBeNullOrWhiteSpace();
            w.Inputs.Should().NotBeEmpty();
            w.WorkflowId.Should().NotBe(default(Guid));
        });
    }

    [TestMethod]
    public void Catalog_FindByCommandName_ResolvesEachConvenienceAccessor()
    {
        BuiltInWorkflows.FindByCommandName("ai-hair-salon")!.WorkflowId
            .Should().Be(BuiltInWorkflows.AiHairSalon.WorkflowId);
        BuiltInWorkflows.FindByCommandName("video-style-transfer")!.WorkflowId
            .Should().Be(BuiltInWorkflows.VideoStyleTransfer.WorkflowId);
        BuiltInWorkflows.FindByCommandName("nope-not-real").Should().BeNull();
    }

    [TestMethod]
    public void Catalog_FindByKind_RoundTripsThroughEnum()
    {
        foreach (var kind in Enum.GetValues<BuiltInWorkflowKind>())
        {
            var workflow = BuiltInWorkflows.FindByKind(kind);
            workflow.Should().NotBeNull();
            workflow.CommandName.Should().NotBeNullOrWhiteSpace();
        }
    }

    [TestMethod]
    public void Category_DisplayNameAndSlugAndDescription_AreNonEmpty()
    {
        foreach (var category in Enum.GetValues<BuiltInWorkflowCategory>())
        {
            category.DisplayName().Should().NotBeNullOrWhiteSpace();
            category.Slug().Should().NotBeNullOrWhiteSpace();
            // Description is permitted to be empty for unknown categories, but should be set for the curated ones.
            if (category != BuiltInWorkflowCategory.Uncategorized)
            {
                category.Description().Should().NotBeNullOrWhiteSpace();
            }
        }
    }

    [TestMethod]
    public void Category_TryResolve_AcceptsBothEnumNameAndSlug()
    {
        BuiltInWorkflowCategoryExtensions.TryResolve("PhotoRestyle").Should().Be(BuiltInWorkflowCategory.PhotoRestyle);
        BuiltInWorkflowCategoryExtensions.TryResolve("photo-restyle").Should().Be(BuiltInWorkflowCategory.PhotoRestyle);
        BuiltInWorkflowCategoryExtensions.TryResolve("PHOTO-RESTYLE").Should().Be(BuiltInWorkflowCategory.PhotoRestyle);
        BuiltInWorkflowCategoryExtensions.TryResolve("photorestyle").Should().Be(BuiltInWorkflowCategory.PhotoRestyle);
        BuiltInWorkflowCategoryExtensions.TryResolve("nope").Should().BeNull();
        BuiltInWorkflowCategoryExtensions.TryResolve("").Should().BeNull();
    }

    [TestMethod]
    public void Inputs_FluentBuilder_AcceptsTextAndStreamAndUri()
    {
        var stream = new MemoryStream([0x01, 0x02]);
        var inputs = BuiltInWorkflowInputs.Create()
            .Set("--hairstyle", "wavy bob")
            .SetStream("--image", stream, "photo.png")
            .SetUri("--background", new Uri("https://example.com/bg.jpg"))
            .SetNumber("--strength", 0.75)
            .SetBoolean("--enabled", true);

        inputs.Values.Should().HaveCount(5);
        inputs.Values["--hairstyle"].Should().BeOfType<BuiltInWorkflowValue.TextValue>()
            .Which.Text.Should().Be("wavy bob");
        inputs.Values["--image"].Should().BeOfType<BuiltInWorkflowValue.StreamValue>()
            .Which.FileName.Should().Be("photo.png");
        inputs.Values["--background"].Should().BeOfType<BuiltInWorkflowValue.UriValue>()
            .Which.Uri.AbsoluteUri.Should().Be("https://example.com/bg.jpg");
        inputs.Values["--strength"].Should().BeOfType<BuiltInWorkflowValue.NumberValue>()
            .Which.Number.Should().Be(0.75);
        inputs.Values["--enabled"].Should().BeOfType<BuiltInWorkflowValue.BooleanValue>()
            .Which.Boolean.Should().BeTrue();
    }

    [TestMethod]
    public void Inputs_FromAssetString_RecognizesUriPrefixes()
    {
        BuiltInWorkflowValue.FromAssetString("https://cdn.example/file.png")
            .Should().BeOfType<BuiltInWorkflowValue.UriValue>();
        BuiltInWorkflowValue.FromAssetString("runway://upload/abc123")
            .Should().BeOfType<BuiltInWorkflowValue.UriValue>();
        BuiltInWorkflowValue.FromAssetString("data:image/png;base64,iVBORw0KGgo=")
            .Should().BeOfType<BuiltInWorkflowValue.UriValue>();
        BuiltInWorkflowValue.FromAssetString("./assets/photo.png")
            .Should().BeOfType<BuiltInWorkflowValue.FilePathValue>()
            .Which.Path.Should().Be("./assets/photo.png");
    }

    [TestMethod]
    public void JsonContext_SerializesAndRoundTripsResult()
    {
        var nodeA = Guid.NewGuid();
        var result = new BuiltInWorkflowResult(
            InvocationId: Guid.NewGuid(),
            Status: BuiltInWorkflowStatus.Succeeded,
            NodeOutputs: new Dictionary<Guid, IReadOnlyList<Uri>>
            {
                [nodeA] = [new Uri("https://cdn.example/a.png")],
            },
            Failure: null,
            FailureCode: null,
            Progress: 1.0);

        var json = System.Text.Json.JsonSerializer.Serialize(
            result,
            BuiltInWorkflowsJsonSerializerContext.Default.BuiltInWorkflowResult);

        json.Should().Contain("\"status\":\"Succeeded\"");
        json.Should().Contain("https://cdn.example/a.png");

        var deserialized = System.Text.Json.JsonSerializer.Deserialize(
            json,
            BuiltInWorkflowsJsonSerializerContext.Default.BuiltInWorkflowResult);
        deserialized.Should().NotBeNull();
        deserialized!.InvocationId.Should().Be(result.InvocationId);
        deserialized.Status.Should().Be(BuiltInWorkflowStatus.Succeeded);
        deserialized.NodeOutputs.Should().HaveCount(1);
    }

    [TestMethod]
    public void RenderHumanList_GroupsByCategoryAndIncludesEveryCommand()
    {
        var output = BuiltInWorkflows.RenderHumanList();

        // Category headers present in display-name form.
        output.Should().Contain("## Photo / Identity Restyle");
        output.Should().Contain("## Composition / Scene");
        output.Should().Contain("## Story / Sequence");
        output.Should().Contain("## Character & Item Generation");
        output.Should().Contain("## Video & Prompt Sandbox");

        // Every built-in command name appears in the output.
        foreach (var w in BuiltInWorkflows.All)
        {
            output.Should().Contain(w.CommandName);
        }
    }

    [TestMethod]
    public void Result_AllOutputUris_FlattensNodeOutputs()
    {
        var nodeA = Guid.NewGuid();
        var nodeB = Guid.NewGuid();
        var result = new BuiltInWorkflowResult(
            InvocationId: Guid.NewGuid(),
            Status: BuiltInWorkflowStatus.Succeeded,
            NodeOutputs: new Dictionary<Guid, IReadOnlyList<Uri>>
            {
                [nodeA] = [new Uri("https://cdn/a1.png"), new Uri("https://cdn/a2.png")],
                [nodeB] = [new Uri("https://cdn/b.mp4")],
            });

        result.AllOutputUris.Select(u => u.AbsoluteUri).Should().BeEquivalentTo(
            ["https://cdn/a1.png", "https://cdn/a2.png", "https://cdn/b.mp4"]);
        result.IsTerminal.Should().BeTrue();
    }
}
