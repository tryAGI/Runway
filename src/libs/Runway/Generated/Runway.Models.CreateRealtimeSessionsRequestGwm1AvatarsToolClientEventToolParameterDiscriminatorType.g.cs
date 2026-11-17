
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Array => "array",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Boolean => "boolean",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Integer => "integer",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Number => "number",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Object => "object",
                CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Array,
                "boolean" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Boolean,
                "integer" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Integer,
                "number" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Number,
                "object" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.Object,
                "string" => CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventToolParameterDiscriminatorType.String,
                _ => null,
            };
        }
    }
}