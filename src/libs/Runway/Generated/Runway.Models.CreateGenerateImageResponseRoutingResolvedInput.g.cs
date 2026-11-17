
#nullable enable

namespace Runway
{
    /// <summary>
    /// Request-side defaults resolved for the routing response. Not necessarily identical to prepared model options.
    /// </summary>
    public sealed partial class CreateGenerateImageResponseRoutingResolvedInput
    {
        /// <summary>
        /// Output ratio for the selected model, as `&lt;width&gt;:&lt;height&gt;`. `auto` means the output keeps the source image's framing, so no pixel size was chosen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ratio { get; set; }

        /// <summary>
        /// Aspect ratio resolved for routing display from the request or router default. When `ratio` is `auto`, the source image determines output framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AspectRatio { get; set; }

        /// <summary>
        /// Megapixel tier resolved for routing display from the request or model default. When `ratio` is `auto`, this does not specify output pixel dimensions.
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
        /// Output ratio for the selected model, as `&lt;width&gt;:&lt;height&gt;`. `auto` means the output keeps the source image's framing, so no pixel size was chosen.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio resolved for routing display from the request or router default. When `ratio` is `auto`, the source image determines output framing.
        /// </param>
        /// <param name="resolution">
        /// Megapixel tier resolved for routing display from the request or model default. When `ratio` is `auto`, this does not specify output pixel dimensions.
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