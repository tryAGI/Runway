#nullable enable

namespace Runway
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Routed video generation<br/>
        /// Start a video generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateGenerateVideoResponse> CreateGenerateVideoAsync(

            global::Runway.CreateGenerateVideoRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Routed video generation<br/>
        /// Start a video generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateGenerateVideoResponse>> CreateGenerateVideoAsResponseAsync(

            global::Runway.CreateGenerateVideoRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Routed video generation<br/>
        /// Start a video generation task using a saved Model Router config instead of naming a model.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="configId">
        /// The slug of a saved Model Router config to route this request with.
        /// </param>
        /// <param name="input">
        /// Model-agnostic video generation input. Fields are optional; the router selects a model and maps these options to it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateGenerateVideoResponse> CreateGenerateVideoAsync(
            string configId,
            global::Runway.CreateGenerateVideoRequestInput input,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}