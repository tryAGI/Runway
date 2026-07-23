
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateAudioRequestInputReferenceAudio
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputReferenceAudio" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioRequestInputReferenceAudio(
            string uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputReferenceAudio" /> class.
        /// </summary>
        public CreateGenerateAudioRequestInputReferenceAudio()
        {
        }

    }
}