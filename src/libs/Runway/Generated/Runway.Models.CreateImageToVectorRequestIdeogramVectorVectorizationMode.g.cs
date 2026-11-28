
#nullable enable

namespace Runway
{
    /// <summary>
    /// Use simple for fewer shapes, or default to retain more detail.
    /// </summary>
    public enum CreateImageToVectorRequestIdeogramVectorVectorizationMode
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVectorRequestIdeogramVectorVectorizationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVectorRequestIdeogramVectorVectorizationMode value)
        {
            return value switch
            {
                CreateImageToVectorRequestIdeogramVectorVectorizationMode.Default => "default",
                CreateImageToVectorRequestIdeogramVectorVectorizationMode.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVectorRequestIdeogramVectorVectorizationMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateImageToVectorRequestIdeogramVectorVectorizationMode.Default,
                "simple" => CreateImageToVectorRequestIdeogramVectorVectorizationMode.Simple,
                _ => null,
            };
        }
    }
}