#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateAvatarsResponse : global::System.IEquatable<CreateAvatarsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateAvatarsResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// An avatar that is still being processed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsResponseAvatarProcessing? Processing { get; init; }
#else
        public global::Runway.CreateAvatarsResponseAvatarProcessing? Processing { get; }
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
            out global::Runway.CreateAvatarsResponseAvatarProcessing? value)
        {
            value = Processing;
            return IsProcessing;
        }

        /// <summary>
        /// An avatar that is ready for use in sessions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsResponseAvatarReady? Ready { get; init; }
#else
        public global::Runway.CreateAvatarsResponseAvatarReady? Ready { get; }
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
            out global::Runway.CreateAvatarsResponseAvatarReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// An avatar that failed to finish processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateAvatarsResponseAvatarFailed? Failed { get; init; }
#else
        public global::Runway.CreateAvatarsResponseAvatarFailed? Failed { get; }
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
            out global::Runway.CreateAvatarsResponseAvatarFailed? value)
        {
            value = Failed;
            return IsFailed;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarProcessing value) => new CreateAvatarsResponse((global::Runway.CreateAvatarsResponseAvatarProcessing?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsResponseAvatarProcessing?(CreateAvatarsResponse @this) => @this.Processing;

        /// <summary>
        /// 
        /// </summary>
        public CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarProcessing? value)
        {
            Processing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarReady value) => new CreateAvatarsResponse((global::Runway.CreateAvatarsResponseAvatarReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsResponseAvatarReady?(CreateAvatarsResponse @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarFailed value) => new CreateAvatarsResponse((global::Runway.CreateAvatarsResponseAvatarFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateAvatarsResponseAvatarFailed?(CreateAvatarsResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public CreateAvatarsResponse(global::Runway.CreateAvatarsResponseAvatarFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAvatarsResponse(
            global::Runway.CreateAvatarsResponseDiscriminatorStatus? status,
            global::Runway.CreateAvatarsResponseAvatarProcessing? processing,
            global::Runway.CreateAvatarsResponseAvatarReady? ready,
            global::Runway.CreateAvatarsResponseAvatarFailed? failed
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
            global::System.Func<global::Runway.CreateAvatarsResponseAvatarProcessing, TResult>? processing = null,
            global::System.Func<global::Runway.CreateAvatarsResponseAvatarReady, TResult>? ready = null,
            global::System.Func<global::Runway.CreateAvatarsResponseAvatarFailed, TResult>? failed = null,
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
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessing>? processing = null,

            global::System.Action<global::Runway.CreateAvatarsResponseAvatarReady>? ready = null,

            global::System.Action<global::Runway.CreateAvatarsResponseAvatarFailed>? failed = null,
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
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarProcessing>? processing = null,
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarReady>? ready = null,
            global::System.Action<global::Runway.CreateAvatarsResponseAvatarFailed>? failed = null,
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
                typeof(global::Runway.CreateAvatarsResponseAvatarProcessing),
                Ready,
                typeof(global::Runway.CreateAvatarsResponseAvatarReady),
                Failed,
                typeof(global::Runway.CreateAvatarsResponseAvatarFailed),
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
        public bool Equals(CreateAvatarsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsResponseAvatarProcessing?>.Default.Equals(Processing, other.Processing) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsResponseAvatarReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateAvatarsResponseAvatarFailed?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAvatarsResponse obj1, CreateAvatarsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAvatarsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAvatarsResponse obj1, CreateAvatarsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAvatarsResponse o && Equals(o);
        }
    }
}
