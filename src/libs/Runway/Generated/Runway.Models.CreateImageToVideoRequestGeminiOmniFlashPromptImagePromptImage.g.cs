
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage
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
        /// The position of the image in the output video. "first" will use the image as the first frame of the video.
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
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="position">
        /// The position of the image in the output video. "first" will use the image as the first frame of the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage(
            string uri,
            string position = "first")
        {
            this.Uri = uri;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage" /> class.
        /// </summary>
        public CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage FromUri(string uri)
        {
            return new CreateImageToVideoRequestGeminiOmniFlashPromptImagePromptImage
            {
                Uri = uri,
            };
        }

    }
}