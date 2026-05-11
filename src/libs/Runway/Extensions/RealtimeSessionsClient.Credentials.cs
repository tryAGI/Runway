#nullable enable

namespace Runway;

public sealed partial class RealtimeSessionsClient
{
    /// <summary>
    /// Consume a ready realtime session and return WebRTC connection credentials.
    /// Session credentials can only be consumed once.
    /// </summary>
    public async global::System.Threading.Tasks.Task<global::Runway.RealtimeSessionConnectionCredentials> ConsumeRealtimeSessionAsync(
        global::System.Guid id,
        string sessionKey,
        string xRunwayVersion = "2024-11-06",
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        var response = await ConsumeRealtimeSessionAsResponseAsync(
            id: id,
            sessionKey: sessionKey,
            xRunwayVersion: xRunwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return response.Body;
    }

    /// <summary>
    /// Consume a ready realtime session and return WebRTC connection credentials with response metadata.
    /// Session credentials can only be consumed once.
    /// </summary>
    public async global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.RealtimeSessionConnectionCredentials>> ConsumeRealtimeSessionAsResponseAsync(
        global::System.Guid id,
        string sessionKey,
        string xRunwayVersion = "2024-11-06",
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        sessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));

        return await SendRealtimeSessionCredentialsRequestAsync(
            id: id,
            action: "consume",
            bearerToken: sessionKey,
            sessionScopedAuth: true,
            xRunwayVersion: xRunwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Connect a backend worker to a realtime session and return WebRTC connection credentials.
    /// This is used for server-side RPC tool handlers.
    /// </summary>
    public async global::System.Threading.Tasks.Task<global::Runway.RealtimeSessionConnectionCredentials> ConnectRealtimeSessionBackendAsync(
        global::System.Guid id,
        string xRunwayVersion = "2024-11-06",
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        var response = await ConnectRealtimeSessionBackendAsResponseAsync(
            id: id,
            xRunwayVersion: xRunwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return response.Body;
    }

    /// <summary>
    /// Connect a backend worker to a realtime session and return WebRTC connection credentials with response metadata.
    /// This is used for server-side RPC tool handlers.
    /// </summary>
    public async global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.RealtimeSessionConnectionCredentials>> ConnectRealtimeSessionBackendAsResponseAsync(
        global::System.Guid id,
        string xRunwayVersion = "2024-11-06",
        global::System.Threading.CancellationToken cancellationToken = default)
    {
        var apiKey = GetBearerAuthorizationValue(operationName: nameof(ConnectRealtimeSessionBackendAsync));

        return await SendRealtimeSessionCredentialsRequestAsync(
            id: id,
            action: "connect_backend",
            bearerToken: apiKey,
            sessionScopedAuth: false,
            xRunwayVersion: xRunwayVersion,
            cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    private async global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.RealtimeSessionConnectionCredentials>> SendRealtimeSessionCredentialsRequestAsync(
        global::System.Guid id,
        string action,
        string bearerToken,
        bool sessionScopedAuth,
        string xRunwayVersion,
        global::System.Threading.CancellationToken cancellationToken)
    {
        action = action ?? throw new global::System.ArgumentNullException(nameof(action));
        bearerToken = bearerToken ?? throw new global::System.ArgumentNullException(nameof(bearerToken));
        xRunwayVersion = xRunwayVersion ?? throw new global::System.ArgumentNullException(nameof(xRunwayVersion));

        PrepareArguments(client: HttpClient);

        var escapedId = global::System.Uri.EscapeDataString(id.ToString("D"));
        var pathBuilder = new global::Runway.PathBuilder(
            path: $"/v1/realtime_sessions/{escapedId}/{action}",
            baseUri: HttpClient.BaseAddress);
        var path = pathBuilder.ToString();

        using var request = new global::System.Net.Http.HttpRequestMessage(
            method: global::System.Net.Http.HttpMethod.Post,
            requestUri: new global::System.Uri(path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
        request.Version = global::System.Net.HttpVersion.Version11;
        request.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
        if (sessionScopedAuth)
        {
            request.Options.Set(global::Runway.RunwayHttpRequestOptions.SessionScopedAuthorization, true);
        }
        request.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);
        request.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion);
        request.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        request.Content = new global::System.Net.Http.StringContent(
            string.Empty,
            global::System.Text.Encoding.UTF8,
            "application/json");

        PrepareRequest(
            client: HttpClient,
            request: request);

        using var response = await HttpClient.SendAsync(
            request,
            global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        ProcessResponse(
            client: HttpClient,
            response: response);

        var content = response.Content is null
            ? string.Empty
            : await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        ProcessResponseContent(
            client: HttpClient,
            response: response,
            content: ref content);

        var headers = global::Runway.AutoSDKHttpResponse.CreateHeaders(response);
        if (!response.IsSuccessStatusCode)
        {
            throw new global::Runway.ApiException(
                $"Error calling realtime session {action}: HTTP {(int)response.StatusCode}.",
                response.StatusCode)
            {
                ResponseBody = content,
                ResponseHeaders = headers,
            };
        }

        global::Runway.RealtimeSessionConnectionCredentials? body;
        try
        {
            body = global::System.Text.Json.JsonSerializer.Deserialize(
                content,
                global::Runway.RealtimeSessionJsonSerializerContext.Default.RealtimeSessionConnectionCredentials);
        }
        catch (global::System.Exception exception)
        {
            throw new global::Runway.ApiException(
                $"Failed to deserialize realtime session {action} response.",
                exception,
                response.StatusCode)
            {
                ResponseBody = content,
                ResponseHeaders = headers,
            };
        }

        return body is null
            ? throw new global::Runway.ApiException(
                $"Realtime session {action} response was empty.",
                response.StatusCode)
            {
                ResponseBody = content,
                ResponseHeaders = headers,
            }
            : new global::Runway.AutoSDKHttpResponse<global::Runway.RealtimeSessionConnectionCredentials>(
                statusCode: response.StatusCode,
                headers: headers,
                requestUri: response.RequestMessage?.RequestUri,
                body: body);
    }

    private string GetBearerAuthorizationValue(string operationName)
    {
        for (var i = Authorizations.Count - 1; i >= 0; i--)
        {
            var authorization = Authorizations[i];
            if (authorization.Type == "Http" &&
                authorization.Name == "Bearer")
            {
                return authorization.Value;
            }
        }

        throw new global::System.InvalidOperationException(
            $"Operation '{operationName}' requires Bearer authorization.");
    }
}
