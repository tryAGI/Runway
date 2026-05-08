
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of each element in the array.
    /// </summary>
    public enum CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType
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
    public static class CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Boolean => "boolean",
                CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Integer => "integer",
                CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Number => "number",
                CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Boolean,
                "integer" => CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Integer,
                "number" => CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.Number,
                "string" => CreateRealtimeSessionsRequestToolClientEventToolParameterArrayParameterItemsType.String,
                _ => null,
            };
        }
    }
}