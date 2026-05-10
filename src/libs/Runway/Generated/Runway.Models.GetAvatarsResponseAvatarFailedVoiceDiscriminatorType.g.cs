
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarsResponseAvatarFailedVoiceDiscriminatorType
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
    public static class GetAvatarsResponseAvatarFailedVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarFailedVoiceDiscriminatorType value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom => "custom",
                GetAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarFailedVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom,
                "runway-live-preset" => GetAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}