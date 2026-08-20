
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVideoToHdrRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ruby,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoToHdrRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoToHdrRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVideoToHdrRequestDiscriminatorModel.Ruby => "ruby",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoToHdrRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "ruby" => CreateVideoToHdrRequestDiscriminatorModel.Ruby,
                _ => null,
            };
        }
    }
}