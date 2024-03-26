using System;

Square square1 = new Square(10, 10);
Console.WriteLine(square1.Height);
square1.NumberOfSides = 10;


class Square
{
    public readonly int Height;
    private readonly int Width;
    public readonly int NumberOfSides;

    public Square(int height, int width)
    {
        Height = height;
        Width = width;
        NumberOfSides = 4;
    }
}