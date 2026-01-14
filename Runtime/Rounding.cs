using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// A type of rounding method.
    /// </summary>
    public enum Rounding
    {
        /// <summary>
        /// Rounds down to the nearest integer.
        /// </summary>
        [Tooltip("Rounds down to the nearest integer.")]
        Floor,

        /// <summary>
        /// Rounds down or up to the nearest integer. Half steps (0.5) round up.
        /// </summary>
        [Tooltip("Rounds down or up to the nearest integer. Half steps (0.5) round up.")]
        Round,

        /// <summary>
        /// Rounds up to the nearest integer.
        /// </summary>
        [Tooltip("Rounds up to the nearest integer.")]
        Ceil,

        /// <summary>
        /// Casts the result to an integer. This is similar to Floor except on
        /// negative numbers it rounds toward zero.
        /// </summary>
        [Tooltip("Casts the result to an integer. This is similar to Floor except on negative numbers it rounds toward zero.")]
        Cast,
    }

    /// <summary>
    /// Extension methods for <see cref="Rounding"/>.
    /// </summary>
    public static class RoundingExtensions
    {
        /// <summary>
        /// Applies the rounding method to the number x.
        /// </summary>
        /// <param name="rounding">The rounding method to use.</param>
        /// <param name="x">The number to round.</param>
        /// <returns>The rounded number.</returns>
        public static int Apply(this Rounding rounding, float x)
        {
            return rounding switch
            {
                Rounding.Floor => Mathf.FloorToInt(x),
                Rounding.Round => Mathf.RoundToInt(x),
                Rounding.Ceil => Mathf.CeilToInt(x),
                Rounding.Cast => (int)x,
                _ => (int)x,
            };
        }

    }

}
