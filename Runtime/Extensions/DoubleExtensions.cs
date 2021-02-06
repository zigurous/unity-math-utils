namespace Zigurous.Math
{
    public static class DoubleExtensions
    {
        public static bool IsInRange(this double value, double min, double max) => value >= min && value <= max;

        public static bool IsNaN(this double value) => double.IsNaN(value);
        public static bool IsNotNaN(this double value) => !double.IsNaN(value);

        public static bool IsInfinity(this double value) => double.IsInfinity(value);
        public static bool IsNotInfinity(this double value) => !double.IsInfinity(value);

        public static bool IsPositiveInfinity(this double value) => double.IsPositiveInfinity(value);
        public static bool IsNegativeInfinity(this double value) => double.IsNegativeInfinity(value);

        public static bool IsRealNumber(this double value) => !double.IsInfinity(value) && !double.IsNaN(value);
        public static bool IsImaginaryNumber(this double value) => double.IsInfinity(value) || double.IsNaN(value);
        public static bool IsDividable(this double value) => value != 0.0f && !double.IsInfinity(value) && !double.IsNaN(value);

        public static bool IsPositive(this double value) => value > 0.0f;
        public static bool IsNegative(this double value) => value < 0.0f;

        public static bool IsZero(this double value) => (value > -double.Epsilon) && (value < double.Epsilon);
        public static bool IsZero(this double value, double epsilon) => (value > -epsilon) && (value < epsilon);

        public static bool IsNotZero(this double value) => !((value > -double.Epsilon) && (value < double.Epsilon));
        public static bool IsNotZero(this double value, double epsilon) => !((value > -epsilon) && (value < epsilon));

        public static bool IsEqualTo(this double lhs, double rhs) => System.Math.Abs(lhs - rhs) < double.Epsilon;
        public static bool IsEqualTo(this double lhs, double rhs, double epsilon) => System.Math.Abs(lhs - rhs) < epsilon;

        public static bool IsNotEqualTo(this double lhs, double rhs) => !(System.Math.Abs(lhs - rhs) < double.Epsilon);
        public static bool IsNotEqualTo(this double lhs, double rhs, double epsilon) => !(System.Math.Abs(lhs - rhs) < epsilon);

        public static double NotImaginary(this double value, double newValue = 0.0f) => IsRealNumber(value) ? value : newValue;
        public static double NotInfinity(this double value, double newValue = 0.0f) => IsNotInfinity(value) ? value : newValue;
        public static double NotNaN(this double value, double newValue = 0.0f) => IsNotNaN(value) ? value : newValue;
        public static double NotZero(this double value, double newValue = System.Double.Epsilon) => IsNotZero(value) ? value : newValue;
        public static double NotZero(this double value, double newValue = System.Double.Epsilon, double epsilon = double.Epsilon) => IsNotZero(value, epsilon) ? value : newValue;

    }

}
