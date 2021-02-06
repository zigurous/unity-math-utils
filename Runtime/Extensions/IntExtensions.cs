using UnityEngine;

namespace Zigurous.Math
{
    public static class IntExtensions
    {
        public static int GetBits(this int value, int offset, int n)
        {
            if (offset >= int.MaxValue) {
                return 0; // value is padded with infinite zeros on the left
            }

            value >>= offset; // drop offset bits

            if (n >= int.MaxValue) {
                return value; // all bits
            }

            int mask = (1 << n) - 1;
            return value & mask;
        }

        /// <summary><c>(mask &amp; flag) == flag</c></summary>
        public static bool HasFlag(this int mask, int flag) => (mask & flag) == flag;

        /// <summary><c>(mask &amp; flags) != 0</c></summary>
        public static bool HasAnyFlag(this int mask, int flags) => (mask & flags) != 0;

        /// <summary><c>n % 2 == 0</c></summary>
        public static bool IsEven(this int n) => n % 2 == 0;

        /// <summary><c>n % 2 != 0</c></summary>
        public static bool IsOdd(this int n) => n % 2 != 0;

        /// <summary><c>n > 0</c></summary>
        public static bool IsPositive(this int n) => n > 0;

        /// <summary><c>n < 0</c></summary>
        public static bool IsNegative(this int n) => n < 0;

        /// <summary><c>n == 0</c></summary>
        public static bool IsZero(this int n) => n == 0;

        public static int NumDigits(this int n) => Mathf.FloorToInt(Mathf.Log10((float)n) + 1.0f);

        public static string ToBinary(this int n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(32 - binary.Length, '0');
        }

    }

}
