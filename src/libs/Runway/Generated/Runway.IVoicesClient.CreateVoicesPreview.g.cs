#nullable enable

namespace Runway
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Preview a voice<br/>
        /// Generate a short audio preview of a voice from a text description. Use this to audition a voice before creating it.
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
        /// const preview = await client.voices.preview({<br/>
        ///   prompt: 'A warm, friendly voice with a slight British accent',<br/>
        ///   model: 'eleven_ttv_v3',<br/>
        /// });<br/>
        /// console.log(preview.url, preview.durationSecs);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateVoicesPreviewResponse> CreateVoicesPreviewAsync(

            global::Runway.CreateVoicesPreviewRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a voice<br/>
        /// Generate a short audio preview of a voice from a text description. Use this to audition a voice before creating it.
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
        /// const preview = await client.voices.preview({<br/>
        ///   prompt: 'A warm, friendly voice with a slight British accent',<br/>
        ///   model: 'eleven_ttv_v3',<br/>
        /// });<br/>
        /// console.log(preview.url, preview.durationSecs);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateVoicesPreviewResponse>> CreateVoicesPreviewAsResponseAsync(

            global::Runway.CreateVoicesPreviewRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview a voice<br/>
        /// Generate a short audio preview of a voice from a text description. Use this to audition a voice before creating it.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired voice characteristics. Must be at least 20 characters.
        /// </param>
        /// <param name="model">
        /// The voice design model to use. Prefer eleven_ttv_v3 (latest); eleven_multilingual_ttv_v2 is the previous generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateVoicesPreviewResponse> CreateVoicesPreviewAsync(
            string prompt,
            global::Runway.CreateVoicesPreviewRequestModel model,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}