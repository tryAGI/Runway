
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateImageResponseVariant1EmptiedByItem
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
    public static class CreateGenerateImageResponseVariant1EmptiedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateImageResponseVariant1EmptiedByItem value)
        {
            return value switch
            {
                CreateGenerateImageResponseVariant1EmptiedByItem.AllowDeny => "allow_deny",
                CreateGenerateImageResponseVariant1EmptiedByItem.Capability => "capability",
                CreateGenerateImageResponseVariant1EmptiedByItem.InputSupport => "input_support",
                CreateGenerateImageResponseVariant1EmptiedByItem.Price => "price",
                CreateGenerateImageResponseVariant1EmptiedByItem.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateImageResponseVariant1EmptiedByItem? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateImageResponseVariant1EmptiedByItem.AllowDeny,
                "capability" => CreateGenerateImageResponseVariant1EmptiedByItem.Capability,
                "input_support" => CreateGenerateImageResponseVariant1EmptiedByItem.InputSupport,
                "price" => CreateGenerateImageResponseVariant1EmptiedByItem.Price,
                "prompt_length" => CreateGenerateImageResponseVariant1EmptiedByItem.PromptLength,
                _ => null,
            };
        }
    }
}