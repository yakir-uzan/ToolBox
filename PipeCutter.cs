using System;

public class PipeCutter : Tool
{
    public PipeCutter(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("A pipe cutter that ensures clean cuts on metal and plastic pipes");
    }

    public override void Use()
    {
        Console.WriteLine("Cutting a pipe smoothly");
    }

}

