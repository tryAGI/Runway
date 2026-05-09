namespace Runway.IntegrationTests;

[TestClass]
public sealed class RunwayCliMarketingBriefTests
{
    [TestMethod]
    public void MarketingBrief_RoundTripsThroughMarkdown()
    {
        var brief = new RunwayCliMarketingBrief
        {
            ProductOneLiner = "AI espresso machine that adapts to your palate.",
            ProductCategory = "consumer hardware",
            AudiencePersona = "specialty coffee enthusiasts who already own a grinder",
            AudienceAwarenessStage = "solution-aware",
            AudiencePainPoints = "inconsistent extraction, slow morning routine",
            GoalObjective = "conversion",
            GoalCallToAction = "preorder before launch week ends",
            GoalSuccessMetric = "preorders attributed to short-video traffic",
            MessageValueProposition = "barista-grade espresso without the learning curve",
            MessageDifferentiators = "live taste tuning, single-button workflow",
            MessageProofPoints = "rated 9.2 by Coffee Review",
            VoiceTone = "confident, warm, precise",
            VoiceWordsToAvoid = "cheap, hack",
            FormatPlatform = "tiktok",
            FormatAspectRatio = "720:1280",
            FormatLengthSeconds = "30",
            FormatCaptionsOnScreen = "yes",
        };

        var markdown = RunwayCliMarketingBriefStore.ToMarkdown(brief);
        var parsed = RunwayCliMarketingBriefStore.Parse(markdown);
        var roundTrip = RunwayCliMarketingBriefStore.ToMarkdown(parsed);

        parsed.Should().BeEquivalentTo(brief);
        roundTrip.Should().Be(markdown);
    }

    [TestMethod]
    public void MarketingBrief_ParseSkipsBlankFields()
    {
        var markdown = """
            # MARKETING.md

            ## Product
            - One-liner: A short tagline
            - Category:

            ## Audience
            - Persona: builders
            - Awareness stage:
            - Pain points:
            """;

        var parsed = RunwayCliMarketingBriefStore.Parse(markdown);

        parsed.ProductOneLiner.Should().Be("A short tagline");
        parsed.ProductCategory.Should().BeNull();
        parsed.AudiencePersona.Should().Be("builders");
        parsed.AudienceAwarenessStage.Should().BeNull();
        parsed.AudiencePainPoints.Should().BeNull();
    }

    [TestMethod]
    public void MarketingBrief_RenderPlannerSectionIncludesPopulatedFields()
    {
        var brief = new RunwayCliMarketingBrief
        {
            AudiencePersona = "indie founders",
            AudienceAwarenessStage = "problem-aware",
            GoalObjective = "leads",
            GoalCallToAction = "join the waitlist",
            MessageValueProposition = "ship faster without burning out",
            VoiceTone = "honest, energetic",
            FormatPlatform = "linkedin",
            FormatAspectRatio = "1280:720",
            FormatLengthSeconds = "60",
            FormatCaptionsOnScreen = "yes",
        };

        var section = RunwayCliMarketingBriefStore.RenderPlannerSection(brief);

        section.Should().NotBeNull();
        section.Should().Contain("Audience: indie founders (problem-aware)");
        section.Should().Contain("Objective: leads");
        section.Should().Contain("Call to action: join the waitlist");
        section.Should().Contain("Core message: ship faster without burning out");
        section.Should().Contain("Tone: honest, energetic");
        section.Should().Contain("Platform: linkedin (1280:720, 60s, captions on)");
    }

    [TestMethod]
    public void MarketingBrief_RenderPlannerSectionReturnsNullWhenEmpty()
    {
        RunwayCliMarketingBriefStore.RenderPlannerSection(new RunwayCliMarketingBrief()).Should().BeNull();
    }

