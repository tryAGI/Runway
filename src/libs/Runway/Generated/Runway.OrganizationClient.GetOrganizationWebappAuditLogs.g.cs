
#nullable enable

namespace Runway
{
    public partial class OrganizationClient
    {


        private static readonly global::Runway.EndPointSecurityRequirement s_GetOrganizationWebappAuditLogsSecurityRequirement0 =
            new global::Runway.EndPointSecurityRequirement
            {
                Authorizations = new global::Runway.EndPointAuthorizationRequirement[]
                {                    new global::Runway.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Runway.EndPointSecurityRequirement[] s_GetOrganizationWebappAuditLogsSecurityRequirements =
            new global::Runway.EndPointSecurityRequirement[]
            {                s_GetOrganizationWebappAuditLogsSecurityRequirement0,
            };
        partial void PrepareGetOrganizationWebappAuditLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int limit,
            ref global::System.Guid? organizationId,
            ref string? workspaceIds,
            ref string? actions,
            ref string? actorEmails,
            ref global::System.DateTime? from,
            ref global::System.DateTime? to,
            ref string xRunwayVersion);
        partial void PrepareGetOrganizationWebappAuditLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int limit,
            global::System.Guid? organizationId,
            string? workspaceIds,
            string? actions,
            string? actorEmails,
            global::System.DateTime? from,
            global::System.DateTime? to,
            string xRunwayVersion);
        partial void ProcessGetOrganizationWebappAuditLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetOrganizationWebappAuditLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List linked workspace audit logs<br/>
        /// List audit log entries for the linked Runway workspaces you administer, newest first. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="actions"></param>
        /// <param name="actorEmails"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Runway.GetOrganizationWebappAuditLogsResponse> GetOrganizationWebappAuditLogsAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string? actions = default,
            string? actorEmails = default,
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetOrganizationWebappAuditLogsAsResponseAsync(
                limit: limit,
                cursor: cursor,
                organizationId: organizationId,
                workspaceIds: workspaceIds,
                actions: actions,
                actorEmails: actorEmails,
                from: from,
                to: to,
                xRunwayVersion: xRunwayVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List linked workspace audit logs<br/>
        /// List audit log entries for the linked Runway workspaces you administer, newest first. Authorized via the account link between this API project and the workspace.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="actions"></param>
        /// <param name="actorEmails"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappAuditLogsResponse>> GetOrganizationWebappAuditLogsAsResponseAsync(
            int limit,
            string? cursor = default,
            global::System.Guid? organizationId = default,
            string? workspaceIds = default,
            string? actions = default,
            string? actorEmails = default,
            global::System.DateTime? from = default,
            global::System.DateTime? to = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetOrganizationWebappAuditLogsArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                limit: ref limit,
                organizationId: ref organizationId,
                workspaceIds: ref workspaceIds,
                actions: ref actions,
                actorEmails: ref actorEmails,
                from: ref from,
                to: ref to,
                xRunwayVersion: ref xRunwayVersion);


            var __authorizations = global::Runway.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetOrganizationWebappAuditLogsSecurityRequirements,
                operationName: "GetOrganizationWebappAuditLogsAsync");

            using var __timeoutCancellationTokenSource = global::Runway.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Runway.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Runway.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Runway.PathBuilder(
                                path: "/v1/organization/webapp/audit_logs",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("cursor", cursor)
                                .AddRequiredParameter("limit", limit.ToString()!)
                                .AddOptionalParameter("organizationId", organizationId?.ToString())
                                .AddOptionalParameter("workspaceIds", workspaceIds)
                                .AddOptionalParameter("actions", actions)
                                .AddOptionalParameter("actorEmails", actorEmails)
                                .AddOptionalParameter("from", from?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("to", to?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Runway.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                __httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToString());

                global::Runway.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetOrganizationWebappAuditLogsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cursor: cursor,
                    limit: limit!,
                    organizationId: organizationId,
                    workspaceIds: workspaceIds,
                    actions: actions,
                    actorEmails: actorEmails,
                    from: from,
                    to: to,
                    xRunwayVersion: xRunwayVersion!);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Runway.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getOrganizationWebappAuditLogs",
                                methodName: "GetOrganizationWebappAuditLogsAsync",
                                pathTemplate: "\"/v1/organization/webapp/audit_logs\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Runway.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Runway.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getOrganizationWebappAuditLogs",
                                methodName: "GetOrganizationWebappAuditLogsAsync",
                                pathTemplate: "\"/v1/organization/webapp/audit_logs\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Runway.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Runway.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Runway.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Runway.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getOrganizationWebappAuditLogs",
                                methodName: "GetOrganizationWebappAuditLogsAsync",
                                pathTemplate: "\"/v1/organization/webapp/audit_logs\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Runway.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetOrganizationWebappAuditLogsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Runway.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getOrganizationWebappAuditLogs",
                                methodName: "GetOrganizationWebappAuditLogsAsync",
                                pathTemplate: "\"/v1/organization/webapp/audit_logs\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Runway.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getOrganizationWebappAuditLogs",
                                methodName: "GetOrganizationWebappAuditLogsAsync",
                                pathTemplate: "\"/v1/organization/webapp/audit_logs\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetOrganizationWebappAuditLogsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Runway.GetOrganizationWebappAuditLogsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappAuditLogsResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Runway.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Runway.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Runway.GetOrganizationWebappAuditLogsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Runway.AutoSDKHttpResponse<global::Runway.GetOrganizationWebappAuditLogsResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Runway.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Runway.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}