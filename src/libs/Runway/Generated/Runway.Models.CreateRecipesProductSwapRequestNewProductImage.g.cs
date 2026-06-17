
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecipesProductSwapRequestNewProductImage
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Optional view label for this reference (front, side, or back). Omit when supplying a single reference sheet or when view labels are unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter))]
        public global::Runway.CreateRecipesProductSwapRequestNewProductImageView? View { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequestNewProductImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="view">
        /// Optional view label for this reference (front, side, or back). Omit when supplying a single reference sheet or when view labels are unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesProductSwapRequestNewProductImage(
            string uri,
            global::Runway.CreateRecipesProductSwapRequestNewProductImageView? view)
        {
            this.Uri = uri;
            this.View = view;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesProductSwapRequestNewProductImage" /> class.
        /// </summary>
        public CreateRecipesProductSwapRequestNewProductImage()
        {
        }

    }
}