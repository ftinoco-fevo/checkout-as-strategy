namespace Strategy.Strategies;

public interface ICheckoutStrategy
{
    Task<bool> CanConnect();
    Task<object> PayForOrderAsync();
}