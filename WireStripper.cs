using System;

public class WireStripper : Tool
{
    public WireStripper(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("is a wire stripper used to remove insulation from electrical wires");
    }

    public override void Use()
    {
        Console.WriteLine("Stripping wire insulation...");
    }

}
