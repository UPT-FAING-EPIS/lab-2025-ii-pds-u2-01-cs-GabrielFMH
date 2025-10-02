namespace Bank.Domain
{
    /// <summary>
    /// Defines the contract for credit card types in the banking system.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Gets the type of the credit card (e.g., MoneyBack, Platinum).
        /// </summary>
        /// <returns>The card type as a string.</returns>
        string GetCardType();

        /// <summary>
        /// Gets the credit limit for the card.
        /// </summary>
        /// <returns>The credit limit as an integer.</returns>
        int GetCreditLimit();

        /// <summary>
        /// Gets the annual charge for the card.
        /// </summary>
        /// <returns>The annual charge as an integer.</returns>
        int GetAnnualCharge();
    }
}