#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// The avatar configuration for the session.
    /// </summary>
    public readonly partial struct Avatar : global::System.IEquatable<Avatar>
    {
        /// <summary>
        /// A preset avatar from Runway.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar? RunwayPreset { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar? RunwayPreset { get; }
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
            out global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar? value)
        {
            value = RunwayPreset;
            return IsRunwayPreset;
        }

        /// <summary>
        /// A user-created avatar.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar? Custom { get; init; }
#else
        public global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar? Custom { get; }
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
            out global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar? value)
        {
            value = Custom;
            return IsCustom;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Avatar(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar value) => new Avatar((global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar?(Avatar @this) => @this.RunwayPreset;

        /// <summary>
        /// 
        /// </summary>
        public Avatar(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar? value)
        {
            RunwayPreset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Avatar(global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar value) => new Avatar((global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar?(Avatar @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Avatar(global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Avatar(
            global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar? runwayPreset,
            global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar? custom
            )
        {
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
            global::System.Func<global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar, TResult>? runwayPreset = null,
            global::System.Func<global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar, TResult>? custom = null,
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
            global::System.Action<global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar>? runwayPreset = null,

            global::System.Action<global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar>? custom = null,
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
            global::System.Action<global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar>? runwayPreset = null,
            global::System.Action<global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar>? custom = null,
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
                typeof(global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar),
                Custom,
                typeof(global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar),
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
        public bool Equals(Avatar other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestAvatarRunwayPresetAvatar?>.Default.Equals(RunwayPreset, other.RunwayPreset) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarVideosRequestAvatarCustomAvatar?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Avatar obj1, Avatar obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Avatar>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Avatar obj1, Avatar obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Avatar o && Equals(o);
        }
    }
}
