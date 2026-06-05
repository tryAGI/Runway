#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateVideoToVideoRequest : global::System.IEquatable<CreateVideoToVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestGen4Aleph? Gen4Aleph { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestGen4Aleph? Gen4Aleph { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Aleph))]
#endif
        public bool IsGen4Aleph => Gen4Aleph != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGen4Aleph(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestGen4Aleph? value)
        {
            value = Gen4Aleph;
            return IsGen4Aleph;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestGen4Aleph PickGen4Aleph() => IsGen4Aleph
            ? Gen4Aleph!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen4Aleph' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestAleph2? Aleph2 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestAleph2? Aleph2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Aleph2))]
#endif
        public bool IsAleph2 => Aleph2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAleph2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestAleph2? value)
        {
            value = Aleph2;
            return IsAleph2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestAleph2 PickAleph2() => IsAleph2
            ? Aleph2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aleph2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestSeedance2? Seedance2 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestSeedance2? Seedance2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedance2))]
#endif
        public bool IsSeedance2 => Seedance2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSeedance2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestSeedance2? value)
        {
            value = Seedance2;
            return IsSeedance2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestSeedance2 PickSeedance2() => IsSeedance2
            ? Seedance2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestSeedance2Fast? Seedance2Fast { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestSeedance2Fast? Seedance2Fast { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedance2Fast))]
#endif
        public bool IsSeedance2Fast => Seedance2Fast != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSeedance2Fast(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestSeedance2Fast? value)
        {
            value = Seedance2Fast;
            return IsSeedance2Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestSeedance2Fast PickSeedance2Fast() => IsSeedance2Fast
            ? Seedance2Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Fast' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGen4Aleph value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestGen4Aleph?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestGen4Aleph?(CreateVideoToVideoRequest @this) => @this.Gen4Aleph;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGen4Aleph? value)
        {
            Gen4Aleph = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromGen4Aleph(global::Runway.CreateVideoToVideoRequestGen4Aleph? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestAleph2 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestAleph2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestAleph2?(CreateVideoToVideoRequest @this) => @this.Aleph2;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestAleph2? value)
        {
            Aleph2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromAleph2(global::Runway.CreateVideoToVideoRequestAleph2? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestSeedance2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestSeedance2?(CreateVideoToVideoRequest @this) => @this.Seedance2;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2? value)
        {
            Seedance2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromSeedance2(global::Runway.CreateVideoToVideoRequestSeedance2? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2Fast value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestSeedance2Fast?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestSeedance2Fast?(CreateVideoToVideoRequest @this) => @this.Seedance2Fast;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2Fast? value)
        {
            Seedance2Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromSeedance2Fast(global::Runway.CreateVideoToVideoRequestSeedance2Fast? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(
            global::Runway.CreateVideoToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateVideoToVideoRequestGen4Aleph? gen4Aleph,
            global::Runway.CreateVideoToVideoRequestAleph2? aleph2,
            global::Runway.CreateVideoToVideoRequestSeedance2? seedance2,
            global::Runway.CreateVideoToVideoRequestSeedance2Fast? seedance2Fast
            )
        {
            Model = model;

            Gen4Aleph = gen4Aleph;
            Aleph2 = aleph2;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Seedance2Fast as object ??
            Seedance2 as object ??
            Aleph2 as object ??
            Gen4Aleph as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gen4Aleph?.ToString() ??
            Aleph2?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen4Aleph && !IsAleph2 && !IsSeedance2 && !IsSeedance2Fast || !IsGen4Aleph && IsAleph2 && !IsSeedance2 && !IsSeedance2Fast || !IsGen4Aleph && !IsAleph2 && IsSeedance2 && !IsSeedance2Fast || !IsGen4Aleph && !IsAleph2 && !IsSeedance2 && IsSeedance2Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoToVideoRequestGen4Aleph, TResult>? gen4Aleph = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestAleph2, TResult>? aleph2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Aleph && gen4Aleph != null)
            {
                return gen4Aleph(Gen4Aleph!);
            }
            else if (IsAleph2 && aleph2 != null)
            {
                return aleph2(Aleph2!);
            }
            else if (IsSeedance2 && seedance2 != null)
            {
                return seedance2(Seedance2!);
            }
            else if (IsSeedance2Fast && seedance2Fast != null)
            {
                return seedance2Fast(Seedance2Fast!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoToVideoRequestGen4Aleph>? gen4Aleph = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestAleph2>? aleph2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Aleph)
            {
                gen4Aleph?.Invoke(Gen4Aleph!);
            }
            else if (IsAleph2)
            {
                aleph2?.Invoke(Aleph2!);
            }
            else if (IsSeedance2)
            {
                seedance2?.Invoke(Seedance2!);
            }
            else if (IsSeedance2Fast)
            {
                seedance2Fast?.Invoke(Seedance2Fast!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoToVideoRequestGen4Aleph>? gen4Aleph = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestAleph2>? aleph2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen4Aleph)
            {
                gen4Aleph?.Invoke(Gen4Aleph!);
            }
            else if (IsAleph2)
            {
                aleph2?.Invoke(Aleph2!);
            }
            else if (IsSeedance2)
            {
                seedance2?.Invoke(Seedance2!);
            }
            else if (IsSeedance2Fast)
            {
                seedance2Fast?.Invoke(Seedance2Fast!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gen4Aleph,
                typeof(global::Runway.CreateVideoToVideoRequestGen4Aleph),
                Aleph2,
                typeof(global::Runway.CreateVideoToVideoRequestAleph2),
                Seedance2,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast),
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
        public bool Equals(CreateVideoToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestGen4Aleph?>.Default.Equals(Gen4Aleph, other.Gen4Aleph) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestAleph2?>.Default.Equals(Aleph2, other.Aleph2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateVideoToVideoRequest obj1, CreateVideoToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVideoToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateVideoToVideoRequest obj1, CreateVideoToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVideoToVideoRequest o && Equals(o);
        }
    }
}
