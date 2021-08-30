using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Compares the equality of float values using a specified amount of
    /// decimal digits to compare.
    /// </summary>
    public sealed class FloatEqualityComparer : IEqualityComparer<float>
    {
        /// <summary>
        /// The number of decimal digits to compare when determining equality.
        /// </summary>
        public int digits = 3;

        /// <summary>
        /// Checks the equality of two float values.
        /// </summary>
        /// <param name="x">The first value to compare.</param>
        /// <param name="y">The second value to compare.</param>
        /// <returns>True if the values are equal, false otherwise.</returns>
        public bool Equals(float x, float y)
        {
            return System.Math.Round(x, this.digits) == System.Math.Round(y, this.digits);
        }

        /// <summary>
        /// Returns a hash code for the float value.
        /// </summary>
        /// <param name="value">The value to get the hash code for.</param>
        /// <returns>The hash code for the value.</returns>
        public int GetHashCode(float value)
        {
            return System.Math.Round(value, this.digits).GetHashCode();
        }

    }

}
