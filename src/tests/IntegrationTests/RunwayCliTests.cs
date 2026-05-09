using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task RunwayCli_HelpListsGenerationCommands()
    {
        var result = await RunCliAsync("--help").ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("video <prompt>");
        result.Stdout.Should().Contain("short-video");
        result.Stdout.Should().Contain("product-photoshoot");
        result.Stdout.Should().Contain("marketplace-cards");
        result.Stdout.Should().Contain("ad-video");
        result.Stdout.Should().Contain("image <prompt>");
        result.Stdout.Should().Contain("text-to-video");
        result.Stdout.Should().Contain("image-to-video");
        result.Stdout.Should().Contain("video-to-video");
        result.Stdout.Should().Contain("character-performance");
        result.Stdout.Should().Contain("sound-effect");
        result.Stdout.Should().Contain("speech-to-speech");
        result.Stdout.Should().Contain("text-to-speech");
        result.Stdout.Should().Contain("voice-dubbing");
        result.Stdout.Should().Contain("voice-isolation");
        result.Stdout.Should().Contain("document");
        result.Stdout.Should().Contain("upload");
        result.Stdout.Should().Contain("voice");
        result.Stdout.Should().Contain("realtime");
        result.Stdout.Should().Contain("organization");
        result.Stdout.Should().Contain("workflow");
        result.Stdout.Should().Contain("models");
        result.Stdout.Should().Contain("task");
        result.Stdout.Should().Contain("gallery");
    }

    [TestMethod]
    public async Task RunwayCli_ModelsListsAllEndpointModelFamilies()
    {
        var result = await RunCliAsync("models", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("gen4.5");
        result.Stdout.Should().Contain("short-video");
        result.Stdout.Should().Contain("gen4_aleph");
        result.Stdout.Should().Contain("gpt_image_2");
        result.Stdout.Should().Contain("eleven_voice_isolation");
        result.Stdout.Should().Contain("gwm1_avatars");
    }

    [TestMethod]
    public async Task RunwayCli_VideoCommandParsesPromptBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("video tiny test prompt --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
    }

    [TestMethod]
    public async Task RunwayCli_ImageCommandParsesPromptBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("image tiny test prompt --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoPlanOnlyDoesNotRequireApiKey()
    {
        var result = await RunCliAsync("short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner deterministic", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"scenario\"");
        result.Stdout.Should().Contain("\"keyframePrompt\"");
        result.Stdout.Should().Contain("\"videoPrompt\"");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoParsesScenarioBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("short-video tiny robot finds a glowing garden --no-wait --planner deterministic", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
    }

    [TestMethod]
    public async Task RunwayCli_ProductPhotoshootPlanOnlyDoesNotRequireApiKey()
    {
        var result = await RunCliAsync(
            "product-photoshoot create --prompt=tiny-camera --mode social_carousel --plan-only",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"kind\": \"product_photoshoot\"");
        result.Stdout.Should().Contain("\"mode\": \"social_carousel\"");
        result.Stdout.Should().Contain("\"count\": 4");
        result.Stdout.Should().Contain("\"model\": \"gpt_image_2\"");
    }

    [TestMethod]
    public async Task RunwayCli_MarketplaceCardsPlanOnlyDoesNotRequireApiKey()
    {
        var result = await RunCliAsync(
            "marketplace-cards create --prompt=tiny-camera --scope full-set --plan-only",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"kind\": \"marketplace_cards\"");
        result.Stdout.Should().Contain("\"scope\": \"full-set\"");
        result.Stdout.Should().Contain("\"count\": 9");
        result.Stdout.Should().Contain("not a compliance guarantee");
    }

    [TestMethod]
    public async Task RunwayCli_AdVideoPlanOnlyDoesNotRequireApiKey()
    {
        var result = await RunCliAsync(
            "ad-video create --prompt=tiny-camera --mode ugc --shots 2 --plan-only",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"kind\": \"ad_video\"");
        result.Stdout.Should().Contain("\"mode\": \"ugc\"");
        result.Stdout.Should().Contain("\"count\": 2");
        result.Stdout.Should().Contain("\"model\": \"veo3.1_fast\"");
    }

    [TestMethod]
    public async Task RunwayCli_CreativeRecipeCommandsParseBeforeRequiringApiKey()
    {
        var product = await RunCliAsync(
            "product-photoshoot create --prompt=tiny-camera --mode product_shot --no-wait",
            removeApiKey: true).ConfigureAwait(false);
        var marketplace = await RunCliAsync(
            "marketplace-cards create --prompt=tiny-camera --scope main --no-wait",
            removeApiKey: true).ConfigureAwait(false);
        var ad = await RunCliAsync(
            "ad-video create --prompt=tiny-camera --mode ugc --shots 1 --no-wait",
            removeApiKey: true).ConfigureAwait(false);

        product.ExitCode.Should().Be(1);
        marketplace.ExitCode.Should().Be(1);
        ad.ExitCode.Should().Be(1);
        product.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
        marketplace.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
        ad.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoAutoFallsBackToDeterministicWhenNoExternalPlannerIsFound()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-no-planner-").FullName;

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner auto",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"scenario\"");
            result.Stdout.Should().Contain("\"keyframePrompt\"");
            result.Stderr.Should().Contain("Short-video planner: Deterministic");
            result.Stderr.Should().Contain("Short-video planner: Deterministic");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoAutoPlansBeforeRequiringApiKey()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-no-planner-").FullName;

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --no-wait --planner auto",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(1);
            result.Stderr.Should().Contain("Short-video planner: Deterministic");
            result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoPlannerCanBeSelectedFromEnvironment()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-no-planner-").FullName;

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only",
                removeApiKey: true,
                environment: new Dictionary<string, string?>
                {
                    ["PATH"] = plannerPath,
                    ["RUNWAY_SHORT_VIDEO_PLANNER"] = "deterministic",
                }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"keyframePrompt\"");
            result.Stderr.Should().Contain("Short-video planner: Deterministic");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoExplicitUnavailableExternalPlannerFailsClearly()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-no-planner-").FullName;

        try
        {
            var claude = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --plan-only --planner claude",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);
            var codex = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --plan-only --planner codex",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            claude.ExitCode.Should().Be(1);
            claude.Stderr.Should().Contain("Claude planner was requested");
            claude.Stderr.Should().Contain("`claude` was not found on PATH");
            codex.ExitCode.Should().Be(1);
            codex.Stderr.Should().Contain("Codex planner was requested");
            codex.Stderr.Should().Contain("`codex` was not found on PATH");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayShortVideoPlanner_CreatesKeyframePromptsAndTextToVideoRequest()
    {
        var options = new RunwayShortVideoOptions
        {
            ShotCount = 3,
            ShotDurationSeconds = 4,
            Style = "warm macro sci-fi product film",
            Seed = 42,
        };

        var plan = RunwayShortVideoExtensions.CreateShortVideoPlan(
            "A tiny robot wakes inside a workshop. It finds a glowing seed. The seed becomes a rooftop garden at sunrise.",
            options);

        plan.Shots.Should().HaveCount(3);
        plan.Scenario.Should().Contain("3-shot short film");
        plan.Shots[0].KeyframePrompt.Should().Contain("Establishing keyframe");
        plan.Shots[1].VideoPrompt.Should().Contain("Short film shot 2 of 3");
        plan.Shots[2].VideoPrompt.Should().Contain("Resolution keyframe");

        var request = RunwayShortVideoExtensions.CreateTextToVideoRequest(plan.Shots[0].VideoPrompt, options);

        request.IsVeo31Fast.Should().BeTrue();
        request.Veo31Fast!.PromptText.Should().Be(plan.Shots[0].VideoPrompt);
        request.Veo31Fast.Ratio.Should().Be(CreateTextToVideoRequestVeo31FastRatio.x1280_720);
        request.Veo31Fast.Duration.Should().Be(4);
        request.Veo31Fast.Audio.Should().BeFalse();
        request.Veo31Fast.AdditionalProperties["seed"].Should().Be(42);
    }

    [TestMethod]
    public async Task RunwayShortVideoPlanner_UsesDelegatePlanAndJsonContextRoundTrips()
    {
        var options = new RunwayShortVideoOptions
        {
            ShotCount = 2,
            ShotDurationSeconds = 5,
            Ratio = "720:1280",
            Style = "editorial vertical short",
        };

        var plan = await RunwayShortVideoExtensions.CreateShortVideoPlanAsync(
            "A glass flower opens on a rainy street.",
            static (scenario, plannerOptions, _) => ValueTask.FromResult<RunwayShortVideoPlan?>(new RunwayShortVideoPlan
            {
                SourceText = scenario,
                Scenario = "Two-shot rainy street film.",
                Style = plannerOptions.Style!,
                Model = plannerOptions.Model,
                Ratio = plannerOptions.Ratio,
                ShotDurationSeconds = plannerOptions.ShotDurationSeconds,
                Shots =
                [
                    new RunwayShortVideoShot
                    {
                        Index = 1,
                        Count = 2,
                        Title = "Opening",
                        Beat = "A glass flower rests on wet pavement.",
                        KeyframePrompt = "Macro keyframe of a glass flower on reflective pavement.",
                        VideoPrompt = "Slow macro push toward a glass flower on reflective pavement.",
                    },
                    new RunwayShortVideoShot
                    {
                        Index = 2,
                        Count = 2,
                        Title = "Bloom",
                        Beat = "The flower opens under soft rain.",
                        KeyframePrompt = "Glass petals opening under soft rain.",
                        VideoPrompt = "The glass flower blooms as rain ripples around it.",
                    },
                ],
            }),
            options).ConfigureAwait(false);

        plan.Shots.Should().HaveCount(2);
        plan.Ratio.Should().Be("720:1280");
        plan.Shots[1].VideoPrompt.Should().Contain("blooms");

        var json = JsonSerializer.Serialize(plan, RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan);
        json.Should().Contain("sourceText");
        json.Should().Contain("keyframePrompt");

        var roundTrip = JsonSerializer.Deserialize(json, RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan);
        roundTrip!.Shots.Should().HaveCount(2);
        roundTrip.Ratio.Should().Be("720:1280");
    }

    [TestMethod]
    public async Task RunwayShortVideoPlanner_IChatClientRequestsJsonSchemaResponseFormat()
    {
        var chatClient = new CapturingChatClient(_ => CreateChatResponse(CreatePlannerPlanJson()));

        var plan = await chatClient.CreateShortVideoPlanAsync(
            "A glass flower opens on a rainy street.",
            new RunwayShortVideoOptions { ShotCount = 2 }).ConfigureAwait(false);

        plan.Shots.Should().HaveCount(2);
        chatClient.CapturedOptions.Should().HaveCount(1);

        var responseFormat = chatClient.CapturedOptions[0]!.ResponseFormat;
        var schemaFormat = responseFormat.Should().BeOfType<ChatResponseFormatJson>().Subject;
        schemaFormat.SchemaName.Should().Be("runway_short_video_plan");
        schemaFormat.SchemaDescription.Should().Contain("Runway short-video storyboard plan");
        schemaFormat.Schema.Should().NotBeNull();
    }

    [TestMethod]
    public async Task RunwayShortVideoPlanner_IChatClientDeserializesAndNormalizesStructuredJson()
    {
        var chatClient = new CapturingChatClient(_ => CreateChatResponse(CreatePlannerPlanJson(
            new RunwayShortVideoOptions { ShotCount = 2, ShotDurationSeconds = 7, Ratio = "720:1280" },
            preserveRequestedOptions: false)));

        var plan = await chatClient.CreateShortVideoPlanAsync(
            "A glass flower opens on a rainy street.",
            new RunwayShortVideoOptions { ShotCount = 2, ShotDurationSeconds = 7, Ratio = "720:1280" }).ConfigureAwait(false);

        plan.Model.Should().Be(RunwayShortVideoOptions.DefaultModel);
        plan.Ratio.Should().Be("720:1280");
        plan.ShotDurationSeconds.Should().Be(7);
        plan.Shots.Should().HaveCount(2);
        plan.Shots[0].Index.Should().Be(1);
        plan.Shots[0].Count.Should().Be(2);
        plan.Shots[1].Index.Should().Be(2);
        plan.Shots[1].Count.Should().Be(2);
    }

    [TestMethod]
    public async Task RunwayShortVideoPlanner_IChatClientFallsBackWhenJsonSchemaResponseFormatIsUnsupported()
    {
        var chatClient = new CapturingChatClient(
            _ => throw new NotSupportedException("JSON schema response format is not supported."),
            _ => CreateChatResponse(CreatePlannerPlanJson()));

        var plan = await chatClient.CreateShortVideoPlanAsync(
            "A glass flower opens on a rainy street.",
            new RunwayShortVideoOptions { ShotCount = 2 }).ConfigureAwait(false);

        plan.Shots.Should().HaveCount(2);
        chatClient.CapturedOptions.Should().HaveCount(2);
        chatClient.CapturedOptions[0]!.ResponseFormat.Should().BeOfType<ChatResponseFormatJson>();
        chatClient.CapturedOptions[1]!.ResponseFormat.Should().BeSameAs(ChatResponseFormat.Json);
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoClaudePlannerUsesValidJsonAndNormalizesPlan()
    {
        var plannerPath = await CreateFakePlannerDirectoryAsync(
            "claude",
            CreatePlannerPlanJson(
                new RunwayShortVideoOptions { ShotCount = 2, ShotDurationSeconds = 7, Ratio = "720:1280" },
                preserveRequestedOptions: false)).ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video a glass flower opens on a rainy street --shots 2 --duration 7 --ratio 720:1280 --plan-only --planner claude --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"ratio\": \"720:1280\"");
            result.Stdout.Should().Contain("\"shotDurationSeconds\": 7");
            result.Stdout.Should().Contain("\"index\": 1");
            result.Stdout.Should().Contain("\"count\": 2");
            result.Stderr.Should().Contain("Short-video planner: Claude");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoClaudePlannerUsesLocalClaudeAuthMode()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-claude-args-").FullName;
        var outputPath = Path.Combine(plannerPath, "plan.json");
        var argsPath = Path.Combine(plannerPath, "args.txt");
        await File.WriteAllTextAsync(outputPath, CreatePlannerPlanJson(new RunwayShortVideoOptions { ShotCount = 2 })).ConfigureAwait(false);
        await AddFakePlannerScriptAsync(
            plannerPath,
            "claude",
            $"#!/bin/sh\nprintf '%s\\n' \"$@\" > \"{argsPath}\"\n/bin/cat \"{outputPath}\"\n",
            $"@echo off\r\necho %* > \"{argsPath}\"\r\ntype \"{outputPath}\"\r\n").ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video a glass flower opens on a rainy street --shots 2 --plan-only --planner claude --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            var args = await File.ReadAllTextAsync(argsPath).ConfigureAwait(false);
            args.Should().Contain("--print");
            args.Should().Contain("--json-schema");
            args.Should().Contain("--permission-mode");
            args.Should().Contain("--");
            args.Should().NotContain("--bare");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoClaudePlannerNormalizesCommonSchemaAliases()
    {
        var plannerPath = await CreateFakePlannerDirectoryAsync(
            "claude",
            """
            {
              "sourceText": "A glass flower opens on a rainy street.",
              "scenario": "A two-shot rainy street product-style film.",
              "style": "warm editorial",
              "model": "veo3.1_fast",
              "ratio": "1280:720",
              "shotDurationSeconds": 4,
              "shots": [
                {
                  "index": 1,
                  "count": 2,
                  "title": "Street reveal",
                  "storyBeat": "The glass flower rests on wet pavement.",
                  "imagePrompt": "Macro still of a glass flower on wet pavement.",
                  "motionPrompt": "Slow push toward the glass flower as rain glows around it."
                },
                {
                  "index": 2,
                  "count": 2,
                  "title": "Bloom",
                  "description": "The flower opens under soft rain.",
                  "keyframe": "Glass petals opening under soft rain.",
                  "prompt": "The glass flower blooms as water ripples outward."
                }
              ]
            }
            """).ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video a glass flower opens on a rainy street --shots 2 --plan-only --planner claude --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"beat\": \"The glass flower rests on wet pavement.\"");
            result.Stdout.Should().Contain("\"keyframePrompt\": \"Macro still of a glass flower on wet pavement.\"");
            result.Stdout.Should().Contain("\"videoPrompt\": \"Slow push toward the glass flower as rain glows around it.\"");
            result.Stderr.Should().Contain("Short-video planner: Claude");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoAutoFallsBackWhenExternalPlannerReturnsInvalidJson()
    {
        var plannerPath = await CreateFakePlannerDirectoryAsync("claude", "not-json").ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner auto --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"scenario\"");
            result.Stdout.Should().Contain("\"keyframePrompt\"");
            result.Stderr.Should().Contain("Short-video planner: Deterministic");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoAutoUsesCodexWhenClaudeReturnsInvalidJson()
    {
        var plannerPath = await CreateFakePlannerDirectoryAsync("claude", "not-json").ConfigureAwait(false);
        await AddFakePlannerExecutableAsync(
            plannerPath,
            "codex",
            CreatePlannerPlanJson(new RunwayShortVideoOptions { ShotCount = 2 })).ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner auto --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("\"scenario\"");
            result.Stdout.Should().Contain("\"keyframePrompt\"");
            result.Stderr.Should().Contain("Short-video planner: Codex");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoExplicitExternalPlannerFailsWhenJsonIsInvalid()
    {
        var plannerPath = await CreateFakePlannerDirectoryAsync("claude", "not-json").ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner claude --planner-timeout-seconds 10",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(1);
            result.Stderr.Should().Contain("Claude planner returned invalid short-video JSON");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoExplicitExternalPlannerFailsWhenPlannerTimesOut()
    {
        var plannerPath = Directory.CreateTempSubdirectory("runway-slow-planner-").FullName;
        await AddFakePlannerScriptAsync(
            plannerPath,
            "claude",
            "#!/bin/sh\n/bin/sleep 5\n",
            "@echo off\r\nping -n 6 127.0.0.1 >nul\r\n").ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner claude --planner-timeout-seconds 1",
                removeApiKey: true,
                environment: new Dictionary<string, string?> { ["PATH"] = plannerPath }).ConfigureAwait(false);

            result.ExitCode.Should().Be(1);
            result.Stderr.Should().Contain("Claude planner timed out after 1 seconds");
        }
        finally
        {
            Directory.Delete(plannerPath, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoRunParsesPlanBeforeRequiringApiKey()
    {
        var plan = RunwayShortVideoExtensions.CreateShortVideoPlan(
            "A tiny robot finds a glowing garden.",
            new RunwayShortVideoOptions { ShotCount = 2 });
        var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.json");
        await File.WriteAllTextAsync(path, RunwayCliShortVideo.ToJson(plan)).ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync($"short-video run --plan {path} --no-wait", removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(1);
            result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET");
        }
        finally
        {
            File.Delete(path);
        }
    }

    [TestMethod]
    public async Task RunwayCliShortVideo_ReadPlanAsyncLoadsEditedPlanJson()
    {
        var plan = RunwayShortVideoExtensions.CreateShortVideoPlan(
            "A tiny robot finds a glowing garden.",
            new RunwayShortVideoOptions { ShotCount = 2, Ratio = "720:1280" });
        var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.json");
        await File.WriteAllTextAsync(path, RunwayCliShortVideo.ToJson(plan)).ConfigureAwait(false);

        try
        {
            var loaded = await RunwayCliShortVideo.ReadPlanAsync(path, CancellationToken.None).ConfigureAwait(false);

            loaded.Shots.Should().HaveCount(2);
            loaded.Ratio.Should().Be("720:1280");
            loaded.Shots[0].VideoPrompt.Should().Contain("Short film shot 1 of 2");
        }
        finally
        {
            File.Delete(path);
        }
    }

    [TestMethod]
    public void RunwayCliShortVideo_ResolvesFileOutputToSegmentDirectoryAndFinalVideo()
    {
        var directory = Directory.CreateTempSubdirectory("runway-short-video-test-").FullName;

        try
        {
            var finalPath = Path.Combine(directory, "final.mp4");
            var output = RunwayCliShortVideo.ResolveOutput(finalPath, new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc));

            output.FinalOutput.Should().Be(finalPath);
            output.SegmentDirectory.Should().Be(Path.Combine(directory, "final-segments"));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliShortVideo_NameReplacesTimestampStemWhenOutputIsDirectory()
    {
        var directory = Directory.CreateTempSubdirectory("runway-short-video-name-test-").FullName;

        try
        {
            var output = RunwayCliShortVideo.ResolveOutput(directory, new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc), name: "v4");

            output.SegmentDirectory.Should().Be(directory);
            output.FinalOutput.Should().Be(Path.Combine(directory, "runway-short-video-v4.mp4"));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliShortVideo_NameReplacesTimestampStemWhenOutputOmitted()
    {
        var output = RunwayCliShortVideo.ResolveOutput(output: null, new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc), name: "marketing-v4");

        var expectedDirectory = Path.Combine(Environment.CurrentDirectory, "runway-short-video-marketing-v4");
        output.SegmentDirectory.Should().Be(expectedDirectory);
        output.FinalOutput.Should().Be(Path.Combine(expectedDirectory, "runway-short-video-marketing-v4.mp4"));
    }

    [TestMethod]
    public void RunwayCliShortVideo_NameIsIgnoredWhenOutputIsExplicitFilePath()
    {
        var directory = Directory.CreateTempSubdirectory("runway-short-video-name-explicit-test-").FullName;

        try
        {
            var finalPath = Path.Combine(directory, "launch.mp4");
            var output = RunwayCliShortVideo.ResolveOutput(finalPath, new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc), name: "v4");

            output.FinalOutput.Should().Be(finalPath);
            output.SegmentDirectory.Should().Be(Path.Combine(directory, "launch-segments"));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliShortVideo_NameRejectsPathSeparators()
    {
        var act = () => RunwayCliShortVideo.ResolveOutput(output: null, new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc), name: "bad/name");

        act.Should().Throw<ArgumentException>();
    }

    [TestMethod]
    public void RunwayCliNaming_AutoNameStartsAtOneInEmptyDirectory()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-empty-").FullName;

        try
        {
            var name = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-short-video-",
                namePrefix: "v",
                scanDirectory: directory);

            name.Should().Be("v1");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliNaming_AutoNameIncrementsPastHighestSibling()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-incr-").FullName;

        try
        {
            File.WriteAllText(Path.Combine(directory, "runway-short-video-v1.mp4"), string.Empty);
            File.WriteAllText(Path.Combine(directory, "runway-short-video-v3.plan.json"), "{}");
            Directory.CreateDirectory(Path.Combine(directory, "runway-short-video-v2"));
            File.WriteAllText(Path.Combine(directory, "runway-short-video-other.mp4"), string.Empty);

            var name = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-short-video-",
                namePrefix: "v",
                scanDirectory: directory);

            name.Should().Be("v4");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliNaming_AutoNameIgnoresUnrelatedSiblings()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-isolation-").FullName;

        try
        {
            File.WriteAllText(Path.Combine(directory, "runway-product-photoshoot-v9-01-foo.png"), string.Empty);
            File.WriteAllText(Path.Combine(directory, "unrelated-v8.mp4"), string.Empty);

            var name = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-short-video-",
                namePrefix: "v",
                scanDirectory: directory);

            name.Should().Be("v1");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliNaming_AutoNameDoesNotConflateLongerSuffixes()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-suffix-").FullName;

        try
        {
            File.WriteAllText(Path.Combine(directory, "runway-short-video-v33.mp4"), string.Empty);

            var name = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-short-video-",
                namePrefix: "v",
                scanDirectory: directory);

            name.Should().Be("v34");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliNaming_ResolveAutoNameScanDirectoryFallsBackToCwdWhenOutputIsNull()
    {
        var directory = RunwayCliNaming.ResolveAutoNameScanDirectory(output: null);

        directory.Should().Be(Environment.CurrentDirectory);
    }

    [TestMethod]
    public void RunwayCliNaming_ResolveAutoNameScanDirectoryUsesParentForFileOutput()
    {
        var temp = Directory.CreateTempSubdirectory("runway-auto-name-scan-parent-").FullName;

        try
        {
            var directory = RunwayCliNaming.ResolveAutoNameScanDirectory(Path.Combine(temp, "result.mp4"));

            directory.Should().Be(temp);
        }
        finally
        {
            Directory.Delete(temp, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCli_AutoNameAndResolveOutputProduceMatchingPaths()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-resolve-end-to-end-").FullName;

        try
        {
            File.WriteAllText(Path.Combine(directory, "runway-short-video-v3.mp4"), string.Empty);

            var resolvedName = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-short-video-",
                namePrefix: "v",
                scanDirectory: directory);

            var output = RunwayCliShortVideo.ResolveOutput(
                output: directory,
                utcNow: new DateTime(2026, 5, 9, 0, 0, 0, DateTimeKind.Utc),
                name: resolvedName);

            resolvedName.Should().Be("v4");
            output.SegmentDirectory.Should().Be(directory);
            output.FinalOutput.Should().Be(Path.Combine(directory, "runway-short-video-v4.mp4"));
            RunwayCliShortVideo.ResolvePlanOutputPath(output).Should().Be(Path.Combine(directory, "runway-short-video-v4.plan.json"));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoAutoNameSurfacesResolvedNameInStderr()
    {
        var directory = Directory.CreateTempSubdirectory("runway-cli-auto-name-smoke-").FullName;

        try
        {
            await File.WriteAllTextAsync(Path.Combine(directory, "runway-short-video-v3.mp4"), string.Empty).ConfigureAwait(false);

            var result = await RunCliAsync(
                $"short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner deterministic --auto-name v --output {directory}",
                removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stderr.Should().Contain("Auto-name resolved to: v4");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoNameAndAutoNameAreMutuallyExclusive()
    {
        var result = await RunCliAsync(
            "short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner deterministic --name v3 --auto-name v",
            removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().NotBe(0);
        result.Stderr.Should().Contain("--name and --auto-name are mutually exclusive");
    }

    [TestMethod]
    public async Task RunwayCli_RecipeAutoNameSurfacesResolvedNameInPlanOnly()
    {
        var directory = Directory.CreateTempSubdirectory("runway-cli-recipe-auto-name-smoke-").FullName;

        try
        {
            await File.WriteAllTextAsync(Path.Combine(directory, "runway-product-photoshoot-v2-01-foo.png"), string.Empty).ConfigureAwait(false);

            var result = await RunCliAsync(
                $"product-photoshoot create --prompt brushed-steel-kettle --plan-only --auto-name v --output {directory}",
                removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stderr.Should().Contain("Auto-name resolved to: v3");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_RecipeAutoNameResolvedEagerlyBeforePlanOnlyShortCircuit()
    {
        var directory = Directory.CreateTempSubdirectory("runway-cli-recipe-eager-resolution-").FullName;

        try
        {
            await File.WriteAllTextAsync(Path.Combine(directory, "runway-product-photoshoot-v7-01-foo.png"), string.Empty).ConfigureAwait(false);

            var result = await RunCliAsync(
                $"product-photoshoot create --prompt brushed-steel-kettle --plan-only --auto-name v --output {directory}",
                removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stderr.Should().Contain("Auto-name resolved to: v8");
            result.Stdout.Should().Contain("\"kind\"");
            result.Stdout.Should().Contain("\"jobs\"");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_AutoNameAcceptsNamePrefixAlias()
    {
        var directory = Directory.CreateTempSubdirectory("runway-cli-name-prefix-alias-").FullName;

        try
        {
            await File.WriteAllTextAsync(Path.Combine(directory, "runway-short-video-v5.mp4"), string.Empty).ConfigureAwait(false);

            var result = await RunCliAsync(
                $"short-video tiny robot finds a glowing garden --shots 2 --plan-only --planner deterministic --name-prefix v --output {directory}",
                removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stderr.Should().Contain("Auto-name resolved to: v6");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliNaming_AutoNameMatchesSiblingsWithTrailingDashIndex()
    {
        var directory = Directory.CreateTempSubdirectory("runway-auto-name-recipe-").FullName;

        try
        {
            File.WriteAllText(Path.Combine(directory, "runway-product-photoshoot-v2-01-hero.png"), string.Empty);
            File.WriteAllText(Path.Combine(directory, "runway-product-photoshoot-v2-02-detail.png"), string.Empty);
            File.WriteAllText(Path.Combine(directory, "runway-product-photoshoot-v3-01-hero.png"), string.Empty);
            File.WriteAllText(Path.Combine(directory, "runway-marketplace-cards-v9-01-foo.png"), string.Empty);

            var name = RunwayCliNaming.ComputeNextNameWithPrefix(
                stemPrefix: "runway-product-photoshoot-",
                namePrefix: "v",
                scanDirectory: directory);

            name.Should().Be("v4");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCliShortVideo_WritesPlanBesideFinalVideo()
    {
        var directory = Directory.CreateTempSubdirectory("runway-short-video-plan-test-").FullName;
        var output = RunwayCliShortVideo.ResolveOutput(Path.Combine(directory, "launch.mp4"), new DateTime(2026, 5, 8, 15, 0, 0, DateTimeKind.Utc));
        var plan = RunwayShortVideoExtensions.CreateShortVideoPlan(
            "A small shop launches a new mug.",
            new RunwayShortVideoOptions { ShotCount = 2 });

        try
        {
            var path = await RunwayCliShortVideo.WritePlanAsync(plan, output, CancellationToken.None).ConfigureAwait(false);

            path.Should().Be(Path.Combine(directory, "launch.plan.json"));
            File.Exists(path).Should().BeTrue();
            var json = await File.ReadAllTextAsync(path).ConfigureAwait(false);
            json.Should().Contain("\"sourceText\"");
            json.Should().Contain("\"shots\"");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayCliShortVideo_CreatesFfmpegConcatArguments()
    {
        var startInfo = RunwayCliShortVideo.CreateConcatStartInfo(
            "ffmpeg",
            "/tmp/list.txt",
            "/tmp/final.mp4",
            streamCopy: true);

        var arguments = startInfo.ArgumentList.ToArray();
        arguments.Should().ContainInOrder("-f", "concat", "-safe", "0", "-i", "/tmp/list.txt");
        arguments.Should().ContainInOrder("-c", "copy");
        arguments.Should().EndWith("/tmp/final.mp4");
    }

    [TestMethod]
    public void RunwayCliShortVideo_CreatesFfmpegConcatListLines()
    {
        var lines = RunwayCliShortVideo.CreateConcatListLines(["/tmp/one.mp4", "/tmp/two's.mp4"]);

        lines.Should().Equal(
            "file '/tmp/one.mp4'",
            "file '/tmp/two\\'s.mp4'");
    }

    [TestMethod]
    public async Task RunwayCliShortVideo_RealFfmpegConcatSmoke()
    {
        var ffmpeg = CliHarness.FindExecutableOnPath("ffmpeg")
            ?? throw new AssertInconclusiveException("ffmpeg is not available.");
        var directory = Directory.CreateTempSubdirectory("runway-ffmpeg-concat-").FullName;
        var first = Path.Combine(directory, "first.mp4");
        var second = Path.Combine(directory, "second.mp4");
        var output = Path.Combine(directory, "joined.mp4");

        try
        {
            await RunProcessForTestAsync(
                ffmpeg,
                [
                    "-y",
                    "-hide_banner",
                    "-loglevel",
                    "error",
                    "-f",
                    "lavfi",
                    "-i",
                    "color=c=red:s=64x64:d=0.2",
                    "-pix_fmt",
                    "yuv420p",
                    first,
                ]).ConfigureAwait(false);
            await RunProcessForTestAsync(
                ffmpeg,
                [
                    "-y",
                    "-hide_banner",
                    "-loglevel",
                    "error",
                    "-f",
                    "lavfi",
                    "-i",
                    "color=c=blue:s=64x64:d=0.2",
                    "-pix_fmt",
                    "yuv420p",
                    second,
                ]).ConfigureAwait(false);

            var result = await RunwayCliShortVideo.TryConcatAsync(
                [first, second],
                output,
                ffmpeg,
                CancellationToken.None).ConfigureAwait(false);

            result.Output.Should().Be(output);
            result.Warning.Should().BeNull();
            File.Exists(output).Should().BeTrue();
            new FileInfo(output).Length.Should().BeGreaterThan(0);
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCliGallery_CreatesHtmlForVideosAndPlans()
    {
        var directory = Directory.CreateTempSubdirectory("runway-gallery-test-").FullName;
        var videoPath = Path.Combine(directory, "launch video.mp4");
        var planPath = Path.Combine(directory, "launch video.plan.json");

        try
        {
            await File.WriteAllBytesAsync(videoPath, [0, 1, 2, 3]).ConfigureAwait(false);
            await File.WriteAllTextAsync(planPath, "{}").ConfigureAwait(false);

            var output = await RunwayCliGallery.CreateAsync(
                directory,
                null,
                recursive: false,
                title: "Launch Gallery",
                CancellationToken.None).ConfigureAwait(false);

            File.Exists(output).Should().BeTrue();
            var html = await File.ReadAllTextAsync(output).ConfigureAwait(false);
            html.Should().Contain("Launch Gallery");
            html.Should().Contain("launch video.mp4");
            html.Should().Contain("launch%20video.mp4");
            html.Should().Contain("launch%20video.plan.json");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_GalleryCreateDoesNotRequireApiKey()
    {
        var directory = Directory.CreateTempSubdirectory("runway-gallery-cli-test-").FullName;
        var videoPath = Path.Combine(directory, "clip.mp4");
        await File.WriteAllBytesAsync(videoPath, [0, 1, 2, 3]).ConfigureAwait(false);

        try
        {
            var result = await RunCliAsync(
                $"gallery create --input {directory} --title Gallery",
                removeApiKey: true).ConfigureAwait(false);

            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain(Path.Combine(directory, "runway-gallery.html"));
            File.Exists(Path.Combine(directory, "runway-gallery.html")).Should().BeTrue();
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public async Task RunwayCli_NormalizesLocalReferenceImagesAsDataUris()
    {
        var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid():N}.png");
        await File.WriteAllBytesAsync(path, [1, 2, 3]).ConfigureAwait(false);

        try
        {
            var images = await RunwayCliGeneration.CreateGemini25FlashReferenceImagesAsync([path], CancellationToken.None).ConfigureAwait(false);

            images.Should().ContainSingle();
            images[0].Tag.Should().Be("reference1");
            images[0].Uri.Should().Be("data:image/png;base64,AQID");
        }
        finally
        {
            File.Delete(path);
        }
    }

    [TestMethod]
    public async Task RunwayCli_RejectsTooManyReferenceImages()
    {
        var act = () => RunwayCliGeneration.CreateGemini25FlashReferenceImagesAsync(
            ["https://example.com/1.png", "https://example.com/2.png", "https://example.com/3.png", "https://example.com/4.png"],
            CancellationToken.None);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("Runway accepts up to three reference images.").ConfigureAwait(false);
    }

    [TestMethod]
    public async Task RunwayCli_CreatesGptImage2RequestWithQualityAndSixteenReferences()
    {
        var references = Enumerable.Range(1, 16)
            .Select(index => $"https://example.com/reference-{index}.png")
            .ToArray();

        var request = await RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
            "poster with crisp product typography",
            "1920:1088",
            references,
            "1K",
            "low",
            1,
            CancellationToken.None).ConfigureAwait(false);

        request.PromptText.Should().Be("poster with crisp product typography");
        request.Ratio.Should().Be("1920:1088");
        request.Resolution.Should().BeNull();
        request.Quality.Should().Be(GptImage2Quality.Low);
        request.OutputCount.Should().Be(1);
        request.ReferenceImages.Should().HaveCount(16);
        request.ReferenceImages![15].Tag.Should().Be("reference16");
    }

    [TestMethod]
    public void RunwayCli_UsesModelSpecificTextToImageRatioDefaults()
    {
        RunwayCliGeneration.ResolveTextToImageRatio(null, "gemini_2.5_flash").Should().Be("1024:1024");
        RunwayCliGeneration.ResolveTextToImageRatio(null, "gpt_image_2").Should().Be("1920:1920");
        RunwayCliGeneration.ResolveTextToImageRatio(" 1920:1088 ", "gpt_image_2").Should().Be("1920:1088");
    }

    [TestMethod]
    public async Task RunwayCli_RejectsGen4ImageTurboWithoutReferenceImage()
    {
        var act = () => RunwayCliGeneration.CreateTextToImageJsonBodyAsync(
            "clean product poster",
            "gen4-image-turbo",
            "1280:720",
            referenceImages: null,
            referenceSubject: "object",
            seed: null,
            outputCount: null,
            publicFigureThreshold: null,
            resolution: null,
            quality: null,
            CancellationToken.None);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("gen4-image-turbo requires at least one --reference-image. Use gpt-image-2 or gemini-2.5-flash for text-only image generation.").ConfigureAwait(false);
    }

    [TestMethod]
    public async Task RunwayCli_RejectsTooManyGptImage2ReferenceImages()
    {
        var act = () => RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
            "poster with crisp product typography",
            "1920:1088",
            Enumerable.Range(1, 17).Select(index => $"https://example.com/reference-{index}.png").ToArray(),
            "1K",
            "low",
            1,
            CancellationToken.None);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("GPT Image 2 accepts up to 16 reference images.").ConfigureAwait(false);
    }

    [TestMethod]
    public void RunwayCliCreativeRecipes_ProductPhotoshootModesCreateRoundTrippablePlans()
    {
        var expectedCounts = new Dictionary<string, int>
        {
            ["product_shot"] = 1,
            ["lifestyle_scene"] = 1,
            ["hero_banner"] = 1,
            ["social_carousel"] = 4,
            ["ad_creative_pack"] = 4,
            ["virtual_model_tryout"] = 1,
            ["conceptual_product"] = 1,
            ["restyle"] = 1,
        };

        foreach (var (mode, expectedCount) in expectedCounts)
        {
            var plan = RunwayCliCreativeRecipes.CreateProductPhotoshootPlan(
                "transparent speaker",
                ["https://example.com/product.png"],
                count: null,
                ratio: null,
                model: null,
                mode,
                productContext: "glass body with visible drivers",
                brandContext: "premium calm studio",
                quality: null,
                resolution: null);

            plan.Kind.Should().Be(RunwayCliCreativeRecipes.ProductPhotoshootKind);
            plan.Mode.Should().Be(mode);
            plan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultImageModel);
            plan.Ratio.Should().Be(RunwayCliCreativeRecipes.DefaultImageRatio);
            plan.Count.Should().Be(expectedCount);
            plan.Jobs.Should().HaveCount(expectedCount);
            plan.Jobs.Should().OnlyContain(job => job.Prompt.Contains("positive phrasing", StringComparison.OrdinalIgnoreCase));
            plan.Jobs.Should().OnlyContain(job => job.ReferenceImages.Contains("https://example.com/product.png"));

            var json = RunwayCliCreativeRecipes.ToJson(plan);
            var roundTrip = JsonSerializer.Deserialize(
                json,
                RunwayCliCreativeRecipeJsonSerializerContext.Default.RunwayCliCreativeRecipePlan);

            roundTrip!.Kind.Should().Be(plan.Kind);
            roundTrip.Jobs.Should().HaveCount(expectedCount);
            roundTrip.ReferenceImages.Should().ContainSingle().Which.Should().Be("https://example.com/product.png");
        }
    }

    [TestMethod]
    public void RunwayCliCreativeRecipes_MarketplaceScopesCreateExpectedLabelsAndRoundTrip()
    {
        var expectedCounts = new Dictionary<string, int>
        {
            ["main"] = 1,
            ["product-images"] = 4,
            ["aplus"] = 4,
            ["full-set"] = 9,
        };

        foreach (var (scope, expectedCount) in expectedCounts)
        {
            var plan = RunwayCliCreativeRecipes.CreateMarketplaceCardsPlan(
                "wireless travel kettle",
                ["https://example.com/asset.png"],
                count: null,
                ratio: null,
                model: null,
                scope,
                category: "kitchen",
                visualStyle: "bright editorial");

            plan.Kind.Should().Be(RunwayCliCreativeRecipes.MarketplaceCardsKind);
            plan.Scope.Should().Be(scope);
            plan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultImageModel);
            plan.Ratio.Should().Be(RunwayCliCreativeRecipes.DefaultImageRatio);
            plan.Count.Should().Be(expectedCount);
            plan.Jobs.Should().HaveCount(expectedCount);
            plan.Jobs.Should().OnlyContain(job => job.Prompt.Contains("not a compliance guarantee", StringComparison.OrdinalIgnoreCase));
            plan.Assets.Should().ContainSingle().Which.Should().Be("https://example.com/asset.png");

            var json = RunwayCliCreativeRecipes.ToJson(plan);
            var roundTrip = JsonSerializer.Deserialize(
                json,
                RunwayCliCreativeRecipeJsonSerializerContext.Default.RunwayCliCreativeRecipePlan);

            roundTrip!.Scope.Should().Be(scope);
            roundTrip.Jobs.Select(job => job.Label).Should().Equal(plan.Jobs.Select(job => job.Label));
        }
    }

    [TestMethod]
    public void RunwayCliCreativeRecipes_AdVideoModesCreateExpectedShotPlansAndRoundTrip()
    {
        var modes = new[]
        {
            "ugc",
            "unboxing",
            "product_showcase",
            "product_review",
            "tv_spot",
            "virtual_try_on",
        };

        foreach (var mode in modes)
        {
            var plan = RunwayCliCreativeRecipes.CreateAdVideoPlan(
                "modular travel backpack",
                ["https://example.com/reference.png"],
                shots: 2,
                ratio: null,
                model: null,
                mode,
                style: "warm handheld commercial",
                audio: true,
                duration: null);

            plan.Kind.Should().Be(RunwayCliCreativeRecipes.AdVideoKind);
            plan.Mode.Should().Be(mode);
            plan.Model.Should().Be(RunwayCliCreativeRecipes.DefaultVideoModel);
            plan.Ratio.Should().Be(RunwayCliCreativeRecipes.DefaultVideoRatio);
            plan.Count.Should().Be(2);
            plan.DurationSeconds.Should().Be(RunwayCliCreativeRecipes.DefaultVideoDurationSeconds);
            plan.Audio.Should().BeTrue();
            plan.Jobs.Should().HaveCount(2);
            plan.Jobs.Should().OnlyContain(job => job.Prompt.Contains("camera", StringComparison.OrdinalIgnoreCase));
            plan.Jobs.Should().OnlyContain(job => job.Audio == true);
            plan.Jobs.Should().OnlyContain(job => job.ReferenceImages.Contains("https://example.com/reference.png"));

            var json = RunwayCliCreativeRecipes.ToJson(plan);
            var roundTrip = JsonSerializer.Deserialize(
                json,
                RunwayCliCreativeRecipeJsonSerializerContext.Default.RunwayCliCreativeRecipePlan);

            roundTrip!.Mode.Should().Be(mode);
            roundTrip.Jobs.Should().HaveCount(2);
            roundTrip.Jobs[0].DurationSeconds.Should().Be(RunwayCliCreativeRecipes.DefaultVideoDurationSeconds);
        }
    }

    [TestMethod]
    public void RunwayEnvironment_LoadsApiKeyFromDotEnv()
    {
        var originalCurrentDirectory = Environment.CurrentDirectory;
        var originalRunwayApiKey = Environment.GetEnvironmentVariable("RUNWAY_API_KEY");
        var originalRunwayMlApiSecret = Environment.GetEnvironmentVariable("RUNWAYML_API_SECRET");
        var originalDotEnvDisabled = Environment.GetEnvironmentVariable("RUNWAY_DOTENV_DISABLED");
        var directory = Directory.CreateTempSubdirectory("runway-dotenv-test-").FullName;
        var childDirectory = Path.Combine(directory, "child");
        Directory.CreateDirectory(childDirectory);

        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_API_KEY", null);
            Environment.SetEnvironmentVariable("RUNWAYML_API_SECRET", null);
            Environment.SetEnvironmentVariable("RUNWAY_DOTENV_DISABLED", null);
            File.WriteAllText(Path.Combine(directory, ".env"), "RUNWAY_API_KEY=dotenv-test-key\n");
            Environment.CurrentDirectory = childDirectory;

            RunwayEnvironment.GetApiKey().Should().Be("dotenv-test-key");
        }
        finally
        {
            Environment.CurrentDirectory = originalCurrentDirectory;
            Environment.SetEnvironmentVariable("RUNWAY_API_KEY", originalRunwayApiKey);
            Environment.SetEnvironmentVariable("RUNWAYML_API_SECRET", originalRunwayMlApiSecret);
            Environment.SetEnvironmentVariable("RUNWAY_DOTENV_DISABLED", originalDotEnvDisabled);
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayTaskExtensions_ResolveOutputPathHandlesDirectoriesAndMultipleOutputs()
    {
        var directory = Directory.CreateTempSubdirectory("runway-cli-test-").FullName;

        try
        {
            RunwayTaskExtensions.ResolveOutputPath(directory, "stem", 0, 1, ".png")
                .Should().Be(Path.Combine(directory, "stem.png"));

            var missingDirectory = Path.Combine(directory, "new-output-dir");
            RunwayTaskExtensions.ResolveOutputPath(missingDirectory, "stem", 0, 1, ".png")
                .Should().Be(Path.Combine(missingDirectory, "stem.png"));

            RunwayTaskExtensions.ResolveOutputPath(Path.Combine(directory, "result.png"), "stem", 1, 2, ".png")
                .Should().Be(Path.Combine(directory, "result-2.png"));
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    [TestMethod]
    public void RunwayTaskExtensions_GetOutputExtensionFallsBackWhenUrlHasNoExtension()
    {
        RunwayTaskExtensions.GetOutputExtension(new Uri("https://example.com/output.mp4?token=abc"), ".bin")
            .Should().Be(".mp4");

        RunwayTaskExtensions.GetOutputExtension(new Uri("https://example.com/download?token=abc"), ".png")
            .Should().Be(".png");
    }

    private static ChatResponse CreateChatResponse(string text)
    {
        return new ChatResponse([new ChatMessage(ChatRole.Assistant, text)]);
    }

    private static async Task<string> CreateFakePlannerDirectoryAsync(
        string executableName,
        string output,
        int exitCode = 0)
    {
        var directory = Directory.CreateTempSubdirectory("runway-planner-").FullName;
        await AddFakePlannerExecutableAsync(directory, executableName, output, exitCode).ConfigureAwait(false);
        return directory;
    }

    private static async Task AddFakePlannerExecutableAsync(
        string directory,
        string executableName,
        string output,
        int exitCode = 0)
    {
        var outputPath = Path.Combine(directory, $"{executableName}-planner-output.txt");
        await File.WriteAllTextAsync(outputPath, output).ConfigureAwait(false);

        if (OperatingSystem.IsWindows())
        {
            var scriptPath = Path.Combine(directory, $"{executableName}.cmd");
            await File.WriteAllTextAsync(
                scriptPath,
                $"@echo off\r\ntype \"{outputPath}\"\r\nexit /b {exitCode}\r\n").ConfigureAwait(false);
        }
        else
        {
            var scriptPath = Path.Combine(directory, executableName);
            await File.WriteAllTextAsync(
                scriptPath,
                $"#!/bin/sh\n/bin/cat \"{outputPath}\"\nexit {exitCode}\n").ConfigureAwait(false);
            File.SetUnixFileMode(
                scriptPath,
                UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute);
        }
    }

    private static async Task AddFakePlannerScriptAsync(
        string directory,
        string executableName,
        string unixScript,
        string windowsScript)
    {
        if (OperatingSystem.IsWindows())
        {
            await File.WriteAllTextAsync(Path.Combine(directory, $"{executableName}.cmd"), windowsScript).ConfigureAwait(false);
            return;
        }

        var scriptPath = Path.Combine(directory, executableName);
        await File.WriteAllTextAsync(scriptPath, unixScript).ConfigureAwait(false);
        File.SetUnixFileMode(
            scriptPath,
            UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute);
    }

    private static string CreatePlannerPlanJson(
        RunwayShortVideoOptions? options = null,
        bool preserveRequestedOptions = true)
    {
        var effectiveOptions = options ?? new RunwayShortVideoOptions { ShotCount = 2 };
        var plan = RunwayShortVideoExtensions.CreateShortVideoPlan(
            "A glass flower opens on a rainy street.",
            effectiveOptions);

        if (!preserveRequestedOptions)
        {
            plan = new RunwayShortVideoPlan
            {
                SourceText = plan.SourceText,
                Scenario = plan.Scenario,
                Style = plan.Style,
                Model = "llm-selected-model",
                Ratio = "1:1",
                ShotDurationSeconds = 99,
                Shots =
                [
                    CopyShotWithIndexes(plan.Shots[0], index: 12, count: 99),
                    CopyShotWithIndexes(plan.Shots[1], index: 13, count: 99),
                ],
            };
        }

        return JsonSerializer.Serialize(plan, RunwayShortVideoJsonSerializerContext.Default.RunwayShortVideoPlan);
    }

    private static RunwayShortVideoShot CopyShotWithIndexes(
        RunwayShortVideoShot shot,
        int index,
        int count)
    {
        return new RunwayShortVideoShot
        {
            Index = index,
            Count = count,
            Title = shot.Title,
            Beat = shot.Beat,
            KeyframePrompt = shot.KeyframePrompt,
            VideoPrompt = shot.VideoPrompt,
        };
    }

    private sealed class CapturingChatClient(params Func<ChatOptions?, ChatResponse>[] responses) : IChatClient
    {
        private readonly Queue<Func<ChatOptions?, ChatResponse>> _responses = new(responses);

        public List<ChatOptions?> CapturedOptions { get; } = [];

        public Task<ChatResponse> GetResponseAsync(
            IEnumerable<ChatMessage> messages,
            ChatOptions? options = null,
            CancellationToken cancellationToken = default)
        {
            CapturedOptions.Add(options);

            if (_responses.Count == 0)
            {
                throw new InvalidOperationException("No chat response was configured.");
            }

            return Task.FromResult(_responses.Dequeue().Invoke(options));
        }

        public async IAsyncEnumerable<ChatResponseUpdate> GetStreamingResponseAsync(
            IEnumerable<ChatMessage> messages,
            ChatOptions? options = null,
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await Task.CompletedTask.ConfigureAwait(false);
            yield break;
        }

        public object? GetService(Type serviceType, object? serviceKey = null)
        {
            return serviceType.IsInstanceOfType(this) ? this : null;
        }

        public void Dispose()
        {
        }
    }

    private static Task<CliResult> RunCliAsync(
        string arguments,
        bool removeApiKey = false,
        IReadOnlyDictionary<string, string?>? environment = null) =>
        CliHarness.RunCliAsync(arguments, removeApiKey, environment);

    private static async Task RunProcessForTestAsync(string fileName, IReadOnlyList<string> arguments)
    {
        var startInfo = new ProcessStartInfo(fileName)
        {
            RedirectStandardError = true,
            RedirectStandardOutput = true,
        };

        foreach (var argument in arguments)
        {
            startInfo.ArgumentList.Add(argument);
        }

        using var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException($"Failed to start {fileName}.");
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync().ConfigureAwait(false);

        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException(
                $"{fileName} failed with exit code {process.ExitCode}: {await stderr.ConfigureAwait(false)} {await stdout.ConfigureAwait(false)}");
        }
    }

    private static string FindRunwayRoot() => CliHarness.FindRunwayRoot();
}
