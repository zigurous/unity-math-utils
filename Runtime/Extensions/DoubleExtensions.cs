namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for doubles.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Checks if the value is between <paramref name="min"/> and
        /// <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static bool IsBetween(this double value, double min, double max)
        {
            return value >= min && value <= max;
        }

        /// <summary>
        /// Checks if the value is <c>NaN</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsNaN(this double value)
        {
            return double.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is infinite.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsInfinite(this double value)
        {
            return double.IsInfinity(value);
        }

        /// <summary>
        /// Checks if the value is equal to positive infinity.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsPositiveInfinity(this double value)
        {
            return double.IsPositiveInfinity(value);
        }

        /// <summary>
        /// Checks if the value is equal to negative infinity.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsNegativeInfinity(this double value)
        {
            return double.IsNegativeInfinity(value);
        }

        /// <summary>
        /// Checks if the value is a real number (not infinite and not
        /// <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsRealNumber(this double value)
        {
            return !double.IsInfinity(value) && !double.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is an imaginary number (infinite or <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsImaginaryNumber(this double value)
        {
            return double.IsInfinity(value) || double.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value can be divided (not zero, not infinite, and not
        /// <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsDividable(this double value)
        {
            return value != 0.0 && !double.IsInfinity(value) && !double.IsNaN(value);
        }

        /// <summary>
        /// Checks if the value is positive.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsPositive(this double value)
        {
            return value > 0.0;
        }

        /// <summary>
        /// Checks if the value is negative.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool IsNegative(this double value)
        {
            return value < 0.0;
        }

        /// <summary>
        /// Checks if the value is zero given a margin of error specified by the
        /// <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="epsilon">The margin of error.</param>
        public static bool IsZero(this double value, double epsilon = double.Epsilon)
        {
            return (value > -epsilon) && (value < epsilon);
        }

        /// <summary>
        /// Checks for equality with another value given a margin of error
        /// specified by the <paramref name="epsilon"/>
        /// </summary>
        /// <param name="lhs">The left-hand side of the equality check.</param>
        /// <param name="rhs">The right-hand side of the equality check.</param>
        /// <param name="epsilon">The margin of error.</param>
        /// <returns>True if <paramref name="lhs"/> is considered equal to <paramref name="rhs"/>.</returns>
        public static bool IsEqualTo(this double lhs, double rhs, double epsilon = double.Epsilon)
        {
            return System.Math.Abs(lhs - rhs) < epsilon;
        }

        /// <summary>
        /// Converts the number to an abbreviated string, e.g. "1k" for 1000.
        /// </summary>
        /// <param name="value">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number, or the number as a string if it cannot be abbreviated.</returns>
        public static string ToAbbreviatedString(this double value)
        {
            return NumberAbbreviation.Common.Format(value);
        }

        /// <summary>
        /// Converts the number to an abbreviated string using the possible
        /// provided <paramref name="abbreviations"/>.
        /// </summary>
        /// <param name="value">The number to abbreviate.</param>
        /// <param name="abbreviations">The possible abbreviations.</param>
        /// <returns>A new string of the abbreviated number, or the number as a string if it cannot be abbreviated.</returns>
        public static string ToAbbreviatedString(this double value, NumberAbbreviation[] abbreviations)
        {
            return abbreviations.Format(value);
        }

        /// <summary>
        /// Sets the value to <paramref name="newValue"/> if the value is an
        /// imaginary number (infinite or <c>NaN</c>).
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to return if the original value is an imaginary number.</param>
        public static void UnsetImaginary(this ref double value, double newValue = default(double))
        {
            if (IsImaginaryNumber(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to <paramref name="newValue"/> if the value is an
        /// infinite number.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to return if the original value is infinite.</param>
        public static void UnsetInfinite(this ref double value, double newValue = default(double))
        {
            if (IsInfinite(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to <paramref name="newValue"/> if the value is
        /// <c>NaN</c>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to return if the original value is <c>NaN</c>.</param>
        public static void UnsetNaN(this ref double value, double newValue = default(double))
        {
            if (IsNaN(value)) {
                value = newValue;
            }
        }

        /// <summary>
        /// Sets the value to <paramref name="newValue"/> if the value is zero
        /// given a margin of error specified by the <paramref name="epsilon"/>.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="newValue">The value to return if the original value is zero.</param>
        /// <param name="epsilon">The margin of error.</param>
        public static void UnsetZero(this ref double value, double newValue = double.Epsilon, double epsilon = double.Epsilon)
        {
            if (IsZero(value, epsilon)) {
                value = newValue;
            }
        }

    }

}
