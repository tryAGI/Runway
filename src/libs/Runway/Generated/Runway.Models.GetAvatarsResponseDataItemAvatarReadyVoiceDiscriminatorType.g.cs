
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType
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
    public static class GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseDataItemAvatarReadyVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}