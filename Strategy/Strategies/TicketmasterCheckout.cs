namespace Strategy.Strategies
{
    public class TicketmasterCheckout : ICheckoutStrategy
    {
        public Task<bool> CanConnect()
        {
            return default!;
        }

        public async Task<object> QueryOrCreateCustomer()
        {
            return default!;
        }
    }
}