using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for uints.
    /// </summary>
    public static class UIntExtensions
    {
        /// <summary>
        /// Returns the factors of the given number.
        /// </summary>
        /// <param name="n">The number to factor.</param>
        public static IEnumerable<uint> Factors(this uint n)
        {
            for (uint x = 1; x * x <= n; x++)
            {
                if (n % x == 0)
                {
                    yield return x;

                    if (x != (n / x)) {
                        yield return n / x;
                    }
                }
            }
        }

        /// <summary>
        /// Returns a subset of bits from the number.
        /// </summary>
        /// <param name="n">The number to get bits from.</param>
        /// <param name="amount">The amount of bits to return.</param>
        /// <param name="offset">The amount of bits to discard.</param>
        public static uint GetBits(this uint n, int amount, int offset)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            n >>= offset; // drop offset bits

            if (amount >= int.MaxValue) {
                return n; // all bits
            }

            uint mask = (1U << amount) - 1;
            return n & mask;
        }

        /// <summary>
        /// Checks if the <paramref name="flag"/> is set in the bitmask.
        /// <c>(mask &amp; flag) == flag</c>
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="flag">The flag to check for.</param>
        public static bool HasFlag(this uint mask, uint flag)
        {
            return (mask & flag) == flag;
        }

        /// <summary>
        /// Checks if any of the <paramref name="flags"/> are set in the bitmask.
        /// <c>(mask &amp; flags) != 0</c>
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="flags">The flags to check for.</param>
        public static bool HasAnyFlag(this uint mask, uint flags)
        {
            return (mask & flags) != 0;
        }

        /// <summary>
        /// Checks if the number is even.
        /// <c>n % 2 == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        public static bool IsEven(this uint n)
        {
            return n % 2 == 0;
        }

        /// <summary>
        /// Checks if the number is odd.
        /// <c>n % 2 != 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        public static bool IsOdd(this uint n)
        {
            return n % 2 != 0;
        }

        /// <summary>
        /// Checks if the number is zero.
        /// <c>n == 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        public static bool IsZero(this uint n)
        {
            return n == 0;
        }

        /// <summary>
        /// Checks if the number is positive.
        /// <c>n &#62; 0</c>
        /// </summary>
        /// <param name="n">The number to check.</param>
        public static bool IsPositive(this uint n)
        {
            return n > 0;
        }

        /// <summary>
        /// Converts the number to a string of binary digits.
        /// </summary>
        /// <param name="n">The number to convert.</param>
        /// <returns>The binary representation of the number.</returns>
        public static string ToBinaryString(this uint n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(32 - binary.Length, '0');
        }

    }

}
