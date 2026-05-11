namespace Runway.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ConsumeRealtimeSessionSendsSessionKeyToConsumeEndpoint()
    {
        var sessionId = Guid.Parse("550e8400-e29b-41d4-a716-446655440000");
        var handler = new CaptureHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new RealtimeSessionsClient(
            httpClient: httpClient,
            baseUri: new Uri("https://api.dev.runwayml.com/"),
            authorizations: []);

        var credentials = await client.ConsumeRealtimeSessionAsync(
            id: sessionId,
            sessionKey: "session-key");

        credentials.Url.Should().Be(new Uri("wss://livekit.example"));
        credentials.Token.Should().Be("jwt");
        credentials.RoomName.Should().Be("room");
        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri($"https://api.dev.runwayml.com/v1/realtime_sessions/{sessionId:D}/consume"));
        handler.Authorization.Should().Be("Bearer session-key");
        handler.RunwayVersion.Should().Be("2024-11-06");
        handler.SessionScopedAuth.Should().BeTrue("consume uses a one-shot session-scoped bearer token (issue #116)");
        handler.UniversalAuthorizationOverride.Should().BeTrue(
            "consume should also stamp the universal AutoSDKHttpRequestOptions.AuthorizationOverride marker (AutoSDK #321) so cross-SDK rotation handlers can detect it without checking the Runway-specific key");
    }

    [TestMethod]
    public async Task ConnectRealtimeSessionBackendSendsApiKeyToBackendEndpoint()
    {
        var sessionId = Guid.Parse("550e8400-e29b-41d4-a716-446655440000");
        var handler = new CaptureHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new RunwayClient(
            apiKey: "api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://api.dev.runwayml.com/"));

        var credentials = await client.RealtimeSessions.ConnectRealtimeSessionBackendAsync(
            id: sessionId);

        credentials.Url.Should().Be(new Uri("wss://livekit.example"));
        credentials.Token.Should().Be("jwt");
        credentials.RoomName.Should().Be("room");
        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri($"https://api.dev.runwayml.com/v1/realtime_sessions/{sessionId:D}/connect_backend"));
        handler.Authorization.Should().Be("Bearer api-key");
        handler.RunwayVersion.Should().Be("2024-11-06");
        handler.SessionScopedAuth.Should().BeFalse("connect_backend uses the account-level bearer (issue #116)");
        handler.UniversalAuthorizationOverride.Should().BeFalse(
            "connect_backend uses the account-level bearer; rotation handlers should be free to overwrite it");
    }

    private sealed class CaptureHandler : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? Authorization { get; private set; }
        public string? RunwayVersion { get; private set; }
        public bool SessionScopedAuth { get; private set; }
        public bool UniversalAuthorizationOverride { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization?.ToString();
            RunwayVersion = request.Headers.TryGetValues("X-Runway-Version", out var values)
                ? values.SingleOrDefault()
                : null;
            // Read both markers so the test exercises both back-compat surfaces.
            // The universal AutoSDK marker is the recommended check for new
            // consumer code; the Runway-specific one stays for handlers wired
            // before #321 landed.
            UniversalAuthorizationOverride = AutoSDKHttpRequestOptions.HasAuthorizationOverride(request);
#pragma warning disable CS0618 // RunwayHttpRequestOptions.SessionScopedAuthorization is obsolete; verifying back-compat stamping.
            SessionScopedAuth = request.Options.TryGetValue(
                RunwayHttpRequestOptions.SessionScopedAuthorization,
                out var marker) && marker;
#pragma warning restore CS0618

            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "url": "wss://livekit.example",
                      "token": "jwt",
                      "roomName": "room"
                    }
                    """,
                    System.Text.Encoding.UTF8,
                    "application/json"),
            };

            return Task.FromResult(response);
        }
    }
}
