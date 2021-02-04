namespace Zigurous.Math
{
    public static class Chance
    {
        public enum Coin { Heads, Tails }

        public enum GamblingColor { Red, Black, White, Green }

        public enum PlayingCardSuit { Hearts, Diamonds, Spades, Clubs }

        public enum PlayingCard
        {
            HeartsA, HeartsK, HeartsQ, HeartsJ, Hearts10, Hearts9, Hearts8,
            Hearts7, Hearts6, Hearts5, Hearts4, Hearts3, Hearts2,
            DiamondsA, DiamondsK, DiamondsQ, DiamondsJ, Diamonds10, Diamonds9, Diamonds8,
            Diamonds7, Diamonds6, Diamonds5, Diamonds4, Diamonds3, Diamonds2,
            SpadesA, SpadesK, SpadesQ, SpadesJ, Spades10, Spades9, Spades8,
            Spades7, Spades6, Spades5, Spades4, Spades3, Spades2,
            ClubsA, ClubsK, ClubsQ, ClubsJ, Clubs10, Clubs9, Clubs8,
            Clubs7, Clubs6, Clubs5, Clubs4, Clubs3, Clubs2
        }

        public static readonly PlayingCardSuit[] PLAYING_CARD_SUITES = {
            PlayingCardSuit.Hearts,
            PlayingCardSuit.Diamonds,
            PlayingCardSuit.Spades,
            PlayingCardSuit.Clubs
        };

        public static readonly PlayingCard[] PLAYING_CARDS = {
            PlayingCard.HeartsA, PlayingCard.HeartsK, PlayingCard.HeartsQ, PlayingCard.HeartsJ, PlayingCard.Hearts10, PlayingCard.Hearts9, PlayingCard.Hearts8,
            PlayingCard.Hearts7, PlayingCard.Hearts6, PlayingCard.Hearts5, PlayingCard.Hearts4, PlayingCard.Hearts3, PlayingCard.Hearts2,
            PlayingCard.DiamondsA, PlayingCard.DiamondsK, PlayingCard.DiamondsQ, PlayingCard.DiamondsJ, PlayingCard.Diamonds10, PlayingCard.Diamonds9, PlayingCard.Diamonds8,
            PlayingCard.Diamonds7, PlayingCard.Diamonds6, PlayingCard.Diamonds5, PlayingCard.Diamonds4, PlayingCard.Diamonds3, PlayingCard.Diamonds2,
            PlayingCard.SpadesA, PlayingCard.SpadesK, PlayingCard.SpadesQ, PlayingCard.SpadesJ, PlayingCard.Spades10, PlayingCard.Spades9, PlayingCard.Spades8,
            PlayingCard.Spades7, PlayingCard.Spades6, PlayingCard.Spades5, PlayingCard.Spades4, PlayingCard.Spades3, PlayingCard.Spades2,
            PlayingCard.ClubsA, PlayingCard.ClubsK, PlayingCard.ClubsQ, PlayingCard.ClubsJ, PlayingCard.Clubs10, PlayingCard.Clubs9, PlayingCard.Clubs8,
            PlayingCard.Clubs7, PlayingCard.Clubs6, PlayingCard.Clubs5, PlayingCard.Clubs4, PlayingCard.Clubs3, PlayingCard.Clubs2
        };

        /// <summary>
        /// Returns a random value from an array with
        /// probability proportional to a given set of
        /// frequencies.
        /// </summary>
        public static T Roll<T>(T[] values, int[] frequencies)
        {
            T[] extendedRange = new T[frequencies.Sum()];

            int length = System.Math.Min(values.Length, frequencies.Length);
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                T value = values[i];
                int frequency = frequencies[i];

                while (--frequency > 0) {
                    extendedRange[count++] = value;
                }
            }

            return extendedRange[UnityEngine.Random.Range(0, extendedRange.Length)];
        }

        /// <summary>
        /// Returns a random number on a 4-sided dice (1-4).
        /// </summary>
        public static int D4() => UnityEngine.Random.Range(1, 5);

        /// <summary>
        /// Returns the sum of rolling a 4-sided dice (1-4), x amount of times.
        /// </summary>
        public static int D4(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D4();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 6-sided dice (1-6).
        /// </summary>
        public static int D6() => UnityEngine.Random.Range(1, 7);

        /// <summary>
        /// Returns the sum of rolling a 6-sided dice (1-6), x amount of times.
        /// </summary>
        public static int D6(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D6();
            return roll;
        }

        /// <summary>
        /// Returns a random number on an 8-sided dice (1-8).
        /// </summary>
        public static int D8() => UnityEngine.Random.Range(1, 9);

        /// <summary>
        /// Returns the sum of rolling an 8-sided dice (1-8), x amount of times.
        /// </summary>
        public static int D8(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D8();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 10-sided dice (1-10).
        /// </summary>
        public static int D10() => UnityEngine.Random.Range(1, 11);

        /// <summary>
        /// Returns the sum of rolling a 10-sided dice (1-10), x amount of times.
        /// </summary>
        public static int D10(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D10();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 12-sided dice (1-12).
        /// </summary>
        public static int D12() => UnityEngine.Random.Range(1, 13);

        /// <summary>
        /// Returns the sum of rolling a 12-sided dice (1-12), x amount of times.
        /// </summary>
        public static int D12(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D12();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a 20-sided dice (1-20).
        /// </summary>
        public static int D20() => UnityEngine.Random.Range(1, 21);

        /// <summary>
        /// Returns the sum of rolling a 20-sided dice (1-20), x amount of times.
        /// </summary>
        public static int D20(int x)
        {
            int roll = 0;
            while (x-- > 0) roll += D20();
            return roll;
        }

        /// <summary>
        /// Returns a random number on a n-sided dice (1-n).
        /// </summary>
        public static int NSidedDiceRoll(int n) => UnityEngine.Random.Range(1, n);

        /// <summary>
        /// Returns the sum of rolling a n-sided dice (1-n), x amount of times.
        /// </summary>
        public static int NSidedDiceRoll(int n, int x)
        {
            int roll = 0;
            while (x-- > 0) roll += NSidedDiceRoll(n);
            return roll;
        }

        /// <summary>
        /// Returns a random number on a dice with custom values.
        /// </summary>
        public static int CustomDiceRoll(int[] values) => values[UnityEngine.Random.Range(0, values.Length)];

        /// <summary>
        /// Returns the sum of rolling a dice with custom values, x amount of times.
        /// </summary>
        public static int CustomDiceRoll(int[] values, int x)
        {
            int roll = 0;
            while (x-- > 0) roll += CustomDiceRoll(values);
            return roll;
        }

        /// <summary>
        /// Returns `true` or `false`, with 50-50 odds.
        /// </summary>
        public static bool RandomBool() => UnityEngine.Random.value < 0.5f;

        /// <summary>
        /// Returns "heads" or "tails", with 50-50 odds.
        /// </summary>
        public static Coin CoinFlip() => UnityEngine.Random.value < 0.5f ? Coin.Heads : Coin.Tails;

        /// <summary>
        /// Returns `1.0f` or `-1.0f`, with 50-50 odds.
        /// </summary>
        public static float PositiveOrNegative() => UnityEngine.Random.value < 0.5f ? 1.0f : -1.0f;

        /// <summary>
        /// Returns -value or +value, with 50-50 odds.
        /// </summary>
        public static float PositiveOrNegative(float value) => UnityEngine.Random.value < 0.5f ? value : -value;

        /// <summary>
        /// Returns "red" or "black", with 50-50 odds.
        /// </summary>
        public static GamblingColor RedBlack() => (UnityEngine.Random.Range(0, 2) == 1) ? GamblingColor.Red : GamblingColor.Black;

        /// <summary>
        /// Returns a random playing card from a standard deck of 52 cards.
        /// </summary>
        public static PlayingCard RandomPlayingCard() => PLAYING_CARDS[UnityEngine.Random.Range(0, 52)];

        /// <summary>
        /// Returns "hearts", "diamonds", "spades", or "clubs", with equal odds.
        /// </summary>
        public static PlayingCardSuit RandomPlayingCardSuite() => PLAYING_CARD_SUITES[UnityEngine.Random.Range(0, 4)];

    }

}
