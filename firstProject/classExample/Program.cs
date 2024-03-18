using System;

Rectangle rectangle1 = new Rectangle(10, 10);
var calculator = new ShapesMeasurementsCalculator();
Console.WriteLine(calculator.CalculateRectangleArea(rectangle1));

class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class ShapesMeasurementsCalculator
{
    public int CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }

}