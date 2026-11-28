#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateImageToVideoRequest : global::System.IEquatable<CreateImageToVideoRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestDiscriminatorModel? Model { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGen45? Gen45 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGen45? Gen45 { get; }
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
            out global::Runway.CreateImageToVideoRequestGen45? value)
        {
            value = Gen45;
            return IsGen45;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGen45 PickGen45() => Gen45 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen45' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGen4Turbo? Gen4Turbo { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGen4Turbo? Gen4Turbo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen4Turbo))]
#endif
        public bool IsGen4Turbo => Gen4Turbo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGen4Turbo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGen4Turbo? value)
        {
            value = Gen4Turbo;
            return IsGen4Turbo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGen4Turbo PickGen4Turbo() => Gen4Turbo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen4Turbo' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestVeo31? Veo31 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestVeo31? Veo31 { get; }
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
            out global::Runway.CreateImageToVideoRequestVeo31? value)
        {
            value = Veo31;
            return IsVeo31;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestVeo31 PickVeo31() => Veo31 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestVeo31Fast? Veo31Fast { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestVeo31Fast? Veo31Fast { get; }
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
            out global::Runway.CreateImageToVideoRequestVeo31Fast? value)
        {
            value = Veo31Fast;
            return IsVeo31Fast;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestVeo31Fast PickVeo31Fast() => Veo31Fast is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31Fast' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKlingO34k? KlingO34k { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKlingO34k? KlingO34k { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KlingO34k))]
#endif
        public bool IsKlingO34k => KlingO34k != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKlingO34k(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKlingO34k? value)
        {
            value = KlingO34k;
            return IsKlingO34k;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKlingO34k PickKlingO34k() => KlingO34k is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO34k' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestHailuo3? Hailuo3 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestHailuo3? Hailuo3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hailuo3))]
#endif
        public bool IsHailuo3 => Hailuo3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHailuo3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestHailuo3? value)
        {
            value = Hailuo3;
            return IsHailuo3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestHailuo3 PickHailuo3() => Hailuo3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hailuo3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling304k? Kling304k { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling304k? Kling304k { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling304k))]
#endif
        public bool IsKling304k => Kling304k != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling304k(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling304k? value)
        {
            value = Kling304k;
            return IsKling304k;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling304k PickKling304k() => Kling304k is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling304k' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestHappyhorse10? Happyhorse10 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestHappyhorse10? Happyhorse10 { get; }
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
            out global::Runway.CreateImageToVideoRequestHappyhorse10? value)
        {
            value = Happyhorse10;
            return IsHappyhorse10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestHappyhorse10 PickHappyhorse10() => Happyhorse10 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Happyhorse10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling25TurboPro? Kling25TurboPro { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling25TurboPro? Kling25TurboPro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling25TurboPro))]
#endif
        public bool IsKling25TurboPro => Kling25TurboPro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling25TurboPro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling25TurboPro? value)
        {
            value = Kling25TurboPro;
            return IsKling25TurboPro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling25TurboPro PickKling25TurboPro() => Kling25TurboPro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling25TurboPro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling30Pro? Kling30Pro { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling30Pro? Kling30Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling30Pro))]
#endif
        public bool IsKling30Pro => Kling30Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling30Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling30Pro? value)
        {
            value = Kling30Pro;
            return IsKling30Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling30Pro PickKling30Pro() => Kling30Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling30Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling30Standard? Kling30Standard { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling30Standard? Kling30Standard { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling30Standard))]
#endif
        public bool IsKling30Standard => Kling30Standard != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling30Standard(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling30Standard? value)
        {
            value = Kling30Standard;
            return IsKling30Standard;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling30Standard PickKling30Standard() => Kling30Standard is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling30Standard' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKlingO3Pro? KlingO3Pro { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKlingO3Pro? KlingO3Pro { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KlingO3Pro))]
#endif
        public bool IsKlingO3Pro => KlingO3Pro != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKlingO3Pro(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKlingO3Pro? value)
        {
            value = KlingO3Pro;
            return IsKlingO3Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKlingO3Pro PickKlingO3Pro() => KlingO3Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO3Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKlingO3Standard? KlingO3Standard { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKlingO3Standard? KlingO3Standard { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KlingO3Standard))]
#endif
        public bool IsKlingO3Standard => KlingO3Standard != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKlingO3Standard(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKlingO3Standard? value)
        {
            value = KlingO3Standard;
            return IsKlingO3Standard;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKlingO3Standard PickKlingO3Standard() => KlingO3Standard is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO3Standard' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestSeedance2? Seedance2 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestSeedance2? Seedance2 { get; }
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
            out global::Runway.CreateImageToVideoRequestSeedance2? value)
        {
            value = Seedance2;
            return IsSeedance2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestSeedance2 PickSeedance2() => Seedance2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestSeedance2Fast? Seedance2Fast { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestSeedance2Fast? Seedance2Fast { get; }
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
            out global::Runway.CreateImageToVideoRequestSeedance2Fast? value)
        {
            value = Seedance2Fast;
            return IsSeedance2Fast;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestSeedance2Fast PickSeedance2Fast() => Seedance2Fast is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Fast' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestSeedance2Mini? Seedance2Mini { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestSeedance2Mini? Seedance2Mini { get; }
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
            out global::Runway.CreateImageToVideoRequestSeedance2Mini? value)
        {
            value = Seedance2Mini;
            return IsSeedance2Mini;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestSeedance2Mini PickSeedance2Mini() => Seedance2Mini is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Mini' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash? GeminiOmniFlash { get; }
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
            out global::Runway.CreateImageToVideoRequestGeminiOmniFlash? value)
        {
            value = GeminiOmniFlash;
            return IsGeminiOmniFlash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash PickGeminiOmniFlash() => GeminiOmniFlash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGrokImagine15? GrokImagine15 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGrokImagine15? GrokImagine15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GrokImagine15))]
