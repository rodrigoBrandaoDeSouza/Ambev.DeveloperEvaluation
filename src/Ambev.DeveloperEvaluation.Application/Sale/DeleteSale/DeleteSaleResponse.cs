namespace Ambev.DeveloperEvaluation.Application.Sale.DeleteSale
{
    /// <summary>
    /// Result returned after attempting to delete a sale.
    /// </summary>
    /// <remarks>
    /// This result provides feedback about whether the sale was successfully deleted
    /// and includes the identifier of the affected sale.
    /// </remarks>
    public class DeleteSaleResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the sale that was targeted for deletion.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sale was successfully deleted.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets a descriptive message indicating the result of the operation.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
