using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// A number used in a math operation, either a constant, a variable, or a
    /// referenced value.
    /// </summary>
    /// <typeparam name="TValue">The underlying type of number, e.g., int, float, double.</typeparam>
    /// <typeparam name="TReference">The type of key used to reference values.</typeparam>
    [System.Serializable]
    public struct MathOperationNumber<TValue, TReference>
    {
        /// <summary>
        /// The type of number.
        /// </summary>
        [Tooltip("The type of number.")]
        public MathOperationNumberType type;

        /// <summary>
        /// The variable to use.
        /// </summary>
        [Tooltip("The variable to use.")]
        public MathOperationVariable variable;

        /// <summary>
        /// The number reference to use.
        /// </summary>
        [Tooltip("The number reference to use.")]
        public TReference reference;

        /// <summary>
        /// The constant number to use.
        /// </summary>
        [Tooltip("The constant number to use.")]
        public TValue constant;

        /// <summary>
        /// Gets the value of the number depending on its type.
        /// </summary>
        /// <typeparam name="T">The type of dereferencer to use.</typeparam>
        /// <param name="x">The input variable being solved for in the larger expression, e.g., f(x).</param>
        /// <param name="n">The current value of the expression as its being evaluated.</param>
        /// <param name="a">The temporary variable stored in register a.</param>
        /// <param name="b">The temporary variable stored in register b.</param>
        /// <param name="c">The temporary variable stored in register c.</param>
        /// <param name="dereferencer">Dereferences any referenced numbers.</param>
        /// <returns>The value of the number.</param>
        public readonly TValue GetValue<T>(TValue x, TValue n, TValue a, TValue b, TValue c, T dereferencer)
            where T : IMathOperationDereferencer<TValue, TReference>
        {
            return type switch
            {
                MathOperationNumberType.Constant => constant,
                MathOperationNumberType.Reference => dereferencer.GetValue(reference),
                MathOperationNumberType.Variable => variable switch {
                    MathOperationVariable.x => x,
                    MathOperationVariable.n => n,
                    MathOperationVariable.a => a,
                    MathOperationVariable.b => b,
                    MathOperationVariable.c => c,
                    _ => default,
                },
                _ => default,
            };
        }

    }

    /// <summary>
    /// A type of number used in a math operation.
    /// </summary>
    public enum MathOperationNumberType
    {
        Constant,
        Variable,
        Reference,
    }

}
