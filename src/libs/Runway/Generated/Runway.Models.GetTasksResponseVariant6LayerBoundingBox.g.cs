
#nullable enable

namespace Runway
{
    /// <summary>
    /// The layer bounds in absolute and normalized coordinates, when returned by the model provider.
    /// </summary>
    public sealed partial class GetTasksResponseVariant6LayerBoundingBox
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("absolute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Absolute { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Normalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6LayerBoundingBox" /> class.
        /// </summary>
        /// <param name="absolute"></param>
        /// <param name="normalized"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant6LayerBoundingBox(
            global::System.Collections.Generic.IList<double> absolute,
            global::System.Collections.Generic.IList<double> normalized)
        {
            this.Absolute = absolute ?? throw new global::System.ArgumentNullException(nameof(absolute));
            this.Normalized = normalized ?? throw new global::System.ArgumentNullException(nameof(normalized));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant6LayerBoundingBox" /> class.
        /// </summary>
        public GetTasksResponseVariant6LayerBoundingBox()
        {
        }

    }
}