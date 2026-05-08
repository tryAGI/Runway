#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetAvatarConversationsResponse2 : global::System.IEquatable<GetAvatarConversationsResponse2>
    {
        /// <summary>
        /// A conversation that is currently active.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarConversationsResponseVariant1? InProgress { get; init; }
#else
        public global::Runway.GetAvatarConversationsResponseVariant1? InProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InProgress))]
#endif
        public bool IsInProgress => InProgress != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetAvatarConversationsResponseVariant1? value)
        {
            value = InProgress;
            return IsInProgress;
        }

        /// <summary>
        /// A conversation that completed successfully.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarConversationsResponseVariant2? Ended { get; init; }
#else
        public global::Runway.GetAvatarConversationsResponseVariant2? Ended { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ended))]
#endif
        public bool IsEnded => Ended != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetAvatarConversationsResponseVariant2? value)
        {
            value = Ended;
            return IsEnded;
        }

        /// <summary>
        /// A conversation that ended due to an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarConversationsResponseVariant3? Failed { get; init; }
#else
        public global::Runway.GetAvatarConversationsResponseVariant3? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetAvatarConversationsResponseVariant3? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant1 value) => new GetAvatarConversationsResponse2((global::Runway.GetAvatarConversationsResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarConversationsResponseVariant1?(GetAvatarConversationsResponse2 @this) => @this.InProgress;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant1? value)
        {
            InProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant2 value) => new GetAvatarConversationsResponse2((global::Runway.GetAvatarConversationsResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarConversationsResponseVariant2?(GetAvatarConversationsResponse2 @this) => @this.Ended;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant2? value)
        {
            Ended = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant3 value) => new GetAvatarConversationsResponse2((global::Runway.GetAvatarConversationsResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarConversationsResponseVariant3?(GetAvatarConversationsResponse2 @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarConversationsResponse2(global::Runway.GetAvatarConversationsResponseVariant3? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarConversationsResponse2(
            global::Runway.GetAvatarConversationsResponseVariant1? inProgress,
            global::Runway.GetAvatarConversationsResponseVariant2? ended,
            global::Runway.GetAvatarConversationsResponseVariant3? failed
            )
        {
            InProgress = inProgress;
            Ended = ended;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Ended as object ??
            InProgress as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InProgress?.ToString() ??
            Ended?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInProgress && !IsEnded && !IsFailed || !IsInProgress && IsEnded && !IsFailed || !IsInProgress && !IsEnded && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.GetAvatarConversationsResponseVariant1, TResult>? inProgress = null,
            global::System.Func<global::Runway.GetAvatarConversationsResponseVariant2, TResult>? ended = null,
            global::System.Func<global::Runway.GetAvatarConversationsResponseVariant3, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInProgress && inProgress != null)
            {
                return inProgress(InProgress!);
            }
            else if (IsEnded && ended != null)
            {
                return ended(Ended!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant1>? inProgress = null,

            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant2>? ended = null,

            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant3>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInProgress)
            {
                inProgress?.Invoke(InProgress!);
            }
            else if (IsEnded)
            {
                ended?.Invoke(Ended!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant1>? inProgress = null,
            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant2>? ended = null,
            global::System.Action<global::Runway.GetAvatarConversationsResponseVariant3>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInProgress)
            {
                inProgress?.Invoke(InProgress!);
            }
            else if (IsEnded)
            {
                ended?.Invoke(Ended!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InProgress,
                typeof(global::Runway.GetAvatarConversationsResponseVariant1),
                Ended,
                typeof(global::Runway.GetAvatarConversationsResponseVariant2),
                Failed,
                typeof(global::Runway.GetAvatarConversationsResponseVariant3),
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
        public bool Equals(GetAvatarConversationsResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarConversationsResponseVariant1?>.Default.Equals(InProgress, other.InProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarConversationsResponseVariant2?>.Default.Equals(Ended, other.Ended) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarConversationsResponseVariant3?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetAvatarConversationsResponse2 obj1, GetAvatarConversationsResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetAvatarConversationsResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetAvatarConversationsResponse2 obj1, GetAvatarConversationsResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAvatarConversationsResponse2 o && Equals(o);
        }
    }
}
