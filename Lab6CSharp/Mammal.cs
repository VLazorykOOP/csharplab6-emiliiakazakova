using Lab6CSharp;
using System.Xml.Linq;

class Mammal : Animal, DotNetFeature
{
    public void GiveBirth()
    {
        Console.WriteLine($"{Name} is a mammal and gives birth to live young.");
    }

    public void UseDotNetFeature()
    {
        Console.WriteLine($"{Name} is using a .NET feature.");
    }
}