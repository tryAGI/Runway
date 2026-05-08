
#nullable enable

namespace Runway
{
    /// <summary>
    /// Default Value: createdAt
    /// </summary>
    public enum GetDocumentsSort
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsSort value)
        {
            return value switch
            {
                GetDocumentsSort.CreatedAt => "createdAt",
                GetDocumentsSort.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsSort? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GetDocumentsSort.CreatedAt,
                "updatedAt" => GetDocumentsSort.UpdatedAt,
                _ => null,
            };
        }
    }
}