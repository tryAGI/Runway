/*
 * order: 85
 * title: Avatar Conversations
 * slug: avatar-conversations
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// List realtime avatar conversations and inspect aggregate avatar usage.
    //// Pass avatar: avatarId to restrict the conversation list to a single custom avatar.

    [TestMethod]
    public async Task Example_ListAvatarConversations()
    {
        using var client = GetAuthenticatedClient();

        var conversations = await client.Avatars.GetAvatarConversationsAsync(
            limit: 20,
            xRunwayVersion: "2024-11-06");

        Console.WriteLine($"Conversations on page: {conversations.Data.Count}");
        Console.WriteLine($"Has more: {conversations.HasMore}");

        var endDate = DateTime.UtcNow.Date;
        var startDate = endDate.AddDays(-7);

        var usage = await client.Avatars.GetAvatarUsageAsync(
            startDate: startDate,
            endDate: endDate,
            xRunwayVersion: "2024-11-06");

        Console.WriteLine($"Sessions: {usage.TotalSessions}");
        Console.WriteLine($"Total seconds: {usage.TotalSeconds}");

        conversations.Data.Should().NotBeNull();
        usage.ByDay.Should().NotBeNull();
    }
}
