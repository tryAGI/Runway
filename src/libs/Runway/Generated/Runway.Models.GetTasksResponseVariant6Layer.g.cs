
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTasksResponseVariant6Layer
    {
        /// <summary>
        /// An ephemeral URL for this layer, matching output at the same index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// The layer filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The layer stacking order returned by the model provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zIndex")]
        public double? ZIndex { get; set; }

        /// <summary>
        /// The layer bounds in absolute and normalized coordinates, when returned by the model provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boundingBox")]
        public global::Runway.GetTasksResponseVariant6LayerBoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6Layer" /> class.
        /// </summary>
        /// <param name="uri">
        /// An ephemeral URL for this layer, matching output at the same index.
        /// </param>
        /// <param name="name">
        /// The layer filename.
        /// </param>
        /// <param name="zIndex">
        /// The layer stacking order returned by the model provider.
        /// </param>
        /// <param name="boundingBox">
        /// The layer bounds in absolute and normalized coordinates, when returned by the model provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant6Layer(
            string uri,
            string? name,
            double? zIndex,
            global::Runway.GetTasksResponseVariant6LayerBoundingBox? boundingBox)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Name = name;
            this.ZIndex = zIndex;
            this.BoundingBox = boundingBox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6Layer" /> class.
        /// </summary>
        public GetTasksResponseVariant6Layer()
        {
        }

    }
}