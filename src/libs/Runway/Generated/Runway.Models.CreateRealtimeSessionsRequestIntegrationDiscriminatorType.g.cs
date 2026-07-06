
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRealtimeSessionsRequestIntegrationDiscriminatorType
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
    public static class CreateRealtimeSessionsRequestIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestIntegrationDiscriminatorType value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestIntegrationDiscriminatorType.Elevenlabs => "elevenlabs",
                CreateRealtimeSessionsRequestIntegrationDiscriminatorType.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => CreateRealtimeSessionsRequestIntegrationDiscriminatorType.Elevenlabs,
                "livekit" => CreateRealtimeSessionsRequestIntegrationDiscriminatorType.Livekit,
                _ => null,
            };
        }
    }
}