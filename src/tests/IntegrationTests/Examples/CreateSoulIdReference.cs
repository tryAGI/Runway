/*
 * order: 78
 * title: Soul-ID Local Registry
 * slug: soul-id-local-registry
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Build a soul-id from 5 reference photos and verify the local registry layout.
    //// Soul-ids are stored client-side under ~/.runway-cli/soul-ids/<id>/ and are reusable
    //// across runs as `--soul-id <id>` on `runway image` and `runway image-to-video`.
    //// The CLI does not train a server-side identity model — the registry only manages
    //// reference photos that are auto-attached to subsequent generation calls.

    [TestMethod]
    public void Example_CreateSoulIdReference()
    {
        var sandbox = Path.Combine(Path.GetTempPath(), $"runway-soulid-test-{Guid.NewGuid():N}");
        var previousHome = Environment.GetEnvironmentVariable("RUNWAY_CLI_HOME");
        try
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", sandbox);

            var photos = new List<string>(5);
            for (var index = 1; index <= 5; index++)
            {
                var path = Path.Combine(sandbox, $"photo{index}.jpg");
                Directory.CreateDirectory(sandbox);
                File.WriteAllBytes(path, [(byte)index, 0, 0, 0]);
                photos.Add(path);
            }

            var entry = RunwayCliSoulId.Create(name: "alice", photoPaths: photos, variant: "soul-2");
            entry.Id.Should().NotBeNullOrWhiteSpace();
            entry.Variant.Should().Be("soul-2");
            entry.Status.Should().Be("ready");
            entry.Photos.Should().HaveCount(5);

            var listed = RunwayCliSoulId.List();
            listed.Should().ContainSingle();
            listed[0].Id.Should().Be(entry.Id);

            var fetched = RunwayCliSoulId.Get(entry.Id);
            fetched.Should().NotBeNull();
            fetched!.Name.Should().Be("alice");

            var resolved = RunwayCliSoulId.ResolvePhotos(entry.Id);
            resolved.Should().HaveCount(5);
            foreach (var photo in resolved)
            {
                File.Exists(photo).Should().BeTrue();
            }
        }
        finally
        {
            Environment.SetEnvironmentVariable("RUNWAY_CLI_HOME", previousHome);
            if (Directory.Exists(sandbox))
            {
                Directory.Delete(sandbox, recursive: true);
            }
        }
    }
}
