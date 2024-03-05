using System;

Console.WriteLine("Hello!");

Console.WriteLine("Input the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine(Calculator(firstNumber, secondNumber));

string Calculator(int a, int b)
{
    Console.WriteLine("What do you want to do with those numbers?");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");

    string userChoice = Console.ReadLine();

    if (userChoice == "A" || userChoice == "a")
    {
        return a.ToString() + "+" + b.ToString() + "=" + (a + b).ToString();
    }
    else if(userChoice == "S" || userChoice == "s")
    {
        return a.ToString() + "-" + b.ToString() + "=" + (a - b).ToString();
    }
    else if (userChoice == "M" || userChoice == "m")
    {
        return a.ToString() + "*" + b.ToString() + "=" + (a * b).ToString();
    }
    return "Invalid option";
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

// Professor Solution -=-=-=-=-=-=-=-=-=-=-

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number: ");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var choice = Console.ReadLine();

if (choice == "A" || choice == "a")
{
    var sum = number1 + number2;
    Console.WriteLine(
        number1 + "+" + number2 + "=" + sum);
}
// repeats the above code block with else if statements
// for the rest of the options

Console.WriteLine("Press any key to close");
Console.ReadKey();

