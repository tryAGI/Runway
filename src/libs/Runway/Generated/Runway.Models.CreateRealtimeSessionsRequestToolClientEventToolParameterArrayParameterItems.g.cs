
#nullable enable

namespace Runway
{
    /// <summary>
    /// Item schema for array elements.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems
    {
        /// <summary>
        /// The type of each element in the array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of each element in the array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems(
            global::Runway.CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItems()
        {
        }
    }
}