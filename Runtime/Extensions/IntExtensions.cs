using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for ints.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Returns a subset of bits from the number.
        /// </summary>
        /// <param name="n">The number to get bits from.</param>
        /// <param name="amount">The amount of bits to return.</param>
        /// <param name="offset">The amount of bits to discard.</param>
        /// <returns>The subset of bits.</returns>
        public static int GetBits(this int n, int amount, int offset)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            n >>= offset; // drop offset bits

            if (amount >= int.MaxValue) {
                return n; // all bits
            }

            int mask = (1 << amount) - 1;
            return n & mask;
        }

        /// <summary>
        /// Checks if a given flag is set in the bitmask.
        /// <c>(mask &amp; flag) == flag</c>
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="flag">The flag to check for.</param>
        /// <returns>True if the flag is set in the mask.</returns>
        public static bool HasFlag(this int mask, int flag)
        {
            return (mask & flag) == flag;
        }

        /// <summary>
        /// Checks if any of the given flags are set in the bitmask.
        /// <c>(mask &amp; flags) != 0</c>
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="flags">The flags to check for.</param>
        /// <returns>True if any of the flags are set in the mask.</returns>
        public static bool HasAnyFlag(this int mask, int flags)
        {
            return (mask & flags) != 0;
        }

        /// <summary>
        /// Checks if the number is even.
        /// <c>n % 2 == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is even.</returns>
        public static bool IsEven(this int n)
        {
            return n % 2 == 0;
        }

        /// <summary>
        /// Checks if the number is odd.
        /// <c>n % 2 != 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is odd.</returns>
        public static bool IsOdd(this int n)
        {
            return n % 2 != 0;
        }

        /// <summary>
        /// Checks if the number is zero.
        /// <c>n == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is zero.</returns>
        public static bool IsZero(this int n)
        {
            return n == 0;
        }

        /// <summary>
        /// Checks if the number is positive.
        /// <c>n &#62; 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is positive.</returns>
        public static bool IsPositive(this int n)
        {
            return n > 0;
        }

        /// <summary>
        /// Checks if the number is negative.
        /// <c>n &#60; 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is negative.</returns>
        public static bool IsNegative(this int n)
        {
            return n < 0;
        }

        /// <summary>
        /// Returns the number of digits in the number.
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>The number of digits in the number.</returns>
        public static int NumDigits(this int n)
        {
            return Mathf.FloorToInt(Mathf.Log10((float)n) + 1f);
        }

        /// <summary>
        /// Converts the number to an abbreviated string, e.g. "1k" for 1000.
        /// </summary>
        /// <param name="n">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string ToAbbreviatedString(this int n)
        {
            return NumberAbbreviation.common.Format(n);
        }

        /// <summary>
        /// Converts the number to an abbreviated string with a given set of
        /// possible abbreviations.
        /// </summary>
        /// <param name="n">The number to abbreviate.</param>
        /// <param name="abbreviations">The abbreviations to use.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string ToAbbreviatedString(this int n, NumberAbbreviation[] abbreviations)
        {
            return abbreviations.Format(n);
        }

        /// <summary>
        /// Converts the number to a string of binary digits.
        /// </summary>
        /// <param name="n">The number to convert.</param>
        /// <returns>The binary representation of the number.</returns>
        public static string ToBinaryString(this int n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(32 - binary.Length, '0');
        }

    }

}
