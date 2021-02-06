namespace Zigurous.Math
{
    public static class ComparableExtensions
    {
        public static bool IsBetween<T>(this T value, T min, T max, bool includeMin, bool includeMax) where T: IComparable<T>
        {
            int minCompare = value.CompareTo(min);
            int maxCompare = value.CompareTo(max);

            if (minCompare < 0 || maxCompare > 0) return false;
            if (!includeMin && minCompare == 0) return false;
            if (!includeMax && maxCompare == 0) return false;

            return true;
        }

        public static T Max<T>(this T[] array) where T: IComparable<T>
        {
            T max = default(T);

            for (int i = 0; i < array.Length; i++)
            {
                T element = array[i];

                if (element.CompareTo(max) > 0) {
                    max = element;
                }
            }

            return max;
        }

        public static T Min<T>(this T[] array) where T: IComparable<T>
        {
            T min = default(T);

            for (int i = 0; i < array.Length; i++)
            {
                T element = array[i];

                if (element.CompareTo(min) < 0) {
                    min = element;
                }
            }

            return min;
        }

    }

}
