
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of document.
    /// </summary>
    public enum GetDocumentsResponseType
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
    public static class GetDocumentsResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsResponseType value)
        {
            return value switch
            {
                GetDocumentsResponseType.File => "file",
                GetDocumentsResponseType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsResponseType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetDocumentsResponseType.File,
                "text" => GetDocumentsResponseType.Text,
                _ => null,
            };
        }
    }
}