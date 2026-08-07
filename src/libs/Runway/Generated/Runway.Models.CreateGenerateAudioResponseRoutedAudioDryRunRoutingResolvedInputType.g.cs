
#nullable enable

namespace Runway
{
    /// <summary>
    /// The prompt mode the router routed for.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType
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
    public static class CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType.Audio => "audio",
                CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType.Audio,
                "speech" => CreateGenerateAudioResponseRoutedAudioDryRunRoutingResolvedInputType.Speech,
                _ => null,
            };
        }
    }
}