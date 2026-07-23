
#nullable enable

namespace Runway
{
    /// <summary>
    /// Clone a voice from a reference audio clip, then speak promptText in that voice. Routes only to models that support voice cloning.
    /// </summary>
    public sealed partial class CreateGenerateAudioRequestInputVoiceAudioReferenceVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"reference-audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "reference-audio";

        /// <summary>
        /// A 1–30 second clip to clone the voice from.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputVoiceAudioReferenceVoice" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// A 1–30 second clip to clone the voice from.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateAudioRequestInputVoiceAudioReferenceVoice(
            string audioUri,
            string type = "reference-audio")
        {
            this.Type = type;
            this.AudioUri = audioUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateAudioRequestInputVoiceAudioReferenceVoice" /> class.
        /// </summary>
        public CreateGenerateAudioRequestInputVoiceAudioReferenceVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateGenerateAudioRequestInputVoiceAudioReferenceVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateGenerateAudioRequestInputVoiceAudioReferenceVoice FromAudioUri(string audioUri)
        {
            return new CreateGenerateAudioRequestInputVoiceAudioReferenceVoice
            {
                AudioUri = audioUri,
            };
        }

    }
}