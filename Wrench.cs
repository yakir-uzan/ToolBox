using System;

public class Wrench : Tool
{
    public Wrench(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("An adjustable wrench, used for tightening and loosening nuts and bolts");
    }

    public override void Use()
    {
        Console.WriteLine("Turning a stubborn bolt");
    }

}

