
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGrokImagine15Lite
    {
        /// <summary>
        /// The start frame of the output video. The output keeps its aspect ratio, which (width / height) must be between 0.4 and 2.5. See [our docs](/assets/inputs#images) for image input requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15LitePromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15LitePromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// An optional text prompt describing motion or changes in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video. The output keeps the input image's aspect ratio. `auto_1080p` is rendered at 720p and upscaled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGrokImagine15LiteRatioJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGrokImagine15LiteRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"grok_imagine_1_5_lite"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "grok_imagine_1_5_lite";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGrokImagine15Lite" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// The start frame of the output video. The output keeps its aspect ratio, which (width / height) must be between 0.4 and 2.5. See [our docs](/assets/inputs#images) for image input requirements.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt describing motion or changes in the output video.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video. The output keeps the input image's aspect ratio. `auto_1080p` is rendered at 720p and upscaled.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestGrokImagine15Lite(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15LitePromptImagePromptImage>> promptImage,
            string? promptText,
            int? duration,
            global::Runway.CreateImageToVideoRequestGrokImagine15LiteRatio? ratio,
            string model = "grok_imagine_1_5_lite")
        {
            this.PromptImage = promptImage;
            this.PromptText = promptText;
            this.Duration = duration;
            this.Ratio = ratio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGrokImagine15Lite" /> class.
        /// </summary>
        public CreateImageToVideoRequestGrokImagine15Lite()
        {
        }

    }
}