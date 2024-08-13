// See https://aka.ms/new-console-template for more information
using Strategy;
using Strategy.Strategies;

CheckoutContext context = new(new TicketmasterCheckout()); 
await context.OrderTicketsAsync();


CheckoutContext context2 = new(new TMHostCheckout());
await context2.OrderTicketsAsync(); 