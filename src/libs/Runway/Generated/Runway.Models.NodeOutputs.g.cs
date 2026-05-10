#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeOutputs : global::System.IEquatable<NodeOutputs>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType? Type { get; }

        /// <summary>
        /// A primitive value (string, number, or boolean)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? Primitive { get; init; }
#else
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? Primitive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Primitive))]
#endif
        public bool IsPrimitive => Primitive != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPrimitive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? value)
        {
            value = Primitive;
            return IsPrimitive;
        }

        /// <summary>
        /// An image asset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? Image { get; init; }
#else
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// A video asset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? Video { get; init; }
#else
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// An audio asset
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? Audio { get; init; }
#else
        public global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? Audio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? value)
        {
            value = Audio;
            return IsAudio;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive value) => new NodeOutputs((global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive?(NodeOutputs @this) => @this.Primitive;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? value)
        {
            Primitive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NodeOutputs FromPrimitive(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? value) => new NodeOutputs(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage value) => new NodeOutputs((global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage?(NodeOutputs @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NodeOutputs FromImage(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? value) => new NodeOutputs(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo value) => new NodeOutputs((global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo?(NodeOutputs @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NodeOutputs FromVideo(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? value) => new NodeOutputs(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio value) => new NodeOutputs((global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio?(NodeOutputs @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputs(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NodeOutputs FromAudio(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? value) => new NodeOutputs(value);

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputs(
            global::Runway.CreateWorkflowsRequestNodeOutputsDiscriminatorType? type,
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive? primitive,
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage? image,
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo? video,
            global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio? audio
            )
        {
            Type = type;

            Primitive = primitive;
            Image = image;
            Video = video;
            Audio = audio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Audio as object ??
            Video as object ??
            Image as object ??
            Primitive as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Primitive?.ToString() ??
            Image?.ToString() ??
            Video?.ToString() ??
            Audio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrimitive && !IsImage && !IsVideo && !IsAudio || !IsPrimitive && IsImage && !IsVideo && !IsAudio || !IsPrimitive && !IsImage && IsVideo && !IsAudio || !IsPrimitive && !IsImage && !IsVideo && IsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive, TResult>? primitive = null,
            global::System.Func<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage, TResult>? image = null,
            global::System.Func<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo, TResult>? video = null,
            global::System.Func<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio, TResult>? audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrimitive && primitive != null)
            {
                return primitive(Primitive!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive>? primitive = null,

            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage>? image = null,

            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo>? video = null,

            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio>? audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrimitive)
            {
                primitive?.Invoke(Primitive!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive>? primitive = null,
            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage>? image = null,
            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo>? video = null,
            global::System.Action<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio>? audio = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrimitive)
            {
                primitive?.Invoke(Primitive!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Primitive,
                typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive),
                Image,
                typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage),
                Video,
                typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo),
                Audio,
                typeof(global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio),
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
        public bool Equals(NodeOutputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputPrimitive?>.Default.Equals(Primitive, other.Primitive) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputImage?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputVideo?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateWorkflowsRequestNodeOutputsWorkflowNodeOutputAudio?>.Default.Equals(Audio, other.Audio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeOutputs obj1, NodeOutputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeOutputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeOutputs obj1, NodeOutputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeOutputs o && Equals(o);
        }
    }
}
