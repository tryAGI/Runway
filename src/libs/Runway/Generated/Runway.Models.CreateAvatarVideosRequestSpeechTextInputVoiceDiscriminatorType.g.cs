
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Custom => "custom",
                CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Custom,
                "preset" => CreateAvatarVideosRequestSpeechTextInputVoiceDiscriminatorType.Preset,
                _ => null,
            };
        }
    }
}