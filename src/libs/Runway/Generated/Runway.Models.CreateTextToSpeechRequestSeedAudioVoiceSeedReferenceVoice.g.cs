
#nullable enable

namespace Runway
{
    /// <summary>
    /// Clone from a single reference audio clip, then speak promptText in that voice.
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"reference-audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "reference-audio";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
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
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice(
            string audioUri,
            string type = "reference-audio")
        {
            this.Type = type;
            this.AudioUri = audioUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice" /> class.
        /// </summary>
        public CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice FromAudioUri(string audioUri)
        {
            return new CreateTextToSpeechRequestSeedAudioVoiceSeedReferenceVoice
            {
                AudioUri = audioUri,
            };
        }

    }
}