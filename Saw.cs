using System;

public class Saw : Tool
{
    public Saw(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("A sharp saw, ideal for cutting wood and plastic materials");
    }

    public override void Use()
    {
        Console.WriteLine("Slicing through wood");
    }

}
