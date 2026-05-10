#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem2 : global::System.IEquatable<DataItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetVoicesResponseDataItemDiscriminatorStatus? Status { get; }

        /// <summary>
        /// A voice that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseDataItemVoiceProcessing? Processing { get; init; }
#else
        public global::Runway.GetVoicesResponseDataItemVoiceProcessing? Processing { get; }
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
            out global::Runway.GetVoicesResponseDataItemVoiceProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetVoicesResponseDataItemVoiceProcessing PickProcessing() => IsProcessing
            ? Processing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Processing' but the value was {ToString()}.");

        /// <summary>
        /// A voice that is ready for use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseDataItemVoiceReady? Ready { get; init; }
#else
        public global::Runway.GetVoicesResponseDataItemVoiceReady? Ready { get; }
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
            out global::Runway.GetVoicesResponseDataItemVoiceReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetVoicesResponseDataItemVoiceReady PickReady() => IsReady
            ? Ready!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ready' but the value was {ToString()}.");

        /// <summary>
        /// A voice that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseDataItemVoiceFailed? Failed { get; init; }
#else
        public global::Runway.GetVoicesResponseDataItemVoiceFailed? Failed { get; }
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
            out global::Runway.GetVoicesResponseDataItemVoiceFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetVoicesResponseDataItemVoiceFailed PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Runway.GetVoicesResponseDataItemVoiceProcessing value) => new DataItem2((global::Runway.GetVoicesResponseDataItemVoiceProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseDataItemVoiceProcessing?(DataItem2 @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Runway.GetVoicesResponseDataItemVoiceProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem2 FromProcessing(global::Runway.GetVoicesResponseDataItemVoiceProcessing? value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Runway.GetVoicesResponseDataItemVoiceReady value) => new DataItem2((global::Runway.GetVoicesResponseDataItemVoiceReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseDataItemVoiceReady?(DataItem2 @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Runway.GetVoicesResponseDataItemVoiceReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem2 FromReady(global::Runway.GetVoicesResponseDataItemVoiceReady? value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Runway.GetVoicesResponseDataItemVoiceFailed value) => new DataItem2((global::Runway.GetVoicesResponseDataItemVoiceFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseDataItemVoiceFailed?(DataItem2 @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Runway.GetVoicesResponseDataItemVoiceFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem2 FromFailed(global::Runway.GetVoicesResponseDataItemVoiceFailed? value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(
            global::Runway.GetVoicesResponseDataItemDiscriminatorStatus? status,
            global::Runway.GetVoicesResponseDataItemVoiceProcessing? processing,
            global::Runway.GetVoicesResponseDataItemVoiceReady? ready,
            global::Runway.GetVoicesResponseDataItemVoiceFailed? failed
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
            global::System.Func<global::Runway.GetVoicesResponseDataItemVoiceProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.GetVoicesResponseDataItemVoiceReady, TResult>? ready = null,
            global::System.Func<global::Runway.GetVoicesResponseDataItemVoiceFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceProcessing>? processing = null,

            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceReady>? ready = null,

            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceFailed>? failed = null,
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
            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceProcessing>? processing = null,
            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceReady>? ready = null,
            global::System.Action<global::Runway.GetVoicesResponseDataItemVoiceFailed>? failed = null,
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
                typeof(global::Runway.GetVoicesResponseDataItemVoiceProcessing),
                Ready,
                typeof(global::Runway.GetVoicesResponseDataItemVoiceReady),
                Failed,
                typeof(global::Runway.GetVoicesResponseDataItemVoiceFailed),
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
        public bool Equals(DataItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseDataItemVoiceProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseDataItemVoiceReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseDataItemVoiceFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem2 obj1, DataItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem2 obj1, DataItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem2 o && Equals(o);
        }
    }
}
