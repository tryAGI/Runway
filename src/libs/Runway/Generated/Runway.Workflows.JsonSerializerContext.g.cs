
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.NodeOutputs), TypeInfoPropertyName = "NodeOutputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?, bool?>), TypeInfoPropertyName = "AnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType), TypeInfoPropertyName = "CreateWorkflowsRequestNodeOutputsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runway.GetWorkflowsResponseDataItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowsResponseDataItemVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse), TypeInfoPropertyName = "GetWorkflowInvocationsResponse2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationPending))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationThrottled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationRunningNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailedNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationFailedNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceeded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseWorkflowInvocationSucceededNodeErrors2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus), TypeInfoPropertyName = "GetWorkflowInvocationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.NodeOutputs?), TypeInfoPropertyName = "NullableNodeOutputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.AnyOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableAnyOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?), TypeInfoPropertyName = "NullableCreateWorkflowsRequestNodeOutputsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponse?), TypeInfoPropertyName = "NullableGetWorkflowInvocationsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetWorkflowInvocationsResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runway.GetWorkflowsResponseDataItemVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class WorkflowsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkflowsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkflowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Runway.JsonConverters.NodeOutputsJsonConverter());
            options.Converters.Add(new global::Runway.JsonConverters.GetWorkflowInvocationsResponseJsonConverter());
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
                    typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType)

                    || typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?)

                    || typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType))
                {
                    return new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType?))
                {
                    return new global::Runway.JsonConverters.CreateWorkflowsRequestNodeOutputsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus))
                {
                    return new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Runway.GetWorkflowInvocationsResponseDiscriminatorStatus?))
                {
                    return new global::Runway.JsonConverters.GetWorkflowInvocationsResponseDiscriminatorStatusNullableJsonConverter();
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
                    0 => new WorkflowsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}