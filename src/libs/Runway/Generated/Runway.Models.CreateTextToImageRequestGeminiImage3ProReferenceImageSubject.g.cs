
#nullable enable

namespace Runway
{
    /// <summary>
    /// Whether this is a reference of a human subject (for character consistency) or an object that appears in the output.<br/>
    /// Default Value: object
    /// </summary>
    public enum CreateTextToImageRequestGeminiImage3ProReferenceImageSubject
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
    public static class CreateTextToImageRequestGeminiImage3ProReferenceImageSubjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestGeminiImage3ProReferenceImageSubject value)
        {
            return value switch
            {
                CreateTextToImageRequestGeminiImage3ProReferenceImageSubject.Human => "human",
                CreateTextToImageRequestGeminiImage3ProReferenceImageSubject.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestGeminiImage3ProReferenceImageSubject? ToEnum(string value)
        {
            return value switch
            {
                "human" => CreateTextToImageRequestGeminiImage3ProReferenceImageSubject.Human,
                "object" => CreateTextToImageRequestGeminiImage3ProReferenceImageSubject.Object,
                _ => null,
            };
        }
    }
}