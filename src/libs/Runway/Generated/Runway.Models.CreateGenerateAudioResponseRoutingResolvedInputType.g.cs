
#nullable enable

namespace Runway
{
    /// <summary>
    /// The prompt mode the router routed for.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutingResolvedInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateAudioResponseRoutingResolvedInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutingResolvedInputType value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutingResolvedInputType.Audio => "audio",
                CreateGenerateAudioResponseRoutingResolvedInputType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutingResolvedInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateGenerateAudioResponseRoutingResolvedInputType.Audio,
                "speech" => CreateGenerateAudioResponseRoutingResolvedInputType.Speech,
                _ => null,
            };
        }
    }
}