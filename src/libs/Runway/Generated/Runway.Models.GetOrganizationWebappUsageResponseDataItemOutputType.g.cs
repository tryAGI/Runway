
#nullable enable

namespace Runway
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationWebappUsageResponseDataItemOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Cloud,
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Font,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Mesh,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        Splat,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationWebappUsageResponseDataItemOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationWebappUsageResponseDataItemOutputType value)
        {
            return value switch
            {
                GetOrganizationWebappUsageResponseDataItemOutputType.Audio => "audio",
                GetOrganizationWebappUsageResponseDataItemOutputType.Cloud => "cloud",
                GetOrganizationWebappUsageResponseDataItemOutputType.File => "file",
                GetOrganizationWebappUsageResponseDataItemOutputType.Font => "font",
                GetOrganizationWebappUsageResponseDataItemOutputType.Image => "image",
                GetOrganizationWebappUsageResponseDataItemOutputType.Mesh => "mesh",
                GetOrganizationWebappUsageResponseDataItemOutputType.Model => "model",
                GetOrganizationWebappUsageResponseDataItemOutputType.Project => "project",
                GetOrganizationWebappUsageResponseDataItemOutputType.Splat => "splat",
                GetOrganizationWebappUsageResponseDataItemOutputType.Text => "text",
                GetOrganizationWebappUsageResponseDataItemOutputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationWebappUsageResponseDataItemOutputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GetOrganizationWebappUsageResponseDataItemOutputType.Audio,
                "cloud" => GetOrganizationWebappUsageResponseDataItemOutputType.Cloud,
                "file" => GetOrganizationWebappUsageResponseDataItemOutputType.File,
                "font" => GetOrganizationWebappUsageResponseDataItemOutputType.Font,
                "image" => GetOrganizationWebappUsageResponseDataItemOutputType.Image,
                "mesh" => GetOrganizationWebappUsageResponseDataItemOutputType.Mesh,
                "model" => GetOrganizationWebappUsageResponseDataItemOutputType.Model,
                "project" => GetOrganizationWebappUsageResponseDataItemOutputType.Project,
                "splat" => GetOrganizationWebappUsageResponseDataItemOutputType.Splat,
                "text" => GetOrganizationWebappUsageResponseDataItemOutputType.Text,
                "video" => GetOrganizationWebappUsageResponseDataItemOutputType.Video,
                _ => null,
            };
        }
    }
}