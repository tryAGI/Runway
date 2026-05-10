
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType
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
    public static class GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType value)
        {
            return value switch
            {
                GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.Custom => "custom",
                GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.RunwayPreset => "runway-preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.Custom,
                "runway-preset" => GetAvatarConversationsResponseDataItemAvatarVariant1DiscriminatorType.RunwayPreset,
                _ => null,
            };
        }
    }
}