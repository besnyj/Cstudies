using System;

Food tomato = new Tomato("Vegetable", 10);
int value = 10;




public abstract class Food
{
    public virtual string Name => "This is a food";
    public virtual int Quantity => 0;
    public string Type { get; }

    public Food(string type)
    {
        this.Type = type;
    }

    public abstract void Prepare();
}

public class Tomato : Food
{

    public override int Quantity { get; }

    public Tomato(string type, int quantity) : base(type)
    {
        Quantity = quantity;
    }

    public override string Name => $"Tomato {base.Name}";
    public override string ToString() => Name;

    public override void Prepare()
    {
        Console.WriteLine("Smash");
    }
}

