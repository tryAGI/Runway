#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateGenerateAudioResponse : global::System.IEquatable<CreateGenerateAudioResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun? DryRun { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? False { get; init; }
#else
        public global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? False { get; }
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
            out global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? value)
        {
            value = False;
            return IsFalse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated PickFalse() => IsFalse
            ? False!
            : throw new global::System.InvalidOperationException($"Expected union variant 'False' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? True { get; init; }
#else
        public global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? True { get; }
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
            out global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? value)
        {
            value = True;
            return IsTrue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun PickTrue() => IsTrue
            ? True!
            : throw new global::System.InvalidOperationException($"Expected union variant 'True' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateAudioResponse(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated value) => new CreateGenerateAudioResponse((global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated?(CreateGenerateAudioResponse @this) => @this.False;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateAudioResponse(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? value)
        {
            False = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateAudioResponse FromFalse(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? value) => new CreateGenerateAudioResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateAudioResponse(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun value) => new CreateGenerateAudioResponse((global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun?(CreateGenerateAudioResponse @this) => @this.True;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateAudioResponse(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? value)
        {
            True = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateAudioResponse FromTrue(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? value) => new CreateGenerateAudioResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateAudioResponse(
            global::Runway.CreateGenerateAudioResponseDiscriminatorDryRun? dryRun,
            global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated? @false,
            global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun? @true
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
            global::System.Func<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated, TResult>? @false = null,
            global::System.Func<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun, TResult>? @true = null,
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
            global::System.Action<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated>? @false = null,

            global::System.Action<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun>? @true = null,
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
            global::System.Action<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated>? @false = null,
            global::System.Action<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun>? @true = null,
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
                typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated),
                True,
                typeof(global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun),
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
        public bool Equals(CreateGenerateAudioResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateAudioResponseRoutedAudioTaskCreated?>.Default.Equals(False, other.False) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateAudioResponseRoutedAudioDryRun?>.Default.Equals(True, other.True) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateGenerateAudioResponse obj1, CreateGenerateAudioResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGenerateAudioResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateGenerateAudioResponse obj1, CreateGenerateAudioResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGenerateAudioResponse o && Equals(o);
        }
    }
}
