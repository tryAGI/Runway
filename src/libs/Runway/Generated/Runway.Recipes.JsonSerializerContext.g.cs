
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion), TypeInfoPropertyName = "CreateRecipesAdLocalizationRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage), TypeInfoPropertyName = "CreateRecipesAdLocalizationRequestTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion), TypeInfoPropertyName = "CreateRecipesMarketingStockImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestReferenceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality), TypeInfoPropertyName = "CreateRecipesMarketingStockImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestVersion), TypeInfoPropertyName = "CreateRecipesProductAdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdRequestStyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestStyleImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestRatio), TypeInfoPropertyName = "CreateRecipesProductAdRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion), TypeInfoPropertyName = "CreateRecipesProductCampaignImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestVersion), TypeInfoPropertyName = "CreateRecipesProductSwapRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestReferenceVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestOriginalProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapRequestNewProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView), TypeInfoPropertyName = "CreateRecipesProductSwapRequestNewProductImageView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestResolution), TypeInfoPropertyName = "CreateRecipesProductSwapRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequest), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1FirstFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant1Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2FirstFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestVariant2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode), TypeInfoPropertyName = "CreateRecipesMultiShotVideoRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestVersion), TypeInfoPropertyName = "CreateRecipesProductUgcRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestCharacterImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestProductImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestRatio), TypeInfoPropertyName = "CreateRecipesProductUgcRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesAdLocalizationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMarketingStockImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductAdResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductCampaignImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductSwapResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesMultiShotVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponseEstimatedCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.CreateRecipesProductUgcResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponseIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesAdLocalizationRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?), TypeInfoPropertyName = "NullableCreateRecipesAdLocalizationRequestTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesMarketingStockImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?), TypeInfoPropertyName = "NullableCreateRecipesMarketingStockImageRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductAdRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductAdRequestRatio?), TypeInfoPropertyName = "NullableCreateRecipesProductAdRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductCampaignImageRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestNewProductImageView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductSwapRequestResolution?), TypeInfoPropertyName = "NullableCreateRecipesProductSwapRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequest?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant1Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant1Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant2Version2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestVariant2Ratio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?), TypeInfoPropertyName = "NullableCreateRecipesMultiShotVideoRequestDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestVersion?), TypeInfoPropertyName = "NullableCreateRecipesProductUgcRequestVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateRecipesProductUgcRequestRatio?), TypeInfoPropertyName = "NullableCreateRecipesProductUgcRequestRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdRequestProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdRequestStyleImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductSwapRequestNewProductImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMultiShotVideoRequestVariant2Shot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesAdLocalizationResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMarketingStockImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductAdResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductCampaignImageResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductSwapResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesMultiShotVideoResponseIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.CreateRecipesProductUgcResponseIssue>))]
    internal sealed partial class RecipesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecipesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RecipesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RecipesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Runway.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage)

                    || typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode)

                    || typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion?)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio)

                    || typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesAdLocalizationRequestTargetLanguage?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesAdLocalizationRequestTargetLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMarketingStockImageRequestQuality?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMarketingStockImageRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductAdRequestRatio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductAdRequestRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductCampaignImageRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductCampaignImageRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestNewProductImageView?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestNewProductImageViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductSwapRequestResolution?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductSwapRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Version?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1VersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant1Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant1RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Version?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2VersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestVariant2Ratio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestVariant2RatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesMultiShotVideoRequestDiscriminatorMode?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesMultiShotVideoRequestDiscriminatorModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestVersion?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateRecipesProductUgcRequestRatio?))
                {
                    return new global::Runway.JsonConverters.CreateRecipesProductUgcRequestRatioNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RecipesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}