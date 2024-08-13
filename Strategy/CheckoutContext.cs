using Strategy.Strategies;

namespace Strategy;

public class CheckoutContext
{
    private readonly ICheckoutStrategy _checkoutStrategy;

    public CheckoutContext(ICheckoutStrategy checkoutStrategy)
    {
        _checkoutStrategy = checkoutStrategy;
    }

    public async Task<object> OrderTicketsAsync()
    {
        await _checkoutStrategy.CanConnect();
         
        // TODO: Execute specific logic 
        if (_checkoutStrategy is ITMHostCheckoutStrategy strategy)
            await strategy.AddBillingInfoAsync();

        // TODO: Other steps for order ticket

        await _checkoutStrategy.PayForOrderAsync();

        return default!;
    }
}