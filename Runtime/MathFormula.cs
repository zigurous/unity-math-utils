using UnityEngine;

namespace Zigurous.Math
{
    /// <summary>
    /// A serializable math formula constructed within the editor.
    /// </summary>
    [System.Serializable]
    public struct MathFormula<TReference>
    {
        /// <summary>
        /// Evaluates the formula as a summation for the provided range.
        /// </summary>
        [Tooltip("Evaluates the formula as a summation for the provided range.")]
        public bool summation;

        /// <summary>
        /// The starting index of the summation.
        /// </summary>
        [Tooltip("The starting index of the summation.")]
        public int summationMin;

        /// <summary>
        /// The final index of the summation.
        /// </summary>
        [Tooltip("The final index of the summation.")]
        public int summationMax;

        /// <summary>
        /// The operations performed in order when the formula is evaluated.
        /// </summary>
        [Tooltip("The operations performed in order when the formula is evaluated.")]
        public MathOperation<TReference>[] operations;

        /// <summary>
        /// Evaluates the value of <paramref name="x"/> using the formula.
        /// </summary>
        /// <param name="x">The input variable to solve for.</param>
        /// <param name="dereferencer">Dereferences any referenced numbers in the formula.</param>
        /// <returns>The evaluated value f(<paramref name="x"/>).</returns>
        public readonly int Evaluate<T>(int x, T dereferencer)
            where T : IMathOperationDereferencer<int, TReference>
        {
            if (summation) {
                return Summation(x, summationMin, summationMax, dereferencer);
            } else {
                return Eval(x, dereferencer);
            }
        }

        /// <summary>
        /// Evaluates the value of <paramref name="x"/> using the formula as a
        /// summation in the provided range.
        /// </summary>
        /// <param name="x">The input variable to solve for.</param>
        /// <param name="start">The starting index of the summation.</param>
        /// <param name="end">The final index of the summation.</param>
        /// <param name="dereferencer">Dereferences any referenced numbers in the formula.</param>
        /// <returns>The evaluated summation ∑(<paramref name="x"/>).</returns>
        public readonly int Summation<T>(int x, int start, int end, T dereferencer)
            where T : IMathOperationDereferencer<int, TReference>
        {
            int sum = default;
            int min = start;
            int max = Mathf.Clamp(x, start, end);

            for (int k = min; k <= max; k++) {
                sum += Eval(k, dereferencer);
            }

            return sum;
        }

        private readonly int Eval<T>(int x, T dereferencer)
            where T : IMathOperationDereferencer<int, TReference>
        {
            int n = 0, a = 0, b = 0, c = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i].register)
                {
                    case MathOperationRegister.a:
                        a = operations[i].Evaluate(x, n, a, b, c, dereferencer);
                        break;
                    case MathOperationRegister.b:
                        b = operations[i].Evaluate(x, n, a, b, c, dereferencer);
                        break;
                    case MathOperationRegister.c:
                        c = operations[i].Evaluate(x, n, a, b, c, dereferencer);
                        break;
                    default:
                        n = operations[i].Evaluate(x, n, a, b, c, dereferencer);
                        break;
                }
            }

            return n;
        }

    }

}
