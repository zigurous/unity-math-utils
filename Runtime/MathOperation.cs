using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// A single operation within a math formula.
    /// </summary>
    [System.Serializable]
    public struct MathOperation<TReference>
    {
        /// <summary>
        /// The type of operation to perform.
        /// </summary>
        [Tooltip("The type of operation to perform.")]
        public MathOperationType type;

        /// <summary>
        /// The left hand side of the operation.
        /// </summary>
        [Tooltip("The left hand side of the operation.")]
        public MathOperationNumber<int, TReference> left;

        /// <summary>
        /// The right hand side of the operation.
        /// </summary>
        [Tooltip("The right hand side of the operation.")]
        public MathOperationNumber<int, TReference> right;

        /// <summary>
        /// The minimum value.
        /// </summary>
        [Tooltip("The minimum value.")]
        public MathOperationNumber<int, TReference> min;

        /// <summary>
        /// The maximum value.
        /// </summary>
        [Tooltip("The maximum value.")]
        public MathOperationNumber<int, TReference> max;

        /// <summary>
        /// The power to raise to.
        /// </summary>
        [Tooltip("The power to raise to.")]
        public MathOperationNumber<int, TReference> power;

        /// <summary>
        /// Stores the result of the operation in a temporary register
        /// (optional).
        /// </summary>
        [Tooltip("Stores the result of the operation in a temporary register (optional).")]
        public MathOperationRegister register;

        /// <summary>
        /// Evaluates the result of performing the operation.
        /// </summary>
        /// <typeparam name="T">The type of dereferencer to use.</typeparam>
        /// <param name="x">The input variable being solved for in the larger expression, e.g., f(x).</param>
        /// <param name="n">The current value of the expression as its being evaluated.</param>
        /// <param name="a">The temporary variable stored in register a.</param>
        /// <param name="b">The temporary variable stored in register b.</param>
        /// <param name="c">The temporary variable stored in register c.</param>
        /// <param name="dereferencer">Dereferences any referenced numbers in the operation.</param>
        /// <returns>The result of performing the operation.</returns>
        public readonly int Evaluate<T>(int x, int n, int a, int b, int c, T dereferencer)
            where T : IMathOperationDereferencer<int, TReference>
        {
            return type switch
            {
                MathOperationType.Add => left.GetValue(x, n, a, b, c, dereferencer) + right.GetValue(x, n, a, b, c, dereferencer),
                MathOperationType.Subtract => left.GetValue(x, n, a, b, c, dereferencer) - right.GetValue(x, n, a, b, c, dereferencer),
                MathOperationType.Multiply => left.GetValue(x, n, a, b, c, dereferencer) * right.GetValue(x, n, a, b, c, dereferencer),
                MathOperationType.Divide => Mathf.FloorToInt(left.GetValue(x, n, a, b, c, dereferencer) / (float)right.GetValue(x, n, a, b, c, dereferencer)),
                MathOperationType.Min => Mathf.Min(n, min.GetValue(x, n, a, b, c, dereferencer)),
                MathOperationType.Max => Mathf.Max(n, max.GetValue(x, n, a, b, c, dereferencer)),
                MathOperationType.Clamp => Mathf.Clamp(n, min.GetValue(x, n, a, b, c, dereferencer), max.GetValue(x, n, a, b, c, dereferencer)),
                MathOperationType.Pow => Mathf.FloorToInt(Mathf.Pow(n, power.GetValue(x, n, a, b, c, dereferencer))),
                MathOperationType.Sqrt => Mathf.FloorToInt(Mathf.Sqrt(n)),
                _ => n,
            };
        }

    }

    /// <summary>
    /// A type of math operation.
    /// </summary>
    public enum MathOperationType
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Min,
        Max,
        Clamp,
        Pow,
        Sqrt,
    }

    /// <summary>
    /// A variable used in a math operation.
    /// </summary>
    public enum MathOperationVariable
    {
        /// <summary>
        /// The input variable being solved for, e.g., f(x).
        /// </summary>
        [Tooltip("The input variable being solved for, e.g., f(x).")]
        [InspectorName("x")]
        x,

        /// <summary>
        /// The current value of the expression as its being evaluated.
        /// </summary>
        [Tooltip("The current value of the expression as its being evaluated.")]
        [InspectorName("n")]
        n,

        /// <summary>
        /// The temporary variable a.
        /// </summary>
        [Tooltip("The temporary variable a.")]
        [InspectorName("a")]
        a,

        /// <summary>
        /// The temporary variable b.
        /// </summary>
        [Tooltip("The temporary variable b.")]
        [InspectorName("b")]
        b,

        /// <summary>
        /// The temporary variable c.
        /// </summary>
        [Tooltip("The temporary variable c.")]
        [InspectorName("c")]
        c,
    }

    /// <summary>
    /// A register to store a temporary variable.
    /// </summary>
    public enum MathOperationRegister
    {
        /// <summary>
        /// Does not use a register.
        /// </summary>
        None,

        /// <summary>
        /// The register to store temporary variable a.
        /// </summary>
        [InspectorName("a")]
        a,

        /// <summary>
        /// The register to store temporary variable b.
        /// </summary>
        [InspectorName("b")]
        b,

        /// <summary>
        /// The register to store temporary variable c.
        /// </summary>
        [InspectorName("c")]
        c,
    }

}
