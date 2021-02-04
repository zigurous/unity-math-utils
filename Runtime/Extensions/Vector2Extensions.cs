using UnityEngine;

namespace Zigurous
{
    public static class Vector2Extensions
    {
        public static Vector2 Abs(this Vector2 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            return vector;
        }

        public static Vector2 Average(this Vector2[] vectors)
        {
            Vector2 average = Vector2.zero;

            if (vectors.Length > 0)
            {
                for (int i = 0; i < vectors.Length; i++) {
                    average += vectors[i];
                }

                average /= vectors.Length;
            }

            return average;
        }

        public static void Ceil(this ref Vector2 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
        }

        public static Vector2 Ceiled(this Vector2 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            return vector;
        }

        public static void Clamp(this ref Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
        }

        public static void ClampWrap(this ref Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Math.Processors.ClampWrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.ClampWrap(vector.y, min.y, max.y);
        }

        public static Vector2 Clamped(this Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
            return vector;
        }

        public static Vector2 ClampedWrap(this Vector2 vector, Vector2 min, Vector2 max)
        {
            vector.x = Math.Processors.ClampWrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.ClampWrap(vector.y, min.y, max.y);
            return vector;
        }

        public static void Floor(this ref Vector2 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
        }

        public static Vector2 Floored(this Vector2 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            return vector;
        }

        public static bool IsEqualTo(this Vector2 lhs, Vector2 rhs)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y);
        }

        public static bool IsEqualTo(this Vector2 lhs, Vector2 rhs, float epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x, epsilon) &&
                   lhs.y.IsEqualTo(rhs.y, epsilon);
        }

        public static bool IsNotEqualTo(this Vector2 lhs, Vector2 rhs)
        {
            return !(lhs.x.IsEqualTo(rhs.x) &&
                     lhs.y.IsEqualTo(rhs.y));
        }

        public static bool IsNotEqualTo(this Vector2 lhs, Vector2 rhs, float epsilon)
        {
            return !(lhs.x.IsEqualTo(rhs.x, epsilon) &&
                     lhs.y.IsEqualTo(rhs.y, epsilon));
        }

        public static bool IsNotZero(this Vector2 vector)
        {
            return !(vector.x.IsZero() &&
                     vector.y.IsZero());
        }

        public static bool IsNotZero(this Vector2 vector, float epsilon)
        {
            return !(vector.x.IsZero(epsilon) &&
                     vector.y.IsZero(epsilon));
        }

        public static bool IsZero(this Vector2 vector)
        {
            return vector.x.IsZero() &&
                   vector.y.IsZero();
        }

        public static bool IsZero(this Vector2 vector, float epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon);
        }

        public static void Round(this ref Vector2 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
        }

        public static Vector2 Rounded(this Vector2 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            return vector;
        }

        public static void ScaleBy(this ref Vector2 vector, Vector2 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
        }

        public static Vector2 ScaledBy(this Vector2 vector, Vector2 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
            return vector;
        }

        public static void SetUniform(this ref Vector2 vector, float value)
        {
            vector.x = value;
            vector.y = value;
        }

        public static Vector2 SetUniformly(this Vector2 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            return vector;
        }

    }

}
