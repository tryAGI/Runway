
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAvatarVideosRequestAvatarDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        RunwayPreset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarVideosRequestAvatarDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarVideosRequestAvatarDiscriminatorType value)
        {
            return value switch
            {
                CreateAvatarVideosRequestAvatarDiscriminatorType.Custom => "custom",
                CreateAvatarVideosRequestAvatarDiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarVideosRequestAvatarDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CreateAvatarVideosRequestAvatarDiscriminatorType.Custom,
                "runway-preset" => CreateAvatarVideosRequestAvatarDiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}