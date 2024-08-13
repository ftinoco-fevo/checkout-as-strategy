// See https://aka.ms/new-console-template for more information
using Strategy;
using Strategy.Strategies;

CheckoutContext cartService = new(new TicketmasterCheckout()); 
var result = await cartService.OrderTicketsAsync();
