using UnityEngine;

namespace Zigurous.Math
{
    public static class ColliderExtensions
    {
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

        public static Vector3 RandomPointInside(this Collider2D collider)
        {
            Vector3 randomPoint = collider.bounds.RandomPointInside();
            Vector3 closetPoint = collider.ClosestPoint(randomPoint);

            if (closetPoint == randomPoint) { // inside
                return randomPoint;
            } else { // outside
                return Vector3.Lerp(closetPoint, collider.bounds.center, Random.value);
            }
        }

    }

}
