
#nullable enable

namespace Runway
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject
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
    public static class CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject.Human => "human",
                CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject? ToEnum(string value)
        {
            return value switch
            {
                "human" => CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject.Human,
                "object" => CreateTextToImageRequestGeminiImage31FlashLiteReferenceImageSubject.Object,
                _ => null,
            };
        }
    }
}