#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateGenerateVideoResponse : global::System.IEquatable<CreateGenerateVideoResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun? DryRun { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? False { get; init; }
#else
        public global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? False { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(False))]
#endif
        public bool IsFalse => False != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFalse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? value)
        {
            value = False;
            return IsFalse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated PickFalse() => IsFalse
            ? False!
            : throw new global::System.InvalidOperationException($"Expected union variant 'False' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? True { get; init; }
#else
        public global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? True { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(True))]
#endif
        public bool IsTrue => True != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? value)
        {
            value = True;
            return IsTrue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun PickTrue() => IsTrue
            ? True!
            : throw new global::System.InvalidOperationException($"Expected union variant 'True' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateVideoResponse(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated value) => new CreateGenerateVideoResponse((global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated?(CreateGenerateVideoResponse @this) => @this.False;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateVideoResponse(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? value)
        {
            False = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateVideoResponse FromFalse(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? value) => new CreateGenerateVideoResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateVideoResponse(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun value) => new CreateGenerateVideoResponse((global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun?(CreateGenerateVideoResponse @this) => @this.True;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateVideoResponse(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? value)
        {
            True = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateVideoResponse FromTrue(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? value) => new CreateGenerateVideoResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateVideoResponse(
            global::Runway.CreateGenerateVideoResponseDiscriminatorDryRun? dryRun,
            global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated? @false,
            global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun? @true
            )
        {
            DryRun = dryRun;

            False = @false;
            True = @true;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            True as object ??
            False as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            False?.ToString() ??
            True?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFalse && !IsTrue || !IsFalse && IsTrue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated, TResult>? @false = null,
            global::System.Func<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun, TResult>? @true = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFalse && @false != null)
            {
                return @false(False!);
            }
            else if (IsTrue && @true != null)
            {
                return @true(True!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated>? @false = null,

            global::System.Action<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun>? @true = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFalse)
            {
                @false?.Invoke(False!);
            }
            else if (IsTrue)
            {
                @true?.Invoke(True!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated>? @false = null,
            global::System.Action<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun>? @true = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFalse)
            {
                @false?.Invoke(False!);
            }
            else if (IsTrue)
            {
                @true?.Invoke(True!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                False,
                typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated),
                True,
                typeof(global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun),
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
        public bool Equals(CreateGenerateVideoResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateVideoResponseRoutedVideoTaskCreated?>.Default.Equals(False, other.False) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateVideoResponseRoutedVideoDryRun?>.Default.Equals(True, other.True) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateGenerateVideoResponse obj1, CreateGenerateVideoResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGenerateVideoResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateGenerateVideoResponse obj1, CreateGenerateVideoResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGenerateVideoResponse o && Equals(o);
        }
    }
}
