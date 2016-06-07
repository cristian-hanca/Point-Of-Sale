namespace Models
{
    /// <summary>
    ///     Possible Order Statuses.
    ///     Expressed in a Final State Automata style.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        ///     Order Created.
        ///     Initial State.
        /// </summary>
        Created,
        /// <summary>
        ///     Order Finalized and sent to Payment.
        ///     Intermediary State.
        /// </summary>
        Invoiced,
        /// <summary>
        ///     Order Payed.
        ///     Final Success State.
        /// </summary>
        Payed,
        /// <summary>
        ///     Payment or Invoice canceled.
        ///     Final Fail State.
        /// </summary>
        Canceled
    }
}