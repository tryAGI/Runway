
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType
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
    public static class CreateAvatarsResponseAvatarReadyVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom => "custom",
                CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType.Custom,
                "runway-live-preset" => CreateAvatarsResponseAvatarReadyVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}