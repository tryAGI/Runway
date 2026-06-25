
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesProductAdRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-07") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductAdRequestVersion Version { get; set; }

        /// <summary>
        /// Product images (1–10). Multiple angles of the same product. All images inform product analysis and reference generation; only the first image is used as the primary product reference in the storyboard grid. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage> ProductImages { get; set; }

        /// <summary>
        /// Optional style reference images (0–4). Defines the visual treatment (lighting, palette, mood). Treated as a moodboard when multiple are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleImages")]
        public global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>? StyleImages { get; set; }

        /// <summary>
        /// Optional product description and specifications to inform creative direction and which product elements to highlight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productInfo")]
        public string? ProductInfo { get; set; }

        /// <summary>
        /// Optional creative direction describing brand voice, product framing, scene specifics, lighting, camera motion, and narrative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userConcept")]
        public string? UserConcept { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter))]
        public global::Runway.CreateRecipesProductAdRequestRatio? Ratio { get; set; }

        /// <summary>
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductAdRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-07") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="productImages">
        /// Product images (1–10). Multiple angles of the same product. All images inform product analysis and reference generation; only the first image is used as the primary product reference in the storyboard grid. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="styleImages">
        /// Optional style reference images (0–4). Defines the visual treatment (lighting, palette, mood). Treated as a moodboard when multiple are provided.
        /// </param>
        /// <param name="productInfo">
        /// Optional product description and specifications to inform creative direction and which product elements to highlight.
        /// </param>
        /// <param name="userConcept">
        /// Optional creative direction describing brand voice, product framing, scene specifics, lighting, camera motion, and narrative.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductAdRequest(
            global::Runway.CreateRecipesProductAdRequestVersion version,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage> productImages,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>? styleImages,
            string? productInfo,
            string? userConcept,
            global::Runway.CreateRecipesProductAdRequestRatio? ratio,
            int? duration,
            bool? audio)
        {
            this.Version = version;
            this.ProductImages = productImages ?? throw new global::System.ArgumentNullException(nameof(productImages));
            this.StyleImages = styleImages;
            this.ProductInfo = productInfo;
            this.UserConcept = userConcept;
            this.Ratio = ratio;
            this.Duration = duration;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductAdRequest" /> class.
        /// </summary>
        public CreateRecipesProductAdRequest()
        {
        }

    }
}