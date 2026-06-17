
#nullable enable

namespace Runway
{
    /// <summary>
    /// Reference video containing the product to swap. Duration must be between 1.8 and 15 seconds. See [our docs](/assets/inputs#videos) on video inputs.
    /// </summary>
    public sealed partial class CreateRecipesProductSwapRequestReferenceVideo
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequestReferenceVideo" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductSwapRequestReferenceVideo(
            string uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequestReferenceVideo" /> class.
        /// </summary>
        public CreateRecipesProductSwapRequestReferenceVideo()
        {
        }

    }
}