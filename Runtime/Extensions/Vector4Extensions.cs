using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Vector4.
    /// </summary>
    public static class Vector4Extensions
    {
        /// <summary>
        /// Returns the absolute value of the vector.
        /// </summary>
        /// <param name="vector">The vector to return the absolute of.</param>
        public static Vector4 Abs(this Vector4 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            vector.z = System.Math.Abs(vector.z);
            vector.w = System.Math.Abs(vector.w);
            return vector;
        }

        /// <summary>
        /// Calculates the average of the vectors.
        /// </summary>
        /// <param name="vectors">The vectors to return the average of.</param>
        /// <returns>A new vector of the average.</returns>
        public static Vector4 Average(this Vector4[] vectors)
        {
            Vector4 average = Vector4.zero;

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
        public static void Ceil(this ref Vector4 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            vector.w = Mathf.Ceil(vector.w);
        }

        /// <summary>
        /// Rounds the vector up to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector4 Ceiled(this Vector4 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            vector.w = Mathf.Ceil(vector.w);
            return vector;
        }

        /// <summary>
        /// Clamps the vector to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Clamp(this ref Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
            vector.w = Processors.Clamp(vector.w, min.w, max.w);
        }

        /// <summary>
        /// Clamps the vector to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new clamped vector.</returns>
        public static Vector4 Clamped(this Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
            vector.w = Processors.Clamp(vector.w, min.w, max.w);
            return vector;
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Floor(this ref Vector4 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            vector.w = Mathf.Floor(vector.w);
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector4 Floored(this Vector4 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            vector.w = Mathf.Floor(vector.w);
            return vector;
        }

        /// <summary>
        /// Checks for equality with another vector given a margin of error
        /// specified by the <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the equality check.</param>
        /// <param name="rhs">The right-hand side of the equality check.</param>
        /// <returns>True if <paramref name="lhs"/> is considered equal to <paramref name="rhs"/>.</returns>
        public static bool IsEqualTo(this Vector4 lhs, Vector4 rhs, float epsilon = float.Epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y) &&
                   lhs.z.IsEqualTo(rhs.z) &&
                   lhs.w.IsEqualTo(rhs.w);
        }

        /// <summary>
        /// Checks if the vector is zero given a margin of error specified by
        /// the <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="vector">The vector to check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if the vector is considered zero.</returns>
        public static bool IsZero(this Vector4 vector, float epsilon = float.Epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon) &&
                   vector.z.IsZero(epsilon) &&
                   vector.w.IsZero(epsilon);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Round(this ref Vector4 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            vector.w = Mathf.Round(vector.w);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector4 Rounded(this Vector4 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            vector.w = Mathf.Round(vector.w);
            return vector;
        }

        /// <summary>
        /// Sets all components of the vector to the given
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        public static void SetUniform(this ref Vector4 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            vector.w = value;
        }

        /// <summary>
        /// Sets all components of the vector to the given
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        /// <returns>A new vector with the uniform component value.</returns>
        public static Vector4 SetUniformly(this Vector4 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            vector.w = value;
            return vector;
        }

        /// <summary>
        /// Wraps the vector to the <paramref name="min"/> and
        /// <paramref name="max"/> values.
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Wrap(this ref Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Processors.Wrap(vector.z, min.z, max.z);
            vector.w = Processors.Wrap(vector.w, min.w, max.w);
        }

        /// <summary>
        /// Wraps the vector to the <paramref name="min"/> and
        /// <paramref name="max"/> values.
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new wrapped vector.</returns>
        public static Vector4 Wrapped(this Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Processors.Wrap(vector.z, min.z, max.z);
            vector.w = Processors.Wrap(vector.w, min.w, max.w);
            return vector;
        }

    }

}
