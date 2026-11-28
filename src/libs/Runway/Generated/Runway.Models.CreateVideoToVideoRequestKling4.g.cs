
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestKling4
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
        /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestKling4RatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestKling4Ratio? Ratio { get; set; }

        /// <summary>
        /// The duration of the edited video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Optional first, middle, and last frames guiding the edit. Middle or last frames can be provided without a first frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptImage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>))]
        public global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>>? PromptImage { get; set; }

        /// <summary>
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKling4Reference>? References { get; set; }

        /// <summary>
        /// Up to 4 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<object>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"kling_4"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "kling_4";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKling4" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The video to edit.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="promptText">
        /// A text prompt describing how to edit the video.
        /// </param>
        /// <param name="ratio">
        /// The target output size. Use a pixel ratio such as `1280:720` or `auto_720p` / `auto_1080p` for adaptive framing.
        /// </param>
        /// <param name="duration">
        /// The duration of the edited video in seconds.
        /// </param>
        /// <param name="promptImage">
        /// Optional first, middle, and last frames guiding the edit. Middle or last frames can be provided without a first frame.
        /// </param>
        /// <param name="references">
        /// Images of characters, objects or styles to use in the video. Up to 10 images in total, frames included.
        /// </param>
        /// <param name="referenceVideos">
        /// Up to 4 videos whose style, motion or camera work should guide the output, together at most 30 seconds long.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestKling4(
            string videoUri,
            string promptText,
            global::Runway.CreateVideoToVideoRequestKling4Ratio? ratio,
            int? duration,
            global::Runway.AnyOf<string?, global::System.Collections.Generic.IList<object>>? promptImage,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestKling4Reference>? references,
            global::System.Collections.Generic.IList<object>? referenceVideos,
            string model = "kling_4")
        {
            this.VideoUri = videoUri;
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.Duration = duration;
            this.PromptImage = promptImage;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestKling4" /> class.
        /// </summary>
        public CreateVideoToVideoRequestKling4()
        {
        }

    }
}