namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for longs.
    /// </summary>
    public static class LongExtensions
    {
        /// <summary>
        /// Returns a subset of bits from the number.
        /// </summary>
        /// <param name="n">The number to get bits from.</param>
        /// <param name="amount">The amount of bits to return.</param>
        /// <param name="offset">The amount of bits to discard.</param>
        /// <returns>The subset of bits.</returns>
        public static long GetBits(this long n, int amount, int offset)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            n >>= offset; // drop offset bits

            if (amount >= int.MaxValue) {
                return n; // all bits
            }

            long mask = (1L << amount) - 1;
            return n & mask;
        }

        /// <summary>
        /// Checks if a given flag is set in the bitmask.
        /// <c>(mask &amp; flag) == flag</c>
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="flag">The flag to check for.</param>
        /// <returns>True if the flag is set in the mask.</returns>
        public static bool HasFlag(this long mask, long flag)
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
        public static bool HasAnyFlag(this long mask, long flags)
        {
            return (mask & flags) != 0;
        }

        /// <summary>
        /// Checks if the number is even.
        /// <c>n % 2 == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is even.</returns>
        public static bool IsEven(this long n)
        {
            return n % 2 == 0;
        }

        /// <summary>
        /// Checks if the number is odd.
        /// <c>n % 2 != 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is odd.</returns>
        public static bool IsOdd(this long n)
        {
            return n % 2 != 0;
        }

        /// <summary>
        /// Checks if the number is zero.
        /// <c>n == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is zero.</returns>
        public static bool IsZero(this long n)
        {
            return n == 0;
        }

        /// <summary>
        /// Checks if the number is positive.
        /// <c>n &#62; 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is positive.</returns>
        public static bool IsPositive(this long n)
        {
            return n > 0;
        }

        /// <summary>
        /// Checks if the number is negative.
        /// <c>n &#60; 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        /// <returns>True if the number is negative.</returns>
        public static bool IsNegative(this long n)
        {
            return n < 0;
        }

        /// <summary>
        /// Converts the number to a string of binary digits.
        /// </summary>
        /// <param name="n">The number to convert.</param>
        /// <returns>The binary representation of the number.</returns>
        public static string ToBinaryString(this long n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(32 - binary.Length, '0');
        }

    }

}
