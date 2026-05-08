
#nullable enable

namespace Runway
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetDocumentsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsOrder value)
        {
            return value switch
            {
                GetDocumentsOrder.Asc => "asc",
                GetDocumentsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetDocumentsOrder.Asc,
                "desc" => GetDocumentsOrder.Desc,
                _ => null,
            };
        }
    }
}