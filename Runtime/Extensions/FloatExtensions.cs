namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for floats.
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        /// Sometimes Unity throws precision errors for really small numbers
        /// such as when setting transform values. Using <c>float.Epsilon</c>
        /// can still cause issues so this value is intended to be a safer
        /// alternative.
        /// </summary>
        public const float SAFE_FLOAT = 1.4E-32f;

        /// <summary>
        /// Checks if the value is <c>NaN</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is <c>NaN</c>.</returns>
        public static bool IsNaN(this float value)
        {
            return float.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is infinite.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is infinite.</returns>
        public static bool IsInfinite(this float value)
        {
            return float.IsInfinity(value);
        }

        /// <summary>
        /// Checks if the value is equal to positive infinity.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is equal to positive infinity.</returns>
        public static bool IsPositiveInfinity(this float value)
        {
            return float.IsPositiveInfinity(value);
        }

        /// <summary>
        /// Checks if the value is equal to negative infinity.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is equal to negative infinity.</returns>
        public static bool IsNegativeInfinity(this float value)
        {
            return float.IsNegativeInfinity(value);
        }

        /// <summary>
        /// Checks if the value is a real number (not infinite and not <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is a real number.</returns>
        public static bool IsRealNumber(this float value)
        {
            return !float.IsInfinity(value) && !float.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is an imaginary number (infinite or <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is an imaginary number.</returns>
        public static bool IsImaginaryNumber(this float value)
        {
            return float.IsInfinity(value) || float.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value can be divided (not zero, not infinite, and not
        /// <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value can be divided.</returns>
        public static bool IsDividable(this float value)
        {
            return value != 0f && !float.IsInfinity(value) && !float.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is positive.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is positive.</returns>
        public static bool IsPositive(this float value)
        {
            return value > 0f;
        }

        /// <summary>
        /// Checks if the value is negative.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is negative.</returns>
        public static bool IsNegative(this float value)
        {
            return value < 0f;
        }

        /// <summary>
        /// Checks if the value is zero given a margin of error specified by an
        /// epsilon.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if the value is zero.</returns>
        public static bool IsZero(this float value, float epsilon = float.Epsilon)
        {
            return (value > -epsilon) && (value < epsilon);
        }

        /// <summary>
        /// Checks for equality with another value given a margin of error
        /// specified by an epsilon.
        /// </summary>
        /// <param name="lhs">The left-hand side of the equality check.</param>
        /// <param name="rhs">The right-hand side of the equality check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if the values are equal.</returns>
        public static bool IsEqualTo(this float lhs, float rhs, float epsilon = float.Epsilon)
        {
            return System.Math.Abs(lhs - rhs) < epsilon;
        }

        /// <summary>
        /// Converts the number to an abbreviated string, e.g. "1k" for 1000.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string ToAbbreviatedString(this float number)
        {
            return NumberAbbreviation.common.Format(number);
        }

        /// <summary>
        /// Converts the number to an abbreviated string with a given set of
        /// possible abbreviations.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <param name="abbreviations">The abbreviations to use.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string ToAbbreviatedString(this float number, NumberAbbreviation[] abbreviations)
        {
            return abbreviations.Format(number);
        }

        /// <summary>
        /// Sets the value to a new value if the value is an imaginary number
        /// (infinite or <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to set if the original value is an imaginary number.</param>
        public static void UnsetImaginary(this ref float value, float newValue = default(float))
        {
            if (IsImaginaryNumber(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to a new value if the value is an infinite number.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to set if the original value is infinite.</param>
        public static void UnsetInfinite(this ref float value, float newValue = default(float))
        {
            if (IsInfinite(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to a new value if the value is <c>NaN</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to set if the original value is <c>NaN</c>.</param>
        public static void UnsetNaN(this ref float value, float newValue = default(float))
        {
            if (IsNaN(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to a new value if the value is zero given a margin of
        /// error specified by an epsilon.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to set if the original value is zero.</param>
        /// <param name="epsilon">The margin of error.</param>
        public static void UnsetZero(this ref float value, float newValue = SAFE_FLOAT, float epsilon = float.Epsilon)
        {
            if (IsZero(value, epsilon)) {
                value = newValue;
            }
        }

    }

}
