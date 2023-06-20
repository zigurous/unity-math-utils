using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Bounds.
    /// </summary>
    public static class BoundsExtensions
    {
        /// <summary>
        /// Linearly interpolates between the bounds' minimum and maximum values
        /// along each axis.
        /// </summary>
        /// <param name="bounds">The bounds to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector3 Lerp(this Bounds bounds, Vector3 t)
        {
            Vector3 position = new Vector3();
            position.x = Mathf.Lerp(bounds.min.x, bounds.max.x, t.x);
            position.y = Mathf.Lerp(bounds.min.y, bounds.max.y, t.y);
            position.z = Mathf.Lerp(bounds.min.z, bounds.max.z, t.z);
            return position;
        }

        /// <summary>
        /// Linearly interpolates between the bounds' minimum and maximum values
        /// along each axis.
        /// </summary>
        /// <param name="bounds">The bounds to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector3Int Lerp(this BoundsInt bounds, Vector3 t)
        {
            Vector3Int position = new Vector3Int();
            position.x = (int)Mathf.Lerp(bounds.min.x, bounds.max.x, t.x);
            position.y = (int)Mathf.Lerp(bounds.min.y, bounds.max.y, t.y);
            position.z = (int)Mathf.Lerp(bounds.min.z, bounds.max.z, t.z);
            return position;
        }

        /// <summary>
        /// Linearly interpolates between the bounds' minimum and maximum values
        /// along each axis with no limit to <paramref name="t"/>.
        /// </summary>
        /// <param name="bounds">The bounds to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector3 LerpUnclamped(this Bounds bounds, Vector3 t)
        {
            Vector3 position = new Vector3();
            position.x = Mathf.LerpUnclamped(bounds.min.x, bounds.max.x, t.x);
            position.y = Mathf.LerpUnclamped(bounds.min.y, bounds.max.y, t.y);
            position.z = Mathf.LerpUnclamped(bounds.min.z, bounds.max.z, t.z);
            return position;
        }

        /// <summary>
        /// Linearly interpolates between the bounds' minimum and maximum values
        /// along each axis with no limit to <paramref name="t"/>.
        /// </summary>
        /// <param name="bounds">The bounds to interpolate between.</param>
        /// <param name="t">The interpolation value for each axis.</param>
        /// <returns>The position as a result of the interpolation.</returns>
        public static Vector3Int LerpUnclamped(this BoundsInt bounds, Vector3 t)
        {
            Vector3Int position = new Vector3Int();
            position.x = (int)Mathf.LerpUnclamped(bounds.min.x, bounds.max.x, t.x);
            position.y = (int)Mathf.LerpUnclamped(bounds.min.y, bounds.max.y, t.y);
            position.z = (int)Mathf.LerpUnclamped(bounds.min.z, bounds.max.z, t.z);
            return position;
        }

        /// <summary>
        /// Returns the linear parameter <c>t</c> that produces the interpolant
        /// for each axis within the bounds' minimum and maximum values.
        /// </summary>
        /// <param name="bounds">The bounds to get the linear parameter from.</param>
        /// <param name="position">A position within the bounds.</param>
        /// <returns>The linear parameter <c>t</c> where each axis falls in the range [0..1].</returns>
        public static Vector3 InverseLerp(this Bounds bounds, Vector3 position)
        {
            Vector3 t = new Vector3();
            t.x = Mathf.InverseLerp(bounds.min.x, bounds.max.x, position.x);
            t.y = Mathf.InverseLerp(bounds.min.y, bounds.max.y, position.y);
            t.z = Mathf.InverseLerp(bounds.min.z, bounds.max.z, position.z);
            return t;
        }

        /// <summary>
        /// Returns the linear parameter <c>t</c> that produces the interpolant
        /// for each axis within the bounds' minimum and maximum values.
        /// </summary>
        /// <param name="bounds">The bounds to get the linear parameter from.</param>
        /// <param name="position">A position within the bounds.</param>
        /// <returns>The linear parameter <c>t</c> where each axis falls in the range [0..1].</returns>
        public static Vector3 InverseLerp(this BoundsInt bounds, Vector3Int position)
        {
            Vector3 t = new Vector3();
            t.x = Mathf.InverseLerp(bounds.min.x, bounds.max.x, position.x);
            t.y = Mathf.InverseLerp(bounds.min.y, bounds.max.y, position.y);
            t.z = Mathf.InverseLerp(bounds.min.z, bounds.max.z, position.z);
            return t;
        }

        /// <summary>
        /// Calculates the scale of the bounds required to fit inside another bounds.
        /// </summary>
        /// <param name="bounds">The bounds to calculate the scale of.</param>
        /// <param name="areaToFit">The bounds to fit inside.</param>
        /// <param name="epsilon">The minimum value for each axis to be considered (default=0.00001).</param>
        /// <returns>The scale of the bounds required to fit inside the area.</returns>
        public static float CalculateScale(this Bounds bounds, Bounds areaToFit, float epsilon = 0.00001f)
        {
            float scale = Mathf.Infinity;

            scale = CompareAxis(areaToFit.size.x, bounds.size.x, scale, epsilon);
            scale = CompareAxis(areaToFit.size.y, bounds.size.y, scale, epsilon);
            scale = CompareAxis(areaToFit.size.z, bounds.size.z, scale, epsilon);

            if (scale != Mathf.Infinity) {
                return scale;
            } else {
                return 1f;
            }
        }

        /// <summary>
        /// Calculates the scale of the bounds required to fit inside another bounds.
        /// </summary>
        /// <param name="bounds">The bounds to calculate the scale of.</param>
        /// <param name="areaToFit">The bounds to fit inside.</param>
        /// <returns>The scale of the bounds required to fit inside the area.</returns>
        public static float CalculateScale(this BoundsInt bounds, BoundsInt areaToFit)
        {
            float scale = Mathf.Infinity;

            scale = CompareAxis(areaToFit.size.x, bounds.size.x, scale, float.Epsilon);
            scale = CompareAxis(areaToFit.size.y, bounds.size.y, scale, float.Epsilon);
            scale = CompareAxis(areaToFit.size.z, bounds.size.z, scale, float.Epsilon);

            if (scale != Mathf.Infinity) {
                return scale;
            } else {
                return 1f;
            }
        }

        private static float CompareAxis(float a, float b, float currentScale, float epsilon)
        {
            if (a >= epsilon && b >= epsilon) {
                return Mathf.Min(a / b, currentScale);
            } else {
                return currentScale;
            }
        }

        /// <summary>
        /// Returns a random point inside the bounds.
        /// </summary>
        /// <param name="bounds">The bounds to get a random point from.</param>
        /// <returns>A random point inside the bounds.</returns>
        public static Vector3 RandomPointInside(this Bounds bounds)
        {
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z));
        }

        /// <summary>
        /// Returns a random point inside the bounds.
        /// </summary>
        /// <param name="bounds">The bounds to get a random point from.</param>
        /// <returns>A random point inside the bounds.</returns>
        public static Vector3Int RandomPointInside(this BoundsInt bounds)
        {
            return new Vector3Int(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z));
        }

    }

}
