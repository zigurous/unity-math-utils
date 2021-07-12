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

        /// <summary>
        /// Returns a random point inside the bounds.
        /// </summary>
        /// <param name="bounds">The bounds to get a random point from.</param>
        public static Vector3Int RandomPointInside(this BoundsInt bounds)
        {
            return new Vector3Int(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z));
        }

    }

}
