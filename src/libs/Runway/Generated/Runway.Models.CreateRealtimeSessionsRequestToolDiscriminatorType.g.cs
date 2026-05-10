
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRealtimeSessionsRequestToolDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestToolDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestToolDiscriminatorType.BackendRpc => "backend_rpc",
                CreateRealtimeSessionsRequestToolDiscriminatorType.ClientEvent => "client_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "backend_rpc" => CreateRealtimeSessionsRequestToolDiscriminatorType.BackendRpc,
                "client_event" => CreateRealtimeSessionsRequestToolDiscriminatorType.ClientEvent,
                _ => null,
            };
        }
    }
}