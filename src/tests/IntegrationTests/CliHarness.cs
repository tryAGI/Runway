using System.Diagnostics;

namespace Runway.IntegrationTests;

/// <summary>
/// Shared shell-out helper for tests that drive `dotnet run --project src/cli/Runway.Cli`.
/// Lets tests in any file invoke the CLI without growing inside <c>RunwayCliTests.cs</c>.
/// </summary>
internal static class CliHarness
{
    public static async Task<CliResult> RunCliAsync(
        string arguments,
        bool removeApiKey = false,
        IReadOnlyDictionary<string, string?>? environment = null)
    {
        var runwayRoot = FindRunwayRoot();
        var startInfo = new ProcessStartInfo(FindDotnetExecutable())
        {
            WorkingDirectory = runwayRoot,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true,
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

        startInfo.Environment.Remove("RUNWAY_SHORT_VIDEO_PLANNER");
        startInfo.Environment.Remove("RUNWAY_SHORT_VIDEO_PLANNER_MODEL");
        startInfo.Environment.Remove("RUNWAY_SHORT_VIDEO_PLANNER_TOOLS");
        startInfo.Environment.Remove("RUNWAY_SHORT_VIDEO_PLANNER_TIMEOUT_SECONDS");

        if (environment is not null)
        {
            foreach (var (key, value) in environment)
            {
                if (value is null)
                {
                    startInfo.Environment.Remove(key);
                }
                else
                {
                    startInfo.Environment[key] = value;
                }
            }
        }

        using var process = Process.Start(startInfo)
            ?? throw new InvalidOperationException("Failed to start Runway CLI process.");

        process.StandardInput.Close();

        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        await process.WaitForExitAsync().ConfigureAwait(false);

        return new CliResult(process.ExitCode, await stdout.ConfigureAwait(false), await stderr.ConfigureAwait(false));
    }

    public static string FindDotnetExecutable()
    {
        if (Environment.ProcessPath is { Length: > 0 } processPath &&
            string.Equals(Path.GetFileNameWithoutExtension(processPath), "dotnet", StringComparison.OrdinalIgnoreCase))
        {
            return processPath;
        }

        if (FindExecutableOnPath("dotnet") is { Length: > 0 } dotnet)
        {
            return dotnet;
        }

        return "dotnet";
    }

    public static string? FindExecutableOnPath(string name)
    {
        if (Environment.GetEnvironmentVariable("PATH") is not { Length: > 0 } path)
        {
            return null;
        }

        foreach (var directory in path.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries))
        {
            var candidate = Path.Combine(directory, name);
            if (File.Exists(candidate))
            {
                return candidate;
            }

            if (OperatingSystem.IsWindows() &&
                Environment.GetEnvironmentVariable("PATHEXT") is { Length: > 0 } pathExt)
            {
                foreach (var extension in pathExt.Split(';', StringSplitOptions.RemoveEmptyEntries))
                {
                    candidate = Path.Combine(directory, $"{name}{extension}");
                    if (File.Exists(candidate))
                    {
                        return candidate;
                    }
                }
            }
        }

        return null;
    }

    public static string FindRunwayRoot()
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

    public static string GetCurrentBuildConfiguration()
    {
        var targetFrameworkDirectory = new DirectoryInfo(AppContext.BaseDirectory);
        return targetFrameworkDirectory.Parent?.Name is { Length: > 0 } configuration
            ? configuration
            : "Debug";
    }

    public static IEnumerable<string> SplitArguments(string arguments) =>
        arguments.Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

internal sealed record CliResult(int ExitCode, string Stdout, string Stderr);
