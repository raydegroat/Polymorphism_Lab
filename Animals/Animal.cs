using System;

public class Animal
{

    public string name { get; protected set; }
    public string favoriteFood { get; protected set; }

    protected Animal(string name, string favoriteFood)
    {
        this.name = name;
        this.favoriteFood = favoriteFood;
    }

    public virtual string ExplainSelf()
    {
        return ($"I am {this.name} and my favorite food is {this.favoriteFood}");
    }
}

