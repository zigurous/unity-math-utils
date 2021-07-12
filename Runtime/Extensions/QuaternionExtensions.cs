using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for quaternions.
    /// </summary>
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Gradually changes a quaternion towards a desired goal over time.
        /// The quaternion is smoothed by some spring-damper like function,
        /// which will never overshoot.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <param name="maxSpeed">	Optionally allows you to clamp the maximum speed.</param>
        /// <returns>The smoothed quaternion.</returns>
        public static Quaternion SmoothDamp(this Quaternion current, Quaternion target, ref Quaternion currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity)
        {
            float dot = Quaternion.Dot(current, target);
            float direction = dot > 0.0f ? 1.0f : -1.0f;
            target.x *= direction;
            target.y *= direction;
            target.z *= direction;
            target.w *= direction;

            Vector4 result = new Vector4(
                x: Mathf.SmoothDamp(current.x, target.x, ref currentVelocity.x, smoothTime, maxSpeed),
                y: Mathf.SmoothDamp(current.y, target.y, ref currentVelocity.y, smoothTime, maxSpeed),
                z: Mathf.SmoothDamp(current.z, target.z, ref currentVelocity.z, smoothTime, maxSpeed),
                w: Mathf.SmoothDamp(current.w, target.w, ref currentVelocity.w, smoothTime, maxSpeed)).normalized;

            Vector4 error = Vector4.Project(new Vector4(currentVelocity.x, currentVelocity.y, currentVelocity.z, currentVelocity.w), result);
            currentVelocity.x -= error.x;
            currentVelocity.y -= error.y;
            currentVelocity.z -= error.z;
            currentVelocity.w -= error.w;

            return new Quaternion(result.x, result.y, result.z, result.w);
        }

    }

}
