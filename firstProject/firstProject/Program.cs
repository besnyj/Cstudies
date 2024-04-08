using System;

Food tomato = new Tomato("Vegetable", 10);
bool isTomato = tomato is Tomato;
Console.WriteLine(isTomato);
public class Food
{
    public virtual string Name => "This is a food";
    public virtual int Quantity => 0;
    public string Type { get; }

    public Food(string type)
    {
        this.Type = type;
    }

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
}

