
#nullable enable

namespace Runway
{
    /// <summary>
    /// The type of document.
    /// </summary>
    public enum GetDocumentsResponseDataItemType
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
    public static class GetDocumentsResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsResponseDataItemType value)
        {
            return value switch
            {
                GetDocumentsResponseDataItemType.File => "file",
                GetDocumentsResponseDataItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetDocumentsResponseDataItemType.File,
                "text" => GetDocumentsResponseDataItemType.Text,
                _ => null,
            };
        }
    }
}