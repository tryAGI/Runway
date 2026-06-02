
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestAleph2PromptImageItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, string, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string, string, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition> Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItem" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestAleph2PromptImageItem(
            string uri,
            global::Runway.AnyOf<string, string, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionTimestampPosition, global::Runway.CreateVideoToVideoRequestAleph2PromptImageItemPositionRelativePosition> position)
        {
            this.Uri = uri;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestAleph2PromptImageItem" /> class.
        /// </summary>
        public CreateVideoToVideoRequestAleph2PromptImageItem()
        {
        }

    }
}