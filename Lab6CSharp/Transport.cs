class Transport : ITrans
{
    public string Brand { get; set; }
    public string Number { get; set; }
    public int Speed { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Number: {Number}, Speed: {Speed}");
    }

    public virtual int CargoCapacity
    {
        get { return 0; }
    }

    public void UseDotNetFeature()
    {
        Console.WriteLine($"Using .NET feature for {Brand}");
    }
}