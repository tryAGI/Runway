
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestKling4Flash
    {
        /// <summary>
        /// The first frame of the video. Output framing follows this image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashPromptImageVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashPromptImageVariant2Item>> PromptImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public string? Ratio { get; set; }

        /// <summary>
        /// The duration of the output video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// A text prompt describing what should happen in the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

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
        /// The first frame of the video. Output framing follows this image.
        /// </param>
        /// <param name="ratio"></param>
        /// <param name="duration">
        /// The duration of the output video in seconds.
        /// </param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="promptText">
        /// A text prompt describing what should happen in the video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestKling4Flash(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashPromptImageVariant2Item>> promptImage,
            string? ratio,
            int? duration,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestKling4FlashReferenceVideo>? referenceVideos,
            string? promptText,
            string model = "kling_4_flash")
        {
            this.PromptImage = promptImage;
            this.Ratio = ratio;
            this.Duration = duration;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.PromptText = promptText;
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