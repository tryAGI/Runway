
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Elevenlabs,
        /// <summary>
        ///
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Elevenlabs => "elevenlabs",
                CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Elevenlabs,
                "livekit" => CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType.Livekit,
                _ => null,
            };
        }
    }
}