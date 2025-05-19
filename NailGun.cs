using System;

public class NailGun : Tool
{
    public NailGun(string name, int kg) : base(name, kg) { }

    public override void Describe()
    {
        Console.WriteLine("is a pneumatic nail gun for rapid fastening");
    }

    public override void Use()
    {
        Console.WriteLine("Firing nails at high speed...");
    }

}
