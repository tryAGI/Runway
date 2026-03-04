#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Response : global::System.IEquatable<Response>
    {
        /// <summary>
        /// A pending task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant1? Pending { get; init; }
#else
        public global::Runway.ResponseVariant1? Pending { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        /// A throttled task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant2? Throttled { get; init; }
#else
        public global::Runway.ResponseVariant2? Throttled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Throttled))]
#endif
        public bool IsThrottled => Throttled != null;

        /// <summary>
        /// A cancelled or deleted task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant3? Cancelled { get; init; }
#else
        public global::Runway.ResponseVariant3? Cancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cancelled))]
#endif
        public bool IsCancelled => Cancelled != null;

        /// <summary>
        /// A running task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant4? Running { get; init; }
#else
        public global::Runway.ResponseVariant4? Running { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Running))]
#endif
        public bool IsRunning => Running != null;

        /// <summary>
        /// A failed task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant5? Failed { get; init; }
#else
        public global::Runway.ResponseVariant5? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// A succeeded task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant6? Succeeded { get; init; }
#else
        public global::Runway.ResponseVariant6? Succeeded { get; }
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
        public static implicit operator Response(global::Runway.ResponseVariant1 value) => new Response((global::Runway.ResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant1?(Response @this) => @this.Pending;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant1? value)
        {
            Pending = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant2 value) => new Response((global::Runway.ResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant2?(Response @this) => @this.Throttled;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant2? value)
        {
            Throttled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant3 value) => new Response((global::Runway.ResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant3?(Response @this) => @this.Cancelled;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant3? value)
        {
            Cancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant4 value) => new Response((global::Runway.ResponseVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant4?(Response @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant4? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant5 value) => new Response((global::Runway.ResponseVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant5?(Response @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant5? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant6 value) => new Response((global::Runway.ResponseVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant6?(Response @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant6? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Response(
            global::Runway.ResponseVariant1? pending,
            global::Runway.ResponseVariant2? throttled,
            global::Runway.ResponseVariant3? cancelled,
            global::Runway.ResponseVariant4? running,
            global::Runway.ResponseVariant5? failed,
            global::Runway.ResponseVariant6? succeeded
            )
        {
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
            global::System.Func<global::Runway.ResponseVariant1?, TResult>? pending = null,
            global::System.Func<global::Runway.ResponseVariant2?, TResult>? throttled = null,
            global::System.Func<global::Runway.ResponseVariant3?, TResult>? cancelled = null,
            global::System.Func<global::Runway.ResponseVariant4?, TResult>? running = null,
            global::System.Func<global::Runway.ResponseVariant5?, TResult>? failed = null,
            global::System.Func<global::Runway.ResponseVariant6?, TResult>? succeeded = null,
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
            global::System.Action<global::Runway.ResponseVariant1?>? pending = null,
            global::System.Action<global::Runway.ResponseVariant2?>? throttled = null,
            global::System.Action<global::Runway.ResponseVariant3?>? cancelled = null,
            global::System.Action<global::Runway.ResponseVariant4?>? running = null,
            global::System.Action<global::Runway.ResponseVariant5?>? failed = null,
            global::System.Action<global::Runway.ResponseVariant6?>? succeeded = null,
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
                typeof(global::Runway.ResponseVariant1),
                Throttled,
                typeof(global::Runway.ResponseVariant2),
                Cancelled,
                typeof(global::Runway.ResponseVariant3),
                Running,
                typeof(global::Runway.ResponseVariant4),
                Failed,
                typeof(global::Runway.ResponseVariant5),
                Succeeded,
                typeof(global::Runway.ResponseVariant6),
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
        public bool Equals(Response other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant1?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant2?>.Default.Equals(Throttled, other.Throttled) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant3?>.Default.Equals(Cancelled, other.Cancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant4?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant5?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant6?>.Default.Equals(Succeeded, other.Succeeded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Response obj1, Response obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Response>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Response obj1, Response obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Response o && Equals(o);
        }
    }
}
