using System.Diagnostics;
using System.Text.Json;

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
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, or a .env file.");
    }

    [TestMethod]
    public async Task RunwayCli_ImageCommandParsesPromptBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("image tiny test prompt --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, or a .env file.");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoPlanOnlyDoesNotRequireApiKey()
    {
        var result = await RunCliAsync("short-video tiny robot finds a glowing garden --shots 2 --plan-only", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("\"scenario\"");
        result.Stdout.Should().Contain("\"keyframePrompt\"");
        result.Stdout.Should().Contain("\"videoPrompt\"");
    }

    [TestMethod]
    public async Task RunwayCli_ShortVideoParsesScenarioBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("short-video tiny robot finds a glowing garden --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, or a .env file.");
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
            result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, RUNWAYML_API_SECRET, or a .env file.");
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
    public async Task RunwayCli_CreatesGptImage2RequestWithResolutionQualityAndSixteenReferences()
    {
        var references = Enumerable.Range(1, 16)
            .Select(index => $"https://example.com/reference-{index}.png")
            .ToArray();

        var request = await RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
            "poster with crisp product typography",
            "1024:1024",
            references,
            "1K",
            "low",
            1,
            CancellationToken.None).ConfigureAwait(false);

        request.PromptText.Should().Be("poster with crisp product typography");
        request.Ratio.Should().Be("1024:1024");
        request.Resolution.Should().Be(GptImage2Resolution.x1K);
        request.Quality.Should().Be(GptImage2Quality.Low);
        request.OutputCount.Should().Be(1);
        request.ReferenceImages.Should().HaveCount(16);
        request.ReferenceImages![15].Tag.Should().Be("reference16");
    }

    [TestMethod]
    public async Task RunwayCli_RejectsTooManyGptImage2ReferenceImages()
    {
        var act = () => RunwayCliGeneration.CreateGptImage2TextToImageRequestAsync(
            "poster with crisp product typography",
            "1024:1024",
            Enumerable.Range(1, 17).Select(index => $"https://example.com/reference-{index}.png").ToArray(),
            "1K",
            "low",
            1,
            CancellationToken.None);

        await act.Should().ThrowAsync<ArgumentException>()
            .WithMessage("GPT Image 2 accepts up to 16 reference images.").ConfigureAwait(false);
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

    private static async Task<CliResult> RunCliAsync(string arguments, bool removeApiKey = false)
    {
        var runwayRoot = FindRunwayRoot();
        var startInfo = new ProcessStartInfo("dotnet")
        {
            WorkingDirectory = runwayRoot,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };

        startInfo.ArgumentList.Add("run");
        startInfo.ArgumentList.Add("--project");
        startInfo.ArgumentList.Add(Path.Combine(runwayRoot, "src", "cli", "Runway.Cli", "Runway.Cli.csproj"));
        startInfo.ArgumentList.Add("--configuration");
        startInfo.ArgumentList.Add(GetCurrentBuildConfiguration());
        startInfo.ArgumentList.Add("--no-build");
        startInfo.ArgumentList.Add("--");

        foreach (var argument in SplitArguments(arguments))
        {
            startInfo.ArgumentList.Add(argument);
        }

        if (removeApiKey)
        {
            startInfo.Environment.Remove("RUNWAY_API_KEY");
            startInfo.Environment.Remove("RUNWAYML_API_SECRET");
            startInfo.Environment["RUNWAY_DOTENV_DISABLED"] = "1";
        }
        else
        {
            startInfo.Environment.Remove("RUNWAY_DOTENV_DISABLED");
        }

        using var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start Runway CLI process.");

        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync().ConfigureAwait(false);

        return new CliResult(process.ExitCode, await stdout.ConfigureAwait(false), await stderr.ConfigureAwait(false));
    }

    private static string FindRunwayRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, "Runway.slnx")))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        throw new InvalidOperationException("Could not locate Runway.slnx.");
    }

    private static string GetCurrentBuildConfiguration()
    {
        var targetFrameworkDirectory = new DirectoryInfo(AppContext.BaseDirectory);
        return targetFrameworkDirectory.Parent?.Name is { Length: > 0 } configuration
            ? configuration
            : "Debug";
    }

    private static IEnumerable<string> SplitArguments(string arguments)
    {
        return arguments.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }

    private sealed record CliResult(int ExitCode, string Stdout, string Stderr);
}
