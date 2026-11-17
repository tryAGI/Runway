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
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType? Type { get; }

        /// <summary>
        /// ElevenLabs handles conversation; Runway renders the avatar video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? Elevenlabs { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? Elevenlabs { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? value)
        {
            value = Elevenlabs;
            return IsElevenlabs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration PickElevenlabs() => Elevenlabs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Elevenlabs' but the value was {ToString()}.");

        /// <summary>
        /// Join an external LiveKit room; Runway publishes video, your agent supplies audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? Livekit { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? Livekit { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? value)
        {
            value = Livekit;
            return IsLivekit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration PickLivekit() => Livekit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Livekit' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Integration(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration value) => new Integration((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration?(Integration @this) => @this.Elevenlabs;

        /// <summary>
        ///
        /// </summary>
        public Integration(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Integration FromElevenlabs(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? value) => new Integration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Integration(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration value) => new Integration((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration?(Integration @this) => @this.Livekit;

        /// <summary>
        ///
        /// </summary>
        public Integration(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? value)
        {
            Livekit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Integration FromLivekit(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? value) => new Integration(value);

        /// <summary>
        ///
        /// </summary>
        public Integration(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration? elevenlabs,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration? livekit
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration, TResult>? elevenlabs = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration, TResult>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Elevenlabs is { } __value0 && elevenlabs != null)
            {
                return elevenlabs(__value0);
            }
            else if (Livekit is { } __value1 && livekit != null)
            {
                return livekit(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration>? elevenlabs = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Elevenlabs is { } __value0)
            {
                elevenlabs?.Invoke(__value0);
            }
            else if (Livekit is { } __value1)
            {
                livekit?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration>? elevenlabs = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration>? livekit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Elevenlabs is { } __value0)
            {
                elevenlabs?.Invoke(__value0);
            }
            else if (Livekit is { } __value1)
            {
                livekit?.Invoke(__value1);
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
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration),
                Livekit,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationElevenLabsIntegration?>.Default.Equals(Elevenlabs, other.Elevenlabs) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsIntegrationLiveKitIntegration?>.Default.Equals(Livekit, other.Livekit)
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
