namespace Bank.Domain
{
    /// <summary>
    /// Represents a MoneyBack credit card, which provides cashback rewards.
    /// Implements the <see cref="ICreditCard"/> interface.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Gets the type of the credit card.
        /// </summary>
        /// <returns>The card type "MoneyBack".</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }

        /// <summary>
        /// Gets the credit limit for the MoneyBack card.
        /// </summary>
        /// <returns>The credit limit of 15000.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }

        /// <summary>
        /// Gets the annual charge for the MoneyBack card.
        /// </summary>
        /// <returns>The annual charge of 500.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}