
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType
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
    public static class PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType value)
        {
            return value switch
            {
                PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom => "custom",
                PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.Custom,
                "runway-live-preset" => PatchAvatarsResponseAvatarProcessingVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}