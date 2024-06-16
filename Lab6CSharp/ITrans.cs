using Lab6CSharp;
using System.Xml.Linq;
interface ITrans : DotNetFeature
{
    void DisplayInfo();
    int CargoCapacity { get; }
}