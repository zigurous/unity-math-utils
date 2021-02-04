using UnityEngine;

namespace Zigurous
{
    public static class QuaternionExtensions
    {
        public static Quaternion SmoothDamp(this Quaternion current, Quaternion target, ref Quaternion currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity)
        {
            float dot = Quaternion.Dot(current, target);
            float multiple = dot > 0.0f ? 1.0f : -1.0f;
            target.x *= multiple;
            target.y *= multiple;
            target.z *= multiple;
            target.w *= multiple;

            Vector4 result = new Vector4(
                x: Mathf.SmoothDamp(current.x, target.x, ref currentVelocity.x, smoothTime, maxSpeed),
                y: Mathf.SmoothDamp(current.y, target.y, ref currentVelocity.y, smoothTime, maxSpeed),
                z: Mathf.SmoothDamp(current.z, target.z, ref currentVelocity.z, smoothTime, maxSpeed),
                w: Mathf.SmoothDamp(current.w, target.w, ref currentVelocity.w, smoothTime, maxSpeed)).normalized;

            float inverseDeltaTime = 1.0f / Time.deltaTime;
            currentVelocity.x = (result.x - current.x) * inverseDeltaTime;
            currentVelocity.y = (result.y - current.y) * inverseDeltaTime;
            currentVelocity.z = (result.z - current.z) * inverseDeltaTime;
            currentVelocity.w = (result.w - current.w) * inverseDeltaTime;

            return new Quaternion(result.x, result.y, result.z, result.w);
        }

    }

}
