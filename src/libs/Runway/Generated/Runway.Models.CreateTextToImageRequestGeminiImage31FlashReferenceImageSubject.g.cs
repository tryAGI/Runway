
#nullable enable

namespace Runway
{
    /// <summary>
    /// Whether this is a reference of a human subject (for character consistency) or an object that appears in the output.<br/>
    /// Default Value: object
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject
    {
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestGeminiImage31FlashReferenceImageSubjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject.Human => "human",
                CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject? ToEnum(string value)
        {
            return value switch
            {
                "human" => CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject.Human,
                "object" => CreateTextToImageRequestGeminiImage31FlashReferenceImageSubject.Object,
                _ => null,
            };
        }
    }
}