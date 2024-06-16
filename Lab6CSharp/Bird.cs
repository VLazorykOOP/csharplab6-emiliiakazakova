using Lab6CSharp;
using System.Xml.Linq;

class Bird : Animal, DotNetFeature
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is a bird and can fly.");
    }

    public void UseDotNetFeature()
    {
        Console.WriteLine($"{Name} is using a .NET feature.");
    }
}