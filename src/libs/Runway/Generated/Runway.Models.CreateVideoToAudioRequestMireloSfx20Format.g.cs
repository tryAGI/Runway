
#nullable enable

namespace Runway
{
    /// <summary>
    /// The format of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateVideoToAudioRequestMireloSfx20Format
    {
        /// <summary>
        ///
        /// </summary>
        Flac,
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToAudioRequestMireloSfx20FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToAudioRequestMireloSfx20Format value)
        {
            return value switch
            {
                CreateVideoToAudioRequestMireloSfx20Format.Flac => "flac",
                CreateVideoToAudioRequestMireloSfx20Format.Mp3 => "mp3",
                CreateVideoToAudioRequestMireloSfx20Format.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToAudioRequestMireloSfx20Format? ToEnum(string value)
        {
            return value switch
            {
                "flac" => CreateVideoToAudioRequestMireloSfx20Format.Flac,
                "mp3" => CreateVideoToAudioRequestMireloSfx20Format.Mp3,
                "wav" => CreateVideoToAudioRequestMireloSfx20Format.Wav,
                _ => null,
            };
        }
    }
}