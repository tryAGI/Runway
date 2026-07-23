
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGenerateAudioResponseVariant1EmptiedByItem
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
    public static class CreateGenerateAudioResponseVariant1EmptiedByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateAudioResponseVariant1EmptiedByItem value)
        {
            return value switch
            {
                CreateGenerateAudioResponseVariant1EmptiedByItem.AllowDeny => "allow_deny",
                CreateGenerateAudioResponseVariant1EmptiedByItem.Capability => "capability",
                CreateGenerateAudioResponseVariant1EmptiedByItem.InputSupport => "input_support",
                CreateGenerateAudioResponseVariant1EmptiedByItem.Price => "price",
                CreateGenerateAudioResponseVariant1EmptiedByItem.PromptLength => "prompt_length",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateAudioResponseVariant1EmptiedByItem? ToEnum(string value)
        {
            return value switch
            {
                "allow_deny" => CreateGenerateAudioResponseVariant1EmptiedByItem.AllowDeny,
                "capability" => CreateGenerateAudioResponseVariant1EmptiedByItem.Capability,
                "input_support" => CreateGenerateAudioResponseVariant1EmptiedByItem.InputSupport,
                "price" => CreateGenerateAudioResponseVariant1EmptiedByItem.Price,
                "prompt_length" => CreateGenerateAudioResponseVariant1EmptiedByItem.PromptLength,
                _ => null,
            };
        }
    }
}