
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoUpscaleRequestMagnificVideoUpscalerCreative
    {
        /// <summary>
        /// Video to upscale. See [video inputs](/assets/inputs#videos) for URL, upload, and file size limits. Maximum duration is 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUri { get; set; }

        /// <summary>
        /// Target output resolution from 720p to 4k. Defaults to `2k`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolutionJsonConverter))]
        public global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution? Resolution { get; set; }

        /// <summary>
        /// How much AI-generated detail to add during upscaling, from 0 (faithful) to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public int? Creativity { get; set; }

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
        /// Processing style: `vivid` for enhanced color and detail, `natural` for faithful reproduction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavorJsonConverter))]
        public global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor? Flavor { get; set; }

        /// <summary>
        /// Whether to increase the output frame rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fpsBoost")]
        public bool? FpsBoost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"magnific_video_upscaler_creative"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "magnific_video_upscaler_creative";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequestMagnificVideoUpscalerCreative" /> class.
        /// </summary>
        /// <param name="videoUri">
        /// Video to upscale. See [video inputs](/assets/inputs#videos) for URL, upload, and file size limits. Maximum duration is 30 seconds.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="resolution">
        /// Target output resolution from 720p to 4k. Defaults to `2k`.
        /// </param>
        /// <param name="creativity">
        /// How much AI-generated detail to add during upscaling, from 0 (faithful) to 100.
        /// </param>
        /// <param name="sharpen">
        /// Sharpness intensity from 0 (none) to 100.
        /// </param>
        /// <param name="smartGrain">
        /// Grain and texture enhancement from 0 to 100.
        /// </param>
        /// <param name="flavor">
        /// Processing style: `vivid` for enhanced color and detail, `natural` for faithful reproduction.
        /// </param>
        /// <param name="fpsBoost">
        /// Whether to increase the output frame rate.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoUpscaleRequestMagnificVideoUpscalerCreative(
            string videoUri,
            global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeResolution? resolution,
            int? creativity,
            int? sharpen,
            int? smartGrain,
            global::Runway.CreateVideoUpscaleRequestMagnificVideoUpscalerCreativeFlavor? flavor,
            bool? fpsBoost,
            string model = "magnific_video_upscaler_creative")
        {
            this.VideoUri = videoUri;
            this.Resolution = resolution;
            this.Creativity = creativity;
            this.Sharpen = sharpen;
            this.SmartGrain = smartGrain;
            this.Flavor = flavor;
            this.FpsBoost = fpsBoost;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoUpscaleRequestMagnificVideoUpscalerCreative" /> class.
        /// </summary>
        public CreateVideoUpscaleRequestMagnificVideoUpscalerCreative()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateVideoUpscaleRequestMagnificVideoUpscalerCreative"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateVideoUpscaleRequestMagnificVideoUpscalerCreative FromVideoUri(string videoUri)
        {
            return new CreateVideoUpscaleRequestMagnificVideoUpscalerCreative
            {
                VideoUri = videoUri,
            };
        }

    }
}