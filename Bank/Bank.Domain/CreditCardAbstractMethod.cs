namespace Bank.Domain
{
    /// <summary>
    /// Abstract base class for credit card factory methods, implementing the Factory Method pattern.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Abstract method to create a specific credit card product.
        /// </summary>
        /// <returns>An instance of <see cref="ICreditCard"/>.</returns>
        protected abstract ICreditCard MakeProduct();

        /// <summary>
        /// Creates and returns a credit card product using the factory method.
        /// </summary>
        /// <returns>The created <see cref="ICreditCard"/> instance.</returns>
        public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object
            ICreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}