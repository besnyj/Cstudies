

using System;


bool isParsingSuccessful;
do
{
    Console.WriteLine("Digite um");
    string numero = Console.ReadLine();

    isParsingSuccessful = int.TryParse(numero, out int number);

} while (isParsingSuccessful == false);