    [TestMethod]
    public async Task MarketingBrief_AskMissingAsyncSkipsLoadedFieldsAndAsksGaps()
    {
        var existing = new RunwayCliMarketingBrief
        {
            ProductOneLiner = "Existing product one-liner",
            ProductCategory = "SaaS",
            AudiencePersona = "ops engineers",
            AudienceAwarenessStage = "problem-aware",
            GoalObjective = "awareness",
            GoalCallToAction = "follow on LinkedIn",
            MessageValueProposition = "incident reviews without the meeting",
            VoiceTone = "calm, direct, dry",
        };

        var answers =
            "yes\n" +              // Format.CaptionsOnScreen choice (default already "yes" pre-filled, so this branch only matters when answer was empty)
            string.Empty;

        // Provide answers ONLY for the still-empty fields, in the order the questionnaire asks them.
        var script = string.Join('\n',
            string.Empty,                                   // Audience.PainPoints (optional, accept empty)
            string.Empty,                                   // Goal.SuccessMetric (optional, accept empty)
            string.Empty,                                   // Message.Differentiators (optional, accept empty)
            string.Empty,                                   // Message.ProofPoints (optional, accept empty)
            string.Empty,                                   // Voice.WordsToAvoid (optional, accept empty)
            "linkedin",                                     // Format.Platform choice
            string.Empty,                                   // Format.AspectRatio (accept default)
            string.Empty,                                   // Format.LengthSeconds (accept default)
            "yes") + "\n";                                  // Format.CaptionsOnScreen

        using var input = new StringReader(script);
        using var output = new StringWriter();

        var collected = await RunwayCliMarketingBriefStore.AskMissingAsync(
            existing,
            input,
            output,
            CancellationToken.None).ConfigureAwait(false);

        collected.ProductOneLiner.Should().Be("Existing product one-liner");
        collected.AudiencePersona.Should().Be("ops engineers");
        collected.AudienceAwarenessStage.Should().Be("problem-aware");
        collected.GoalObjective.Should().Be("awareness");
        collected.GoalCallToAction.Should().Be("follow on LinkedIn");
        collected.MessageValueProposition.Should().Be("incident reviews without the meeting");
        collected.VoiceTone.Should().Be("calm, direct, dry");
        collected.FormatPlatform.Should().Be("linkedin");
        collected.FormatAspectRatio.Should().Be("1280:720");
        collected.FormatLengthSeconds.Should().Be("60");
        collected.FormatCaptionsOnScreen.Should().Be("yes");

        output.ToString().Should().Contain("[loaded] Product.OneLiner");
    }

    [TestMethod]
    public async Task MarketingBrief_WriteAsyncIsIdempotentWhenContentUnchanged()
    {
        var directory = Directory.CreateTempSubdirectory("runway-marketing-brief-").FullName;
        try
        {
            var brief = new RunwayCliMarketingBrief
            {
                ProductOneLiner = "Stable",
                AudiencePersona = "engineers",
                AudienceAwarenessStage = "solution-aware",
                GoalObjective = "leads",
                GoalCallToAction = "sign up",
                MessageValueProposition = "ship calmly",
                VoiceTone = "calm",
                FormatPlatform = "linkedin",
                FormatAspectRatio = "1280:720",
                FormatLengthSeconds = "60",
                FormatCaptionsOnScreen = "yes",
            };

            var first = await RunwayCliMarketingBriefStore.WriteAsync(directory, brief, CancellationToken.None).ConfigureAwait(false);
            var second = await RunwayCliMarketingBriefStore.WriteAsync(directory, brief, CancellationToken.None).ConfigureAwait(false);

            first.Should().BeTrue();
            second.Should().BeFalse();
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void PlannerPrompt_OmitsMarketingBriefBlockWhenBriefIsNull()
    {
        var prompt = RunwayCliShortVideo.CreatePlannerPrompt(
            "tiny robot finds a glowing garden",
            new RunwayShortVideoOptions { ShotCount = 2 },
            RunwayCliShortVideoPlannerTools.ReadOnly);

        prompt.Should().NotContain("Marketing brief");
    }

    [TestMethod]
    public void PlannerPrompt_InjectsBriefBlockBeforeScenario()
    {
        var brief = new RunwayCliMarketingBrief
        {
            AudiencePersona = "specialty coffee enthusiasts",
            AudienceAwarenessStage = "solution-aware",
            GoalObjective = "conversion",
            GoalCallToAction = "preorder before launch week ends",
            MessageValueProposition = "barista-grade espresso without the learning curve",
            VoiceTone = "confident, warm, precise",
            FormatPlatform = "tiktok",
            FormatAspectRatio = "720:1280",
            FormatLengthSeconds = "30",
            FormatCaptionsOnScreen = "yes",
        };

        var prompt = RunwayCliShortVideo.CreatePlannerPrompt(
            "tiny robot finds a glowing garden",
            new RunwayShortVideoOptions { ShotCount = 2 },
            RunwayCliShortVideoPlannerTools.ReadOnly,
            brief);

        prompt.Should().Contain("Marketing brief");
        prompt.Should().Contain("Audience: specialty coffee enthusiasts (solution-aware)");
        prompt.Should().Contain("Call to action: preorder before launch week ends");
        prompt.Should().Contain("Platform: tiktok (720:1280, 30s, captions on)");
        prompt.IndexOf("Marketing brief", StringComparison.Ordinal).Should().BeLessThan(
            prompt.IndexOf("Scenario text:", StringComparison.Ordinal));
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoNoInteractiveBehavesAsTodayWithoutMarketingFile()
    {
        var result = await CliHarness.RunCliAsync(
            "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner deterministic --no-interactive",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"scenario\"");
        result.Stdout.Should().Contain("\"keyframePrompt\"");
        result.Stdout.Should().Contain("\"videoPrompt\"");
        result.Stderr.Should().NotContain("Updated MARKETING.md");
    }
}
