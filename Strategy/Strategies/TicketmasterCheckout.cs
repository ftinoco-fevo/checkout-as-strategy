namespace Strategy.Strategies;

public class TicketmasterCheckout : ICheckoutStrategy
{
    public Task<bool> CanConnect()
    {
        return default!;
    }

    public Task<object> PayForOrderAsync()
    {
        return default!;
    }
}