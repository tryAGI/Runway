
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestVariant1KeyframeVariant1
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
        /// Absolute timestamp in seconds from the start of the input video when this guidance image should apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seconds { get; set; }

        /// <summary>
        /// Optional edit window. When set, the edit applies only to this time range and the keyframe timestamp must fall within it. All keyframes must either set a range or none may.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        public global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1Range? Range { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1KeyframeVariant1" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="seconds">
        /// Absolute timestamp in seconds from the start of the input video when this guidance image should apply.
        /// </param>
        /// <param name="range">
        /// Optional edit window. When set, the edit applies only to this time range and the keyframe timestamp must fall within it. All keyframes must either set a range or none may.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestVariant1KeyframeVariant1(
            string uri,
            double seconds,
            global::Runway.CreateVideoToVideoRequestVariant1KeyframeVariant1Range? range)
        {
            this.Uri = uri;
            this.Seconds = seconds;
            this.Range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestVariant1KeyframeVariant1" /> class.
        /// </summary>
        public CreateVideoToVideoRequestVariant1KeyframeVariant1()
        {
        }

    }
}