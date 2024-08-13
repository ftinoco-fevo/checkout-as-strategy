namespace Strategy.Strategies;

public interface ICheckoutStrategy
{
    Task<bool> CanConnect();
    Task<object> QueryOrCreateCustomer()
    {
        // Default logic or throw NotImplementedException
        throw new NotImplementedException();
    } 
}
