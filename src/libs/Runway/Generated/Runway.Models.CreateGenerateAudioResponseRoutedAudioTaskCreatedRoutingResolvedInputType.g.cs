
#nullable enable

namespace Runway
{
    /// <summary>
    /// The prompt mode the router routed for.
    /// </summary>
    public enum CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType
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
    public static class CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType value)
        {
            return value switch
            {
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType.Audio => "audio",
                CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType.Audio,
                "speech" => CreateGenerateAudioResponseRoutedAudioTaskCreatedRoutingResolvedInputType.Speech,
                _ => null,
            };
        }
    }
}