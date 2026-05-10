
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType
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
    public static class PatchAvatarsResponseAvatarFailedVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom => "custom",
                PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom,
                "runway-live-preset" => PatchAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}