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
        public global::Runway.ResponseVariant1? PENDING { get; init; }
#else
        public global::Runway.ResponseVariant1? PENDING { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PENDING))]
#endif
        public bool IsPENDING => PENDING != null;

        /// <summary>
        /// A throttled task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant2? THROTTLED { get; init; }
#else
        public global::Runway.ResponseVariant2? THROTTLED { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(THROTTLED))]
#endif
        public bool IsTHROTTLED => THROTTLED != null;

        /// <summary>
        /// A cancelled or deleted task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant3? CANCELLED { get; init; }
#else
        public global::Runway.ResponseVariant3? CANCELLED { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CANCELLED))]
#endif
        public bool IsCANCELLED => CANCELLED != null;

        /// <summary>
        /// A running task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant4? RUNNING { get; init; }
#else
        public global::Runway.ResponseVariant4? RUNNING { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RUNNING))]
#endif
        public bool IsRUNNING => RUNNING != null;

        /// <summary>
        /// A failed task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant5? FAILED { get; init; }
#else
        public global::Runway.ResponseVariant5? FAILED { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FAILED))]
#endif
        public bool IsFAILED => FAILED != null;

        /// <summary>
        /// A succeeded task
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.ResponseVariant6? SUCCEEDED { get; init; }
#else
        public global::Runway.ResponseVariant6? SUCCEEDED { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SUCCEEDED))]
#endif
        public bool IsSUCCEEDED => SUCCEEDED != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant1 value) => new Response((global::Runway.ResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant1?(Response @this) => @this.PENDING;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant1? value)
        {
            PENDING = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant2 value) => new Response((global::Runway.ResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant2?(Response @this) => @this.THROTTLED;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant2? value)
        {
            THROTTLED = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant3 value) => new Response((global::Runway.ResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant3?(Response @this) => @this.CANCELLED;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant3? value)
        {
            CANCELLED = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant4 value) => new Response((global::Runway.ResponseVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant4?(Response @this) => @this.RUNNING;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant4? value)
        {
            RUNNING = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant5 value) => new Response((global::Runway.ResponseVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant5?(Response @this) => @this.FAILED;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant5? value)
        {
            FAILED = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Response(global::Runway.ResponseVariant6 value) => new Response((global::Runway.ResponseVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.ResponseVariant6?(Response @this) => @this.SUCCEEDED;

        /// <summary>
        /// 
        /// </summary>
        public Response(global::Runway.ResponseVariant6? value)
        {
            SUCCEEDED = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Response(
            global::Runway.ResponseVariant1? pENDING,
            global::Runway.ResponseVariant2? tHROTTLED,
            global::Runway.ResponseVariant3? cANCELLED,
            global::Runway.ResponseVariant4? rUNNING,
            global::Runway.ResponseVariant5? fAILED,
            global::Runway.ResponseVariant6? sUCCEEDED
            )
        {
            PENDING = pENDING;
            THROTTLED = tHROTTLED;
            CANCELLED = cANCELLED;
            RUNNING = rUNNING;
            FAILED = fAILED;
            SUCCEEDED = sUCCEEDED;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SUCCEEDED as object ??
            FAILED as object ??
            RUNNING as object ??
            CANCELLED as object ??
            THROTTLED as object ??
            PENDING as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PENDING?.ToString() ??
            THROTTLED?.ToString() ??
            CANCELLED?.ToString() ??
            RUNNING?.ToString() ??
            FAILED?.ToString() ??
            SUCCEEDED?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPENDING && !IsTHROTTLED && !IsCANCELLED && !IsRUNNING && !IsFAILED && !IsSUCCEEDED || !IsPENDING && IsTHROTTLED && !IsCANCELLED && !IsRUNNING && !IsFAILED && !IsSUCCEEDED || !IsPENDING && !IsTHROTTLED && IsCANCELLED && !IsRUNNING && !IsFAILED && !IsSUCCEEDED || !IsPENDING && !IsTHROTTLED && !IsCANCELLED && IsRUNNING && !IsFAILED && !IsSUCCEEDED || !IsPENDING && !IsTHROTTLED && !IsCANCELLED && !IsRUNNING && IsFAILED && !IsSUCCEEDED || !IsPENDING && !IsTHROTTLED && !IsCANCELLED && !IsRUNNING && !IsFAILED && IsSUCCEEDED;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.ResponseVariant1?, TResult>? pENDING = null,
            global::System.Func<global::Runway.ResponseVariant2?, TResult>? tHROTTLED = null,
            global::System.Func<global::Runway.ResponseVariant3?, TResult>? cANCELLED = null,
            global::System.Func<global::Runway.ResponseVariant4?, TResult>? rUNNING = null,
            global::System.Func<global::Runway.ResponseVariant5?, TResult>? fAILED = null,
            global::System.Func<global::Runway.ResponseVariant6?, TResult>? sUCCEEDED = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPENDING && pENDING != null)
            {
                return pENDING(PENDING!);
            }
            else if (IsTHROTTLED && tHROTTLED != null)
            {
                return tHROTTLED(THROTTLED!);
            }
            else if (IsCANCELLED && cANCELLED != null)
            {
                return cANCELLED(CANCELLED!);
            }
            else if (IsRUNNING && rUNNING != null)
            {
                return rUNNING(RUNNING!);
            }
            else if (IsFAILED && fAILED != null)
            {
                return fAILED(FAILED!);
            }
            else if (IsSUCCEEDED && sUCCEEDED != null)
            {
                return sUCCEEDED(SUCCEEDED!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.ResponseVariant1?>? pENDING = null,
            global::System.Action<global::Runway.ResponseVariant2?>? tHROTTLED = null,
            global::System.Action<global::Runway.ResponseVariant3?>? cANCELLED = null,
            global::System.Action<global::Runway.ResponseVariant4?>? rUNNING = null,
            global::System.Action<global::Runway.ResponseVariant5?>? fAILED = null,
            global::System.Action<global::Runway.ResponseVariant6?>? sUCCEEDED = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPENDING)
            {
                pENDING?.Invoke(PENDING!);
            }
            else if (IsTHROTTLED)
            {
                tHROTTLED?.Invoke(THROTTLED!);
            }
            else if (IsCANCELLED)
            {
                cANCELLED?.Invoke(CANCELLED!);
            }
            else if (IsRUNNING)
            {
                rUNNING?.Invoke(RUNNING!);
            }
            else if (IsFAILED)
            {
                fAILED?.Invoke(FAILED!);
            }
            else if (IsSUCCEEDED)
            {
                sUCCEEDED?.Invoke(SUCCEEDED!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PENDING,
                typeof(global::Runway.ResponseVariant1),
                THROTTLED,
                typeof(global::Runway.ResponseVariant2),
                CANCELLED,
                typeof(global::Runway.ResponseVariant3),
                RUNNING,
                typeof(global::Runway.ResponseVariant4),
                FAILED,
                typeof(global::Runway.ResponseVariant5),
                SUCCEEDED,
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant1?>.Default.Equals(PENDING, other.PENDING) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant2?>.Default.Equals(THROTTLED, other.THROTTLED) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant3?>.Default.Equals(CANCELLED, other.CANCELLED) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant4?>.Default.Equals(RUNNING, other.RUNNING) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant5?>.Default.Equals(FAILED, other.FAILED) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.ResponseVariant6?>.Default.Equals(SUCCEEDED, other.SUCCEEDED) 
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
