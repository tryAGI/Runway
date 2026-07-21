
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the video is used. `source` is the primary video-to-video input; `reference` is additional video context.
    /// </summary>
    public enum CreateGenerateVideoRequestInputReferenceVideoRole
    {
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        Source,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerateVideoRequestInputReferenceVideoRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerateVideoRequestInputReferenceVideoRole value)
        {
            return value switch
            {
                CreateGenerateVideoRequestInputReferenceVideoRole.Reference => "reference",
                CreateGenerateVideoRequestInputReferenceVideoRole.Source => "source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerateVideoRequestInputReferenceVideoRole? ToEnum(string value)
        {
            return value switch
            {
                "reference" => CreateGenerateVideoRequestInputReferenceVideoRole.Reference,
                "source" => CreateGenerateVideoRequestInputReferenceVideoRole.Source,
                _ => null,
            };
        }
    }
}