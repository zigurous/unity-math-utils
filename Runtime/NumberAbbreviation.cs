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
        /// An abbreviation for numbers in the thousands (Read only).
        /// </summary>
        public static NumberAbbreviation thousands => new NumberAbbreviation(1_000, "0K");

        /// <summary>
        /// An abbreviation for numbers in the millions (Read only).
        /// </summary>
        public static NumberAbbreviation millions => new NumberAbbreviation(1_000_000, "0M");

        /// <summary>
        /// An abbreviation for numbers in the billions (Read only).
        /// </summary>
        public static NumberAbbreviation billions => new NumberAbbreviation(1_000_000_000, "0B");

        /// <summary>
        /// An abbreviation for numbers in the trillions (Read only).
        /// </summary>
        public static NumberAbbreviation trillions => new NumberAbbreviation(1_000_000_000_000, "0T");

        /// <summary>
        /// A predefined set of common number abbreviations (Read only).
        /// </summary>
        public static readonly NumberAbbreviation[] common = new NumberAbbreviation[4] {
            trillions,
            billions,
            millions,
            thousands,
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
        /// Creates a new number abbreviation with a given factor and format.
        /// </summary>
        /// <param name="factor">The number factor after which the abbreviation is applied.</param>
        /// <param name="format">The string format of the abbreviated number.</param>
        public NumberAbbreviation(double factor, string format)
        {
            this.factor = factor;
            this.format = format;
        }

        /// <summary>
        /// Abbreviates a number to a string.
        /// </summary>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string.</returns>
        public string Format(double number)
        {
            return (number / factor).ToString(format);
        }

    }

    /// <summary>
    /// Extension methods for <see cref="NumberAbbreviation"/>.
    /// </summary>
    public static class NumberAbbreviationExtensions
    {
        /// <summary>
        /// Abbreviates a number to a string with the given set of abbreviations.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
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
        /// Abbreviates a number to a string with the given set of abbreviations.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
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

        /// <summary>
        /// Abbreviates a number to a string with the given set of abbreviations.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
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
        /// Abbreviates a number to a string with the given set of abbreviations.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string Format(this NumberAbbreviation[] abbreviations, short number)
        {
            short abs = System.Math.Abs(number);

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
        /// Abbreviates a number to a string with the given set of abbreviations.
        /// </summary>
        /// <param name="abbreviations">The possible abbreviations to apply.</param>
        /// <param name="number">The number to abbreviate.</param>
        /// <returns>The number abbreviated as a string, or the number as a string if no abbreviations apply.</returns>
        public static string Format(this NumberAbbreviation[] abbreviations, long number)
        {
            long abs = System.Math.Abs(number);

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
