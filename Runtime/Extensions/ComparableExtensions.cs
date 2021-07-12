using System;
using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for IComparable.
    /// </summary>
    public static class ComparableExtensions
    {
        /// <summary>
        /// Checks if the value is between <paramref name="min"/> and
        /// <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="includeMin">The minimum value is inclusive if true, exclusive if false.</param>
        /// <param name="includeMax">The maximum value is inclusive if true, exclusive if false.</param>
        /// <typeparam name="T">The type of value to check.</typeparam>
        public static bool IsBetween<T>(this T value, T min, T max, bool includeMin, bool includeMax) where T: IComparable<T>
        {
            int minCompare = value.CompareTo(min);
            int maxCompare = value.CompareTo(max);

            if (minCompare < 0 || maxCompare > 0) return false;
            if (!includeMin && minCompare == 0) return false;
            if (!includeMax && maxCompare == 0) return false;

            return true;
        }

        /// <summary>
        /// Returns the maximum value in the array.
        /// </summary>
        /// <param name="values">The values to check.</param>
        /// <typeparam name="T">The type of value to check.</typeparam>
        public static T Max<T>(this T[] values) where T: IComparable<T>
        {
            if (values == null || values.Length == 0) {
                return default(T);
            }

            T max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                T element = values[i];

                if (element.CompareTo(max) > 0) {
                    max = element;
                }
            }

            return max;
        }

        /// <summary>
        /// Returns the maximum value in the list.
        /// </summary>
        /// <param name="values">The values to check.</param>
        /// <typeparam name="T">The type of value to check.</typeparam>
        public static T Max<T>(this List<T> values) where T: IComparable<T>
        {
            if (values == null || values.Count == 0) {
                return default(T);
            }

            T max = values[0];

            for (int i = 1; i < values.Count; i++)
            {
                T element = values[i];

                if (element.CompareTo(max) > 0) {
                    max = element;
                }
            }

            return max;
        }

        /// <summary>
        /// Returns the minimum value in the array.
        /// </summary>
        /// <param name="values">The values to check.</param>
        /// <typeparam name="T">The type of value to check.</typeparam>
        public static T Min<T>(this T[] values) where T: IComparable<T>
        {
            if (values == null || values.Length == 0) {
                return default(T);
            }

            T min = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                T element = values[i];

                if (element.CompareTo(min) < 0) {
                    min = element;
                }
            }

            return min;
        }

        /// <summary>
        /// Returns the minimum value in the list.
        /// </summary>
        /// <param name="values">The values to check.</param>
        /// <typeparam name="T">The type of value to check.</typeparam>
        public static T Min<T>(this List<T> values) where T: IComparable<T>
        {
            if (values == null || values.Count == 0) {
                return default(T);
            }

            T min = values[0];

            for (int i = 1; i < values.Count; i++)
            {
                T element = values[i];

                if (element.CompareTo(min) < 0) {
                    min = element;
                }
            }

            return min;
        }

    }

}
