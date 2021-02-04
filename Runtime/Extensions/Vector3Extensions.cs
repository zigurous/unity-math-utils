using UnityEngine;

namespace Zigurous
{
    public static class Vector3Extensions
    {
        public static Vector3 Abs(this Vector3 vector)
        {
            vector.x = System.Math.Abs(vector.x);
            vector.y = System.Math.Abs(vector.y);
            vector.z = System.Math.Abs(vector.z);
            return vector;
        }

        public static Vector3 Average(this Vector3[] vectors)
        {
            Vector3 average = Vector3.zero;

            if (vectors.Length > 0)
            {
                for (int i = 0; i < vectors.Length; i++) {
                    average += vectors[i];
                }

                average /= vectors.Length;
            }

            return average;
        }

        public static void Ceil(this ref Vector3 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
        }

        public static Vector3 Ceiled(this Vector3 vector)
        {
            vector.x = Mathf.Ceil(vector.x);
            vector.y = Mathf.Ceil(vector.y);
            vector.z = Mathf.Ceil(vector.z);
            return vector;
        }

        public static void Clamp(this ref Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Math.Processors.Clamp(vector.z, min.z, max.z);
        }

        public static void ClampWrap(this ref Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Math.Processors.ClampWrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.ClampWrap(vector.y, min.y, max.y);
            vector.z = Math.Processors.ClampWrap(vector.z, min.z, max.z);
        }

        public static Vector3 Clamped(this Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Math.Processors.Clamp(vector.x, min.x, max.x);
            vector.y = Math.Processors.Clamp(vector.y, min.y, max.y);
            vector.z = Math.Processors.Clamp(vector.z, min.z, max.z);
            return vector;
        }

        public static Vector3 ClampedWrap(this Vector3 vector, Vector3 min, Vector3 max)
        {
            vector.x = Math.Processors.ClampWrap(vector.x, min.x, max.x);
            vector.y = Math.Processors.ClampWrap(vector.y, min.y, max.y);
            vector.z = Math.Processors.ClampWrap(vector.z, min.z, max.z);
            return vector;
        }

        public static void Floor(this ref Vector3 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
        }

        public static Vector3 Floored(this Vector3 vector)
        {
            vector.x = Mathf.Floor(vector.x);
            vector.y = Mathf.Floor(vector.y);
            vector.z = Mathf.Floor(vector.z);
            return vector;
        }

        public static bool IsEqualTo(this Vector3 lhs, Vector3 rhs)
        {
            return lhs.x.IsEqualTo(rhs.x) &&
                   lhs.y.IsEqualTo(rhs.y) &&
                   lhs.z.IsEqualTo(rhs.z);
        }

        public static bool IsEqualTo(this Vector3 lhs, Vector3 rhs, float epsilon)
        {
            return lhs.x.IsEqualTo(rhs.x, epsilon) &&
                   lhs.y.IsEqualTo(rhs.y, epsilon) &&
                   lhs.z.IsEqualTo(rhs.z, epsilon);
        }

        public static bool IsNotEqualTo(this Vector3 lhs, Vector3 rhs)
        {
            return !(lhs.x.IsEqualTo(rhs.x) &&
                     lhs.y.IsEqualTo(rhs.y) &&
                     lhs.z.IsEqualTo(rhs.z));
        }

        public static bool IsNotEqualTo(this Vector3 lhs, Vector3 rhs, float epsilon)
        {
            return !(lhs.x.IsEqualTo(rhs.x, epsilon) &&
                     lhs.y.IsEqualTo(rhs.y, epsilon) &&
                     lhs.z.IsEqualTo(rhs.z, epsilon));
        }

        public static bool IsNotZero(this Vector3 vector)
        {
            return !(vector.x.IsZero() &&
                     vector.y.IsZero() &&
                     vector.z.IsZero());
        }

        public static bool IsNotZero(this Vector3 vector, float epsilon)
        {
            return !(vector.x.IsZero(epsilon) &&
                     vector.y.IsZero(epsilon) &&
                     vector.z.IsZero(epsilon));
        }

        public static bool IsZero(this Vector3 vector)
        {
            return vector.x.IsZero() &&
                   vector.y.IsZero() &&
                   vector.z.IsZero();
        }

        public static bool IsZero(this Vector3 vector, float epsilon)
        {
            return vector.x.IsZero(epsilon) &&
                   vector.y.IsZero(epsilon) &&
                   vector.z.IsZero(epsilon);
        }

        public static void Round(this ref Vector3 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
        }

        public static Vector3 Rounded(this Vector3 vector)
        {
            vector.x = Mathf.Round(vector.x);
            vector.y = Mathf.Round(vector.y);
            vector.z = Mathf.Round(vector.z);
            return vector;
        }

        public static void ScaleBy(this ref Vector3 vector, Vector3 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
            vector.z *= scalar.z;
        }

        public static Vector3 ScaledBy(this Vector3 vector, Vector3 scalar)
        {
            vector.x *= scalar.x;
            vector.y *= scalar.y;
            vector.z *= scalar.z;
            return vector;
        }

        public static void SetUniform(this ref Vector3 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
        }

        public static Vector3 SetUniformly(this Vector3 vector, float value)
        {
            vector.x = value;
            vector.y = value;
            vector.z = value;
            return vector;
        }

    }

}
