
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarsRequest
    {
        /// <summary>
        /// The character name for the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A HTTPS URL, Runway URI, or data URI containing the avatar reference image. See [our docs](/assets/inputs#images) for supported formats.<br/>
        /// Example: https://example.com/reference.jpg
        /// </summary>
        /// <example>https://example.com/reference.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceImage { get; set; }

        /// <summary>
        /// System prompt defining how the avatar should behave in conversations.<br/>
        /// Example: You are a helpful support agent assisting users with their account questions. Be friendly, patient, and provide clear step-by-step guidance.
        /// </summary>
        /// <example>You are a helpful support agent assisting users with their account questions. Be friendly, patient, and provide clear step-by-step guidance.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Personality { get; set; }

        /// <summary>
        /// Optional opening message that the avatar will say when a session starts.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.VoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Voice Voice { get; set; }

        /// <summary>
        /// Optional list of knowledge document IDs to attach to this avatar. Documents provide additional context during conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? DocumentIds { get; set; }

        /// <summary>
        /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
        /// Default Value: optimize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageProcessing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateAvatarsRequestImageProcessingJsonConverter))]
        public global::Runway.CreateAvatarsRequestImageProcessing? ImageProcessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsRequest" /> class.
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
        /// <param name="voice">
        /// The voice configuration for the avatar.<br/>
        /// Example: {"type":"runway-live-preset","presetId":"adrian"}
        /// </param>
        /// <param name="startScript">
        /// Optional opening message that the avatar will say when a session starts.<br/>
        /// Example: Hello! How can I help you today?
        /// </param>
        /// <param name="documentIds">
        /// Optional list of knowledge document IDs to attach to this avatar. Documents provide additional context during conversations.
        /// </param>
        /// <param name="imageProcessing">
        /// Controls image preprocessing. `optimize` improves the image for better avatar results. `none` uses the image as-is; quality not guaranteed.<br/>
        /// Default Value: optimize
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarsRequest(
            string name,
            string referenceImage,
            string personality,
            global::Runway.Voice voice,
            string? startScript,
            global::System.Collections.Generic.IList<global::System.Guid>? documentIds,
            global::Runway.CreateAvatarsRequestImageProcessing? imageProcessing)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ReferenceImage = referenceImage;
            this.Personality = personality ?? throw new global::System.ArgumentNullException(nameof(personality));
            this.StartScript = startScript;
            this.Voice = voice;
            this.DocumentIds = documentIds;
            this.ImageProcessing = imageProcessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarsRequest" /> class.
        /// </summary>
        public CreateAvatarsRequest()
        {
        }

    }
}