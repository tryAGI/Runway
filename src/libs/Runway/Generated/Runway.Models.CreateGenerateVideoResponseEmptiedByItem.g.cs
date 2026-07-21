
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateVideoResponseEmptiedByItem
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
    public static class CreateGenerateVideoResponseEmptiedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoResponseEmptiedByItem value)
        {
            return value switch
            {
                CreateGenerateVideoResponseEmptiedByItem.AllowDeny => "allow_deny",
                CreateGenerateVideoResponseEmptiedByItem.Capability => "capability",
                CreateGenerateVideoResponseEmptiedByItem.InputSupport => "input_support",
                CreateGenerateVideoResponseEmptiedByItem.Price => "price",
                CreateGenerateVideoResponseEmptiedByItem.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoResponseEmptiedByItem? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateVideoResponseEmptiedByItem.AllowDeny,
                "capability" => CreateGenerateVideoResponseEmptiedByItem.Capability,
                "input_support" => CreateGenerateVideoResponseEmptiedByItem.InputSupport,
                "price" => CreateGenerateVideoResponseEmptiedByItem.Price,
                "prompt_length" => CreateGenerateVideoResponseEmptiedByItem.PromptLength,
                _ => null,
            };
        }
    }
}