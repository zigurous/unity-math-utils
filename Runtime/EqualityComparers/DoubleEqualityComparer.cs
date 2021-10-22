using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Compares the equality of double values using a specified amount of
    /// decimal digits to compare.
    /// </summary>
    public sealed class DoubleEqualityComparer : IEqualityComparer<double>
    {
        /// <summary>
        /// The number of decimal digits to compare when determining equality.
        /// </summary>
        public int digits = 3;

        /// <summary>
        /// Checks the equality of two double values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>True if the values are equal, false otherwise.</returns>
        public bool Equals(double x, double y)
        {
            return System.Math.Round(x, digits) == System.Math.Round(y, digits);
        }

        /// <summary>
        /// Returns a hash code for the double value.
        /// </summary>
        /// <param name="value">The value to get the hash code for.</param>
        /// <returns>The hash code for the value.</returns>
        public int GetHashCode(double value)
        {
            return System.Math.Round(value, digits).GetHashCode();
        }

    }

}
