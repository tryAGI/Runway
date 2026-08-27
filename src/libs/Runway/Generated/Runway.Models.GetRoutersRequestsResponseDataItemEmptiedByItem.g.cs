
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemEmptiedByItem
    {
        /// <summary>
        ///
        /// </summary>
        AllowDeny,
        /// <summary>
        ///
        /// </summary>
        Capability,
        /// <summary>
        ///
        /// </summary>
        InputSupport,
        /// <summary>
        ///
        /// </summary>
        Price,
        /// <summary>
        ///
        /// </summary>
        PromptLength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutersRequestsResponseDataItemEmptiedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemEmptiedByItem value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemEmptiedByItem.AllowDeny => "allow_deny",
                GetRoutersRequestsResponseDataItemEmptiedByItem.Capability => "capability",
                GetRoutersRequestsResponseDataItemEmptiedByItem.InputSupport => "input_support",
                GetRoutersRequestsResponseDataItemEmptiedByItem.Price => "price",
                GetRoutersRequestsResponseDataItemEmptiedByItem.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemEmptiedByItem? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => GetRoutersRequestsResponseDataItemEmptiedByItem.AllowDeny,
                "capability" => GetRoutersRequestsResponseDataItemEmptiedByItem.Capability,
                "input_support" => GetRoutersRequestsResponseDataItemEmptiedByItem.InputSupport,
                "price" => GetRoutersRequestsResponseDataItemEmptiedByItem.Price,
                "prompt_length" => GetRoutersRequestsResponseDataItemEmptiedByItem.PromptLength,
                _ => null,
            };
        }
    }
}