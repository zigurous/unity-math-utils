namespace Zigurous.Math
{
    public static class LongExtensions
    {
        public static long GetBits(this long value, int offset, int n)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            value >>= offset; // drop offset bits

            if (n >= int.MaxValue) {
                return value; // all bits
            }

            long mask = (1L << n) - 1;
            return value & mask;
        }

        /// <summary><c>(mask &amp; flag) == flag</c></summary>
        public static bool HasFlag(this long mask, long flag) => (mask & flag) == flag;

        /// <summary><c>(mask &amp; flags) != 0</c></summary>
        public static bool HasAnyFlag(this long mask, long flags) => (mask & flags) != 0;

        /// <summary><c>n % 2 == 0</c></summary>
        public static bool IsEven(this long n) => n % 2 == 0;

        /// <summary><c>n % 2 != 0</c></summary>
        public static bool IsOdd(this long n) => n % 2 != 0;

        /// <summary><c>n > 0</c></summary>
        public static bool IsPositive(this long n) => n > 0;

        /// <summary><c>n < 0</c></summary>
        public static bool IsNegative(this long n) => n < 0;

        /// <summary><c>n == 0</c></summary>
        public static bool IsZero(this long n) => n == 0;

        public static string ToBinary(this long n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(64 - binary.Length, '0');
        }

    }

}
