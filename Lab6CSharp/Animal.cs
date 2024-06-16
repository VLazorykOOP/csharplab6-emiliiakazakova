namespace Lab6CSharp
{
    class Animal : UseInterface
    {
        public string Name { get; set; }

        public void DisplayUserInfo()
        {
            Console.WriteLine($"I am an animal. My name is {Name}");
        }
    }
}