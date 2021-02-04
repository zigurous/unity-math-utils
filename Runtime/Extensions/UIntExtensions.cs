using System.Collections.Generic;

namespace Zigurous
{
    public static class UIntExtensions
    {
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

        public static uint GetBits(this uint value, int offset, int n)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            value >>= offset; // drop offset bits

            if (n >= int.MaxValue) {
                return value; // all bits
            }

            uint mask = (1U << n) - 1;
            return value & mask;
        }

        /// <summary><c>(mask &amp; flag) == flag</c></summary>
        public static bool HasFlag(this uint mask, uint flag) => (mask & flag) == flag;

        /// <summary><c>(mask &amp; flags) != 0</c></summary>
        public static bool HasAnyFlag(this uint mask, uint flags) => (mask & flags) != 0;

        /// <summary><c>n % 2 == 0</c></summary>
        public static bool IsEven(this uint n) => n % 2 == 0;

        /// <summary><c>n % 2 != 0</c></summary>
        public static bool IsOdd(this uint n) => n % 2 != 0;

        /// <summary><c>n == 0</c></summary>
        public static bool IsZero(this uint n) => n == 0;

        public static string ToBinary(this uint n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(32 - binary.Length, '0');
        }

    }

}
