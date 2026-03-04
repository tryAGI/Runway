
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration.
    /// </summary>
    public sealed partial class RequestVariant1ReferenceVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/reference-performance.mp4
        /// </summary>
        /// <example>https://example.com/reference-performance.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.AnyOfJsonConverter<string, string, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.AnyOf<string, string, string> Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant1ReferenceVariant12" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/reference-performance.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestVariant1ReferenceVariant12(
            string type,
            global::Runway.AnyOf<string, string, string> uri)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant1ReferenceVariant12" /> class.
        /// </summary>
        public RequestVariant1ReferenceVariant12()
        {
        }
    }
}