
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Capacity,
        /// <summary>
        /// 
        /// </summary>
        Filter,
        /// <summary>
        /// 
        /// </summary>
        Rank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Capacity => "capacity",
                GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Filter => "filter",
                GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Rank => "rank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "capacity" => GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Capacity,
                "filter" => GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Filter,
                "rank" => GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType.Rank,
                _ => null,
            };
        }
    }
}