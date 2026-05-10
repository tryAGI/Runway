
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRealtimeSessionsRequestAvatarDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestAvatarDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestAvatarDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestAvatarDiscriminatorType.Custom => "custom",
                CreateRealtimeSessionsRequestAvatarDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestAvatarDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateRealtimeSessionsRequestAvatarDiscriminatorType.Custom,
                "runway-preset" => CreateRealtimeSessionsRequestAvatarDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}