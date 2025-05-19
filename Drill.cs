using System;

public class Drill : Tool
{
    public Drill(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("A high-speed drill suitable for making precise holes in wood and metal");
    }

    public override void Use()
    {
        Console.WriteLine("Drilling holes rapidly");
    }
}



