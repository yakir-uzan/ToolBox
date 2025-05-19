using System;

public class Hammer : Tool
{
    public Hammer(string name, int kg) : base(name, kg){ }

    public override void Describe()
    {
        Console.WriteLine("This is a heavy hammer, perfect for driving nails and construction work");
    }

    public override void Use()
    {
        Console.WriteLine("Hammering nails with force");
    }







}