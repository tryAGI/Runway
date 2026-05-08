/*
 * order: 81
 * title: Marketing Studio — Avatars Listing
 * slug: marketing-studio-avatars-listing
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List custom avatars through the Marketing Studio parity surface.
    //// `runway marketing-studio avatars list` is a thin alias over the SDK's avatar list endpoint;
    //// this example exercises the underlying SDK call to confirm the same response shape.

    [TestMethod]
    [Ignore("Requires RUNWAY_API_KEY")]
    public async Task Example_CreateMarketingStudioAvatar()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Avatars.GetAvatarsAsync(
            xRunwayVersion: "2024-11-06",
            limit: 5);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();

        Console.WriteLine($"Returned {response.Data.Count} avatar(s).");
        foreach (var avatar in response.Data)
        {
            Console.WriteLine($"- {avatar.Match(processing: p => p!.Id, ready: r => r!.Id, failed: f => f!.Id)}");
        }
    }
}
