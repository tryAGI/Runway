#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateRealtimeSessionsRequest : global::System.IEquatable<CreateRealtimeSessionsRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? Gwm1Avatars { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? Gwm1Avatars { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gwm1Avatars))]
#endif
        public bool IsGwm1Avatars => Gwm1Avatars != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGwm1Avatars(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? value)
        {
            value = Gwm1Avatars;
            return IsGwm1Avatars;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1Avatars PickGwm1Avatars() => Gwm1Avatars is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gwm1Avatars' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateRealtimeSessionsRequest(global::Runway.CreateRealtimeSessionsRequestGwm1Avatars value) => new CreateRealtimeSessionsRequest((global::Runway.CreateRealtimeSessionsRequestGwm1Avatars?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1Avatars?(CreateRealtimeSessionsRequest @this) => @this.Gwm1Avatars;

        /// <summary>
        ///
        /// </summary>
        public CreateRealtimeSessionsRequest(global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? value)
        {
            Gwm1Avatars = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateRealtimeSessionsRequest FromGwm1Avatars(global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? value) => new CreateRealtimeSessionsRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateRealtimeSessionsRequest(
            global::Runway.CreateRealtimeSessionsRequestDiscriminatorModel? model,
            global::Runway.CreateRealtimeSessionsRequestGwm1Avatars? gwm1Avatars
            )
        {
            Model = model;

            Gwm1Avatars = gwm1Avatars;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Gwm1Avatars as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Gwm1Avatars?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGwm1Avatars;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1Avatars, TResult>? gwm1Avatars = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gwm1Avatars is { } __value0 && gwm1Avatars != null)
            {
                return gwm1Avatars(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1Avatars>? gwm1Avatars = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gwm1Avatars is { } __value0)
            {
                gwm1Avatars?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1Avatars>? gwm1Avatars = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gwm1Avatars is { } __value0)
            {
                gwm1Avatars?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gwm1Avatars,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1Avatars),
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
        public bool Equals(CreateRealtimeSessionsRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1Avatars?>.Default.Equals(Gwm1Avatars, other.Gwm1Avatars)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateRealtimeSessionsRequest obj1, CreateRealtimeSessionsRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateRealtimeSessionsRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateRealtimeSessionsRequest obj1, CreateRealtimeSessionsRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateRealtimeSessionsRequest o && Equals(o);
        }
    }
}
