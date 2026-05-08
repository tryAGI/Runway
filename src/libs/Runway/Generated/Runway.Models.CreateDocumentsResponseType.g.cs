
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of document.
    /// </summary>
    public enum CreateDocumentsResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDocumentsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentsResponseType value)
        {
            return value switch
            {
                CreateDocumentsResponseType.File => "file",
                CreateDocumentsResponseType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "file" => CreateDocumentsResponseType.File,
                "text" => CreateDocumentsResponseType.Text,
                _ => null,
            };
        }
    }
}