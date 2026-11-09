using System.Text.Json;
using AwesomeAssertions;

namespace Runway.IntegrationTests;

/// <summary>
/// The CLI's scripting contract, exercised against the real binary: stdout carries only machine-readable
/// results, prose goes to stderr, <c>--quiet</c> silences the prose, exit codes separate a bad invocation
/// from a failed generation, and `-` reads an asset from stdin so commands can be piped together.
/// None of these cases reach the API, so they cost nothing.
/// </summary>
[TestClass]
public sealed class RunwayCliScriptingContractTests
{
    /// <summary>Points the CLI at a closed port so submissions fail fast instead of spending credits.</summary>
    private static readonly Dictionary<string, string?> OfflineEnvironment = new(StringComparer.Ordinal)
    {
        ["RUNWAY_BASE_URL"] = "http://127.0.0.1:9",
        ["RUNWAY_API_KEY"] = "key_test_dummy",
        ["RUNWAY_DOTENV_DISABLED"] = "1",
    };

    private static Task<CliResult> RunAsync(string arguments) =>
        CliHarness.RunCliAsync(arguments, environment: OfflineEnvironment);

    [TestMethod]
    public async Task ListingCommandsKeepStdoutCleanForPiping()
    {
        var models = await RunAsync("models").ConfigureAwait(false);
        models.ExitCode.Should().Be(0);
        models.Stdout.Should().NotBeEmpty();
        models.Stderr.Should().BeEmpty("the listing is data, so none of it may leak onto stderr");

        var presets = await RunAsync("voice presets").ConfigureAwait(false);
        presets.ExitCode.Should().Be(0);
        presets.Stdout.Should().Contain("Maya");
        presets.Stderr.Should().BeEmpty();
    }

    [TestMethod]
    public async Task PlanOnlyEmitsParseableJsonOnStdout()
    {
        var result = await RunAsync(
            "short-video \"a robot finds a seed\" --shots 2 --plan-only --planner deterministic")
            .ConfigureAwait(false);

        result.ExitCode.Should().Be(0);
        using var json = JsonDocument.Parse(result.Stdout);
        json.RootElement.GetProperty("shots").GetArrayLength().Should().Be(2);
    }

    [TestMethod]
    public async Task UsageErrorsExitTwoAndGenerationFailuresExitOne()
    {
        // 2 — the caller can fix these in the command line.
        var unknownModel = await RunAsync("text-to-video x --model nope").ConfigureAwait(false);
        unknownModel.ExitCode.Should().Be(2);
        unknownModel.Stdout.Should().BeEmpty();
        unknownModel.Stderr.Should().Contain("Unsupported model");

        var outOfEnum = await RunAsync("video-upscale --video https://example.com/v.mp4 --flavor bogus").ConfigureAwait(false);
        outOfEnum.ExitCode.Should().Be(2);

        var missingOption = await RunAsync("video-to-video x").ConfigureAwait(false);
        missingOption.ExitCode.Should().Be(2);

        var badFormat = await RunAsync("text-to-video x --format yaml").ConfigureAwait(false);
        badFormat.ExitCode.Should().Be(2);
        badFormat.Stderr.Should().Contain("Accepted values: text, json");

        // 1 — the request was well-formed and failed in transit or on Runway's side.
        var transport = await RunAsync("text-to-video x --no-wait").ConfigureAwait(false);
        transport.ExitCode.Should().Be(1);
        transport.Stdout.Should().BeEmpty();
    }

    [TestMethod]
    public async Task QuietSuppressesProseButNotErrors()
    {
        var loud = await RunAsync(
            "short-video \"a robot\" --shots 2 --plan-only --planner deterministic").ConfigureAwait(false);
        loud.Stderr.Should().NotBeEmpty("the plan summary and planner name are prose");

        var quiet = await RunAsync(
            "short-video \"a robot\" --shots 2 --plan-only --planner deterministic --quiet").ConfigureAwait(false);
        quiet.ExitCode.Should().Be(0);
        quiet.Stderr.Should().BeEmpty();
        quiet.Stdout.Should().Be(loud.Stdout, "--quiet must not change the machine-readable output");

        // Errors survive --quiet, otherwise CI could not diagnose a failure.
        var failing = await RunAsync("text-to-video x --model nope --quiet").ConfigureAwait(false);
        failing.ExitCode.Should().Be(2);
        failing.Stderr.Should().Contain("Unsupported model");
    }

    [TestMethod]
    public async Task DashReadsAnAssetFromStdinSoCommandsCanBePiped()
    {
        // Nothing piped in: fail fast with an actionable message rather than blocking on a read.
        var empty = await RunAsync("image-to-video --image - \"push in\" --no-wait").ConfigureAwait(false);
        empty.ExitCode.Should().Be(2);
        empty.Stderr.Should().Contain("stdin");
    }

    [TestMethod]
    public async Task FormatJsonIsRejectedWithoutAnAccountComparisonOnModels()
    {
        var result = await RunAsync("models --json").ConfigureAwait(false);
        result.ExitCode.Should().Be(2, "it is a usage error like any other");
        result.Stderr.Should().Contain("--account");
    }
}
