
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAvatarVideosRequest
    {
        /// <summary>
        /// The model to use for avatar video generation.
        /// </summary>
        /// <default>"gwm1_avatars"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gwm1_avatars";

        /// <summary>
        /// The avatar configuration for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AvatarJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Avatar Avatar { get; set; }

        /// <summary>
        /// The speech source for avatar video generation. Either an audio file or text script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.SpeechJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Speech Speech { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequest" /> class.
        /// </summary>
        /// <param name="avatar">
        /// The avatar configuration for the session.
        /// </param>
        /// <param name="speech">
        /// The speech source for avatar video generation. Either an audio file or text script.
        /// </param>
        /// <param name="model">
        /// The model to use for avatar video generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAvatarVideosRequest(
            global::Runway.Avatar avatar,
            global::Runway.Speech speech,
            string model = "gwm1_avatars")
        {
            this.Model = model;
            this.Avatar = avatar;
            this.Speech = speech;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAvatarVideosRequest" /> class.
        /// </summary>
        public CreateAvatarVideosRequest()
        {
        }

    }
}