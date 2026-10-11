using System;
using System.Collections.Generic;
using System.Text;

namespace Zigurous.Math
{
    /// <summary>
    /// Represents a roman numeral value.
    /// </summary>
    public struct RomanNumeral : IEquatable<RomanNumeral>
    {
        private static readonly Dictionary<char, int> RomanMap;
        private static readonly Dictionary<int, string> NumberMap;
        private static readonly StringBuilder StringBuilder;

        static RomanNumeral()
        {
            RomanMap = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            NumberMap = new()
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

            StringBuilder = new();
        }

        /// <summary>
        /// The integer value of the roman numeral.
        /// </summary>
        public int value;

        /// <summary>
        /// Initializes a roman numeral with the provided integer value.
        /// </summary>
        /// <param name="value">The integer value of the roman numeral between 0 and 3999.</param>
        public RomanNumeral(int value)
        {
            if (value < 0 || value > 3999) {
                throw new ArgumentOutOfRangeException("Value must be between 0 and 3999");
            } else {
                this.value = value;
            }
        }

        /// <summary>
        /// Initializes a roman numeral from a string.
        /// </summary>
        /// <param name="s">The roman numeral string.</param>
        public RomanNumeral(string s)
        {
            int value = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanMap[s[i]] < RomanMap[s[i+1]]) {
                    value -= RomanMap[s[i]];
                } else {
                    value += RomanMap[s[i]];
                }
            }

            if (value < 0 || value > 3999) {
                throw new ArgumentOutOfRangeException("Value must be between 0 and 3999");
            }

            this.value = value;
        }

        /// <summary>
        /// Converts the roman numeral value to a string.
        /// </summary>
        /// <returns>The roman numeral as a string.</returns>
        public override readonly string ToString()
        {
            StringBuilder.Clear();

            int number = value;

            foreach (var item in NumberMap)
            {
                while (number >= item.Key)
                {
                    StringBuilder.Append(item.Value);
                    number -= item.Key;
                }
            }

            return StringBuilder.ToString();
        }

        /// <summary>
        /// Determines if the roman numeral is equal to another roman numeral.
        /// </summary>
        /// <param name="other">The roman numeral to compare to.</param>
        /// <returns>True if the roman numerals are equal, false otherwise.</returns>
        public readonly bool Equals(RomanNumeral other)
        {
            return value == other.value;
        }

        /// <summary>
        /// Determines if the roman numeral is equal to another roman numeral.
        /// </summary>
        /// <param name="other">The roman numeral to compare to.</param>
        /// <returns>True if the roman numerals are equal, false otherwise.</returns>
        public override readonly bool Equals(object other)
        {
            if (other is RomanNumeral roman) {
                return Equals(roman);
            } else {
                return false;
            }
        }

        /// <summary>
        /// Returns the hash code of the roman numeral.
        /// </summary>
        /// <returns>The hash code of the roman numeral.</returns>
        public override readonly int GetHashCode()
        {
            return value.GetHashCode();
        }

        /// <summary>
        /// Performs an addition operation on two roman numerals.
        /// </summary>
        /// <param name="lhs">The first roman numeral.</param>
        /// <param name="rhs">The second roman numeral.</param>
        /// <returns>The result of adding the two roman numerals.</returns>
        public static RomanNumeral operator +(RomanNumeral lhs, RomanNumeral rhs) => new(lhs.value + rhs.value);

        /// <summary>
        /// Performs a subtraction operation on two roman numerals.
        /// </summary>
        /// <param name="lhs">The first roman numeral.</param>
        /// <param name="rhs">The second roman numeral.</param>
        /// <returns>The result of subtracting the two roman numerals.</returns>
        public static RomanNumeral operator -(RomanNumeral lhs, RomanNumeral rhs) => new(lhs.value - rhs.value);

        /// <summary>
        /// Determines if two roman numerals are equal.
        /// </summary>
        /// <param name="lhs">The first bitmask to compare.</param>
        /// <param name="rhs">The second bitmask to compare.</param>
        /// <returns>True if the roman numerals are equal, false otherwise.</returns>
        public static bool operator ==(RomanNumeral lhs, RomanNumeral rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Determines if two roman numerals are not equal.
        /// </summary>
        /// <param name="lhs">The first bitmask to compare.</param>
        /// <param name="rhs">The second bitmask to compare.</param>
        /// <returns>True if the roman numerals are not equal, false otherwise.</returns>
        public static bool operator !=(RomanNumeral lhs, RomanNumeral rhs) => !lhs.Equals(rhs);

        /// <summary>
        /// Implicitly converts a roman numeral to an integer.
        /// </summary>
        /// <param name="roman">The roman numeral to convert.</param>
        /// <returns>The roman numeral as an integer.</returns>
        public static implicit operator int(RomanNumeral roman) => roman.value;

        /// <summary>
        /// Implicitly converts an integer to a roman numeral.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The integer as a roman numeral.</returns>
        public static implicit operator RomanNumeral(int value) => new(value);

    }

}
