﻿using System;
using System.Collections;
using System.Collections.Generic;


Square square1 = new Square(10, 10);

var calculation = Square.CalculateArea(10, 10);
Console.WriteLine(calculation);

bool testEvenOrNot;
int perimeter = Square.AmountOfSides();



class Square
{
    private int _width;
    public int Height { get; }

    public Square(int height, int width)
    {
        Height = height;
        _width = width;
    }



    public static int CalculateArea(int x, int y) => x * y;

    public static int AmountOfSides() => 4;
}

