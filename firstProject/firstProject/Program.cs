using System;
using System.Collections.Generic;

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
Console.WriteLine(pizza.Describe());
Cheddar cheese = new Cheddar();
cheese.PublicMethod();



public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    protected void Working() => Console.WriteLine("Working");
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class. ";
}

public class Cheddar : Ingredient
{
    void Teste() => Working();
}