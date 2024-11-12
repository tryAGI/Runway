
#nullable enable

namespace Runway
{
    public partial class RunwayClient
    {
        partial void PrepareCreateVideoFromImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Runway.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::Runway.CreateVideoFromImageRequest request);
        partial void PrepareCreateVideoFromImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Runway.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::Runway.CreateVideoFromImageRequest request);
        partial void ProcessCreateVideoFromImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVideoFromImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Runway.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::Runway.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::Runway.CreateVideoFromImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateVideoFromImageArguments(
                httpClient: HttpClient,
                xRunwayVersion: ref xRunwayVersion,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/image_to_video",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            __httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateVideoFromImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xRunwayVersion: xRunwayVersion,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVideoFromImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                if (ReadResponseAsString)
                {
                    __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::Runway.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateVideoFromImageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Runway.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Runway.CreateVideoFromImageResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Runway.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::Runway.CreateVideoFromImageResponse.FromJsonStreamAsync(__responseStream, JsonSerializerContext).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="promptImage">
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </param>
        /// <param name="model">
        /// The model variant to use.
        /// </param>
        /// <param name="seed">
        /// Seed value for generating consistent results.
        /// </param>
        /// <param name="promptText">
        /// A detailed description of the output.
        /// </param>
        /// <param name="watermark">
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Runway.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::Runway.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            string promptImage,
            global::Runway.CreateVideoFromImageRequestModel model = default,
            int? seed = default,
            string? promptText = default,
            bool? watermark = default,
            int? duration = default,
            global::Runway.CreateVideoFromImageRequestRatio? ratio = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Runway.CreateVideoFromImageRequest
            {
                PromptImage = promptImage,
                Model = model,
                Seed = seed,
                PromptText = promptText,
                Watermark = watermark,
                Duration = duration,
                Ratio = ratio,
            };

            return await CreateVideoFromImageAsync(
                xRunwayVersion: xRunwayVersion,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}