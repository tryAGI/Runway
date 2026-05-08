#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PatchVoicesResponse : global::System.IEquatable<PatchVoicesResponse>
    {
        /// <summary>
        /// A voice that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchVoicesResponseVoiceProcessing? Processing { get; init; }
#else
        public global::Runway.PatchVoicesResponseVoiceProcessing? Processing { get; }
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
            out global::Runway.PatchVoicesResponseVoiceProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// A voice that is ready for use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchVoicesResponseVoiceReady? Ready { get; init; }
#else
        public global::Runway.PatchVoicesResponseVoiceReady? Ready { get; }
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
            out global::Runway.PatchVoicesResponseVoiceReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// A voice that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.PatchVoicesResponseVoiceFailed? Failed { get; init; }
#else
        public global::Runway.PatchVoicesResponseVoiceFailed? Failed { get; }
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
            out global::Runway.PatchVoicesResponseVoiceFailed? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceProcessing value) => new PatchVoicesResponse((global::Runway.PatchVoicesResponseVoiceProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchVoicesResponseVoiceProcessing?(PatchVoicesResponse @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceReady value) => new PatchVoicesResponse((global::Runway.PatchVoicesResponseVoiceReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchVoicesResponseVoiceReady?(PatchVoicesResponse @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceFailed value) => new PatchVoicesResponse((global::Runway.PatchVoicesResponseVoiceFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.PatchVoicesResponseVoiceFailed?(PatchVoicesResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public PatchVoicesResponse(global::Runway.PatchVoicesResponseVoiceFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PatchVoicesResponse(
            global::Runway.PatchVoicesResponseVoiceProcessing? processing,
            global::Runway.PatchVoicesResponseVoiceReady? ready,
            global::Runway.PatchVoicesResponseVoiceFailed? failed
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
            global::System.Func<global::Runway.PatchVoicesResponseVoiceProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.PatchVoicesResponseVoiceReady, TResult>? ready = null,
            global::System.Func<global::Runway.PatchVoicesResponseVoiceFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.PatchVoicesResponseVoiceProcessing>? processing = null,

            global::System.Action<global::Runway.PatchVoicesResponseVoiceReady>? ready = null,

            global::System.Action<global::Runway.PatchVoicesResponseVoiceFailed>? failed = null,
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
            global::System.Action<global::Runway.PatchVoicesResponseVoiceProcessing>? processing = null,
            global::System.Action<global::Runway.PatchVoicesResponseVoiceReady>? ready = null,
            global::System.Action<global::Runway.PatchVoicesResponseVoiceFailed>? failed = null,
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
                typeof(global::Runway.PatchVoicesResponseVoiceProcessing),
                Ready,
                typeof(global::Runway.PatchVoicesResponseVoiceReady),
                Failed,
                typeof(global::Runway.PatchVoicesResponseVoiceFailed),
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
        public bool Equals(PatchVoicesResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchVoicesResponseVoiceProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchVoicesResponseVoiceReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.PatchVoicesResponseVoiceFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PatchVoicesResponse obj1, PatchVoicesResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PatchVoicesResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PatchVoicesResponse obj1, PatchVoicesResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PatchVoicesResponse o && Equals(o);
        }
    }
}
