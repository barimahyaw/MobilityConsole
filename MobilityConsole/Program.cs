// See https://aka.ms/new-console-template for more information
using MobilityConsole;

int num1 = 5;
int num2 = 7;
var result = MobilityMath.Multiply(num1, num2);
Console.WriteLine($"Result of {num1} * {num2} = {result}");
Console.ReadLine();