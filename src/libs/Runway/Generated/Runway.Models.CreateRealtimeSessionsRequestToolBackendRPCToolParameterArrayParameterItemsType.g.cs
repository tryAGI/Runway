
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of each element in the array.
    /// </summary>
    public enum CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType
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
    public static class CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Boolean => "boolean",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Integer => "integer",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Number => "number",
                CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Boolean,
                "integer" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Integer,
                "number" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.Number,
                "string" => CreateRealtimeSessionsRequestToolBackendRPCToolParameterArrayParameterItemsType.String,
                _ => null,
            };
        }
    }
}