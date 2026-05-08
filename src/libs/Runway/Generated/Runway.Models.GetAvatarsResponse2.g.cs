#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetAvatarsResponse2 : global::System.IEquatable<GetAvatarsResponse2>
    {
        /// <summary>
        /// An avatar that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseAvatarProcessing? Processing { get; init; }
#else
        public global::Runway.GetAvatarsResponseAvatarProcessing? Processing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Processing))]
#endif
        public bool IsProcessing => Processing != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProcessing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetAvatarsResponseAvatarProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// An avatar that is ready for use in sessions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseAvatarReady? Ready { get; init; }
#else
        public global::Runway.GetAvatarsResponseAvatarReady? Ready { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ready))]
#endif
        public bool IsReady => Ready != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReady(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetAvatarsResponseAvatarReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// An avatar that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseAvatarFailed? Failed { get; init; }
#else
        public global::Runway.GetAvatarsResponseAvatarFailed? Failed { get; }
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
            out global::Runway.GetAvatarsResponseAvatarFailed? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarProcessing value) => new GetAvatarsResponse2((global::Runway.GetAvatarsResponseAvatarProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseAvatarProcessing?(GetAvatarsResponse2 @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarReady value) => new GetAvatarsResponse2((global::Runway.GetAvatarsResponseAvatarReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseAvatarReady?(GetAvatarsResponse2 @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarFailed value) => new GetAvatarsResponse2((global::Runway.GetAvatarsResponseAvatarFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseAvatarFailed?(GetAvatarsResponse2 @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarsResponse2(global::Runway.GetAvatarsResponseAvatarFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetAvatarsResponse2(
            global::Runway.GetAvatarsResponseAvatarProcessing? processing,
            global::Runway.GetAvatarsResponseAvatarReady? ready,
            global::Runway.GetAvatarsResponseAvatarFailed? failed
            )
        {
            Processing = processing;
            Ready = ready;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Ready as object ??
            Processing as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Processing?.ToString() ??
            Ready?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProcessing && !IsReady && !IsFailed || !IsProcessing && IsReady && !IsFailed || !IsProcessing && !IsReady && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.GetAvatarsResponseAvatarProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.GetAvatarsResponseAvatarReady, TResult>? ready = null,
            global::System.Func<global::Runway.GetAvatarsResponseAvatarFailed, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcessing && processing != null)
            {
                return processing(Processing!);
            }
            else if (IsReady && ready != null)
            {
                return ready(Ready!);
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
            global::System.Action<global::Runway.GetAvatarsResponseAvatarProcessing>? processing = null,

            global::System.Action<global::Runway.GetAvatarsResponseAvatarReady>? ready = null,

            global::System.Action<global::Runway.GetAvatarsResponseAvatarFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcessing)
            {
                processing?.Invoke(Processing!);
            }
            else if (IsReady)
            {
                ready?.Invoke(Ready!);
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
            global::System.Action<global::Runway.GetAvatarsResponseAvatarProcessing>? processing = null,
            global::System.Action<global::Runway.GetAvatarsResponseAvatarReady>? ready = null,
            global::System.Action<global::Runway.GetAvatarsResponseAvatarFailed>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcessing)
            {
                processing?.Invoke(Processing!);
            }
            else if (IsReady)
            {
                ready?.Invoke(Ready!);
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
                Processing,
                typeof(global::Runway.GetAvatarsResponseAvatarProcessing),
                Ready,
                typeof(global::Runway.GetAvatarsResponseAvatarReady),
                Failed,
                typeof(global::Runway.GetAvatarsResponseAvatarFailed),
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
        public bool Equals(GetAvatarsResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseAvatarProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseAvatarReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseAvatarFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetAvatarsResponse2 obj1, GetAvatarsResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetAvatarsResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetAvatarsResponse2 obj1, GetAvatarsResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAvatarsResponse2 o && Equals(o);
        }
    }
}
