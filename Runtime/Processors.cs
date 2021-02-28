using UnityEngine;

namespace Zigurous.Math
{
    public static class Processors
    {
        /// <summary>
        /// An axis deadzone scales the input such that any value with an
        /// absolute value smaller than min is 0, and any value with an absolute
        /// value larger than max is 1 or -1.
        /// </summary>
        public static float AxisDeadzone(float input, float min = 0.125f, float max = 0.925f)
        {
            if (input >= 0.0f)
            {
                if (input < min) return 0.0f;
                if (input > max) return 1.0f;
            }
            else
            {
                if (input > -min) return 0.0f;
                if (input < -max) return -1.0f;
            }

            return input;
        }

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static int Clamp(int input, int min, int max) => input < min ? min : (input > max ? max : input);

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static uint Clamp(uint input, uint min, uint max) => input < min ? min : (input > max ? max : input);

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static float Clamp(float input, float min, float max) => input < min ? min : (input > max ? max : input);

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static double Clamp(double input, double min, double max) => input < min ? min : (input > max ? max : input);

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static Vector3 Clamp(Vector2 input, Vector2 min, Vector2 max) => new Vector2(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y));

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static Vector3 Clamp(Vector3 input, Vector3 min, Vector3 max) => new Vector3(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y), Clamp(input.z, min.z, max.z));

        /// <summary>
        /// Clamps the input to the [min..max] range.
        /// </summary>
        public static Vector4 Clamp(Vector4 input, Vector4 min, Vector4 max) => new Vector4(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y), Clamp(input.z, min.z, max.z), Clamp(input.w, min.w, max.w));

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static int Clamp01(int input) => input < 0 ? 0 : (input > 1 ? 1 : input);

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static uint Clamp01(uint input) => input < 0 ? 0 : (input > 1 ? 1 : input);

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static float Clamp01(float input) => input < 0.0f ? 0.0f : (input > 1.0f ? 1.0f : input);

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static double Clamp01(double input) => input < 0.0 ? 0.0 : (input > 1.0 ? 1.0 : input);

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static Vector2 Clamp01(Vector2 input) => new Vector2(Clamp01(input.x), Clamp01(input.y));

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static Vector3 Clamp01(Vector3 input) => new Vector3(Clamp01(input.x), Clamp01(input.y), Clamp01(input.z));

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        public static Vector4 Clamp01(Vector4 input) => new Vector4(Clamp01(input.x), Clamp01(input.y), Clamp01(input.z), Clamp01(input.w));

        /// <summary>
        /// Decays the input back to zero over time by the decayRate *
        /// Time.deltaTime.
        /// </summary>
        public static float Decay(float input, float decayRate, float zero = 0.0f)
        {
            if (input >= zero) {
                return System.Math.Max(input - (decayRate * Time.deltaTime), zero);
            } else {
                return System.Math.Min(input + (decayRate * Time.deltaTime), zero);
            }
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        public static float Invert(float input) => input * -1.0f;

        /// <summary>
        /// Inverts the input values by multiplying by -1.
        /// </summary>
        public static Vector2 Invert(Vector2 input) => input * -1.0f;

        /// <summary>
        /// Inverts the input values by multiplying by -1. Inverts the x axis of
        /// the vector if invertX is true, and the y axis if invertY is true.
        /// </summary>
        public static Vector2 Invert(Vector2 input, bool invertX, bool invertY)
        {
            Vector2 inverted = input;
            if (invertX) inverted.x *= -1.0f;
            if (invertY) inverted.y *= -1.0f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input values by multiplying by -1.
        /// </summary>
        public static Vector3 Invert(Vector3 input) => input * -1.0f;

        /// <summary>
        /// Inverts the input values by multiplying by -1. Inverts the x axis of
        /// the vector if invertX is true, the y axis if invertY is true, and
        /// the z axis if invertZ is true.
        /// </summary>
        public static Vector3 Invert(Vector3 input, bool invertX, bool invertY, bool invertZ)
        {
            Vector3 inverted = input;
            if (invertX) inverted.x *= -1.0f;
            if (invertY) inverted.y *= -1.0f;
            if (invertZ) inverted.z *= -1.0f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input values by multiplying by -1.
        /// </summary>
        public static Vector4 Invert(Vector4 input) => input * -1.0f;

        /// <summary>
        /// Inverts the input values by multiplying by -1. Inverts the x axis of
        /// the vector if invertX is true, the y axis if invertY is true, the z
        /// axis if invertZ is true, and the w axis if invertW is true.
        /// </summary>
        public static Vector4 Invert(Vector4 input, bool invertX, bool invertY, bool invertZ, bool invertW)
        {
            Vector4 inverted = input;
            if (invertX) inverted.x *= -1.0f;
            if (invertY) inverted.y *= -1.0f;
            if (invertZ) inverted.z *= -1.0f;
            if (invertW) inverted.w *= -1.0f;
            return inverted;
        }

        /// <summary>
        /// Normalizes the input in the range [min..max] to unsigned normalized
        /// form [0..1] if min is >= zero, and to signed normalized form [-1..1]
        /// if min is less than zero.
        /// </summary>
        public static float Normalize(float input, float min, float max, float zero = 0.0f)
        {
            if (min >= zero) {
                return (input - min) / (max - min);
            } else {
                return 2.0f * ((input - min) / (max - min)) - 1.0f;
            }
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling Vector2.normalized.
        /// </summary>
        public static Vector2 Normalize(Vector2 input) => input.normalized;

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling Vector3.normalized.
        /// </summary>
        public static Vector3 Normalize(Vector3 input) => input.normalized;

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling Vector4.normalized.
        /// </summary>
        public static Vector4 Normalize(Vector4 input) => input.normalized;

        /// <summary>
        /// Multiplies the input by factor.
        /// </summary>
        public static float Scale(float input, float factor) => input * factor;

        /// <summary>
        /// Multiplies the input vector by factor.
        /// </summary>
        public static Vector2 Scale(Vector2 input, float factor) => input * factor;

        /// <summary>
        /// Multiplies all input values by x along the X axis and by y along the
        /// Y axis.
        /// </summary>
        public static Vector2 Scale(Vector2 input, float x, float y) => new Vector2(input.x * x, input.y * y);

        /// <summary>
        /// Multiplies the input vector by factor.
        /// </summary>
        public static Vector3 Scale(Vector3 input, float factor) => input * factor;

        /// <summary>
        /// Multiplies all input values by x along the X axis, by y along the Y
        /// axis, and by z along the Z axis.
        /// </summary>
        public static Vector3 Scale(Vector3 input, float x, float y, float z) => new Vector3(input.x * x, input.y * y, input.z * z);

        /// <summary>
        /// Multiplies the input vector by factor.
        /// </summary>
        public static Vector4 Scale(Vector4 input, float factor) => input * factor;

        /// <summary>
        /// Multiplies all input values by x along the X axis, by y along the Y
        /// axis, by z along the Z axis, and w along the W axis.
        /// </summary>
        public static Vector4 Scale(Vector4 input, float x, float y, float z, float w) => new Vector4(input.x * x, input.y * y, input.z * z, input.w * w);

        /// <summary>
        /// Wraps the input to the [min..max] range. If the value exceeds max it
        /// wraps around to min, and if the value is less than min it wraps back
        /// to max.
        /// </summary>
        public static float Wrap(float input, float min, float max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else if (input > max) {
                return min + (input - min) % (max - min);
            } else {
                return input;
            }
        }

        /// <summary>
        /// Wraps the input to the [min..max] range. If the value exceeds max it
        /// wraps around to min, and if the value is less than min it wraps back
        /// to max.
        /// </summary>
        public static double Wrap(double input, double min, double max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else if (input > max) {
                return min + (input - min) % (max - min);
            } else {
                return input;
            }
        }

        /// <summary>
        /// Wraps the input to the [min..max) range. If the value exceeds max it
        /// wraps around to min, and if the value is less than min it wraps back
        /// to max.
        /// </summary>
        public static int Wrap(int input, int min, int max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else {
                return min + (input - min) % (max - min);
            }
        }

        /// <summary>
        /// Wraps the input to the [min..max) range. If the value exceeds max it
        /// wraps around to min, and if the value is less than min it wraps back
        /// to max.
        /// </summary>
        public static uint Wrap(uint input, uint min, uint max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else {
                return min + (input - min) % (max - min);
            }
        }

    }

}
