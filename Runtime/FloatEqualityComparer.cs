using System.Collections.Generic;

namespace Zigurous.Math
{
    /// <summary>
    /// Determines equality between float values given an amount of decimal
    /// digits to compare.
    /// </summary>
    public sealed class FloatEqualityComparer : IEqualityComparer<float>
    {
        /// <summary>
        /// The number of decimal digits to compare when determining equality.
        /// </summary>
        public int digits = 3;

        /// <summary>
        /// Determines whether the specified floats are equal.
        /// </summary>
        public bool Equals(float x, float y) => System.Math.Round(x, this.digits) == System.Math.Round(y, this.digits);

        /// <summary>
        /// Returns a hash code for the specified float value.
        /// </summary>
        public int GetHashCode(float f) => System.Math.Round(f, this.digits).GetHashCode();

    }

}
