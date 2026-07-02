
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional edit window. When set, the edit applies only to this time range and the keyframe timestamp must fall within it. All keyframes must either set a range or none may.
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestVariant1KeyframeVariant2Range
    {
        /// <summary>
        /// Start of the edit window in whole seconds from the start of the input video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartSeconds { get; set; }

        /// <summary>
        /// End of the edit window (exclusive) in whole seconds from the start of the input video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1KeyframeVariant2Range" /> class.
        /// </summary>
        /// <param name="startSeconds">
        /// Start of the edit window in whole seconds from the start of the input video.
        /// </param>
        /// <param name="endSeconds">
        /// End of the edit window (exclusive) in whole seconds from the start of the input video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestVariant1KeyframeVariant2Range(
            int startSeconds,
            int endSeconds)
        {
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1KeyframeVariant2Range" /> class.
        /// </summary>
        public CreateVideoToVideoRequestVariant1KeyframeVariant2Range()
        {
        }

    }
}