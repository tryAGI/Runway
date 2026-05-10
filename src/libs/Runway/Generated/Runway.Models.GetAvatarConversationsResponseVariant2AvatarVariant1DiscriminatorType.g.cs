
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType
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
    public static class GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.Custom => "custom",
                GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.Custom,
                "runway-preset" => GetAvatarConversationsResponseVariant2AvatarVariant1DiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}