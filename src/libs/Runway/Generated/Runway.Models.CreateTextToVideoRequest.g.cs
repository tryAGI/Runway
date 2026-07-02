#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTextToVideoRequest : global::System.IEquatable<CreateTextToVideoRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestDiscriminatorModel? Model { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestGen45? Gen45 { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestGen45? Gen45 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen45))]
#endif
        public bool IsGen45 => Gen45 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGen45(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToVideoRequestGen45? value)
        {
            value = Gen45;
            return IsGen45;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestGen45 PickGen45() => IsGen45
            ? Gen45!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen45' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestVeo31? Veo31 { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestVeo31? Veo31 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31))]
#endif
        public bool IsVeo31 => Veo31 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVeo31(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToVideoRequestVeo31? value)
        {
            value = Veo31;
            return IsVeo31;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestVeo31 PickVeo31() => IsVeo31
            ? Veo31!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestVeo31Fast? Veo31Fast { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestVeo31Fast? Veo31Fast { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo31Fast))]
#endif
        public bool IsVeo31Fast => Veo31Fast != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVeo31Fast(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToVideoRequestVeo31Fast? value)
        {
            value = Veo31Fast;
            return IsVeo31Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestVeo31Fast PickVeo31Fast() => IsVeo31Fast
            ? Veo31Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31Fast' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestHappyhorse10? Happyhorse10 { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestHappyhorse10? Happyhorse10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Happyhorse10))]
#endif
        public bool IsHappyhorse10 => Happyhorse10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHappyhorse10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToVideoRequestHappyhorse10? value)
        {
            value = Happyhorse10;
            return IsHappyhorse10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestHappyhorse10 PickHappyhorse10() => IsHappyhorse10
            ? Happyhorse10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Happyhorse10' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestSeedance2? Seedance2 { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestSeedance2? Seedance2 { get; }
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
            out global::Runway.CreateTextToVideoRequestSeedance2? value)
        {
            value = Seedance2;
            return IsSeedance2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestSeedance2 PickSeedance2() => IsSeedance2
            ? Seedance2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestSeedance2Fast? Seedance2Fast { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestSeedance2Fast? Seedance2Fast { get; }
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
            out global::Runway.CreateTextToVideoRequestSeedance2Fast? value)
        {
            value = Seedance2Fast;
            return IsSeedance2Fast;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestSeedance2Fast PickSeedance2Fast() => IsSeedance2Fast
            ? Seedance2Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Fast' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestSeedance2Mini? Seedance2Mini { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestSeedance2Mini? Seedance2Mini { get; }
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
            out global::Runway.CreateTextToVideoRequestSeedance2Mini? value)
        {
            value = Seedance2Mini;
            return IsSeedance2Mini;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestSeedance2Mini PickSeedance2Mini() => IsSeedance2Mini
            ? Seedance2Mini!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Mini' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; }
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
            out global::Runway.CreateTextToVideoRequestGeminiOmniFlash? value)
        {
            value = GeminiOmniFlash;
            return IsGeminiOmniFlash;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestGeminiOmniFlash PickGeminiOmniFlash() => IsGeminiOmniFlash
            ? GeminiOmniFlash!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateTextToVideoRequestVeo3? Veo3 { get; init; }
#else
        public global::Runway.CreateTextToVideoRequestVeo3? Veo3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Veo3))]
