using Lab6CSharp;
using System.Xml.Linq;
class DotNetUser : UseInterface, DotNetFeature
    {
        public void DisplayUserInfo()
        {
            Console.WriteLine("I am a .NET user.");
        }

        public void UseDotNetFeature()
        {
            Console.WriteLine("Using .NET feature.");
        }
    }