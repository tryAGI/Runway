#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus? Status { get; }

        /// <summary>
        /// An avatar that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessing? Processing { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessing? Processing { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarProcessing PickProcessing() => IsProcessing
            ? Processing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Processing' but the value was {ToString()}.");

        /// <summary>
        /// An avatar that is ready for use in sessions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarReady? Ready { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarReady? Ready { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarReady PickReady() => IsReady
            ? Ready!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ready' but the value was {ToString()}.");

        /// <summary>
        /// An avatar that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetAvatarsResponseDataItemAvatarFailed? Failed { get; init; }
#else
        public global::Runway.GetAvatarsResponseDataItemAvatarFailed? Failed { get; }
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
            out global::Runway.GetAvatarsResponseDataItemAvatarFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetAvatarsResponseDataItemAvatarFailed PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Runway.GetAvatarsResponseDataItemAvatarProcessing value) => new DataItem((global::Runway.GetAvatarsResponseDataItemAvatarProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarProcessing?(DataItem @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Runway.GetAvatarsResponseDataItemAvatarProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem FromProcessing(global::Runway.GetAvatarsResponseDataItemAvatarProcessing? value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Runway.GetAvatarsResponseDataItemAvatarReady value) => new DataItem((global::Runway.GetAvatarsResponseDataItemAvatarReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarReady?(DataItem @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Runway.GetAvatarsResponseDataItemAvatarReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem FromReady(global::Runway.GetAvatarsResponseDataItemAvatarReady? value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::Runway.GetAvatarsResponseDataItemAvatarFailed value) => new DataItem((global::Runway.GetAvatarsResponseDataItemAvatarFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetAvatarsResponseDataItemAvatarFailed?(DataItem @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::Runway.GetAvatarsResponseDataItemAvatarFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem FromFailed(global::Runway.GetAvatarsResponseDataItemAvatarFailed? value) => new DataItem(value);

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::Runway.GetAvatarsResponseDataItemDiscriminatorStatus? status,
            global::Runway.GetAvatarsResponseDataItemAvatarProcessing? processing,
            global::Runway.GetAvatarsResponseDataItemAvatarReady? ready,
            global::Runway.GetAvatarsResponseDataItemAvatarFailed? failed
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
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarReady, TResult>? ready = null,
            global::System.Func<global::Runway.GetAvatarsResponseDataItemAvatarFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessing>? processing = null,

            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReady>? ready = null,

            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarFailed>? failed = null,
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
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarProcessing>? processing = null,
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarReady>? ready = null,
            global::System.Action<global::Runway.GetAvatarsResponseDataItemAvatarFailed>? failed = null,
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
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarProcessing),
                Ready,
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarReady),
                Failed,
                typeof(global::Runway.GetAvatarsResponseDataItemAvatarFailed),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetAvatarsResponseDataItemAvatarFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
