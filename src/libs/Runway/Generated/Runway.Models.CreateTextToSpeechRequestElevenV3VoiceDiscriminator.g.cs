
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestElevenV3VoiceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorTypeJsonConverter))]
        public global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV3VoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToSpeechRequestElevenV3VoiceDiscriminator(
            global::Runway.CreateTextToSpeechRequestElevenV3VoiceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestElevenV3VoiceDiscriminator" /> class.
        /// </summary>
        public CreateTextToSpeechRequestElevenV3VoiceDiscriminator()
        {
        }

    }
}