
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTextToMusicRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        ElevenMusicV25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToMusicRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToMusicRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToMusicRequestDiscriminatorModel.ElevenMusicV25 => "eleven_music_v2_5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToMusicRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_music_v2_5" => CreateTextToMusicRequestDiscriminatorModel.ElevenMusicV25,
                _ => null,
            };
        }
    }
}