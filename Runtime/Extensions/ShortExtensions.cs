namespace Zigurous.Math
{
    public static class ShortExtensions
    {
        /// <summary><c>(mask &amp; flag) == flag</c></summary>
        public static bool HasFlag(this short mask, short flag) => (mask & flag) == flag;

        /// <summary><c>(mask &amp; flags) != 0</c></summary>
        public static bool HasAnyFlag(this short mask, short flags) => (mask & flags) != 0;

        /// <summary><c>n % 2 == 0</c></summary>
        public static bool IsEven(this short n) => n % 2 == 0;

        /// <summary><c>n % 2 != 0</c></summary>
        public static bool IsOdd(this short n) => n % 2 != 0;

        /// <summary><c>n > 0</c></summary>
        public static bool IsPositive(this short n) => n > 0;

        /// <summary><c>n < 0</c></summary>
        public static bool IsNegative(this short n) => n < 0;

        /// <summary><c>n == 0</c></summary>
        public static bool IsZero(this short n) => n == 0;

        public static string ToBinary(this short n)
        {
            string binary = System.Convert.ToString(n, 2);
            return binary.PadLeft(16 - binary.Length, '0');
        }

    }

}
