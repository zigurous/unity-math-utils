namespace Zigurous
{
    public static class ArrayExtensions
    {
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
