using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Vector2Int.
    /// </summary>
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Returns the absolute value of the vector.
        /// </summary>
        /// <param name="vector">The vector to return the absolute of.</param>
        /// <returns>A new vector of the absolute value.</returns>
        public static Vector2Int Abs(this Vector2Int vector)
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
        public static Vector2Int Average(this Vector2Int[] vectors)
        {
            Vector2Int average = Vector2Int.zero;

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
        /// Clamps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Clamp(this ref Vector2Int vector, Vector2Int min, Vector2Int max)
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
        public static Vector2Int Clamped(this Vector2Int vector, Vector2Int min, Vector2Int max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            return vector;
        }

        /// <summary>
        /// Sets all components of the vector to the given value.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        public static void SetUniform(this ref Vector2Int vector, int value)
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
        public static Vector2Int SetUniformly(this Vector2Int vector, int value)
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
        public static void Wrap(this ref Vector2Int vector, Vector2Int min, Vector2Int max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x + 1);
            vector.y = Processors.Wrap(vector.y, min.y, max.y + 1);
        }

        /// <summary>
        /// Wraps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new wrapped vector.</returns>
        public static Vector2Int Wrapped(this Vector2Int vector, Vector2Int min, Vector2Int max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x + 1);
            vector.y = Processors.Wrap(vector.y, min.y, max.y + 1);
            return vector;
        }

    }

}
