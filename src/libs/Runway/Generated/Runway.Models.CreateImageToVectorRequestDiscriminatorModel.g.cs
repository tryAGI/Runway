
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageToVectorRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        IdeogramVector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVectorRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVectorRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateImageToVectorRequestDiscriminatorModel.IdeogramVector => "ideogram_vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVectorRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "ideogram_vector" => CreateImageToVectorRequestDiscriminatorModel.IdeogramVector,
                _ => null,
            };
        }
    }
}