
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageUpscaleRequestMagnificPrecisionUpscalerV2
    {
        /// <summary>
        /// Image to upscale. See [image inputs](/assets/inputs#images) for URL, upload, and file size limits.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUri { get; set; }

        /// <summary>
        /// Multiplies each input dimension to produce output width and height. Defaults to 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaleFactor")]
        public double? ScaleFactor { get; set; }

        /// <summary>
        /// Sharpness intensity from 0 (none) to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpen")]
        public int? Sharpen { get; set; }

        /// <summary>
        /// Grain and texture enhancement from 0 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smartGrain")]
        public int? SmartGrain { get; set; }

        /// <summary>
        /// Fine detail enhancement from 0 to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ultraDetail")]
        public int? UltraDetail { get; set; }

        /// <summary>
        /// Optimization preset: `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2FlavorJsonConverter))]
        public global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor? Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"magnific_precision_upscaler_v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "magnific_precision_upscaler_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageUpscaleRequestMagnificPrecisionUpscalerV2" /> class.
        /// </summary>
        /// <param name="imageUri">
        /// Image to upscale. See [image inputs](/assets/inputs#images) for URL, upload, and file size limits.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="scaleFactor">
        /// Multiplies each input dimension to produce output width and height. Defaults to 2.
        /// </param>
        /// <param name="sharpen">
        /// Sharpness intensity from 0 (none) to 100.
        /// </param>
        /// <param name="smartGrain">
        /// Grain and texture enhancement from 0 to 100.
        /// </param>
        /// <param name="ultraDetail">
        /// Fine detail enhancement from 0 to 100.
        /// </param>
        /// <param name="flavor">
        /// Optimization preset: `sublime` (illustration), `photo` (photographic), or `photo_denoiser` (noisy photos).
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageUpscaleRequestMagnificPrecisionUpscalerV2(
            string imageUri,
            double? scaleFactor,
            int? sharpen,
            int? smartGrain,
            int? ultraDetail,
            global::Runway.CreateImageUpscaleRequestMagnificPrecisionUpscalerV2Flavor? flavor,
            string model = "magnific_precision_upscaler_v2")
        {
            this.ImageUri = imageUri;
            this.ScaleFactor = scaleFactor;
            this.Sharpen = sharpen;
            this.SmartGrain = smartGrain;
            this.UltraDetail = ultraDetail;
            this.Flavor = flavor;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageUpscaleRequestMagnificPrecisionUpscalerV2" /> class.
        /// </summary>
        public CreateImageUpscaleRequestMagnificPrecisionUpscalerV2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateImageUpscaleRequestMagnificPrecisionUpscalerV2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateImageUpscaleRequestMagnificPrecisionUpscalerV2 FromImageUri(string imageUri)
        {
            return new CreateImageUpscaleRequestMagnificPrecisionUpscalerV2
            {
                ImageUri = imageUri,
            };
        }

    }
}