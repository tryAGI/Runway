
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoUpscaleRequestEnhanceFrameRate
    {
        /// <summary>
        /// The video to convert. See [video inputs](/assets/inputs#videos) for URL, upload, and file size limits. Maximum duration is 300 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// The output frame rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetFramerate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate TargetFramerate { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"enhance_frame_rate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "enhance_frame_rate";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequestEnhanceFrameRate" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// The video to convert. See [video inputs](/assets/inputs#videos) for URL, upload, and file size limits. Maximum duration is 300 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="targetFramerate">
        /// The output frame rate.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoUpscaleRequestEnhanceFrameRate(
            string videoUri,
            global::Runway.CreateVideoUpscaleRequestEnhanceFrameRateTargetFramerate targetFramerate,
            string model = "enhance_frame_rate")
        {
            this.VideoUri = videoUri;
            this.TargetFramerate = targetFramerate;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequestEnhanceFrameRate" /> class.
        /// </summary>
        public CreateVideoUpscaleRequestEnhanceFrameRate()
        {
        }

    }
}