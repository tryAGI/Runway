
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of each element in the array.
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType
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
    public static class CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Boolean => "boolean",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Integer => "integer",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Number => "number",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Boolean,
                "integer" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Integer,
                "number" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.Number,
                "string" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterArrayParameterItemsType.String,
                _ => null,
            };
        }
    }
}