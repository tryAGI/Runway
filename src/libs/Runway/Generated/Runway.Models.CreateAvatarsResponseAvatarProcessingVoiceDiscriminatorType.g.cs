
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        RunwayLivePreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom => "custom",
                CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom,
                "runway-live-preset" => CreateAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}