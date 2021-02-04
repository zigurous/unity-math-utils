namespace Zigurous
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Sometimes Unity throws precision errors for really
        /// small numbers such as when setting transform values.
        /// Using float.Epsilon can still cause issues so this
        /// value is intended to be a safer alternative.
        /// </summary>
        public const float SAFE_FLOAT = 1.4E-32f;

        public static bool IsInRange(this float value, float min, float max) => value >= min && value <= max;

        public static bool IsNaN(this float value) => float.IsNaN(value);
        public static bool IsNotNaN(this float value) => !float.IsNaN(value);

        public static bool IsInfinity(this float value) => float.IsInfinity(value);
        public static bool IsNotInfinity(this float value) => !float.IsInfinity(value);

        public static bool IsPositiveInfinity(this float value) => float.IsPositiveInfinity(value);
        public static bool IsNegativeInfinity(this float value) => float.IsNegativeInfinity(value);

        public static bool IsRealNumber(this float value) => !float.IsInfinity(value) && !float.IsNaN(value);
        public static bool IsImaginaryNumber(this float value) => float.IsInfinity(value) || float.IsNaN(value);
        public static bool IsDividable(this float value) => value != 0.0f && !float.IsInfinity(value) && !float.IsNaN(value);

        public static bool IsPositive(this float value) => value > 0.0f;
        public static bool IsNegative(this float value) => value < 0.0f;

        public static bool IsZero(this float value) => (value > -float.Epsilon) && (value < float.Epsilon);
        public static bool IsZero(this float value, float epsilon) => (value > -epsilon) && (value < epsilon);

        public static bool IsNotZero(this float value) => !((value > -float.Epsilon) && (value < float.Epsilon));
        public static bool IsNotZero(this float value, float epsilon) => !((value > -epsilon) && (value < epsilon));

        public static bool IsEqualTo(this float lhs, float rhs) => System.Math.Abs(lhs - rhs) < float.Epsilon;
        public static bool IsEqualTo(this float lhs, float rhs, float epsilon) => System.Math.Abs(lhs - rhs) < epsilon;

        public static bool IsNotEqualTo(this float lhs, float rhs) => !(System.Math.Abs(lhs - rhs) < float.Epsilon);
        public static bool IsNotEqualTo(this float lhs, float rhs, float epsilon) => !(System.Math.Abs(lhs - rhs) < epsilon);

        public static float NotImaginary(this float value, float newValue = 0.0f) => IsRealNumber(value) ? value : newValue;
        public static float NotInfinity(this float value, float newValue = 0.0f) => IsNotInfinity(value) ? value : newValue;
        public static float NotNaN(this float value, float newValue = 0.0f) => IsNotNaN(value) ? value : newValue;
        public static float NotZero(this float value, float newValue = SAFE_FLOAT) => IsNotZero(value) ? value : newValue;
        public static float NotZero(this float value, float newValue = SAFE_FLOAT, float epsilon = float.Epsilon) => IsNotZero(value, epsilon) ? value : newValue;

    }

}
