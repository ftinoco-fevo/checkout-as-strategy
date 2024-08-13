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

        try
        {
            await _checkoutStrategy.QueryOrCreateCustomer();
        }
        catch (NotImplementedException)
        {

            Console.WriteLine("QueryOrCreateCustomer is not part of this checkout flow");
        }

        // other steps for order ticket
        if (_checkoutStrategy is ITMHostCheckoutStrategy strategy)
            await strategy.AddBillingInfoAsync();

        return default!;
    }
}