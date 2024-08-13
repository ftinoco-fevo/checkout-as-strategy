namespace Strategy.Strategies;

internal interface ITMHostCheckoutStrategy
{
    Task<object> AddBillingInfoAsync();
}