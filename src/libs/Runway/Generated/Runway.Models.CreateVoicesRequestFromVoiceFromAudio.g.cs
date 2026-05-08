
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoicesRequestFromVoiceFromAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// Audio sample to clone the voice from. Must be between 10 seconds and 5 minutes long and at most 10MB. For best results, use a clear recording with minimal background noise and varied tone.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesRequestFromVoiceFromAudio" /> class.
        /// </summary>
        /// <param name="audio">
        /// Audio sample to clone the voice from. Must be between 10 seconds and 5 minutes long and at most 10MB. For best results, use a clear recording with minimal background noise and varied tone.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoicesRequestFromVoiceFromAudio(
            string audio,
            string type = "audio")
        {
            this.Type = type;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoicesRequestFromVoiceFromAudio" /> class.
        /// </summary>
        public CreateVoicesRequestFromVoiceFromAudio()
        {
        }
    }
}