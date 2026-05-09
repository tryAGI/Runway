namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliShortVideoDiffTests
{
    [TestMethod]
    public void Compute_IdenticalPlans_HasNoChanges()
    {
        var plan = SamplePlan();

        var diff = RunwayCliShortVideoDiff.Compute(plan, CopyPlan(plan));

        diff.HasChanges.Should().BeFalse();
        diff.TopLevel.Should().BeEmpty();
        diff.Shots.Should().BeEmpty();
        diff.ShotCountA.Should().Be(diff.ShotCountB);
    }

    [TestMethod]
    public void Compute_TopLevelChange_OnlySurfacesChangedFields()
    {
        var planA = SamplePlan();
        var planB = CopyPlan(planA, model: "veo3.1");

        var diff = RunwayCliShortVideoDiff.Compute(planA, planB);

        diff.TopLevel.Should().HaveCount(1);
        diff.TopLevel[0].Field.Should().Be("Model");
        diff.TopLevel[0].ValueA.Should().Be("veo3.1_fast");
        diff.TopLevel[0].ValueB.Should().Be("veo3.1");
        diff.Shots.Should().BeEmpty();
    }

    [TestMethod]
    public void Compute_PerShotPromptChange_ListsTitleAndPromptDelta()
    {
        var planA = SamplePlan();
        var planB = CopyPlan(planA, mutateShot: (index, shot) => index == 1
            ? new RunwayShortVideoShot
            {
                Index = shot.Index,
                Count = shot.Count,
                Title = "Cluttered Desk Overload",
                Beat = shot.Beat,
                KeyframePrompt = "different keyframe prompt",
                VideoPrompt = shot.VideoPrompt,
            }
            : shot);

        var diff = RunwayCliShortVideoDiff.Compute(planA, planB);

        diff.Shots.Should().HaveCount(1);
        var changed = diff.Shots[0];
        changed.Index.Should().Be(1);
        changed.TitleA.Should().Be("Cluttered Before");
        changed.TitleB.Should().Be("Cluttered Desk Overload");
        changed.Fields.Select(f => f.Field).Should().BeEquivalentTo("Title", "KeyframePrompt");
    }

    [TestMethod]
    public void Compute_DifferentShotCounts_FlagsAddedAndRemoved()
    {
        var planA = SamplePlan();
        var trimmedShots = planA.Shots.Take(2).ToArray();
        var planB = new RunwayShortVideoPlan
        {
            SourceText = planA.SourceText,
            Scenario = planA.Scenario,
            Style = planA.Style,
            Model = planA.Model,
            Ratio = planA.Ratio,
            ShotDurationSeconds = planA.ShotDurationSeconds,
            Shots = trimmedShots,
        };

        var diff = RunwayCliShortVideoDiff.Compute(planA, planB);

        diff.ShotCountA.Should().Be(3);
        diff.ShotCountB.Should().Be(2);
        diff.Shots.Should().HaveCount(1);
        diff.Shots[0].Index.Should().Be(3);
        diff.Shots[0].TitleA.Should().Be("Finished Artifact");
        diff.Shots[0].TitleB.Should().BeNull();
    }

    [TestMethod]
    public void RenderText_IdenticalPlans_PrintsIdenticalLine()
    {
        var plan = SamplePlan();
        var diff = RunwayCliShortVideoDiff.Compute(plan, CopyPlan(plan));

        var text = RunwayCliShortVideoDiff.RenderText(diff);

        text.Should().Contain("Plans are identical.");
    }

    [TestMethod]
    public void RenderText_ShotChange_IncludesABBlocksForLongFields()
    {
        var planA = SamplePlan();
        var planB = CopyPlan(planA, mutateShot: (index, shot) => index == 1
            ? new RunwayShortVideoShot
            {
                Index = shot.Index,
                Count = shot.Count,
                Title = shot.Title,
                Beat = "different beat",
                KeyframePrompt = shot.KeyframePrompt,
                VideoPrompt = shot.VideoPrompt,
            }
            : shot);

        var text = RunwayCliShortVideoDiff.RenderText(RunwayCliShortVideoDiff.Compute(planA, planB));

        text.Should().Contain("=== Shot 1: Cluttered Before -> Cluttered Before ===");
        text.Should().Contain("Beat:");
        text.Should().Contain("A: chaos established");
        text.Should().Contain("B: different beat");
    }

    [TestMethod]
    public void RenderJson_OutputsValidParseableJsonWithExpectedShape()
    {
        var planA = SamplePlan();
        var planB = CopyPlan(planA, ratio: "1280:720");

        var json = RunwayCliShortVideoDiff.RenderJson(RunwayCliShortVideoDiff.Compute(planA, planB));

        var node = System.Text.Json.Nodes.JsonNode.Parse(json);
        node.Should().NotBeNull();
        node!["shotCountA"]!.GetValue<int>().Should().Be(3);
        node["shotCountB"]!.GetValue<int>().Should().Be(3);
        var topLevel = node["topLevel"]!.AsArray();
        topLevel.Count.Should().Be(1);
        topLevel[0]!["field"]!.GetValue<string>().Should().Be("Ratio");
        topLevel[0]!["a"]!.GetValue<string>().Should().Be("720:1280");
        topLevel[0]!["b"]!.GetValue<string>().Should().Be("1280:720");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoDiffSubcommandShowsInHelp()
    {
        var result = await CliHarness.RunCliAsync("short-video diff --help", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("plan-a");
        result.Stdout.Should().Contain("plan-b");
        result.Stdout.Should().Contain("--json");
    }

    private static RunwayShortVideoPlan SamplePlan() => new()
    {
        SourceText = "scenario text",
        Scenario = "compact scenario",
        Style = "cinematic",
        Model = "veo3.1_fast",
        Ratio = "720:1280",
        ShotDurationSeconds = 6,
        Shots =
        [
            new RunwayShortVideoShot
            {
                Index = 1,
                Count = 3,
                Title = "Cluttered Before",
                Beat = "chaos established",
                KeyframePrompt = "messy desk",
                VideoPrompt = "slow push-in on the chaos",
            },
            new RunwayShortVideoShot
            {
                Index = 2,
                Count = 3,
                Title = "One Clean Command",
                Beat = "pivot",
                KeyframePrompt = "single terminal",
                VideoPrompt = "dolly into the terminal",
            },
            new RunwayShortVideoShot
            {
                Index = 3,
                Count = 3,
                Title = "Finished Artifact",
                Beat = "payoff",
                KeyframePrompt = "video file on desktop",
                VideoPrompt = "pull back to reveal the result",
            },
        ],
    };

    private static RunwayShortVideoPlan CopyPlan(
        RunwayShortVideoPlan source,
        string? model = null,
        string? ratio = null,
        Func<int, RunwayShortVideoShot, RunwayShortVideoShot>? mutateShot = null)
    {
        return new RunwayShortVideoPlan
        {
            SourceText = source.SourceText,
            Scenario = source.Scenario,
            Style = source.Style,
            Model = model ?? source.Model,
            Ratio = ratio ?? source.Ratio,
            ShotDurationSeconds = source.ShotDurationSeconds,
            Shots = mutateShot is null
                ? source.Shots.Select(shot => new RunwayShortVideoShot
                {
                    Index = shot.Index,
                    Count = shot.Count,
                    Title = shot.Title,
                    Beat = shot.Beat,
                    KeyframePrompt = shot.KeyframePrompt,
                    VideoPrompt = shot.VideoPrompt,
                }).ToArray()
                : source.Shots.Select(shot => mutateShot(shot.Index, shot)).ToArray(),
        };
    }
}
