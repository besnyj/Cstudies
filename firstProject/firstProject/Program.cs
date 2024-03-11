using System;
using System.CodeDom;
using System.Collections.Generic;


// int result = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     result += numbers[i];
// }
// Console.WriteLine(result);
//
// char[,] letters = new char[2, 3];
//
// letters[0, 0] = 'A';
//
// var letters2 = new char[,]
// {
//     {'A', 'B', 'C'},
//     {'D', 'E', 'F'}
// };
//
// // var x = letters2.GetLength(0);
// // var y = letters2.GetLength(1);
// //
// // for (int i = 0; i < x; i++)
// // {
// //     for (int j = 0; j < y; j++)
// //     {
// //         Console.WriteLine(letters2[i, j]);
// //     }
// // }

// int[] numbers = new int[] { 2, 6, 1, 6, 19};
//
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }
//
// int result = 0;
// foreach (var number in numbers)
// {
//     result += number;
// }
// Console.WriteLine(result);

// List<string> words = new List<string>();
// words.Add("hi");
// words.Add("bye");
// Console.WriteLine(words.Count);
//
// foreach (var word in words)
// {
//     Console.WriteLine(word);
// }


int[] integersArray = new int[10];
var integersArray2 = new[] { 10, 11, 12, 13 };

char[,] characters = new char[2, 2]
{
    { 'a', 'b' },
    { 'c', 'd' }
};

int x = characters.GetLength(0);
int y = characters.GetLength(1);

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.WriteLine(characters[i, j]);
    }
}



