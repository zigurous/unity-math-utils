namespace Zigurous.Math
{
    /// <summary>
    /// Functions for rolling dice.
    /// </summary>
    public static class Dice
    {
        /// <summary>
        /// Returns a random number on a 4-sided dice [1..4].
        /// </summary>
        public static int D4()
        {
            return UnityEngine.Random.Range(1, 5);
        }

        /// <summary>
        /// Returns the sum of rolling a 4-sided dice [1..4]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D4(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D4();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 6-sided dice [1..6].
        /// </summary>
        public static int D6()
        {
            return UnityEngine.Random.Range(1, 7);
        }

        /// <summary>
        /// Returns the sum of rolling a 6-sided dice [1..6]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D6(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D6();
            return roll;
        }

        /// <summary>
        /// Returns a random number on an 8-sided dice [1..8].
        /// </summary>
        public static int D8()
        {
            return UnityEngine.Random.Range(1, 9);
        }

        /// <summary>
        /// Returns the sum of rolling an 8-sided dice [1..8]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D8(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D8();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 10-sided dice [1..10].
        /// </summary>
        public static int D10()
        {
            return UnityEngine.Random.Range(1, 11);
        }

        /// <summary>
        /// Returns the sum of rolling a 10-sided dice [1..10]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D10(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D10();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 12-sided dice [1..12].
        /// </summary>
        public static int D12()
        {
            return UnityEngine.Random.Range(1, 13);
        }

        /// <summary>
        /// Returns the sum of rolling a 12-sided dice [1..12]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D12(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D12();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 20-sided dice [1..20].
        /// </summary>
        public static int D20()
        {
            return UnityEngine.Random.Range(1, 21);
        }

        /// <summary>
        /// Returns the sum of rolling a 20-sided dice [1..20]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D20(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D20();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 48-sided dice [1..48].
        /// </summary>
        public static int D48()
        {
            return UnityEngine.Random.Range(1, 49);
        }

        /// <summary>
        /// Returns the sum of rolling a 48-sided dice [1..48]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D48(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D48();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 100-sided dice [1..100].
        /// </summary>
        public static int D100()
        {
            return UnityEngine.Random.Range(1, 101);
        }

        /// <summary>
        /// Returns the sum of rolling a 100-sided dice [1..100]
        /// <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int D100(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D100();
            return roll;
        }

        /// <summary>
        /// Returns a random number on an n-sided dice [1..<paramref name="n"/>].
        /// </summary>
        /// <param name="n">The number of sides on the dice.</param>
        public static int NSided(int n)
        {
            return UnityEngine.Random.Range(1, n + 1);
        }

        /// <summary>
        /// Returns the sum of rolling an n-sided dice [1..<paramref name="n"/>]
        /// <paramref name="x"/> amount of times.
        /// </summary>
        /// <param name="n">The number of sides on the dice.</param>
        /// <param name="x">The number of times to roll the dice.</param>
        public static int NSided(int n, int x)
        {
            int roll = 0;
            while (x-- > 0) roll += NSided(n);
            return roll;
        }

        /// <summary>
        /// Returns a random value on a dice with custom values.
        /// </summary>
        /// <param name="values">The values of the dice.</param>
        public static int Roll(int[] values)
        {
            return values[UnityEngine.Random.Range(0, values.Length)];
        }

        /// <summary>
        /// Returns the sum of rolling a dice with custom values
        /// <paramref name="n"/> amount of times.
        /// </summary>
        /// <param name="values">The values of the dice.</param>
        /// <param name="n">The number of times to roll the dice.</param>
        public static int Roll(int[] values, int n)
        {
            int roll = 0;
            while (n-- > 0) roll += Roll(values);
            return roll;
        }

        /// <summary>
        /// Returns a random value on a dice with custom values.
        /// </summary>
        /// <typeparam name="T">The type of value to choose.</typeparam>
        /// <param name="values">The values of the dice.</param>
        public static T Roll<T>(T[] values)
        {
            return values[UnityEngine.Random.Range(0, values.Length)];
        }

        /// <summary>
        /// Returns a random value from an array of <paramref name="values"/>
        /// with probability proportional to the given set of
        /// <paramref name="probabilities"/>.
        /// </summary>
        /// <typeparam name="T">The type of value to choose.</typeparam>
        /// <param name="values">The values to choose from.</param>
        /// <param name="probabilities">The probabilities of each value.</param>
        public static T Roll<T>(T[] values, int[] probabilities)
        {
            // OPTIMIZE: Prevent allocation of a new array each time.
            T[] extendedRange = new T[probabilities.Sum()];

            int length = System.Math.Min(values.Length, probabilities.Length);
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                T value = values[i];
                int frequency = probabilities[i];

                while (--frequency > 0) {
                    extendedRange[count++] = value;
                }
            }

            return extendedRange[UnityEngine.Random.Range(0, extendedRange.Length)];
        }

    }

}