#endif
        public bool IsGrokImagine15 => GrokImagine15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrokImagine15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGrokImagine15? value)
        {
            value = GrokImagine15;
            return IsGrokImagine15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGrokImagine15 PickGrokImagine15() => GrokImagine15 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GrokImagine15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestWan3? Wan3 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestWan3? Wan3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wan3))]
#endif
        public bool IsWan3 => Wan3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWan3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestWan3? value)
        {
            value = Wan3;
            return IsWan3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestWan3 PickWan3() => Wan3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wan3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? GeminiOmniFlash11 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? GeminiOmniFlash11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiOmniFlash11))]
#endif
        public bool IsGeminiOmniFlash11 => GeminiOmniFlash11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiOmniFlash11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? value)
        {
            value = GeminiOmniFlash11;
            return IsGeminiOmniFlash11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash11 PickGeminiOmniFlash11() => GeminiOmniFlash11 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestWan3Prime? Wan3Prime { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestWan3Prime? Wan3Prime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wan3Prime))]
#endif
        public bool IsWan3Prime => Wan3Prime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWan3Prime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestWan3Prime? value)
        {
            value = Wan3Prime;
            return IsWan3Prime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestWan3Prime PickWan3Prime() => Wan3Prime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wan3Prime' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestH3Max? H3Max { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestH3Max? H3Max { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(H3Max))]
#endif
        public bool IsH3Max => H3Max != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickH3Max(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestH3Max? value)
        {
            value = H3Max;
            return IsH3Max;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestH3Max PickH3Max() => H3Max is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'H3Max' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestSeedance25? Seedance25 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestSeedance25? Seedance25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedance25))]
#endif
        public bool IsSeedance25 => Seedance25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedance25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestSeedance25? value)
        {
            value = Seedance25;
            return IsSeedance25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestSeedance25 PickSeedance25() => Seedance25 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance25' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGrokImagine15Lite? GrokImagine15Lite { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGrokImagine15Lite? GrokImagine15Lite { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GrokImagine15Lite))]
#endif
        public bool IsGrokImagine15Lite => GrokImagine15Lite != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrokImagine15Lite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGrokImagine15Lite? value)
        {
            value = GrokImagine15Lite;
            return IsGrokImagine15Lite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGrokImagine15Lite PickGrokImagine15Lite() => GrokImagine15Lite is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GrokImagine15Lite' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling4? Kling4 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling4? Kling4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling4))]
#endif
        public bool IsKling4 => Kling4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling4? value)
        {
            value = Kling4;
            return IsKling4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling4 PickKling4() => Kling4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? GeminiOmniFlash12 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? GeminiOmniFlash12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeminiOmniFlash12))]
#endif
        public bool IsGeminiOmniFlash12 => GeminiOmniFlash12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeminiOmniFlash12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? value)
        {
            value = GeminiOmniFlash12;
            return IsGeminiOmniFlash12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGeminiOmniFlash12 PickGeminiOmniFlash12() => GeminiOmniFlash12 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestKling4Flash? Kling4Flash { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestKling4Flash? Kling4Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Kling4Flash))]
#endif
        public bool IsKling4Flash => Kling4Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKling4Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestKling4Flash? value)
        {
            value = Kling4Flash;
            return IsKling4Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestKling4Flash PickKling4Flash() => Kling4Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling4Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestHailuo3Highspeed? Hailuo3Highspeed { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestHailuo3Highspeed? Hailuo3Highspeed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hailuo3Highspeed))]
#endif
        public bool IsHailuo3Highspeed => Hailuo3Highspeed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHailuo3Highspeed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestHailuo3Highspeed? value)
        {
            value = Hailuo3Highspeed;
            return IsHailuo3Highspeed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestHailuo3Highspeed PickHailuo3Highspeed() => Hailuo3Highspeed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hailuo3Highspeed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestHailuo3Lite? Hailuo3Lite { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestHailuo3Lite? Hailuo3Lite { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hailuo3Lite))]
