
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType
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
    public static class PatchAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom => "custom",
                PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom,
                "runway-live-preset" => PatchAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}