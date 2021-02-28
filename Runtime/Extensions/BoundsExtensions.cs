using UnityEngine;

namespace Zigurous.Math
{
    public static class BoundsExtensions
    {
        public static Vector3 RandomPointInside(this Bounds bounds)
        {
            return new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z));
        }

    }

}
