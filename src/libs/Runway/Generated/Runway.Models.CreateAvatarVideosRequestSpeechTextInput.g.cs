
#nullable enable

namespace Runway
{
    /// <summary>
    /// Provide text for the avatar to speak via TTS.
    /// </summary>
    public sealed partial class CreateAvatarVideosRequestSpeechTextInput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"text"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// Text script for speech-driven video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Optional voice override for TTS. If not provided, the avatar's configured voice is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.Voice3JsonConverter))]
        public global::Runway.Voice3? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInput" /> class.
        /// </summary>
        /// <param name="text">
        /// Text script for speech-driven video generation.
        /// </param>
        /// <param name="voice">
        /// Optional voice override for TTS. If not provided, the avatar's configured voice is used.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarVideosRequestSpeechTextInput(
            string text,
            global::Runway.Voice3? voice,
            string type = "text")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInput" /> class.
        /// </summary>
        public CreateAvatarVideosRequestSpeechTextInput()
        {
        }
    }
}