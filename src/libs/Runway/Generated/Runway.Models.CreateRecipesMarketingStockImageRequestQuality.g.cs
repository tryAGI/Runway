
#nullable enable

namespace Runway
{
    /// <summary>
    /// GPT Image 2 rendering quality (`low`, `medium`, or `high`). Lower settings are faster and use fewer credits; `high` (default) is slowest and highest fidelity.<br/>
    /// Default Value: high
    /// </summary>
    public enum CreateRecipesMarketingStockImageRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesMarketingStockImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesMarketingStockImageRequestQuality value)
        {
            return value switch
            {
                CreateRecipesMarketingStockImageRequestQuality.High => "high",
                CreateRecipesMarketingStockImageRequestQuality.Low => "low",
                CreateRecipesMarketingStockImageRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesMarketingStockImageRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateRecipesMarketingStockImageRequestQuality.High,
                "low" => CreateRecipesMarketingStockImageRequestQuality.Low,
                "medium" => CreateRecipesMarketingStockImageRequestQuality.Medium,
                _ => null,
            };
        }
    }
}