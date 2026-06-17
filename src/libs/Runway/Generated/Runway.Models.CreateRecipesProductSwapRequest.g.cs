
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesProductSwapRequest
    {
        /// <summary>
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductSwapRequestVersion Version { get; set; }

        /// <summary>
        /// Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVideo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductSwapRequestReferenceVideo ReferenceVideo { get; set; }

        /// <summary>
        /// Image of the original product being swapped out. See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalProductImage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRecipesProductSwapRequestOriginalProductImage OriginalProductImage { get; set; }

        /// <summary>
        /// Reference images of the new product (1–10). Supply multiple angles when the reference video shows the product from different views — optionally label each with `view` ("front", "side", or "back"). A single pre-composed reference sheet is also supported (omit `view`). See [our docs](/assets/inputs#images) on image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProductImages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage> NewProductImages { get; set; }

        /// <summary>
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Output video resolution. Defaults to 720p.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter))]
        public global::Runway.CreateRecipesProductSwapRequestResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// Workflow version. Use a dated version (e.g. "2026-06") to pin behavior, or "unsafe-latest" to track the newest stable version (may break without notice).
        /// </param>
        /// <param name="referenceVideo">
        /// Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.
        /// </param>
        /// <param name="originalProductImage">
        /// Image of the original product being swapped out. See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="newProductImages">
        /// Reference images of the new product (1–10). Supply multiple angles when the reference video shows the product from different views — optionally label each with `view` ("front", "side", or "back"). A single pre-composed reference sheet is also supported (omit `view`). See [our docs](/assets/inputs#images) on image inputs.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video in seconds (4–15). Defaults to 10 seconds.
        /// </param>
        /// <param name="resolution">
        /// Output video resolution. Defaults to 720p.
        /// </param>
        /// <param name="audio">
        /// Whether to generate audio for the video.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductSwapRequest(
            global::Runway.CreateRecipesProductSwapRequestVersion version,
            global::Runway.CreateRecipesProductSwapRequestReferenceVideo referenceVideo,
            global::Runway.CreateRecipesProductSwapRequestOriginalProductImage originalProductImage,
            global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage> newProductImages,
            int? duration,
            global::Runway.CreateRecipesProductSwapRequestResolution? resolution,
            bool? audio)
        {
            this.Version = version;
            this.ReferenceVideo = referenceVideo ?? throw new global::System.ArgumentNullException(nameof(referenceVideo));
            this.OriginalProductImage = originalProductImage ?? throw new global::System.ArgumentNullException(nameof(originalProductImage));
            this.NewProductImages = newProductImages ?? throw new global::System.ArgumentNullException(nameof(newProductImages));
            this.Duration = duration;
            this.Resolution = resolution;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequest" /> class.
        /// </summary>
        public CreateRecipesProductSwapRequest()
        {
        }

    }
}