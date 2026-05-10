#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetVoicesResponse2 : global::System.IEquatable<GetVoicesResponse2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetVoicesResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// A voice that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseVoiceProcessing? Processing { get; init; }
#else
        public global::Runway.GetVoicesResponseVoiceProcessing? Processing { get; }
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
            out global::Runway.GetVoicesResponseVoiceProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// A voice that is ready for use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseVoiceReady? Ready { get; init; }
#else
        public global::Runway.GetVoicesResponseVoiceReady? Ready { get; }
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
            out global::Runway.GetVoicesResponseVoiceReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// A voice that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetVoicesResponseVoiceFailed? Failed { get; init; }
#else
        public global::Runway.GetVoicesResponseVoiceFailed? Failed { get; }
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
            out global::Runway.GetVoicesResponseVoiceFailed? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceProcessing value) => new GetVoicesResponse2((global::Runway.GetVoicesResponseVoiceProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseVoiceProcessing?(GetVoicesResponse2 @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetVoicesResponse2 FromProcessing(global::Runway.GetVoicesResponseVoiceProcessing? value) => new GetVoicesResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceReady value) => new GetVoicesResponse2((global::Runway.GetVoicesResponseVoiceReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseVoiceReady?(GetVoicesResponse2 @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetVoicesResponse2 FromReady(global::Runway.GetVoicesResponseVoiceReady? value) => new GetVoicesResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceFailed value) => new GetVoicesResponse2((global::Runway.GetVoicesResponseVoiceFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetVoicesResponseVoiceFailed?(GetVoicesResponse2 @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetVoicesResponse2(global::Runway.GetVoicesResponseVoiceFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetVoicesResponse2 FromFailed(global::Runway.GetVoicesResponseVoiceFailed? value) => new GetVoicesResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public GetVoicesResponse2(
            global::Runway.GetVoicesResponseDiscriminatorStatus? status,
            global::Runway.GetVoicesResponseVoiceProcessing? processing,
            global::Runway.GetVoicesResponseVoiceReady? ready,
            global::Runway.GetVoicesResponseVoiceFailed? failed
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
            global::System.Func<global::Runway.GetVoicesResponseVoiceProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.GetVoicesResponseVoiceReady, TResult>? ready = null,
            global::System.Func<global::Runway.GetVoicesResponseVoiceFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.GetVoicesResponseVoiceProcessing>? processing = null,

            global::System.Action<global::Runway.GetVoicesResponseVoiceReady>? ready = null,

            global::System.Action<global::Runway.GetVoicesResponseVoiceFailed>? failed = null,
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
            global::System.Action<global::Runway.GetVoicesResponseVoiceProcessing>? processing = null,
            global::System.Action<global::Runway.GetVoicesResponseVoiceReady>? ready = null,
            global::System.Action<global::Runway.GetVoicesResponseVoiceFailed>? failed = null,
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
                typeof(global::Runway.GetVoicesResponseVoiceProcessing),
                Ready,
                typeof(global::Runway.GetVoicesResponseVoiceReady),
                Failed,
                typeof(global::Runway.GetVoicesResponseVoiceFailed),
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
        public bool Equals(GetVoicesResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseVoiceProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseVoiceReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetVoicesResponseVoiceFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetVoicesResponse2 obj1, GetVoicesResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetVoicesResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetVoicesResponse2 obj1, GetVoicesResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetVoicesResponse2 o && Equals(o);
        }
    }
}
