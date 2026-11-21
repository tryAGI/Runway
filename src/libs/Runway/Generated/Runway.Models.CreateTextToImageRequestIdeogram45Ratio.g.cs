
#nullable enable

namespace Runway
{
    /// <summary>
    /// The resolution of the output image, expressed as `&lt;width&gt;:&lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
    /// </summary>
    public enum CreateTextToImageRequestIdeogram45Ratio
    {
        /// <summary>
        ///
        /// </summary>
        x1024_1024,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x1024_576,
        /// <summary>
        ///
        /// </summary>
        x1120_896,
        /// <summary>
        ///
        /// </summary>
        x1152_864,
        /// <summary>
        ///
        /// </summary>
        x1248_832,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x1280_720,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x1408_704,
        /// <summary>
        ///
        /// </summary>
        x1440_2560,
        /// <summary>
        ///
        /// </summary>
        x1440_2880,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x1440_720,
        /// <summary>
        ///
        /// </summary>
        x1664_2496,
        /// <summary>
        ///
        /// </summary>
        x1728_2304,
        /// <summary>
        ///
        /// </summary>
        x1792_2240,
        /// <summary>
        ///
        /// </summary>
        x2048_2048,
        /// <summary>
        ///
        /// </summary>
        x2240_1792,
        /// <summary>
        ///
        /// </summary>
        x2304_1728,
        /// <summary>
        ///
        /// </summary>
        x2496_1664,
        /// <summary>
        ///
        /// </summary>
        x2560_1440,
        /// <summary>
        ///
        /// </summary>
        x2880_1440,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x576_1024,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x704_1408,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x720_1280,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        x720_1440,
        /// <summary>
        ///
        /// </summary>
        x832_1248,
        /// <summary>
        ///
        /// </summary>
        x864_1152,
        /// <summary>
        ///
        /// </summary>
        x896_1120,
        /// <summary>
        /// &lt;height&gt;`. Omit it or use `auto` to let the model choose. With reference images, widescreen 1K sizes are `1024:576`, `576:1024`, `1408:704`, `704:1408` instead of `1280:720`, `720:1280`, `1440:720`, `720:1440`. Not available with `maskUri` or `preciseEdit`, where the source and edit window determine output dimensions.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToImageRequestIdeogram45RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToImageRequestIdeogram45Ratio value)
        {
            return value switch
            {
                CreateTextToImageRequestIdeogram45Ratio.x1024_1024 => "1024:1024",
                CreateTextToImageRequestIdeogram45Ratio.x1024_576 => "1024:576",
                CreateTextToImageRequestIdeogram45Ratio.x1120_896 => "1120:896",
                CreateTextToImageRequestIdeogram45Ratio.x1152_864 => "1152:864",
                CreateTextToImageRequestIdeogram45Ratio.x1248_832 => "1248:832",
                CreateTextToImageRequestIdeogram45Ratio.x1280_720 => "1280:720",
                CreateTextToImageRequestIdeogram45Ratio.x1408_704 => "1408:704",
                CreateTextToImageRequestIdeogram45Ratio.x1440_2560 => "1440:2560",
                CreateTextToImageRequestIdeogram45Ratio.x1440_2880 => "1440:2880",
                CreateTextToImageRequestIdeogram45Ratio.x1440_720 => "1440:720",
                CreateTextToImageRequestIdeogram45Ratio.x1664_2496 => "1664:2496",
                CreateTextToImageRequestIdeogram45Ratio.x1728_2304 => "1728:2304",
                CreateTextToImageRequestIdeogram45Ratio.x1792_2240 => "1792:2240",
                CreateTextToImageRequestIdeogram45Ratio.x2048_2048 => "2048:2048",
                CreateTextToImageRequestIdeogram45Ratio.x2240_1792 => "2240:1792",
                CreateTextToImageRequestIdeogram45Ratio.x2304_1728 => "2304:1728",
                CreateTextToImageRequestIdeogram45Ratio.x2496_1664 => "2496:1664",
                CreateTextToImageRequestIdeogram45Ratio.x2560_1440 => "2560:1440",
                CreateTextToImageRequestIdeogram45Ratio.x2880_1440 => "2880:1440",
                CreateTextToImageRequestIdeogram45Ratio.x576_1024 => "576:1024",
                CreateTextToImageRequestIdeogram45Ratio.x704_1408 => "704:1408",
                CreateTextToImageRequestIdeogram45Ratio.x720_1280 => "720:1280",
                CreateTextToImageRequestIdeogram45Ratio.x720_1440 => "720:1440",
                CreateTextToImageRequestIdeogram45Ratio.x832_1248 => "832:1248",
                CreateTextToImageRequestIdeogram45Ratio.x864_1152 => "864:1152",
                CreateTextToImageRequestIdeogram45Ratio.x896_1120 => "896:1120",
                CreateTextToImageRequestIdeogram45Ratio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToImageRequestIdeogram45Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1024:1024" => CreateTextToImageRequestIdeogram45Ratio.x1024_1024,
                "1024:576" => CreateTextToImageRequestIdeogram45Ratio.x1024_576,
                "1120:896" => CreateTextToImageRequestIdeogram45Ratio.x1120_896,
                "1152:864" => CreateTextToImageRequestIdeogram45Ratio.x1152_864,
                "1248:832" => CreateTextToImageRequestIdeogram45Ratio.x1248_832,
                "1280:720" => CreateTextToImageRequestIdeogram45Ratio.x1280_720,
                "1408:704" => CreateTextToImageRequestIdeogram45Ratio.x1408_704,
                "1440:2560" => CreateTextToImageRequestIdeogram45Ratio.x1440_2560,
                "1440:2880" => CreateTextToImageRequestIdeogram45Ratio.x1440_2880,
                "1440:720" => CreateTextToImageRequestIdeogram45Ratio.x1440_720,
                "1664:2496" => CreateTextToImageRequestIdeogram45Ratio.x1664_2496,
                "1728:2304" => CreateTextToImageRequestIdeogram45Ratio.x1728_2304,
                "1792:2240" => CreateTextToImageRequestIdeogram45Ratio.x1792_2240,
                "2048:2048" => CreateTextToImageRequestIdeogram45Ratio.x2048_2048,
                "2240:1792" => CreateTextToImageRequestIdeogram45Ratio.x2240_1792,
                "2304:1728" => CreateTextToImageRequestIdeogram45Ratio.x2304_1728,
                "2496:1664" => CreateTextToImageRequestIdeogram45Ratio.x2496_1664,
                "2560:1440" => CreateTextToImageRequestIdeogram45Ratio.x2560_1440,
                "2880:1440" => CreateTextToImageRequestIdeogram45Ratio.x2880_1440,
                "576:1024" => CreateTextToImageRequestIdeogram45Ratio.x576_1024,
                "704:1408" => CreateTextToImageRequestIdeogram45Ratio.x704_1408,
                "720:1280" => CreateTextToImageRequestIdeogram45Ratio.x720_1280,
                "720:1440" => CreateTextToImageRequestIdeogram45Ratio.x720_1440,
                "832:1248" => CreateTextToImageRequestIdeogram45Ratio.x832_1248,
                "864:1152" => CreateTextToImageRequestIdeogram45Ratio.x864_1152,
                "896:1120" => CreateTextToImageRequestIdeogram45Ratio.x896_1120,
                "auto" => CreateTextToImageRequestIdeogram45Ratio.Auto,
                _ => null,
            };
        }
    }
}