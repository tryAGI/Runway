#nullable enable

namespace Runway
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a voice<br/>
        /// Create a custom voice from a text description, or clone a voice from an audio sample.
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
        /// const voice = await client.voices.create({<br/>
        ///   name: 'My Custom Voice',<br/>
        ///   from: {<br/>
        ///     type: 'text',<br/>
        ///     prompt: 'A warm, friendly voice with a slight British accent',<br/>
        ///     model: 'eleven_ttv_v3',<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateVoicesResponse> CreateVoicesAsync(

            global::Runway.CreateVoicesRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice<br/>
        /// Create a custom voice from a text description, or clone a voice from an audio sample.
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
        /// const voice = await client.voices.create({<br/>
        ///   name: 'My Custom Voice',<br/>
        ///   from: {<br/>
        ///     type: 'text',<br/>
        ///     prompt: 'A warm, friendly voice with a slight British accent',<br/>
        ///     model: 'eleven_ttv_v3',<br/>
        ///   },<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateVoicesResponse>> CreateVoicesAsResponseAsync(

            global::Runway.CreateVoicesRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a voice<br/>
        /// Create a custom voice from a text description, or clone a voice from an audio sample.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// A name for the voice.
        /// </param>
        /// <param name="description">
        /// An optional description of the voice.
        /// </param>
        /// <param name="from"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateVoicesResponse> CreateVoicesAsync(
            string name,
            global::Runway.From from,
            string xRunwayVersion = "2024-11-06",
            string? description = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}