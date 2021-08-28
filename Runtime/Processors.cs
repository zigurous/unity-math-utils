using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Functions for processing input values.
    /// </summary>
    public static class Processors
    {
        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static float Abs(float input)
        {
            return System.Math.Abs(input);
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static double Abs(double input)
        {
            return System.Math.Abs(input);
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static int Abs(int input)
        {
            return System.Math.Abs(input);
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static Vector2 Abs(Vector2 input)
        {
            return new Vector2(Abs(input.x), Abs(input.y));
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static Vector2Int Abs(Vector2Int input)
        {
            return new Vector2Int(Abs(input.x), Abs(input.y));
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static Vector3 Abs(Vector3 input)
        {
            return new Vector3(Abs(input.x), Abs(input.y), Abs(input.z));
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static Vector3Int Abs(Vector3Int input)
        {
            return new Vector3Int(Abs(input.x), Abs(input.y), Abs(input.z));
        }

        /// <summary>
        /// Returns the absolute value of the input.
        /// </summary>
        /// <param name="input">The input value to absolute.</param>
        public static Vector4 Abs(Vector4 input)
        {
            return new Vector4(Abs(input.x), Abs(input.y), Abs(input.z), Abs(input.w));
        }

        /// <summary>
        /// An axis deadzone scales the input such that any value with an
        /// absolute value smaller than <paramref name="min"/> is 0, and any
        /// value with an absolute value larger than <paramref name="max"/> is
        /// 1 or -1.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="min">The lower deadzone threshold.</param>
        /// <param name="max">The upper deadzone threshold.</param>
        public static float AxisDeadzone(float input, float min = 0.125f, float max = 0.925f)
        {
            if (input >= 0f)
            {
                if (input < min) return 0f;
                if (input > max) return 1f;
            }
            else
            {
                if (input > -min) return 0f;
                if (input < -max) return -1f;
            }

            return input;
        }

        /// <summary>
        /// An axis deadzone scales the input such that any value with an
        /// absolute value smaller than <paramref name="min"/> is 0, and any
        /// value with an absolute value larger than <paramref name="max"/> is
        /// 1 or -1.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="min">The lower deadzone threshold.</param>
        /// <param name="max">The upper deadzone threshold.</param>
        public static double AxisDeadzone(double input, double min = 0.125, double max = 0.925)
        {
            if (input >= 0.0)
            {
                if (input < min) return 0.0;
                if (input > max) return 1.0;
            }
            else
            {
                if (input > -min) return 0.0;
                if (input < -max) return -1.0;
            }

            return input;
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static float Ceil(float input)
        {
            return Mathf.Ceil(input);
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static double Ceil(double input)
        {
            return System.Math.Ceiling(input);
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static int Ceil(int input)
        {
            return Mathf.CeilToInt(input);
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2 Ceil(Vector2 input)
        {
            return new Vector2(Ceil(input.x), Ceil(input.y));
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2Int Ceil(Vector2Int input)
        {
            return new Vector2Int(Ceil(input.x), Ceil(input.y));
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3 Ceil(Vector3 input)
        {
            return new Vector3(Ceil(input.x), Ceil(input.y), Ceil(input.z));
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3Int Ceil(Vector3Int input)
        {
            return new Vector3Int(Ceil(input.x), Ceil(input.y), Ceil(input.z));
        }

        /// <summary>
        /// Rounds the input up to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector4 Ceil(Vector4 input)
        {
            return new Vector4(Ceil(input.x), Ceil(input.y), Ceil(input.z), Ceil(input.w));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
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
        public static Vector2 Clamp(Vector2 input, Vector2 min, Vector2 max)
        {
            return new Vector2(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static Vector2Int Clamp(Vector2Int input, Vector2Int min, Vector2Int max)
        {
            return new Vector2Int(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static Vector3 Clamp(Vector3 input, Vector3 min, Vector3 max)
        {
            return new Vector3(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y), Clamp(input.z, min.z, max.z));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static Vector3Int Clamp(Vector3Int input, Vector3Int min, Vector3Int max)
        {
            return new Vector3Int(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y), Clamp(input.z, min.z, max.z));
        }

        /// <summary>
        /// Clamps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        public static Vector4 Clamp(Vector4 input, Vector4 min, Vector4 max)
        {
            return new Vector4(Clamp(input.x, min.x, max.x), Clamp(input.y, min.y, max.y), Clamp(input.z, min.z, max.z), Clamp(input.w, min.w, max.w));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static float Clamp01(float input)
        {
            return input < 0f ? 0f : (input > 1f ? 1f : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static double Clamp01(double input)
        {
            return input < 0.0 ? 0.0 : (input > 1.0 ? 1.0 : input);
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static int Clamp01(int input)
        {
            return input >= 1 ? 1 : 0;
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static Vector2 Clamp01(Vector2 input)
        {
            return new Vector2(Clamp01(input.x), Clamp01(input.y));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static Vector2Int Clamp01(Vector2Int input)
        {
            return new Vector2Int(Clamp01(input.x), Clamp01(input.y));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static Vector3 Clamp01(Vector3 input)
        {
            return new Vector3(Clamp01(input.x), Clamp01(input.y), Clamp01(input.z));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static Vector3Int Clamp01(Vector3Int input)
        {
            return new Vector3Int(Clamp01(input.x), Clamp01(input.y), Clamp01(input.z));
        }

        /// <summary>
        /// Clamps the input to the range [0..1].
        /// </summary>
        /// <param name="input">The input value to clamp.</param>
        public static Vector4 Clamp01(Vector4 input)
        {
            return new Vector4(Clamp01(input.x), Clamp01(input.y), Clamp01(input.z), Clamp01(input.w));
        }

        /// <summary>
        /// Decays the input back to zero over time at a given
        /// <paramref name="rate"/>. The <paramref name="rate"/> is multiplied
        /// by <c>Time.deltaTime</c>.
        /// </summary>
        /// <param name="input">The input value to decay.</param>
        /// <param name="rate">How quickly the input decays.</param>
        /// <param name="target">The optional value to decay to, otherwise zero.</param>
        public static float Decay(float input, float rate, float target = 0f)
        {
            if (input > target) {
                return System.Math.Max(input - (rate * Time.deltaTime), target);
            } else if (input < target) {
                return System.Math.Min(input + (rate * Time.deltaTime), target);
            } else {
                return input;
            }
        }

        /// <summary>
        /// Decays the input back to zero over time at a given
        /// <paramref name="rate"/>. The <paramref name="rate"/> is multiplied
        /// by <c>Time.deltaTime</c>.
        /// </summary>
        /// <param name="input">The input value to decay.</param>
        /// <param name="rate">How quickly the input decays.</param>
        /// <param name="target">The optional value to decay to, otherwise zero.</param>
        public static double Decay(double input, double rate, double target = 0.0)
        {
            if (input > target) {
                return System.Math.Max(input - (rate * Time.deltaTime), target);
            } else if (input < target) {
                return System.Math.Min(input + (rate * Time.deltaTime), target);
            } else {
                return input;
            }
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static float Floor(float input)
        {
            return Mathf.Floor(input);
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static double Floor(double input)
        {
            return System.Math.Floor(input);
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static int Floor(int input)
        {
            return Mathf.FloorToInt(input);
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2 Floor(Vector2 input)
        {
            return new Vector2(Floor(input.x), Floor(input.y));
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2Int Floor(Vector2Int input)
        {
            return new Vector2Int(Floor(input.x), Floor(input.y));
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3 Floor(Vector3 input)
        {
            return new Vector3(Floor(input.x), Floor(input.y), Floor(input.z));
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3Int Floor(Vector3Int input)
        {
            return new Vector3Int(Floor(input.x), Floor(input.y), Floor(input.z));
        }

        /// <summary>
        /// Rounds the input down to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector4 Floor(Vector4 input)
        {
            return new Vector4(Floor(input.x), Floor(input.y), Floor(input.z), Floor(input.w));
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static float Invert(float input)
        {
            return input * -1f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static double Invert(double input)
        {
            return input * -1.0;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static int Invert(int input)
        {
            return input * -1;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static Vector2 Invert(Vector2 input)
        {
            return input * -1f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        public static Vector2 Invert(Vector2 input, bool invertX, bool invertY)
        {
            Vector2 inverted = input;
            if (invertX) inverted.x *= -1f;
            if (invertY) inverted.y *= -1f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static Vector2Int Invert(Vector2Int input)
        {
            return input * -1;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        public static Vector2Int Invert(Vector2Int input, bool invertX, bool invertY)
        {
            Vector2Int inverted = input;
            if (invertX) inverted.x *= -1;
            if (invertY) inverted.y *= -1;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static Vector3 Invert(Vector3 input)
        {
            return input * -1f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <param name="invertZ">Inverts the z-axis.</param>
        public static Vector3 Invert(Vector3 input, bool invertX, bool invertY, bool invertZ)
        {
            Vector3 inverted = input;
            if (invertX) inverted.x *= -1f;
            if (invertY) inverted.y *= -1f;
            if (invertZ) inverted.z *= -1f;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static Vector3Int Invert(Vector3Int input)
        {
            return input * -1;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <param name="invertZ">Inverts the z-axis.</param>
        public static Vector3Int Invert(Vector3Int input, bool invertX, bool invertY, bool invertZ)
        {
            Vector3Int inverted = input;
            if (invertX) inverted.x *= -1;
            if (invertY) inverted.y *= -1;
            if (invertZ) inverted.z *= -1;
            return inverted;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        public static Vector4 Invert(Vector4 input)
        {
            return input * -1f;
        }

        /// <summary>
        /// Inverts the input by multiplying by -1.
        /// </summary>
        /// <param name="input">The input value to invert.</param>
        /// <param name="invertX">Inverts the x-axis.</param>
        /// <param name="invertY">Inverts the y-axis.</param>
        /// <param name="invertZ">Inverts the z-axis.</param>
        /// <param name="invertW">Inverts the w-axis.</param>
        public static Vector4 Invert(Vector4 input, bool invertX, bool invertY, bool invertZ, bool invertW)
        {
            Vector4 inverted = input;
            if (invertX) inverted.x *= -1f;
            if (invertY) inverted.y *= -1f;
            if (invertZ) inverted.z *= -1f;
            if (invertW) inverted.w *= -1f;
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
        public static float Normalize(float input, float min, float max, float zero = 0f)
        {
            if (min >= zero) {
                return (input - min) / (max - min);
            } else {
                return 2f * ((input - min) / (max - min)) - 1f;
            }
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
        public static double Normalize(double input, double min, double max, double zero = 0.0)
        {
            if (min >= zero) {
                return (input - min) / (max - min);
            } else {
                return 2.0 * ((input - min) / (max - min)) - 1.0;
            }
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling <c>Vector2.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        public static Vector2 Normalize(Vector2 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling <c>Vector3.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        public static Vector3 Normalize(Vector3 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Normalizes the input vector to be of unit length (1). This is the
        /// same as calling <c>Vector4.normalized</c>.
        /// </summary>
        /// <param name="input">The input value to normalize.</param>
        public static Vector4 Normalize(Vector4 input)
        {
            return input.normalized;
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static float Round(float input)
        {
            return Mathf.Round(input);
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static double Round(double input)
        {
            return System.Math.Round(input);
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static int Round(int input)
        {
            return Mathf.RoundToInt(input);
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2 Round(Vector2 input)
        {
            return new Vector2(Round(input.x), Round(input.y));
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector2Int Round(Vector2Int input)
        {
            return new Vector2Int(Round(input.x), Round(input.y));
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3 Round(Vector3 input)
        {
            return new Vector3(Round(input.x), Round(input.y), Round(input.z));
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector3Int Round(Vector3Int input)
        {
            return new Vector3Int(Round(input.x), Round(input.y), Round(input.z));
        }

        /// <summary>
        /// Rounds the input to the nearest whole number.
        /// </summary>
        /// <param name="input">The input value to round.</param>
        public static Vector4 Round(Vector4 input)
        {
            return new Vector4(Round(input.x), Round(input.y), Round(input.z), Round(input.w));
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        public static float Scale(float input, float factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        public static double Scale(double input, double factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        public static int Scale(int input, int factor)
        {
            return input * factor;
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
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
        public static Vector2 Scale(Vector2 input, float x, float y)
        {
            return new Vector2(input.x * x, input.y * y);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        public static Vector2Int Scale(Vector2Int input, int factor)
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
        public static Vector2Int Scale(Vector2Int input, int x, int y)
        {
            return new Vector2Int(input.x * x, input.y * y);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
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
        public static Vector3 Scale(Vector3 input, float x, float y, float z)
        {
            return new Vector3(input.x * x, input.y * y, input.z * z);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
        public static Vector3Int Scale(Vector3Int input, int factor)
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
        public static Vector3Int Scale(Vector3Int input, int x, int y, int z)
        {
            return new Vector3Int(input.x * x, input.y * y, input.z * z);
        }

        /// <summary>
        /// Multiplies the input by <paramref name="factor"/>.
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="factor">The scale factor.</param>
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
        public static Vector4 Scale(Vector4 input, float x, float y, float z, float w)
        {
            return new Vector4(input.x * x, input.y * y, input.z * z, input.w * w);
        }

        /// <summary>
        /// A stick deadzone scales the input such that any value with a
        /// magnitude smaller than <paramref name="min"/> results in (0,0), and
        /// any value with a magnitude greater than <paramref name="max"/> is
        /// normalized to unit length (1).
        /// </summary>
        /// <param name="input">The input value to scale.</param>
        /// <param name="min">The lower deadzone threshold.</param>
        /// <param name="max">The upper deadzone threshold.</param>
        public static Vector2 StickDeadzone(Vector2 input, float min = 0.125f, float max = 0.925f)
        {
            float magnitude = input.magnitude;
            if (magnitude < min) return Vector2.zero;
            if (magnitude > max) return input.normalized;
            return input;
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
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
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
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
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>). If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static int Wrap(int input, int min, int max)
        {
            if (input < min) {
                return max - (min - input) % (max - min);
            } else {
                return min + (input - min) % (max - min);
            }
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static Vector2 Wrap(Vector2 input, Vector2 min, Vector2 max)
        {
            return new Vector2(
                Wrap(input.x, min.x, max.x),
                Wrap(input.y, min.y, max.y));
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static Vector2Int Wrap(Vector2Int input, Vector2Int min, Vector2Int max)
        {
            return new Vector2Int(
                Wrap(input.x, min.x, max.x),
                Wrap(input.y, min.y, max.y));
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static Vector3 Wrap(Vector3 input, Vector3 min, Vector3 max)
        {
            return new Vector3(
                Wrap(input.x, min.x, max.x),
                Wrap(input.y, min.y, max.y),
                Wrap(input.z, min.z, max.z));
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static Vector3Int Wrap(Vector3Int input, Vector3Int min, Vector3Int max)
        {
            return new Vector3Int(
                Wrap(input.x, min.x, max.x),
                Wrap(input.y, min.y, max.y),
                Wrap(input.z, min.z, max.z));
        }

        /// <summary>
        /// Wraps the input to the range
        /// [<paramref name="min"/>..<paramref name="max"/>]. If the value
        /// exceeds <paramref name="max"/> it wraps around to
        /// <paramref name="min"/>, and if the value is less than
        /// <paramref name="min"/> it wraps back to <paramref name="max"/>.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        public static Vector4 Wrap(Vector4 input, Vector4 min, Vector4 max)
        {
            return new Vector4(
                Wrap(input.x, min.x, max.x),
                Wrap(input.y, min.y, max.y),
                Wrap(input.z, min.z, max.z),
                Wrap(input.w, min.w, max.w));
        }

        /// <summary>
        /// Wraps the input to the range [0..1]. If the value exceeds 1 it wraps
        /// around to 0, and if the value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static float Wrap01(float input)
        {
            if (input < 0f) {
                return 1f - (-input % 1f);
            } else if (input > 1f) {
                return input % 1f;
            } else {
                return input;
            }
        }

        /// <summary>
        /// Wraps the input to the range [0..1]. If the value exceeds 1 it wraps
        /// around to 0, and if the value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static double Wrap01(double input)
        {
            if (input < 0.0) {
                return 1.0 - (-input % 1.0);
            } else if (input > 1.0) {
                return input % 1.0;
            } else {
                return input;
            }
        }

        /// <summary>
        /// Wraps the input to the range [0..1]. If the value exceeds 1 it wraps
        /// around to 0, and if the value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static int Wrap01(int input)
        {
            if (input < 0) {
                return 1 - (-input % 1);
            } else {
                return input % 1;
            }
        }

        /// <summary>
        /// Wraps the input values to the range [0..1]. If a value exceeds 1 it
        /// wraps around to 0, and if a value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static Vector2 Wrap01(Vector2 input)
        {
            return new Vector2(Wrap01(input.x), Wrap01(input.y));
        }

        /// <summary>
        /// Wraps the input values to the range [0..1]. If a value exceeds 1 it
        /// wraps around to 0, and if a value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static Vector2Int Wrap01(Vector2Int input)
        {
            return new Vector2Int(Wrap01(input.x), Wrap01(input.y));
        }

        /// <summary>
        /// Wraps the input values to the range [0..1]. If a value exceeds 1 it
        /// wraps around to 0, and if a value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static Vector3 Wrap01(Vector3 input)
        {
            return new Vector3(Wrap01(input.x), Wrap01(input.y), Wrap01(input.z));
        }

        /// <summary>
        /// Wraps the input values to the range [0..1]. If a value exceeds 1 it
        /// wraps around to 0, and if a value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static Vector3Int Wrap01(Vector3Int input)
        {
            return new Vector3Int(Wrap01(input.x), Wrap01(input.y), Wrap01(input.z));
        }

        /// <summary>
        /// Wraps the input values to the range [0..1]. If a value exceeds 1 it
        /// wraps around to 0, and if a value is less than 0 it wraps back to 1.
        /// </summary>
        /// <param name="input">The input value to wrap.</param>
        public static Vector4 Wrap01(Vector4 input)
        {
            return new Vector4(Wrap01(input.x), Wrap01(input.y), Wrap01(input.z), Wrap01(input.w));
        }

    }

}
