
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output audio container/format.
    /// </summary>
    public enum CreateSoundEffectRequestSeedAudioOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        OggOpus,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSoundEffectRequestSeedAudioOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSoundEffectRequestSeedAudioOutputFormat value)
        {
            return value switch
            {
                CreateSoundEffectRequestSeedAudioOutputFormat.Mp3 => "mp3",
                CreateSoundEffectRequestSeedAudioOutputFormat.OggOpus => "ogg_opus",
                CreateSoundEffectRequestSeedAudioOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSoundEffectRequestSeedAudioOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateSoundEffectRequestSeedAudioOutputFormat.Mp3,
                "ogg_opus" => CreateSoundEffectRequestSeedAudioOutputFormat.OggOpus,
                "wav" => CreateSoundEffectRequestSeedAudioOutputFormat.Wav,
                _ => null,
            };
        }
    }
}