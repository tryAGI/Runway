
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestHappyhorse10
    {
        /// <summary>
        /// A string up to 2500 characters (measured in UTF-16 code units) describing motion or changes in the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>> PromptImage { get; set; }

        /// <summary>
        /// Output quality tier. Output aspect ratio follows the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageToVideoRequestHappyhorse10ResolutionJsonConverter))]
        public global::Runway.CreateImageToVideoRequestHappyhorse10Resolution? Resolution { get; set; }

        /// <summary>
        /// The number of seconds of duration for the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"happyhorse_1_0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "happyhorse_1_0";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHappyhorse10" /> class.
        /// </summary>
        /// <param name="promptImage"></param>
        /// <param name="promptText">
        /// A string up to 2500 characters (measured in UTF-16 code units) describing motion or changes in the output video.
        /// </param>
        /// <param name="resolution">
        /// Output quality tier. Output aspect ratio follows the input image.
        /// </param>
        /// <param name="duration">
        /// The number of seconds of duration for the output video.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestHappyhorse10(
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<global::Runway.CreateImageToVideoRequestHappyhorse10PromptImagePromptImage>> promptImage,
            string? promptText,
            global::Runway.CreateImageToVideoRequestHappyhorse10Resolution? resolution,
            int? duration,
            string model = "happyhorse_1_0")
        {
            this.PromptText = promptText;
            this.PromptImage = promptImage;
            this.Resolution = resolution;
            this.Duration = duration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestHappyhorse10" /> class.
        /// </summary>
        public CreateImageToVideoRequestHappyhorse10()
        {
        }

    }
}