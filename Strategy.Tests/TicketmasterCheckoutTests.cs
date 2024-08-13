using Moq;
using Strategy.Strategies;

namespace Strategy.Tests;

internal class TicketmasterCheckoutTests
{
    private Mock<TicketmasterCheckout> _mockCheckoutStrategy;
    private CheckoutContext _checkoutContext;

    [SetUp]
    public void Setup()
    {
        _mockCheckoutStrategy = new Mock<TicketmasterCheckout>();
        _checkoutContext = new CheckoutContext(_mockCheckoutStrategy.Object);

    }

    [Test]
    public async Task OrderTickets_CallsCheckoutMethodsOfStrategy()
    {
        // Arrange


        // Act
        await _checkoutContext.OrderTicketsAsync();

        // Assert
        _mockCheckoutStrategy.Verify(strategy => strategy.CanConnect(), Times.Once);
        _mockCheckoutStrategy.Verify(strategy => strategy.QueryOrCreateCustomer(), Times.Once);
    } 
}