
#nullable enable

namespace Runway
{
    /// <summary>
    /// The tool type.
    /// </summary>
    public enum GetAvatarConversationsResponseVariant3ToolType
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
    public static class GetAvatarConversationsResponseVariant3ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarConversationsResponseVariant3ToolType value)
        {
            return value switch
            {
                GetAvatarConversationsResponseVariant3ToolType.BackendRpc => "backend_rpc",
                GetAvatarConversationsResponseVariant3ToolType.ClientEvent => "client_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarConversationsResponseVariant3ToolType? ToEnum(string value)
        {
            return value switch
            {
                "backend_rpc" => GetAvatarConversationsResponseVariant3ToolType.BackendRpc,
                "client_event" => GetAvatarConversationsResponseVariant3ToolType.ClientEvent,
                _ => null,
            };
        }
    }
}