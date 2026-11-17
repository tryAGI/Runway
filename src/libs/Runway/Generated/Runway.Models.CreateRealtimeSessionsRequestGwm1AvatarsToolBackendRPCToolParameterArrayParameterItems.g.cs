
#nullable enable

namespace Runway
{
    /// <summary>
    /// Item schema for array elements.
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItems
    {
        /// <summary>
        /// The type of each element in the array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of each element in the array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItems(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItems" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItems()
        {
        }

    }
}