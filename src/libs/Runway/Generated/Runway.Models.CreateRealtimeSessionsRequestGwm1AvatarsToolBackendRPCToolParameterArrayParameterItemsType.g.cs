
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of each element in the array.
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Boolean => "boolean",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Integer => "integer",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Number => "number",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Boolean,
                "integer" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Integer,
                "number" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.Number,
                "string" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterArrayParameterItemsType.String,
                _ => null,
            };
        }
    }
}