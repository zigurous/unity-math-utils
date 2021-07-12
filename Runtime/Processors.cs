using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Functions for processing input values.
    /// </summary>
    public static class Processors
    {
        /// <summary>
        /// An axis deadzone scales the input such that any value with an
        /// absolute value smaller than <paramref name="min"/> is 0, and any
        /// value with an absolute value larger than <paramref name="max"/> is
        /// 1 or -1.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="min">The lower deadzone threshold.</param>
        /// <param name="max">The upper deadzone threshold.</param>
        /// <returns>The input value scaled to the deadzone.</returns>
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
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static int Clamp(int input, int min, int max)
        {
            return input < min ? min : (input > max ? max : input);
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static uint Clamp(uint input, uint min, uint max)
        {
            return input < min ? min : (input > max ? max : input);
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static float Clamp(float input, float min, float max)
        {
            return input < min ? min : (input > max ? max : input);
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static double Clamp(double input, double min, double max)
        {
            return input < min ? min : (input > max ? max : input);
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector3 Clamp(Vector2 input, Vector2 min, Vector2 max)
        {
            return new Vector2(
                Clamp(input.x, min.x, max.x),
                Clamp(input.y, min.y, max.y));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector3 Clamp(Vector3 input, Vector3 min, Vector3 max)
        {
            return new Vector3(
                Clamp(input.x, min.x, max.x),
                Clamp(input.y, min.y, max.y),
                Clamp(input.z, min.z, max.z));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector4 Clamp(Vector4 input, Vector4 min, Vector4 max)
        {
            return new Vector4(
                Clamp(input.x, min.x, max.x),
                Clamp(input.y, min.y, max.y),
                Clamp(input.z, min.z, max.z),
                Clamp(input.w, min.w, max.w));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static int Clamp01(int input)
        {
            return input < 0 ? 0 : (input > 1 ? 1 : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static uint Clamp01(uint input)
        {
            return input < 0 ? 0 : (input > 1 ? 1 : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static float Clamp01(float input)
        {
            return input < 0.0f ? 0.0f : (input > 1.0f ? 1.0f : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static double Clamp01(double input)
        {
            return input < 0.0 ? 0.0 : (input > 1.0 ? 1.0 : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector2 Clamp01(Vector2 input)
        {
            return new Vector2(
                Clamp01(input.x),
                Clamp01(input.y));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector3 Clamp01(Vector3 input)
        {
            return new Vector3(
                Clamp01(input.x),
                Clamp01(input.y),
                Clamp01(input.z));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <returns>The input value clamped to the range.</returns>
        public static Vector4 Clamp01(Vector4 input)
        {
            return new Vector4(
                Clamp01(input.x),
                Clamp01(input.y),
                Clamp01(input.z),
                Clamp01(input.w));
        }

        /// <summary>
        /// Decays the input back to zero over time.
        /// </summary>
        /// <param name="input">The input value to decay.</param>
        /// <param name="rate">How quickly the input decays.</param>
        /// <param name="target">The optional value to decay to, otherwise zero.</param>
        /// <returns>The decayed input value.</returns>
        public static float Decay(float input, float rate, float target = 0.0f)
        {
            if (input > target) {
                return Mathf.Max(input - (rate * Time.deltaTime), target);
            } else if (input < target) {
                return Mathf.Min(input + (rate * Time.deltaTime), target);
            } else {
                return input;
            }
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <returns>The inverted input value.</returns>
        public static float Invert(float input)
        {
            return input * -1.0f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <returns>The inverted input value.</returns>
        public static Vector2 Invert(Vector2 input)
        {
            return input * -1.0f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <returns>The inverted input value.</returns>
        public static Vector2 Invert(Vector2 input, bool invertX, bool invertY)
        {
            Vector2 inverted = input;
            if (invertX) inverted.x *= -1.0f;
            if (invertY) inverted.y *= -1.0f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <returns>The inverted input value.</returns>
        public static Vector3 Invert(Vector3 input)
        {
            return input * -1.0f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <param name="invertZ">Inverts the z-axis.</param>
        /// <returns>The inverted input value.</returns>
        public static Vector3 Invert(Vector3 input, bool invertX, bool invertY, bool invertZ)
        {
            Vector3 inverted = input;
            if (invertX) inverted.x *= -1.0f;
            if (invertY) inverted.y *= -1.0f;
            if (invertZ) inverted.z *= -1.0f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <returns>The inverted input value.</returns>
        public static Vector4 Invert(Vector4 input)
        {
            return input * -1.0f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <param name="invertZ">Inverts the z-axis.</param>
        /// <param name="invertW">Inverts the w-axis.</param>
        /// <returns>The inverted input value.</returns>
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
        /// Normalizes the input value in the range
        /// [<paramref name="min"/>..<paramref name="max"/>] to unsigned
        /// normalized form [0..1] if <paramref name="min"/> is >=
        /// <paramref name="zero"/>, and to signed normalized form [-1..1] if
        /// <paramref name="min"/> &#60; <paramref name="zero"/>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>The normalized input value.</returns>
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
        /// same as calling <c>Vector2.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        /// <returns>The normalized input value.</returns>
        public static Vector2 Normalize(Vector2 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling <c>Vector3.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        /// <returns>The normalized input value.</returns>
        public static Vector3 Normalize(Vector3 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling <c>Vector4.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        /// <returns>The normalized input value.</returns>
        public static Vector4 Normalize(Vector4 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        /// <returns>The scaled input value.</returns>
        public static float Scale(float input, float factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector2 Scale(Vector2 input, float factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="x"/> along the x-axis and
        /// <paramref name="y"/> along the y-axis.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="x">The scale factor along the x-axis.</param>
        /// <param name="y">The scale factor along the y-axis.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector2 Scale(Vector2 input, float x, float y)
        {
            return new Vector2(input.x * x, input.y * y);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector3 Scale(Vector3 input, float factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="x"/> along the x-axis,
        /// <paramref name="y"/> along the y-axis, and <paramref name="z"/>
        /// along the z-axis.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="x">The scale factor along the x-axis.</param>
        /// <param name="y">The scale factor along the y-axis.</param>
        /// <param name="z">The scale factor along the z-axis.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector3 Scale(Vector3 input, float x, float y, float z)
        {
            return new Vector3(input.x * x, input.y * y, input.z * z);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector4 Scale(Vector4 input, float factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="x"/> along the x-axis,
        /// <paramref name="y"/> along the y-axis, <paramref name="z"/> along
        /// the z-axis, and <paramref name="w"/> along the w-axis.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="x">The scale factor along the x-axis.</param>
        /// <param name="y">The scale factor along the y-axis.</param>
        /// <param name="z">The scale factor along the z-axis.</param>
        /// <param name="w">The scale factor along the w-axis.</param>
        /// <returns>The scaled input value.</returns>
        public static Vector4 Scale(Vector4 input, float x, float y, float z, float w)
        {
            return new Vector4(input.x * x, input.y * y, input.z * z, input.w * w);
        }

        /// <summary>
        /// Wraps the input to the
        /// [<paramref name="min"/>..<paramref name="max"/>] range. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>The wrapped input value.</returns>
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
        /// Wraps the input to the
        /// [<paramref name="min"/>..<paramref name="max"/>] range. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>The wrapped input value.</returns>
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
        /// Wraps the input to the
        /// [<paramref name="min"/>..<paramref name="max"/>) range. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>The wrapped input value.</returns>
        public static int Wrap(int input, int min, int max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else {
                return min + (input - min) % (max - min);
            }
        }

        /// <summary>
        /// Wraps the input to the
        /// [<paramref name="min"/>..<paramref name="max"/>) range. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>The wrapped input value.</returns>
        public static uint Wrap(uint input, uint min, uint max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else {
                return min + (input - min) % (max - min);
            }
        }

        /// <summary>
        /// Wraps the input to the range [0..1]. If the value exceeds 1 it wraps
        /// around to 0, and if the value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <returns>The wrapped input value.</returns>
        public static float Wrap01(float input)
        {
            if (input < 0.0f) {
                return 1.0f + input % 1.0f;
            } else if (input > 1.0f) {
                return input % 1.0f;
            } else {
                return input;
            }
        }

        /// <summary>
        /// Wraps the input to the range [0..1]. If the value exceeds 1 it wraps
        /// around to 0, and if the value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <returns>The wrapped input value.</returns>
        public static double Wrap01(double input)
        {
            if (input < 0.0) {
                return 1.0 + input % 1.0;
            } else if (input > 1.0) {
                return input % 1.0;
            } else {
                return input;
            }
        }

    }

}
