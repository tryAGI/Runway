
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
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
        Object,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Array => "array",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Boolean => "boolean",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Integer => "integer",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Number => "number",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Object => "object",
                CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Array,
                "boolean" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Boolean,
                "integer" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Integer,
                "number" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Number,
                "object" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.Object,
                "string" => CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCToolParameterDiscriminatorType.String,
                _ => null,
            };
        }
    }
}