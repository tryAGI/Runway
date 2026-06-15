
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestVariant1
    {
        /// <summary>
        /// A non-empty string up to 1000 characters describing what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// Timed guidance images placed at specific points in the input video. Up to 5 keyframes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframes")]
        public global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>? Keyframes { get; set; }

        /// <summary>
        /// The input video to edit. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Target aspect ratio for expand/outpaint. Letterboxes the input video and keyframes before generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetAspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoToVideoRequestVariant1TargetAspectRatioJsonConverter))]
        public global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio? TargetAspectRatio { get; set; }

        /// <summary>
        /// Settings that affect the behavior of the content moderation system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentModeration")]
        public global::Runway.CreateVideoToVideoRequestVariant1ContentModeration? ContentModeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"aleph2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "aleph2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters describing what should appear in the output.
        /// </param>
        /// <param name="videoUri">
        /// The input video to edit. Must be 30 seconds or shorter.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="keyframes">
        /// Timed guidance images placed at specific points in the input video. Up to 5 keyframes.
        /// </param>
        /// <param name="seed">
        /// If unspecified, a random number is chosen. Varying the seed integer is a way to get different results for the same other request parameters. Using the same seed integer for an identical request will produce similar results.
        /// </param>
        /// <param name="targetAspectRatio">
        /// Target aspect ratio for expand/outpaint. Letterboxes the input video and keyframes before generation.
        /// </param>
        /// <param name="contentModeration">
        /// Settings that affect the behavior of the content moderation system.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestVariant1(
            string promptText,
            string videoUri,
            global::System.Collections.Generic.IList<global::Runway.AnyOf<global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1, global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant2>>? keyframes,
            int? seed,
            global::Runway.CreateVideoToVideoRequestVariant1TargetAspectRatio? targetAspectRatio,
            global::Runway.CreateVideoToVideoRequestVariant1ContentModeration? contentModeration,
            string model = "aleph2")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Keyframes = keyframes;
            this.VideoUri = videoUri;
            this.Seed = seed;
            this.TargetAspectRatio = targetAspectRatio;
            this.ContentModeration = contentModeration;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1" /> class.
        /// </summary>
        public CreateVideoToVideoRequestVariant1()
        {
        }

    }
}