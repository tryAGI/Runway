
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateVideoResponseVariant1EmptiedByItem
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
    public static class CreateGenerateVideoResponseVariant1EmptiedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseVariant1EmptiedByItem value)
        {
            return value switch
            {
                CreateGenerateVideoResponseVariant1EmptiedByItem.AllowDeny => "allow_deny",
                CreateGenerateVideoResponseVariant1EmptiedByItem.Capability => "capability",
                CreateGenerateVideoResponseVariant1EmptiedByItem.InputSupport => "input_support",
                CreateGenerateVideoResponseVariant1EmptiedByItem.Price => "price",
                CreateGenerateVideoResponseVariant1EmptiedByItem.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseVariant1EmptiedByItem? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateVideoResponseVariant1EmptiedByItem.AllowDeny,
                "capability" => CreateGenerateVideoResponseVariant1EmptiedByItem.Capability,
                "input_support" => CreateGenerateVideoResponseVariant1EmptiedByItem.InputSupport,
                "price" => CreateGenerateVideoResponseVariant1EmptiedByItem.Price,
                "prompt_length" => CreateGenerateVideoResponseVariant1EmptiedByItem.PromptLength,
                _ => null,
            };
        }
    }
}