#endif
        public bool IsVeo3 => Veo3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVeo3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateTextToVideoRequestVeo3? value)
        {
            value = Veo3;
            return IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateTextToVideoRequestVeo3 PickVeo3() => IsVeo3
            ? Veo3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestGen45 value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestGen45?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestGen45?(CreateTextToVideoRequest @this) => @this.Gen45;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestGen45? value)
        {
            Gen45 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromGen45(global::Runway.CreateTextToVideoRequestGen45? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo31 value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestVeo31?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestVeo31?(CreateTextToVideoRequest @this) => @this.Veo31;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo31? value)
        {
            Veo31 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromVeo31(global::Runway.CreateTextToVideoRequestVeo31? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo31Fast value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestVeo31Fast?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestVeo31Fast?(CreateTextToVideoRequest @this) => @this.Veo31Fast;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo31Fast? value)
        {
            Veo31Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromVeo31Fast(global::Runway.CreateTextToVideoRequestVeo31Fast? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestHappyhorse10 value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestHappyhorse10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestHappyhorse10?(CreateTextToVideoRequest @this) => @this.Happyhorse10;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestHappyhorse10? value)
        {
            Happyhorse10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromHappyhorse10(global::Runway.CreateTextToVideoRequestHappyhorse10? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2 value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestSeedance2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestSeedance2?(CreateTextToVideoRequest @this) => @this.Seedance2;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2? value)
        {
            Seedance2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromSeedance2(global::Runway.CreateTextToVideoRequestSeedance2? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2Fast value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestSeedance2Fast?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestSeedance2Fast?(CreateTextToVideoRequest @this) => @this.Seedance2Fast;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2Fast? value)
        {
            Seedance2Fast = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromSeedance2Fast(global::Runway.CreateTextToVideoRequestSeedance2Fast? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2Mini value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestSeedance2Mini?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestSeedance2Mini?(CreateTextToVideoRequest @this) => @this.Seedance2Mini;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestSeedance2Mini? value)
        {
            Seedance2Mini = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromSeedance2Mini(global::Runway.CreateTextToVideoRequestSeedance2Mini? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestGeminiOmniFlash value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestGeminiOmniFlash?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestGeminiOmniFlash?(CreateTextToVideoRequest @this) => @this.GeminiOmniFlash;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestGeminiOmniFlash? value)
        {
            GeminiOmniFlash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromGeminiOmniFlash(global::Runway.CreateTextToVideoRequestGeminiOmniFlash? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo3 value) => new CreateTextToVideoRequest((global::Runway.CreateTextToVideoRequestVeo3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateTextToVideoRequestVeo3?(CreateTextToVideoRequest @this) => @this.Veo3;

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(global::Runway.CreateTextToVideoRequestVeo3? value)
        {
            Veo3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateTextToVideoRequest FromVeo3(global::Runway.CreateTextToVideoRequestVeo3? value) => new CreateTextToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateTextToVideoRequest(
            global::Runway.CreateTextToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateTextToVideoRequestGen45? gen45,
            global::Runway.CreateTextToVideoRequestVeo31? veo31,
            global::Runway.CreateTextToVideoRequestVeo31Fast? veo31Fast,
            global::Runway.CreateTextToVideoRequestHappyhorse10? happyhorse10,
            global::Runway.CreateTextToVideoRequestSeedance2? seedance2,
            global::Runway.CreateTextToVideoRequestSeedance2Fast? seedance2Fast,
            global::Runway.CreateTextToVideoRequestSeedance2Mini? seedance2Mini,
            global::Runway.CreateTextToVideoRequestGeminiOmniFlash? geminiOmniFlash,
            global::Runway.CreateTextToVideoRequestVeo3? veo3
            )
        {
            Model = model;

            Gen45 = gen45;
            Veo31 = veo31;
            Veo31Fast = veo31Fast;
            Happyhorse10 = happyhorse10;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
            Seedance2Mini = seedance2Mini;
            GeminiOmniFlash = geminiOmniFlash;
            Veo3 = veo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Veo3 as object ??
            GeminiOmniFlash as object ??
            Seedance2Mini as object ??
            Seedance2Fast as object ??
            Seedance2 as object ??
            Happyhorse10 as object ??
            Veo31Fast as object ??
            Veo31 as object ??
            Gen45 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Gen45?.ToString() ??
            Veo31?.ToString() ??
            Veo31Fast?.ToString() ??
            Happyhorse10?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() ??
            Seedance2Mini?.ToString() ??
            GeminiOmniFlash?.ToString() ??
            Veo3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && IsSeedance2Mini && !IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && IsGeminiOmniFlash && !IsVeo3 || !IsGen45 && !IsVeo31 && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateTextToVideoRequestGen45, TResult>? gen45 = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestVeo31, TResult>? veo31 = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestVeo31Fast, TResult>? veo31Fast = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestHappyhorse10, TResult>? happyhorse10 = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestSeedance2Mini, TResult>? seedance2Mini = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestGeminiOmniFlash, TResult>? geminiOmniFlash = null,
            global::System.Func<global::Runway.CreateTextToVideoRequestVeo3, TResult>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen45 && gen45 != null)
            {
                return gen45(Gen45!);
            }
            else if (IsVeo31 && veo31 != null)
            {
                return veo31(Veo31!);
            }
            else if (IsVeo31Fast && veo31Fast != null)
            {
                return veo31Fast(Veo31Fast!);
            }
            else if (IsHappyhorse10 && happyhorse10 != null)
            {
                return happyhorse10(Happyhorse10!);
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
            else if (IsVeo3 && veo3 != null)
            {
                return veo3(Veo3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateTextToVideoRequestGen45>? gen45 = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestVeo31>? veo31 = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestVeo31Fast>? veo31Fast = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestHappyhorse10>? happyhorse10 = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2Fast>? seedance2Fast = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2Mini>? seedance2Mini = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,

            global::System.Action<global::Runway.CreateTextToVideoRequestVeo3>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen45)
            {
                gen45?.Invoke(Gen45!);
            }
            else if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsVeo31Fast)
            {
                veo31Fast?.Invoke(Veo31Fast!);
            }
            else if (IsHappyhorse10)
            {
                happyhorse10?.Invoke(Happyhorse10!);
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
            else if (IsVeo3)
            {
                veo3?.Invoke(Veo3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateTextToVideoRequestGen45>? gen45 = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestVeo31>? veo31 = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestVeo31Fast>? veo31Fast = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestHappyhorse10>? happyhorse10 = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2Fast>? seedance2Fast = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestSeedance2Mini>? seedance2Mini = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,
            global::System.Action<global::Runway.CreateTextToVideoRequestVeo3>? veo3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGen45)
            {
                gen45?.Invoke(Gen45!);
            }
            else if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsVeo31Fast)
            {
                veo31Fast?.Invoke(Veo31Fast!);
            }
            else if (IsHappyhorse10)
            {
                happyhorse10?.Invoke(Happyhorse10!);
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
            else if (IsVeo3)
            {
                veo3?.Invoke(Veo3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Gen45,
                typeof(global::Runway.CreateTextToVideoRequestGen45),
                Veo31,
                typeof(global::Runway.CreateTextToVideoRequestVeo31),
                Veo31Fast,
                typeof(global::Runway.CreateTextToVideoRequestVeo31Fast),
                Happyhorse10,
                typeof(global::Runway.CreateTextToVideoRequestHappyhorse10),
                Seedance2,
                typeof(global::Runway.CreateTextToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateTextToVideoRequestSeedance2Fast),
                Seedance2Mini,
                typeof(global::Runway.CreateTextToVideoRequestSeedance2Mini),
                GeminiOmniFlash,
                typeof(global::Runway.CreateTextToVideoRequestGeminiOmniFlash),
                Veo3,
                typeof(global::Runway.CreateTextToVideoRequestVeo3),
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
        public bool Equals(CreateTextToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestGen45?>.Default.Equals(Gen45, other.Gen45) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestVeo31?>.Default.Equals(Veo31, other.Veo31) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestVeo31Fast?>.Default.Equals(Veo31Fast, other.Veo31Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestHappyhorse10?>.Default.Equals(Happyhorse10, other.Happyhorse10) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestSeedance2Mini?>.Default.Equals(Seedance2Mini, other.Seedance2Mini) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestGeminiOmniFlash?>.Default.Equals(GeminiOmniFlash, other.GeminiOmniFlash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateTextToVideoRequestVeo3?>.Default.Equals(Veo3, other.Veo3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTextToVideoRequest obj1, CreateTextToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTextToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTextToVideoRequest obj1, CreateTextToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTextToVideoRequest o && Equals(o);
        }
    }
}
