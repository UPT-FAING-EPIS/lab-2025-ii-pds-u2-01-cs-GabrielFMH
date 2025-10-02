namespace Bank.Domain
{
    /// <summary>
    /// Represents a Titanium credit card, providing balanced benefits and limits.
    /// Implements the <see cref="ICreditCard"/> interface.
    /// </summary>
    public class Titanium : ICreditCard
    {
        /// <summary>
        /// Gets the type of the credit card.
        /// </summary>
        /// <returns>The card type "Titanium Edge".</returns>
        public string GetCardType()
        {
            return "Titanium Edge";
        }

        /// <summary>
        /// Gets the credit limit for the Titanium card.
        /// </summary>
        /// <returns>The credit limit of 25000.</returns>
        public int GetCreditLimit()
        {
            return 25000;
        }

        /// <summary>
        /// Gets the annual charge for the Titanium card.
        /// </summary>
        /// <returns>The annual charge of 1500.</returns>
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}