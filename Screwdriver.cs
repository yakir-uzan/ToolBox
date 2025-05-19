using System;

public class Screwdriver : Tool
{
    public Screwdriver(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("A flathead screwdriver designed for driving and removing screws");
    }

    public override void Use()
    {
        Console.WriteLine("Tightening a screw");
    }

}

