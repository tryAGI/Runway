#nullable enable

namespace Runway
{
    public partial interface IStartGeneratingClient
    {
        /// <summary>
        /// Image to vector<br/>
        /// Convert a source image into a scalable SVG.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// const response = await fetch('https://api.dev.runwayml.com/v1/image_to_vector', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: 'Bearer ' + process.env.RUNWAYML_API_SECRET,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///     'X-Runway-Version': '2024-11-06',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     model: 'ideogram_vector',<br/>
        ///     imageUri: 'https://example.com/illustration.png',<br/>
        ///     vectorizationMode: 'default',<br/>
        ///   }),<br/>
        /// });<br/>
        /// if (!response.ok) throw new Error(await response.text());<br/>
        /// const task = await response.json();<br/>
        /// // Poll GET /v1/tasks/{task.id} until the SVG is ready.<br/>
        /// console.log(task.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateImageToVectorResponse> CreateImageToVectorAsync(

            global::Runway.CreateImageToVectorRequest request,
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to vector<br/>
        /// Convert a source image into a scalable SVG.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Runway.ApiException"></exception>
        /// <remarks>
        /// const response = await fetch('https://api.dev.runwayml.com/v1/image_to_vector', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: 'Bearer ' + process.env.RUNWAYML_API_SECRET,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///     'X-Runway-Version': '2024-11-06',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({<br/>
        ///     model: 'ideogram_vector',<br/>
        ///     imageUri: 'https://example.com/illustration.png',<br/>
        ///     vectorizationMode: 'default',<br/>
        ///   }),<br/>
        /// });<br/>
        /// if (!response.ok) throw new Error(await response.text());<br/>
        /// const task = await response.json();<br/>
        /// // Poll GET /v1/tasks/{task.id} until the SVG is ready.<br/>
        /// console.log(task.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateImageToVectorResponse>> CreateImageToVectorAsResponseAsync(

            global::Runway.CreateImageToVectorRequest request,
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image to vector<br/>
        /// Convert a source image into a scalable SVG.
        /// </summary>
        /// <param name="xRunwayTags">
        /// Example: team:growth,env:prod,campaign-q4
        /// </param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateImageToVectorResponse> CreateImageToVectorAsync(
            string? xRunwayTags = default,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}