#endif
        public bool IsHailuo3Lite => Hailuo3Lite != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHailuo3Lite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestHailuo3Lite? value)
        {
            value = Hailuo3Lite;
            return IsHailuo3Lite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestHailuo3Lite PickHailuo3Lite() => Hailuo3Lite is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hailuo3Lite' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestSeedance25Flash? Seedance25Flash { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestSeedance25Flash? Seedance25Flash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Seedance25Flash))]
#endif
        public bool IsSeedance25Flash => Seedance25Flash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSeedance25Flash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestSeedance25Flash? value)
        {
            value = Seedance25Flash;
            return IsSeedance25Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateImageToVideoRequestSeedance25Flash PickSeedance25Flash() => Seedance25Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance25Flash' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen45 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGen45?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGen45?(CreateImageToVideoRequest @this) => @this.Gen45;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen45? value)
        {
            Gen45 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGen45(global::Runway.CreateImageToVideoRequestGen45? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen4Turbo value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGen4Turbo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGen4Turbo?(CreateImageToVideoRequest @this) => @this.Gen4Turbo;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen4Turbo? value)
        {
            Gen4Turbo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGen4Turbo(global::Runway.CreateImageToVideoRequestGen4Turbo? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo31 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestVeo31?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestVeo31?(CreateImageToVideoRequest @this) => @this.Veo31;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo31? value)
        {
            Veo31 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromVeo31(global::Runway.CreateImageToVideoRequestVeo31? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo31Fast value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestVeo31Fast?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestVeo31Fast?(CreateImageToVideoRequest @this) => @this.Veo31Fast;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo31Fast? value)
        {
            Veo31Fast = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromVeo31Fast(global::Runway.CreateImageToVideoRequestVeo31Fast? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO34k value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKlingO34k?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKlingO34k?(CreateImageToVideoRequest @this) => @this.KlingO34k;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO34k? value)
        {
            KlingO34k = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKlingO34k(global::Runway.CreateImageToVideoRequestKlingO34k? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestHailuo3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestHailuo3?(CreateImageToVideoRequest @this) => @this.Hailuo3;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3? value)
        {
            Hailuo3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromHailuo3(global::Runway.CreateImageToVideoRequestHailuo3? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling304k value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling304k?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling304k?(CreateImageToVideoRequest @this) => @this.Kling304k;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling304k? value)
        {
            Kling304k = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling304k(global::Runway.CreateImageToVideoRequestKling304k? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHappyhorse10 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestHappyhorse10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestHappyhorse10?(CreateImageToVideoRequest @this) => @this.Happyhorse10;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHappyhorse10? value)
        {
            Happyhorse10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromHappyhorse10(global::Runway.CreateImageToVideoRequestHappyhorse10? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling25TurboPro value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling25TurboPro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling25TurboPro?(CreateImageToVideoRequest @this) => @this.Kling25TurboPro;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling25TurboPro? value)
        {
            Kling25TurboPro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling25TurboPro(global::Runway.CreateImageToVideoRequestKling25TurboPro? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling30Pro value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling30Pro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling30Pro?(CreateImageToVideoRequest @this) => @this.Kling30Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling30Pro? value)
        {
            Kling30Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling30Pro(global::Runway.CreateImageToVideoRequestKling30Pro? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling30Standard value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling30Standard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling30Standard?(CreateImageToVideoRequest @this) => @this.Kling30Standard;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling30Standard? value)
        {
            Kling30Standard = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling30Standard(global::Runway.CreateImageToVideoRequestKling30Standard? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO3Pro value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKlingO3Pro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKlingO3Pro?(CreateImageToVideoRequest @this) => @this.KlingO3Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO3Pro? value)
        {
            KlingO3Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKlingO3Pro(global::Runway.CreateImageToVideoRequestKlingO3Pro? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO3Standard value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKlingO3Standard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKlingO3Standard?(CreateImageToVideoRequest @this) => @this.KlingO3Standard;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKlingO3Standard? value)
        {
            KlingO3Standard = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKlingO3Standard(global::Runway.CreateImageToVideoRequestKlingO3Standard? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestSeedance2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestSeedance2?(CreateImageToVideoRequest @this) => @this.Seedance2;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2? value)
        {
            Seedance2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromSeedance2(global::Runway.CreateImageToVideoRequestSeedance2? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2Fast value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestSeedance2Fast?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestSeedance2Fast?(CreateImageToVideoRequest @this) => @this.Seedance2Fast;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2Fast? value)
        {
            Seedance2Fast = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromSeedance2Fast(global::Runway.CreateImageToVideoRequestSeedance2Fast? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2Mini value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestSeedance2Mini?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestSeedance2Mini?(CreateImageToVideoRequest @this) => @this.Seedance2Mini;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance2Mini? value)
        {
            Seedance2Mini = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromSeedance2Mini(global::Runway.CreateImageToVideoRequestSeedance2Mini? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGeminiOmniFlash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGeminiOmniFlash?(CreateImageToVideoRequest @this) => @this.GeminiOmniFlash;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash? value)
        {
            GeminiOmniFlash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGeminiOmniFlash(global::Runway.CreateImageToVideoRequestGeminiOmniFlash? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGrokImagine15 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGrokImagine15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGrokImagine15?(CreateImageToVideoRequest @this) => @this.GrokImagine15;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGrokImagine15? value)
        {
            GrokImagine15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGrokImagine15(global::Runway.CreateImageToVideoRequestGrokImagine15? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestWan3 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestWan3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestWan3?(CreateImageToVideoRequest @this) => @this.Wan3;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestWan3? value)
        {
            Wan3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromWan3(global::Runway.CreateImageToVideoRequestWan3? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGeminiOmniFlash11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGeminiOmniFlash11?(CreateImageToVideoRequest @this) => @this.GeminiOmniFlash11;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? value)
        {
            GeminiOmniFlash11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGeminiOmniFlash11(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestWan3Prime value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestWan3Prime?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestWan3Prime?(CreateImageToVideoRequest @this) => @this.Wan3Prime;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestWan3Prime? value)
        {
            Wan3Prime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromWan3Prime(global::Runway.CreateImageToVideoRequestWan3Prime? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestH3Max value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestH3Max?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestH3Max?(CreateImageToVideoRequest @this) => @this.H3Max;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestH3Max? value)
        {
            H3Max = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromH3Max(global::Runway.CreateImageToVideoRequestH3Max? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance25 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestSeedance25?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestSeedance25?(CreateImageToVideoRequest @this) => @this.Seedance25;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance25? value)
        {
            Seedance25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromSeedance25(global::Runway.CreateImageToVideoRequestSeedance25? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGrokImagine15Lite value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGrokImagine15Lite?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGrokImagine15Lite?(CreateImageToVideoRequest @this) => @this.GrokImagine15Lite;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGrokImagine15Lite? value)
        {
            GrokImagine15Lite = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGrokImagine15Lite(global::Runway.CreateImageToVideoRequestGrokImagine15Lite? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling4 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling4?(CreateImageToVideoRequest @this) => @this.Kling4;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling4? value)
        {
            Kling4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling4(global::Runway.CreateImageToVideoRequestKling4? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGeminiOmniFlash12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGeminiOmniFlash12?(CreateImageToVideoRequest @this) => @this.GeminiOmniFlash12;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? value)
        {
            GeminiOmniFlash12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromGeminiOmniFlash12(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling4Flash value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestKling4Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestKling4Flash?(CreateImageToVideoRequest @this) => @this.Kling4Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestKling4Flash? value)
        {
            Kling4Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromKling4Flash(global::Runway.CreateImageToVideoRequestKling4Flash? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3Highspeed value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestHailuo3Highspeed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestHailuo3Highspeed?(CreateImageToVideoRequest @this) => @this.Hailuo3Highspeed;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3Highspeed? value)
        {
            Hailuo3Highspeed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromHailuo3Highspeed(global::Runway.CreateImageToVideoRequestHailuo3Highspeed? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3Lite value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestHailuo3Lite?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestHailuo3Lite?(CreateImageToVideoRequest @this) => @this.Hailuo3Lite;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestHailuo3Lite? value)
        {
            Hailuo3Lite = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromHailuo3Lite(global::Runway.CreateImageToVideoRequestHailuo3Lite? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance25Flash value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestSeedance25Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestSeedance25Flash?(CreateImageToVideoRequest @this) => @this.Seedance25Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestSeedance25Flash? value)
        {
            Seedance25Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateImageToVideoRequest FromSeedance25Flash(global::Runway.CreateImageToVideoRequestSeedance25Flash? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateImageToVideoRequest(
            global::Runway.CreateImageToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateImageToVideoRequestGen45? gen45,
            global::Runway.CreateImageToVideoRequestGen4Turbo? gen4Turbo,
            global::Runway.CreateImageToVideoRequestVeo31? veo31,
            global::Runway.CreateImageToVideoRequestVeo31Fast? veo31Fast,
            global::Runway.CreateImageToVideoRequestKlingO34k? klingO34k,
            global::Runway.CreateImageToVideoRequestHailuo3? hailuo3,
            global::Runway.CreateImageToVideoRequestKling304k? kling304k,
            global::Runway.CreateImageToVideoRequestHappyhorse10? happyhorse10,
            global::Runway.CreateImageToVideoRequestKling25TurboPro? kling25TurboPro,
            global::Runway.CreateImageToVideoRequestKling30Pro? kling30Pro,
            global::Runway.CreateImageToVideoRequestKling30Standard? kling30Standard,
            global::Runway.CreateImageToVideoRequestKlingO3Pro? klingO3Pro,
            global::Runway.CreateImageToVideoRequestKlingO3Standard? klingO3Standard,
            global::Runway.CreateImageToVideoRequestSeedance2? seedance2,
            global::Runway.CreateImageToVideoRequestSeedance2Fast? seedance2Fast,
            global::Runway.CreateImageToVideoRequestSeedance2Mini? seedance2Mini,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash? geminiOmniFlash,
            global::Runway.CreateImageToVideoRequestGrokImagine15? grokImagine15,
            global::Runway.CreateImageToVideoRequestWan3? wan3,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash11? geminiOmniFlash11,
            global::Runway.CreateImageToVideoRequestWan3Prime? wan3Prime,
            global::Runway.CreateImageToVideoRequestH3Max? h3Max,
            global::Runway.CreateImageToVideoRequestSeedance25? seedance25,
            global::Runway.CreateImageToVideoRequestGrokImagine15Lite? grokImagine15Lite,
            global::Runway.CreateImageToVideoRequestKling4? kling4,
            global::Runway.CreateImageToVideoRequestGeminiOmniFlash12? geminiOmniFlash12,
            global::Runway.CreateImageToVideoRequestKling4Flash? kling4Flash,
            global::Runway.CreateImageToVideoRequestHailuo3Highspeed? hailuo3Highspeed,
            global::Runway.CreateImageToVideoRequestHailuo3Lite? hailuo3Lite,
            global::Runway.CreateImageToVideoRequestSeedance25Flash? seedance25Flash
            )
        {
            Model = model;

            Gen45 = gen45;
            Gen4Turbo = gen4Turbo;
            Veo31 = veo31;
            Veo31Fast = veo31Fast;
            KlingO34k = klingO34k;
            Hailuo3 = hailuo3;
            Kling304k = kling304k;
            Happyhorse10 = happyhorse10;
            Kling25TurboPro = kling25TurboPro;
            Kling30Pro = kling30Pro;
            Kling30Standard = kling30Standard;
            KlingO3Pro = klingO3Pro;
            KlingO3Standard = klingO3Standard;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
            Seedance2Mini = seedance2Mini;
            GeminiOmniFlash = geminiOmniFlash;
            GrokImagine15 = grokImagine15;
            Wan3 = wan3;
            GeminiOmniFlash11 = geminiOmniFlash11;
            Wan3Prime = wan3Prime;
            H3Max = h3Max;
            Seedance25 = seedance25;
            GrokImagine15Lite = grokImagine15Lite;
            Kling4 = kling4;
            GeminiOmniFlash12 = geminiOmniFlash12;
            Kling4Flash = kling4Flash;
            Hailuo3Highspeed = hailuo3Highspeed;
            Hailuo3Lite = hailuo3Lite;
            Seedance25Flash = seedance25Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Seedance25Flash as object ??
            Hailuo3Lite as object ??
            Hailuo3Highspeed as object ??
            Kling4Flash as object ??
            GeminiOmniFlash12 as object ??
            Kling4 as object ??
            GrokImagine15Lite as object ??
            Seedance25 as object ??
            H3Max as object ??
            Wan3Prime as object ??
            GeminiOmniFlash11 as object ??
            Wan3 as object ??
            GrokImagine15 as object ??
            GeminiOmniFlash as object ??
            Seedance2Mini as object ??
            Seedance2Fast as object ??
            Seedance2 as object ??
            KlingO3Standard as object ??
            KlingO3Pro as object ??
            Kling30Standard as object ??
            Kling30Pro as object ??
            Kling25TurboPro as object ??
            Happyhorse10 as object ??
            Kling304k as object ??
            Hailuo3 as object ??
            KlingO34k as object ??
            Veo31Fast as object ??
            Veo31 as object ??
            Gen4Turbo as object ??
            Gen45 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Gen45?.ToString() ??
            Gen4Turbo?.ToString() ??
            Veo31?.ToString() ??
            Veo31Fast?.ToString() ??
            KlingO34k?.ToString() ??
            Hailuo3?.ToString() ??
            Kling304k?.ToString() ??
            Happyhorse10?.ToString() ??
            Kling25TurboPro?.ToString() ??
            Kling30Pro?.ToString() ??
            Kling30Standard?.ToString() ??
            KlingO3Pro?.ToString() ??
            KlingO3Standard?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() ??
            Seedance2Mini?.ToString() ??
            GeminiOmniFlash?.ToString() ??
            GrokImagine15?.ToString() ??
            Wan3?.ToString() ??
            GeminiOmniFlash11?.ToString() ??
            Wan3Prime?.ToString() ??
            H3Max?.ToString() ??
            Seedance25?.ToString() ??
            GrokImagine15Lite?.ToString() ??
            Kling4?.ToString() ??
            GeminiOmniFlash12?.ToString() ??
            Kling4Flash?.ToString() ??
            Hailuo3Highspeed?.ToString() ??
            Hailuo3Lite?.ToString() ??
            Seedance25Flash?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && IsHailuo3Highspeed && !IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && IsHailuo3Lite && !IsSeedance25Flash || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsVeo31Fast && !IsKlingO34k && !IsHailuo3 && !IsKling304k && !IsHappyhorse10 && !IsKling25TurboPro && !IsKling30Pro && !IsKling30Standard && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGrokImagine15 && !IsWan3 && !IsGeminiOmniFlash11 && !IsWan3Prime && !IsH3Max && !IsSeedance25 && !IsGrokImagine15Lite && !IsKling4 && !IsGeminiOmniFlash12 && !IsKling4Flash && !IsHailuo3Highspeed && !IsHailuo3Lite && IsSeedance25Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateImageToVideoRequestGen45, TResult>? gen45 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGen4Turbo, TResult>? gen4Turbo = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestVeo31, TResult>? veo31 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestVeo31Fast, TResult>? veo31Fast = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKlingO34k, TResult>? klingO34k = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestHailuo3, TResult>? hailuo3 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling304k, TResult>? kling304k = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestHappyhorse10, TResult>? happyhorse10 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling25TurboPro, TResult>? kling25TurboPro = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling30Pro, TResult>? kling30Pro = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling30Standard, TResult>? kling30Standard = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKlingO3Pro, TResult>? klingO3Pro = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKlingO3Standard, TResult>? klingO3Standard = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance2Mini, TResult>? seedance2Mini = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGeminiOmniFlash, TResult>? geminiOmniFlash = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGrokImagine15, TResult>? grokImagine15 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestWan3, TResult>? wan3 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11, TResult>? geminiOmniFlash11 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestWan3Prime, TResult>? wan3Prime = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestH3Max, TResult>? h3Max = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance25, TResult>? seedance25 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGrokImagine15Lite, TResult>? grokImagine15Lite = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling4, TResult>? kling4 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12, TResult>? geminiOmniFlash12 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestKling4Flash, TResult>? kling4Flash = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestHailuo3Highspeed, TResult>? hailuo3Highspeed = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestHailuo3Lite, TResult>? hailuo3Lite = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance25Flash, TResult>? seedance25Flash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen45 is { } __value0 && gen45 != null)
            {
                return gen45(__value0);
            }
            else if (Gen4Turbo is { } __value1 && gen4Turbo != null)
            {
                return gen4Turbo(__value1);
            }
            else if (Veo31 is { } __value2 && veo31 != null)
            {
                return veo31(__value2);
            }
            else if (Veo31Fast is { } __value3 && veo31Fast != null)
            {
                return veo31Fast(__value3);
            }
            else if (KlingO34k is { } __value4 && klingO34k != null)
            {
                return klingO34k(__value4);
            }
            else if (Hailuo3 is { } __value5 && hailuo3 != null)
            {
                return hailuo3(__value5);
            }
            else if (Kling304k is { } __value6 && kling304k != null)
            {
                return kling304k(__value6);
            }
            else if (Happyhorse10 is { } __value7 && happyhorse10 != null)
            {
                return happyhorse10(__value7);
            }
            else if (Kling25TurboPro is { } __value8 && kling25TurboPro != null)
            {
                return kling25TurboPro(__value8);
            }
            else if (Kling30Pro is { } __value9 && kling30Pro != null)
            {
                return kling30Pro(__value9);
            }
            else if (Kling30Standard is { } __value10 && kling30Standard != null)
            {
                return kling30Standard(__value10);
            }
            else if (KlingO3Pro is { } __value11 && klingO3Pro != null)
            {
                return klingO3Pro(__value11);
            }
            else if (KlingO3Standard is { } __value12 && klingO3Standard != null)
            {
                return klingO3Standard(__value12);
            }
            else if (Seedance2 is { } __value13 && seedance2 != null)
            {
                return seedance2(__value13);
            }
            else if (Seedance2Fast is { } __value14 && seedance2Fast != null)
            {
                return seedance2Fast(__value14);
            }
            else if (Seedance2Mini is { } __value15 && seedance2Mini != null)
            {
                return seedance2Mini(__value15);
            }
            else if (GeminiOmniFlash is { } __value16 && geminiOmniFlash != null)
            {
                return geminiOmniFlash(__value16);
            }
            else if (GrokImagine15 is { } __value17 && grokImagine15 != null)
            {
                return grokImagine15(__value17);
            }
            else if (Wan3 is { } __value18 && wan3 != null)
            {
                return wan3(__value18);
            }
            else if (GeminiOmniFlash11 is { } __value19 && geminiOmniFlash11 != null)
            {
                return geminiOmniFlash11(__value19);
            }
            else if (Wan3Prime is { } __value20 && wan3Prime != null)
            {
                return wan3Prime(__value20);
            }
            else if (H3Max is { } __value21 && h3Max != null)
            {
                return h3Max(__value21);
            }
            else if (Seedance25 is { } __value22 && seedance25 != null)
            {
                return seedance25(__value22);
            }
            else if (GrokImagine15Lite is { } __value23 && grokImagine15Lite != null)
            {
                return grokImagine15Lite(__value23);
            }
            else if (Kling4 is { } __value24 && kling4 != null)
            {
                return kling4(__value24);
            }
            else if (GeminiOmniFlash12 is { } __value25 && geminiOmniFlash12 != null)
            {
                return geminiOmniFlash12(__value25);
            }
            else if (Kling4Flash is { } __value26 && kling4Flash != null)
            {
                return kling4Flash(__value26);
            }
            else if (Hailuo3Highspeed is { } __value27 && hailuo3Highspeed != null)
            {
                return hailuo3Highspeed(__value27);
            }
            else if (Hailuo3Lite is { } __value28 && hailuo3Lite != null)
            {
                return hailuo3Lite(__value28);
            }
            else if (Seedance25Flash is { } __value29 && seedance25Flash != null)
            {
                return seedance25Flash(__value29);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateImageToVideoRequestGen45>? gen45 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGen4Turbo>? gen4Turbo = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31>? veo31 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31Fast>? veo31Fast = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO34k>? klingO34k = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3>? hailuo3 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling304k>? kling304k = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestHappyhorse10>? happyhorse10 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling25TurboPro>? kling25TurboPro = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling30Pro>? kling30Pro = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling30Standard>? kling30Standard = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO3Pro>? klingO3Pro = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO3Standard>? klingO3Standard = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Fast>? seedance2Fast = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Mini>? seedance2Mini = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGrokImagine15>? grokImagine15 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestWan3>? wan3 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11>? geminiOmniFlash11 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestWan3Prime>? wan3Prime = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestH3Max>? h3Max = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance25>? seedance25 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGrokImagine15Lite>? grokImagine15Lite = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling4>? kling4 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12>? geminiOmniFlash12 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestKling4Flash>? kling4Flash = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3Highspeed>? hailuo3Highspeed = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3Lite>? hailuo3Lite = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance25Flash>? seedance25Flash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen45 is { } __value0)
            {
                gen45?.Invoke(__value0);
            }
            else if (Gen4Turbo is { } __value1)
            {
                gen4Turbo?.Invoke(__value1);
            }
            else if (Veo31 is { } __value2)
            {
                veo31?.Invoke(__value2);
            }
            else if (Veo31Fast is { } __value3)
            {
                veo31Fast?.Invoke(__value3);
            }
            else if (KlingO34k is { } __value4)
            {
                klingO34k?.Invoke(__value4);
            }
            else if (Hailuo3 is { } __value5)
            {
                hailuo3?.Invoke(__value5);
            }
            else if (Kling304k is { } __value6)
            {
                kling304k?.Invoke(__value6);
            }
            else if (Happyhorse10 is { } __value7)
            {
                happyhorse10?.Invoke(__value7);
            }
            else if (Kling25TurboPro is { } __value8)
            {
                kling25TurboPro?.Invoke(__value8);
            }
            else if (Kling30Pro is { } __value9)
            {
                kling30Pro?.Invoke(__value9);
            }
            else if (Kling30Standard is { } __value10)
            {
                kling30Standard?.Invoke(__value10);
            }
            else if (KlingO3Pro is { } __value11)
            {
                klingO3Pro?.Invoke(__value11);
            }
            else if (KlingO3Standard is { } __value12)
            {
                klingO3Standard?.Invoke(__value12);
            }
            else if (Seedance2 is { } __value13)
            {
                seedance2?.Invoke(__value13);
            }
            else if (Seedance2Fast is { } __value14)
            {
                seedance2Fast?.Invoke(__value14);
            }
            else if (Seedance2Mini is { } __value15)
            {
                seedance2Mini?.Invoke(__value15);
            }
            else if (GeminiOmniFlash is { } __value16)
            {
                geminiOmniFlash?.Invoke(__value16);
            }
            else if (GrokImagine15 is { } __value17)
            {
                grokImagine15?.Invoke(__value17);
            }
            else if (Wan3 is { } __value18)
            {
                wan3?.Invoke(__value18);
            }
            else if (GeminiOmniFlash11 is { } __value19)
            {
                geminiOmniFlash11?.Invoke(__value19);
            }
            else if (Wan3Prime is { } __value20)
            {
                wan3Prime?.Invoke(__value20);
            }
            else if (H3Max is { } __value21)
            {
                h3Max?.Invoke(__value21);
            }
            else if (Seedance25 is { } __value22)
            {
                seedance25?.Invoke(__value22);
            }
            else if (GrokImagine15Lite is { } __value23)
            {
                grokImagine15Lite?.Invoke(__value23);
            }
            else if (Kling4 is { } __value24)
            {
                kling4?.Invoke(__value24);
            }
            else if (GeminiOmniFlash12 is { } __value25)
            {
                geminiOmniFlash12?.Invoke(__value25);
            }
            else if (Kling4Flash is { } __value26)
            {
                kling4Flash?.Invoke(__value26);
            }
            else if (Hailuo3Highspeed is { } __value27)
            {
                hailuo3Highspeed?.Invoke(__value27);
            }
            else if (Hailuo3Lite is { } __value28)
            {
                hailuo3Lite?.Invoke(__value28);
            }
            else if (Seedance25Flash is { } __value29)
            {
                seedance25Flash?.Invoke(__value29);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateImageToVideoRequestGen45>? gen45 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGen4Turbo>? gen4Turbo = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31>? veo31 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31Fast>? veo31Fast = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO34k>? klingO34k = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3>? hailuo3 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling304k>? kling304k = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestHappyhorse10>? happyhorse10 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling25TurboPro>? kling25TurboPro = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling30Pro>? kling30Pro = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling30Standard>? kling30Standard = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO3Pro>? klingO3Pro = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKlingO3Standard>? klingO3Standard = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Fast>? seedance2Fast = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Mini>? seedance2Mini = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGrokImagine15>? grokImagine15 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestWan3>? wan3 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11>? geminiOmniFlash11 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestWan3Prime>? wan3Prime = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestH3Max>? h3Max = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance25>? seedance25 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGrokImagine15Lite>? grokImagine15Lite = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling4>? kling4 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12>? geminiOmniFlash12 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestKling4Flash>? kling4Flash = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3Highspeed>? hailuo3Highspeed = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestHailuo3Lite>? hailuo3Lite = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance25Flash>? seedance25Flash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Gen45 is { } __value0)
            {
                gen45?.Invoke(__value0);
            }
            else if (Gen4Turbo is { } __value1)
            {
                gen4Turbo?.Invoke(__value1);
            }
            else if (Veo31 is { } __value2)
            {
                veo31?.Invoke(__value2);
            }
            else if (Veo31Fast is { } __value3)
            {
                veo31Fast?.Invoke(__value3);
            }
            else if (KlingO34k is { } __value4)
            {
                klingO34k?.Invoke(__value4);
            }
            else if (Hailuo3 is { } __value5)
            {
                hailuo3?.Invoke(__value5);
            }
            else if (Kling304k is { } __value6)
            {
                kling304k?.Invoke(__value6);
            }
            else if (Happyhorse10 is { } __value7)
            {
                happyhorse10?.Invoke(__value7);
            }
            else if (Kling25TurboPro is { } __value8)
            {
                kling25TurboPro?.Invoke(__value8);
            }
            else if (Kling30Pro is { } __value9)
            {
                kling30Pro?.Invoke(__value9);
            }
            else if (Kling30Standard is { } __value10)
            {
                kling30Standard?.Invoke(__value10);
            }
            else if (KlingO3Pro is { } __value11)
            {
                klingO3Pro?.Invoke(__value11);
            }
            else if (KlingO3Standard is { } __value12)
            {
                klingO3Standard?.Invoke(__value12);
            }
            else if (Seedance2 is { } __value13)
            {
                seedance2?.Invoke(__value13);
            }
            else if (Seedance2Fast is { } __value14)
            {
                seedance2Fast?.Invoke(__value14);
            }
            else if (Seedance2Mini is { } __value15)
            {
                seedance2Mini?.Invoke(__value15);
            }
            else if (GeminiOmniFlash is { } __value16)
            {
                geminiOmniFlash?.Invoke(__value16);
            }
            else if (GrokImagine15 is { } __value17)
            {
                grokImagine15?.Invoke(__value17);
            }
            else if (Wan3 is { } __value18)
            {
                wan3?.Invoke(__value18);
            }
            else if (GeminiOmniFlash11 is { } __value19)
            {
                geminiOmniFlash11?.Invoke(__value19);
            }
            else if (Wan3Prime is { } __value20)
            {
                wan3Prime?.Invoke(__value20);
            }
            else if (H3Max is { } __value21)
            {
                h3Max?.Invoke(__value21);
            }
            else if (Seedance25 is { } __value22)
            {
                seedance25?.Invoke(__value22);
            }
            else if (GrokImagine15Lite is { } __value23)
            {
                grokImagine15Lite?.Invoke(__value23);
            }
            else if (Kling4 is { } __value24)
            {
                kling4?.Invoke(__value24);
            }
            else if (GeminiOmniFlash12 is { } __value25)
            {
                geminiOmniFlash12?.Invoke(__value25);
            }
            else if (Kling4Flash is { } __value26)
            {
                kling4Flash?.Invoke(__value26);
            }
            else if (Hailuo3Highspeed is { } __value27)
            {
                hailuo3Highspeed?.Invoke(__value27);
            }
            else if (Hailuo3Lite is { } __value28)
            {
                hailuo3Lite?.Invoke(__value28);
            }
            else if (Seedance25Flash is { } __value29)
            {
                seedance25Flash?.Invoke(__value29);
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
                typeof(global::Runway.CreateImageToVideoRequestGen45),
                Gen4Turbo,
                typeof(global::Runway.CreateImageToVideoRequestGen4Turbo),
                Veo31,
                typeof(global::Runway.CreateImageToVideoRequestVeo31),
                Veo31Fast,
                typeof(global::Runway.CreateImageToVideoRequestVeo31Fast),
                KlingO34k,
                typeof(global::Runway.CreateImageToVideoRequestKlingO34k),
                Hailuo3,
                typeof(global::Runway.CreateImageToVideoRequestHailuo3),
                Kling304k,
                typeof(global::Runway.CreateImageToVideoRequestKling304k),
                Happyhorse10,
                typeof(global::Runway.CreateImageToVideoRequestHappyhorse10),
                Kling25TurboPro,
                typeof(global::Runway.CreateImageToVideoRequestKling25TurboPro),
                Kling30Pro,
                typeof(global::Runway.CreateImageToVideoRequestKling30Pro),
                Kling30Standard,
                typeof(global::Runway.CreateImageToVideoRequestKling30Standard),
                KlingO3Pro,
                typeof(global::Runway.CreateImageToVideoRequestKlingO3Pro),
                KlingO3Standard,
                typeof(global::Runway.CreateImageToVideoRequestKlingO3Standard),
                Seedance2,
                typeof(global::Runway.CreateImageToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast),
                Seedance2Mini,
                typeof(global::Runway.CreateImageToVideoRequestSeedance2Mini),
                GeminiOmniFlash,
                typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash),
                GrokImagine15,
                typeof(global::Runway.CreateImageToVideoRequestGrokImagine15),
                Wan3,
                typeof(global::Runway.CreateImageToVideoRequestWan3),
                GeminiOmniFlash11,
                typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash11),
                Wan3Prime,
                typeof(global::Runway.CreateImageToVideoRequestWan3Prime),
                H3Max,
                typeof(global::Runway.CreateImageToVideoRequestH3Max),
                Seedance25,
                typeof(global::Runway.CreateImageToVideoRequestSeedance25),
                GrokImagine15Lite,
                typeof(global::Runway.CreateImageToVideoRequestGrokImagine15Lite),
                Kling4,
                typeof(global::Runway.CreateImageToVideoRequestKling4),
                GeminiOmniFlash12,
                typeof(global::Runway.CreateImageToVideoRequestGeminiOmniFlash12),
                Kling4Flash,
                typeof(global::Runway.CreateImageToVideoRequestKling4Flash),
                Hailuo3Highspeed,
                typeof(global::Runway.CreateImageToVideoRequestHailuo3Highspeed),
                Hailuo3Lite,
                typeof(global::Runway.CreateImageToVideoRequestHailuo3Lite),
                Seedance25Flash,
                typeof(global::Runway.CreateImageToVideoRequestSeedance25Flash),
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
        public bool Equals(CreateImageToVideoRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGen45?>.Default.Equals(Gen45, other.Gen45) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGen4Turbo?>.Default.Equals(Gen4Turbo, other.Gen4Turbo) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestVeo31?>.Default.Equals(Veo31, other.Veo31) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestVeo31Fast?>.Default.Equals(Veo31Fast, other.Veo31Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKlingO34k?>.Default.Equals(KlingO34k, other.KlingO34k) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestHailuo3?>.Default.Equals(Hailuo3, other.Hailuo3) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling304k?>.Default.Equals(Kling304k, other.Kling304k) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestHappyhorse10?>.Default.Equals(Happyhorse10, other.Happyhorse10) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling25TurboPro?>.Default.Equals(Kling25TurboPro, other.Kling25TurboPro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling30Pro?>.Default.Equals(Kling30Pro, other.Kling30Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling30Standard?>.Default.Equals(Kling30Standard, other.Kling30Standard) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKlingO3Pro?>.Default.Equals(KlingO3Pro, other.KlingO3Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKlingO3Standard?>.Default.Equals(KlingO3Standard, other.KlingO3Standard) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance2Mini?>.Default.Equals(Seedance2Mini, other.Seedance2Mini) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGeminiOmniFlash?>.Default.Equals(GeminiOmniFlash, other.GeminiOmniFlash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGrokImagine15?>.Default.Equals(GrokImagine15, other.GrokImagine15) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestWan3?>.Default.Equals(Wan3, other.Wan3) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGeminiOmniFlash11?>.Default.Equals(GeminiOmniFlash11, other.GeminiOmniFlash11) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestWan3Prime?>.Default.Equals(Wan3Prime, other.Wan3Prime) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestH3Max?>.Default.Equals(H3Max, other.H3Max) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance25?>.Default.Equals(Seedance25, other.Seedance25) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGrokImagine15Lite?>.Default.Equals(GrokImagine15Lite, other.GrokImagine15Lite) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling4?>.Default.Equals(Kling4, other.Kling4) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGeminiOmniFlash12?>.Default.Equals(GeminiOmniFlash12, other.GeminiOmniFlash12) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestKling4Flash?>.Default.Equals(Kling4Flash, other.Kling4Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestHailuo3Highspeed?>.Default.Equals(Hailuo3Highspeed, other.Hailuo3Highspeed) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestHailuo3Lite?>.Default.Equals(Hailuo3Lite, other.Hailuo3Lite) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance25Flash?>.Default.Equals(Seedance25Flash, other.Seedance25Flash)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateImageToVideoRequest obj1, CreateImageToVideoRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateImageToVideoRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateImageToVideoRequest obj1, CreateImageToVideoRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateImageToVideoRequest o && Equals(o);
        }
    }
}
