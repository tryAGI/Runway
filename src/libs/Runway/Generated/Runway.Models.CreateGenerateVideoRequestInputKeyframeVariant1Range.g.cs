
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoRequestInputKeyframeVariant1Range
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartSeconds { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputKeyframeVariant1Range" /> class.
        /// </summary>
        /// <param name="startSeconds"></param>
        /// <param name="endSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoRequestInputKeyframeVariant1Range(
            int startSeconds,
            int endSeconds)
        {
            this.StartSeconds = startSeconds;
            this.EndSeconds = endSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputKeyframeVariant1Range" /> class.
        /// </summary>
        public CreateGenerateVideoRequestInputKeyframeVariant1Range()
        {
        }

    }
}