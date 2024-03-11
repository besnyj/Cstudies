using System;
using System.Linq;

Console.WriteLine("Welcome to Calculator");
Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Calculation(firstNumber, secondNumber);

void Calculation(int number1, int number2) // void functions wont return anything, using the return keyword will crash the build
{
    Console.WriteLine("What you want to do with these numbers?");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");

    string userChoice = Console.ReadLine();

    switch (userChoice.ToUpper())
    {
        case "A":
            int sum = (number1 + number2);
            ResultInterpolation(number1, number2, "+", sum);
            break;
        case "S":
            int subtraction = (number1 - number2);
            ResultInterpolation(number1, number2, "-", subtraction);
            break;
        case "M":
            int multiplication = (number1 * number2);
            ResultInterpolation(number1, number2, "*", multiplication);
            break;
        default:
            Console.WriteLine("Option not valid");
            break;
    }
}

Console.WriteLine("Press any key to exit");
Console.ReadKey();

void ResultInterpolation(int number1, int number2, string @operator, int result)
{
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}