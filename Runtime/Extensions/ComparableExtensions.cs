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
        /// Checks if the value is between a min and max value.
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="includeMin">The minimum value is inclusive if true, exclusive if false.</param>
        /// <param name="includeMax">The maximum value is inclusive if true, exclusive if false.</param>
        /// <returns>True if the value is between the min and max value.</returns>
        public static bool IsBetween<T>(this T value, T min, T max, bool includeMin = true, bool includeMax = true) where T : IComparable<T>
        {
            int minCompare = value.CompareTo(min);
            int maxCompare = value.CompareTo(max);

            if (minCompare < 0 || maxCompare > 0) return false;
            if (!includeMin && minCompare == 0) return false;
            if (!includeMax && maxCompare == 0) return false;

            return true;
        }

        /// <summary>
        /// Checks if the value is in the range [min..max].
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>True if the value is in the range [min..max].</returns>
        public static bool IsBetweenInclusive<T>(this T value, T min, T max) where T : IComparable<T>
        {
            return value.IsBetween(min, max, true, true);
        }

        /// <summary>
        /// Checks if the value is in the range [min..max).
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>True if the value is in the range [min..max).</returns>
        public static bool IsBetweenInclusiveExclusive<T>(this T value, T min, T max) where T : IComparable<T>
        {
            return value.IsBetween(min, max, true, false);
        }

        /// <summary>
        /// Checks if the value is in the range (min..max).
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>True if the value is in the range (min..max).</returns>
        public static bool IsBetweenExclusive<T>(this T value, T min, T max) where T : IComparable<T>
        {
            return value.IsBetween(min, max, false, false);
        }

        /// <summary>
        /// Checks if the value is in the range (min..max].
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>True if the value is in the range (min..max].</returns>
        public static bool IsBetweenExclusiveInclusive<T>(this T value, T min, T max) where T : IComparable<T>
        {
            return value.IsBetween(min, max, false, true);
        }

        /// <summary>
        /// Returns the maximum value in the array.
        /// </summary>
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="values">The values to check.</param>
        /// <returns>The maximum value in the array.</returns>
        public static T Max<T>(this T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0) {
                return default;
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
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="values">The values to check.</param>
        /// <returns>The maximum value in the list.</returns>
        public static T Max<T>(this List<T> values) where T : IComparable<T>
        {
            if (values == null || values.Count == 0) {
                return default;
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
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="values">The values to check.</param>
        /// <returns>The minimum value in the array.</returns>
        public static T Min<T>(this T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0) {
                return default;
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
        /// <typeparam name="T">The type of value to check.</typeparam>
        /// <param name="values">The values to check.</param>
        /// <returns>The minimum value in the list.</returns>
        public static T Min<T>(this List<T> values) where T : IComparable<T>
        {
            if (values == null || values.Count == 0) {
                return default;
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
