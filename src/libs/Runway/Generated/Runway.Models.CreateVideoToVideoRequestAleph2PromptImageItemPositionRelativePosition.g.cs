
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"position"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "position";

        /// <summary>
        /// Position as a fraction [0.0, 1.0] of the total video duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positionPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PositionPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition" /> class.
        /// </summary>
        /// <param name="positionPercentage">
        /// Position as a fraction [0.0, 1.0] of the total video duration.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition(
            double positionPercentage,
            string type = "position")
        {
            this.Type = type;
            this.PositionPercentage = positionPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition" /> class.
        /// </summary>
        public CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition FromPositionPercentage(double positionPercentage)
        {
            return new CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition
            {
                PositionPercentage = positionPercentage,
            };
        }

    }
}