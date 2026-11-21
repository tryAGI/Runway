
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestHailuo3Highspeed
    {
        /// <summary>
        /// The text prompt describing the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3HighspeedResolutionJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestHailuo3HighspeedResolution? Resolution { get; set; }

        /// <summary>
        /// An MP4 or MOV reference video, 2–15 seconds long at 22–62 fps. Frame rates near the limits are normalized to 24–60 fps.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVideo { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestHailuo3HighspeedRatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestHailuo3HighspeedRatio? Ratio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReference>? References { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideos")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceAudio")]
        public global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReferenceAudioItem>? ReferenceAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"hailuo3_highspeed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "hailuo3_highspeed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestHailuo3Highspeed" /> class.
        /// </summary>
        /// <param name="promptText">
        /// The text prompt describing the output video.
        /// </param>
        /// <param name="promptVideo">
        /// An MP4 or MOV reference video, 2–15 seconds long at 22–62 fps. Frame rates near the limits are normalized to 24–60 fps.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="resolution">
        /// The output video resolution.<br/>
        /// Default Value: 768p
        /// </param>
        /// <param name="duration">
        /// Default Value: 5
        /// </param>
        /// <param name="ratio"></param>
        /// <param name="references"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="referenceAudio"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestHailuo3Highspeed(
            string promptText,
            string promptVideo,
            global::Runway.CreateVideoToVideoRequestHailuo3HighspeedResolution? resolution,
            int? duration,
            global::Runway.CreateVideoToVideoRequestHailuo3HighspeedRatio? ratio,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReference>? references,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::Runway.CreateVideoToVideoRequestHailuo3HighspeedReferenceAudioItem>? referenceAudio,
            string model = "hailuo3_highspeed")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Resolution = resolution;
            this.PromptVideo = promptVideo;
            this.Duration = duration;
            this.Ratio = ratio;
            this.References = references;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudio = referenceAudio;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestHailuo3Highspeed" /> class.
        /// </summary>
        public CreateVideoToVideoRequestHailuo3Highspeed()
        {
        }

    }
}