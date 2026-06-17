
#nullable enable

namespace Runway
{
    public partial class RecipesClient
    {


        private static readonly global::Runway.EndPointSecurityRequirement s_CreateRecipesProductSwapSecurityRequirement0 =
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
        private static readonly global::Runway.EndPointSecurityRequirement[] s_CreateRecipesProductSwapSecurityRequirements =
            new global::Runway.EndPointSecurityRequirement[]
            {                s_CreateRecipesProductSwapSecurityRequirement0,
            };
        partial void PrepareCreateRecipesProductSwapArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xRunwayVersion,
            global::Runway.CreateRecipesProductSwapRequest request);
        partial void PrepareCreateRecipesProductSwapRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xRunwayVersion,
            global::Runway.CreateRecipesProductSwapRequest request);
        partial void ProcessCreateRecipesProductSwapResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRecipesProductSwapResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.recipes.productSwap({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceVideo: { uri: 'https://example.com/reference-ad.mp4' },<br/>
        ///   originalProductImage: { uri: 'https://example.com/original-product.jpg' },<br/>
        ///   newProductImages: [<br/>
        ///     { uri: 'https://example.com/new-product-front.jpg', view: 'front' },<br/>
        ///     { uri: 'https://example.com/new-product-side.jpg', view: 'side' },<br/>
        ///   ],<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductSwapResponse> CreateRecipesProductSwapAsync(

            global::Runway.CreateRecipesProductSwapRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateRecipesProductSwapAsResponseAsync(

                request: request,
                xRunwayVersion: xRunwayVersion,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.recipes.productSwap({<br/>
        ///   version: '2026-06',<br/>
        ///   referenceVideo: { uri: 'https://example.com/reference-ad.mp4' },<br/>
        ///   originalProductImage: { uri: 'https://example.com/original-product.jpg' },<br/>
        ///   newProductImages: [<br/>
        ///     { uri: 'https://example.com/new-product-front.jpg', view: 'front' },<br/>
        ///     { uri: 'https://example.com/new-product-side.jpg', view: 'side' },<br/>
        ///   ],<br/>
        ///   duration: 10,<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductSwapResponse>> CreateRecipesProductSwapAsResponseAsync(

            global::Runway.CreateRecipesProductSwapRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRecipesProductSwapArguments(
                httpClient: HttpClient,
                xRunwayVersion: ref xRunwayVersion,
                request: request);


            var __authorizations = global::Runway.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateRecipesProductSwapSecurityRequirements,
                operationName: "CreateRecipesProductSwapAsync");

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
                                path: "/v1/recipes/product_swap",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Runway.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Runway.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateRecipesProductSwapRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xRunwayVersion: xRunwayVersion!,
                    request: request);

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
                                operationId: "createRecipesProductSwap",
                                methodName: "CreateRecipesProductSwapAsync",
                                pathTemplate: "\"/v1/recipes/product_swap\"",
                                httpMethod: "POST",
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
                                operationId: "createRecipesProductSwap",
                                methodName: "CreateRecipesProductSwapAsync",
                                pathTemplate: "\"/v1/recipes/product_swap\"",
                                httpMethod: "POST",
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
                                operationId: "createRecipesProductSwap",
                                methodName: "CreateRecipesProductSwapAsync",
                                pathTemplate: "\"/v1/recipes/product_swap\"",
                                httpMethod: "POST",
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
                ProcessCreateRecipesProductSwapResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Runway.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Runway.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createRecipesProductSwap",
                                methodName: "CreateRecipesProductSwapAsync",
                                pathTemplate: "\"/v1/recipes/product_swap\"",
                                httpMethod: "POST",
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
                                operationId: "createRecipesProductSwap",
                                methodName: "CreateRecipesProductSwapAsync",
                                pathTemplate: "\"/v1/recipes/product_swap\"",
                                httpMethod: "POST",
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
                            // You have exceeded the rate limit for this endpoint.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Runway.CreateRecipesProductSwapResponse2? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Runway.CreateRecipesProductSwapResponse2.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Runway.CreateRecipesProductSwapResponse2.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Runway.ApiException<global::Runway.CreateRecipesProductSwapResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateRecipesProductSwapResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Runway.CreateRecipesProductSwapResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductSwapResponse>(
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

                                    var __value = await global::Runway.CreateRecipesProductSwapResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesProductSwapResponse>(
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
        /// <summary>
        /// Swap a product in a reference video<br/>
        /// Replace the product in a reference video with a new product, preserving camera motion, lighting, and scene composition.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="referenceVideo">
        /// Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.
        /// </param>
        /// <param name="originalProductImage">
        /// Image of the original product being swapped out. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="newProductImages">
        /// Reference images of the new product (1–10). Supply multiple angles when the reference video shows the product from different views — optionally label each with `view` ("front", "side", or "back"). A single pre-composed reference sheet is also supported (omit `view`). See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to 720p.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Runway.CreateRecipesProductSwapResponse> CreateRecipesProductSwapAsync(
            global::Runway.CreateRecipesProductSwapRequestVersion version,
            global::Runway.CreateRecipesProductSwapRequestReferenceVideo referenceVideo,
            global::Runway.CreateRecipesProductSwapRequestOriginalProductImage originalProductImage,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage> newProductImages,
            string xRunwayVersion = "2024-11-06",
            int? duration = default,
            global::Runway.CreateRecipesProductSwapRequestResolution? resolution = default,
            bool? audio = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Runway.CreateRecipesProductSwapRequest
            {
                Version = version,
                ReferenceVideo = referenceVideo,
                OriginalProductImage = originalProductImage,
                NewProductImages = newProductImages,
                Duration = duration,
                Resolution = resolution,
                Audio = audio,
            };

            return await CreateRecipesProductSwapAsync(
                xRunwayVersion: xRunwayVersion,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}