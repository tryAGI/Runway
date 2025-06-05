
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
            typeof(global::Runway.JsonConverters.CreateVideoFromImageRequestModelJsonConverter),
            typeof(global::Runway.JsonConverters.CreateVideoFromImageRequestModelNullableJsonConverter),
            typeof(global::Runway.JsonConverters.CreateVideoFromImageRequestRatioJsonConverter),
            typeof(global::Runway.JsonConverters.CreateVideoFromImageRequestRatioNullableJsonConverter),
            typeof(global::Runway.JsonConverters.CreateVideoFromImageXRunwayVersionJsonConverter),
            typeof(global::Runway.JsonConverters.CreateVideoFromImageXRunwayVersionNullableJsonConverter),
            typeof(global::Runway.JsonConverters.GetTaskDetailXRunwayVersionJsonConverter),
            typeof(global::Runway.JsonConverters.GetTaskDetailXRunwayVersionNullableJsonConverter),
            typeof(global::Runway.JsonConverters.CancelOrDeleteTaskXRunwayVersionJsonConverter),
            typeof(global::Runway.JsonConverters.CancelOrDeleteTaskXRunwayVersionNullableJsonConverter),
            typeof(global::Runway.JsonConverters.GetTaskDetailResponseStatusJsonConverter),
            typeof(global::Runway.JsonConverters.GetTaskDetailResponseStatusNullableJsonConverter),
            typeof(global::Runway.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runway.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}