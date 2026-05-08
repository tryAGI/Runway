/*
 * order: 85
 * title: Realtime Avatar Session
 * slug: realtime-avatar-session
 */

namespace Runway.IntegrationTests;

public partial class Tests
{
    //// Create a live Runway Characters realtime session, poll until it is ready,
    //// consume the one-time WebRTC credentials, and then cancel the session.
    //// This verifies the C# SDK surface needed by backend bridges for clients
    //// that cannot use WebRTC directly, such as watchOS.

    [TestMethod]
    public async Task Example_CreateRealtimeAvatarSession()
    {
        SkipUnlessRealtimeTestsEnabled();

        using var client = GetAuthenticatedClient();

        var sessionId = default(Guid);

        try
        {
            var session = await client.RealtimeSessions.CreateRealtimeSessionsAsync(
                request: new CreateRealtimeSessionsRequest
                {
                    Avatar = new CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar
                    {
                        PresetId = CreateRealtimeSessionsRequestAvatarRunwayPresetAvatarPresetId.Influencer,
                    },
                    MaxDuration = 60,
                });

            session.Id.Should().NotBe(default(Guid));
            sessionId = session.Id;

            Console.WriteLine($"Realtime session ID: {sessionId}");

            var ready = await WaitForRealtimeSessionReadyAsync(
                client: client,
                sessionId: sessionId,
                timeout: TimeSpan.FromSeconds(90));

            ready.SessionKey.Should().NotBeNullOrWhiteSpace();

            var credentials = await client.RealtimeSessions.ConsumeRealtimeSessionAsync(
                id: sessionId,
                sessionKey: ready.SessionKey);

            credentials.Url.Should().NotBeNull();
            credentials.Token.Should().NotBeNullOrWhiteSpace();
            credentials.RoomName.Should().NotBeNullOrWhiteSpace();

            Console.WriteLine($"Realtime credentials received for room '{credentials.RoomName}' at {credentials.Url.Host}.");
        }
        finally
        {
            if (sessionId != default)
            {
                try
                {
                    await client.RealtimeSessions.DeleteRealtimeSessionsByIdAsync(id: sessionId);
                }
                catch (ApiException exception)
                {
                    Console.WriteLine($"Realtime session cleanup returned HTTP {(int)exception.StatusCode}.");
                }
            }
        }
    }

    private static void SkipUnlessRealtimeTestsEnabled()
    {
        var value = Environment.GetEnvironmentVariable("RUNWAY_RUN_REALTIME_TESTS");
        var enabled =
            string.Equals(value, "true", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(value, "1", StringComparison.OrdinalIgnoreCase);

        if (!enabled)
        {
            throw new AssertInconclusiveException(
                "Set RUNWAY_RUN_REALTIME_TESTS=true to run this paid realtime session smoke test.");
        }
    }

    private static async Task<GetRealtimeSessionsResponseSessionReady> WaitForRealtimeSessionReadyAsync(
        RunwayClient client,
        Guid sessionId,
        TimeSpan timeout)
    {
        var deadline = DateTimeOffset.UtcNow + timeout;

        while (DateTimeOffset.UtcNow < deadline)
        {
            var session = await client.RealtimeSessions.GetRealtimeSessionsByIdAsync(id: sessionId);

            if (session.IsReady)
            {
                return session.Ready;
            }

            if (session.IsFailed)
            {
                throw new AssertFailedException(
                    $"Realtime session failed: {session.Failed.FailureCode}: {session.Failed.Failure}");
            }

            if (session.IsCancelled)
            {
                throw new AssertFailedException("Realtime session was cancelled before it became READY.");
            }

            if (session.IsCompleted)
            {
                throw new AssertFailedException("Realtime session completed before credentials were consumed.");
            }

            Console.WriteLine($"Realtime session status: {GetRealtimeSessionStatus(session)}.");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        throw new AssertFailedException(
            $"Realtime session did not become READY within {timeout.TotalSeconds:n0} seconds.");
    }

    private static string GetRealtimeSessionStatus(GetRealtimeSessionsResponse session)
    {
        return session.IsNotReady ? session.NotReady.Status :
            session.IsRunning ? session.Running.Status :
            session.IsReady ? session.Ready.Status :
            session.IsCompleted ? session.Completed.Status :
            session.IsFailed ? session.Failed.Status :
            session.IsCancelled ? session.Cancelled.Status :
            "UNKNOWN";
    }
}
