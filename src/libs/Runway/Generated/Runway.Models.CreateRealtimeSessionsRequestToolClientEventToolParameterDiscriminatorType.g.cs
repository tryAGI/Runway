
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Array => "array",
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Boolean => "boolean",
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Integer => "integer",
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Number => "number",
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Object => "object",
                CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "array" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Array,
                "boolean" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Boolean,
                "integer" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Integer,
                "number" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Number,
                "object" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.Object,
                "string" => CreateRealtimeSessionsRequestToolClientEventToolParameterDiscriminatorType.String,
                _ => null,
            };
        }
    }
}