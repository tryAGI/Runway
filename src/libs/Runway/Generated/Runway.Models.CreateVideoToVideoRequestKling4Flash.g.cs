
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestKling4Flash
    {
        /// <summary>
        /// The video to edit.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// A text prompt describing how to edit the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Output quality tier. The video keeps the input media framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestKling4FlashRatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestKling4FlashRatio? Ratio { get; set; }

        /// <summary>
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKling4FlashReference>? References { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKling4Flash" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The video to edit.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A text prompt describing how to edit the video.
        /// </param>
        /// <param name="ratio">
        /// Output quality tier. The video keeps the input media framing.
        /// </param>
        /// <param name="references">
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestKling4Flash(
            string videoUri,
            string promptText,
            global::Runway.CreateVideoToVideoRequestKling4FlashRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKling4FlashReference>? references,
            string model = "kling_4_flash")
        {
            this.VideoUri = videoUri;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.References = references;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKling4Flash" /> class.
        /// </summary>
        public CreateVideoToVideoRequestKling4Flash()
        {
        }

    }
}