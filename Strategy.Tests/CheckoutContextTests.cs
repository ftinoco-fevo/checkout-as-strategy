using Moq;
using Strategy.Strategies;

namespace Strategy.Tests
{
    public class CheckoutContextTests
    {
        private Mock<ICheckoutStrategy> _mockCheckoutStrategy;
        private CheckoutContext _checkoutContext;

        [SetUp]
        public void Setup()
        {
            _mockCheckoutStrategy = new Mock<ICheckoutStrategy>();
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
        }
    }
}