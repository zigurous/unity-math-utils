using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// Represents how a number is abbreviated to a string.
    /// </summary>
    [System.Serializable]
    public struct NumberAbbreviation
    {
        /// <summary>
        /// An abbreviation for numbers in the thousands.
        /// </summary>
        public static NumberAbbreviation Thousands => new NumberAbbreviation(1_000, "0K");

        /// <summary>
        /// An abbreviation for numbers in the millions.
        /// </summary>
        public static NumberAbbreviation Millions => new NumberAbbreviation(1_000_000, "0M");

        /// <summary>
        /// An abbreviation for numbers in the billions.
        /// </summary>
        public static NumberAbbreviation Billions => new NumberAbbreviation(1_000_000_000, "0B");

        /// <summary>
        /// An abbreviation for numbers in the trillions.
        /// </summary>
        public static NumberAbbreviation Trillions => new NumberAbbreviation(1_000_000_000_000, "0T");

        /// <summary>
        /// A predefined set of common number abbreviations.
        /// </summary>
        public static readonly NumberAbbreviation[] Common = new NumberAbbreviation[4] {
            Trillions,
            Billions,
            Millions,
            Thousands,
        };

        /// <summary>
        /// The number factor after which the abbreviation is applied.
        /// </summary>
        [Tooltip("The number factor after which the abbreviation is applied.")]
        public double factor;

        /// <summary>
        /// The string format of the abbreviated number.
        /// </summary>
        [Tooltip("The string format of the abbreviated number.")]
        public string format;

        /// <summary>
        /// Creates a new number abbreviation with the given
        /// <paramref name="factor"/> and <paramref name="format"/>.
        /// </summary>
        /// <param name="factor">The number factor after which the abbreviation is applied.</param>
        /// <param name="format">The string format of the abbreviated number.</param>
        public NumberAbbreviation(double factor, string format)
        {
            this.factor = factor;
            this.format = format;
        }

        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number.</returns>
        public string Format(int number)
        {
            return (number / this.factor).ToString(this.format);
        }

        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number.</returns>
        public string Format(float number)
        {
            return (number / this.factor).ToString(this.format);
        }

        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number.</returns>
        public string Format(double number)
        {
            return (number / this.factor).ToString(this.format);
        }

    }

    /// <summary>
    /// Extensions methods for <see cref="NumberAbbreviation"/>.
    /// </summary>
    public static class NumberAbbreviationExtensions
    {
        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number, or the number as a string if it cannot be abbreviated.</returns>
        public static string Format(this NumberAbbreviation[] abbreviations, int number)
        {
            int abs = System.Math.Abs(number);

            for (int i = 0; i < abbreviations.Length; i++)
            {
                NumberAbbreviation abbreviation = abbreviations[i];

                if (abs >= abbreviation.factor) {
                    return abbreviation.Format(number);
                }
            }

            return number.ToString();
        }

        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number, or the number as a string if it cannot be abbreviated.</returns>
        public static string Format(this NumberAbbreviation[] abbreviations, float number)
        {
            float abs = System.Math.Abs(number);

            for (int i = 0; i < abbreviations.Length; i++)
            {
                NumberAbbreviation abbreviation = abbreviations[i];

                if (abs >= abbreviation.factor) {
                    return abbreviation.Format(number);
                }
            }

            return number.ToString();
        }

        /// <summary>
        /// Abbreviates the given <paramref name="number"/> to a string.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>A new string of the abbreviated number, or the number as a string if it cannot be abbreviated.</returns>
        public static string Format(this NumberAbbreviation[] abbreviations, double number)
        {
            double abs = System.Math.Abs(number);

            for (int i = 0; i < abbreviations.Length; i++)
            {
                NumberAbbreviation abbreviation = abbreviations[i];

                if (abs >= abbreviation.factor) {
                    return abbreviation.Format(number);
                }
            }

            return number.ToString();
        }

    }

}
