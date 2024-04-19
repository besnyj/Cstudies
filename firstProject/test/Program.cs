var square = new Square
{
    Height = 10,
    Width = 10,
};

Cube cube = new Cube
{
    Height = 5,
    Width = 5,
    Depth = 5
};

Console.WriteLine(square.GetArea());
Console.WriteLine(cube.GetArea());



public abstract class Shapes
{
    public virtual int Height { get; set; }

    public virtual int Width { get; set; }

    public virtual int Depth { get; set; }

}


public interface ICalculations
{
    public int GetArea();

    public int GetVolume()
    {
        return 0;
    }
}

public class Square : Shapes, ICalculations
{
    public override int Height { get; set; }

    public override int Width { get; set; }

    public int GetArea()
    {
        return this.Height * this.Width;
    }

}

public class Cube : Shapes, ICalculations
{
    public override int Height { get; set; }

    public override int Width { get; set; }

    public override int Depth { get; set; }

    public int GetArea()
    {
        return this.Height * this.Width;
    }

    public int GetVolume()
    {
        return this.Height * this.Width * this.Depth;
    }
}