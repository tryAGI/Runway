#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Runway
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PipelineItem : global::System.IEquatable<PipelineItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? Filter { get; init; }
#else
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? Filter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Filter))]
#endif
        public bool IsFilter => Filter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? value)
        {
            value = Filter;
            return IsFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1 PickFilter() => IsFilter
            ? Filter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Filter' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? Capacity { get; init; }
#else
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? Capacity { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Capacity))]
#endif
        public bool IsCapacity => Capacity != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCapacity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? value)
        {
            value = Capacity;
            return IsCapacity;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2 PickCapacity() => IsCapacity
            ? Capacity!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Capacity' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? Rank { get; init; }
#else
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? Rank { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rank))]
#endif
        public bool IsRank => Rank != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRank(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? value)
        {
            value = Rank;
            return IsRank;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3 PickRank() => IsRank
            ? Rank!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Rank' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1 value) => new PipelineItem((global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1?(PipelineItem @this) => @this.Filter;

        /// <summary>
        /// 
        /// </summary>
        public PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? value)
        {
            Filter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineItem FromFilter(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? value) => new PipelineItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2 value) => new PipelineItem((global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2?(PipelineItem @this) => @this.Capacity;

        /// <summary>
        /// 
        /// </summary>
        public PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? value)
        {
            Capacity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineItem FromCapacity(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? value) => new PipelineItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3 value) => new PipelineItem((global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3?(PipelineItem @this) => @this.Rank;

        /// <summary>
        /// 
        /// </summary>
        public PipelineItem(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? value)
        {
            Rank = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineItem FromRank(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? value) => new PipelineItem(value);

        /// <summary>
        /// 
        /// </summary>
        public PipelineItem(
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemDiscriminatorType? type,
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1? filter,
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2? capacity,
            global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3? rank
            )
        {
            Type = type;

            Filter = filter;
            Capacity = capacity;
            Rank = rank;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Rank as object ??
            Capacity as object ??
            Filter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Filter?.ToString() ??
            Capacity?.ToString() ??
            Rank?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFilter && !IsCapacity && !IsRank || !IsFilter && IsCapacity && !IsRank || !IsFilter && !IsCapacity && IsRank;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1, TResult>? filter = null,
            global::System.Func<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2, TResult>? capacity = null,
            global::System.Func<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3, TResult>? rank = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFilter && filter != null)
            {
                return filter(Filter!);
            }
            else if (IsCapacity && capacity != null)
            {
                return capacity(Capacity!);
            }
            else if (IsRank && rank != null)
            {
                return rank(Rank!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1>? filter = null,

            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2>? capacity = null,

            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3>? rank = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFilter)
            {
                filter?.Invoke(Filter!);
            }
            else if (IsCapacity)
            {
                capacity?.Invoke(Capacity!);
            }
            else if (IsRank)
            {
                rank?.Invoke(Rank!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1>? filter = null,
            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2>? capacity = null,
            global::System.Action<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3>? rank = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFilter)
            {
                filter?.Invoke(Filter!);
            }
            else if (IsCapacity)
            {
                capacity?.Invoke(Capacity!);
            }
            else if (IsRank)
            {
                rank?.Invoke(Rank!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Filter,
                typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1),
                Capacity,
                typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2),
                Rank,
                typeof(global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3),
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
        public bool Equals(PipelineItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant1?>.Default.Equals(Filter, other.Filter) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant2?>.Default.Equals(Capacity, other.Capacity) &&
                global::System.Collections.Generic.EqualityComparer<global::Runway.GetRoutersRequestsResponseDataItemPipelineItemVariant3?>.Default.Equals(Rank, other.Rank) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PipelineItem obj1, PipelineItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PipelineItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PipelineItem obj1, PipelineItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineItem o && Equals(o);
        }
    }
}
