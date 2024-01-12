namespace Zigurous.Math
{
    /// <summary>
    /// A mathematical sign that can be used to compare two values.
    /// </summary>
    public enum ComparisonSign
    {
        /// <summary>
        /// <c>a == b</c>
        /// </summary>
        Equal,

        /// <summary>
        /// <c>a != b</c>
        /// </summary>
        NotEqual,

        /// <summary>
        /// <c>a &gt; b</c>
        /// </summary>
        GreaterThan,

        /// <summary>
        /// <c>a &gt;= b</c>
        /// </summary>
        GreaterThanOrEqual,

        /// <summary>
        /// <c>a &lt; b</c>
        /// </summary>
        LessThan,

        /// <summary>
        /// <c>a &lt;= b</c>
        /// </summary>
        LessThanOrEqual,
    }

    /// <summary>
    /// Extension methods for <see cref="ComparisonSign"/>.
    /// </summary>
    public static class ComparisonSignExtensions
    {
        /// <summary>
        /// Compares two values using the comparison sign.
        /// </summary>
        /// <typeparam name="T">The type of values to compare.</typeparam>
        /// <param name="sign">The comparison sign.</param>
        /// <param name="a">The first value to compare.</param>
        /// <param name="b">The second value to compare.</param>
        /// <returns>The result of the comparison, either true or false.</returns>
        public static bool Compare<T>(this ComparisonSign sign, T a, T b)
            where T : System.IComparable<T>
        {
            return sign switch
            {
                ComparisonSign.Equal => a.CompareTo(b) == 0,
                ComparisonSign.NotEqual => a.CompareTo(b) != 0,
                ComparisonSign.GreaterThan => a.CompareTo(b) > 0,
                ComparisonSign.GreaterThanOrEqual => a.CompareTo(b) >= 0,
                ComparisonSign.LessThan => a.CompareTo(b) < 0,
                ComparisonSign.LessThanOrEqual => a.CompareTo(b) <= 0,
                _ => false,
            };
        }

    }

}
