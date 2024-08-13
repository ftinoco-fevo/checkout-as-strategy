namespace Strategy.Strategies
{
    public class TMHostCheckout : ICheckoutStrategy, ITMHostCheckoutStrategy
    {
        public Task<object> AddBillingInfoAsync()
        {
            return default!;
        }

        public Task<bool> CanConnect()
        {
            return default!;
        }
    }
}