
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchAvatarsRequestVoiceDiscriminatorType
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
    public static class PatchAvatarsRequestVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAvatarsRequestVoiceDiscriminatorType value)
        {
            return value switch
            {
                PatchAvatarsRequestVoiceDiscriminatorType.Custom => "custom",
                PatchAvatarsRequestVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAvatarsRequestVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAvatarsRequestVoiceDiscriminatorType.Custom,
                "runway-live-preset" => PatchAvatarsRequestVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}