
#nullable enable

namespace Runway
{
    /// <summary>
    /// How the routing attempt ended: routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
    /// </summary>
    public enum GetRoutersRequestsResponseDataItemStatus
    {
        /// <summary>
        /// routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        Error,
        /// <summary>
        /// routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        NoEligibleModel,
        /// <summary>
        /// routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        Routed,
        /// <summary>
        /// routed (model selected), no_eligible_model (hard filters emptied the pool), router_config_not_found (same condition as the generate error of that name), invalid_request, or error.
        /// </summary>
        RouterConfigNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutersRequestsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutersRequestsResponseDataItemStatus value)
        {
            return value switch
            {
                GetRoutersRequestsResponseDataItemStatus.Error => "error",
                GetRoutersRequestsResponseDataItemStatus.InvalidRequest => "invalid_request",
                GetRoutersRequestsResponseDataItemStatus.NoEligibleModel => "no_eligible_model",
                GetRoutersRequestsResponseDataItemStatus.Routed => "routed",
                GetRoutersRequestsResponseDataItemStatus.RouterConfigNotFound => "router_config_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutersRequestsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetRoutersRequestsResponseDataItemStatus.Error,
                "invalid_request" => GetRoutersRequestsResponseDataItemStatus.InvalidRequest,
                "no_eligible_model" => GetRoutersRequestsResponseDataItemStatus.NoEligibleModel,
                "routed" => GetRoutersRequestsResponseDataItemStatus.Routed,
                "router_config_not_found" => GetRoutersRequestsResponseDataItemStatus.RouterConfigNotFound,
                _ => null,
            };
        }
    }
}