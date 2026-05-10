
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarVideosRequestSpeechDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarVideosRequestSpeechDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarVideosRequestSpeechDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarVideosRequestSpeechDiscriminatorType.Audio => "audio",
                CreateAvatarVideosRequestSpeechDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarVideosRequestSpeechDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateAvatarVideosRequestSpeechDiscriminatorType.Audio,
                "text" => CreateAvatarVideosRequestSpeechDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}