#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// A tool available to the avatar during the session.
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A fire-and-forget tool that sends arguments to the frontend client of the realtime session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? ClientEvent { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? ClientEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientEvent))]
#endif
        public bool IsClientEvent => ClientEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? value)
        {
            value = ClientEvent;
            return IsClientEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool PickClientEvent() => ClientEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientEvent' but the value was {ToString()}.");

        /// <summary>
        /// A tool that makes a round-trip RPC call to your backend server during the session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? BackendRpc { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? BackendRpc { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackendRpc))]
#endif
        public bool IsBackendRpc => BackendRpc != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackendRpc(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? value)
        {
            value = BackendRpc;
            return IsBackendRpc;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool PickBackendRpc() => BackendRpc is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackendRpc' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool value) => new ToolsItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool?(ToolsItem @this) => @this.ClientEvent;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? value)
        {
            ClientEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem FromClientEvent(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? value) => new ToolsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool value) => new ToolsItem((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool?(ToolsItem @this) => @this.BackendRpc;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? value)
        {
            BackendRpc = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem FromBackendRpc(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? value) => new ToolsItem(value);

        /// <summary>
        ///
        /// </summary>
        public ToolsItem(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool? clientEvent,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool? backendRpc
            )
        {
            Type = type;

            ClientEvent = clientEvent;
            BackendRpc = backendRpc;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BackendRpc as object ??
            ClientEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ClientEvent?.ToString() ??
            BackendRpc?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsClientEvent && !IsBackendRpc || !IsClientEvent && IsBackendRpc;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool, TResult>? clientEvent = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool, TResult>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClientEvent is { } __value0 && clientEvent != null)
            {
                return clientEvent(__value0);
            }
            else if (BackendRpc is { } __value1 && backendRpc != null)
            {
                return backendRpc(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool>? clientEvent = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClientEvent is { } __value0)
            {
                clientEvent?.Invoke(__value0);
            }
            else if (BackendRpc is { } __value1)
            {
                backendRpc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool>? clientEvent = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ClientEvent is { } __value0)
            {
                clientEvent?.Invoke(__value0);
            }
            else if (BackendRpc is { } __value1)
            {
                backendRpc?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClientEvent,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool),
                BackendRpc,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolClientEventTool?>.Default.Equals(ClientEvent, other.ClientEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsToolBackendRPCTool?>.Default.Equals(BackendRpc, other.BackendRpc)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
        }
    }
}
