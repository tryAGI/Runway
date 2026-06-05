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
        public global::Runway.CreateImageToVideoRequestGen45 PickGen45() => IsGen45
            ? Gen45!
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
        public global::Runway.CreateImageToVideoRequestGen4Turbo PickGen4Turbo() => IsGen4Turbo
            ? Gen4Turbo!
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
        public global::Runway.CreateImageToVideoRequestVeo31 PickVeo31() => IsVeo31
            ? Veo31!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestGen3aTurbo? Gen3aTurbo { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestGen3aTurbo? Gen3aTurbo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gen3aTurbo))]
#endif
        public bool IsGen3aTurbo => Gen3aTurbo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGen3aTurbo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateImageToVideoRequestGen3aTurbo? value)
        {
            value = Gen3aTurbo;
            return IsGen3aTurbo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateImageToVideoRequestGen3aTurbo PickGen3aTurbo() => IsGen3aTurbo
            ? Gen3aTurbo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gen3aTurbo' but the value was {ToString()}.");

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
        public global::Runway.CreateImageToVideoRequestVeo31Fast PickVeo31Fast() => IsVeo31Fast
            ? Veo31Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo31Fast' but the value was {ToString()}.");

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
        public global::Runway.CreateImageToVideoRequestHappyhorse10 PickHappyhorse10() => IsHappyhorse10
            ? Happyhorse10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Happyhorse10' but the value was {ToString()}.");

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
        public global::Runway.CreateImageToVideoRequestSeedance2 PickSeedance2() => IsSeedance2
            ? Seedance2!
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
        public global::Runway.CreateImageToVideoRequestSeedance2Fast PickSeedance2Fast() => IsSeedance2Fast
            ? Seedance2Fast!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Seedance2Fast' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateImageToVideoRequestVeo3? Veo3 { get; init; }
#else
        public global::Runway.CreateImageToVideoRequestVeo3? Veo3 { get; }
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
            out global::Runway.CreateImageToVideoRequestVeo3? value)
        {
            value = Veo3;
            return IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateImageToVideoRequestVeo3 PickVeo3() => IsVeo3
            ? Veo3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Veo3' but the value was {ToString()}.");
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
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen3aTurbo value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestGen3aTurbo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestGen3aTurbo?(CreateImageToVideoRequest @this) => @this.Gen3aTurbo;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestGen3aTurbo? value)
        {
            Gen3aTurbo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateImageToVideoRequest FromGen3aTurbo(global::Runway.CreateImageToVideoRequestGen3aTurbo? value) => new CreateImageToVideoRequest(value);

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
        public static implicit operator CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo3 value) => new CreateImageToVideoRequest((global::Runway.CreateImageToVideoRequestVeo3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateImageToVideoRequestVeo3?(CreateImageToVideoRequest @this) => @this.Veo3;

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(global::Runway.CreateImageToVideoRequestVeo3? value)
        {
            Veo3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateImageToVideoRequest FromVeo3(global::Runway.CreateImageToVideoRequestVeo3? value) => new CreateImageToVideoRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateImageToVideoRequest(
            global::Runway.CreateImageToVideoRequestDiscriminatorModel? model,
            global::Runway.CreateImageToVideoRequestGen45? gen45,
            global::Runway.CreateImageToVideoRequestGen4Turbo? gen4Turbo,
            global::Runway.CreateImageToVideoRequestVeo31? veo31,
            global::Runway.CreateImageToVideoRequestGen3aTurbo? gen3aTurbo,
            global::Runway.CreateImageToVideoRequestVeo31Fast? veo31Fast,
            global::Runway.CreateImageToVideoRequestHappyhorse10? happyhorse10,
            global::Runway.CreateImageToVideoRequestSeedance2? seedance2,
            global::Runway.CreateImageToVideoRequestSeedance2Fast? seedance2Fast,
            global::Runway.CreateImageToVideoRequestVeo3? veo3
            )
        {
            Model = model;

            Gen45 = gen45;
            Gen4Turbo = gen4Turbo;
            Veo31 = veo31;
            Gen3aTurbo = gen3aTurbo;
            Veo31Fast = veo31Fast;
            Happyhorse10 = happyhorse10;
            Seedance2 = seedance2;
            Seedance2Fast = seedance2Fast;
            Veo3 = veo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Veo3 as object ??
            Seedance2Fast as object ??
            Seedance2 as object ??
            Happyhorse10 as object ??
            Veo31Fast as object ??
            Gen3aTurbo as object ??
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
            Gen3aTurbo?.ToString() ??
            Veo31Fast?.ToString() ??
            Happyhorse10?.ToString() ??
            Seedance2?.ToString() ??
            Seedance2Fast?.ToString() ??
            Veo3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && IsSeedance2 && !IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && IsSeedance2Fast && !IsVeo3 || !IsGen45 && !IsGen4Turbo && !IsVeo31 && !IsGen3aTurbo && !IsVeo31Fast && !IsHappyhorse10 && !IsSeedance2 && !IsSeedance2Fast && IsVeo3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateImageToVideoRequestGen45, TResult>? gen45 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGen4Turbo, TResult>? gen4Turbo = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestVeo31, TResult>? veo31 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestGen3aTurbo, TResult>? gen3aTurbo = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestVeo31Fast, TResult>? veo31Fast = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestHappyhorse10, TResult>? happyhorse10 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance2, TResult>? seedance2 = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestSeedance2Fast, TResult>? seedance2Fast = null,
            global::System.Func<global::Runway.CreateImageToVideoRequestVeo3, TResult>? veo3 = null,
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
            else if (IsGen4Turbo && gen4Turbo != null)
            {
                return gen4Turbo(Gen4Turbo!);
            }
            else if (IsVeo31 && veo31 != null)
            {
                return veo31(Veo31!);
            }
            else if (IsGen3aTurbo && gen3aTurbo != null)
            {
                return gen3aTurbo(Gen3aTurbo!);
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
            global::System.Action<global::Runway.CreateImageToVideoRequestGen45>? gen45 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGen4Turbo>? gen4Turbo = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31>? veo31 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestGen3aTurbo>? gen3aTurbo = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31Fast>? veo31Fast = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestHappyhorse10>? happyhorse10 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2>? seedance2 = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Fast>? seedance2Fast = null,

            global::System.Action<global::Runway.CreateImageToVideoRequestVeo3>? veo3 = null,
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
            else if (IsGen4Turbo)
            {
                gen4Turbo?.Invoke(Gen4Turbo!);
            }
            else if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsGen3aTurbo)
            {
                gen3aTurbo?.Invoke(Gen3aTurbo!);
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
            else if (IsVeo3)
            {
                veo3?.Invoke(Veo3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateImageToVideoRequestGen45>? gen45 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGen4Turbo>? gen4Turbo = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31>? veo31 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestGen3aTurbo>? gen3aTurbo = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestVeo31Fast>? veo31Fast = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestHappyhorse10>? happyhorse10 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2>? seedance2 = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestSeedance2Fast>? seedance2Fast = null,
            global::System.Action<global::Runway.CreateImageToVideoRequestVeo3>? veo3 = null,
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
            else if (IsGen4Turbo)
            {
                gen4Turbo?.Invoke(Gen4Turbo!);
            }
            else if (IsVeo31)
            {
                veo31?.Invoke(Veo31!);
            }
            else if (IsGen3aTurbo)
            {
                gen3aTurbo?.Invoke(Gen3aTurbo!);
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
                typeof(global::Runway.CreateImageToVideoRequestGen45),
                Gen4Turbo,
                typeof(global::Runway.CreateImageToVideoRequestGen4Turbo),
                Veo31,
                typeof(global::Runway.CreateImageToVideoRequestVeo31),
                Gen3aTurbo,
                typeof(global::Runway.CreateImageToVideoRequestGen3aTurbo),
                Veo31Fast,
                typeof(global::Runway.CreateImageToVideoRequestVeo31Fast),
                Happyhorse10,
                typeof(global::Runway.CreateImageToVideoRequestHappyhorse10),
                Seedance2,
                typeof(global::Runway.CreateImageToVideoRequestSeedance2),
                Seedance2Fast,
                typeof(global::Runway.CreateImageToVideoRequestSeedance2Fast),
                Veo3,
                typeof(global::Runway.CreateImageToVideoRequestVeo3),
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
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestGen3aTurbo?>.Default.Equals(Gen3aTurbo, other.Gen3aTurbo) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestVeo31Fast?>.Default.Equals(Veo31Fast, other.Veo31Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestHappyhorse10?>.Default.Equals(Happyhorse10, other.Happyhorse10) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance2?>.Default.Equals(Seedance2, other.Seedance2) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestSeedance2Fast?>.Default.Equals(Seedance2Fast, other.Seedance2Fast) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateImageToVideoRequestVeo3?>.Default.Equals(Veo3, other.Veo3) 
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
