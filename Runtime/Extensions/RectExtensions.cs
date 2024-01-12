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
        /// <param name="includeEdges">Whether to include points that overlap on the edges (default=true).</param>
        /// <returns>True if the rect fully contains the other rect.</returns>
        public static bool Contains(this Rect rect, Rect other, bool includeEdges = true)
        {
            if (includeEdges)
            {
                return other.min.x >= rect.min.x && other.min.y >= rect.min.y &&
                       other.max.x <= rect.max.x && other.max.y <= rect.max.y;
            }
            else
            {
                return other.min.x > rect.min.x && other.min.y > rect.min.y &&
                       other.max.x < rect.max.x && other.max.y < rect.max.y;
            }
        }

        /// <summary>
        /// Grows the rect to fully encapsulate another rect.
        /// </summary>
        /// <param name="rect">The rect to grow.</param>
        /// <param name="other">The rect to encapsulate.</param>
        public static void Encapsulate(this ref Rect rect, Rect other)
        {
            rect = Rect.MinMaxRect(
                    Mathf.Min(rect.xMin, other.xMin),
                    Mathf.Min(rect.yMin, other.yMin),
                    Mathf.Max(rect.xMax, other.xMax),
                    Mathf.Max(rect.yMax, other.yMax));
        }

        /// <summary>
        /// Linearly interpolates between the rect's minimum and maximum values
        /// along each axis.
        /// </summary>
        /// <param name="rect">The rect to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector2 Lerp(this Rect rect, Vector2 t)
        {
            return new Vector2
            {
                x = Mathf.Lerp(rect.min.x, rect.max.x, t.x),
                y = Mathf.Lerp(rect.min.y, rect.max.y, t.y)
            };
        }

        /// <summary>
        /// Linearly interpolates between the rect's minimum and maximum values
        /// along each axis with no limit to <paramref name="t"/>.
        /// </summary>
        /// <param name="rect">The rect to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector2 LerpUnclamped(this Rect rect, Vector2 t)
        {
            return new Vector2
            {
                x = Mathf.LerpUnclamped(rect.min.x, rect.max.x, t.x),
                y = Mathf.LerpUnclamped(rect.min.y, rect.max.y, t.y)
            };
        }

        /// <summary>
        /// Returns the linear parameter <c>t</c> that produces the interpolant
        /// for each axis within the rect's minimum and maximum values.
        /// </summary>
        /// <param name="rect">The rect to get the linear parameter from.</param>
        /// <param name="position">A position within the rect.</param>
        /// <returns>The linear parameter <c>t</c> where each axis falls in the range [0..1].</returns>
        public static Vector2 InverseLerp(this Rect rect, Vector2 position)
        {
            return new Vector2
            {
                x = Mathf.InverseLerp(rect.min.x, rect.max.x, position.x),
                y = Mathf.InverseLerp(rect.min.y, rect.max.y, position.y)
            };
        }

    }

}
