
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGrokImagine15
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// The output resolution. Output aspect ratio follows the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestGrokImagine15ResolutionJsonConverter))]
        public global::Runway.CreateImageToVideoRequestGrokImagine15Resolution? Resolution { get; set; }

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
        /// 
        /// </summary>
        /// <default>"grok_imagine_1_5"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "grok_imagine_1_5";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGrokImagine15" /> class.
        /// </summary>
        /// <param name="promptImage"></param>
        /// <param name="resolution">
        /// The output resolution. Output aspect ratio follows the input image.
        /// </param>
        /// <param name="promptText">
        /// An optional text prompt describing motion or changes in the output video.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestGrokImagine15(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestGrokImagine15PromptImagePromptImage>> promptImage,
            global::Runway.CreateImageToVideoRequestGrokImagine15Resolution? resolution,
            string? promptText,
            int? duration,
            string model = "grok_imagine_1_5")
        {
            this.PromptImage = promptImage;
            this.Resolution = resolution;
            this.PromptText = promptText;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGrokImagine15" /> class.
        /// </summary>
        public CreateImageToVideoRequestGrokImagine15()
        {
        }

    }
}