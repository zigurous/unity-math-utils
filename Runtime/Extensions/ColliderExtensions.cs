using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Extension methods for colliders.
    /// </summary>
    public static class ColliderExtensions
    {
        /// <summary>
        /// Returns a random point inside the collider's bounds.
        /// </summary>
        /// <param name="collider">The collider to get a random point from.</param>
        /// <returns>A random point inside the collider's bounds.</returns>
        public static Vector3 RandomPointInside(this Collider collider)
        {
            Vector3 randomPoint = collider.bounds.RandomPointInside();
            Vector3 closetPoint = collider.ClosestPoint(randomPoint);

            if (closetPoint == randomPoint) { // inside
                return randomPoint;
            } else { // outside
                return Vector3.Lerp(closetPoint, collider.bounds.center, Random.value);
            }
        }

        /// <summary>
        /// Returns a random point inside the collider's bounds.
        /// </summary>
        /// <param name="collider">The collider to get a random point from.</param>
        /// <returns>A random point inside the collider's bounds.</returns>
        public static Vector2 RandomPointInside(this Collider2D collider)
        {
            Vector2 randomPoint = collider.bounds.RandomPointInside();
            Vector2 closetPoint = collider.ClosestPoint(randomPoint);

            if (closetPoint == randomPoint) { // inside
                return randomPoint;
            } else { // outside
                return Vector2.Lerp(closetPoint, collider.bounds.center, Random.value);
            }
        }

    }

}
