namespace Models
{
    /// <summary>
    ///     Possible Order Types.
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        ///     Normal Orders have only Positive Quantities.
        /// </summary>
        Normal,

        /// <summary>
        ///     Return Orders have only Negative Quantities.
        /// </summary>
        Return,

        /// <summary>
        ///     Exchange Orders have both Positive and Negative Quantities.
        /// </summary>
        Exchange
    }
}