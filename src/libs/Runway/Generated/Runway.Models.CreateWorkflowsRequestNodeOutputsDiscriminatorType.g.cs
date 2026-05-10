
#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWorkflowsRequestNodeOutputsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Primitive,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkflowsRequestNodeOutputsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowsRequestNodeOutputsDiscriminatorType value)
        {
            return value switch
            {
                CreateWorkflowsRequestNodeOutputsDiscriminatorType.Audio => "audio",
                CreateWorkflowsRequestNodeOutputsDiscriminatorType.Image => "image",
                CreateWorkflowsRequestNodeOutputsDiscriminatorType.Primitive => "primitive",
                CreateWorkflowsRequestNodeOutputsDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowsRequestNodeOutputsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateWorkflowsRequestNodeOutputsDiscriminatorType.Audio,
                "image" => CreateWorkflowsRequestNodeOutputsDiscriminatorType.Image,
                "primitive" => CreateWorkflowsRequestNodeOutputsDiscriminatorType.Primitive,
                "video" => CreateWorkflowsRequestNodeOutputsDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}