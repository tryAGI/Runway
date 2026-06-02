
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"timestamp"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "timestamp";

        /// <summary>
        /// Absolute timestamp in seconds from the start of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimestampSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition" /> class.
        /// </summary>
        /// <param name="timestampSeconds">
        /// Absolute timestamp in seconds from the start of the output video.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition(
            double timestampSeconds,
            string type = "timestamp")
        {
            this.Type = type;
            this.TimestampSeconds = timestampSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition" /> class.
        /// </summary>
        public CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition FromTimestampSeconds(double timestampSeconds)
        {
            return new CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition
            {
                TimestampSeconds = timestampSeconds,
            };
        }

    }
}