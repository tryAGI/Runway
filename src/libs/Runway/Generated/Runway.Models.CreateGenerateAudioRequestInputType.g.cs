
#nullable enable

namespace Runway
{
    /// <summary>
    /// How promptText is interpreted: `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects; `music` treats it as a description of a song or instrumental track.
    /// </summary>
    public enum CreateGenerateAudioRequestInputType
    {
        /// <summary>
        /// `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects; `music` treats it as a description of a song or instrumental track.
        /// </summary>
        Audio,
        /// <summary>
        /// `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects; `music` treats it as a description of a song or instrumental track.
        /// </summary>
        Music,
        /// <summary>
        /// `speech` speaks it verbatim as a script; `audio` treats it as a description of the desired audio, which may combine speech, music, ambience, and sound effects; `music` treats it as a description of a song or instrumental track.
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateAudioRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioRequestInputType value)
        {
            return value switch
            {
                CreateGenerateAudioRequestInputType.Audio => "audio",
                CreateGenerateAudioRequestInputType.Music => "music",
                CreateGenerateAudioRequestInputType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateGenerateAudioRequestInputType.Audio,
                "music" => CreateGenerateAudioRequestInputType.Music,
                "speech" => CreateGenerateAudioRequestInputType.Speech,
                _ => null,
            };
        }
    }
}