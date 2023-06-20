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
            Bounds bounds = new Bounds();

            foreach (Transform child in transform) {
                bounds.Encapsulate(child.position);
            }

            return bounds.center;
        }

        /// <summary>
        /// Resets the position, rotation, and scale of the transform.
        /// </summary>
        /// <param name="transform">The transform to reset.</param>
        public static void Reset(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Resets the local position, rotation, and scale of the transform.
        /// </summary>
        /// <param name="transform">The transform to reset.</param>
        public static void ResetLocal(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Sets the position of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="x">The x-axis position to set.</param>
        public static void SetPositionX(this Transform transform, float x) =>
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

        /// <summary>
        /// Sets the position of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="y">The y-axis position to set.</param>
        public static void SetPositionY(this Transform transform, float y) =>
            transform.position = new Vector3(transform.position.x, y, transform.position.z);

        /// <summary>
        /// Sets the position of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the position of.</param>
        /// <param name="z">The z-axis position to set.</param>
        public static void SetPositionZ(this Transform transform, float z) =>
            transform.position = new Vector3(transform.position.x, transform.position.y, z);

        /// <summary>
        /// Sets the local position of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="x">The x-axis position to set.</param>
        public static void SetLocalPositionX(this Transform transform, float x) =>
            transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);

        /// <summary>
        /// Sets the local position of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="y">The y-axis position to set.</param>
        public static void SetLocalPositionY(this Transform transform, float y) =>
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);

        /// <summary>
        /// Sets the local position of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local position of.</param>
        /// <param name="z">The z-axis position to set.</param>
        public static void SetLocalPositionZ(this Transform transform, float z) =>
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);

        /// <summary>
        /// Sets the euler angles of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="x">The x-axis euler angle to set.</param>
        public static void SetEulerX(this Transform transform, float x) =>
            transform.eulerAngles = new Vector3(x, transform.eulerAngles.y, transform.eulerAngles.z);

        /// <summary>
        /// Sets the euler angles of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="y">The y-axis euler angle to set.</param>
        public static void SetEulerY(this Transform transform, float y) =>
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, y, transform.eulerAngles.z);

        /// <summary>
        /// Sets the euler angles of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the euler angles of.</param>
        /// <param name="z">The z-axis euler angle to set.</param>
        public static void SetEulerZ(this Transform transform, float z) =>
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, z);

        /// <summary>
        /// Sets the local euler angles of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="x">The x-axis euler angle to set.</param>
        public static void SetLocalEulerX(this Transform transform, float x) =>
            transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, transform.localEulerAngles.z);

        /// <summary>
        /// Sets the local euler angles of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="y">The y-axis euler angle to set.</param>
        public static void SetLocalEulerY(this Transform transform, float y) =>
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, y, transform.localEulerAngles.z);

        /// <summary>
        /// Sets the local euler angles of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the local euler angles of.</param>
        /// <param name="z">The z-axis euler angle to set.</param>
        public static void SetLocalEulerZ(this Transform transform, float z) =>
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, z);

        /// <summary>
        /// Sets the scale of the transform in the x-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="x">The x-axis scale to set.</param>
        public static void SetScaleX(this Transform transform, float x) =>
            transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);

        /// <summary>
        /// Sets the scale of the transform in the y-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="y">The y-axis scale to set.</param>
        public static void SetScaleY(this Transform transform, float y) =>
            transform.localScale = new Vector3(transform.localScale.x, y, transform.localScale.z);

        /// <summary>
        /// Sets the scale of the transform in the z-axis.
        /// </summary>
        /// <param name="transform">The transform to set the scale of.</param>
        /// <param name="z">The z-axis scale to set.</param>
        public static void SetScaleZ(this Transform transform, float z) =>
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, z);

    }

}
