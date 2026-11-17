#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The avatar configuration for the session.
    /// </summary>
    public readonly partial struct Avatar2 : global::System.IEquatable<Avatar2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset avatar from Runway.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? RunwayPreset { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? RunwayPreset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunwayPreset))]
#endif
        public bool IsRunwayPreset => RunwayPreset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunwayPreset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? value)
        {
            value = RunwayPreset;
            return IsRunwayPreset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar PickRunwayPreset() => RunwayPreset is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunwayPreset' but the value was {ToString()}.");

        /// <summary>
        /// A user-created avatar.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? Custom { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Avatar2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar value) => new Avatar2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar?(Avatar2 @this) => @this.RunwayPreset;

        /// <summary>
        ///
        /// </summary>
        public Avatar2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? value)
        {
            RunwayPreset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Avatar2 FromRunwayPreset(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? value) => new Avatar2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Avatar2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar value) => new Avatar2((global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar?(Avatar2 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public Avatar2(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Avatar2 FromCustom(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? value) => new Avatar2(value);

        /// <summary>
        ///
        /// </summary>
        public Avatar2(
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar? runwayPreset,
            global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar? custom
            )
        {
            Type = type;

            RunwayPreset = runwayPreset;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            RunwayPreset as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunwayPreset?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunwayPreset && !IsCustom || !IsRunwayPreset && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar, TResult>? runwayPreset = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0 && runwayPreset != null)
            {
                return runwayPreset(__value0);
            }
            else if (Custom is { } __value1 && custom != null)
            {
                return custom(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar>? runwayPreset = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0)
            {
                runwayPreset?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar>? runwayPreset = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunwayPreset is { } __value0)
            {
                runwayPreset?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunwayPreset,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar),
                Custom,
                typeof(global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar),
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
        public bool Equals(Avatar2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarRunwayPresetAvatar?>.Default.Equals(RunwayPreset, other.RunwayPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestGwm1AvatarsAvatarCustomAvatar?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Avatar2 obj1, Avatar2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Avatar2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Avatar2 obj1, Avatar2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Avatar2 o && Equals(o);
        }
    }
}
