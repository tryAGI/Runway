
#nullable enable

namespace Runway
{
    /// <summary>
    /// The format of the generated audio.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateSoundEffectRequestMireloSfx20Format
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
    public static class CreateSoundEffectRequestMireloSfx20FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSoundEffectRequestMireloSfx20Format value)
        {
            return value switch
            {
                CreateSoundEffectRequestMireloSfx20Format.Flac => "flac",
                CreateSoundEffectRequestMireloSfx20Format.Mp3 => "mp3",
                CreateSoundEffectRequestMireloSfx20Format.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSoundEffectRequestMireloSfx20Format? ToEnum(string value)
        {
            return value switch
            {
                "flac" => CreateSoundEffectRequestMireloSfx20Format.Flac,
                "mp3" => CreateSoundEffectRequestMireloSfx20Format.Mp3,
                "wav" => CreateSoundEffectRequestMireloSfx20Format.Wav,
                _ => null,
            };
        }
    }
}