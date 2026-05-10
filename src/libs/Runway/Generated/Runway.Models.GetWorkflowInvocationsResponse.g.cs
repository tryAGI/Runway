#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetWorkflowInvocationsResponse : global::System.IEquatable<GetWorkflowInvocationsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// A pending workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? Pending { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? Pending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending PickPending() => IsPending
            ? Pending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// A throttled workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? Throttled { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? Throttled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Throttled))]
#endif
        public bool IsThrottled => Throttled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThrottled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? value)
        {
            value = Throttled;
            return IsThrottled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled PickThrottled() => IsThrottled
            ? Throttled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Throttled' but the value was {ToString()}.");

        /// <summary>
        /// A cancelled or deleted workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? Cancelled { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? Cancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cancelled))]
#endif
        public bool IsCancelled => Cancelled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCancelled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? value)
        {
            value = Cancelled;
            return IsCancelled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled PickCancelled() => IsCancelled
            ? Cancelled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cancelled' but the value was {ToString()}.");

        /// <summary>
        /// A running workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? Running { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? Running { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? value)
        {
            value = Running;
            return IsRunning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning PickRunning() => IsRunning
            ? Running!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Running' but the value was {ToString()}.");

        /// <summary>
        /// A failed workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? Failed { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? Failed { get; }
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
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        /// A succeeded workflow invocation
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? Succeeded { get; init; }
#else
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? Succeeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Succeeded))]
#endif
        public bool IsSucceeded => Succeeded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSucceeded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? value)
        {
            value = Succeeded;
            return IsSucceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded PickSucceeded() => IsSucceeded
            ? Succeeded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Succeeded' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending?(GetWorkflowInvocationsResponse @this) => @this.Pending;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? value)
        {
            Pending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromPending(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled?(GetWorkflowInvocationsResponse @this) => @this.Throttled;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? value)
        {
            Throttled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromThrottled(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled?(GetWorkflowInvocationsResponse @this) => @this.Cancelled;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? value)
        {
            Cancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromCancelled(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning?(GetWorkflowInvocationsResponse @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromRunning(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed?(GetWorkflowInvocationsResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromFailed(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded value) => new GetWorkflowInvocationsResponse((global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded?(GetWorkflowInvocationsResponse @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetWorkflowInvocationsResponse FromSucceeded(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? value) => new GetWorkflowInvocationsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public GetWorkflowInvocationsResponse(
            global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus? status,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending? pending,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled? throttled,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled? cancelled,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning? running,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed? failed,
            global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded? succeeded
            )
        {
            Status = status;

            Pending = pending;
            Throttled = throttled;
            Cancelled = cancelled;
            Running = running;
            Failed = failed;
            Succeeded = succeeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Succeeded as object ??
            Failed as object ??
            Running as object ??
            Cancelled as object ??
            Throttled as object ??
            Pending as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pending?.ToString() ??
            Throttled?.ToString() ??
            Cancelled?.ToString() ??
            Running?.ToString() ??
            Failed?.ToString() ??
            Succeeded?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPending && !IsThrottled && !IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && IsThrottled && !IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && IsCancelled && !IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && IsRunning && !IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && !IsRunning && IsFailed && !IsSucceeded || !IsPending && !IsThrottled && !IsCancelled && !IsRunning && !IsFailed && IsSucceeded;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending, TResult>? pending = null,
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled, TResult>? throttled = null,
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled, TResult>? cancelled = null,
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning, TResult>? running = null,
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed, TResult>? failed = null,
            global::System.Func<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded, TResult>? succeeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending && pending != null)
            {
                return pending(Pending!);
            }
            else if (IsThrottled && throttled != null)
            {
                return throttled(Throttled!);
            }
            else if (IsCancelled && cancelled != null)
            {
                return cancelled(Cancelled!);
            }
            else if (IsRunning && running != null)
            {
                return running(Running!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }
            else if (IsSucceeded && succeeded != null)
            {
                return succeeded(Succeeded!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending>? pending = null,

            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled>? throttled = null,

            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled>? cancelled = null,

            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning>? running = null,

            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed>? failed = null,

            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded>? succeeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending)
            {
                pending?.Invoke(Pending!);
            }
            else if (IsThrottled)
            {
                throttled?.Invoke(Throttled!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsSucceeded)
            {
                succeeded?.Invoke(Succeeded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending>? pending = null,
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled>? throttled = null,
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled>? cancelled = null,
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning>? running = null,
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed>? failed = null,
            global::System.Action<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded>? succeeded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPending)
            {
                pending?.Invoke(Pending!);
            }
            else if (IsThrottled)
            {
                throttled?.Invoke(Throttled!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsSucceeded)
            {
                succeeded?.Invoke(Succeeded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Pending,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending),
                Throttled,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled),
                Cancelled,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled),
                Running,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning),
                Failed,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed),
                Succeeded,
                typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded),
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
        public bool Equals(GetWorkflowInvocationsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled?>.Default.Equals(Throttled, other.Throttled) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled?>.Default.Equals(Cancelled, other.Cancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded?>.Default.Equals(Succeeded, other.Succeeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetWorkflowInvocationsResponse obj1, GetWorkflowInvocationsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetWorkflowInvocationsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetWorkflowInvocationsResponse obj1, GetWorkflowInvocationsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetWorkflowInvocationsResponse o && Equals(o);
        }
    }
}
