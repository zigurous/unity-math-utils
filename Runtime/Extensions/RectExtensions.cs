using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Rect.
    /// </summary>
    public static class RectExtensions
    {
        /// <summary>
        /// Determines if the rect fully contains another rect.
        /// </summary>
        /// <param name="rect">The outer rect to test.</param>
        /// <param name="other">The inner rect to test.</param>
        /// <returns>True if the rect fully contains the other rect.</returns>
        public static bool Contains(this Rect rect, Rect other)
        {
            return rect.Contains(other.min) && rect.Contains(other.max);
        }

        /// <summary>
        /// Determines if the rect fully contains another rect. Points that
        /// overlap on the edges will be considered contained.
        /// </summary>
        /// <param name="rect">The outer rect to test.</param>
        /// <param name="other">The inner rect to test.</param>
        /// <returns>True if the rect fully contains the other rect.</returns>
        public static bool ContainsInclusive(this Rect rect, Rect other)
        {
            return other.min.x >= rect.min.x && other.min.y >= rect.min.y &&
                   other.max.x <= rect.max.x && other.max.y <= rect.max.y;
        }

    }

}
