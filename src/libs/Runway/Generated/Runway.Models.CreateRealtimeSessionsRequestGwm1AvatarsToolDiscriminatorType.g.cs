
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BackendRpc,
        /// <summary>
        ///
        /// </summary>
        ClientEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.BackendRpc => "backend_rpc",
                CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.ClientEvent => "client_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "backend_rpc" => CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.BackendRpc,
                "client_event" => CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType.ClientEvent,
                _ => null,
            };
        }
    }
}