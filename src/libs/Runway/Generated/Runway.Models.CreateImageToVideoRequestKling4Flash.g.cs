
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestKling4Flash
    {
        /// <summary>
        /// The first frame of the video, or an array with a first frame and optional middle and last frames. The video follows the first frame’s aspect ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>> PromptImage { get; set; }

        /// <summary>
        /// Output quality tier. The video keeps the input media framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestKling4FlashRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestKling4FlashRatio? Ratio { get; set; }

        /// <summary>
        /// A text prompt describing what should happen in the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The duration of the output video in seconds. Defaults to 5.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReference>? References { get; set; }

        /// <summary>
        /// Up to 5 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<object>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"kling_4_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "kling_4_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling4Flash" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// The first frame of the video, or an array with a first frame and optional middle and last frames. The video follows the first frame’s aspect ratio.
        /// </param>
        /// <param name="ratio">
        /// Output quality tier. The video keeps the input media framing.
        /// </param>
        /// <param name="promptText">
        /// A text prompt describing what should happen in the video.
        /// </param>
        /// <param name="duration">
        /// The duration of the output video in seconds. Defaults to 5.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="references">
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </param>
        /// <param name="referenceVideos">
        /// Up to 5 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestKling4Flash(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>> promptImage,
            global::Runway.CreateImageToVideoRequestKling4FlashRatio? ratio,
            string? promptText,
            int? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReference>? references,
            global::System.Collections.Generic.IList<object>? referenceVideos,
            string model = "kling_4_flash")
        {
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.PromptText = promptText;
            this.Duration = duration;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling4Flash" /> class.
        /// </summary>
        public CreateImageToVideoRequestKling4Flash()
        {
        }

    }
}