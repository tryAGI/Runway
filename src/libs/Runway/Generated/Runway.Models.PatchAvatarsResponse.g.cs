#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PatchAvatarsResponse : global::System.IEquatable<PatchAvatarsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.PatchAvatarsResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// An avatar that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarProcessing? Processing { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarProcessing? Processing { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// An avatar that is ready for use in sessions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarReady? Ready { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarReady? Ready { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// An avatar that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchAvatarsResponseAvatarFailed? Failed { get; init; }
#else
        public global::Runway.PatchAvatarsResponseAvatarFailed? Failed { get; }
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
            out global::Runway.PatchAvatarsResponseAvatarFailed? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarProcessing value) => new PatchAvatarsResponse((global::Runway.PatchAvatarsResponseAvatarProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarProcessing?(PatchAvatarsResponse @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchAvatarsResponse FromProcessing(global::Runway.PatchAvatarsResponseAvatarProcessing? value) => new PatchAvatarsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarReady value) => new PatchAvatarsResponse((global::Runway.PatchAvatarsResponseAvatarReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarReady?(PatchAvatarsResponse @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchAvatarsResponse FromReady(global::Runway.PatchAvatarsResponseAvatarReady? value) => new PatchAvatarsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarFailed value) => new PatchAvatarsResponse((global::Runway.PatchAvatarsResponseAvatarFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchAvatarsResponseAvatarFailed?(PatchAvatarsResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public PatchAvatarsResponse(global::Runway.PatchAvatarsResponseAvatarFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PatchAvatarsResponse FromFailed(global::Runway.PatchAvatarsResponseAvatarFailed? value) => new PatchAvatarsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public PatchAvatarsResponse(
            global::Runway.PatchAvatarsResponseDiscriminatorStatus? status,
            global::Runway.PatchAvatarsResponseAvatarProcessing? processing,
            global::Runway.PatchAvatarsResponseAvatarReady? ready,
            global::Runway.PatchAvatarsResponseAvatarFailed? failed
            )
        {
            Status = status;

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
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarReady, TResult>? ready = null,
            global::System.Func<global::Runway.PatchAvatarsResponseAvatarFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessing>? processing = null,

            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReady>? ready = null,

            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailed>? failed = null,
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
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarProcessing>? processing = null,
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarReady>? ready = null,
            global::System.Action<global::Runway.PatchAvatarsResponseAvatarFailed>? failed = null,
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
                typeof(global::Runway.PatchAvatarsResponseAvatarProcessing),
                Ready,
                typeof(global::Runway.PatchAvatarsResponseAvatarReady),
                Failed,
                typeof(global::Runway.PatchAvatarsResponseAvatarFailed),
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
        public bool Equals(PatchAvatarsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchAvatarsResponseAvatarFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PatchAvatarsResponse obj1, PatchAvatarsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PatchAvatarsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PatchAvatarsResponse obj1, PatchAvatarsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PatchAvatarsResponse o && Equals(o);
        }
    }
}
