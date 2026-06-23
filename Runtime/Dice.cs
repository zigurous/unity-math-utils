using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Functions for rolling dice.
    /// </summary>
    public static class Dice
    {
        /// <summary>
        /// A function that rolls dice to produce an integer result.
        /// </summary>
        /// <returns>The result of the dice roll.</returns>
        public delegate int DiceRollFunction();

        /// <summary>
        /// Rolls dice to produce an integer result.
        /// </summary>
        /// <param name="dice">The dice roll function to use.</param>
        /// <param name="flags">The optional flags to use when rolling the dice, such as advantage or disadvantage.</param>
        /// <returns>The result of the dice roll.</returns>
        public static int Roll(DiceRollFunction dice, DiceRollFlag flags = DiceRollFlag.None)
        {
            bool advantage = flags.Has(DiceRollFlag.Advantage);
            bool disadvantage = flags.Has(DiceRollFlag.Disadvantage);

            if (advantage && disadvantage) {
                return dice(); // advantage and disadvantage cancel out
            } else if (advantage) {
                return Mathf.Max(dice(), dice());
            } else if (disadvantage) {
                return Mathf.Min(dice(), dice());
            } else {
                return dice();
            }
        }

        /// <summary>
        /// Rolls dice <paramref name="n"/> times and returns the sum of the rolls.
        /// </summary>
        /// <param name="dice">The dice roll function to use.</param>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
        public static int Roll(DiceRollFunction dice, int n)
        {
            int roll = 0;
            while (n-- > 0) roll += dice();
            return roll;
        }

        /// <summary>
        /// Rolls a 4-sided dice [1..4].
        /// </summary>
        /// <returns>A random number on a 4-sided dice [1..4].</returns>
        public static int D4()
        {
            return Random.Range(1, 5);
        }

        /// <summary>
        /// Rolls a 4-sided dice [1..4] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, 7);
        }

        /// <summary>
        /// Rolls a 6-sided dice [1..6] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, 9);
        }

        /// <summary>
        /// Rolls an 8-sided dice [1..8] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, 11);
        }

        /// <summary>
        /// Rolls a 10-sided dice [1..10] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, 13);
        }

        /// <summary>
        /// Rolls a 12-sided dice [1..12] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, 21);
        }

        /// <summary>
        /// Rolls a 20-sided dice [1..20] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
        public static int D20(int n)
        {
            int roll = 0;
            while (n-- > 0) roll += D20();
            return roll;
        }

        /// <summary>
        /// Rolls a 100-sided dice [1..100].
        /// </summary>
        /// <returns>A random number on a 100-sided dice [1..100].</returns>
        public static int D100()
        {
            return Random.Range(1, 101);
        }

        /// <summary>
        /// Rolls a 100-sided dice [1..100] <paramref name="n"/> times and
        /// returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return Random.Range(1, n + 1);
        }

        /// <summary>
        /// Rolls an n-sided dice [1..<paramref name="n"/>] <paramref name="x"/>
        /// times and returns the sum of the rolls.
        /// </summary>
        /// <param name="n">The number of sides on the dice.</param>
        /// <param name="x">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return dice[Random.Range(0, dice.Length)];
        }

        /// <summary>
        /// Rolls a custom dice <paramref name="n"/> times and returns the sum
        /// of the rolls.
        /// </summary>
        /// <param name="dice">The numbered sides of the dice.</param>
        /// <param name="n">The number of times to roll the dice.</param>
        /// <returns>The sum of the dice rolls.</returns>
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
            return dice[Random.Range(0, dice.Length)];
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
            int len = weights.Length;
            int weightedTotal = 0;

            for (int i = 0; i < len; i++) {
                weightedTotal += weights[i];
            }

            int roll = Random.Range(0, weightedTotal);
            int min = 0;

            for (int i = 0; i < len; i++)
            {
                int weight = weights[i];
                if (weight <= 0) continue;

                int max = min + weight;
                if (roll >= min && roll < max) {
                    return dice[i];
                } else {
                    min = max;
                }
            }

            return default;
        }

    }

    /// <summary>
    /// A special flag that changes how the dice are rolled.
    /// </summary>
    [System.Flags]
    public enum DiceRollFlag
    {
        /// <summary>
        /// No special flags.
        /// </summary>
        [Tooltip("No special flags.")]
        None = 0,

        /// <summary>
        /// Rolls the dice twice and takes the higher result.
        /// </summary>
        [Tooltip("Rolls the dice twice and takes the higher result.")]
        Advantage = 1 << 0,

        /// <summary>
        /// Rolls the dice twice and takes the lower result.
        /// </summary>
        [Tooltip("Rolls the dice twice and takes the lower result.")]
        Disadvantage = 1 << 1,
    }

    /// <summary>
    /// Extension methods for <see cref="DiceRollFlag"/>.
    /// </summary>
    public static class DiceRollFlagExtensions
    {
        /// <summary>
        /// Checks if the flags has a specified flag.
        /// </summary>
        /// <param name="flags">The flags to check.</param>
        /// <param name="flag">The other flag to check for.</param>
        /// <returns>True if the flags has the specified flag, false otherwise.</returns>
        public static bool Has(this DiceRollFlag flags, DiceRollFlag flag)
        {
            return ((int)flags & (int)flag) == (int)flag;
        }

    }

}
