
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Array => "array",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Boolean => "boolean",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Integer => "integer",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Number => "number",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Object => "object",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Array,
                "boolean" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Boolean,
                "integer" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Integer,
                "number" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Number,
                "object" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.Object,
                "string" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterDiscriminatorType.String,
                _ => null,
            };
        }
    }
}