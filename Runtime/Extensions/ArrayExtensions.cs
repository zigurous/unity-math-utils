namespace Zigurous.Math
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Shuffles the array in place.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <param name="array">The array to shuffle.</param>
        /// <typeparam name="T">The type of the array.</typeparam>
        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;

            while (n > 1)
            {
                int k = UnityEngine.Random.Range(0, n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        /// <summary>
        /// Shuffles the array in place using the given random number generator.
        /// </summary>
        /// <remarks>The shuffle is done using the Fisher-Yates algorithm.</remarks>
        /// <param name="array">The array to shuffle.</param>
        /// <param name="rng">The random number generator to use.</param>
        /// <typeparam name="T">The type of the array.</typeparam>
        public static void Shuffle<T>(this T[] array, Random rng)
        {
            int n = array.Length;

            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public static int Sum(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

        public static float Sum(this float[] array)
        {
            float sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

        public static double Sum(this double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }

            return sum;
        }

    }

}
