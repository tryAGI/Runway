#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateGenerateImageResponse : global::System.IEquatable<CreateGenerateImageResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateImageResponseDiscriminatorDryRun? DryRun { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? False { get; init; }
#else
        public global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? False { get; }
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
            out global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? value)
        {
            value = False;
            return IsFalse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated PickFalse() => IsFalse
            ? False!
            : throw new global::System.InvalidOperationException($"Expected union variant 'False' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateGenerateImageResponseRoutedImageDryRun? True { get; init; }
#else
        public global::Runway.CreateGenerateImageResponseRoutedImageDryRun? True { get; }
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
            out global::Runway.CreateGenerateImageResponseRoutedImageDryRun? value)
        {
            value = True;
            return IsTrue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateGenerateImageResponseRoutedImageDryRun PickTrue() => IsTrue
            ? True!
            : throw new global::System.InvalidOperationException($"Expected union variant 'True' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateImageResponse(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated value) => new CreateGenerateImageResponse((global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated?(CreateGenerateImageResponse @this) => @this.False;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateImageResponse(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? value)
        {
            False = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateImageResponse FromFalse(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? value) => new CreateGenerateImageResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGenerateImageResponse(global::Runway.CreateGenerateImageResponseRoutedImageDryRun value) => new CreateGenerateImageResponse((global::Runway.CreateGenerateImageResponseRoutedImageDryRun?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateGenerateImageResponseRoutedImageDryRun?(CreateGenerateImageResponse @this) => @this.True;

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateImageResponse(global::Runway.CreateGenerateImageResponseRoutedImageDryRun? value)
        {
            True = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGenerateImageResponse FromTrue(global::Runway.CreateGenerateImageResponseRoutedImageDryRun? value) => new CreateGenerateImageResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateGenerateImageResponse(
            global::Runway.CreateGenerateImageResponseDiscriminatorDryRun? dryRun,
            global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated? @false,
            global::Runway.CreateGenerateImageResponseRoutedImageDryRun? @true
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
            global::System.Func<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated, TResult>? @false = null,
            global::System.Func<global::Runway.CreateGenerateImageResponseRoutedImageDryRun, TResult>? @true = null,
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
            global::System.Action<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated>? @false = null,

            global::System.Action<global::Runway.CreateGenerateImageResponseRoutedImageDryRun>? @true = null,
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
            global::System.Action<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated>? @false = null,
            global::System.Action<global::Runway.CreateGenerateImageResponseRoutedImageDryRun>? @true = null,
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
                typeof(global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated),
                True,
                typeof(global::Runway.CreateGenerateImageResponseRoutedImageDryRun),
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
        public bool Equals(CreateGenerateImageResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateImageResponseRoutedImageTaskCreated?>.Default.Equals(False, other.False) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateGenerateImageResponseRoutedImageDryRun?>.Default.Equals(True, other.True) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateGenerateImageResponse obj1, CreateGenerateImageResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGenerateImageResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateGenerateImageResponse obj1, CreateGenerateImageResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGenerateImageResponse o && Equals(o);
        }
    }
}
