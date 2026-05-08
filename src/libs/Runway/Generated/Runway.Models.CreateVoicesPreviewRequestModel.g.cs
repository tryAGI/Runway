
#nullable enable

namespace Runway
{
    /// <summary>
    /// The voice design model to use. Prefer eleven_ttv_v3 (latest); eleven_multilingual_ttv_v2 is the previous generation.
    /// </summary>
    public enum CreateVoicesPreviewRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenMultilingualTtvV2,
        /// <summary>
        /// 
        /// </summary>
        ElevenTtvV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoicesPreviewRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoicesPreviewRequestModel value)
        {
            return value switch
            {
                CreateVoicesPreviewRequestModel.ElevenMultilingualTtvV2 => "eleven_multilingual_ttv_v2",
                CreateVoicesPreviewRequestModel.ElevenTtvV3 => "eleven_ttv_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoicesPreviewRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_multilingual_ttv_v2" => CreateVoicesPreviewRequestModel.ElevenMultilingualTtvV2,
                "eleven_ttv_v3" => CreateVoicesPreviewRequestModel.ElevenTtvV3,
                _ => null,
            };
        }
    }
}