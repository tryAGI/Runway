
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType
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
    public static class GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseDataItemAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}