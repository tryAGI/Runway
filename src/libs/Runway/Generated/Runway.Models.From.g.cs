#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct From : global::System.IEquatable<From>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.CreateVoicesRequestFromDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVoicesRequestFromVoiceFromAudio? Audio { get; init; }
#else
        public global::Runway.CreateVoicesRequestFromVoiceFromAudio? Audio { get; }
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
            out global::Runway.CreateVoicesRequestFromVoiceFromAudio? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.CreateVoicesRequestFromVoiceFromText? Text { get; init; }
#else
        public global::Runway.CreateVoicesRequestFromVoiceFromText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.CreateVoicesRequestFromVoiceFromText? value)
        {
            value = Text;
            return IsText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator From(global::Runway.CreateVoicesRequestFromVoiceFromAudio value) => new From((global::Runway.CreateVoicesRequestFromVoiceFromAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVoicesRequestFromVoiceFromAudio?(From @this) => @this.Audio;

        /// <summary>
        /// 
        /// </summary>
        public From(global::Runway.CreateVoicesRequestFromVoiceFromAudio? value)
        {
            Audio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator From(global::Runway.CreateVoicesRequestFromVoiceFromText value) => new From((global::Runway.CreateVoicesRequestFromVoiceFromText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.CreateVoicesRequestFromVoiceFromText?(From @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public From(global::Runway.CreateVoicesRequestFromVoiceFromText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public From(
            global::Runway.CreateVoicesRequestFromDiscriminatorType? type,
            global::Runway.CreateVoicesRequestFromVoiceFromAudio? audio,
            global::Runway.CreateVoicesRequestFromVoiceFromText? text
            )
        {
            Type = type;

            Audio = audio;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Audio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsText || !IsAudio && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.CreateVoicesRequestFromVoiceFromAudio, TResult>? audio = null,
            global::System.Func<global::Runway.CreateVoicesRequestFromVoiceFromText, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.CreateVoicesRequestFromVoiceFromAudio>? audio = null,

            global::System.Action<global::Runway.CreateVoicesRequestFromVoiceFromText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.CreateVoicesRequestFromVoiceFromAudio>? audio = null,
            global::System.Action<global::Runway.CreateVoicesRequestFromVoiceFromText>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Audio,
                typeof(global::Runway.CreateVoicesRequestFromVoiceFromAudio),
                Text,
                typeof(global::Runway.CreateVoicesRequestFromVoiceFromText),
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
        public bool Equals(From other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVoicesRequestFromVoiceFromAudio?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.CreateVoicesRequestFromVoiceFromText?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(From obj1, From obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<From>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(From obj1, From obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is From o && Equals(o);
        }
    }
}
