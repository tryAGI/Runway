
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarsRequestVoiceDiscriminatorType
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
    public static class CreateAvatarsRequestVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsRequestVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarsRequestVoiceDiscriminatorType.Custom => "custom",
                CreateAvatarsRequestVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsRequestVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarsRequestVoiceDiscriminatorType.Custom,
                "runway-live-preset" => CreateAvatarsRequestVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}