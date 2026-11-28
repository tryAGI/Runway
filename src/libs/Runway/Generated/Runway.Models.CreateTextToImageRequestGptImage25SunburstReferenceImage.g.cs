
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTextToImageRequestGptImage25SunburstReferenceImage
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
        /// An optional label for the reference image. Tags are not sent to the model and cannot be used to reference images in prompt text. Instead, refer to images by their order in this array (for example, "the first image" or "the second image"). Must be 3-16 characters, start with a letter, and use only letters, digits, and underscores (no hyphens or other punctuation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage25SunburstReferenceImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="tag">
        /// An optional label for the reference image. Tags are not sent to the model and cannot be used to reference images in prompt text. Instead, refer to images by their order in this array (for example, "the first image" or "the second image"). Must be 3-16 characters, start with a letter, and use only letters, digits, and underscores (no hyphens or other punctuation).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGptImage25SunburstReferenceImage(
            string uri,
            string? tag)
        {
            this.Uri = uri;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGptImage25SunburstReferenceImage" /> class.
        /// </summary>
        public CreateTextToImageRequestGptImage25SunburstReferenceImage()
        {
        }

    }
}