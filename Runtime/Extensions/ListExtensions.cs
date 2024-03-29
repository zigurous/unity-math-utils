﻿using System;
using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for lists.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Shuffles the list in place.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to shuffle.</param>
        public static void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                int k = UnityEngine.Random.Range(0, n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }

        /// <summary>
        /// Shuffles the list in place using the given random number generator.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="list">The list to shuffle.</param>
        /// <param name="rng">The random number generator to use.</param>
        public static void Shuffle<T>(this List<T> list, Random rng)
        {
            int n = list.Count;

            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }

        /// <summary>
        /// Calculates the sum of all items in the list.
        /// </summary>
        /// <param name="list">The list to sum.</param>
        /// <returns>The sum of all items in the list.</returns>
        public static int Sum(this List<int> list)
        {
            int sum = 0;

            for (int i = 0; i < list.Count; i++) {
                sum += list[i];
            }

            return sum;
        }

        /// <summary>
        /// Calculates the sum of all items in the list.
        /// </summary>
        /// <param name="list">The list to sum.</param>
        /// <returns>The sum of all items in the list.</returns>
        public static float Sum(this List<float> list)
        {
            float sum = 0;

            for (int i = 0; i < list.Count; i++) {
                sum += list[i];
            }

            return sum;
        }

        /// <summary>
        /// Calculates the sum of all items in the list.
        /// </summary>
        /// <param name="list">The list to sum.</param>
        /// <returns>The sum of all items in the list.</returns>
        public static double Sum(this List<double> list)
        {
            double sum = 0;

            for (int i = 0; i < list.Count; i++) {
                sum += list[i];
            }

            return sum;
        }

    }

}
