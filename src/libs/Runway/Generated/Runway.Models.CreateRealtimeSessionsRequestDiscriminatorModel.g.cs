
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateRealtimeSessionsRequestDiscriminatorModel
    {
        /// <summary>
        ///
        /// </summary>
        Gwm1Avatars,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRealtimeSessionsRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRealtimeSessionsRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateRealtimeSessionsRequestDiscriminatorModel.Gwm1Avatars => "gwm1_avatars",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRealtimeSessionsRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gwm1_avatars" => CreateRealtimeSessionsRequestDiscriminatorModel.Gwm1Avatars,
                _ => null,
            };
        }
    }
}