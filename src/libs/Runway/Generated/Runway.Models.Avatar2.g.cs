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
        public global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType? Type { get; }

        /// <summary>
        /// A preset avatar from Runway.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? RunwayPreset { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? RunwayPreset { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? value)
        {
            value = RunwayPreset;
            return IsRunwayPreset;
        }

        /// <summary>
        /// A user-created avatar.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? Custom { get; init; }
#else
        public global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? Custom { get; }
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
            out global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Avatar2(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar value) => new Avatar2((global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar?(Avatar2 @this) => @this.RunwayPreset;

        /// <summary>
        /// 
        /// </summary>
        public Avatar2(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? value)
        {
            RunwayPreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Avatar2 FromRunwayPreset(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? value) => new Avatar2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Avatar2(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar value) => new Avatar2((global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar?(Avatar2 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Avatar2(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Avatar2 FromCustom(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? value) => new Avatar2(value);

        /// <summary>
        /// 
        /// </summary>
        public Avatar2(
            global::Runway.CreateRealtimeSessionsRequestAvatarDiscriminatorType? type,
            global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar? runwayPreset,
            global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar? custom
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
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar, TResult>? runwayPreset = null,
            global::System.Func<global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset && runwayPreset != null)
            {
                return runwayPreset(RunwayPreset!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar>? runwayPreset = null,

            global::System.Action<global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset)
            {
                runwayPreset?.Invoke(RunwayPreset!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar>? runwayPreset = null,
            global::System.Action<global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunwayPreset)
            {
                runwayPreset?.Invoke(RunwayPreset!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
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
                typeof(global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar),
                Custom,
                typeof(global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestAvatarRunwayPresetAvatar?>.Default.Equals(RunwayPreset, other.RunwayPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateRealtimeSessionsRequestAvatarCustomAvatar?>.Default.Equals(Custom, other.Custom) 
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
