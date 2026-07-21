
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the image is used. `first` is the starting frame; `last` is an end frame; `reference` is additional image context.
    /// </summary>
    public enum CreateGenerateVideoRequestInputReferenceImageRole
    {
        /// <summary>
        /// 
        /// </summary>
        First,
        /// <summary>
        /// 
        /// </summary>
        Last,
        /// <summary>
        /// 
        /// </summary>
        Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateVideoRequestInputReferenceImageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoRequestInputReferenceImageRole value)
        {
            return value switch
            {
                CreateGenerateVideoRequestInputReferenceImageRole.First => "first",
                CreateGenerateVideoRequestInputReferenceImageRole.Last => "last",
                CreateGenerateVideoRequestInputReferenceImageRole.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoRequestInputReferenceImageRole? ToEnum(string value)
        {
            return value switch
            {
                "first" => CreateGenerateVideoRequestInputReferenceImageRole.First,
                "last" => CreateGenerateVideoRequestInputReferenceImageRole.Last,
                "reference" => CreateGenerateVideoRequestInputReferenceImageRole.Reference,
                _ => null,
            };
        }
    }
}