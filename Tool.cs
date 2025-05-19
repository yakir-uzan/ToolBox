using System;
using System.Net.NetworkInformation;

public abstract class Tool
{
    public string Name;
    public int Kg;


    public Tool(string name, int kg)
    {
        Name = name;
        Kg = kg;
    }

    public abstract void Describe();

    public abstract void Use();















}
