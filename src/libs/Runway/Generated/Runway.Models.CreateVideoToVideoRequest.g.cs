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
        public global::Runway.CreateVideoToVideoRequestVariant1? Aleph2 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestVariant1? Aleph2 { get; }
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
            out global::Runway.CreateVideoToVideoRequestVariant1? value)
        {
            value = Aleph2;
            return IsAleph2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestVariant1 PickAleph2() => IsAleph2
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
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestSeedance2Mini? Seedance2Mini { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestSeedance2Mini? Seedance2Mini { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedance2Mini))]
#endif
        public bool IsSeedance2Mini => Seedance2Mini != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSeedance2Mini(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestSeedance2Mini? value)
        {
            value = Seedance2Mini;
            return IsSeedance2Mini;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestSeedance2Mini PickSeedance2Mini() => IsSeedance2Mini
            ? Seedance2Mini!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Mini' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiOmniFlash))]
#endif
        public bool IsGeminiOmniFlash => GeminiOmniFlash != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGeminiOmniFlash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? value)
        {
            value = GeminiOmniFlash;
            return IsGeminiOmniFlash;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash PickGeminiOmniFlash() => IsGeminiOmniFlash
            ? GeminiOmniFlash!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestVariant1 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestVariant1?(CreateVideoToVideoRequest @this) => @this.Aleph2;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestVariant1? value)
        {
            Aleph2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromAleph2(global::Runway.CreateVideoToVideoRequestVariant1? value) => new CreateVideoToVideoRequest(value);

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
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2Mini value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestSeedance2Mini?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestSeedance2Mini?(CreateVideoToVideoRequest @this) => @this.Seedance2Mini;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance2Mini? value)
        {
            Seedance2Mini = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromSeedance2Mini(global::Runway.CreateVideoToVideoRequestSeedance2Mini? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestGeminiOmniFlash?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestGeminiOmniFlash?(CreateVideoToVideoRequest @this) => @this.GeminiOmniFlash;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? value)
        {
            GeminiOmniFlash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateVideoToVideoRequest FromGeminiOmniFlash(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoToVideoRequest(
            global::Runway.CreateVideoToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateVideoToVideoRequestVariant1? aleph2,
            global::Runway.CreateVideoToVideoRequestSeedance2? seedance2,
            global::Runway.CreateVideoToVideoRequestSeedance2Fast? seedance2Fast,
            global::Runway.CreateVideoToVideoRequestSeedance2Mini? seedance2Mini,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? geminiOmniFlash
            )
        {
            Model = model;

            Aleph2 = aleph2;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
            Seedance2Mini = seedance2Mini;
            GeminiOmniFlash = geminiOmniFlash;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GeminiOmniFlash as object ??
            Seedance2Mini as object ??
            Seedance2Fast as object ??
            Seedance2 as object ??
            Aleph2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Aleph2?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() ??
            Seedance2Mini?.ToString() ??
            GeminiOmniFlash?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAleph2 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash || !IsAleph2 && IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash || !IsAleph2 && !IsSeedance2 && IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash || !IsAleph2 && !IsSeedance2 && !IsSeedance2Fast && IsSeedance2Mini && !IsGeminiOmniFlash || !IsAleph2 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && IsGeminiOmniFlash;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoToVideoRequestVariant1, TResult>? aleph2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2Mini, TResult>? seedance2Mini = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash, TResult>? geminiOmniFlash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAleph2 && aleph2 != null)
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
            else if (IsSeedance2Mini && seedance2Mini != null)
            {
                return seedance2Mini(Seedance2Mini!);
            }
            else if (IsGeminiOmniFlash && geminiOmniFlash != null)
            {
                return geminiOmniFlash(GeminiOmniFlash!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoToVideoRequestVariant1>? aleph2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Mini>? seedance2Mini = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAleph2)
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
            else if (IsSeedance2Mini)
            {
                seedance2Mini?.Invoke(Seedance2Mini!);
            }
            else if (IsGeminiOmniFlash)
            {
                geminiOmniFlash?.Invoke(GeminiOmniFlash!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoToVideoRequestVariant1>? aleph2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Mini>? seedance2Mini = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAleph2)
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
            else if (IsSeedance2Mini)
            {
                seedance2Mini?.Invoke(Seedance2Mini!);
            }
            else if (IsGeminiOmniFlash)
            {
                geminiOmniFlash?.Invoke(GeminiOmniFlash!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Aleph2,
                typeof(global::Runway.CreateVideoToVideoRequestVariant1),
                Seedance2,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast),
                Seedance2Mini,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini),
                GeminiOmniFlash,
                typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestVariant1?>.Default.Equals(Aleph2, other.Aleph2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2Mini?>.Default.Equals(Seedance2Mini, other.Seedance2Mini) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash?>.Default.Equals(GeminiOmniFlash, other.GeminiOmniFlash) 
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
