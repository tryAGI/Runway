
#nullable enable

namespace Runway
{
    /// <summary>
    /// Optional view label for this reference (front, side, or back). Omit when supplying a single reference sheet or when view labels are unknown.
    /// </summary>
    public enum CreateRecipesProductSwapRequestNewProductImageView
    {
        /// <summary>
        /// 
        /// </summary>
        Back,
        /// <summary>
        /// 
        /// </summary>
        Front,
        /// <summary>
        /// 
        /// </summary>
        Side,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecipesProductSwapRequestNewProductImageViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecipesProductSwapRequestNewProductImageView value)
        {
            return value switch
            {
                CreateRecipesProductSwapRequestNewProductImageView.Back => "back",
                CreateRecipesProductSwapRequestNewProductImageView.Front => "front",
                CreateRecipesProductSwapRequestNewProductImageView.Side => "side",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecipesProductSwapRequestNewProductImageView? ToEnum(string value)
        {
            return value switch
            {
                "back" => CreateRecipesProductSwapRequestNewProductImageView.Back,
                "front" => CreateRecipesProductSwapRequestNewProductImageView.Front,
                "side" => CreateRecipesProductSwapRequestNewProductImageView.Side,
                _ => null,
            };
        }
    }
}