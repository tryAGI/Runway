using System.Diagnostics;

namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task RunwayCli_HelpListsGenerationCommands()
    {
        var result = await RunCliAsync("--help").ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Contain("video <prompt>");
        result.Stdout.Should().Contain("image <prompt>");
        result.Stdout.Should().Contain("task");
    }

    [TestMethod]
    public async Task RunwayCli_VideoCommandParsesPromptBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("video tiny test prompt --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, or RUNWAYML_API_SECRET.");
    }

    [TestMethod]
    public async Task RunwayCli_ImageCommandParsesPromptBeforeRequiringApiKey()
    {
        var result = await RunCliAsync("image tiny test prompt --no-wait", removeApiKey: true).ConfigureAwait(false);

        result.ExitCode.Should().Be(1);
        result.Stderr.Should().Contain("Set --api-key, RUNWAY_API_KEY, or RUNWAYML_API_SECRET.");
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
