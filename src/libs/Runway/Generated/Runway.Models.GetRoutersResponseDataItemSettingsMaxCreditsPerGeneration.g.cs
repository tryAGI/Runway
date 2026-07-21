
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional per-modality hard caps on credits for one generation. Models whose estimated cost for that modality exceeds the cap are excluded.
    /// </summary>
    public sealed partial class GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public int? Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public int? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public int? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration(
            int? video,
            int? image,
            int? audio)
        {
            this.Video = video;
            this.Image = image;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration" /> class.
        /// </summary>
        public GetRoutersResponseDataItemSettingsMaxCreditsPerGeneration()
        {
        }

    }
}