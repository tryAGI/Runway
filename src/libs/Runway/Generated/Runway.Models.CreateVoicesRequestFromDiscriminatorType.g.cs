
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVoicesRequestFromDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoicesRequestFromDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoicesRequestFromDiscriminatorType value)
        {
            return value switch
            {
                CreateVoicesRequestFromDiscriminatorType.Audio => "audio",
                CreateVoicesRequestFromDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoicesRequestFromDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateVoicesRequestFromDiscriminatorType.Audio,
                "text" => CreateVoicesRequestFromDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}