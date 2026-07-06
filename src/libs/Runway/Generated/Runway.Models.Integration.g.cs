#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// External integration. Runway renders the avatar; the integration owns conversation or audio.
    /// </summary>
    public readonly partial struct Integration : global::System.IEquatable<Integration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType? Type { get; }

        /// <summary>
        /// ElevenLabs handles conversation; Runway renders the avatar video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? Elevenlabs { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? Elevenlabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Elevenlabs))]
#endif
        public bool IsElevenlabs => Elevenlabs != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenlabs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? value)
        {
            value = Elevenlabs;
            return IsElevenlabs;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration PickElevenlabs() => IsElevenlabs
            ? Elevenlabs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Elevenlabs' but the value was {ToString()}.");

        /// <summary>
        /// Join an external LiveKit room; Runway publishes video, your agent supplies audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? Livekit { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? Livekit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Livekit))]
#endif
        public bool IsLivekit => Livekit != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLivekit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? value)
        {
            value = Livekit;
            return IsLivekit;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration PickLivekit() => IsLivekit
            ? Livekit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Livekit' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Integration(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration value) => new Integration((global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration?(Integration @this) => @this.Elevenlabs;

        /// <summary>
        /// 
        /// </summary>
        public Integration(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Integration FromElevenlabs(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? value) => new Integration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Integration(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration value) => new Integration((global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration?(Integration @this) => @this.Livekit;

        /// <summary>
        /// 
        /// </summary>
        public Integration(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? value)
        {
            Livekit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Integration FromLivekit(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? value) => new Integration(value);

        /// <summary>
        /// 
        /// </summary>
        public Integration(
            global::Runway.CreateRealtimeSessionsRequestIntegrationDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration? elevenlabs,
            global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration? livekit
            )
        {
            Type = type;

            Elevenlabs = elevenlabs;
            Livekit = livekit;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Livekit as object ??
            Elevenlabs as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Elevenlabs?.ToString() ??
            Livekit?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenlabs && !IsLivekit || !IsElevenlabs && IsLivekit;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration, TResult>? elevenlabs = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration, TResult>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenlabs && elevenlabs != null)
            {
                return elevenlabs(Elevenlabs!);
            }
            else if (IsLivekit && livekit != null)
            {
                return livekit(Livekit!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration>? elevenlabs = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsLivekit)
            {
                livekit?.Invoke(Livekit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration>? elevenlabs = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsLivekit)
            {
                livekit?.Invoke(Livekit!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Elevenlabs,
                typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration),
                Livekit,
                typeof(global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration),
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
        public bool Equals(Integration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestIntegrationElevenLabsIntegration?>.Default.Equals(Elevenlabs, other.Elevenlabs) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestIntegrationLiveKitIntegration?>.Default.Equals(Livekit, other.Livekit) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Integration obj1, Integration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Integration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Integration obj1, Integration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Integration o && Equals(o);
        }
    }
}
