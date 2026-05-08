/*
 * order: 90
 * title: Custom Voices
 * slug: custom-voices
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List custom voices available to the authenticated organization.
    //// Custom voices can be assigned to avatars or used as speech overrides.

    [TestMethod]
    public async Task Example_ListCustomVoices()
    {
        using var client = GetAuthenticatedClient();

        var voices = await client.Voices.GetVoicesAsync(
            limit: 50,
            xRunwayVersion: "2024-11-06");

        Console.WriteLine($"Custom voices on page: {voices.Data.Count}");
        Console.WriteLine($"Has more: {voices.HasMore}");

        voices.Data.Should().NotBeNull();
    }
}
