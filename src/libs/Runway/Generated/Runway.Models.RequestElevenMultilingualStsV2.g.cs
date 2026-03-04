
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2
    {
        /// <summary>
        /// Whether to remove background noise from the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeBackgroundNoise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.MediaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.Media Media { get; set; }

        /// <summary>
        /// The voice to use for the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2" /> class.
        /// </summary>
        /// <param name="removeBackgroundNoise">
        /// Whether to remove background noise from the generated speech.
        /// </param>
        /// <param name="media"></param>
        /// <param name="voice">
        /// The voice to use for the generated speech.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestElevenMultilingualStsV2(
            global::Runway.Media media,
            global::Runway.RequestElevenMultilingualStsV2VoiceRunwayPresetVoice voice,
            string model,
            bool? removeBackgroundNoise)
        {
            this.Media = media;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.RemoveBackgroundNoise = removeBackgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2()
        {
        }
    }
}