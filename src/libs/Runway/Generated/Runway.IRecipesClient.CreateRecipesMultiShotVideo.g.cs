#nullable enable

namespace Runway
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create a multi-shot video<br/>
        /// Generate a multi-cut video from a story prompt (auto mode) or a custom shot list (custom mode).
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
        /// const task = await client.recipes.multiShotVideo({<br/>
        ///   version: '2026-06',<br/>
        ///   prompt: 'A lone astronaut discovers a glowing forest on a distant planet',<br/>
        ///   duration: 10,<br/>
        ///   ratio: '1280:720',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesMultiShotVideoResponse> CreateRecipesMultiShotVideoAsync(

            global::Runway.CreateRecipesMultiShotVideoRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a multi-shot video<br/>
        /// Generate a multi-cut video from a story prompt (auto mode) or a custom shot list (custom mode).
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
        /// const task = await client.recipes.multiShotVideo({<br/>
        ///   version: '2026-06',<br/>
        ///   prompt: 'A lone astronaut discovers a glowing forest on a distant planet',<br/>
        ///   duration: 10,<br/>
        ///   ratio: '1280:720',<br/>
        /// });<br/>
        /// console.log(task);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateRecipesMultiShotVideoResponse>> CreateRecipesMultiShotVideoAsResponseAsync(

            global::Runway.CreateRecipesMultiShotVideoRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a multi-shot video<br/>
        /// Generate a multi-cut video from a story prompt (auto mode) or a custom shot list (custom mode).
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateRecipesMultiShotVideoResponse> CreateRecipesMultiShotVideoAsync(
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}