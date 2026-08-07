
#nullable enable

namespace Runway
{
    /// <summary>
    /// Estimated cost, computed against current pricing.
    /// </summary>
    public sealed partial class CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingEstimatedCost
    {
        /// <summary>
        /// Estimated cost of the generation in credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingEstimatedCost" /> class.
        /// </summary>
        /// <param name="credits">
        /// Estimated cost of the generation in credits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingEstimatedCost(
            double credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingEstimatedCost" /> class.
        /// </summary>
        public CreateGenerateVideoResponseRoutedVideoTaskCreatedRoutingEstimatedCost()
        {
        }

    }
}