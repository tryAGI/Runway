
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType
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
    public static class CreateAvatarsResponseAvatarFailedVoiceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom => "custom",
                CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset => "runway-live-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType.Custom,
                "runway-live-preset" => CreateAvatarsResponseAvatarFailedVoiceDiscriminatorType.RunwayLivePreset,
                _ => null,
            };
        }
    }
}