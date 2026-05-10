
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType
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
    public static class GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseDataItemAvatarFailedVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}