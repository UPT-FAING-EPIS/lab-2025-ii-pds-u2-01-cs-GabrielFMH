namespace Bank.Domain
{
    /// <summary>
    /// Represents a Platinum credit card, offering premium benefits and higher limits.
    /// Implements the <see cref="ICreditCard"/> interface.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Gets the type of the credit card.
        /// </summary>
        /// <returns>The card type "Platinum Plus".</returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }

        /// <summary>
        /// Gets the credit limit for the Platinum card.
        /// </summary>
        /// <returns>The credit limit of 35000.</returns>
        public int GetCreditLimit()
        {
            return 35000;
        }

        /// <summary>
        /// Gets the annual charge for the Platinum card.
        /// </summary>
        /// <returns>The annual charge of 2000.</returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}