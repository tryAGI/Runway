
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesProductUgcRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductUgcRequestVersion Version { get; set; }

        /// <summary>
        /// Image of the character who will appear on camera in the UGC video. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characterImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductUgcRequestCharacterImage CharacterImage { get; set; }

        /// <summary>
        /// Image of the product being promoted. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductUgcRequestProductImage ProductImage { get; set; }

        /// <summary>
        /// Product details and creative brief — what the product is, key benefits, and any specifics the script should reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productInfo")]
        public string? ProductInfo { get; set; }

        /// <summary>
        /// Optional creative direction for the UGC video — tone, voice register, specific message, or an entire dialog script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userConcept")]
        public string? UserConcept { get; set; }

        /// <summary>
        /// Duration of the output video in seconds (4–15). Defaults to 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The resolution of the output video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter))]
        public global::Runway.CreateRecipesProductUgcRequestRatio? Ratio { get; set; }

        /// <summary>
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductUgcRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="characterImage">
        /// Image of the character who will appear on camera in the UGC video. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </param>
        /// <param name="productImage">
        /// Image of the product being promoted. Aspect ratio (width / height) must be between 0.4 and 4. See [our docs](/assets/inputs#images) for image input requirements.
        /// </param>
        /// <param name="productInfo">
        /// Product details and creative brief — what the product is, key benefits, and any specifics the script should reference.
        /// </param>
        /// <param name="userConcept">
        /// Optional creative direction for the UGC video — tone, voice register, specific message, or an entire dialog script.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 15 seconds.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output video.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductUgcRequest(
            global::Runway.CreateRecipesProductUgcRequestVersion version,
            global::Runway.CreateRecipesProductUgcRequestCharacterImage characterImage,
            global::Runway.CreateRecipesProductUgcRequestProductImage productImage,
            string? productInfo,
            string? userConcept,
            int? duration,
            global::Runway.CreateRecipesProductUgcRequestRatio? ratio,
            bool? audio)
        {
            this.Version = version;
            this.CharacterImage = characterImage ?? throw new global::System.ArgumentNullException(nameof(characterImage));
            this.ProductImage = productImage ?? throw new global::System.ArgumentNullException(nameof(productImage));
            this.ProductInfo = productInfo;
            this.UserConcept = userConcept;
            this.Duration = duration;
            this.Ratio = ratio;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductUgcRequest" /> class.
        /// </summary>
        public CreateRecipesProductUgcRequest()
        {
        }

    }
}