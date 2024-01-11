// See https://aka.ms/new-console-template for more information

using OpenClosed;

Console.WriteLine("Hello, World!");

//Bir nesne .......gelişime..... AÇIK .......değişime...... KAPALI olmalıdır. 
Customer customer = new Customer() { Card = new PremiumType() };
OrderManagement orderManagement = new OrderManagement() { Customer = customer };
var payment = orderManagement.GetDiscountedPrice(1000);
Console.WriteLine(payment);
