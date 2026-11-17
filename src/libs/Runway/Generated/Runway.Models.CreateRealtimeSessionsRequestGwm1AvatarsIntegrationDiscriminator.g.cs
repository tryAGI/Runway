
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runway.JsonConverters.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorTypeJsonConverter))]
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator" /> class.
        /// </summary>
        public CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminator()
        {
        }

    }
}