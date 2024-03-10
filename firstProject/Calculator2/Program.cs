using System;
using System.IO;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with these numbers? ");
Console.WriteLine("[A]dd ");
Console.WriteLine("[S]ubtract ");
Console.WriteLine("[M]ultiply ");

string userChoice = Console.ReadLine();


switch (userChoice.ToUpper())
{
    case "A":
        int sum = (firstNumber + secondNumber);
    StringInterpolation(
        firstNumber, secondNumber, sum, "+");
        break;
    case "S":
        int sub = (firstNumber - secondNumber);
        StringInterpolation(
            firstNumber, secondNumber, sub, "-");
        break;
    case "M":
        int mult = (firstNumber * secondNumber);
        StringInterpolation(
            firstNumber, secondNumber, mult, "*");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

Console.WriteLine("Press any key to leave");
Console.ReadKey();

// removed the testing string

void StringInterpolation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}