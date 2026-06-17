
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional image used as the first frame of the output video. See [our docs](/assets/inputs#images) on image inputs.
    /// </summary>
    public sealed partial class CreateRecipesMultiShotVideoRequestVariant2FirstFrame
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestVariant2FirstFrame" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecipesMultiShotVideoRequestVariant2FirstFrame(
            string uri)
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecipesMultiShotVideoRequestVariant2FirstFrame" /> class.
        /// </summary>
        public CreateRecipesMultiShotVideoRequestVariant2FirstFrame()
        {
        }

    }
}