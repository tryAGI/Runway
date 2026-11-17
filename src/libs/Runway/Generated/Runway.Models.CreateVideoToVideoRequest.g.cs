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
        public global::Runway.CreateVideoToVideoRequestVariant1 PickAleph2() => Aleph2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Aleph2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestKlingO34k? KlingO34k { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestKlingO34k? KlingO34k { get; }
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
            out global::Runway.CreateVideoToVideoRequestKlingO34k? value)
        {
            value = KlingO34k;
            return IsKlingO34k;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestKlingO34k PickKlingO34k() => KlingO34k is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO34k' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestHailuo3? Hailuo3 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestHailuo3? Hailuo3 { get; }
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
            out global::Runway.CreateVideoToVideoRequestHailuo3? value)
        {
            value = Hailuo3;
            return IsHailuo3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestHailuo3 PickHailuo3() => Hailuo3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hailuo3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestKlingO3Pro? KlingO3Pro { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestKlingO3Pro? KlingO3Pro { get; }
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
            out global::Runway.CreateVideoToVideoRequestKlingO3Pro? value)
        {
            value = KlingO3Pro;
            return IsKlingO3Pro;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestKlingO3Pro PickKlingO3Pro() => KlingO3Pro is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO3Pro' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestKlingO3Standard? KlingO3Standard { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestKlingO3Standard? KlingO3Standard { get; }
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
            out global::Runway.CreateVideoToVideoRequestKlingO3Standard? value)
        {
            value = KlingO3Standard;
            return IsKlingO3Standard;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestKlingO3Standard PickKlingO3Standard() => KlingO3Standard is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KlingO3Standard' but the value was {ToString()}.");

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
        public global::Runway.CreateVideoToVideoRequestSeedance2 PickSeedance2() => Seedance2 is { } value
            ? value
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
        public global::Runway.CreateVideoToVideoRequestSeedance2Fast PickSeedance2Fast() => Seedance2Fast is { } value
            ? value
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
        public global::Runway.CreateVideoToVideoRequestSeedance2Mini PickSeedance2Mini() => Seedance2Mini is { } value
            ? value
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
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash PickGeminiOmniFlash() => GeminiOmniFlash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? GeminiOmniFlash11 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? GeminiOmniFlash11 { get; }
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
            out global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? value)
        {
            value = GeminiOmniFlash11;
            return IsGeminiOmniFlash11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11 PickGeminiOmniFlash11() => GeminiOmniFlash11 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestSeedance25? Seedance25 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestSeedance25? Seedance25 { get; }
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
            out global::Runway.CreateVideoToVideoRequestSeedance25? value)
        {
            value = Seedance25;
            return IsSeedance25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestSeedance25 PickSeedance25() => Seedance25 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance25' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestKling4? Kling4 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestKling4? Kling4 { get; }
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
            out global::Runway.CreateVideoToVideoRequestKling4? value)
        {
            value = Kling4;
            return IsKling4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestKling4 PickKling4() => Kling4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestKling4Flash? Kling4Flash { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestKling4Flash? Kling4Flash { get; }
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
            out global::Runway.CreateVideoToVideoRequestKling4Flash? value)
        {
            value = Kling4Flash;
            return IsKling4Flash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestKling4Flash PickKling4Flash() => Kling4Flash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Kling4Flash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? GeminiOmniFlash12 { get; init; }
#else
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? GeminiOmniFlash12 { get; }
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
            out global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? value)
        {
            value = GeminiOmniFlash12;
            return IsGeminiOmniFlash12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12 PickGeminiOmniFlash12() => GeminiOmniFlash12 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GeminiOmniFlash12' but the value was {ToString()}.");
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
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO34k value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestKlingO34k?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestKlingO34k?(CreateVideoToVideoRequest @this) => @this.KlingO34k;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO34k? value)
        {
            KlingO34k = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromKlingO34k(global::Runway.CreateVideoToVideoRequestKlingO34k? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestHailuo3 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestHailuo3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestHailuo3?(CreateVideoToVideoRequest @this) => @this.Hailuo3;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestHailuo3? value)
        {
            Hailuo3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromHailuo3(global::Runway.CreateVideoToVideoRequestHailuo3? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO3Pro value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestKlingO3Pro?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestKlingO3Pro?(CreateVideoToVideoRequest @this) => @this.KlingO3Pro;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO3Pro? value)
        {
            KlingO3Pro = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromKlingO3Pro(global::Runway.CreateVideoToVideoRequestKlingO3Pro? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO3Standard value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestKlingO3Standard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestKlingO3Standard?(CreateVideoToVideoRequest @this) => @this.KlingO3Standard;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKlingO3Standard? value)
        {
            KlingO3Standard = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromKlingO3Standard(global::Runway.CreateVideoToVideoRequestKlingO3Standard? value) => new CreateVideoToVideoRequest(value);

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
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11?(CreateVideoToVideoRequest @this) => @this.GeminiOmniFlash11;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? value)
        {
            GeminiOmniFlash11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromGeminiOmniFlash11(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance25 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestSeedance25?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestSeedance25?(CreateVideoToVideoRequest @this) => @this.Seedance25;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestSeedance25? value)
        {
            Seedance25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromSeedance25(global::Runway.CreateVideoToVideoRequestSeedance25? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKling4 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestKling4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestKling4?(CreateVideoToVideoRequest @this) => @this.Kling4;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKling4? value)
        {
            Kling4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromKling4(global::Runway.CreateVideoToVideoRequestKling4? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKling4Flash value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestKling4Flash?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestKling4Flash?(CreateVideoToVideoRequest @this) => @this.Kling4Flash;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestKling4Flash? value)
        {
            Kling4Flash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromKling4Flash(global::Runway.CreateVideoToVideoRequestKling4Flash? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12 value) => new CreateVideoToVideoRequest((global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12?(CreateVideoToVideoRequest @this) => @this.GeminiOmniFlash12;

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? value)
        {
            GeminiOmniFlash12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateVideoToVideoRequest FromGeminiOmniFlash12(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? value) => new CreateVideoToVideoRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateVideoToVideoRequest(
            global::Runway.CreateVideoToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateVideoToVideoRequestVariant1? aleph2,
            global::Runway.CreateVideoToVideoRequestKlingO34k? klingO34k,
            global::Runway.CreateVideoToVideoRequestHailuo3? hailuo3,
            global::Runway.CreateVideoToVideoRequestKlingO3Pro? klingO3Pro,
            global::Runway.CreateVideoToVideoRequestKlingO3Standard? klingO3Standard,
            global::Runway.CreateVideoToVideoRequestSeedance2? seedance2,
            global::Runway.CreateVideoToVideoRequestSeedance2Fast? seedance2Fast,
            global::Runway.CreateVideoToVideoRequestSeedance2Mini? seedance2Mini,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash? geminiOmniFlash,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11? geminiOmniFlash11,
            global::Runway.CreateVideoToVideoRequestSeedance25? seedance25,
            global::Runway.CreateVideoToVideoRequestKling4? kling4,
            global::Runway.CreateVideoToVideoRequestKling4Flash? kling4Flash,
            global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12? geminiOmniFlash12
            )
        {
            Model = model;

            Aleph2 = aleph2;
            KlingO34k = klingO34k;
            Hailuo3 = hailuo3;
            KlingO3Pro = klingO3Pro;
            KlingO3Standard = klingO3Standard;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
            Seedance2Mini = seedance2Mini;
            GeminiOmniFlash = geminiOmniFlash;
            GeminiOmniFlash11 = geminiOmniFlash11;
            Seedance25 = seedance25;
            Kling4 = kling4;
            Kling4Flash = kling4Flash;
            GeminiOmniFlash12 = geminiOmniFlash12;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GeminiOmniFlash12 as object ??
            Kling4Flash as object ??
            Kling4 as object ??
            Seedance25 as object ??
            GeminiOmniFlash11 as object ??
            GeminiOmniFlash as object ??
            Seedance2Mini as object ??
            Seedance2Fast as object ??
            Seedance2 as object ??
            KlingO3Standard as object ??
            KlingO3Pro as object ??
            Hailuo3 as object ??
            KlingO34k as object ??
            Aleph2 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Aleph2?.ToString() ??
            KlingO34k?.ToString() ??
            Hailuo3?.ToString() ??
            KlingO3Pro?.ToString() ??
            KlingO3Standard?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() ??
            Seedance2Mini?.ToString() ??
            GeminiOmniFlash?.ToString() ??
            GeminiOmniFlash11?.ToString() ??
            Seedance25?.ToString() ??
            Kling4?.ToString() ??
            Kling4Flash?.ToString() ??
            GeminiOmniFlash12?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && IsSeedance25 && !IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && IsKling4 && !IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && IsKling4Flash && !IsGeminiOmniFlash12 || !IsAleph2 && !IsKlingO34k && !IsHailuo3 && !IsKlingO3Pro && !IsKlingO3Standard && !IsSeedance2 && !IsSeedance2Fast && !IsSeedance2Mini && !IsGeminiOmniFlash && !IsGeminiOmniFlash11 && !IsSeedance25 && !IsKling4 && !IsKling4Flash && IsGeminiOmniFlash12;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVideoToVideoRequestVariant1, TResult>? aleph2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestKlingO34k, TResult>? klingO34k = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestHailuo3, TResult>? hailuo3 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestKlingO3Pro, TResult>? klingO3Pro = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestKlingO3Standard, TResult>? klingO3Standard = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance2Mini, TResult>? seedance2Mini = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash, TResult>? geminiOmniFlash = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11, TResult>? geminiOmniFlash11 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestSeedance25, TResult>? seedance25 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestKling4, TResult>? kling4 = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestKling4Flash, TResult>? kling4Flash = null,
            global::System.Func<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12, TResult>? geminiOmniFlash12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aleph2 is { } __value0 && aleph2 != null)
            {
                return aleph2(__value0);
            }
            else if (KlingO34k is { } __value1 && klingO34k != null)
            {
                return klingO34k(__value1);
            }
            else if (Hailuo3 is { } __value2 && hailuo3 != null)
            {
                return hailuo3(__value2);
            }
            else if (KlingO3Pro is { } __value3 && klingO3Pro != null)
            {
                return klingO3Pro(__value3);
            }
            else if (KlingO3Standard is { } __value4 && klingO3Standard != null)
            {
                return klingO3Standard(__value4);
            }
            else if (Seedance2 is { } __value5 && seedance2 != null)
            {
                return seedance2(__value5);
            }
            else if (Seedance2Fast is { } __value6 && seedance2Fast != null)
            {
                return seedance2Fast(__value6);
            }
            else if (Seedance2Mini is { } __value7 && seedance2Mini != null)
            {
                return seedance2Mini(__value7);
            }
            else if (GeminiOmniFlash is { } __value8 && geminiOmniFlash != null)
            {
                return geminiOmniFlash(__value8);
            }
            else if (GeminiOmniFlash11 is { } __value9 && geminiOmniFlash11 != null)
            {
                return geminiOmniFlash11(__value9);
            }
            else if (Seedance25 is { } __value10 && seedance25 != null)
            {
                return seedance25(__value10);
            }
            else if (Kling4 is { } __value11 && kling4 != null)
            {
                return kling4(__value11);
            }
            else if (Kling4Flash is { } __value12 && kling4Flash != null)
            {
                return kling4Flash(__value12);
            }
            else if (GeminiOmniFlash12 is { } __value13 && geminiOmniFlash12 != null)
            {
                return geminiOmniFlash12(__value13);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVideoToVideoRequestVariant1>? aleph2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO34k>? klingO34k = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestHailuo3>? hailuo3 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO3Pro>? klingO3Pro = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO3Standard>? klingO3Standard = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Mini>? seedance2Mini = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11>? geminiOmniFlash11 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance25>? seedance25 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestKling4>? kling4 = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestKling4Flash>? kling4Flash = null,

            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12>? geminiOmniFlash12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aleph2 is { } __value0)
            {
                aleph2?.Invoke(__value0);
            }
            else if (KlingO34k is { } __value1)
            {
                klingO34k?.Invoke(__value1);
            }
            else if (Hailuo3 is { } __value2)
            {
                hailuo3?.Invoke(__value2);
            }
            else if (KlingO3Pro is { } __value3)
            {
                klingO3Pro?.Invoke(__value3);
            }
            else if (KlingO3Standard is { } __value4)
            {
                klingO3Standard?.Invoke(__value4);
            }
            else if (Seedance2 is { } __value5)
            {
                seedance2?.Invoke(__value5);
            }
            else if (Seedance2Fast is { } __value6)
            {
                seedance2Fast?.Invoke(__value6);
            }
            else if (Seedance2Mini is { } __value7)
            {
                seedance2Mini?.Invoke(__value7);
            }
            else if (GeminiOmniFlash is { } __value8)
            {
                geminiOmniFlash?.Invoke(__value8);
            }
            else if (GeminiOmniFlash11 is { } __value9)
            {
                geminiOmniFlash11?.Invoke(__value9);
            }
            else if (Seedance25 is { } __value10)
            {
                seedance25?.Invoke(__value10);
            }
            else if (Kling4 is { } __value11)
            {
                kling4?.Invoke(__value11);
            }
            else if (Kling4Flash is { } __value12)
            {
                kling4Flash?.Invoke(__value12);
            }
            else if (GeminiOmniFlash12 is { } __value13)
            {
                geminiOmniFlash12?.Invoke(__value13);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVideoToVideoRequestVariant1>? aleph2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO34k>? klingO34k = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestHailuo3>? hailuo3 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO3Pro>? klingO3Pro = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestKlingO3Standard>? klingO3Standard = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Fast>? seedance2Fast = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance2Mini>? seedance2Mini = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash>? geminiOmniFlash = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11>? geminiOmniFlash11 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestSeedance25>? seedance25 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestKling4>? kling4 = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestKling4Flash>? kling4Flash = null,
            global::System.Action<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12>? geminiOmniFlash12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Aleph2 is { } __value0)
            {
                aleph2?.Invoke(__value0);
            }
            else if (KlingO34k is { } __value1)
            {
                klingO34k?.Invoke(__value1);
            }
            else if (Hailuo3 is { } __value2)
            {
                hailuo3?.Invoke(__value2);
            }
            else if (KlingO3Pro is { } __value3)
            {
                klingO3Pro?.Invoke(__value3);
            }
            else if (KlingO3Standard is { } __value4)
            {
                klingO3Standard?.Invoke(__value4);
            }
            else if (Seedance2 is { } __value5)
            {
                seedance2?.Invoke(__value5);
            }
            else if (Seedance2Fast is { } __value6)
            {
                seedance2Fast?.Invoke(__value6);
            }
            else if (Seedance2Mini is { } __value7)
            {
                seedance2Mini?.Invoke(__value7);
            }
            else if (GeminiOmniFlash is { } __value8)
            {
                geminiOmniFlash?.Invoke(__value8);
            }
            else if (GeminiOmniFlash11 is { } __value9)
            {
                geminiOmniFlash11?.Invoke(__value9);
            }
            else if (Seedance25 is { } __value10)
            {
                seedance25?.Invoke(__value10);
            }
            else if (Kling4 is { } __value11)
            {
                kling4?.Invoke(__value11);
            }
            else if (Kling4Flash is { } __value12)
            {
                kling4Flash?.Invoke(__value12);
            }
            else if (GeminiOmniFlash12 is { } __value13)
            {
                geminiOmniFlash12?.Invoke(__value13);
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
                KlingO34k,
                typeof(global::Runway.CreateVideoToVideoRequestKlingO34k),
                Hailuo3,
                typeof(global::Runway.CreateVideoToVideoRequestHailuo3),
                KlingO3Pro,
                typeof(global::Runway.CreateVideoToVideoRequestKlingO3Pro),
                KlingO3Standard,
                typeof(global::Runway.CreateVideoToVideoRequestKlingO3Standard),
                Seedance2,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2Fast),
                Seedance2Mini,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance2Mini),
                GeminiOmniFlash,
                typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash),
                GeminiOmniFlash11,
                typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11),
                Seedance25,
                typeof(global::Runway.CreateVideoToVideoRequestSeedance25),
                Kling4,
                typeof(global::Runway.CreateVideoToVideoRequestKling4),
                Kling4Flash,
                typeof(global::Runway.CreateVideoToVideoRequestKling4Flash),
                GeminiOmniFlash12,
                typeof(global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestKlingO34k?>.Default.Equals(KlingO34k, other.KlingO34k) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestHailuo3?>.Default.Equals(Hailuo3, other.Hailuo3) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestKlingO3Pro?>.Default.Equals(KlingO3Pro, other.KlingO3Pro) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestKlingO3Standard?>.Default.Equals(KlingO3Standard, other.KlingO3Standard) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance2Mini?>.Default.Equals(Seedance2Mini, other.Seedance2Mini) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash?>.Default.Equals(GeminiOmniFlash, other.GeminiOmniFlash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash11?>.Default.Equals(GeminiOmniFlash11, other.GeminiOmniFlash11) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestSeedance25?>.Default.Equals(Seedance25, other.Seedance25) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestKling4?>.Default.Equals(Kling4, other.Kling4) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestKling4Flash?>.Default.Equals(Kling4Flash, other.Kling4Flash) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVideoToVideoRequestGeminiOmniFlash12?>.Default.Equals(GeminiOmniFlash12, other.GeminiOmniFlash12)
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
