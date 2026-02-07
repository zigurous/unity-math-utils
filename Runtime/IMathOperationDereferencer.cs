namespace Zigurous.Math
{
    /// <summary>
    /// A type that can dereference values from a reference key.
    /// </summary>
    /// <typeparam name="TValue">The type of value.</typeparam>
    /// <typeparam name="TReference">The type of reference key.</typeparam>
    public interface IMathOperationDereferencer<TValue, TReference>
    {
        /// <summary>
        /// Gets the value for the given key.
        /// </summary>
        /// <param name="key">The key to get the value of.</param>
        /// <returns>The value for the given key.</returns>
        TValue GetValue(TReference key);
    }

}
