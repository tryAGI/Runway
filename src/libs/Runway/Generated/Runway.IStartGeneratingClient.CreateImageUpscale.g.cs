#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Image upscale<br/>
        /// Upscale an image with Magnific precision upscaling. Each input dimension must be between 300px and 8000px. Output width and height are the input dimensions multiplied by `scaleFactor` (default 2). Output width times height cannot exceed 25,300,000 pixels (~25.3 million).
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.imageUpscale<br/>
        ///   .create({<br/>
        ///     model: 'magnific_precision_upscaler_v2',<br/>
        ///     imageUri: 'https://example.com/photo.jpg',<br/>
        ///     scaleFactor: 2,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateImageUpscaleResponse> CreateImageUpscaleAsync(

            global::Runway.CreateImageUpscaleRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image upscale<br/>
        /// Upscale an image with Magnific precision upscaling. Each input dimension must be between 300px and 8000px. Output width and height are the input dimensions multiplied by `scaleFactor` (default 2). Output width times height cannot exceed 25,300,000 pixels (~25.3 million).
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
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// const task = await client.imageUpscale<br/>
        ///   .create({<br/>
        ///     model: 'magnific_precision_upscaler_v2',<br/>
        ///     imageUri: 'https://example.com/photo.jpg',<br/>
        ///     scaleFactor: 2,<br/>
        ///   })<br/>
        ///   .waitForTaskOutput();<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateImageUpscaleResponse>> CreateImageUpscaleAsResponseAsync(

            global::Runway.CreateImageUpscaleRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image upscale<br/>
        /// Upscale an image with Magnific precision upscaling. Each input dimension must be between 300px and 8000px. Output width and height are the input dimensions multiplied by `scaleFactor` (default 2). Output width times height cannot exceed 25,300,000 pixels (~25.3 million).
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateImageUpscaleResponse> CreateImageUpscaleAsync(
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}