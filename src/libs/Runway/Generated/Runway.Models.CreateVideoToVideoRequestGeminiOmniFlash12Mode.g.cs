
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the input video is used. `reference` generates a new video guided by the input, `extend` continues it, and `edit` transforms it according to the prompt.<br/>
    /// Default Value: reference
    /// </summary>
    public enum CreateVideoToVideoRequestGeminiOmniFlash12Mode
    {
        /// <summary>
        ///
        /// </summary>
        Edit,
        /// <summary>
        ///
        /// </summary>
        Extend,
        /// <summary>
        ///
        /// </summary>
        Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToVideoRequestGeminiOmniFlash12ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGeminiOmniFlash12Mode value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGeminiOmniFlash12Mode.Edit => "edit",
                CreateVideoToVideoRequestGeminiOmniFlash12Mode.Extend => "extend",
                CreateVideoToVideoRequestGeminiOmniFlash12Mode.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGeminiOmniFlash12Mode? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateVideoToVideoRequestGeminiOmniFlash12Mode.Edit,
                "extend" => CreateVideoToVideoRequestGeminiOmniFlash12Mode.Extend,
                "reference" => CreateVideoToVideoRequestGeminiOmniFlash12Mode.Reference,
                _ => null,
            };
        }
    }
}