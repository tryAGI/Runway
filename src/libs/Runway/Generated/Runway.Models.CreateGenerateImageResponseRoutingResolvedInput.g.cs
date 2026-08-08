
#nullable enable

namespace Runway
{
    /// <summary>
    /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
    /// </summary>
    public sealed partial class CreateGenerateImageResponseRoutingResolvedInput
    {
        /// <summary>
        /// Concrete output ratio derived from aspectRatio and resolution for the selected model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ratio { get; set; }

        /// <summary>
        /// Aspect ratio used for routing display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AspectRatio { get; set; }

        /// <summary>
        /// Megapixel tier used for routing display.
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
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponseRoutingResolvedInput" /> class.
        /// </summary>
        /// <param name="ratio">
        /// Concrete output ratio derived from aspectRatio and resolution for the selected model.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio used for routing display.
        /// </param>
        /// <param name="resolution">
        /// Megapixel tier used for routing display.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateImageResponseRoutingResolvedInput(
            string ratio,
            string aspectRatio,
            string resolution)
        {
            this.Ratio = ratio ?? throw new global::System.ArgumentNullException(nameof(ratio));
            this.AspectRatio = aspectRatio ?? throw new global::System.ArgumentNullException(nameof(aspectRatio));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateImageResponseRoutingResolvedInput" /> class.
        /// </summary>
        public CreateGenerateImageResponseRoutingResolvedInput()
        {
        }

    }
}