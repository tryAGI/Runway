#nullable enable

namespace Runway
{
    public partial interface IModelRouterClient
    {
        /// <summary>
        /// Routed image generation<br/>
        /// Start an image generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateGenerateImageResponse> CreateGenerateImageAsync(

            global::Runway.CreateGenerateImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Routed image generation<br/>
        /// Start an image generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateGenerateImageResponse>> CreateGenerateImageAsResponseAsync(

            global::Runway.CreateGenerateImageRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Routed image generation<br/>
        /// Start an image generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="configId">
        /// The slug of a saved Model Router config to route this request with.
        /// </param>
        /// <param name="input">
        /// Model-agnostic image generation input. The router selects a model and maps these options to it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateGenerateImageResponse> CreateGenerateImageAsync(
            string configId,
            global::Runway.CreateGenerateImageRequestInput input,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}