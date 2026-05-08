
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAvatarsRequest
    {
        /// <summary>
        /// The character name for the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A HTTPS URL, Runway URI, or data URI containing the avatar reference image. See [our docs](/assets/inputs#images) for supported formats.<br/>
        /// Example: https://example.com/reference.jpg
        /// </summary>
        /// <example>https://example.com/reference.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImage")]
        public string? ReferenceImage { get; set; }

        /// <summary>
        /// System prompt defining how the avatar should behave in conversations.<br/>
        /// Example: You are a helpful support agent assisting users with their account questions. Be friendly, patient, and provide clear step-by-step guidance.
        /// </summary>
        /// <example>You are a helpful support agent assisting users with their account questions. Be friendly, patient, and provide clear step-by-step guidance.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public string? Personality { get; set; }

        /// <summary>
        /// Optional opening message that the avatar will say when a session starts. Set to null to clear.<br/>
        /// Example: Hello! How can I help you today?
        /// </summary>
        /// <example>Hello! How can I help you today?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startScript")]
        public string? StartScript { get; set; }

        /// <summary>
        /// The voice configuration for the avatar.<br/>
        /// Example: {"type":"runway-live-preset","presetId":"adrian"}
        /// </summary>
        /// <example>{"type":"runway-live-preset","presetId":"adrian"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.Voice2JsonConverter))]
        public global::Runway.Voice2? Voice { get; set; }

        /// <summary>
        /// List of knowledge document IDs to attach to this avatar. Replaces all current attachments. Documents provide additional context during conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DocumentIds { get; set; }

        /// <summary>
        /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
        /// Default Value: optimize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageProcessing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.PatchAvatarsRequestImageProcessingJsonConverter))]
        public global::Runway.PatchAvatarsRequestImageProcessing? ImageProcessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAvatarsRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAvatarsRequest(
            string? name,
            string? referenceImage,
            string? personality,
            string? startScript,
            global::Runway.Voice2? voice,
            global::System.Collections.Generic.IList<global::System.Guid>? documentIds,
            global::Runway.PatchAvatarsRequestImageProcessing? imageProcessing)
        {
            this.Name = name;
            this.ReferenceImage = referenceImage;
            this.Personality = personality;
            this.StartScript = startScript;
            this.Voice = voice;
            this.DocumentIds = documentIds;
            this.ImageProcessing = imageProcessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAvatarsRequest" /> class.
        /// </summary>
        public PatchAvatarsRequest()
        {
        }
    }
}