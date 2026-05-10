
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType
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
    public static class GetAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}