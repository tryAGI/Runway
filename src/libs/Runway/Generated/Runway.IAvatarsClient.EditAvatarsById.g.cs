#nullable enable

namespace Runway
{
    public partial interface IAvatarsClient
    {
        /// <summary>
        /// Update avatar<br/>
        /// Update an existing avatar. At least one field must be provided.
        /// </summary>
        /// <param name="id"></param>
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
        /// const avatar = await client.avatars.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'Updated Avatar Name' }<br/>
        /// );<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.PatchAvatarsResponse> EditAvatarsByIdAsync(
            global::System.Guid id,

            global::Runway.PatchAvatarsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update avatar<br/>
        /// Update an existing avatar. At least one field must be provided.
        /// </summary>
        /// <param name="id"></param>
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
        /// const avatar = await client.avatars.update(<br/>
        ///   '550e8400-e29b-41d4-a716-446655440000',<br/>
        ///   { name: 'Updated Avatar Name' }<br/>
        /// );<br/>
        /// console.log(avatar);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Runway.AutoSDKHttpResponse<global::Runway.PatchAvatarsResponse>> EditAvatarsByIdAsResponseAsync(
            global::System.Guid id,

            global::Runway.PatchAvatarsRequest request,
            string xRunwayVersion = "2024-11-06",
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update avatar<br/>
        /// Update an existing avatar. At least one field must be provided.
        /// </summary>
        /// <param name="id"></param>
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
        /// Optional opening message that the avatar will say when a session starts. Set to null to clear.<br/>
        /// Example: Hello! How can I help you today?
        /// </param>
        /// <param name="voice">
        /// The voice configuration for the avatar.<br/>
        /// Example: {"type":"runway-live-preset","presetId":"adrian"}
        /// </param>
        /// <param name="documentIds">
        /// List of knowledge document IDs to attach to this avatar. Replaces all current attachments. Documents provide additional context during conversations.
        /// </param>
        /// <param name="imageProcessing">
        /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
        /// Default Value: optimize
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Runway.PatchAvatarsResponse> EditAvatarsByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            string? name = default,
            string? referenceImage = default,
            string? personality = default,
            string? startScript = default,
            global::Runway.Voice2? voice = default,
            global::System.Collections.Generic.IList<global::System.Guid>? documentIds = default,
            global::Runway.PatchAvatarsRequestImageProcessing? imageProcessing = default,
            global::Runway.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}