
#nullable enable

namespace Runway
{
    /// <summary>
    /// The tool type.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant2ToolType
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
    public static class GetAvatarConversationsResponseVariant2ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant2ToolType value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant2ToolType.BackendRpc => "backend_rpc",
                GetAvatarConversationsResponseVariant2ToolType.ClientEvent => "client_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant2ToolType? ToEnum(string value)
        {
            return value switch
            {
                "backend_rpc" => GetAvatarConversationsResponseVariant2ToolType.BackendRpc,
                "client_event" => GetAvatarConversationsResponseVariant2ToolType.ClientEvent,
                _ => null,
            };
        }
    }
}