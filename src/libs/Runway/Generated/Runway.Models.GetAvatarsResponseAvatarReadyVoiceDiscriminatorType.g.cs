
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseAvatarReadyVoiceDiscriminatorType
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
    public static class GetAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarReadyVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarReadyVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}