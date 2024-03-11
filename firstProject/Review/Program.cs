using System;

string word;
do
{
    Console.WriteLine("Type a word longer than 10 letters");
    word = Console.ReadLine();

}while(word.Length < 10);