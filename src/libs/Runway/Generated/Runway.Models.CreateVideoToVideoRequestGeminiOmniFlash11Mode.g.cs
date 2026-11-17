
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the input video is used. `reference` generates a new video guided by the input, `extend` continues it, and `edit` transforms it according to the prompt.<br/>
    /// Default Value: reference
    /// </summary>
    public enum CreateVideoToVideoRequestGeminiOmniFlash11Mode
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
    public static class CreateVideoToVideoRequestGeminiOmniFlash11ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToVideoRequestGeminiOmniFlash11Mode value)
        {
            return value switch
            {
                CreateVideoToVideoRequestGeminiOmniFlash11Mode.Edit => "edit",
                CreateVideoToVideoRequestGeminiOmniFlash11Mode.Extend => "extend",
                CreateVideoToVideoRequestGeminiOmniFlash11Mode.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToVideoRequestGeminiOmniFlash11Mode? ToEnum(string value)
        {
            return value switch
            {
                "edit" => CreateVideoToVideoRequestGeminiOmniFlash11Mode.Edit,
                "extend" => CreateVideoToVideoRequestGeminiOmniFlash11Mode.Extend,
                "reference" => CreateVideoToVideoRequestGeminiOmniFlash11Mode.Reference,
                _ => null,
            };
        }
    }
}