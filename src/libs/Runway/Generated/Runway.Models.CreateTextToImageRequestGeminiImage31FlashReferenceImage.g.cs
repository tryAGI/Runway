
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGeminiImage31FlashReferenceImage
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
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Whether this is a reference of a human subject (for character consistency) or an object that appears in the output.<br/>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectJsonConverter))]
        public global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject? Subject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage31FlashReferenceImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="tag">
        /// A tag to identify the reference image. This is used to reference the image in prompt text.
        /// </param>
        /// <param name="subject">
        /// Whether this is a reference of a human subject (for character consistency) or an object that appears in the output.<br/>
        /// Default Value: object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGeminiImage31FlashReferenceImage(
            string uri,
            string? tag,
            global::Runway.CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject? subject)
        {
            this.Uri = uri;
            this.Tag = tag;
            this.Subject = subject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGeminiImage31FlashReferenceImage" /> class.
        /// </summary>
        public CreateTextToImageRequestGeminiImage31FlashReferenceImage()
        {
        }

    }
}