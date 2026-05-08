
#nullable enable

namespace Runway
{
    /// <summary>
    /// A custom voice created via the Voices API.
    /// </summary>
    public sealed partial class CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice(
            global::System.Guid id,
            string type = "custom")
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice" /> class.
        /// </summary>
        public CreateAvatarVideosRequestSpeechTextInputVoiceCustomVoice()
        {
        }
    }
}