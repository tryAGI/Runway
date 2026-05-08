#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Create avatar<br/>
        /// Create a new avatar with a reference image and voice.
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
        /// const avatar = await client.avatars.create({<br/>
        ///   name: 'Customer Support Agent',<br/>
        ///   referenceImage: 'https://example.com/reference.jpg',<br/>
        ///   personality: 'You are a helpful customer support agent. Be friendly and concise.',<br/>
        ///   voice: { type: 'runway-live-preset', presetId: 'adrian' },<br/>
        /// });<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.CreateAvatarsResponse> CreateAvatarsAsync(

            global::Runway.CreateAvatarsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar<br/>
        /// Create a new avatar with a reference image and voice.
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
        /// const avatar = await client.avatars.create({<br/>
        ///   name: 'Customer Support Agent',<br/>
        ///   referenceImage: 'https://example.com/reference.jpg',<br/>
        ///   personality: 'You are a helpful customer support agent. Be friendly and concise.',<br/>
        ///   voice: { type: 'runway-live-preset', presetId: 'adrian' },<br/>
        /// });<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.CreateAvatarsResponse>> CreateAvatarsAsResponseAsync(

            global::Runway.CreateAvatarsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar<br/>
        /// Create a new avatar with a reference image and voice.
        /// </summary>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="name">
        /// The character name for the avatar.
        /// </param>
        /// <param name="referenceImage">
        /// A HTTPS URL, Runway URI, or data URI containing the avatar reference image. See [our docs](/assets/inputs#images) for supported formats.<br/>
        /// Example: https://example.com/reference.jpg
        /// </param>
        /// <param name="personality">
        /// System prompt defining how the avatar should behave in conversations.<br/>
        /// Example: You are a helpful support agent assisting users with their account questions. Be friendly, patient, and provide clear step-by-step guidance.
        /// </param>
        /// <param name="startScript">
        /// Optional opening message that the avatar will say when a session starts.<br/>
        /// Example: Hello! How can I help you today?
        /// </param>
        /// <param name="voice">
        /// The voice configuration for the avatar.<br/>
        /// Example: {"type":"runway-live-preset","presetId":"adrian"}
        /// </param>
        /// <param name="documentIds">
        /// Optional list of knowledge document IDs to attach to this avatar. Documents provide additional context during conversations.
        /// </param>
        /// <param name="imageProcessing">
        /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
        /// Default Value: optimize
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.CreateAvatarsResponse> CreateAvatarsAsync(
            string name,
            string referenceImage,
            string personality,
            global::Runway.Voice voice,
            string xRunwayVersion = "2024-11-06",
            string? startScript = default,
            global::System.Collections.Generic.IList<global::System.Guid>? documentIds = default,
            global::Runway.CreateAvatarsRequestImageProcessing? imageProcessing = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}