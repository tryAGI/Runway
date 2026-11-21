
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom voice belonging to the authenticated organization.
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice
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
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of a custom voice created via the Voices API.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice(
            global::System.Guid id,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice FromId(global::System.Guid id)
        {
            return new CreateTextToSpeechRequestElevenV4VoiceCustomTextToSpeechVoice
            {
                Id = id,
            };
        }

    }
}