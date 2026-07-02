
#nullable enable

namespace Runway
{
    /// <summary>
    /// Output audio container/format.
    /// </summary>
    public enum CreateTextToSpeechRequestSeedAudioOutputFormat
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
    public static class CreateTextToSpeechRequestSeedAudioOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestSeedAudioOutputFormat value)
        {
            return value switch
            {
                CreateTextToSpeechRequestSeedAudioOutputFormat.Mp3 => "mp3",
                CreateTextToSpeechRequestSeedAudioOutputFormat.OggOpus => "ogg_opus",
                CreateTextToSpeechRequestSeedAudioOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestSeedAudioOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateTextToSpeechRequestSeedAudioOutputFormat.Mp3,
                "ogg_opus" => CreateTextToSpeechRequestSeedAudioOutputFormat.OggOpus,
                "wav" => CreateTextToSpeechRequestSeedAudioOutputFormat.Wav,
                _ => null,
            };
        }
    }
}