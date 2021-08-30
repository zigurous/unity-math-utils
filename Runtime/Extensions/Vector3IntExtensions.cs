using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Vector3Int.
    /// </summary>
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Returns the absolute value of the vector.
        /// </summary>
        /// <param name="vector">The vector to return the absolute of.</param>
        /// <returns>A new vector of the absolute value.</returns>
        public static Vector3Int Abs(this Vector3Int vector)
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
        public static Vector3Int Average(this Vector3Int[] vectors)
        {
            Vector3Int average = Vector3Int.zero;

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
        public static void Clamp(this ref Vector3Int vector, Vector3Int min, Vector3Int max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
        }

        /// <summary>
        /// Clamps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new clamped vector.</returns>
        public static Vector3Int Clamped(this Vector3Int vector, Vector3Int min, Vector3Int max)
        {
            vector.x = Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Processors.Clamp(vector.z, min.z, max.z);
            return vector;
        }

        /// <summary>
        /// Sets all components of the vector to the given value.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        public static void SetUniform(this ref Vector3Int vector, int value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
        }

        /// <summary>
        /// Sets all components of the vector to the given value.
        /// </summary>
        /// <param name="vector">The vector to set.</param>
        /// <param name="value">The uniform component value.</param>
        /// <returns>A new vector with the uniform component value.</returns>
        public static Vector3Int SetUniformly(this Vector3Int vector, int value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            return vector;
        }

        /// <summary>
        /// Wraps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static void Wrap(this ref Vector3Int vector, Vector3Int min, Vector3Int max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x + 1);
            vector.y = Processors.Wrap(vector.y, min.y, max.y + 1);
            vector.z = Processors.Wrap(vector.z, min.z, max.z + 1);
        }

        /// <summary>
        /// Wraps the vector to the range [min..max].
        /// </summary>
        /// <param name="vector">The vector to wrap.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>A new wrapped vector.</returns>
        public static Vector3Int Wrapped(this Vector3Int vector, Vector3Int min, Vector3Int max)
        {
            vector.x = Processors.Wrap(vector.x, min.x, max.x + 1);
            vector.y = Processors.Wrap(vector.y, min.y, max.y + 1);
            vector.z = Processors.Wrap(vector.z, min.z, max.z + 1);
            return vector;
        }

    }

}
