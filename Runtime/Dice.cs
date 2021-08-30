namespace Zigurous.Math
{
    /// <summary>
    /// Functions for rolling dice.
    /// </summary>
    public static class Dice
    {
        /// <summary>
        /// Rolls a 4-sided dice [1..4].
        /// </summary>
        /// <returns>A random number on a 4-sided dice [1..4].</returns>
        public static int D4()
        {
            return UnityEngine.Random.Range(1, 5);
        }

        /// <summary>
        /// Rolls a 4-sided dice [1..4] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D4(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D4();
            return roll;
        }

        /// <summary>
        /// Rolls a 6-sided dice [1..6].
        /// </summary>
        /// <returns>A random number on a 6-sided dice [1..6].</returns>
        public static int D6()
        {
            return UnityEngine.Random.Range(1, 7);
        }

        /// <summary>
        /// Rolls a 6-sided dice [1..6] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D6(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D6();
            return roll;
        }

        /// <summary>
        /// Rolls an 8-sided dice [1..8].
        /// </summary>
        /// <returns>A random number on an 8-sided dice [1..8].</returns>
        public static int D8()
        {
            return UnityEngine.Random.Range(1, 9);
        }

        /// <summary>
        /// Rolls an 8-sided dice [1..8] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D8(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D8();
            return roll;
        }

        /// <summary>
        /// Rolls a 10-sided dice [1..10].
        /// </summary>
        /// <returns>A random number on a 10-sided dice [1..10].</returns>
        public static int D10()
        {
            return UnityEngine.Random.Range(1, 11);
        }

        /// <summary>
        /// Rolls a 10-sided dice [1..10] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D10(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D10();
            return roll;
        }

        /// <summary>
        /// Rolls a 12-sided dice [1..12].
        /// </summary>
        /// <returns>A random number on a 12-sided dice [1..12].</returns>
        public static int D12()
        {
            return UnityEngine.Random.Range(1, 13);
        }

        /// <summary>
        /// Rolls a 12-sided dice [1..12] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D12(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D12();
            return roll;
        }

        /// <summary>
        /// Rolls a 20-sided dice [1..20].
        /// </summary>
        /// <returns>A random number on a 20-sided dice [1..20].</returns>
        public static int D20()
        {
            return UnityEngine.Random.Range(1, 21);
        }

        /// <summary>
        /// Rolls a 20-sided dice [1..20] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D20(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D20();
            return roll;
        }

        /// <summary>
        /// Rolls a 48-sided dice [1..48].
        /// </summary>
        /// <returns>A random number on a 48-sided dice [1..48].</returns>
        public static int D48()
        {
            return UnityEngine.Random.Range(1, 49);
        }

        /// <summary>
        /// Rolls a 48-sided dice [1..48] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D48(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D48();
            return roll;
        }

        /// <summary>
        /// Rolls a 100-sided dice [1..100].
        /// </summary>
        /// <returns>A random number on a 100-sided dice [1..100].</returns>
        public static int D100()
        {
            return UnityEngine.Random.Range(1, 101);
        }

        /// <summary>
        /// Rolls a 100-sided dice [1..100] <paramref name="n"/> times.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int D100(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D100();
            return roll;
        }

        /// <summary>
        /// Rolls an n-sided dice [1..<paramref name="n"/>].
        /// </summary>
        /// <param name="n">The number of sides on the dice.</param>
        /// <returns>A random number on an n-sided dice [1..<paramref name="n"/>].</returns>
        public static int NSided(int n)
        {
            return UnityEngine.Random.Range(1, n + 1);
        }

        /// <summary>
        /// Rolls an n-sided dice [1..<paramref name="n"/>] <paramref name="x"/> amount of times.
        /// </summary>
        /// <param name="n">The number of sides on the dice.</param>
        /// <param name="x">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int NSided(int n, int x)
        {
            int roll = 0;
            while (x-- > 0) roll += NSided(n);
            return roll;
        }

        /// <summary>
        /// Rolls a custom dice.
        /// </summary>
        /// <param name="dice">The numbered sides of the dice.</param>
        /// <returns>A random number on the dice.</returns>
        public static int Roll(int[] dice)
        {
            return dice[UnityEngine.Random.Range(0, dice.Length)];
        }

        /// <summary>
        /// Rolls a custom dice <paramref name="n"/> amount of times.
        /// </summary>
        /// <param name="dice">The numbered sides of the dice.</param>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the rolls.</returns>
        public static int Roll(int[] dice, int n)
        {
            int roll = 0;
            while (n-- > 0) roll += Roll(dice);
            return roll;
        }

        /// <summary>
        /// Rolls a custom dice.
        /// </summary>
        /// <typeparam name="T">The type of values of the dice.</typeparam>
        /// <param name="dice">The values of the dice.</param>
        /// <returns>A random value on the dice.</returns>
        public static T Roll<T>(T[] dice)
        {
            return dice[UnityEngine.Random.Range(0, dice.Length)];
        }

        /// <summary>
        /// Rolls a custom dice with weighted probabilities.
        /// </summary>
        /// <typeparam name="T">The type of values of the dice.</typeparam>
        /// <param name="dice">The values of the dice.</param>
        /// <param name="weights">The probabilities of each value.</param>
        /// <returns>A random value on the dice.</returns>
        public static T Roll<T>(T[] dice, int[] weights)
        {
            int weightedTotal = 0;

            for (int i = 0; i < weights.Length; i++) {
                weightedTotal += weights[i];
            }

            float roll = UnityEngine.Random.value;
            float min = 0f;

            for (int i = 0; i < weights.Length; i++)
            {
                float weight = (float)weights[i] / weightedTotal;
                float max = min + weight;

                if (i == weights.Length - 1)
                {
                    if (roll >= min && roll <= max) {
                        return dice[i];
                    }
                }
                else
                {
                    if (roll >= min && roll < max) {
                        return dice[i];
                    }
                }

                min = max;
            }

            return default(T);
        }

    }

}
