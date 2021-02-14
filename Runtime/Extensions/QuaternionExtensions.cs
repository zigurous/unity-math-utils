using UnityEngine;

namespace Zigurous.Math
{
    public static class QuaternionExtensions
    {
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
