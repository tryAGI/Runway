
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom voice belonging to the authenticated organization.
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// The ID of a custom voice created via the Voices API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of a custom voice created via the Voices API.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice(
            global::System.Guid id,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice FromId(global::System.Guid id)
        {
            return new CreateTextToSpeechRequestElevenMultilingualV2VoiceCustomTextToSpeechVoice
            {
                Id = id,
            };
        }

    }
}