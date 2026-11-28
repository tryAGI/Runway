
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateImageToVideoRequestKling4FlashPromptImageVariant2Item
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
        ///
        /// </summary>
        /// <default>"first"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public string Position { get; set; } = "first";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling4FlashPromptImageVariant2Item" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestKling4FlashPromptImageVariant2Item(
            string uri,
            string position = "first")
        {
            this.Uri = uri;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestKling4FlashPromptImageVariant2Item" /> class.
        /// </summary>
        public CreateImageToVideoRequestKling4FlashPromptImageVariant2Item()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateImageToVideoRequestKling4FlashPromptImageVariant2Item"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateImageToVideoRequestKling4FlashPromptImageVariant2Item FromUri(string uri)
        {
            return new CreateImageToVideoRequestKling4FlashPromptImageVariant2Item
            {
                Uri = uri,
            };
        }

    }
}