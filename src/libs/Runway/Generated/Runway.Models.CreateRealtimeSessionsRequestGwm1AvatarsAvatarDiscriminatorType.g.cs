
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.Custom => "custom",
                CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.Custom,
                "runway-preset" => CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}