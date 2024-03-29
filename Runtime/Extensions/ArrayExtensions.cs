using System;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for arrays.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Shuffles the array in place.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to shuffle.</param>
        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;

            while (n > 1)
            {
                int k = UnityEngine.Random.Range(0, n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        /// <summary>
        /// Shuffles the array in place using the given random number generator.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to shuffle.</param>
        /// <param name="rng">The random number generator to use.</param>
        public static void Shuffle<T>(this T[] array, Random rng)
        {
            int n = array.Length;

            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        /// <summary>
        /// Calculates the sum of all elements in the array.
        /// </summary>
        /// <param name="array">The array to sum.</param>
        /// <returns>The sum of all elements in the array.</returns>
        public static int Sum(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

        /// <summary>
        /// Calculates the sum of all elements in the array.
        /// </summary>
        /// <param name="array">The array to sum.</param>
        /// <returns>The sum of all elements in the array.</returns>
        public static float Sum(this float[] array)
        {
            float sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

        /// <summary>
        /// Calculates the sum of all elements in the array.
        /// </summary>
        /// <param name="array">The array to sum.</param>
        /// <returns>The sum of all elements in the array.</returns>
        public static double Sum(this double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

    }

}
