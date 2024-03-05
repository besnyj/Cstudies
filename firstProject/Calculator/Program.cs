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



