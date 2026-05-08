namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task RunwayCliSkill_UsesDnxAndCoversCoreWorkflows()
    {
        var root = FindRunwayRootForSkillTests();
        var skillPath = Path.Combine(root, ".agents", "skills", "runway-cli", "SKILL.md");
        var metadataPath = Path.Combine(root, ".agents", "skills", "runway-cli", "agents", "openai.yaml");

        var skill = await File.ReadAllTextAsync(skillPath).ConfigureAwait(false);
        var metadata = await File.ReadAllTextAsync(metadataPath).ConfigureAwait(false);

        skill.Should().Contain("name: runway-cli");
        skill.Should().Contain("dnx Runway.Cli");
        skill.Should().Contain("--prerelease --yes");
        skill.Should().Contain("short-video");
        skill.Should().Contain("--plan-only");
        skill.Should().Contain("short-video run");
        skill.Should().Contain("image-to-video");
        skill.Should().Contain("text-to-speech");
        skill.Should().Contain("upload create");
        skill.Should().Contain("organization get");
        skill.Should().Contain("--json @");
        metadata.Should().Contain("$runway-cli");
    }

    private static string FindRunwayRootForSkillTests()
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
}
