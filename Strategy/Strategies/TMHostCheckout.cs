namespace Strategy.Strategies;

public class TMHostCheckout : ICheckoutStrategy, ITMHostCheckoutStrategy
{
    public Task<bool> CanConnect()
    {
        return default!;
    }

    public Task<object> AddBillingInfoAsync()
    {
        return default!;
    }

    public Task<object> PayForOrderAsync()
    {
        return default!;
    }
}