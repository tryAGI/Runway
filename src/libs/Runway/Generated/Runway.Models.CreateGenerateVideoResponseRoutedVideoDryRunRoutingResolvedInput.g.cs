
#nullable enable

namespace Runway
{
    /// <summary>
    /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
    /// </summary>
    public sealed partial class CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedInput
    {
        /// <summary>
        /// Duration in seconds used for routing display (request value or router default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Concrete output ratio derived from aspectRatio (e.g. "1280:720"), or the router default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ratio { get; set; }

        /// <summary>
        /// Resolution tier from the request, or the router default when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedInput" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration in seconds used for routing display (request value or router default).
        /// </param>
        /// <param name="ratio">
        /// Concrete output ratio derived from aspectRatio (e.g. "1280:720"), or the router default.
        /// </param>
        /// <param name="resolution">
        /// Resolution tier from the request, or the router default when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedInput(
            double duration,
            string ratio,
            string resolution)
        {
            this.Duration = duration;
            this.Ratio = ratio ?? throw new global::System.ArgumentNullException(nameof(ratio));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedInput" /> class.
        /// </summary>
        public CreateGenerateVideoResponseRoutedVideoDryRunRoutingResolvedInput()
        {
        }

    }
}