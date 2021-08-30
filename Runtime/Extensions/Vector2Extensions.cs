﻿using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Vector2.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        /// Returns the absolute value of the vector.
        /// </summary>
        /// <param name="vector">The vector to return the absolute of.</param>
        /// <returns>A new vector of the absolute value.</returns>
        public static Vector2 Abs(this Vector2 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            return vector;
        }

        /// <summary>
        /// Calculates the average of the vectors.
        /// </summary>
        /// <param name="vectors">The vectors to return the average of.</param>
        /// <returns>A new vector of the average.</returns>
        public static Vector2 Average(this Vector2[] vectors)
        {
            Vector2 average = Vector2.zero;

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
        public static void Ceil(this ref Vector2 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
        }

        /// <summary>
        /// Rounds the vector up to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector2 Ceiled(this Vector2 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            return vector;
        }

        /// <summary>
        /// Clamps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Clamp(this ref Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
        }

        /// <summary>
        /// Clamps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new clamped vector.</returns>
        public static Vector2 Clamped(this Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            return vector;
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Floor(this ref Vector2 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
        }

        /// <summary>
        /// Rounds the vector down to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector2 Floored(this Vector2 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            return vector;
        }

        /// <summary>
        /// Checks for equality with another vector given a margin of error
        /// specified by an epsilon.
        /// </summary>
        /// <param name="lhs">The left-hand side of the equality check.</param>
        /// <param name="rhs">The right-hand side of the equality check.</param>
        /// <returns>True if the values are equal.</returns>
        public static bool IsEqualTo(this Vector2 lhs, Vector2 rhs, float epsilon = float.Epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y);
        }

        /// <summary>
        /// Checks if the vector is zero given a margin of error specified by
        /// an epsilon.
        /// </summary>
        /// <param name="vector">The vector to check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if the vector is considered zero.</returns>
        public static bool IsZero(this Vector2 vector, float epsilon = float.Epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        public static void Round(this ref Vector2 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
        }

        /// <summary>
        /// Rounds the vector to the nearest whole number.
        /// </summary>
        /// <param name="vector">The vector to round.</param>
        /// <returns>A new rounded vector.</returns>
        public static Vector2 Rounded(this Vector2 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            return vector;
        }

        /// <summary>
        /// Sets all components of the vector to the given value.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        public static void SetUniform(this ref Vector2 vector, float value)
        {
            vector.x = value;
            vector.y = value;
        }

        /// <summary>
        /// Sets all components of the vector to the given value.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        /// <returns>A new vector with the uniform component value.</returns>
        public static Vector2 SetUniformly(this Vector2 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            return vector;
        }

        /// <summary>
        /// Wraps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Wrap(this ref Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
        }

        /// <summary>
        /// Wraps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new wrapped vector.</returns>
        public static Vector2 Wrapped(this Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Processors.Wrap(vector.y, min.y, max.y);
            return vector;
        }

    }

}
