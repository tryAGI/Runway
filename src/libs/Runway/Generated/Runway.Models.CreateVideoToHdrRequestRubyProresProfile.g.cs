
#nullable enable

namespace Runway
{
    /// <summary>
    /// The ProRes tier of the `hdr_prores` mezzanine. Only valid when `outputFormat` is `hdr_prores`. Defaults to `422 HQ`.
    /// </summary>
    public enum CreateVideoToHdrRequestRubyProresProfile
    {
        /// <summary>
        ///
        /// </summary>
        x422,
        /// <summary>
        ///
        /// </summary>
        x422Hq,
        /// <summary>
        ///
        /// </summary>
        x4444,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToHdrRequestRubyProresProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToHdrRequestRubyProresProfile value)
        {
            return value switch
            {
                CreateVideoToHdrRequestRubyProresProfile.x422 => "422",
                CreateVideoToHdrRequestRubyProresProfile.x422Hq => "422 HQ",
                CreateVideoToHdrRequestRubyProresProfile.x4444 => "4444",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToHdrRequestRubyProresProfile? ToEnum(string value)
        {
            return value switch
            {
                "422" => CreateVideoToHdrRequestRubyProresProfile.x422,
                "422 HQ" => CreateVideoToHdrRequestRubyProresProfile.x422Hq,
                "4444" => CreateVideoToHdrRequestRubyProresProfile.x4444,
                _ => null,
            };
        }
    }
}