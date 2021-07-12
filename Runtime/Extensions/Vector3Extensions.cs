using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Vector3.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Returns the absolute value of the vector.
        /// </summary>
        /// <param name="vector">The vector to return the absolute of.</param>
        public static Vector3 Abs(this Vector3 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            vector.z = System.Math.Abs(vector.z);
            return vector;
        }

        /// <summary>
        /// Calculates the average of the vectors.
        /// </summary>
        /// <param name="vectors">The vectors to return the average of.</param>
        /// <returns>A new vector of the average.</returns>
        public static Vector3 Average(this Vector3[] vectors)
        {
            Vector3 average = Vector3.zero;

            if (vectors.Length > 0)
            {
                for (int i = 0; i < vectors.Length; i++) {
                    average += vectors[i];
                }

                average /= vectors.Length;
            }

            return average;
        }

        /// <summary>
        /// Rounds the vector up to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Ceil(this ref Vector3 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
        }

        /// <summary>
        /// Rounds the vector up to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector3 Ceiled(this Vector3 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            return vector;
        }

        /// <summary>
        /// Clamps the vector to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Clamp(this ref Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
        }

        /// <summary>
        /// Clamps the vector to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new clamped vector.</returns>
        public static Vector3 Clamped(this Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
            return vector;
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Floor(this ref Vector3 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector3 Floored(this Vector3 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            return vector;
        }

        /// <summary>
        /// Checks for equality with another vector given a margin of error
        /// specified by the <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the equality check.</param>
        /// <param name="rhs">The right-hand side of the equality check.</param>
        /// <returns>True if <paramref name="lhs"/> is considered equal to <paramref name="rhs"/>.</returns>
        public static bool IsEqualTo(this Vector3 lhs, Vector3 rhs, float epsilon = float.Epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y) &&
                   lhs.z.IsEqualTo(rhs.z);
        }

        /// <summary>
        /// Checks if the vector is zero given a margin of error specified by
        /// the <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="vector">The vector to check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if the vector is considered zero.</returns>
        public static bool IsZero(this Vector3 vector, float epsilon = float.Epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon) &&
                   vector.z.IsZero(epsilon);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Round(this ref Vector3 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector3 Rounded(this Vector3 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            return vector;
        }

        /// <summary>
        /// Sets all components of the vector to the given
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        public static void SetUniform(this ref Vector3 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
        }

        /// <summary>
        /// Sets all components of the vector to the given
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        /// <returns>A new vector with the uniform component value.</returns>
        public static Vector3 SetUniformly(this Vector3 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            return vector;
        }

        /// <summary>
        /// Wraps the vector to the <paramref name="min"/> and
        /// <paramref name="max"/> values.
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Wrap(this ref Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Processors.Wrap(vector.z, min.z, max.z);
        }

        /// <summary>
        /// Wraps the vector to the <paramref name="min"/> and
        /// <paramref name="max"/> values.
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new wrapped vector.</returns>
        public static Vector3 Wrapped(this Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Processors.Wrap(vector.z, min.z, max.z);
            return vector;
        }

    }

}
