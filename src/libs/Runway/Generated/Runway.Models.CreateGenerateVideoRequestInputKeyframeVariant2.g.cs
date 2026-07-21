
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerateVideoRequestInputKeyframeVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double At { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2Range? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputKeyframeVariant2" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="at"></param>
        /// <param name="range"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerateVideoRequestInputKeyframeVariant2(
            string uri,
            double at,
            global::Runway.CreateGenerateVideoRequestInputKeyframeVariant2Range? range)
        {
            this.Uri = uri;
            this.At = at;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerateVideoRequestInputKeyframeVariant2" /> class.
        /// </summary>
        public CreateGenerateVideoRequestInputKeyframeVariant2()
        {
        }

    }
}