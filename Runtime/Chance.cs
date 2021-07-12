namespace Zigurous.Math
{
    /// <summary>
    /// Functions for generating random chance values.
    /// </summary>
    public static class Chance
    {
        /// <summary>
        /// The sides of a coin.
        /// </summary>
        public enum Coin { Heads, Tails }

        /// <summary>
        /// The suits of a standard 52-card deck.
        /// </summary>
        public enum Suit { Hearts, Diamonds, Clubs, Spades }

        /// <summary>
        /// The playing cards in a standard 52-card deck.
        /// </summary>
        public enum Card
        {
            HeartsA, HeartsK, HeartsQ, HeartsJ, Hearts10, Hearts9, Hearts8,
            Hearts7, Hearts6, Hearts5, Hearts4, Hearts3, Hearts2,
            DiamondsA, DiamondsK, DiamondsQ, DiamondsJ, Diamonds10, Diamonds9, Diamonds8,
            Diamonds7, Diamonds6, Diamonds5, Diamonds4, Diamonds3, Diamonds2,
            SpadesA, SpadesK, SpadesQ, SpadesJ, Spades10, Spades9, Spades8,
            Spades7, Spades6, Spades5, Spades4, Spades3, Spades2,
            ClubsA, ClubsK, ClubsQ, ClubsJ, Clubs10, Clubs9, Clubs8,
            Clubs7, Clubs6, Clubs5, Clubs4, Clubs3, Clubs2,
            Joker, None,
        }

        /// <summary>
        /// Returns a random playing card suit.
        /// </summary>
        public static Suit RandomSuit()
        {
            return (Suit)UnityEngine.Random.Range(0, 4);
        }

        /// <summary>
        /// Returns a random card from a standard 52-card deck.
        /// </summary>
        public static Card RandomCard()
        {
            return (Card)UnityEngine.Random.Range(0, 52);
        }

        /// <summary>
        /// Returns <c>true</c> or <c>false</c>, with 50-50 odds.
        /// </summary>
        public static bool RandomBool()
        {
            return UnityEngine.Random.value < 0.5f;
        }

        /// <summary>
        /// Returns <c>1.0f</c> or <c>-1.0f</c>, with 50-50 odds.
        /// </summary>
        public static float PositiveOrNegative()
        {
            return UnityEngine.Random.value < 0.5f ? 1.0f : -1.0f;
        }

        /// <summary>
        /// Returns <c>-value</c> or <c>+value</c>, with 50-50 odds.
        /// </summary>
        /// <param name="value">The value to be returned.</param>
        public static float PositiveOrNegative(float value)
        {
            return UnityEngine.Random.value < 0.5f ? value : -value;
        }

        /// <summary>
        /// Returns <c>Heads</c> or <c>Tails</c>, with 50-50 odds.
        /// </summary>
        public static Coin CoinFlip()
        {
            return UnityEngine.Random.value < 0.5f ? Coin.Heads : Coin.Tails;
        }

    }

}
