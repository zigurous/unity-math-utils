using UnityEngine;

namespace Zigurous.Math
{
    public static class Vector4Extensions
    {
        public static Vector4 Abs(this Vector4 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            vector.z = System.Math.Abs(vector.z);
            vector.w = System.Math.Abs(vector.w);
            return vector;
        }

        public static Vector4 Average(this Vector4[] vectors)
        {
            Vector4 average = Vector4.zero;

            if (vectors.Length > 0)
            {
                for (int i = 0; i < vectors.Length; i++) {
                    average += vectors[i];
                }

                average /= vectors.Length;
            }

            return average;
        }

        public static void Ceil(this ref Vector4 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            vector.w = Mathf.Ceil(vector.w);
        }

        public static Vector4 Ceiled(this Vector4 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            vector.w = Mathf.Ceil(vector.w);
            return vector;
        }

        public static void Clamp(this ref Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Math.Processors.Clamp(vector.z, min.z, max.z);
            vector.w = Math.Processors.Clamp(vector.w, min.w, max.w);
        }

        public static Vector4 Clamped(this Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Math.Processors.Clamp(vector.z, min.z, max.z);
            vector.w = Math.Processors.Clamp(vector.w, min.w, max.w);
            return vector;
        }

        public static void Floor(this ref Vector4 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            vector.w = Mathf.Floor(vector.w);
        }

        public static Vector4 Floored(this Vector4 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            vector.w = Mathf.Floor(vector.w);
            return vector;
        }

        public static bool IsEqualTo(this Vector4 lhs, Vector4 rhs)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y) &&
                   lhs.z.IsEqualTo(rhs.z) &&
                   lhs.w.IsEqualTo(rhs.w);
        }

        public static bool IsEqualTo(this Vector4 lhs, Vector4 rhs, float epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x, epsilon) &&
                   lhs.y.IsEqualTo(rhs.y, epsilon) &&
                   lhs.z.IsEqualTo(rhs.z, epsilon) &&
                   lhs.w.IsEqualTo(rhs.w, epsilon);
        }

        public static bool IsNotEqualTo(this Vector4 lhs, Vector4 rhs)
        {
            return !(lhs.x.IsEqualTo(rhs.x) &&
                     lhs.y.IsEqualTo(rhs.y) &&
                     lhs.z.IsEqualTo(rhs.z) &&
                     lhs.w.IsEqualTo(rhs.w));
        }

        public static bool IsNotEqualTo(this Vector4 lhs, Vector4 rhs, float epsilon)
        {
            return !(lhs.x.IsEqualTo(rhs.x, epsilon) &&
                     lhs.y.IsEqualTo(rhs.y, epsilon) &&
                     lhs.z.IsEqualTo(rhs.z, epsilon) &&
                     lhs.w.IsEqualTo(rhs.w, epsilon));
        }

        public static bool IsNotZero(this Vector4 vector)
        {
            return !(vector.x.IsZero() &&
                     vector.y.IsZero() &&
                     vector.z.IsZero() &&
                     vector.w.IsZero());
        }

        public static bool IsNotZero(this Vector4 vector, float epsilon)
        {
            return !(vector.x.IsZero(epsilon) &&
                     vector.y.IsZero(epsilon) &&
                     vector.z.IsZero(epsilon) &&
                     vector.w.IsZero(epsilon));
        }

        public static bool IsZero(this Vector4 vector)
        {
            return vector.x.IsZero() &&
                   vector.y.IsZero() &&
                   vector.z.IsZero() &&
                   vector.w.IsZero();
        }

        public static bool IsZero(this Vector4 vector, float epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon) &&
                   vector.z.IsZero(epsilon) &&
                   vector.w.IsZero(epsilon);
        }

        public static void Round(this ref Vector4 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            vector.w = Mathf.Round(vector.w);
        }

        public static Vector4 Rounded(this Vector4 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            vector.w = Mathf.Round(vector.w);
            return vector;
        }

        public static void ScaleBy(this ref Vector4 vector, Vector4 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
            vector.z *= scalar.z;
            vector.w *= scalar.w;
        }

        public static Vector4 ScaledBy(this Vector4 vector, Vector4 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
            vector.z *= scalar.z;
            vector.w *= scalar.w;
            return vector;
        }

        public static void SetUniform(this ref Vector4 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            vector.w = value;
        }

        public static Vector4 SetUniformly(this Vector4 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            vector.w = value;
            return vector;
        }

        public static void Wrap(this ref Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Math.Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Math.Processors.Wrap(vector.z, min.z, max.z);
            vector.w = Math.Processors.Wrap(vector.w, min.w, max.w);
        }

        public static Vector4 Wrapped(this Vector4 vector, Vector4 min, Vector4 max)
        {
            vector.x = Math.Processors.Wrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.Wrap(vector.y, min.y, max.y);
            vector.z = Math.Processors.Wrap(vector.z, min.z, max.z);
            vector.w = Math.Processors.Wrap(vector.w, min.w, max.w);
            return vector;
        }

    }

}
