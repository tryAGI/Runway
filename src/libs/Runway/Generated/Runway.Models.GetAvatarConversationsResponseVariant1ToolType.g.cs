
#nullable enable

namespace Runway
{
    /// <summary>
    /// The tool type.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant1ToolType
    {
        /// <summary>
        /// 
        /// </summary>
        BackendRpc,
        /// <summary>
        /// 
        /// </summary>
        ClientEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarConversationsResponseVariant1ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant1ToolType value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant1ToolType.BackendRpc => "backend_rpc",
                GetAvatarConversationsResponseVariant1ToolType.ClientEvent => "client_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant1ToolType? ToEnum(string value)
        {
            return value switch
            {
                "backend_rpc" => GetAvatarConversationsResponseVariant1ToolType.BackendRpc,
                "client_event" => GetAvatarConversationsResponseVariant1ToolType.ClientEvent,
                _ => null,
            };
        }
    }
}