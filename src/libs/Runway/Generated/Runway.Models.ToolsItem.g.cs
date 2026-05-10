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
        public global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A fire-and-forget tool that sends arguments to the frontend client of the realtime session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? ClientEvent { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? ClientEvent { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? value)
        {
            value = ClientEvent;
            return IsClientEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolClientEventTool PickClientEvent() => IsClientEvent
            ? ClientEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientEvent' but the value was {ToString()}.");

        /// <summary>
        /// A tool that makes a round-trip RPC call to your backend server during the session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? BackendRpc { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? BackendRpc { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? value)
        {
            value = BackendRpc;
            return IsBackendRpc;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool PickBackendRpc() => IsBackendRpc
            ? BackendRpc!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackendRpc' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool value) => new ToolsItem((global::Runway.CreateRealtimeSessionsRequestToolClientEventTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolClientEventTool?(ToolsItem @this) => @this.ClientEvent;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? value)
        {
            ClientEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem FromClientEvent(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool value) => new ToolsItem((global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool?(ToolsItem @this) => @this.BackendRpc;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? value)
        {
            BackendRpc = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem FromBackendRpc(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::Runway.CreateRealtimeSessionsRequestToolDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestToolClientEventTool? clientEvent,
            global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool? backendRpc
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolClientEventTool, TResult>? clientEvent = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool, TResult>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientEvent && clientEvent != null)
            {
                return clientEvent(ClientEvent!);
            }
            else if (IsBackendRpc && backendRpc != null)
            {
                return backendRpc(BackendRpc!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventTool>? clientEvent = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientEvent)
            {
                clientEvent?.Invoke(ClientEvent!);
            }
            else if (IsBackendRpc)
            {
                backendRpc?.Invoke(BackendRpc!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolClientEventTool>? clientEvent = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool>? backendRpc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientEvent)
            {
                clientEvent?.Invoke(ClientEvent!);
            }
            else if (IsBackendRpc)
            {
                backendRpc?.Invoke(BackendRpc!);
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
                typeof(global::Runway.CreateRealtimeSessionsRequestToolClientEventTool),
                BackendRpc,
                typeof(global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolClientEventTool?>.Default.Equals(ClientEvent, other.ClientEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestToolBackendRPCTool?>.Default.Equals(BackendRpc, other.BackendRpc) 
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
