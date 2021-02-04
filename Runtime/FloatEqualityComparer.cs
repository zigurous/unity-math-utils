using System.Collections.Generic;

namespace Zigurous.Math
{
    public sealed class FloatEqualityComparer : IEqualityComparer<float>
    {
        public int digits = 3;

        public bool Equals(float x, float y) => System.Math.Round(x, this.digits) == System.Math.Round(y, this.digits);

        public int GetHashCode(float f) => System.Math.Round(f, this.digits).GetHashCode();

    }

}
