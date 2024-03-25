
using System;

Dog cachorro1 = new Dog("Max", 30);
Dog cachorro2 = new Dog("Pog", breed: "Max", weight: 30);

cachorro1.Describe();
cachorro2.Describe();


public class Dog
{
    private string _name;
    private string _breed;
    public int Weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        Weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
    }

    public void Describe() =>
        Console.WriteLine($"Name: {this._name}, Breed: {this._breed}, Weight: {this.Weight}");

}
