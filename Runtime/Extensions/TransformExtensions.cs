using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for Transform components.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Calculates the average position of the transform's children.
        /// </summary>
        /// <param name="transform">The transform to calculate the average position of.</param>
        /// <returns>The average position of the transform's children.</returns>
        public static Vector3 AveragePositionOfChildren(this Transform transform)
        {
            Vector3 center = Vector3.zero;

            foreach (Transform child in transform) {
                center += child.position;
            }

            return center / transform.childCount;
        }

        /// <summary>
        /// Calculates the center position of the transform's children.
        /// </summary>
        /// <param name="transform">The transform to calculate the center position of.</param>
        /// <returns>The center position of the transform's children.</returns>
        public static Vector3 CenterPositionOfChildren(this Transform transform)
        {
            Bounds bounds = new();

            foreach (Transform child in transform) {
                bounds.Encapsulate(child.position);
            }

            return bounds.center;
        }

        /// <summary>
        /// Transforms a point from local space to world space without scaling.
        /// </summary>
        /// <param name="transform">The transform to use for the transformation.</param>
        /// <param name="position">The local position to transform.</param>
        /// <returns>The transformed world position.</returns>
        public static Vector3 TransformPointUnscaled(this Transform transform, Vector3 position)
        {
            var localToWorldMatrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
            return localToWorldMatrix.MultiplyPoint3x4(position);
        }

        /// <summary>
        /// Transforms a point from world space to local space without scaling.
        /// </summary>
        /// <param name="transform">The transform to use for the transformation.</param>
        /// <param name="position">The world position to transform.</param>
        /// <returns>The transformed local position.</returns>
        public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
        {
            var worldToLocalMatrix = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one).inverse;
            return worldToLocalMatrix.MultiplyPoint3x4(position);
        }

        /// <summary>
        /// Resets the position, rotation, and scale of the transform.
        /// </summary>
        /// <param name="transform">The transform to reset.</param>
        public static void Reset(this Transform transform)
        {
            transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Resets the local position, rotation, and scale of the transform.
        /// </summary>
        /// <param name="transform">The transform to reset.</param>
        public static void ResetLocal(this Transform transform)
        {
            transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Sets the position of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="x">The x-axis position to set.</param>
        public static void SetPositionX(this Transform transform, float x)
        {
            Vector3 position = transform.position;
            position.x = x;
            transform.position = position;
        }

        /// <summary>
        /// Sets the position of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="y">The y-axis position to set.</param>
        public static void SetPositionY(this Transform transform, float y)
        {
            Vector3 position = transform.position;
            position.y = y;
            transform.position = position;
        }

        /// <summary>
        /// Sets the position of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="z">The z-axis position to set.</param>
        public static void SetPositionZ(this Transform transform, float z)
        {
            Vector3 position = transform.position;
            position.z = z;
            transform.position = position;
        }

        /// <summary>
        /// Sets the local position of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="x">The x-axis position to set.</param>
        public static void SetLocalPositionX(this Transform transform, float x)
        {
            Vector3 position = transform.localPosition;
            position.x = x;
            transform.localPosition = position;
        }

        /// <summary>
        /// Sets the local position of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="y">The y-axis position to set.</param>
        public static void SetLocalPositionY(this Transform transform, float y)
        {
            Vector3 position = transform.localPosition;
            position.y = y;
            transform.localPosition = position;
        }

        /// <summary>
        /// Sets the local position of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="z">The z-axis position to set.</param>
        public static void SetLocalPositionZ(this Transform transform, float z)
        {
            Vector3 position = transform.localPosition;
            position.z = z;
            transform.localPosition = position;
        }

        /// <summary>
        /// Sets the euler angles of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="x">The x-axis euler angle to set.</param>
        public static void SetEulerAnglesX(this Transform transform, float x)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.x = x;
            transform.eulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the euler angles of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="y">The y-axis euler angle to set.</param>
        public static void SetEulerAnglesY(this Transform transform, float y)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.y = y;
            transform.eulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the euler angles of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="z">The z-axis euler angle to set.</param>
        public static void SetEulerAnglesZ(this Transform transform, float z)
        {
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.z = z;
            transform.eulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the local euler angles of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="x">The x-axis euler angle to set.</param>
        public static void SetLocalEulerAnglesX(this Transform transform, float x)
        {
            Vector3 eulerAngles = transform.localEulerAngles;
            eulerAngles.x = x;
            transform.localEulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the local euler angles of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="y">The y-axis euler angle to set.</param>
        public static void SetLocalEulerAnglesY(this Transform transform, float y)
        {
            Vector3 eulerAngles = transform.localEulerAngles;
            eulerAngles.y = y;
            transform.localEulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the local euler angles of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="z">The z-axis euler angle to set.</param>
        public static void SetLocalEulerAnglesZ(this Transform transform, float z)
        {
            Vector3 eulerAngles = transform.localEulerAngles;
            eulerAngles.z = z;
            transform.localEulerAngles = eulerAngles;
        }

        /// <summary>
        /// Sets the scale of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="x">The x-axis scale to set.</param>
        public static void SetLocalScaleX(this Transform transform, float x)
        {
            Vector3 scale = transform.localScale;
            scale.x = x;
            transform.localEulerAngles = scale;
        }

        /// <summary>
        /// Sets the scale of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="y">The y-axis scale to set.</param>
        public static void SetLocalScaleY(this Transform transform, float y)
        {
            Vector3 scale = transform.localScale;
            scale.y = y;
            transform.localEulerAngles = scale;
        }

        /// <summary>
        /// Sets the scale of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="z">The z-axis scale to set.</param>
        public static void SetLocalScaleZ(this Transform transform, float z)
        {
            Vector3 scale = transform.localScale;
            scale.z = z;
            transform.localEulerAngles = scale;
        }

    }

}
