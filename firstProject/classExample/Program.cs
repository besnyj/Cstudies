using System;

GeometricShapes square = new GeometricShapes(10, 10);
GeometricShapes cube = new GeometricShapes(10, 10, 10);

Console.WriteLine(square.Shape());
Console.WriteLine(cube.Shape());


class GeometricShapes
{
    private int _length;
    private int _height;
    private int _depth;

    public GeometricShapes(int length, int height)
    {
        _length = length;
        _height = height;
    }

    public GeometricShapes(int length, int height, int depth)
    {
        _length = length;
        _height = height;
        _depth = depth;
    }

    public string Shape()
    {
        if (_depth == 0)
        {
            return "Square";
        }

        return "Cube";
    }
}