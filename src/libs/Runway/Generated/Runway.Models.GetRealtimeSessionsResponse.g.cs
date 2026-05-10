#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetRealtimeSessionsResponse : global::System.IEquatable<GetRealtimeSessionsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// A session that is being provisioned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionNotReady? NotReady { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionNotReady? NotReady { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotReady))]
#endif
        public bool IsNotReady => NotReady != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNotReady(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetRealtimeSessionsResponseSessionNotReady? value)
        {
            value = NotReady;
            return IsNotReady;
        }

        /// <summary>
        /// A session that is ready to connect.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionReady? Ready { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionReady? Ready { get; }
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
            out global::Runway.GetRealtimeSessionsResponseSessionReady? value)
        {
            value = Ready;
            return IsReady;
        }

        /// <summary>
        /// A session with an active WebRTC connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionRunning? Running { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionRunning? Running { get; }
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
            out global::Runway.GetRealtimeSessionsResponseSessionRunning? value)
        {
            value = Running;
            return IsRunning;
        }

        /// <summary>
        /// A session that ended normally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionCompleted? Completed { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionCompleted? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetRealtimeSessionsResponseSessionCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        /// A session that encountered an error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionFailed? Failed { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionFailed? Failed { get; }
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
            out global::Runway.GetRealtimeSessionsResponseSessionFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// A session that was explicitly cancelled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRealtimeSessionsResponseSessionCancelled? Cancelled { get; init; }
#else
        public global::Runway.GetRealtimeSessionsResponseSessionCancelled? Cancelled { get; }
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
            out global::Runway.GetRealtimeSessionsResponseSessionCancelled? value)
        {
            value = Cancelled;
            return IsCancelled;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionNotReady value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionNotReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionNotReady?(GetRealtimeSessionsResponse @this) => @this.NotReady;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionNotReady? value)
        {
            NotReady = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionReady value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionReady?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionReady?(GetRealtimeSessionsResponse @this) => @this.Ready;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionReady? value)
        {
            Ready = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionRunning value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionRunning?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionRunning?(GetRealtimeSessionsResponse @this) => @this.Running;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionRunning? value)
        {
            Running = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionCompleted value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionCompleted?(GetRealtimeSessionsResponse @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionFailed value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionFailed?(GetRealtimeSessionsResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionCancelled value) => new GetRealtimeSessionsResponse((global::Runway.GetRealtimeSessionsResponseSessionCancelled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRealtimeSessionsResponseSessionCancelled?(GetRealtimeSessionsResponse @this) => @this.Cancelled;

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(global::Runway.GetRealtimeSessionsResponseSessionCancelled? value)
        {
            Cancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetRealtimeSessionsResponse(
            global::Runway.GetRealtimeSessionsResponseDiscriminatorStatus? status,
            global::Runway.GetRealtimeSessionsResponseSessionNotReady? notReady,
            global::Runway.GetRealtimeSessionsResponseSessionReady? ready,
            global::Runway.GetRealtimeSessionsResponseSessionRunning? running,
            global::Runway.GetRealtimeSessionsResponseSessionCompleted? completed,
            global::Runway.GetRealtimeSessionsResponseSessionFailed? failed,
            global::Runway.GetRealtimeSessionsResponseSessionCancelled? cancelled
            )
        {
            Status = status;

            NotReady = notReady;
            Ready = ready;
            Running = running;
            Completed = completed;
            Failed = failed;
            Cancelled = cancelled;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Cancelled as object ??
            Failed as object ??
            Completed as object ??
            Running as object ??
            Ready as object ??
            NotReady as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NotReady?.ToString() ??
            Ready?.ToString() ??
            Running?.ToString() ??
            Completed?.ToString() ??
            Failed?.ToString() ??
            Cancelled?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNotReady && !IsReady && !IsRunning && !IsCompleted && !IsFailed && !IsCancelled || !IsNotReady && IsReady && !IsRunning && !IsCompleted && !IsFailed && !IsCancelled || !IsNotReady && !IsReady && IsRunning && !IsCompleted && !IsFailed && !IsCancelled || !IsNotReady && !IsReady && !IsRunning && IsCompleted && !IsFailed && !IsCancelled || !IsNotReady && !IsReady && !IsRunning && !IsCompleted && IsFailed && !IsCancelled || !IsNotReady && !IsReady && !IsRunning && !IsCompleted && !IsFailed && IsCancelled;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionNotReady, TResult>? notReady = null,
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionReady, TResult>? ready = null,
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionRunning, TResult>? running = null,
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionCompleted, TResult>? completed = null,
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionFailed, TResult>? failed = null,
            global::System.Func<global::Runway.GetRealtimeSessionsResponseSessionCancelled, TResult>? cancelled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNotReady && notReady != null)
            {
                return notReady(NotReady!);
            }
            else if (IsReady && ready != null)
            {
                return ready(Ready!);
            }
            else if (IsRunning && running != null)
            {
                return running(Running!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }
            else if (IsCancelled && cancelled != null)
            {
                return cancelled(Cancelled!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionNotReady>? notReady = null,

            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionReady>? ready = null,

            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionRunning>? running = null,

            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionCompleted>? completed = null,

            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionFailed>? failed = null,

            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionCancelled>? cancelled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNotReady)
            {
                notReady?.Invoke(NotReady!);
            }
            else if (IsReady)
            {
                ready?.Invoke(Ready!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionNotReady>? notReady = null,
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionReady>? ready = null,
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionRunning>? running = null,
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionCompleted>? completed = null,
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionFailed>? failed = null,
            global::System.Action<global::Runway.GetRealtimeSessionsResponseSessionCancelled>? cancelled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNotReady)
            {
                notReady?.Invoke(NotReady!);
            }
            else if (IsReady)
            {
                ready?.Invoke(Ready!);
            }
            else if (IsRunning)
            {
                running?.Invoke(Running!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NotReady,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionNotReady),
                Ready,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionReady),
                Running,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionRunning),
                Completed,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionCompleted),
                Failed,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionFailed),
                Cancelled,
                typeof(global::Runway.GetRealtimeSessionsResponseSessionCancelled),
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
        public bool Equals(GetRealtimeSessionsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionNotReady?>.Default.Equals(NotReady, other.NotReady) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionReady?>.Default.Equals(Ready, other.Ready) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionRunning?>.Default.Equals(Running, other.Running) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRealtimeSessionsResponseSessionCancelled?>.Default.Equals(Cancelled, other.Cancelled) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetRealtimeSessionsResponse obj1, GetRealtimeSessionsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetRealtimeSessionsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetRealtimeSessionsResponse obj1, GetRealtimeSessionsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRealtimeSessionsResponse o && Equals(o);
        }
    }
}
