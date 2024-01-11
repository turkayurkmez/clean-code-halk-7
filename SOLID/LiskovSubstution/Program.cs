// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");
var rect = new Geometry().CreateRectangle(5, 10);
//rect.Width = 100;
//rect.Height = 15;
Console.WriteLine(rect.GetArea());